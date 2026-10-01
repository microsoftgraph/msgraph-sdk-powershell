<#
.SYNOPSIS
Validates the directive migration inventory tool and its reviewed Compliance mapping.
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'
$tool = Join-Path $PSScriptRoot 'Get-WrapperDirectiveMigrationInventory.ps1'
$mapping = Join-Path (Join-Path $PSScriptRoot '..\src\Compliance\wrapper') 'Compliance_directiveMigrationMap.json'
$before = & git -C (Resolve-Path (Join-Path $PSScriptRoot '..')).Path status --porcelain

$compliance = @((& $tool -Module Compliance -MappingPath $mapping -AsJson | Out-String) |
    ConvertFrom-Json)
if ($compliance.Count -ne 2) { throw "Expected 2 Compliance directives, found $($compliance.Count)." }
if (@($compliance | Where-Object Status -ne 'Mapped').Count -ne 0) {
    throw 'Every Compliance directive must be mapped.'
}
$suppression = $compliance | Where-Object DirectiveIndex -eq 1
if (@($suppression.BetaOperations | Where-Object { $_ -match '^PATCH ' }).Count -ne 1 -or
    @($suppression.BetaOperations | Where-Object { $_ -match '^DELETE ' }).Count -ne 1) {
    throw 'Compliance directive 1 must map to one beta PATCH and one beta DELETE.'
}
if ($null -ne $suppression.V1Operations -and @($suppression.V1Operations).Count -ne 0) {
    throw 'Compliance directive 1 should have no v1.0 operations.'
}
$rename = $compliance | Where-Object DirectiveIndex -eq 2
if ($rename.Implementation -ne 'StructuralNaming' -or
    @($rename.BetaOperations | Where-Object { $_ -match '^GET ' }).Count -ne 1) {
    throw 'Compliance directive 2 must map to one structurally named beta GET.'
}

$applications = @((& $tool -Module Applications -MappingPath $mapping -AsJson | Out-String) |
    ConvertFrom-Json)
if (@($applications | Where-Object Status -eq 'Deferred').Count -lt 1) {
    throw 'Applications must expose at least one deferred parameter directive.'
}
if (@($applications | Where-Object Status -eq 'Unresolved').Count -lt 1) {
    throw 'Applications must expose at least one unresolved cmdlet-surface directive.'
}
$calendar = @((& $tool -Module Calendar -MappingPath $mapping -AsJson | Out-String) |
    ConvertFrom-Json)
$resolved = @($calendar | Where-Object Status -eq 'Resolved')
if ($resolved.Count -lt 1 -or @($resolved | Where-Object Implementation -ne 'Candidate').Count -gt 0) {
    throw 'Automatically matched operation-ID directives must be candidates, not mapped migrations.'
}
$schemaDirective = @((& $tool -Module Identity.SignIns -MappingPath $mapping -AsJson | Out-String) |
    ConvertFrom-Json) | Where-Object Classification -eq 'DeferredSchema'
if (@($schemaDirective).Count -ne 1 -or $schemaDirective.Status -ne 'Deferred') {
    throw 'Schema/response directives must be classified as deferred, not unresolved.'
}

$duplicateMapping = [IO.Path]::GetTempFileName()
try {
    $document = Get-Content $mapping -Raw | ConvertFrom-Json
    $document.mappings = @($document.mappings) + @($document.mappings[0])
    $document | ConvertTo-Json -Depth 10 | Set-Content $duplicateMapping
    $failed = $false
    try {
        & $tool -Module Compliance -MappingPath $duplicateMapping | Out-Null
    }
    catch {
        $failed = $_.Exception.Message -match 'Duplicate directive mapping'
    }
    if (-not $failed) { throw 'Duplicate mappings must fail visibly.' }
}
finally {
    Remove-Item $duplicateMapping -Force -ErrorAction SilentlyContinue
}

$after = & git -C (Resolve-Path (Join-Path $PSScriptRoot '..')).Path status --porcelain
if (($before -join "`n") -ne ($after -join "`n")) {
    throw 'Inventory without -OutputPath must not modify the worktree.'
}

Write-Host 'PASS: directive migration inventory and Compliance mapping validated.'
