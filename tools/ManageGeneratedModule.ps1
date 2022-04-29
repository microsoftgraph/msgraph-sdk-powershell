# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Manages generated modules by managing dependencies and configuring authentication.

.PARAMETER Module
The name of the module to manage.
#>
Param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string]$ModuleName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string]$ModuleSrc,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ApiVersion
)
$NugetPackagesToAdd = @("hyak.common")
$NugetPackagesToRemove = @("Microsoft.CSharp")
$AuthenticationProj = Join-Path $PSScriptRoot "..\src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj"
$ModuleCsProj = Join-Path $ModuleSrc "$ModuleName.csproj"
$CustomCodePath = Join-Path $PSScriptRoot "\Custom\"

# if(-not (Test-Path "$GeneratedModuleSlnDir\$Module.sln")) {
#     # Create new solution for generated module project.
#     Write-Host -ForegroundColor Green "Executing: dotnet new sln -n $Module -o $GeneratedModuleSlnDir --force"
#     dotnet new sln -n $Module -o $GeneratedModuleSlnDir --force
#     if($LASTEXITCODE){
#         Write-Error "Failed to create or update $Module solution."
#         return
#     }
# }
# $GeneratedModuleSln = Join-Path $GeneratedModuleSlnDir "$Module.sln"

# # Add generated module project to solution.
# Write-Host -ForegroundColor Green "Executing: dotnet sln $GeneratedModuleSln add $GeneratedModuleProj"
# dotnet sln $GeneratedModuleSln add $GeneratedModuleProj
# if($LASTEXITCODE){
#     Write-Error "Failed to execute: dotnet sln $GeneratedModuleSln add $GeneratedModuleProj"
#     return
# }

# Add authentication project reference to generated module reference.
Write-Debug "Executing: dotnet add $ModuleCsProj reference $AuthenticationProj"
dotnet add $ModuleCsProj reference $AuthenticationProj | Out-Null
if($LastExitCode){
    Write-Error "Failed to execute: dotnet add $ModuleCsProj reference $AuthenticationProj"
}

# Copy custom code to generated module.
foreach($CustomFile in (Get-ChildItem $CustomCodePath -Recurse)) {
    Write-Debug "Copying $CustomFile to $ModuleSrc\custom"
    Copy-Item -Path $CustomFile -Destination "$ModuleSrc\custom"
}

# Remove unnecessary packages from generate modules.
foreach($Package in $NugetPackagesToRemove)
{
    Write-Debug "Executing: dotnet remove $ModuleCsProj package $Package"
    dotnet remove $ModuleCsProj package $Package | Out-Null
    if($LastExitCode){
        Write-Error "Failed to execute: dotnet remove $ModuleCsProj package $Package"
    }
}

# Add nuget packages from generate modules.
foreach($Package in $NugetPackagesToAdd)
{
    Write-Debug "Executing: dotnet add $ModuleCsProj package $Package"
    dotnet add $ModuleCsProj package $Package | Out-Null
    if($LastExitCode){
        Write-Error "Failed to execute: dotnet add $ModuleCsProj package $Package"
    }
}

# Restore packages.
# Write-Host -ForegroundColor Green "Executing: dotnet restore $GeneratedModuleSln"
# dotnet restore $GeneratedModuleSln
# if($LASTEXITCODE){
#     Write-Error "Failed to execute: dotnet restore $GeneratedModuleSln"
#     return
# }