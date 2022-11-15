# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Manages generated modules by managing dependencies and configuring authentication.

.PARAMETER Module
The name of the module to manage.
#>
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string]$ModuleName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string]$ModuleSrc,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $NamespacePrefix
)
$NugetPackagesToAdd = @("Hyak.Common")
$NugetPackagesToRemove = @("Microsoft.CSharp")
$AuthenticationProj = Join-Path $PSScriptRoot "..\src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj"
$ModuleCsProj = Join-Path $ModuleSrc "$ModuleName.csproj"
$CustomCodePath = Join-Path $PSScriptRoot "\Custom\"

# Add authentication project reference to generated module reference.
Write-Debug "Executing: dotnet add $ModuleCsProj reference $AuthenticationProj"
dotnet add $ModuleCsProj reference $AuthenticationProj | Out-Null
if ($LastExitCode) {
    Write-Error "Failed to execute: dotnet add $ModuleCsProj reference $AuthenticationProj"
}

# Copy custom code to generated module.
foreach ($customFile in (Get-ChildItem $CustomCodePath -Recurse)) {
    Write-Debug "Copying $customFile to $ModuleSrc\custom"
    # Resolve namespaces.
    $fileContent = Get-Content $customFile
    $fileContent = $fileContent.Replace("NamespacePrefixPlaceholder", $NamespacePrefix);
    $fileContent | Out-File (Join-Path $ModuleSrc "custom" $customFile.Name)
}

# Remove unnecessary packages from generate modules.
foreach ($Package in $NugetPackagesToRemove) {
    Write-Debug "Executing: dotnet remove $ModuleCsProj package $Package"
    dotnet remove $ModuleCsProj package $Package | Out-Null
    if ($LastExitCode) {
        Write-Error "Failed to execute: dotnet remove $ModuleCsProj package $Package"
    }
}

# Add nuget packages from generate modules.
foreach ($Package in $NugetPackagesToAdd) {
    Write-Debug "Executing: dotnet add $ModuleCsProj package $Package"
    dotnet add $ModuleCsProj package $Package -s https://api.nuget.org/v3/index.json | Out-Null
    if ($LastExitCode) {
        Write-Error "Failed to execute: dotnet add $ModuleCsProj package $Package"
    }
}
