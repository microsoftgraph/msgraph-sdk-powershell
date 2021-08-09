# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

# Set-StrictMode -Version 2

[CmdletBinding()]
param (
    [Parameter()]
    [string]
    $SourcePath = (Join-Path $PSScriptRoot "..\..\src\"),

    [Parameter()]
    [string]
    $OutputPath = (Join-Path $PSScriptRoot "..\..\src\Authentication\Authentication\custom\common\"),

    [Parameter()]
    [switch]
    $IncludePermissions
)
if (!(Test-Path $SourcePath)) {
    Write-Error "SourcePath is not valid or does not exist. Please ensure that $SourcePath exists then try again."
}

if (!(Test-Path $OutputPath)) {
    New-Item -ItemType Directory -Path $OutputPath
}

$MgCommandMetadataFile = Join-Path $OutputPath "MgCommandMetadata.json"
$CommandPathMapping = [ordered]@{}

# Regex patterns.
$CmdletPathPattern = Join-Path $SourcePath "\*\*\generated\cmdlets"
$OpenApiTagPattern = '\[OpenAPI\].s*(.*)=>(.*):\"(.*)\"'
$ProfilePattern = 'Profile\("(v1\.0|v1\.0-beta)"\)'
$OutputTypePattern = 'OutputType\(typeof\(Microsoft\.Graph\.PowerShell\.Models\.(.*)\)\)'
$PermissionsUrl = "https://graphexplorerapi.azurewebsites.net/permissions"

Write-Debug "Crawling cmdlets in $CmdletPathPattern."
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
Get-ChildItem -path $CmdletPathPattern -Filter "*.cs" -Recurse | Where-Object { $_.Attributes -ne "Directory" } | ForEach-Object {
    $SplitFileName = $_.BaseName.Split("_")
    $CommandName = (New-Object regex -ArgumentList "Mg").Replace($SplitFileName[0], "-Mg", 1)
    $VariantName = $SplitFileName[1]

    if ($_.DirectoryName -match "\\src\\(.*?.)\\") {
        $ModuleName = $Matches.1
    }

    $RawFileContent = (Get-Content -Path $_.FullName -Raw)
    if ($RawFileContent -match $OpenApiTagPattern) {
        # "OperationId" = $Matches.1
        $MappingValue = @{
            Command     = $CommandName
            Variants    = [System.Collections.ArrayList]@($VariantName)
            Method      = $Matches.2
            Uri         = $Matches.3
            ApiVersion  = $null
            OutputType  = $null
            Module      = $ModuleName
            Permissions = @()
        }

        if ($RawFileContent -match $ProfilePattern) {
            $MappingValue.ApiVersion = ($Matches.1 -eq "v1.0-beta") ? "beta" : $Matches.1
        }

        if ($RawFileContent -match $OutputTypePattern) {
            $MappingValue.OutputType = $Matches.1
        }

        # Disambiguate between /users (Get-MgUser) and /users/{id} (Get-MgUser) by variant name (parameterset) i.e., List and Get.
        if ($VariantName.StartsWith("List")) {
            $CommandMappingKey = "$($MappingValue.Command)_List_$($MappingValue.ApiVersion)"
        }
        else {
            $CommandMappingKey = "$($MappingValue.Command)_$($MappingValue.ApiVersion)"
        }

        if ($CommandPathMapping.Contains($CommandMappingKey)) {
            $CommandPathMapping[$CommandMappingKey].Variants.AddRange($MappingValue.Variants)
        }
        else {
            if ($IncludePermissions) {
                try {
                    Write-Debug "Fetching permissions for $CommandMappingKey"
                    $Permissions = @()
                    Invoke-RestMethod -Uri "$($PermissionsUrl)?requesturl=$($MappingValue.Uri)&method=$($MappingValue.Method)" -ErrorAction SilentlyContinue | ForEach-Object {
                        $Permissions += [PSCustomObject]@{
                            Name            = $_.value
                            Description     = $_.consentDisplayName
                            FullDescription = $_.consentDescription
                            IsAdmin         = $_.IsAdmin
                        }
                    }
                    $MappingValue.Permissions = ($Permissions | Sort-Object -Property Name -Unique)
                }
                catch {
                    Write-Warning "Failed to fetch permissions: $($PermissionsUrl)?requesturl=$($MappingValue.Uri)&method=$($MappingValue.Method)"
                }
            }
            $CommandPathMapping.Add($CommandMappingKey, $MappingValue)
        }
    }
    else {
        Write-Error "No match for $OpenApiTagPattern"
    }
}
if ($CommandPathMapping.Count -eq 0) {
    Write-Warning "Skipped writing metadata to $MgCommandMetadataFile. Metadata is empty."
}
else {
    Write-Debug "Writing metadata to $MgCommandMetadataFile."
    $CommandPathMapping.GetEnumerator() | Sort-Object Name | Select-Object -ExpandProperty Value | ConvertTo-Json -Depth 4 | Out-File -FilePath $MgCommandMetadataFile
}
$stopwatch.Stop()
Write-Debug "Generated command metadata file in '$($Stopwatch.Elapsed.TotalSeconds)`s."