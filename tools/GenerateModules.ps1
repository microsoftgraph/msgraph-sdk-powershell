# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

[CmdletBinding()]
Param(
    [string[]] $ModuleToGenerate = @(),
    [ValidateSet("v1.0", "beta")]
    $ApiVersion = @("v1.0", "beta"),
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
    [switch] $SkipGeneration = $false,
    [switch] $Build,
    [switch] $Test,
    [switch] $Pack,
    [switch] $EnableSigning,
    [switch] $ExcludeExampleTemplates,
    [switch] $ExcludeNotesSection,
    [switch] $Isolated
)
$ErrorActionPreference = 'Stop'

if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (-not $Isolated) {
    Write-Debug 'Creating isolated process...'
    $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
    & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
    return
}

# Module import.
Import-Module PowerShellGet


$ScriptRoot = $PSScriptRoot
$ModulesSrc = Join-Path $ScriptRoot "..\src\"
$ModuleMappingPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc")
$GenerateServiceModulePS1 = Join-Path $ScriptRoot ".\GenerateServiceModule.ps1" -Resolve

if (-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory | Out-Null
}

if (-not (Test-Path $ModuleMappingPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingPath."
}

# Ensure the Node build tools (rush + autorest) are available so 'npx --no-install' can resolve them.
# In Azure DevOps these are installed at the repo root by install-tools.yml, so this check is a no-op there.
# On a fresh local clone they are missing, so we bootstrap them here using the same versions as CI.
$RepoRoot = (Resolve-Path (Join-Path $ScriptRoot "..")).Path

# Fail fast if the autorest.powershell git submodule has not been initialized.
$AutoRestPowerShellPath = Join-Path $RepoRoot "autorest.powershell"
$RushConfigPath = Join-Path $AutoRestPowerShellPath "rush.json"
if (-not (Test-Path $RushConfigPath)) {
    throw "The 'autorest.powershell' submodule is not initialized ('$RushConfigPath' not found). Run 'git submodule update --init --recursive' from the repository root, then re-run this script."
}

$NodeBinPath = Join-Path $RepoRoot "node_modules" ".bin"
$RushInstalled = (Test-Path (Join-Path $NodeBinPath "rush")) -or (Test-Path (Join-Path $NodeBinPath "rush.cmd"))
$AutoRestInstalled = (Test-Path (Join-Path $NodeBinPath "autorest")) -or (Test-Path (Join-Path $NodeBinPath "autorest.cmd"))
if (-not ($RushInstalled -and $AutoRestInstalled)) {
    Write-Host "Node build tools not found at '$RepoRoot'. Installing rush and autorest..."
    Push-Location $RepoRoot
    try {
        npm install --no-package-lock '@microsoft/rush' 'autorest@3.7.2' '@autorest/core@3.10.4'
        if ($LASTEXITCODE -ne 0) {
            throw "Command 'npm install' for Node build tools (rush, autorest) failed with exit code $LASTEXITCODE."
        }
    }
    finally {
        Pop-Location
    }
}

# Build AutoREST.PowerShell submodule.
Set-Location (Join-Path $ScriptRoot "../autorest.powershell")
npx --no-install rush install
if ($LASTEXITCODE -ne 0) {
    throw "Command 'npx --no-install rush install' failed with exit code $LASTEXITCODE."
}

npx --no-install rush build
if ($LASTEXITCODE -ne 0) {
    throw "Command 'npx --no-install rush build' failed with exit code $LASTEXITCODE."
}

# Diagnostic: show autorest cache state and npm registry config before generation.
# Gated behind ENABLE_AUTOREST_DIAGNOSTICS to avoid npm calls in network-isolated release pipelines.
if ($env:ENABLE_AUTOREST_DIAGNOSTICS) {
    Write-Host "--- Autorest/npm diagnostics ---"
    $autorestHome = if ($env:AUTOREST_HOME) { $env:AUTOREST_HOME } else { Join-Path $env:USERPROFILE ".autorest" }
    Write-Host "AUTOREST_HOME: $autorestHome"
    $coreCacheDir = Join-Path $autorestHome "@autorest\core"
    if (Test-Path $coreCacheDir) {
        Write-Host "Autorest core cache versions: $(Get-ChildItem $coreCacheDir -Directory | Select-Object -ExpandProperty Name)"
        $nodeModulesDir = Join-Path $coreCacheDir "3.10.4\node_modules\@autorest\core"
        Write-Host "Cache 3.10.4 node_modules present: $(Test-Path $nodeModulesDir)"
    } else {
        Write-Host "WARNING: Autorest core cache directory not found at $coreCacheDir"
    }
    $modelerfourCacheDir = Join-Path $autorestHome "@autorest\modelerfour"
    if (Test-Path $modelerfourCacheDir) {
        Write-Host "Autorest modelerfour cache versions: $(Get-ChildItem $modelerfourCacheDir -Directory | Select-Object -ExpandProperty Name)"
        $modelerfourNodeModules = Join-Path $modelerfourCacheDir "4.24.3\node_modules\@autorest\modelerfour"
        Write-Host "Cache modelerfour 4.24.3 node_modules present: $(Test-Path $modelerfourNodeModules)"
    } else {
        Write-Host "WARNING: Autorest modelerfour cache directory not found at $modelerfourCacheDir"
    }
    Write-Host "npm registry: $(npm config get registry 2>&1)"
    Write-Host "npm_config_registry env: $env:npm_config_registry"
    Write-Host "NPM_CONFIG_USERCONFIG: $env:NPM_CONFIG_USERCONFIG"
    $userNpmrc = Join-Path $env:USERPROFILE ".npmrc"
    Write-Host "~/.npmrc exists: $(Test-Path $userNpmrc)"
    if (Test-Path $userNpmrc) {
        Write-Host "~/.npmrc registry line: $(Select-String -Path $userNpmrc -Pattern '^registry=' | Select-Object -First 1 -ExpandProperty Line)"
    }
    Write-Host "--- End diagnostics ---"
} else {
    Write-Host "Autorest diagnostics skipped (set ENABLE_AUTOREST_DIAGNOSTICS=1 to enable)"
}

$RequiredGraphModules = @()
$AuthModuleManifest = Join-Path $ModulesSrc "Authentication" "Authentication" "artifacts" "Microsoft.Graph.Authentication.psd1"
$LoadedAuthModule = Import-Module $AuthModuleManifest -PassThru -ErrorAction SilentlyContinue
if ($null -ne $LoadedAuthModule) {
    $RequiredGraphModules += @{ ModuleName = $LoadedAuthModule.Name ; RequiredVersion = $LoadedAuthModule.Version; PreRelease = $LoadedAuthModule.PrivateData.PSData.PreRelease }
}
else {
    Write-Warning "Module not found in $AuthModuleManifest."
}
if ($ModuleToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingPath | ConvertFrom-Json -AsHashTable
    $ModuleToGenerate = $ModuleMapping.Keys
}

#This is to ensure that the autorest temp folder is cleared before generating the modules
$TempPath = [System.IO.Path]::GetTempPath()
# Check if there is any folder with autorest in the name
$AutoRestTempFolder = Get-ChildItem -Path $TempPath -Recurse -Directory | Where-Object { $_.Name -match "autorest" }

# Go through each folder and forcefully delete autorest related files
$AutoRestTempFolder | ForEach-Object {
    $AutoRestTempFolder = $_
    #Delete files and folders if they exist
    if (Test-Path $AutoRestTempFolder.FullName) {
        #Check if each file in the folder exists
        Get-ChildItem -Path $AutoRestTempFolder.FullName -Recurse | ForEach-Object {
            $File = $_
            Write-Debug "Removing cached file $File"
            if (Test-Path $File.FullName) {
                #Remove the file
                Remove-Item -Path $File.FullName -Force -confirm:$false
            }
        }
    }
}

$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$CpuCount = (Get-CimInstance Win32_Processor | Measure-Object -Property NumberOfLogicalProcessors -Sum).Sum
$Throttle = [int][math]::Max(1, [math]::Min(2, $CpuCount / 2))  # Use half the CPU count but max 2, min 1
$Results = $ModuleToGenerate | ForEach-Object -Parallel {
    $Module = $_
    Write-Host -ForegroundColor Green "-------------'Generating $Module'-------------"

    $ServiceModuleParams = @{
        Module                  = $Module
        ModulesSrc              = $using:ModulesSrc
        ApiVersion              = $using:ApiVersion
        SkipGeneration          = $using:SkipGeneration
        Build                   = $using:Build
        Test                    = $using:Test
        Pack                    = $using:Pack
        EnableSigning           = $using:EnableSigning
        ExcludeExampleTemplates = $using:ExcludeExampleTemplates
        ExcludeNotesSection     = $using:ExcludeNotesSection
        ArtifactsLocation       = $using:ArtifactsLocation
        RequiredModules         = $using:RequiredGraphModules
    }

    try {
        $Result = & $using:GenerateServiceModulePS1 @ServiceModuleParams

        # Check if the script returned an exit code (failure)
        if ($null -ne $Result -and $Result -is [int] -and $Result -ne 0) {
            Write-Host -ForegroundColor Red "Failed to generate module '$Module' with exit code $Result"
            return @{ Module = $Module; Success = $false; ExitCode = $Result; Error = "Generation or build failed" }
        }

        # Also check $LASTEXITCODE in case the script didn't return but set exit code
        if ($null -ne $LASTEXITCODE -and $LASTEXITCODE -ne 0) {
            Write-Host -ForegroundColor Red "Failed to generate module '$Module' with exit code $LASTEXITCODE"
            return @{ Module = $Module; Success = $false; ExitCode = $LASTEXITCODE; Error = "Generation or build failed" }
        }

        function Get-OpenFiles {
            param (
                [string] $Path
            )
            $OpenFiles = @()
            $Files = Get-ChildItem -Path $Path -Recurse -Directory | Where-Object { $_.Name -match "autorest" }
            $Files | ForEach-Object {
                $File = $_
                try {
                    $FileStream = $File.Open([System.IO.FileMode]::Open, [System.IO.FileAccess]::ReadWrite, [System.IO.FileShare]::None)
                    $FileStream.Close()
                }
                catch {
                    $OpenFiles += $File.FullName
                }
            }
            return $OpenFiles
        }
        #Call a function to check if there are any open files in the temp folder. Recurse through the folder until all files are closed
        $OpenFiles = Get-OpenFiles -Path $using:TempPath
        if ($OpenFiles.Count -gt 0) {
            $OpenFiles = Get-OpenFiles -Path $using:TempPath
        }

        return @{ Module = $Module; Success = $true; ExitCode = 0; Error = $null }
    }
    catch {
        Write-Host -ForegroundColor Red "Exception while generating module '$Module': $_"
        return @{ Module = $Module; Success = $false; ExitCode = -1; Error = $_.Exception.Message }
    }
} -ThrottleLimit $Throttle
$stopwatch.Stop()

# Check if any modules failed to generate
$FailedModules = $Results | Where-Object { -not $_.Success }
if ($FailedModules.Count -gt 0) {
    Write-Host ""
    Write-Host -ForegroundColor Red "========================================="
    Write-Host -ForegroundColor Red "Failed to generate the following modules:"
    Write-Host -ForegroundColor Red "========================================="
    $FailedModules | ForEach-Object {
        Write-Host -ForegroundColor Red "  - $($_.Module) (Exit Code: $($_.ExitCode)) - $($_.Error)"
    }
    Write-Host -ForegroundColor Red "========================================="
    Write-Host ""
    Write-Error "Module generation failed. $($FailedModules.Count) of $($ModuleToGenerate.Count) module(s) failed to generate."
}
else {
    Write-Host -ForegroundColor Green "All modules generated successfully in '$($Stopwatch.Elapsed.TotalMinutes)' minutes."
}
