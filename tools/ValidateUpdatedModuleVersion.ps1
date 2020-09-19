# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter()][ValidateNotNullOrEmpty()][string] $ModuleName,
    [Parameter()][ValidateNotNullOrEmpty()][string] $NextVersion,
    [Parameter()][string] $PSRepository = "PSGallery",
    [int] $ModulePreviewNumber = -1
)
enum VersionState {
    Invalid
    Valid
    EqualToFeed
    NotOnFeed
}
$AllowPreRelease = $true
if($ModulePreviewNumber -eq -1) {
    $AllowPreRelease = $false
    $PSRepository = "PSGallery"
}
[VersionState]$ValidationState = [VersionState]::Invalid
# Get current published version from PS Gallery.
$PSGalleryModule = Find-Module -Name $ModuleName -Repository $PSRepository -ErrorAction Ignore -AllowPrerelease:$AllowPreRelease
if ($null -ne $PSGalleryModule ) {
    $PSGalleryVersion = [version]($PSGalleryModule.Version)
    $LocalVersion = [version]$NextVersion
    # Local version is equal to PS Gallery version.
    if ($LocalVersion -eq $PSGalleryVersion) {
        $ValidationState = [VersionState]::EqualToFeed
    }
    # Local version is greater than PS Gallery version.
    elseif ($LocalVersion -gt $PSGalleryVersion) {
        $ValidationState = [VersionState]::Valid
    }
}
else {
    $ValidationState = [VersionState]::NotOnFeed
}

return $ValidationState