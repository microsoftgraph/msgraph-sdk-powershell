# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenAPIFilesPath
)

$prepositionReplacements = @{
    By   = "GraphBPre"
    With = "GraphWPre"
    At   = "GraphAPre"
    For  = "GraphFPre"
    Of   = "GraphOPre"
}

$targetOperationIdRegex = [Regex]::new(".*$($prepositionReplacements.Keys -join "|").*", "Compiled")
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
        return $_
    }
    if ($modified) { $updatedContent | Out-File $filePath -Force }
}
$stopwatch.Stop()
Write-Debug "Tweaked '$OpenAPIFilesPath' OpenAPI files in '$($stopwatch.Elapsed.TotalMinutes)' minutes."