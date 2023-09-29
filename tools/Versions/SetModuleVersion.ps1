# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

function Set-ModuleVersion {
    Param(
        [string] $Version,
        [string] $Prerelease,
        [switch] $SetAuthModule,
        [switch] $SetBetaModule,
        [switch] $SetV1Module
    )

    $ModuleMetadataPath = Join-Path $PSScriptRoot "..\..\config\ModuleMetadata.json"
    $ModuleMetadata = Get-Content $ModuleMetadataPath | ConvertFrom-Json

    if ($SetAuthModule.IsPresent) {
        $ModuleMetadata.versions.authentication.version = $Version
        $ModuleMetadata.versions.authentication.prerelease = $Prerelease
    }

    if ($SetBetaModule.IsPresent) {
        $ModuleMetadata.versions.beta.version = $Version
        $ModuleMetadata.versions.beta.prerelease = $Prerelease
    }

    if ($SetV1Module.IsPresent) {
        $ModuleMetadata.versions.'v1.0'.version = $Version
        $ModuleMetadata.versions.'v1.0'.prerelease = $Prerelease
    }

    $ModuleMetadata | ConvertTo-Json -Depth 5 | Out-File $ModuleMetadataPath -Encoding utf8    
}

function Invoke-BumpMinorOrPreReleaseVersion {
    Param(
        [string] $FullVersion,
        [string] $PreReleaseTag
    )
    $versionSegments = $FullVersion -split "-"
    if ($versionSegments.Count -gt 1 -and [string]::IsNullOrWhiteSpace($PreReleaseTag) -eq $false) {
        $PreReleaseVersion = $versionSegments[1] -split $PreReleaseTag
        if ($PreReleaseVersion.Count -gt 1) {
            $version = [System.Version]("$($versionSegments[0]).$($PreReleaseVersion[1])")
        }
        else {
            $version = [System.Version]("$($versionSegments[0]).0")
        }
        $newVersion = "$($version.Major).$($version.Minor).$($version.Build)"
        $newPrereleaseVersion = "$PreReleaseTag$($version.Revision + 1)"
    }
    else {
        $version = [System.Version]("$($versionSegments[0])")
        if ($version.Build -eq 0) {
            $newVersion = "$($version.Major).$($version.Minor + 1).$($version.Build)"
        } else {
            $newVersion = "$($version.Major).$($version.Minor + 1).0"
        }
    }
    return $newVersion, $newPrereleaseVersion
}

