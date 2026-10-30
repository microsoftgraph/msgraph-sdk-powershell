<#
.SYNOPSIS
Writes a reviewable inventory of the committed wrapper output under src/<Module>/wrapper/<ApiVersion>/.

.DESCRIPTION
The committed output is tens of thousands of generated files - far past what GitHub renders in
a diff and far past what anyone reads. This emits the summary a reviewer actually can read:
one CSV row per exported cmdlet (module, verb, noun, request path, source file) plus a
per-module rollup, so "what does this generator produce" and "what changed since last time"
are answerable from a diff of two small files instead of a diff of the tree.

Cmdlet names come from the emitted [Cmdlet(VerbsX.Verb, "Noun")] attribute and the request
paths from every emitted [GraphRoute] (falling back to the kiota chain for old sources).
The generated source is the source of truth, so the manifest cannot drift from what the
module will actually export.

Internal *_Get/*_List and *_RouteN[_Get/_List] workers are listed with IsWorker = True:
they are real emitted files but not part of the surface a user calls, and separating them
keeps the cmdlet count honest. (The
psd1 currently exports them anyway - the dispatcher resolves them by name at runtime - which is
a dispatch-design question tracked with the module-wiring work, not a manifest concern.)

.EXAMPLE
.\tools\New-WrapperOutputManifest.ps1
.EXAMPLE
.\tools\New-WrapperOutputManifest.ps1 -ApiVersion v1.0
#>
[CmdletBinding()]
param(
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$OutDir,
    [string]$GeneratedRoot = "$PSScriptRoot\..\src"
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
# docs/ already holds versioned CSV inventories of the shipped surface
# (PowerShellBreakingChanges-V1.0.csv); this follows that placement and naming.
if (-not $OutDir) { $OutDir = Join-Path $repoRoot 'docs' }
$versionTag = if ($ApiVersion -eq 'v1.0') { 'V1.0' } else { 'Beta' }

# Same attribute pattern the parity gate and Build-WrapperModule use.
$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'
# The kiota chain the cmdlet calls, e.g. "client.Users[UserId].Messages.GetAsync()".
$builderPattern = 'client\.([A-Za-z0-9_\[\]\.]+?)\.(?:Get|Post|Patch|Delete|Put)Async'
$routePattern = '\[GraphRoute\("((?:\\.|[^"\\])*)",\s*"((?:\\.|[^"\\])*)"(?:,\s*ParameterSetName\s*=\s*"((?:\\.|[^"\\])*)")?\)\]'

$rows = [System.Collections.Generic.List[object]]::new()
$moduleDirs = Get-ChildItem $GeneratedRoot -Directory |
    ForEach-Object { Join-Path $_.FullName "wrapper\$ApiVersion\Cmdlets" } |
    Where-Object { Test-Path $_ }

foreach ($dir in $moduleDirs) {
    $module = (Get-Item $dir).Parent.Parent.Parent.Name
    foreach ($file in Get-ChildItem $dir -Filter '*.g.cs' -File) {
        if ($file.Name -eq 'Shared.g.cs') { continue }
        $text = Get-Content $file.FullName -Raw
        $m = [regex]::Match($text, $cmdletAttrPattern)
        if (-not $m.Success) { continue }
        $b = [regex]::Match($text, $builderPattern)
        $routes = @([regex]::Matches($text, $routePattern))
        $isWorker = $file.Name -match '(_Route\d+(_(Get|List))?|_(Get|List))\.g\.cs$'
        $rows.Add([pscustomobject]@{
                Module      = $module
                ApiVersion  = $ApiVersion
                Cmdlet      = "$($m.Groups[1].Value)-$([regex]::Unescape($m.Groups[2].Value))"
                Verb        = $m.Groups[1].Value
                Noun        = [regex]::Unescape($m.Groups[2].Value)
                RequestPath = if ($routes.Count -gt 0) {
                    ($routes | ForEach-Object { "$([regex]::Unescape($_.Groups[1].Value)) $([regex]::Unescape($_.Groups[2].Value))" }) -join ';'
                } elseif ($b.Success) { $b.Groups[1].Value } elseif (-not $isWorker) { '(dispatcher)' } else { '' }
                IsWorker    = $isWorker
                File        = $file.Name
            })
    }
}

if ($rows.Count -eq 0) { throw "No wrapper output found for $ApiVersion under $GeneratedRoot/*/wrapper/$ApiVersion/Cmdlets." }

$manifestPath = Join-Path $OutDir "WrapperCmdlets-$versionTag.csv"
$rows | Sort-Object Module, Cmdlet, File | Export-Csv $manifestPath -NoTypeInformation

$summaryPath = Join-Path $OutDir "WrapperCmdlets-$versionTag-Summary.csv"
$rows | Group-Object Module | ForEach-Object {
    $public = @($_.Group | Where-Object { -not $_.IsWorker })
    [pscustomobject]@{
        Module      = $_.Name
        Cmdlets     = $public.Count
        WorkerFiles = $_.Count - $public.Count
        Get         = @($public | Where-Object Verb -eq 'Get').Count
        New         = @($public | Where-Object Verb -eq 'New').Count
        Update      = @($public | Where-Object Verb -eq 'Update').Count
        Remove      = @($public | Where-Object Verb -eq 'Remove').Count
    }
} | Sort-Object Cmdlets -Descending | Export-Csv $summaryPath -NoTypeInformation

$publicTotal = @($rows | Where-Object { -not $_.IsWorker }).Count
"modules: $($rows | Group-Object Module | Measure-Object | Select-Object -ExpandProperty Count)"
"public cmdlets: $publicTotal"
"worker files: $($rows.Count - $publicTotal)"
"wrote $manifestPath"
"wrote $summaryPath"
