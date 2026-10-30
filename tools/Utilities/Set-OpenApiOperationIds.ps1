# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string] $OpenApiFilePath,

    [Parameter(Mandatory = $true)]
    [System.Collections.IDictionary] $OperationIdDocument
)

$ErrorActionPreference = 'Stop'
$content = [System.IO.File]::ReadAllText($OpenApiFilePath)
$document = ConvertFrom-Yaml -Yaml $content -Ordered
$operationIds = [System.Collections.Generic.Dictionary[string, string]]::new([System.StringComparer]::Ordinal)
$methods = @('get', 'put', 'post', 'delete', 'options', 'head', 'patch', 'trace')

foreach ($path in $document.paths.GetEnumerator()) {
    foreach ($method in $methods) {
        $operation = $path.Value[$method]
        if (-not $operation -or -not $operation.Contains('operationId')) {
            continue
        }

        if (-not $OperationIdDocument.paths.Contains($path.Key) -or
            -not $OperationIdDocument.paths[$path.Key].Contains($method) -or
            [string]::IsNullOrWhiteSpace($OperationIdDocument.paths[$path.Key][$method].operationId)) {
            throw "Missing formatted operation ID for $($method.ToUpperInvariant()) '$($path.Key)' in '$OpenApiFilePath'."
        }

        $oldId = $operation.operationId
        $newId = $OperationIdDocument.paths[$path.Key][$method].operationId
        if ($operationIds.ContainsKey($oldId) -and $operationIds[$oldId] -cne $newId) {
            throw "Ambiguous operation ID '$oldId' in '$OpenApiFilePath'."
        }
        $operationIds[$oldId] = $newId
    }
}

# Preserve the Plain YAML verbatim outside operationId values, including composed schemas.
$pathsMatch = [regex]::Match($content, '(?ms)^paths:[ \t]*(?:#[^\r\n]*)?\r?\n(?<paths>.*?)(?=^\S|\z)')
if (-not $pathsMatch.Success) {
    throw "Cannot locate the paths section in '$OpenApiFilePath'."
}
$seenIds = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::Ordinal)
$idPattern = '(?m)^(?<prefix>      operationId:[ \t]*)(?<quote>[''"]?)(?<id>[^''"\s#]+)\k<quote>(?<suffix>[ \t]*(?:#[^\r\n]*)?)(?=\r?$)'
$updatedPaths = [regex]::Replace($pathsMatch.Groups['paths'].Value, $idPattern, {
    param($match)
    $oldId = $match.Groups['id'].Value
    if (-not $operationIds.ContainsKey($oldId)) {
        throw "Unexpected operation ID '$oldId' in '$OpenApiFilePath'."
    }
    [void] $seenIds.Add($oldId)
    return $match.Groups['prefix'].Value + $match.Groups['quote'].Value +
        $operationIds[$oldId] + $match.Groups['quote'].Value + $match.Groups['suffix'].Value
})
if ($seenIds.Count -ne $operationIds.Count) {
    throw "Not all operation IDs could be updated in '$OpenApiFilePath'."
}

$paths = $pathsMatch.Groups['paths']
$updatedContent = $content.Substring(0, $paths.Index) + $updatedPaths +
    $content.Substring($paths.Index + $paths.Length)
if ($updatedContent -cne $content) {
    [System.IO.File]::WriteAllText($OpenApiFilePath, $updatedContent, [System.Text.UTF8Encoding]::new($false))
}
