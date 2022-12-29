# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    #Path where the v1 branch (dev) was checked out to
    [string] $SourceDir = ("..\..\..\powershell_copy\msgraph-sdk-powershell\src")
)
function Get-GraphMapping {
    $graphMapping = @{}
    $graphMapping.Add("v1.0", "v1.0")
    $graphMapping.Add("beta", "beta")
    return $graphMapping
}
function Start-Copy {
    Param(
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users"
    )
    $GraphMapping = Get-GraphMapping 
    $GraphMapping.Keys | ForEach-Object {
        $GraphProfile = $_
        Get-FilesByProfile -GraphProfile $GraphProfile -ModulesToGenerate $ModulesToGenerate -Module $Module
    }
   
}


function Get-FilesByProfile {
    Param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users"
    )
    $SourceGraphProfile = "v1.0"
    if ($GraphProfile -eq "beta") {
        $SourceGraphProfile = "v1.0-beta"
    }
    $FromPath = Join-Path $SourceDir $Module $Module "examples" $SourceGraphProfile
    $ToPath = Join-Path "..\..\" "src" $Module $GraphProfile "examples"
    $ConfirmationPath = Join-Path "..\..\" "src" $Module $Module "examples" $SourceGraphProfile
    Write-Host "Confirm path ----  "$ConfirmationPath
    Copy-Files -SourcePath $FromPath -DestPath $ToPath -GraphProfile $GraphProfile -Module $Module -ConfirmationPath $ConfirmationPath
}
function Copy-Files {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $SourcePath = "SourcePath",
        [ValidateNotNullOrEmpty()]
        [string] $DestPath = "DestPath",
        [ValidateNotNullOrEmpty()]
        [string] $ConfirmationPath = "ConfirmationPath",
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users"
    )
    if ((Test-Path $SourcePath)) {
        
        foreach ($File in Get-ChildItem $SourcePath) {
            $FileName = [System.IO.Path]::GetFileNameWithoutExtension($File)
            $OriginalFileName = $FileName
            $FileToCheck = Join-Path $ConfirmationPath "$FileName.md"
            if (Test-Path $FileToCheck) {
                Write-Host "Still generating " $FileToCheck
                if ($GraphProfile -eq "beta") {
                    $FileName = $FileName.Replace("Mg", "MgBeta")
                }
                if ($GraphProfile -eq "v1.0") {
                    Copy-Item $File -Destination $DestPath
                    git add $DestPath
                    git commit -m "Migration for $File done"
                }
                else {
                    Remove-Item $FileToCheck
                    Copy-Item $File -Destination $DestPath
                    $FileToBeReplaced = Join-Path $DestPath "$OriginalFileName.md"
                    $ReplaceWith = $OriginalFileName.Replace("Mg", "MgBeta")
                    Rename-Item $FileToBeReplaced "$ReplaceWith.md"
                    $FinalFilePath = Join-Path $DestPath "$ReplaceWith.md"
                    Write-Host $FinalFilePath
                    Update-File -FilePath $FinalFilePath -ModuleName $Module
                }
            }
        }
    }
      
}

function Update-File {
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath,
        [ValidateNotNullOrEmpty()]
        [string] $ModuleName = "Users"
    )
    (Get-Content $FilePath) | 
    Foreach-Object { $_ -replace '-Mg', '-MgBeta' }  | 
    Out-File $FilePath
    if ($ModuleName -eq "Users") {
        Update-ConnectCommand -FilePath $FilePath
    }
    update-ImportCommand -FilePath $FilePath
}
function Update-ConnectCommand {
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    (Get-Content $FilePath) | 
    Foreach-Object { $_ -replace 'Connect-MgBetaGraph', 'Connect-MgGraph' }  | 
    Out-File $FilePath
}
function update-ImportCommand {
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    (Get-Content $FilePath) | 
    Foreach-Object { $_ -replace 'Import-Module Microsoft.Graph', 'Import-Module Microsoft.Graph.Beta' }  | 
    Out-File $FilePath
    $FileName = [System.IO.Path]::GetFileNameWithoutExtension($FilePath)
    git add $FilePath
    git commit -m "Migration for $FileName.md done"
} 

Write-Host -ForegroundColor Green "-------------Fetching docs and examples from dev-------------"
Start-Copy -Module "Users.Actions"
Write-Host -ForegroundColor Green "-------------Done-------------"