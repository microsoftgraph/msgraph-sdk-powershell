# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

function Set-CiModulePrerelease {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [string] $MetadataPath,

        [Parameter(Mandatory)]
        [ValidatePattern('^\d+$')]
        [string] $BuildId
    )

    $metadata = Get-Content -Path $MetadataPath -Raw | ConvertFrom-Json -AsHashtable
    $prerelease = "ci.$BuildId"

    foreach ($versionMetadata in $metadata.versions.Values) {
        $versionMetadata.prerelease = $prerelease
    }

    $metadata | ConvertTo-Json -Depth 100 | Set-Content -Path $MetadataPath -Encoding utf8
    return $prerelease
}

function Test-AcrPublishPath {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory, ValueFromPipeline)]
        [AllowEmptyString()]
        [string[]] $Path
    )

    begin {
        $isRelevant = $false
        $patterns = @(
            '^src/Authentication(?:/|$)',
            '^config(?:/|$)',
            '^autorest\.powershell(?:/|$)',
            '^openApiDocs(?:/|$)'
        )
    }

    process {
        foreach ($item in $Path) {
            $normalizedPath = $item.Replace('\', '/')
            if ($patterns.Where({ $normalizedPath -match $_ }, 'First').Count -gt 0) {
                $isRelevant = $true
            }
        }
    }

    end {
        return $isRelevant
    }
}
