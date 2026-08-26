# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.SYNOPSIS
Generates, builds and packs every Kiota wrapper module configured for an API version.

.DESCRIPTION
The wrapper counterpart of tools/GenerateModules.ps1, and deliberately the same shape: derive
the population from config/ModulesMapping.jsonc, fan out across modules, and fail with a named
list rather than a count. tools/Build-WrapperModule.ps1 is the per-module worker, the way
GenerateServiceModule.ps1 is for the AutoRest modules.

What it does NOT share with GenerateModules.ps1 is the autorest/rush bootstrap: wrapper modules
are compiled from committed sources under src/<Module>/<ApiVersion>/wrapper/, so building them
needs only the .NET SDK. kiota is required to REGENERATE those sources (-Generate), never to
compile or pack them.

Modules that generate a Kiota client but emit no cmdlets are reported by name and do not fail
the run. There is nothing to compile or ship for them, and which modules those are is measured
each run from what the generator emitted - never a list maintained by hand, which would keep
excusing a module after the generator learned to handle its shape.

.PARAMETER ModuleToGenerate
Restrict the run to these modules. Default: every module configured for -ApiVersion.

.PARAMETER ApiVersion
v1.0 (default) or beta.

.PARAMETER Generate
Re-run kiota and the wrapper generator, overwriting the committed sources under
src/<Module>/<ApiVersion>/wrapper/. Requires the kiota CLI. Omit to compile what is committed.

.PARAMETER Build
Compile each module.

.PARAMETER Pack
Produce a package per module under <ArtifactsLocation>/<Module>/.

.EXAMPLE
.\tools\GenerateWrapperModules.ps1 -Build

.EXAMPLE
.\tools\GenerateWrapperModules.ps1 -Generate -Build -Pack -Configuration Release
#>
[CmdletBinding()]
Param(
    [string[]] $ModuleToGenerate = @(),
    [ValidateSet('v1.0', 'beta')]
    [string] $ApiVersion = 'v1.0',
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot '..\artifacts\'),
    [string] $Configuration = 'Release',
    [string] $ModuleMappingConfigPath,
    [switch] $Generate,
    [switch] $Build,
    [switch] $Pack
)

$ErrorActionPreference = 'Stop'

if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute.'
}

$ScriptRoot = $PSScriptRoot
$RepoRoot = (Resolve-Path (Join-Path $ScriptRoot '..')).Path
if (-not $ModuleMappingConfigPath) { $ModuleMappingConfigPath = Join-Path $RepoRoot 'config\ModulesMapping.jsonc' }
$BuildWrapperModulePS1 = Join-Path $ScriptRoot 'Build-WrapperModule.ps1' -Resolve

. (Join-Path $ScriptRoot 'Utilities\WrapperModuleSet.ps1')

if (-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory | Out-Null
}

if ($ModuleToGenerate.Count -eq 0) {
    $ModuleToGenerate = Get-WrapperModuleSet -ApiVersion $ApiVersion -ModuleMappingConfigPath $ModuleMappingConfigPath -RepoRoot $RepoRoot
}

Write-Host -ForegroundColor Green "$($ModuleToGenerate.Count) module(s) configured for $ApiVersion."

$Stopwatch = [System.Diagnostics.Stopwatch]::StartNew()

if ($Build -or $Pack) {
    # Serially, before any fan-out: see Build-WrapperSharedDependency for why concurrent module
    # builds otherwise race over the shared Authentication outputs.
    Write-Host -ForegroundColor Green 'Building shared Authentication assemblies before fan-out...'
    Build-WrapperSharedDependency -RepoRoot $RepoRoot -Configuration $Configuration
}

# Same throttle policy as GenerateModules.ps1: half the logical processors, capped at 4. Each
# worker runs dotnet and (when generating) kiota, so oversubscribing makes the run slower, not
# faster, and kiota's memory use on the larger specs is what sets the ceiling.
$CpuCount = [System.Environment]::ProcessorCount
$Throttle = [int][math]::Max(1, [math]::Min(4, $CpuCount / 2))

