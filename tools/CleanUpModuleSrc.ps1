
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [switch] $BetaGraphVersion,
    [switch] $RemoveReadme
)

$GraphVersion = "v1.0"
if($BetaGraphVersion){
    $GraphVersion = "Beta"
}

$SrcPath =  Join-Path $PSScriptRoot "..\src\$GraphVersion\*\*"

# Remove all items in resource directory except for its root readme.md
Get-Item "$SrcPath\*" | ForEach-Object {
    if ($_.Name -ne "readme.md") {
        Remove-Item $_.FullName -Recurse
    }
}

# Remove all project references from resource solution.
Get-Item "$SrcPath`.sln" | ForEach-Object {
    $SolutionFile = $_.FullName
    $SolutionPath = $_.Directory
    $SolutionProjects = dotnet sln $SolutionFile list
    $SolutionProjects | ForEach-Object {
        dotnet sln $SolutionFile remove (Join-Path $SolutionPath $_)
    }
}