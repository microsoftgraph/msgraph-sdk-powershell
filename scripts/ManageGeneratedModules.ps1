Param(
    [string[]]$tag
)

# Add nuget packages to project.
$nugetPackagesToRemove = "Microsoft.CSharp"
# $tag = "me.userActivity"

$commonProjDir = "..\src\Common\Common"
$moduleSlnDir = "..\src\$tag"
$moduleProj = "$moduleSlnDir\$tag\$tag.csproj"

# create new solution
Write-Host -ForegroundColor Green "Executing: dotnet new sln -n $tag -o $moduleSlnDir --force"
dotnet new sln -n $tag -o $moduleSlnDir --force

# add projects to solutions
Write-Host -ForegroundColor Green "Executing: dotnet sln $moduleSlnDir\$tag.sln add $moduleProj $commonProjDir\Common.csproj"
dotnet sln "$moduleSlnDir\$tag.sln" add $moduleProj "$commonProjDir\Common.csproj"

# add project to project(s) reference
Write-Host -ForegroundColor Green "Executing: dotnet add $moduleProj reference $commonProjDir\Common.csproj"
dotnet add $moduleProj reference "$commonProjDir\Common.csproj"

# Copy custom templates from common to generated module.
$customTemplates = Get-ChildItem "$commonProjDir\Templates\" -Recurse

foreach($customTemplate in $customTemplates) {
    Write-Host -ForegroundColor Gree "Template -> $customTemplate"
    Copy-Item -Path "$commonProjDir\Templates\$customTemplate" -Destination "$moduleSlnDir\$tag\custom"
}

foreach($package in $nugetPackagesToRemove)
{
    Write-Host -ForegroundColor Green "Executing: dotnet remove $moduleProj package $package"
    dotnet remove $moduleProj package $package
}

Write-Host -ForegroundColor Green "Executing: dotnet restore $moduleSlnDir\$tag.sln"
dotnet restore "$moduleSlnDir\$tag.sln"