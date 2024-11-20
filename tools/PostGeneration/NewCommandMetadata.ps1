﻿# ------------------------------------------------------------------------------
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
    $IncludePermissions,

    [Parameter()]
    [ValidateSet("v1.0", "beta")]
    $ApiVersion = @("v1.0", "beta")
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
$OpenApiTagPattern = '\[OpenAPI\].s*(.*)=>(.*):\"(.*)\"'
$ExternalDocsPattern = 'https://learn.microsoft.com/graph/api/(.*?(graph-rest-1.0|graph-rest-beta))'
$AliasPattern = '\[global::System.Management.Automation.Alias(.*?)\]'
$ActionFunctionFQNPattern = "\/Microsoft.Graph.(.*)$"
$PermissionsUrl = "https://devxapi-func-prod-eastus.azurewebsites.net/permissions"

Write-Debug "Crawling cmdlets in $CmdletPathPattern."
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$ApiVersion | ForEach-Object {
    $CurrentApiVersion = $_
    $OutputTypePattern = ($CurrentApiVersion -eq "beta") ? '\(typeof\(Microsoft\.Graph\.Beta\.PowerShell\.Models\.(.*)\)\)' : '\(typeof\(Microsoft\.Graph\.PowerShell\.Models\.(.*)\)\)'
    $CmdletPathPattern = Join-Path $SourcePath "\*\$CurrentApiVersion\generated\cmdlets"
    Get-ChildItem -path $CmdletPathPattern -Filter "*.cs" -Recurse | Where-Object { $_.Attributes -ne "Directory" } | ForEach-Object {
        $SplitFileName = $_.BaseName.Split("_")
        $CommandName = (New-Object regex -ArgumentList "Mg").Replace($SplitFileName[0], "-Mg", 1)
        $VariantName = $SplitFileName[1]
        if ($_.DirectoryName -match "\\src\\(.*?.)\\") {
            $ModuleName = ($CurrentApiVersion -eq "beta") ? "Beta.$($Matches.1)" : $Matches.1
        }
        $RawFileContent = (Get-Content -Path $_.FullName -Raw)
        if ($RawFileContent -match $OpenApiTagPattern) {
            $Method = $Matches.2
            $Uri = $Matches.3

            # Remove FQN in paths.
            if ($Uri -match $ActionFunctionFQNPattern) {
                $MatchedUriSegment = $Matches.0
                $SegmentBuilder = ""
                # Trim nested namespace segments.
                $NestedNamespaceSegments = $Matches.1 -split "/"
                foreach ($Segment in $NestedNamespaceSegments) {
                    # Remove microsoft.graph prefix and trailing '()' from functions.
                    $Segment = $segment.Replace("microsoft.graph.", "").Replace("()", "")
                    # Get resource object name from segment if it exists. e.g get 'updateAudience' from windowsUpdates.updateAudience
                    $ResourceObj = $Segment.Split(".")
                    $Segment = $ResourceObj[$ResourceObj.Count - 1]       
                    $SegmentBuilder += "/$Segment"
                }
                $Uri = $Uri -replace [Regex]::Escape($MatchedUriSegment), $SegmentBuilder
            }
            $CommandAliasValue = ($RawFileContent -match $AliasPattern) ? $Matches.0 : $null
            if (-not($Null -eq $CommandAliasValue)) {
                $CommandAliasValue = $CommandAliasValue.Replace("[global::System.Management.Automation.Alias(`"", "").Replace("`")", "").Replace("]", "")
            }
            if(-not($CommandAliasValue.Contains("-Mg"))) {
                $CommandAliasValue = $null
            }
            $ExternalDocsUrl = ($RawFileContent -match $ExternalDocsPattern) ? $Matches.0 : $null
            if(-not($Null -eq $ExternalDocsUrl)) {
                $ExternalDocsUrl = $ExternalDocsUrl.Replace("intune-onboarding-", "")
                $ExternalDocsUrl = $ExternalDocsUrl.Replace("intune-mam-", "")
                
                try {
                    $HTTP_Request = [System.Net.WebRequest]::Create($ExternalDocsUrl)
            
                    # We then get a response from the site.
                    $HTTP_Response = $HTTP_Request.GetResponse()
            
                    # We then get the HTTP code as an integer.
                    $HTTP_Status = [int]$HTTP_Response.StatusCode
            
                    If (-not($HTTP_Status-eq 200)) {
                        $ExternalDocsUrl = $Null
                    }
                    If ($HTTP_Response -ne $null) { $HTTP_Response.Close() }
                }
                catch {
                    $ExternalDocsUrl = $Null
                }
            }
            $MappingValue = @{
                Command          = $CommandName
                Variants         = [System.Collections.ArrayList]@($VariantName)
                Method           = $Method
                Uri              = $Uri
                ApiVersion       = $CurrentApiVersion
                OutputType       = ($RawFileContent -match $OutputTypePattern) ? $Matches.1 : $null
                Module           = $ModuleName
                ApiReferenceLink = $ExternalDocsUrl
                CommandAlias     = $CommandAliasValue
                Permissions      = @()
            }

            # Disambiguate between /users (Get-MgUser) and /users/{id} (Get-MgUser) by variant name (parameterset) i.e., List and Get.
            $CommandMappingKey = ($VariantName.StartsWith("List")) ? "$($MappingValue.Command)_List" : "$($MappingValue.Command)"
            if ($CommandPathMapping.Contains($CommandMappingKey)) {
                $CommandPathMapping[$CommandMappingKey].Variants.AddRange($MappingValue.Variants)
            }
            else {
                if ($IncludePermissions) {
                    try {
                        Write-Debug "Fetching permissions for $CommandMappingKey"
                        $Permissions = @()
                        $PermissionsResponse = Invoke-RestMethod -Uri "$($PermissionsUrl)?requesturl=$($MappingValue.Uri)&method=$($MappingValue.Method)" -ErrorAction SilentlyContinue
                        $PermissionsResponse | ForEach-Object {
                            $Permissions += [PSCustomObject]@{
                                Name             = $_.value
                                Description      = $_.consentDisplayName
                                FullDescription  = $_.consentDescription
                                IsAdmin          = $_.IsAdmin
                                PermissionType   = $_.ScopeType
                                IsLeastPrivilege = $_.isLeastPrivilege
                            }
                        }
                        $Permissions = $Permissions | Sort-Object -Property Name -Unique
                        $Permissions = $Permissions | Sort-Object -Property PermissionType
                        $Permissions = $Permissions | Sort-Object -Property IsLeastPrivilege
                        [array]::Reverse($Permissions)
                        $MappingValue.Permissions = $Permissions
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