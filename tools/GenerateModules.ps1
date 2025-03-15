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

# Install Powershell-yaml
if (!(Get-Module -Name powershell-yaml -ListAvailable)) {
    Install-Module powershell-yaml -Repository PSGallery -Scope CurrentUser -Force
}

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

# Build AutoREST.PowerShell submodule.
Set-Location (Join-Path $ScriptRoot "../autorest.powershell")
rush update --purge
rush build

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
                #Remove-Item -Path $File.FullName -Force -confirm:$false
            }
        }
    }
}

#Delete any file in temp folder with the extension .tmp or .log or .db
Get-ChildItem -Path $TempPath -Recurse | Where-Object { $_.Extension -match ".tmp|.log|.db" } | ForEach-Object {
    $File = $_
    Write-Debug "Removing cached file $File"
    if (Test-Path $File.FullName) {
        #Remove the file
        #Remove-Item -Path $File.FullName -Force -confirm:$false
    }
}
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$CpuCount = (Get-CimInstance Win32_Processor).NumberOfLogicalProcessors
$Throttle = [math]::Min(4, $cpuCount / 2)  # Use half the CPU count but max 4
$ModuleToGenerate | ForEach-Object -Parallel {
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
    & $using:GenerateServiceModulePS1 @ServiceModuleParams
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
    $OpenFiles = Get-OpenFiles -Path $TempPath
    if ($OpenFiles.Count -gt 0) {
        $OpenFiles = Get-OpenFiles -Path $TempPath
    }
    
    #Delete any file in temp folder with the extension .tmp or .log or .db
    Get-ChildItem -Path $TempPath -Recurse | Where-Object { $_.Extension -match ".tmp|.log|.db|.db-shm|.db-wal" } | ForEach-Object {
        $File = $_
        Write-Debug "Removing cached file $File"
        if (Test-Path $File.FullName) {
            #Remove the file
            try{
                #Remove-Item -Path $File.FullName -Force -confirm:$false
            }
            catch {
                Write-Warning "Failed to remove file $File"
            }
        }
    }


} -ThrottleLimit $Throttle
$stopwatch.Stop()

Write-Host -ForegroundColor Green "Generated SDK in '$($Stopwatch.Elapsed.TotalMinutes)' minutes."
