# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenAPIFilesPath,

    [Parameter(Mandatory = $false)]
    [Switch] $SetNavigationPropertiesAsReadOnly,

    [Parameter(Mandatory = $false)]
    [Switch] $OperationIdsOnly
)

$prepositionReplacements = @{
    By   = "GraphBPre"
    With = "GraphWPre"
    At   = "GraphAPre"
    For  = "GraphFPre"
    Of   = "GraphOPre"
    #Or   = "GraphRPre" Handling of this preposition needs to be reviewed
}

$wordReplacements = @{
    Deltum    = "delta"
    Quotum    = "quota"
    Statistic = "statistics"
}
$targetOperationIdRegex = [Regex]::new("([a-z*])($($prepositionReplacements.Keys -join "|"))([A-Z*]|$)", "Compiled")
$stopwatch = [system.diagnostics.stopwatch]::StartNew()
# Tweak prepositions in operationIds to byPass https://github.com/Azure/autorest.powershell/issues/795.
Get-ChildItem -Path $OpenAPIFilesPath -File | Where-Object {
    $_.Extension -in @('.yml', '.yaml')
} | ForEach-Object {
    $filePath = $_.FullName
    $modified = $false
    $inPaths = $false
    if ($OperationIdsOnly.IsPresent) {
        # Keep line endings and final-newline behavior unchanged in Kiota-compatible documents.
        $lines = [regex]::Split([System.IO.File]::ReadAllText($filePath), '(\r\n|\n|\r)')
    }
    else {
        $lines = Get-Content $filePath
    }
    $updatedContent = $lines | ForEach-Object {
        if ($OperationIdsOnly.IsPresent -and $_ -match '^\S') {
            $inPaths = $_ -match '^paths:'
        }
        $idMatch = $null
        if ($OperationIdsOnly.IsPresent -and $inPaths -and $_.StartsWith('      operationId:')) {
            $idMatch = [regex]::Match($_, '^(?<prefix>      operationId:[ \t]*)(?<quote>[''"]?)(?<id>[^''"\s#]+)\k<quote>(?<suffix>[ \t]*(?:#.*)?)$')
        }
        if (($_.contains("operationId:") -and -not $OperationIdsOnly.IsPresent) -or
            ($null -ne $idMatch -and $idMatch.Success)) {
            $operationId = if ($OperationIdsOnly.IsPresent) { $idMatch.Groups['id'].Value } else { $_ }
            $wordReplacements.Keys | ForEach-Object {
                if ($operationId.EndsWith($_, "CurrentCultureIgnoreCase")) {
                    $operationId = ($operationId -replace $_, $wordReplacements[$_])
                    $modified = $true
                    Write-Debug "$_ -> $operationId".Trim()
                }
            }

            if (($targetOperationIdRegex.Match($operationId)).Success) {
                $prepositionReplacements.Keys | ForEach-Object {
                    # Replace prepositions with replacement word.
                    #e.g., 'applications_GetCreatedOnBehalfOfByRef' will be renamed to 'applications_GetCreatedOnBehalfGraphOPreGraphBPreRef'.
                    $operationId = ($operationId -creplace $_, $prepositionReplacements[$_])
                    $modified = $true
                    Write-Debug "$_ -> $operationId".Trim()
                }
            }
            
            if ($OperationIdsOnly.IsPresent) {
                return $idMatch.Groups['prefix'].Value + $idMatch.Groups['quote'].Value +
                    $operationId + $idMatch.Groups['quote'].Value + $idMatch.Groups['suffix'].Value
            }
            return $operationId
        }

        if ($OperationIdsOnly.IsPresent) {
            return $_
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
    if ($modified) {
        if ($OperationIdsOnly.IsPresent) {
            [System.IO.File]::WriteAllText($filePath, ($updatedContent -join ''), [System.Text.UTF8Encoding]::new($false))
        }
        else {
            $updatedContent | Out-File $filePath -Force
        }
    }
}
$stopwatch.Stop()
Write-Debug "Tweaked '$OpenAPIFilesPath' OpenAPI files in '$($stopwatch.Elapsed.TotalMinutes)' minutes."
