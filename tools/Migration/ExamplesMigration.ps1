# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string[]] $ModulesToGenerate = @(),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\..\config\ModulesMapping.jsonc"),
    #Path where the v1 branch (dev) was checked out to
    #[string] $SourceDir = ("..\..\..\powershell_copy\msgraph-sdk-powershell\src")
    [string] $SourceDir = (Join-Path $PSScriptRoot "..\..\..\DevRepo\src"),
    [ValidateNotNullOrEmpty()]
    [string] $Token= "Token"
)
function Get-GraphMapping {
    $graphMapping = @{}
    $graphMapping.Add("v1.0", "v1.0")
    $graphMapping.Add("beta", "beta")
    return $graphMapping
}
function Start-Copy {
    Param(
        $ModulesToExclude = @()
    )
    $ModulesToGenerate | ForEach-Object {
        $Module = $_
        if($ModulesToExclude.Contains($Module)){
            Write-Host Skipping $Module module
        }else{
            Write-Host Generating  $Module module
         
            $Pathname = Join-Path $PSScriptRoot "..\GenerateModules.ps1"
            & $Pathname -ModuleToGenerate $Module
    
        $GraphMapping = Get-GraphMapping 
        $GraphMapping.Keys | ForEach-Object {
            $GraphProfile = $_
            Get-FilesByProfile -GraphProfile $GraphProfile -ModulesToGenerate $ModulesToGenerate -Module $Module
        }
        }
    }
    #Set-Location (Join-Path $PSScriptRoot "../../")
    git config --global user.email "timwamalwa@gmail.com"
    git config --global user.name "Timothy Wamalwa"
    git add .
    git commit -m "Migrating example files"
    Write-Host -ForegroundColor Green "-------------Finished commit-------------"
    git push --set-upstream "https://$Token@github.com/microsoftgraph/msgraph-sdk-powershell.git" $proposedBranch
    git status

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
} 
if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}
if (-not (Test-Path $SourceDir)) {
    Write-Error "SourceDir not be found: $SourceDir."
}
$Date = Get-Date -Format "dd-MM-yyyy"
$ProposedBranch = "ExampleFilesMigration_$Date"
$Exists = git branch -l $ProposedBranch
if ([string]::IsNullOrEmpty($Exists)) {
    git checkout -b $ProposedBranch
}else{
	Write-Host "Branch already exists"
    $CurrentBranch = git rev-parse --abbrev-ref HEAD
    if($CurrentBranch -ne $ProposedBranch){
        git checkout $ProposedBranch
     }
     git checkout $ProposedBranch
}
Write-Host -ForegroundColor Green "-------------Fetching docs and examples from dev-------------"
Start-Copy -ModulesToExclude "Users", "Users.Actions", "Users.Functions", "Teams", "Sites", "Security", "Search", "Reports", "Planner", "PersonalContacts", "Mail", "Identity.SignIns", "Identity.Governance", "Identity.DirectoryManagement", "Groups","Financials", "Files","Education", "DirectoryObjects", "DeviceManagement.Functions", "DeviceManagement.Actions", "DeviceManagement.Enrolment", "DeviceManagement.Administration", "DeviceManagement", "Devices.ServiceAnnouncement", "Devices.CorporateManagement", "Devices.CloudPrint", "CrossDeviceExperiences", "Compliance", "CloudCommunications", "ChangeNotifications", "Calendar", "Bookings"
Write-Host -ForegroundColor Green "-------------Done-------------"