# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenApiFilesPath,

    [Parameter(Mandatory = $false)]
    [ValidateRange(0, [int]::MaxValue)]
    [int] $RemovalDateBufferDays = 2,

    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [string] $ReportPath,

    [Parameter(Mandatory = $false)]
    [datetime] $ReferenceDateUtc = [datetime]::UtcNow
)

$ErrorActionPreference = 'Stop'
$httpOperationPattern = '^    (?<method>get|put|post|delete|options|head|patch|trace):\s*(?:#.*)?$'
$pathPattern = '^  (?:(?<quote>[''"])(?<uri>/.+)\k<quote>|(?<uri>/[^:]*)):\s*(?:#.*)?$'
$cutoffDate = $ReferenceDateUtc.ToUniversalTime().Date.AddDays(-$RemovalDateBufferDays)

function Read-TextFile {
    param(
        [Parameter(Mandatory = $true)]
        [string] $Path
    )

    $reader = [System.IO.StreamReader]::new(
        $Path,
        [System.Text.UTF8Encoding]::new($false),
        $true
    )
    try {
        $text = $reader.ReadToEnd()
        return [pscustomobject]@{
            Text     = $text
            Encoding = $reader.CurrentEncoding
        }
    }
    finally {
        $reader.Dispose()
    }
}

function Get-RemovalDate {
    param(
        [Parameter(Mandatory = $true)]
        [string[]] $Lines,

        [Parameter(Mandatory = $true)]
        [int] $OperationStart,

        [Parameter(Mandatory = $true)]
        [int] $OperationEnd,

        [Parameter(Mandatory = $true)]
        [string] $FilePath,

        [Parameter(Mandatory = $true)]
        [string] $Uri,

        [Parameter(Mandatory = $true)]
        [string] $Method
    )

    $hasDeprecatedLabel = $false
    $deprecationExtensionIndex = -1
    for ($lineIndex = $OperationStart + 1; $lineIndex -lt $OperationEnd; $lineIndex++) {
        $line = $Lines[$lineIndex].TrimEnd([char[]]"`r`n")
        if ($line -match '^      deprecated:\s*true\s*(?:#.*)?$') {
            $hasDeprecatedLabel = $true
        }
        elseif ($line -match '^      x-ms-deprecation:\s*(?:#.*)?$') {
            $deprecationExtensionIndex = $lineIndex
        }
    }

    if (-not $hasDeprecatedLabel -or $deprecationExtensionIndex -lt 0) {
        return $null
    }

    for ($lineIndex = $deprecationExtensionIndex + 1; $lineIndex -lt $OperationEnd; $lineIndex++) {
        $line = $Lines[$lineIndex].TrimEnd([char[]]"`r`n")
        if ($line -match '^ {0,6}\S') {
            break
        }

        if ($line -match '^        removalDate:\s*(?<value>[^#]*?)\s*(?:#.*)?$') {
            $value = $Matches.value.Trim()
            if (
                $value.Length -ge 2 -and
                (($value.StartsWith("'") -and $value.EndsWith("'")) -or
                ($value.StartsWith('"') -and $value.EndsWith('"')))
            ) {
                $value = $value.Substring(1, $value.Length - 2)
            }

            $removalDate = [datetime]::MinValue
            $isValidDate = [datetime]::TryParseExact(
                $value,
                'yyyy-MM-dd',
                [System.Globalization.CultureInfo]::InvariantCulture,
                [System.Globalization.DateTimeStyles]::None,
                [ref] $removalDate
            )
            if (-not $isValidDate) {
                throw "Invalid removalDate '$value' for $($Method.ToUpperInvariant()) '$Uri' in '$FilePath'. Expected yyyy-MM-dd."
            }

            return $removalDate.Date
        }
    }

    return $null
}

function Remove-LineRanges {
    param(
        [Parameter(Mandatory = $true)]
        [string[]] $Lines,

        [Parameter(Mandatory = $true)]
        [AllowEmptyCollection()]
        [object[]] $Ranges
    )

    if ($Ranges.Count -eq 0) {
        return ($Lines -join '')
    }

    $builder = [System.Text.StringBuilder]::new()
    $cursor = 0
    foreach ($range in ($Ranges | Sort-Object Start)) {
        while ($cursor -lt $range.Start) {
            [void] $builder.Append($Lines[$cursor])
            $cursor++
        }
        $cursor = $range.End
    }
    while ($cursor -lt $Lines.Count) {
        [void] $builder.Append($Lines[$cursor])
        $cursor++
    }

    return $builder.ToString()
}