$Results = $ModuleToGenerate | ForEach-Object -Parallel {
    $Module = $_
    Write-Host -ForegroundColor Green "-------------'$Module'-------------"

    $WorkerParams = @{
        Module            = $Module
        ApiVersion        = $using:ApiVersion
        Configuration     = $using:Configuration
        ArtifactsLocation = $using:ArtifactsLocation
        Pack              = $using:Pack
        # Built once, serially, above - the workers must not each try to reproduce it.
        SharedDependencyBuilt = $true
        # Without -Generate nothing is regenerated at all: the committed sources are compiled
        # as they are. That is what lets a clean checkout build with only the .NET SDK, and it
        # keeps a build from leaving the working tree dirty.
        SkipGeneration    = -not $using:Generate
    }

    try {
        $Output = & $using:BuildWrapperModulePS1 @WorkerParams *>&1 | Out-String
        $ExitCode = $LASTEXITCODE

        # The worker prints one "OK: n cmdlets -> <psd1>" line per module it completed, and
        # "FAILED at <stage>: <reason>" otherwise. Parsing its own report keeps this script from
        # re-deriving success from the filesystem, where a stale artifact reads as a pass.
        $Ok = [regex]::Match($Output, 'OK: (\d+) cmdlets ->')
        $NoCmdlets = $Output -match 'no cmdlets emitted'
        $Failure = [regex]::Match($Output, 'FAILED at ([\w-]+): (.*)')

        if ($Ok.Success) {
            return @{ Module = $Module; Status = 'OK'; CmdletCount = [int]$Ok.Groups[1].Value; Reason = $null }
        }
        if ($NoCmdlets) {
            return @{ Module = $Module; Status = 'NO-CMDLETS'; CmdletCount = 0; Reason = 'generator emitted no cmdlets for this spec' }
        }
        return @{ Module = $Module; Status = 'FAILED'; CmdletCount = 0
            Reason = if ($Failure.Success) { "$($Failure.Groups[1].Value): $($Failure.Groups[2].Value.Trim())" } else { "exit $ExitCode" } }
    }
    catch {
        return @{ Module = $Module; Status = 'FAILED'; CmdletCount = 0; Reason = $_.Exception.Message }
    }
} -ThrottleLimit $Throttle

$Stopwatch.Stop()

$Succeeded = @($Results | Where-Object { $_.Status -eq 'OK' })
$NoCmdlets = @($Results | Where-Object { $_.Status -eq 'NO-CMDLETS' })
$Failed = @($Results | Where-Object { $_.Status -eq 'FAILED' })

Write-Host ''
Write-Host -ForegroundColor Green "$($Succeeded.Count) module(s) produced $(($Succeeded | Measure-Object -Property CmdletCount -Sum).Sum) cmdlets in $([math]::Round($Stopwatch.Elapsed.TotalMinutes, 1)) minutes."

if ($NoCmdlets.Count -gt 0) {
    # Named, never silently dropped: a shrinking population must be visible in the run output,
    # otherwise "all modules built" stops meaning anything.
    Write-Host -ForegroundColor DarkYellow "$($NoCmdlets.Count) module(s) emitted no cmdlets and produced no module:"
    $NoCmdlets | ForEach-Object { Write-Host -ForegroundColor DarkYellow "  - $($_.Module)" }
}

if ($Failed.Count -gt 0) {
    Write-Host ''
    Write-Host -ForegroundColor Red '========================================='
    Write-Host -ForegroundColor Red 'Failed modules:'
    Write-Host -ForegroundColor Red '========================================='
    $Failed | ForEach-Object { Write-Host -ForegroundColor Red "  - $($_.Module): $($_.Reason)" }
    Write-Host -ForegroundColor Red '========================================='
    Write-Error "Wrapper module generation failed. $($Failed.Count) of $($ModuleToGenerate.Count) module(s) failed."
}
