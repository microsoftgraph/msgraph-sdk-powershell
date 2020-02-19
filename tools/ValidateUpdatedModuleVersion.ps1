# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter()][ValidateNotNullOrEmpty()][string] $ModuleName,
    [Parameter()][ValidateNotNullOrEmpty()][string] $NextVersion,
    [Parameter()][string] $PSRepository = "PSGallery"
)
enum VersionState {
    Invalid
    Valid
    EqualToFeed
    NotOnFeed
}

[VersionState]$ValidationState = [VersionState]::Invalid

# Get current published version from PS Gallery.
$PSGalleryModule = Find-Module -Name $ModuleName -Repository $PSRepository -ErrorAction Ignore
if ($null -ne $PSGalleryModule ) {
    if ($PSGalleryModule.Version -eq $NextVersion) {
        $ValidationState = [VersionState]::EqualToFeed
    }
    else {
        # Split current PS Gallery version to MAJOR, MINOR and PATCH segments.
        $PSGalleryVersionSegments = $PSGalleryModule.Version.Split(".")
        $PSGalleryMajorVersion = $PSGalleryVersionSegments[0] -as [int]
        $PSGalleryMinorVersion = $PSGalleryVersionSegments[1] -as [int]
        $PSGalleryPatchVersion = $PSGalleryVersionSegments[2] -as [int]

        # Split current local version to MAJOR, MINOR and PATCH segments.
        $NextVersionSegments = $NextVersion.Split(".")
        $NextMajorVersion = $NextVersionSegments[0]
        $NextMinorVersion = $NextVersionSegments[1]
        $NextPatchVersion = $NextVersionSegments[2]

        # Validate that the version number has been updated.
        # This considers MAJOR.MINOR.PATCH segments, and assumes that version numbers will be updated by increments of 1 e.g. 0.1.1 -> 0.1.2
        # For a MAJOR or MINOR change, it will be assumed that lower segment (to the right) will be set to 0 e.g. 0.1.5 -> 0.2.0
        if ($PSGalleryMajorVersion -eq $NextMajorVersion) {
            if ($PSGalleryMinorVersion -eq $NextMinorVersion -and ($PSGalleryPatchVersion + 1) -eq $NextPatchVersion) {
                $ValidationState = [VersionState]::Valid
            }
            elseif ((($PSGalleryMinorVersion + 1) -eq $NextMinorVersion) -and $NextPatchVersion -eq 0) {
                $ValidationState = [VersionState]::Valid
            }
        }
        elseif ((($PSGalleryMajorVersion + 1) -eq $NextMajorVersion) -and $NextMinorVersion -eq 0 -and $NextPatchVersion -eq 0) {
            $ValidationState = [VersionState]::Valid
        }
    }
}
else {
    $ValidationState = [VersionState]::NotOnFeed
}

return $ValidationState