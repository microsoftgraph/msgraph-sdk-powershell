# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
	[string] $WorkLoadDocsPath = (Join-Path $PSScriptRoot "..\src"),
    [string] $Folder = "docs"
)

function Get-GraphMapping {
    $graphMapping = @{}
    #$graphMapping.Add("v1.0", "v1.0")
    $graphMapping.Add("v1.0-beta", "v1.0-beta")
    return $graphMapping
}
function Start-Replacement {
    Param(
        $ModulesToGenerate = @()
    )
    
    $GraphMapping = Get-GraphMapping 
    $GraphMapping.Keys | ForEach-Object {
        $graphProfile = $_
        Get-FilesByProfile -GraphProfile $graphProfile -ModulesToGenerate $ModulesToGenerate 
    }
}
function Get-FilesByProfile{
    Param(
    [ValidateSet("v1.0-beta", "v1.0")]
    [string] $GraphProfile = "v1.0",
    [ValidateNotNullOrEmpty()]
    $ModulesToGenerate = @()
    )

    $ModulesToGenerate | ForEach-Object {
        $ModuleName = $_
		Get-Files -GraphProfile $GraphProfile -ModuleName $ModuleName
    }
}
function Get-Files{
    param(
        [ValidateSet("v1.0-beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $ModuleName = "Users"
    )

     $DocPath = Join-Path $WorkLoadDocsPath $ModuleName $ModuleName $Folder $GraphProfile
	if ((Test-Path $DocPath)) {
		 #Write-Host -ForegroundColor DarkYellow "Updating files in  " $DocPath 
         foreach($filePath in Get-ChildItem $DocPath){
            Update-File -FilePath $filePath -ModuleName $ModuleName
         }
	}
}

function Update-File{
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath,
        [ValidateNotNullOrEmpty()]
        [string] $ModuleName = "Users"
    )
    (Get-Content $FilePath) | 
    Foreach-Object {$_ -replace '-Mg','-MgBeta'}  | 
    Out-File $FilePath
    if($ModuleName -eq "Users"){
        Update-ConnectCommand -FilePath $FilePath
    }
    update-ImportCommand -FilePath $FilePath
}
function Update-ConnectCommand{
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    (Get-Content $FilePath) | 
    Foreach-Object {$_ -replace 'Connect-MgBetaGraph','Connect-MgGraph'}  | 
    Out-File $FilePath
}
function update-ImportCommand{
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    (Get-Content $FilePath) | 
    Foreach-Object {$_ -replace 'Import-Module Microsoft.Graph','Import-Module Microsoft.Graph.Beta'}  | 
    Out-File $FilePath
    if($Folder -eq "docs"){
        Update-ExternalHelp -FilePath $FilePath
    }
}
function Update-ExternalHelp{
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    (Get-Content $FilePath) | 
    Foreach-Object {$_ -replace 'Microsoft.Graph','Microsoft.Graph.Beta'}  | 
    Out-File $FilePath
     Update-ExternalHelpUrl -FilePath $FilePath
    
}
function Update-ExternalHelpUrl{
    param (
        [ValidateNotNullOrEmpty()]
        [string] $FilePath
    )
    $origUrl  = ""
    $text = Get-Content -Path $FilePath
    foreach($content in $text){
        if($content -match 'online version: https'){
            $origUrl = $content   
        } 
    }
    $desiredUrl = $origUrl.Replace("-MgBeta", "-mg")
    $desiredUrl = $desiredUrl.Replace("Microsoft.Graph.Beta", "Microsoft.Graph")
    (Get-Content $FilePath) | 
    Foreach-Object {$_ -replace $origUrl,$desiredUrl -replace "Microsoft.Graph.Beta.Beta", "Microsoft.Graph.Beta"}  | 
    Out-File $FilePath
}

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}
Write-Host -ForegroundColor Green "-------------Fetching docs ------------"
Start-Replacement -ModulesToGenerate $ModulesToGenerate
Write-Host -ForegroundColor Green "-------------Done-------------"