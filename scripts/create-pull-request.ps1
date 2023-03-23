# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Title,

    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Body,

    [string] $HeadBranchName,

    [string] $BaseBranchName = "dev"
)
$ErrorActionPreference = "Continue"

$HeadBranchOption = $null
if (-not [string]::IsNullOrWhiteSpace($HeadBranchName)) {
    $HeadBranchOption = "-H $HeadBranchName"
}
# Code owners will be added automatically as reviewers.
Invoke-Expression "gh auth login" # login to GitHub
Invoke-Expression 'gh pr create -t "$Title" -b "$Body" -B $BaseBranchName $HeadBranchOption| Write-Host'

Write-Host "Pull Request Created successfully." -ForegroundColor Green
