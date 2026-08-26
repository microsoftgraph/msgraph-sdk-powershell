# Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
<#
    Shared derivation of the wrapper module population and of the wrapper build policy.

    The generator, the build/pack orchestrator and the wiring validator must agree on exactly
    which modules exist for an API version, or the validator ends up grading a population it
    invented rather than the one that was built. The rule lives here once, so it cannot drift
    the way tools/UpdateOpenApi.ps1's private WindowsUpdates exclusion drifted from every other
    consumer of the same mapping file.
#>

<#
    The modules configured for an API version.

    This reproduces the rule the AutoRest production path already applies, rather than
    inventing a second one: tools/GenerateModules.ps1 enumerates the KEYS of
    config/ModulesMapping.jsonc, and tools/GenerateServiceModule.ps1 then generates a key only
    when openApiDocs/<ApiVersion>/<Module>.yml exists. A module with no document for this
    version (the beta-only workloads) is therefore not part of the version's population, and a
    document with no mapping key (DeviceManagement.Actions, removed from the mapping in
    659db09e81 for producing duplicate cmdlets) is not either.

    Returns the names sorted, so every caller compares the same ordering.
#>
Function Get-WrapperModuleSet {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateSet('v1.0', 'beta')]
        [string] $ApiVersion,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $ModuleMappingConfigPath,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $RepoRoot
    )

    if (-not (Test-Path $ModuleMappingConfigPath)) {
        throw "Module mapping file not found: $ModuleMappingConfigPath."
    }

    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath -Raw | ConvertFrom-Json -AsHashTable
    $OpenApiPath = Join-Path $RepoRoot 'openApiDocs' $ApiVersion

    $Modules = @($ModuleMapping.Keys | Where-Object {
            Test-Path (Join-Path $OpenApiPath "$_.yml")
        } | Sort-Object)

    if ($Modules.Count -eq 0) {
        throw "No modules are configured for '$ApiVersion': no key in $ModuleMappingConfigPath has a document under $OpenApiPath."
    }

    return $Modules
}

<#
    The target framework the wrapper projects compile to.

    Read out of config/Wrapper.Build.props - the file the projects themselves import - so that
    a script locating build output under bin/<Configuration>/<TargetFramework> cannot disagree
    with where the compiler actually wrote it.
#>
Function Get-WrapperTargetFramework {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $WrapperPropsPath
    )

    if (-not (Test-Path $WrapperPropsPath)) {
        throw "Wrapper build properties not found: $WrapperPropsPath."
    }

    $TargetFramework = ([xml](Get-Content $WrapperPropsPath -Raw)).Project.PropertyGroup.WrapperTargetFramework |
        Where-Object { $_ } | Select-Object -First 1

    if (-not $TargetFramework) {
        throw "WrapperTargetFramework is not set in $WrapperPropsPath."
    }

    return "$TargetFramework".Trim()
}

<#
    Builds the assemblies every wrapper project references, before any parallel fan-out.

    Each wrapper project has a ProjectReference to Microsoft.Graph.Authentication, which itself
    references Microsoft.Graph.Authentication.Core. Left to themselves, N concurrent module
    builds each try to produce those same outputs, and several csc processes open one dll for
    writing: CS2012, on whichever modules happen to collide, differing run to run.

    Authentication.Core is built explicitly and FIRST because it multi-targets. Building
    Authentication alone only drives its own netstandard2.0 flavour of Core, while the net10.0
    wrapper projects resolve Core's net6.0 reference assembly - so the flavour the wrappers
    actually need would still be produced concurrently by the workers. Building Core directly
    builds every one of its target frameworks, leaving nothing for the fan-out to write.
#>
Function Build-WrapperSharedDependency {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $RepoRoot,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $Configuration
    )

    $Projects = @(
        Join-Path $RepoRoot 'src\Authentication\Authentication.Core\Microsoft.Graph.Authentication.Core.csproj'
        Join-Path $RepoRoot 'src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj'
    )

    foreach ($Project in $Projects) {
        $Output = & dotnet build $Project -c $Configuration --nologo -v quiet 2>&1
        if ($LASTEXITCODE -ne 0) {
            $Output | ForEach-Object { Write-Host $_ }
            throw "Failed to build '$Project'; every wrapper module references it."
        }
    }
}

<#
    The wrapper module name for a service module, e.g. Mail -> Microsoft.Graph.Wrapper.Mail.

    The prefix distinguishes these from the AutoRest-generated Microsoft.Graph.<Module>, so both
    can be imported into one session while the wrapper work is in preview.
#>
Function Get-WrapperModuleName {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $Module
    )

    return "Microsoft.Graph.Wrapper.$Module"
}

<#
    The repository-owned source folder for one wrapper module and API version.
#>
Function Get-WrapperModuleSourcePath {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $RepoRoot,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $Module,
        [Parameter(Mandatory = $true)]
        [ValidateSet('v1.0', 'beta')]
        [string] $ApiVersion
    )

    return Join-Path $RepoRoot 'src' $Module $ApiVersion 'wrapper'
}
