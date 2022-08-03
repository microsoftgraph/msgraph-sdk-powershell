# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

function Set-CSProjValues(
    [parameter(Mandatory = $true)][string] $ModuleCsProj,
    [parameter(Mandatory = $true)][string] $ModuleVersion,
    [string] $PreRelease,
    [string] $Copyright,
    [string] $AssemblyOriginatorKeyFile) {
    $NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"

    # Import scripts
    . $NuspecHelperPS1

    # Set delay sign to true.
    $ModuleProjDoc = New-Object System.Xml.XmlDocument
    $ModuleProjDoc.Load($ModuleCsProj)
    if ($ModuleProjDoc.DocumentElement.PropertyGroup.Count -gt 1) {
        $ModuleProjElement = [System.Xml.XmlElement] $ModuleProjDoc.DocumentElement.PropertyGroup[0]
    } else {
        $ModuleProjElement = [System.Xml.XmlElement] $ModuleProjDoc.DocumentElement.PropertyGroup
    }
    
    if (![string]::IsNullOrWhiteSpace($AssemblyOriginatorKeyFile)) {
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "AssemblyOriginatorKeyFile" -ElementValue (Join-Path $PSScriptRoot $AssemblyOriginatorKeyFile)
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "DelaySign" -ElementValue "true"
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "SignAssembly" -ElementValue "true"
    }
    if (![string]::IsNullOrWhiteSpace($Copyright)) {
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "Copyright" -ElementValue $Copyright
    }

    if ($PreRelease) {
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "VersionPrefix" -ElementValue $ModuleVersion
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "VersionSuffix" -ElementValue $PreRelease
        Remove-Element -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "Version"
    } else {
        Set-ElementValue -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "Version" -ElementValue $ModuleVersion
        Remove-Element -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "VersionSuffix"
        Remove-Element -XmlDocument $ModuleProjDoc -MetadataElement $ModuleProjElement -ElementName "VersionPrefix"
    }

    $ModuleProjDoc.Save($ModuleCsProj)
    Write-Host "Updated the $ModuleCsProj."
}
