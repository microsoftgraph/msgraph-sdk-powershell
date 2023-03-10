﻿# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenAPIFilesPath,

    [Parameter(Mandatory = $false)]
    [Switch] $SetNavigationPropertiesAsReadOnly
)

$prepositionReplacements = @{
    By   = "GraphBPre"
    With = "GraphWPre"
    At   = "GraphAPre"
    For  = "GraphFPre"
    Of   = "GraphOPre"
}
$targetOperationIdRegex = [Regex]::new("([a-z*])($($prepositionReplacements.Keys -join "|"))([A-Z*]|$)", "Compiled")
$stopwatch = [system.diagnostics.stopwatch]::StartNew()
# Tweak prepositions in operationIds to byPass https://github.com/Azure/autorest.powershell/issues/795.
Get-ChildItem -Path $OpenAPIFilesPath | ForEach-Object {
    $filePath = $_.FullName
    $modified = $false
    $updatedContent = Get-Content $filePath | ForEach-Object {
        if ($_.contains("operationId:") -and ($targetOperationIdRegex.Match($_)).Success) {
            $operationId = $_
            $prepositionReplacements.Keys | ForEach-Object {
                # Replace prepositions with replacement word.
                #e.g., 'applications_GetCreatedOnBehalfOfByRef' will be renamed to 'applications_GetCreatedOnBehalfGraphOPreGraphBPreRef'.
                $operationId = ($operationId -creplace $_, $prepositionReplacements[$_])
                $modified = $true
            }
            Write-Debug "$_ -> $operationId".Trim()
            return $operationId
        }

        if ($SetNavigationPropertiesAsReadOnly.IsPresent -and $_.contains("x-ms-navigationProperty: true")) {
            # Mark navigation properties as readOnly.
            $navigationPropertyExtension = ($_ -replace "x-ms-navigationProperty", "readOnly")
            $modified = $true
            return $navigationPropertyExtension
        }

        if ($_ -match "'2\d\d':") {
            # Replace '2\d\d' with '2xx' to avoid status code mismatch errors.
            $newStatusCode = ($_ -replace $Matches[0], "2XX:")
            $modified = $true
            return $newStatusCode
        }

        return $_
    }
    if ($modified) { $updatedContent | Out-File $filePath -Force }
}
$stopwatch.Stop()
Write-Debug "Tweaked '$OpenAPIFilesPath' OpenAPI files in '$($stopwatch.Elapsed.TotalMinutes)' minutes."
