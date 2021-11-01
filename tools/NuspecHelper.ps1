# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
function Set-NuSpecValues(
    [parameter(Position=1,Mandatory=$true)][ValidateScript({Test-Path $_ -PathType Leaf})][string] $NuSpecFilePath,
    [parameter(Position=2,Mandatory=$true)][string] $VersionNumber,
    [parameter(Position=3,Mandatory=$true)][string] $IconUrl,
    [parameter(Position=4)][hashtable[]] $Dependencies,
    [parameter(Position=5)][string[]] $ReleaseNotes) {
    $XmlDocument = New-Object System.Xml.XmlDocument
    $XmlDocument.Load($NuSpecFilePath)

    $MetadataElement = [System.Xml.XmlElement] $XmlDocument.DocumentElement.FirstChild

    if($MetadataElement)
    {
        Set-Dependencies -XmlDocument $XmlDocument -MetadataElement $MetadataElement -Dependencies $Dependencies
        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "version" -ElementValue $VersionNumber
        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "iconUrl" -ElementValue $IconUrl
        
        if($ReleaseNotes){
            Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "releaseNotes" -ElementValue $ReleaseNotes
        }
    }

    $XmlDocument.Save($NuSpecFilePath)
}

function Set-NuSpecValuesFromManifest(
    [parameter(Position=1,Mandatory=$true)][ValidateScript({Test-Path $_ -PathType Leaf})][string] $NuSpecFilePath,
    [parameter(Position=2,Mandatory=$true)][HashTable] $Manifest) {
    $XmlDocument = New-Object System.Xml.XmlDocument
    $XmlDocument.Load($NuSpecFilePath)
    $MetadataElement = [System.Xml.XmlElement] $XmlDocument.DocumentElement.FirstChild

    if($MetadataElement)
    {
        Set-Dependencies -XmlDocument $XmlDocument -MetadataElement $MetadataElement -Dependencies $Manifest["dependencies"]
        $Manifest.Remove("dependencies")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "projectUrl" -ElementValue $Manifest["projectUri"]
        $Manifest.Remove("projectUri")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "licenseUrl" -ElementValue $Manifest["licenseUri"]
        $Manifest.Remove("licenseUri")

        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "iconUrl" -ElementValue $Manifest["iconUri"]
        $Manifest.Remove("iconUri")

        foreach($NuspecField in $Manifest.Keys)
        {
            Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName $NuspecField -ElementValue $Manifest[$NuspecField]
        }
    }

    $XmlDocument.Save($NuSpecFilePath)
}

function Set-ElementValue(
    [System.Xml.XmlDocument] $XmlDocument,
    [System.Xml.XmlElement] $MetadataElement,
    [string] $ElementName, [string] $ElementValue) {
    if(-not $MetadataElement[$ElementName]){
        $NewElement = $XmlDocument.CreateElement($ElementName, $XmlDocument.DocumentElement.NamespaceURI)
        $MetadataElement.AppendChild($NewElement)
    }
    $MetadataElement[$ElementName].InnerText = $ElementValue
}

function Set-Dependencies(
    [System.Xml.XmlDocument] $XmlDocument,
    [System.Xml.XmlElement] $MetadataElement,
    [hashtable[]] $Dependencies) {
    if(-not $MetadataElement["dependencies"]){
        $NewDependenciesElement = $XmlDocument.CreateElement("dependencies", $XmlDocument.DocumentElement.NamespaceURI)
        $MetadataElement.AppendChild($NewDependenciesElement)
    } else {
        $MetadataElement["dependencies"].RemoveAll()   
    }

    foreach($Dependency in $Dependencies){
        $NewDependencyElement = $XmlDocument.CreateElement("dependency", $XmlDocument.DocumentElement.NamespaceURI)
        $NewDependencyElement.SetAttribute("id", $Dependency.ModuleName)
        $NewDependencyElement.SetAttribute("version", $Dependency.ModuleVersion ?? $Dependency.RequiredVersion)

        $MetadataElement["dependencies"].AppendChild($NewDependencyElement)
    }
}

<#
    Remove Markdown Docs Element from the Nuspec File.
    This is fixed in autorest code generator
    https://github.com/Azure/autorest.powershell/blob/4e5e47e874747ce9cfbf88981538654dd2bafe4f/powershell/generators/nuspec.ts#L42
#>
function Remove-MarkdownDocsElement(
    [parameter(Position=1, Mandatory=$true)]
    [ValidateScript({Test-Path $_ -PathType Leaf})][string] $NuSpecFilePath){

    $XmlDocument = New-Object System.Xml.XmlDocument
    $XmlDocument.Load($NuSpecFilePath)
    $docsNode = $XmlDocument.DocumentElement.Files.ChildNodes | Where-Object { $_.target -eq 'docs'}
    $XmlDocument.DocumentElement.Files.RemoveChild($docsNode) | Out-Null
    $XmlDocument.Save($NuSpecFilePath)
}