# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Manages generated modules by managing dependencies and configuring authentication.

.PARAMETER Module
The name of the module to manage.
#>
Param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string]$Module,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ModuleNamespace,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $GraphVersion
)
$NugetPackagesToRemove = "Microsoft.CSharp"
$AuthenticationProj = Join-Path $PSScriptRoot "..\src\Authentication\Authentication\Microsoft.Graph.Authentication.csproj"
$GeneratedModuleSlnDir = Join-Path $PSScriptRoot "..\src\$GraphVersion\$Module"
$GeneratedModuleProj = Join-Path  $GeneratedModuleSlnDir "$Module\$ModuleNamespace.$Module.csproj"
$CustomCodeDir = Join-Path $PSScriptRoot "\Custom\"

if(-not (Test-Path "$GeneratedModuleSlnDir\$Module.sln")) {
    # Create new solution for generated module project.
    Write-Host -ForegroundColor Green "Executing: dotnet new sln -n $Module -o $GeneratedModuleSlnDir --force"
    dotnet new sln -n $Module -o $GeneratedModuleSlnDir --force
}

# Add generated module project to solution.
Write-Host -ForegroundColor Green "Executing: dotnet sln $GeneratedModuleSlnDir\$Module.sln add $GeneratedModuleProj"
dotnet sln "$GeneratedModuleSlnDir\$Module.sln" add $GeneratedModuleProj
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: "dotnet sln $GeneratedModuleSlnDir\$Module.sln add $GeneratedModuleProj""
    return
}

# Add authentication project reference to generated module reference.
Write-Host -ForegroundColor Green "Executing: dotnet add $GeneratedModuleProj reference $AuthenticationProj"
dotnet add $GeneratedModuleProj reference $AuthenticationProj
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: dotnet add $GeneratedModuleProj reference $AuthenticationProj"
    return
}

# Copy custom code to generated module.
$CustomFiles = Get-ChildItem $CustomCodeDir -Recurse
foreach($CustomFile in $CustomFiles) {
    Write-Host -ForegroundColor Green "Copying $CustomFile to $GeneratedModuleSlnDir\$Module\custom"
    Copy-Item -Path $CustomFile -Destination "$GeneratedModuleSlnDir\$Module\custom"
}

# Remove unnecessary packages from generate modules.
foreach($Package in $NugetPackagesToRemove)
{
    Write-Host -ForegroundColor Green "Executing: dotnet remove $GeneratedModuleProj package $Package"
    dotnet remove $GeneratedModuleProj package $Package
    if($LastExitCode -ne 0){
        Write-Warning "Failed to execute: dotnet remove $GeneratedModuleProj package $Package"
    }
}

# Restore packages.
Write-Host -ForegroundColor Green "Executing: dotnet restore $GeneratedModuleSlnDir\$Module.sln"
dotnet restore "$GeneratedModuleSlnDir\$Module.sln"
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: dotnet restore $GeneratedModuleSlnDir\$Module.sln"
    return
}
Write-Host -ForegroundColor Green "-------------Done-------------"