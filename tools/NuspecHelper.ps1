# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
function Set-NuSpecValues(
    [parameter(Position=1,Mandatory=$true)][ValidateScript({Test-Path $_ -PathType Leaf})][string] $NuSpecFilePath,
    [parameter(Position=2,Mandatory=$true)][string] $VersionNumber,
    [parameter(Position=3)][string[]] $Dependencies,
    [parameter(Position=4)][string] $ReleaseNotes)
{
    $XmlDocument = New-Object System.Xml.XmlDocument
    $XmlDocument.Load($NuSpecFilePath)

    $MetadataElement = [System.Xml.XmlElement] $XmlDocument.DocumentElement.FirstChild

    if($MetadataElement)
    {
        Set-Dependencies -XmlDocument $XmlDocument -MetadataElement $MetadataElement -Dependencies $Dependencies
        Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "version" -ElementValue $VersionNumber
        
        if($ReleaseNotes){
            Set-ElementValue -XmlDocument $XmlDocument -MetadataElement $MetadataElement -ElementName "releaseNotes" -ElementValue $ReleaseNotes
        }
    }

    $XmlDocument.Save($NuSpecFilePath)
}

function Set-ElementValue([System.Xml.XmlDocument] $XmlDocument, [System.Xml.XmlElement] $MetadataElement, [string] $ElementName, [string] $ElementValue){
    if(-not $MetadataElement[$ElementName]){
        $NewElement = $XmlDocument.CreateElement($ElementName, $XmlDocument.DocumentElement.NamespaceURI)
        $MetadataElement.AppendChild($NewElement)
    }
    $MetadataElement[$ElementName].InnerText = $ElementValue
}

function Set-Dependencies([System.Xml.XmlDocument] $XmlDocument, [System.Xml.XmlElement] $MetadataElement, [string[]] $Dependencies){
    if(-not $MetadataElement["dependencies"]){
        $NewDependenciesElement = $XmlDocument.CreateElement("dependencies", $XmlDocument.DocumentElement.NamespaceURI)
        $MetadataElement.AppendChild($NewDependenciesElement)
    } else {
        $MetadataElement["dependencies"].RemoveAll()   
    }

    foreach($Dependency in $Dependencies){
        $NewDependencyElement = $XmlDocument.CreateElement("dependency", $XmlDocument.DocumentElement.NamespaceURI)
        $NewDependencyElement.SetAttribute("id", $Dependency)

        $MetadataElement["dependencies"].AppendChild($NewDependencyElement)
    }
}
