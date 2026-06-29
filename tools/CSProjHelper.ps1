# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

function Invoke-WithRetry {
    param(
        [Parameter(Mandatory = $true)]
        [scriptblock]$ScriptBlock,

        [Parameter(Mandatory = $false)]
        [int]$MaxRetries = 5,

        [Parameter(Mandatory = $false)]
        [int]$InitialDelayMs = 100,

        [Parameter(Mandatory = $false)]
        [string]$OperationName = "Operation"
    )

    for ($attempt = 1; $attempt -le $MaxRetries; $attempt++) {
        try {
            return & $ScriptBlock
        }
        catch {
            if ($attempt -eq $MaxRetries) {
                Write-Error "$OperationName failed after $MaxRetries attempts. Last error: $_"
                throw
            }

            $delayMs = $InitialDelayMs * [Math]::Pow(2, $attempt - 1)
            Write-Warning "$OperationName failed (attempt $attempt/$MaxRetries). Retrying in $delayMs ms. Error: $_"
            Start-Sleep -Milliseconds $delayMs
        }
    }
}

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
