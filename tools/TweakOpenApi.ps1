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
    $fileContent = Get-Content -Path $filePath | ConvertFrom-Yaml -Ordered
    $modified = $false
    # Modify '/$ref' operationIds (*ByRef) to byPass -> https://github.com/Azure/autorest.powershell/issues/795.
    $fileContent.paths.Keys -like "*`$ref" | ForEach-Object {
        $requestUri = $_
        # Matches '_{ActionName}' in operationIds formatted as '{entitySet}_{ActionName}{NavigationProperty}'. e.g.,
        # For 'applications_GetCreatedOnBehalfOfByRef', we will match '_Get'.
        $ActionPattern = [Regex]::new("(_[A-Z][a-z]+)", "Compiled")
        foreach ($method in $fileContent.paths[$requestUri].GetEnumerator()) {
            $operationId = $fileContent.paths[$requestUri][$method.Name].operationId
            if ($operationId.EndsWith($TargetWord)) {
                $operationId = $operationId.Replace($TargetWord, "")
                $match = $ActionPattern.Match($operationId)
                if ($match -ne $null -and $match.Success) {
                    # Suffix matched '_{ActionName}' with 'GraphRef'. GraphRef will be our safe unique word for identifying *ByRef commands in PowerShell e.g.,
                    # 'applications_GetCreatedOnBehalfOf' -> 'applications_GetGraphRefCreatedOnBehalfOf'.
                    $fileContent.paths[$requestUri][$method.Name].operationId = ($operationId -replace $match.Value, "$($match.Value)$ReplacementWord")
                    $Modified = $true
                }
            }
        }
        if ($modified) { $fileContent | ConvertTo-Yaml -OutFile $filePath -Force }
    }
}
$stopwatch.Stop()
Write-Debug "Tweaked '$OpenAPIFilesPath' OpenAPI files in '$($Stopwatch.Elapsed.TotalMinutes)` minutes."