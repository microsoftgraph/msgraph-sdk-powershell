# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

[CmdletBinding()]
Param(
    [string] $Module,
    [string] $ModulesSrc,
    [ValidateSet("v1.0", "beta")]
    $ApiVersion = @("v1.0", "beta"),
    [switch] $SkipGeneration = $false,
    [switch] $Build,
    [switch] $Test,
    [switch] $Pack,
    [switch] $EnableSigning,
    [switch] $ExcludeExampleTemplates,
    [switch] $ExcludeNotesSection
)

# Set NODE max heap size to 32 Gb. This is assuming the VM has this memory.
$MaxMemorySize = 32768
$ENV:NODE_OPTIONS = "--max-old-space-size=$MaxMemorySize"

$ScriptRoot = $PSScriptRoot
$ModulePrefix = "Microsoft.Graph"
$OpenApiPath = Join-Path $ScriptRoot "..\openApiDocs"
$TemplatePath = Join-Path $ScriptRoot "\Templates\"
$ModuleMetadataPath = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json"
[HashTable] $ModuleMetadata = Get-Content $ModuleMetadataPath | ConvertFrom-Json -AsHashTable

# PS Scripts
$ManageGeneratedModulePS1 = Join-Path $ScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$BuildModulePS1 = Join-Path $ScriptRoot ".\BuildModule.ps1" -Resolve
$TestModulePS1 = Join-Path $ScriptRoot ".\TestModule.ps1" -Resolve
$PackModulePS1 = Join-Path $ScriptRoot ".\PackModule.ps1" -Resolve
$CleanUpPsm1 = Join-Path $ScriptRoot "\PostGeneration\CleanUpPsm1.ps1" -Resolve

$ModulePath = Join-Path $ModulesSrc $Module
$ModuleConfig = Join-Path $ModulePath "\$Module.md"

. (Join-Path $ScriptRoot "\Utilities\FileUtils.ps1")
Copy-ModuleTemplate -Destination $ModuleConfig -TemplatePath (Join-Path $TemplatePath "module.md") -ModuleName $Module

$ApiVersion | ForEach-Object {
    $CurrentApiVersion = $_
    $OpenApiFile = Join-Path $OpenApiPath $CurrentApiVersion "$Module.yml"
    if (Test-Path $OpenApiFile) {
        Write-Host -ForegroundColor Green "-------------[$CurrentApiVersion]-------------"
        $NamespacePrefix = ($CurrentApiVersion -eq "beta" ? "$ModulePrefix.Beta" : $ModulePrefix)
        $ModuleFullName = "$NamespacePrefix.$Module"
        $ModuleProjectPath = Join-Path $ModulePath $CurrentApiVersion

        $AutoRestModuleConfig = Join-Path $ModuleProjectPath "\readme.md"
        Copy-ModuleTemplate -Destination $AutoRestModuleConfig -TemplatePath (Join-Path $ScriptRoot "\Templates\readme$CurrentApiVersion.md") -ModuleName $Module

        if ($null -eq $ModuleMetadata.versions[$CurrentApiVersion].version) {
            Write-Error "Version number is not set for $ModuleFullName module. Please set 'version' in $ModuleMetadataPath."
        }

        if ($SkipGeneration) {
            Write-Warning "Skipping generation of '$ModuleFullName - $CurrentApiVersion' module."
        }
        else {
            if ($ModuleMetadata.versions[$CurrentApiVersion].prerelease) {
                $FullModuleVersion = "$($ModuleMetadata.versions[$CurrentApiVersion].version)-$($ModuleMetadata.versions[$CurrentApiVersion].prerelease)"
            }
            else {
                $FullModuleVersion = $ModuleMetadata.versions[$CurrentApiVersion].version
            }
            npx autorest --max-memory-size=$MaxMemorySize --module-version:$FullModuleVersion --module-name:$ModuleFullName --service-name:$Module --input-file:$OpenApiFile $AutoRestModuleConfig
            if ($LastExitCode -ne 0) {
                Write-Host -ForegroundColor Red "AutoREST failed to generate '$ModuleFullName' module."
                exit $LastExitCode
            }
            Write-Debug "AutoRest generated '$ModuleFullName' successfully."

            # Manage generated module.
            Write-Debug "Managing '$ModuleFullName' module..."
            & $ManageGeneratedModulePS1 -ModuleName $ModuleFullName -ModuleSrc $ModuleProjectPath -NamespacePrefix $NamespacePrefix
        }

        if ($Build) {
            # Build generated module.
            & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -RequiredModules $RequiredGraphModules -EnableSigning:$EnableSigning -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection -Version $ModuleMetadata.versions[$CurrentApiVersion].version -Prerelease $ModuleMetadata.versions[$CurrentApiVersion].prerelease -ModuleMetadata $ModuleMetadata.Clone()
            & $CleanUpPsm1 -ModuleProjectPath $ModuleProjectPath -FullyQualifiedModuleName $ModuleFullName
            if ($LastExitCode -ne 0) {
                Write-Host -ForegroundColor Red "Failed to build '$ModuleFullName' module."
                exit $LastExitCode
            }
        }

        if ($Test) {
            & $TestModulePS1 -ModulePath $ModuleProjectPath -ModuleName $ModuleFullName -ModuleTestsPath (Join-Path $ModuleProjectPath "test")
        }

        if ($Pack) {
            & $PackModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -Module $Module -ArtifactsLocation $ArtifactsLocation -ExcludeMarkdownDocsFromNugetPackage
        }
    }
}