function Get-OpenApiPruningPlan {
    param(
        [Parameter(Mandatory = $true)]
        [System.IO.FileInfo] $File,

        [Parameter(Mandatory = $true)]
        [datetime] $CutoffDate
    )

    $fileContent = Read-TextFile -Path $File.FullName
    $lines = [regex]::Split($fileContent.Text, '(?<=\n)')
    $pathsStart = -1
    $pathsEnd = $lines.Count

    for ($lineIndex = 0; $lineIndex -lt $lines.Count; $lineIndex++) {
        $line = $lines[$lineIndex].TrimEnd([char[]]"`r`n")
        if ($line -match '^paths:\s*(?:#.*)?$') {
            $pathsStart = $lineIndex
            break
        }
    }

    if ($pathsStart -lt 0) {
        return [pscustomobject]@{
            File            = $File
            Encoding        = $fileContent.Encoding
            UpdatedContent  = $fileContent.Text
            RemovalEntries  = @()
            RemovedCount    = 0
        }
    }

    for ($lineIndex = $pathsStart + 1; $lineIndex -lt $lines.Count; $lineIndex++) {
        $line = $lines[$lineIndex].TrimEnd([char[]]"`r`n")
        if ($line -match '^\S') {
            $pathsEnd = $lineIndex
            break
        }
    }

    $pathStarts = [System.Collections.Generic.List[object]]::new()
    $hasPathObjectExtensions = $false
    for ($lineIndex = $pathsStart + 1; $lineIndex -lt $pathsEnd; $lineIndex++) {
        $line = $lines[$lineIndex].TrimEnd([char[]]"`r`n")
        if ($line -match $pathPattern) {
            $pathStarts.Add([pscustomobject]@{
                Start = $lineIndex
                Uri   = $Matches.uri
            })
        }
        elseif ($line -match '^  (?!#)\S') {
            $hasPathObjectExtensions = $true
        }
    }

    $rangesToRemove = [System.Collections.Generic.List[object]]::new()
    $removalEntries = [System.Collections.Generic.List[object]]::new()
    $removedPathCount = 0
    for ($pathIndex = 0; $pathIndex -lt $pathStarts.Count; $pathIndex++) {
        $path = $pathStarts[$pathIndex]
        $pathEnd = $pathsEnd
        for ($lineIndex = $path.Start + 1; $lineIndex -lt $pathsEnd; $lineIndex++) {
            $line = $lines[$lineIndex].TrimEnd([char[]]"`r`n")
            if ($line -match '^  \S') {
                $pathEnd = $lineIndex
                break
            }
        }

        $operations = [System.Collections.Generic.List[object]]::new()
        for ($lineIndex = $path.Start + 1; $lineIndex -lt $pathEnd; $lineIndex++) {
            $line = $lines[$lineIndex].TrimEnd([char[]]"`r`n")
            if ($line -match $httpOperationPattern) {
                $method = $Matches.method.ToLowerInvariant()
                $operationEnd = $pathEnd
                for ($nextLineIndex = $lineIndex + 1; $nextLineIndex -lt $pathEnd; $nextLineIndex++) {
                    $nextLine = $lines[$nextLineIndex].TrimEnd([char[]]"`r`n")
                    if ($nextLine -match '^ {0,4}\S') {
                        $operationEnd = $nextLineIndex
                        break
                    }
                }

                $operations.Add([pscustomobject]@{
                    Start  = $lineIndex
                    End    = $operationEnd
                    Method = $method
                })
            }
        }

        if ($operations.Count -eq 0) {
            continue
        }

        $expiredOperations = [System.Collections.Generic.List[object]]::new()
        foreach ($operation in $operations) {
            $removalDate = Get-RemovalDate `
                -Lines $lines `
                -OperationStart $operation.Start `
                -OperationEnd $operation.End `
                -FilePath $File.FullName `
                -Uri $path.Uri `
                -Method $operation.Method
            if ($null -ne $removalDate -and $removalDate -le $CutoffDate) {
                $expiredOperations.Add($operation)
            }
        }

        if ($expiredOperations.Count -eq 0) {
            continue
        }

        $uriRemoved = $expiredOperations.Count -eq $operations.Count
        if ($uriRemoved) {
            $removedPathCount++
            $rangesToRemove.Add([pscustomobject]@{
                Start = $path.Start
                End   = $pathEnd
            })
        }
        else {
            foreach ($operation in $expiredOperations) {
                $rangesToRemove.Add([pscustomobject]@{
                    Start = $operation.Start
                    End   = $operation.End
                })
            }
        }

        $removalEntries.Add([pscustomobject]@{
            Uri               = $path.Uri
            OperationsRemoved = @($expiredOperations.Method)
            UriRemoved        = $uriRemoved
        })
    }

    if (
        $pathStarts.Count -gt 0 -and
        $removedPathCount -eq $pathStarts.Count -and
        -not $hasPathObjectExtensions
    ) {
        $pathsLineEnding = if ($lines[$pathsStart].EndsWith("`r`n")) {
            "`r`n"
        }
        elseif ($lines[$pathsStart].EndsWith("`n")) {
            "`n"
        }
        else {
            ''
        }
        $lines[$pathsStart] = "paths: {}$pathsLineEnding"
    }

    return [pscustomobject]@{
        File            = $File
        Encoding        = $fileContent.Encoding
        UpdatedContent  = Remove-LineRanges -Lines $lines -Ranges $rangesToRemove
        RemovalEntries  = @($removalEntries)
        RemovedCount    = ($removalEntries | ForEach-Object { $_.OperationsRemoved.Count } | Measure-Object -Sum).Sum
    }
}

