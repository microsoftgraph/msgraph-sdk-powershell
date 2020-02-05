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
        $CurrentVersionSegments = $PSGalleryModule.Version.Split(".")
        $CurrentMajorVersion = $CurrentVersionSegments[0] -as [int]
        $CurrentMinorVersion = $CurrentVersionSegments[1] -as [int]
        $CurrentPatchVersion = $CurrentVersionSegments[2] -as [int]

        $NextVersionSegments = $NextVersion.Split(".")
        $NextMajorVersion = $NextVersionSegments[0]
        $NextMinorVersion = $NextVersionSegments[1]
        $NextPatchVersion = $NextVersionSegments[2]

        # Validate that the version number has been updated.
        # This considers MAJOR.MINOR.PATCH segments, and assumes that version numbers will be update by 1's increment. e.g. 0.1.1 -> 0.1.2
        # For MAJOR and MINOR change, the lower segment -to the right - will be assumed to be 0. e.g. 0.1.5 -> 0.2.0
        if ($CurrentMajorVersion -eq $NextMajorVersion) {
            if ($CurrentMinorVersion -eq $NextMinorVersion -and ($CurrentPatchVersion + 1) -eq $NextPatchVersion) {
                $ValidationState = [VersionState]::Valid
            }
            elseif ((($CurrentMinorVersion + 1) -eq $NextMinorVersion) -and $NextPatchVersion -eq 0) {
                $ValidationState = [VersionState]::Valid
            }
        }
        elseif ((($CurrentMajorVersion + 1) -eq $NextMajorVersion) -and $NextMinorVersion -eq 0 -and $NextPatchVersion -eq 0) {
            $ValidationState = [VersionState]::Valid
        }
    }
}
else {
    $ValidationState = [VersionState]::NotOnFeed
}

return $ValidationState