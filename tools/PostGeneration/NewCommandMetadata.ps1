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
    $OutputPath = (Join-Path $PSScriptRoot "..\..\assets\")
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
            "Command"     = $CommandName
            "Variants"    = [System.Collections.ArrayList]@($VariantName)
            "Method"      = $Matches.2
            "Url"         = $Matches.3
            "ApiVersion"  = $null
            "OutputType"  = $null
            "Module"      = $ModuleName
            "Permissions" = @()
        }

        if ($RawFileContent -match $ProfilePattern) {
            $Version = $Matches.1
            if ($Matches.1 -eq "v1.0-beta") {
                $Version = "beta"
            }

            $MappingValue.ApiVersion = $Version
        }

        if ($RawFileContent -match $OutputTypePattern) {
            $MappingValue.OutputType = $Matches.1
        }

        if ($VariantName.StartsWith("List")) {
            $CommandMappingKey = "$($MappingValue.Command)_List_$($MappingValue.ApiVersion)"
        } else {
            $CommandMappingKey = "$($MappingValue.Command)_$($MappingValue.ApiVersion)"
        }

        if ($CommandPathMapping.Contains($CommandMappingKey)) {
            $CommandPathMapping[$CommandMappingKey].Variants.AddRange($MappingValue.Variants)
        }
        else {
            Write-Host "Fetching permissions for $CommandMappingKey" -ForegroundColor Green
            try {
                # $Permissions = Invoke-RestMethod -Uri "$($PermissionsUrl)?requesturl=$($MappingValue.Url)&method=$($MappingValue.Method)" -ErrorAction SilentlyContinue
                # $MappingValue.Permissions = ($Permissions | Sort-Object -Property value -Unique)
            }
            catch {
                Write-Warning "Failed to fetch permissions: $($PermissionsUrl)?requesturl=$($MappingValue.Url)&method=$($MappingValue.Method)"
            }
            $CommandPathMapping.Add($CommandMappingKey, $MappingValue)
        }
    }
    else {
        Write-Error "No match for $OpenApiTagPattern"
    }
}

$CommandPathMapping | ConvertTo-Json -Depth 3 | Out-File -FilePath $MgCommandMetadataFile
$stopwatch.Stop()
$stopwatch.Elapsed.TotalSeconds