$resolvedPath = Resolve-Path -LiteralPath $OpenApiFilesPath
if (Test-Path -LiteralPath $resolvedPath -PathType Container) {
    $openApiFiles = @(Get-ChildItem -LiteralPath $resolvedPath -File -Filter '*.yml' | Sort-Object Name)
    $defaultReportDirectory = $resolvedPath.Path
}
else {
    $openApiFile = Get-Item -LiteralPath $resolvedPath
    if ($openApiFile.Extension -notin @('.yml', '.yaml')) {
        throw "OpenAPI file '$resolvedPath' must have a .yml or .yaml extension."
    }
    $openApiFiles = @($openApiFile)
    $defaultReportDirectory = $openApiFile.DirectoryName
}

if ($openApiFiles.Count -eq 0) {
    throw "No OpenAPI .yml files were found at '$resolvedPath'."
}

if ([string]::IsNullOrWhiteSpace($ReportPath)) {
    $ReportPath = Join-Path $defaultReportDirectory 'deprecated-removals.json'
}
elseif (-not [System.IO.Path]::IsPathRooted($ReportPath)) {
    $ReportPath = Join-Path $defaultReportDirectory $ReportPath
}

# Build and validate every plan before modifying any OpenAPI document.
$pruningPlans = @(
    foreach ($openApiFile in $openApiFiles) {
        Get-OpenApiPruningPlan -File $openApiFile -CutoffDate $cutoffDate
    }
)

$modules = [ordered]@{}
$totalOperationsRemoved = 0
foreach ($plan in $pruningPlans) {
    if ($plan.RemovalEntries.Count -eq 0) {
        continue
    }

    $moduleRemovals = [ordered]@{}
    foreach ($entry in $plan.RemovalEntries) {
        $moduleRemovals[$entry.Uri] = [ordered]@{
            operationsRemoved = @($entry.OperationsRemoved)
            uriRemoved        = $entry.UriRemoved
        }
    }
    $modules[$plan.File.BaseName] = $moduleRemovals
    $totalOperationsRemoved += $plan.RemovedCount
}

$report = [ordered]@{
    generatedAtUtc = [datetime]::UtcNow.ToString('o')
    cutoffDate     = $cutoffDate.ToString('yyyy-MM-dd')
    bufferDays     = $RemovalDateBufferDays
    modules        = $modules
}
$reportJson = $report | ConvertTo-Json -Depth 10
$fullReportPath = [System.IO.Path]::GetFullPath($ReportPath)
$reportDirectory = [System.IO.Path]::GetDirectoryName($fullReportPath)
if (-not [System.IO.Directory]::Exists($reportDirectory)) {
    throw "Report directory '$reportDirectory' does not exist."
}

# Prove that the report destination is writable before modifying any OpenAPI document.
$temporaryReportPath = Join-Path `
    $reportDirectory `
    ".$([System.IO.Path]::GetFileName($fullReportPath)).$([guid]::NewGuid()).tmp"
[System.IO.File]::WriteAllText(
    $temporaryReportPath,
    "$reportJson$([Environment]::NewLine)",
    [System.Text.UTF8Encoding]::new($false)
)

try {
    foreach ($plan in $pruningPlans) {
        if ($plan.RemovalEntries.Count -gt 0) {
            [System.IO.File]::WriteAllText(
                $plan.File.FullName,
                $plan.UpdatedContent,
                $plan.Encoding
            )
        }
    }
    [System.IO.File]::Move($temporaryReportPath, $fullReportPath, $true)
}
finally {
    if ([System.IO.File]::Exists($temporaryReportPath)) {
        [System.IO.File]::Delete($temporaryReportPath)
    }
}

Write-Host "Removed $totalOperationsRemoved expired deprecated operation(s). Report: $fullReportPath"
