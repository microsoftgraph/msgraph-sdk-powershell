<#
.SYNOPSIS
Reports how request-body properties classify across every module: bound, excluded, or
unsupported and why.

.DESCRIPTION
Runs the generator over each spec and reads the per-property diagnostics it emits, so the
numbers come from the same classifier that decides what gets bound - not a second
reimplementation that could disagree with it.

Output is a per-shape rollup (which unsupported shapes are worth implementing next) and a
per-module CSV. Required-but-unbound properties are called out separately: those are the ones
that make a cmdlet unable to complete its request at all.

.EXAMPLE
.\tools\Measure-BodyPropertyCoverage.ps1
#>
[CmdletBinding()]
param(
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$OutCsv
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $OutCsv) { $OutCsv = Join-Path $repoRoot "artifacts\body-property-coverage.$ApiVersion.csv" }

$specRoot = Join-Path $repoRoot "openApiDocs_KiotaCompat\$ApiVersion"
$generator = Join-Path $repoRoot 'tools\WrapperGenerator'
$scratch = Join-Path $repoRoot "artifacts\body-coverage-scratch"
New-Item -ItemType Directory -Force $scratch | Out-Null
New-Item -ItemType Directory -Force (Split-Path $OutCsv) | Out-Null

$rows = [System.Collections.Generic.List[object]]::new()
$specs = @(Get-ChildItem "$specRoot\*.yml" | Sort-Object Name)
# A run over no specs would report "0 unbound" - a clean bill of health from having measured
# nothing, which is the failure mode this whole sweep exists to avoid.
if ($specs.Count -eq 0) { Write-Error "No specs found under '$specRoot'."; exit 2 }
$failedSpecs = [System.Collections.Generic.List[string]]::new()

foreach ($spec in $specs) {
    $module = $spec.BaseName
    $out = Join-Path $scratch $module
    Remove-Item $out -Recurse -Force -ErrorAction SilentlyContinue
    New-Item -ItemType Directory -Force $out | Out-Null

    # Information level so the per-property diagnostics are emitted.
    $log = & dotnet run --project $generator -c Release -- `
        -d $spec.FullName -o $out -n "Microsoft.Graph.PowerShell.$module.Client" --api-version $ApiVersion --log-level Information 2>&1
    # A module that failed to generate emits no diagnostics, so its properties would silently
    # count as zero unbound and flatter the total.
    if ($LASTEXITCODE -ne 0) {
        $failedSpecs.Add("$module (exit $LASTEXITCODE)")
        Write-Warning "$module : generation failed; excluded from the totals"
        continue
    }

    foreach ($line in $log) {
        if ("$line" -match 'Unbound body property (?<noun>[^.]+)\.(?<prop>\S+): (?<shape>\w+) \(required=(?<req>\w+)\)') {
            $rows.Add([pscustomobject]@{
                    Module   = $module
                    Noun     = $Matches.noun
                    Property = $Matches.prop
                    Shape    = $Matches.shape
                    Required = [bool]::Parse($Matches.req)
                })
        }
    }
    Write-Host ("{0,-34} unbound: {1}" -f $module, @($rows | Where-Object Module -eq $module).Count)
}

# A CSV written from a partial sweep reads exactly like a complete one, so it is only produced
# when every spec generated. The population is stated beside the totals for the same reason.
if ($failedSpecs.Count -gt 0) {
    Write-Error "$($failedSpecs.Count) of $($specs.Count) specs failed to generate: $($failedSpecs -join ', '). No CSV written - these totals would understate the unbound surface."
    exit 1
}
$rows | Export-Csv $OutCsv -NoTypeInformation

# The generator reports a property per OPERATION, so an inherited property on a widely reused
# model repeats across every cmdlet that binds it. Both figures matter and mean different
# things: occurrences size the noise in a run, distinct identities size the actual work.
$identity = { "$($_.Module)|$($_.Noun)|$($_.Property)|$($_.Shape)" }
$distinct = @($rows | ForEach-Object $identity | Sort-Object -Unique)

"";  "=== unbound body properties by shape (occurrences / distinct) ==="
$rows | Group-Object Shape | Sort-Object Count -Descending |
    Select-Object Count, Name,
        @{n = 'Distinct'; e = { @($_.Group | ForEach-Object $identity | Sort-Object -Unique).Count } } |
    Format-Table -AutoSize | Out-String -Width 80

"=== distinct property names per shape (top 8 each) ==="
foreach ($g in ($rows | Group-Object Shape | Sort-Object Count -Descending)) {
    $names = ($g.Group | Select-Object -ExpandProperty Property -Unique | Select-Object -First 8) -join ', '
    "  {0,-16} {1}" -f $g.Name, $names
}

"";  "specs generated:                $($specs.Count) of $($specs.Count)"
"total unbound occurrences:      $($rows.Count)"
"distinct module/noun/prop/shape: $($distinct.Count)"
# Graph marks almost nothing required in its schemas (the overwhelming majority of required
# blocks list only @odata.type), so this count is reported for completeness and is not
# evidence that nothing important is unbound.
"flagged required in the spec:    $(@($rows | Where-Object Required -eq 'True').Count)"
"csv: $OutCsv"
