# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
$NuspecFile = Join-Path $PSScriptRoot "..\msgraph-tools-migration\Microsoft.Graph.Migration.Tool.nuspec" -Resolve
$ModuleMetadataJson = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json" -Resolve
[HashTable] $NuspecMetadata = Get-Content $ModuleMetadataJson | ConvertFrom-Json -AsHashTable
$NuspecMetadata.Remove("assemblyOriginatorKeyFile")
$ModuleManifest = Join-Path $PSScriptRoot "..\msgraph-tools-migration\Microsoft.Graph.Migration.Tool.psd1" -Resolve
function Set-NuSpecValuesFromManifest(
    [parameter(Position=1,Mandatory=$true)][ValidateScript({Test-Path $_ -PathType Leaf})][string] $NuSpecFilePath,
    [parameter(Position=2,Mandatory=$true)][HashTable] $Manifest) {
    $XmlDocument = New-Object System.Xml.XmlDocument
    $XmlDocument.Load($NuSpecFilePath)
    $MetadataElement = [System.Xml.XmlElement] $XmlDocument.DocumentElement.FirstChild

    if($MetadataElement)
    {
        Update-ManifestFile -ModuleMetadata $Manifest 
        if ($Manifest["versions"]["v1.0"]["prerelease"]) {
            Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "version" -ElementValue "$($Manifest["versions"]["v1.0"]["version"])-$($Manifest["versions"]["v1.0"]["prerelease"])"
        } else {
            Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "version" -ElementValue $Manifest["versions"]["v1.0"]["version"]
        }
        $Manifest.Remove("version")
        $Manifest.Remove("prerelease")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "projectUrl" -ElementValue "https://github.com/microsoftgraph/msgraph-tools-migration"
        $Manifest.Remove("projectUri")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "licenseUrl" -ElementValue $Manifest["licenseUri"]
        $Manifest.Remove("licenseUri")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "iconUrl" -ElementValue $Manifest["iconUri"]
        $Manifest.Remove("iconUri")

        foreach($NuspecField in $Manifest.Keys)
        {
            if(-not($NuspecField -eq "versions")){
                Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName $NuspecField -ElementValue $Manifest[$NuspecField]
            }   
        }
        Remove-Element -XmlDocument $XmlDocument -ElementName "dependencies"
        Remove-Element -XmlDocument $XmlDocument -ElementName "license"
        
    }

    $XmlDocument.Save($NuSpecFilePath)
}

function Set-ElementValue(
    [System.Xml.XmlDocument] $XmlDocument,
    [System.Xml.XmlElement] $MetadataElement,
    [string] $ElementName,
    [string] $ElementValue) {
    if(-not $MetadataElement[$ElementName]){
        $NewElement = $XmlDocument.CreateElement($ElementName, $XmlDocument.DocumentElement.NamespaceURI)
        $MetadataElement.AppendChild($NewElement) | Out-Null
    }
    $MetadataElement[$ElementName].InnerText = $ElementValue
}

function Remove-Element(
    [System.Xml.XmlDocument] $XmlDocument,
    [string] $ElementName ){
    $XmlDocument.package.metadata.SelectNodes($ElementName).ForEach{ $Null = $_.ParentNode.RemoveChild($_) }
   
}

function Update-ManifestFile(
    [parameter(Position=1,Mandatory=$true)][HashTable] $ModuleMetadata
){
    $Version = $ModuleMetadata["versions"]["v1.0"]["version"]
    $ExistingModule = Find-Module "Microsoft.Graph.Migrations.Tool" -Repository PSGallery -ErrorAction SilentlyContinue
    $ModuleGuid = ($null -eq $ExistingModule) ? (New-Guid).Guid : $ExistingModule.AdditionalMetadata.GUID

    [HashTable]$ModuleManifestSettings = @{
        Guid          = $ModuleGuid
        Path          = $ModuleManifest
        ModuleVersion = $Version
        ProjectUri = "https://github.com/microsoftgraph/msgraph-tools-migration"
        IconUri       = $ModuleMetadata["iconUri"]
        ReleaseNotes  = $ModuleMetadata["releaseNotes"]
    }
    if ($Manifest["versions"]["v1.0"]["prerelease"]) {
        $ModuleManifestSettings.Prerelease = $ModuleMetadata["versions"]["v1.0"]["prerelease"]
    }
    Write-Debug "Updating '$ModuleFullName' module manifest and nuspec..."
    Update-ModuleManifest @ModuleManifestSettings
}
$NuspecMetadata.Remove("guid")
Set-NuSpecValuesFromManifest -NuSpecFilePath $NuspecFile -Manifest $NuspecMetadata