# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

$title = $env:Title
$body = $env:Body
$baseBranchParameter = ""

if (![string]::IsNullOrEmpty($env:BaseBranch))
{
    $baseBranchParameter = "-B $env:BaseBranch" # optionally pass the base branch if provided as the PR will target the default branch otherwise
}

# Code owners will be added automatically as reviewers.
Invoke-Expression "gh auth login" # login to GitHub
Invoke-Expression "gh pr create -t ""$title"" -b ""$body"" $baseBranchParameter | Write-Host"

Write-Host "Pull Request Created successfully." -ForegroundColor Green
