# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

# .\ManageGeneratedModules.ps1 -tag "me.userActivity"
Param(
    [string]$tag
)

# Remove unnecessary nuget packages from generated project.
$nugetPackagesToRemove = "Microsoft.CSharp"

$commonProjDir = ".\src\Common\Common"
$moduleSlnDir = ".\src\$tag"
$moduleProj = "$moduleSlnDir\$tag\$tag.csproj"

# Create new solution for generated module project.
Write-Host -ForegroundColor Green "Executing: dotnet new sln -n $tag -o $moduleSlnDir --force"
dotnet new sln -n $tag -o $moduleSlnDir --force

# Add generated module project and common project to solution.
Write-Host -ForegroundColor Green "Executing: dotnet sln $moduleSlnDir\$tag.sln add $moduleProj $commonProjDir\Common.csproj"
dotnet sln "$moduleSlnDir\$tag.sln" add $moduleProj #"$commonProjDir\Common.csproj"

# Add common project reference to generated module reference.
Write-Host -ForegroundColor Green "Executing: dotnet add $moduleProj reference $commonProjDir\Common.csproj"
dotnet add $moduleProj reference "$commonProjDir\Common.csproj"

# Copy custom templates from common to generated module.
$customTemplates = Get-ChildItem "$commonProjDir\Templates\" -Recurse

foreach($customTemplate in $customTemplates) {
    Write-Host -ForegroundColor Green "Coping $customTemplate from $commonProjDir\Templates to $moduleSlnDir\$tag\custom"
    Copy-Item -Path $customTemplate -Destination "$moduleSlnDir\$tag\custom"
}

# Remove unnecessary packages from generate modules.
foreach($package in $nugetPackagesToRemove)
{
    Write-Host -ForegroundColor Green "Executing: dotnet remove $moduleProj package $package"
    dotnet remove $moduleProj package $package
}

# Restore packages.
Write-Host -ForegroundColor Green "Executing: dotnet restore $moduleSlnDir\$tag.sln"
dotnet restore "$moduleSlnDir\$tag.sln"