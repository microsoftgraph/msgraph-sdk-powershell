# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenAPIFilesPath
)

$TargetWord = "ByRef"
$ReplacementWord = "GraphRef"
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
Get-ChildItem -Path $OpenAPIFilesPath | ForEach-Object {
    $filePath = $_.FullName
    $modified = $false
    $updatedContent = Get-Content $filePath | ForEach-Object {
        # Tweak '/$ref' operationIds (*ByRef) to byPass -> https://github.com/Azure/autorest.powershell/issues/795.
        if ($_.endsWith($TargetWord) -and $_.contains("operationId:")) {
            $operationId = $_
            # Matches '_{ActionName}' in operationIds formatted as '{entitySet}_{ActionName}{NavigationProperty}'. e.g.,
            # For 'applications_GetCreatedOnBehalfOfByRef', we will match '_Get'.
            $actionPattern = [Regex]::new("(_[A-Z][a-z]+)", "Compiled")
            $match = $actionPattern.Match($operationId)
            if ($match -ne $null -and $match.Success) {
                $operationId = $operationId.Replace($TargetWord, "")
                # Suffix matched '_{ActionName}' with 'GraphRef'. GraphRef will be our safe unique word for identifying *ByRef commands in PowerShell e.g.,
                # 'applications_GetCreatedOnBehalfOfByRef' will be renamed to 'applications_GetGraphRefCreatedOnBehalfOf'.
                $operationId = ($operationId -replace $match.Value, "$($match.Value)$ReplacementWord")
                $modified = $true
            }
            return $operationId
        }
        return $_
    }
    if ($modified) { $updatedContent | Out-File $filePath -Force }
}
$stopwatch.Stop()
Write-Debug "Tweaked '$OpenAPIFilesPath' OpenAPI files in '$($Stopwatch.Elapsed.TotalMinutes)' minutes."