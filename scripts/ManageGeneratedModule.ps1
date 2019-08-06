# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Manages generated modules by managing dependencies and configuring authentication.

.PARAMETER Module
The name of the module to manage.
#>
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string]$Module
)

$nugetPackagesToRemove = "Microsoft.CSharp"
$commonProjDir = ".\src\Common\Common"
$moduleSlnDir = ".\src\$Module"
$moduleProj = "$moduleSlnDir\$Module\Graph.$Module.csproj"

# Create new solution for generated module project.
Write-Host -ForegroundColor Green "Executing: dotnet new sln -n $Module -o $moduleSlnDir --force"
dotnet new sln -n $Module -o $moduleSlnDir --force

# Add generated module project and common project to solution.
Write-Host -ForegroundColor Green "Executing: dotnet sln $moduleSlnDir\$Module.sln add $moduleProj"
dotnet sln "$moduleSlnDir\$Module.sln" add $moduleProj
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: 'dotnet sln $moduleSlnDir\$Module.sln add $moduleProj'"
    return
}

# Add common project reference to generated module reference.
Write-Host -ForegroundColor Green "Executing: dotnet add $moduleProj reference $commonProjDir\Common.csproj"
dotnet add $moduleProj reference "$commonProjDir\Common.csproj"
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: 'dotnet add $moduleProj reference $commonProjDir\Common.csproj'"
    return
}

# Copy custom templates from common to generated module.
$customTemplates = Get-ChildItem "$commonProjDir\Templates\" -Recurse
foreach($customTemplate in $customTemplates) {
    Write-Host -ForegroundColor Green "Coping $customTemplate from $commonProjDir\Templates to $moduleSlnDir\$Module\custom"
    Copy-Item -Path $customTemplate -Destination "$moduleSlnDir\$Module\custom"
}

# Remove unnecessary packages from generate modules.
foreach($package in $nugetPackagesToRemove)
{
    Write-Host -ForegroundColor Green "Executing: dotnet remove $moduleProj package $package"
    dotnet remove $moduleProj package $package
    if($LastExitCode -ne 0){
        Write-Error "Failed to execute: 'dotnet remove $moduleProj package $package'"
        return
    }
}

# Restore packages.
Write-Host -ForegroundColor Green "Executing: dotnet restore $moduleSlnDir\$Module.sln"
dotnet restore "$moduleSlnDir\$Module.sln"
if($LastExitCode -ne 0){
    Write-Error "Failed to execute: 'dotnet restore $moduleSlnDir\$Module.sln'"
    return
}