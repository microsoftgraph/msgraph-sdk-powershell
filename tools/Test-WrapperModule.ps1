<#
.SYNOPSIS
Smoke-tests built wrapper modules the way a user would: Import-Module, inventory the
cmdlets, exercise a dispatcher without a Graph session.

.DESCRIPTION
Each module is tested in a CHILD pwsh process — a fresh process per module, because
assemblies cannot be unloaded and Import-Module silently no-ops when a same-name module is
already loaded. Checks, per module:

  0. the binary is not stale                  - the dll is compared against every compiled
                                                input under src (the kiota client in Client/
                                                as well as Cmdlets/ and the csproj) and a
                                                binary older than any of them is refused,
                                                because every check below would pass against
                                                a module built before the change under test
  1. Import-Module <psd1> succeeds            - the user's first experience
  2. exported cmdlet count == manifest count  - nothing silently dropped at load
  3. no orphan workers                        - every *_Get/*_List worker has its public
                                                dispatcher exported alongside it
  4. one dispatcher invoked with dummy ids and no Graph session:
       PASS = NoGraphSession error (the call flowed dispatcher -> worker -> auth path)
       FAIL = CommandNotFound (dispatcher->worker forwarding broken: the manifest
              visibility trap) or any other unexpected error id
  5. each bound shape accepts the value a person would actually type, asserted against the
     real compiled types rather than assumed:
       complex - a model-typed parameter accepts a hashtable
       enum    - an enum-typed parameter accepts its own member name as a string
       scalar  - DateTimeOffset/Guid accept a string; kiota's Date/Time accept a [datetime]
                 (they have NO string conversion), reported as OK(n) where n is how many
                 cases the module actually exercised, so an empty pass is visible
       untyped - 19 cases run through the module's OWN compiled UntypedValue helper, reached
                 by reflection so this gate cannot drift from a copy of the converter: every
                 numeric type, string, boolean, PSObject unwrapping, object, array, nesting,
                 nested-null drop, null-element drop, empty-object omission, and the throw on
                 an unsupported type. The helper is emitted into every module, so a missing
                 helper is a failure, never n/a

Modules with no paired list+item GETs have no dispatcher; check 4 reports n/a for them.
A shape a module never binds reports n/a for that part of check 5, except untyped.

.PARAMETER Module
One or more module names previously built by Build-WrapperModule.ps1.

.PARAMETER OutputRoot
Root folder the modules were built into. Default: <repo>/artifacts/wrapper-modules.

.PARAMETER Configuration
Build configuration used. Default: Debug.

.EXAMPLE
.\tools\Test-WrapperModule.ps1 -Module Mail
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string[]]$Module,
    [string]$OutputRoot,
    [string]$Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $OutputRoot) { $OutputRoot = Join-Path $repoRoot 'artifacts\wrapper-modules' }
# The psd1 path is embedded in a script run by a CHILD process with its own working directory,
# so a relative -OutputRoot would resolve there and Import-Module would fail with a confusing
# "module not found" rather than a path error.
$OutputRoot = (Resolve-Path -LiteralPath $OutputRoot).Path

function Test-OneModule {
    param([string]$Name)

    $moduleName = "Microsoft.Graph.Wrapper.$Name"
    $psd1 = Join-Path $OutputRoot "$Name\src\bin\$Configuration\net10.0\$moduleName.psd1"
    $result = [pscustomobject]@{
        Module = $Name; Pass = $false; Exported = 0; ManifestCount = 0
        OrphanWorkers = 0; Dispatcher = ''; ErrorId = ''; ComplexBinding = ''; EnumBinding = ''; ScalarBinding = ''
        UntypedBinding = ''; Detail = ''
    }

    if (-not (Test-Path $psd1)) {
        $result.Detail = "not built: $psd1 missing (run Build-WrapperModule.ps1 first)"
        return $result
    }

    # A binary older than the sources it was built from passes every check below while proving
    # nothing about the current generator. This gate loads whatever is on disk, so staleness is
    # invisible unless it is refused here: the build and test defaults can drift apart, and a
    # module last built under a different configuration is silently days old.
    #
    # Every compiled input counts, not just the cmdlets. A module is emitted sources plus the
    # kiota client under Client/, and a regenerated client with an unchanged cmdlet is exactly
    # the case where a parameter's CLR type moves out from under the assignment - so watching
    # Cmdlets/ alone would miss the change most likely to invalidate a runtime result.
    $dll = Join-Path $OutputRoot "$Name\src\bin\$Configuration\net10.0\$moduleName.dll"
    $inputs = @(Get-ChildItem -Path (Join-Path $OutputRoot "$Name\src") -Recurse -File -Include *.cs, *.csproj -ErrorAction SilentlyContinue |
        Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' })
    if ((Test-Path $dll) -and $inputs) {
        $newest = ($inputs | Sort-Object LastWriteTimeUtc -Descending | Select-Object -First 1)
        $builtAt = (Get-Item $dll).LastWriteTimeUtc
        if ($builtAt -lt $newest.LastWriteTimeUtc) {
            $rel = $newest.FullName.Substring((Join-Path $OutputRoot "$Name\src").Length).TrimStart('\')
            $result.Detail = "stale binary: $Configuration dll built $($builtAt.ToString('MM-dd HH:mm')) predates $rel ($($newest.LastWriteTimeUtc.ToString('MM-dd HH:mm'))); rebuild with -Configuration $Configuration"
            return $result
        }
    }

    $result.ManifestCount = (Import-PowerShellDataFile -Path $psd1).CmdletsToExport.Count

    # The child prints exactly one JSON line; everything else it may write is noise.
    $inner = @"
`$ErrorActionPreference = 'Stop'
Import-Module '$psd1'
`$cmds = Get-Command -Module '$moduleName'
`$workers = @(`$cmds | Where-Object Name -match '_(Get|List)$')
`$orphans = @(`$workers | Where-Object { `$cmds.Name -notcontains (`$_.Name -replace '_(Get|List)$', '') })
`$dispatcher = `$cmds | Where-Object { `$_.Name -like 'Get-*' -and `$cmds.Name -contains "`$(`$_.Name)_List" } | Select-Object -First 1
`$errorId = 'N/A'
if (`$dispatcher) {
    `$defaultSet = `$dispatcher.ParameterSets | Where-Object IsDefault | Select-Object -First 1
    `$splat = @{}
    foreach (`$p in (`$defaultSet.Parameters | Where-Object { `$_.IsMandatory -and `$_.ParameterType -eq [string] })) {
        `$splat[`$p.Name] = 'smoke-test'
    }
    try {
        & `$dispatcher @splat -ErrorAction Stop | Out-Null
        `$errorId = 'NO-ERROR'
    }
    catch {
        `$errorId = `$_.FullyQualifiedErrorId
    }
}
# A model-typed parameter must accept a hashtable: that conversion is what makes
# -PasswordProfile @{ Password = '...' } work. Find one on any New-/Update- cmdlet and
# convert an empty hashtable to it; failure means typed binding is unusable from the shell.
`$complexBinding = 'N/A'
# Must be a model CLASS, not an enum: referenced enums are also .Client.Models.* types, and
# converting a hashtable to one is meaningless. Enums are covered by their own case below.
`$typed = `$cmds |
    Where-Object { `$_.Name -like 'New-*' -or `$_.Name -like 'Update-*' } |
    ForEach-Object { `$_.Parameters.Values } |
    Where-Object {
        `$_.ParameterType.FullName -like '*.Client.Models.*' -and -not `$_.ParameterType.IsArray -and
        -not `$_.ParameterType.IsEnum -and -not ([System.Nullable]::GetUnderlyingType(`$_.ParameterType))
    } |
    Select-Object -First 1
if (`$typed) {
    try {
        `$converted = [System.Management.Automation.LanguagePrimitives]::ConvertTo(@{}, `$typed.ParameterType)
        `$complexBinding = if (`$converted -and `$converted.GetType() -eq `$typed.ParameterType) { 'OK' } else { 'WRONG-TYPE' }
    }
    catch {
        `$complexBinding = "FAILED: `$(`$_.Exception.Message)"
    }
}

# A referenced enum binds from the string a person would type.
`$enumBinding = 'N/A'
`$enumParam = `$cmds |
    Where-Object { `$_.Name -like 'New-*' -or `$_.Name -like 'Update-*' } |
    ForEach-Object { `$_.Parameters.Values } |
    Where-Object {
        `$u = [System.Nullable]::GetUnderlyingType(`$_.ParameterType)
        `$u -and `$u.IsEnum
    } | Select-Object -First 1
if (`$enumParam) {
    `$u = [System.Nullable]::GetUnderlyingType(`$enumParam.ParameterType)
    `$sample = ([enum]::GetNames(`$u) | Select-Object -First 1)
    try {
        `$v = [System.Management.Automation.LanguagePrimitives]::ConvertTo(`$sample, `$enumParam.ParameterType)
        `$enumBinding = if ("`$v" -eq `$sample) { 'OK' } else { "WRONG-VALUE(`$v)" }
    }
    catch { `$enumBinding = "FAILED: -`$(`$enumParam.Name)" }
}
# Scalar shapes are bound from a value a person would plausibly type. Kiota's Date and Time are
# the sharp edge: they are structs with no string conversion, so they take a [datetime]
# (what Get-Date returns) and binding a string fails. Pinning that here keeps the documented
# input contract honest - the parameter compiles either way, so only a runtime check can tell.
`$scalarBinding = 'N/A'
`$scalarCases = @{
    'System.DateTimeOffset'                = '2001-04-05T00:00:00Z'
    'System.Guid'                          = '00000000-0000-0000-0000-000000000000'
    'Microsoft.Kiota.Abstractions.Date'    = [datetime]'2026-12-31'
    'Microsoft.Kiota.Abstractions.Time'    = [datetime]'2026-12-31T14:30:00'
}
`$bodyParams = @(`$cmds |
    Where-Object { `$_.Name -like 'New-*' -or `$_.Name -like 'Update-*' } |
    ForEach-Object { `$_.Parameters.Values })
`$scalarFailures = @()
`$scalarExercised = 0
foreach (`$typeName in `$scalarCases.Keys) {
    `$p = `$bodyParams | Where-Object {
        `$u = [System.Nullable]::GetUnderlyingType(`$_.ParameterType)
        `$u -and `$u.FullName -eq `$typeName
    } | Select-Object -First 1
    if (-not `$p) { continue }
    `$scalarExercised++
    try {
        `$null = [System.Management.Automation.LanguagePrimitives]::ConvertTo(`$scalarCases[`$typeName], `$p.ParameterType)
    }
    catch {
        `$scalarFailures += "-`$(`$p.Name) rejects `$typeName input"
    }
}
# Reporting OK when no case matched would be a pass that proves nothing, so the count of
# cases actually exercised is carried in the result instead of being assumed.
if (`$scalarFailures) { `$scalarBinding = "FAILED: `$(`$scalarFailures -join ', ')" }
elseif (`$scalarExercised -gt 0) { `$scalarBinding = "OK(`$scalarExercised)" }

# The schema-less converter is the one piece of emitted logic no compiler can check: every
# branch produces a UntypedNode, so a wrong branch sends a value the caller never wrote and
# still builds. The matrix runs the compiled helper inside the module under test - reached by
# reflection because it is internal - so it cannot drift from a copy kept in this script.
# UntypedValue is emitted into every module, so a module that cannot produce it is a failure,
# never N/A.
`$untypedBinding = 'NOT-FOUND'
`$untypedType = `$null
try {
    `$impl = `$cmds | Where-Object { `$_.CommandType -eq 'Cmdlet' } | Select-Object -First 1
    `$untypedType = @(`$impl.ImplementingType.Assembly.GetTypes() |
        Where-Object { `$_.Name -eq 'UntypedValue' })[0]
}
catch { `$untypedType = `$null }
if (`$untypedType) {
    `$from = `$untypedType.GetMethod('From', [Reflection.BindingFlags]'Public,Static')
    # Expect: node type name; '' means the property is omitted; 'THROW' means refused.
    `$untypedCases = @(
        @{ N = 'string';                    V = 'hello';           T = 'UntypedString';  Val = 'hello' }
        @{ N = 'boolean';                   V = `$true;             T = 'UntypedBoolean'; Val = 'True' }
        @{ N = 'int32';                     V = [int]42;           T = 'UntypedInteger'; Val = '42' }
        @{ N = 'int64';                     V = [long]9000000000;  T = 'UntypedLong';    Val = '9000000000' }
        @{ N = 'float';                     V = [float]1.5;        T = 'UntypedFloat';   Val = '1.5' }
        @{ N = 'double';                    V = [double]2.5;       T = 'UntypedDouble';  Val = '2.5' }
        @{ N = 'decimal';                   V = [decimal]3.5;      T = 'UntypedDecimal'; Val = '3.5' }
        @{ N = 'unsigned byte';             V = [byte]7;           T = 'UntypedInteger'; Val = '7' }
        @{ N = 'unsigned int';              V = [uint32]8;         T = 'UntypedInteger'; Val = '8' }
        @{ N = 'PSObject wrapper unwrapped'; V = [psobject]::AsPSObject('wrapped'); T = 'UntypedString'; Val = 'wrapped' }
        @{ N = 'hashtable';                 V = @{ a = 'x' };                T = 'UntypedObject'; Count = 1 }
        @{ N = 'nested hashtable';          V = @{ o = @{ i = 'x' } };       T = 'UntypedObject'; Count = 1 }
        @{ N = 'array';                     V = @(1, 2);                     T = 'UntypedArray';  Count = 2 }
        @{ N = 'null omitted';              V = `$null;                       T = '' }
        @{ N = 'empty object omitted';      V = @{};                         T = '' }
        @{ N = 'all-null object omitted';   V = @{ a = `$null };              T = '' }
        @{ N = 'nested null dropped, sibling kept'; V = @{ a = 'x'; b = `$null }; T = 'UntypedObject'; Count = 1 }
        @{ N = 'null array element dropped'; V = @(1, `$null, 2);             T = 'UntypedArray';  Count = 2 }
        @{ N = 'unsupported type refused';  V = { 1 };                       T = 'THROW' }
    )
    `$untypedFailures = @()
    foreach (`$case in `$untypedCases) {
        # A one-element object[] built by hand: @(`$v) unrolls an array argument into the wrong arity.
        `$callArgs = New-Object object[] 1
        `$callArgs[0] = `$case.V
        `$threw = `$false
        `$node = `$null
        try { `$node = `$from.Invoke(`$null, `$callArgs) }
        catch { `$threw = `$true }

        if (`$case.T -eq 'THROW') {
            if (-not `$threw) { `$untypedFailures += "`$(`$case.N): accepted" }
            continue
        }
        if (`$threw) { `$untypedFailures += "`$(`$case.N): threw"; continue }
        if (`$case.T -eq '') {
            if (`$null -ne `$node) { `$untypedFailures += "`$(`$case.N): sent `$(`$node.GetType().Name)" }
            continue
        }
        if (`$null -eq `$node) { `$untypedFailures += "`$(`$case.N): omitted"; continue }
        if (`$node.GetType().Name -ne `$case.T) {
            `$untypedFailures += "`$(`$case.N): `$(`$node.GetType().Name) not `$(`$case.T)"
            continue
        }
        if (`$case.ContainsKey('Val') -and "`$(`$node.GetValue())" -ne `$case.Val) {
            `$untypedFailures += "`$(`$case.N): value `$(`$node.GetValue()) not `$(`$case.Val)"
        }
        if (`$case.ContainsKey('Count')) {
            `$actual = @(`$node.GetValue()).Count
            if (`$actual -ne `$case.Count) { `$untypedFailures += "`$(`$case.N): `$actual members not `$(`$case.Count)" }
        }
    }
    `$untypedBinding = if (`$untypedFailures) { "FAILED: `$(`$untypedFailures -join '; ')" }
                      else { "OK(`$(`$untypedCases.Count))" }
}

[pscustomobject]@{
    Exported = `$cmds.Count
    OrphanWorkers = `$orphans.Count
    Dispatcher = if (`$dispatcher) { `$dispatcher.Name } else { '' }
    ErrorId = `$errorId
    ComplexBinding = `$complexBinding
    EnumBinding = `$enumBinding
    ScalarBinding = `$scalarBinding
    UntypedBinding = `$untypedBinding
} | ConvertTo-Json -Compress
"@

    $encoded = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($inner))
    $output = & pwsh -NoProfile -NonInteractive -EncodedCommand $encoded 2>&1
    if ($LASTEXITCODE -ne 0) {
        $result.Detail = "Import-Module failed: $(($output | Select-Object -Last 2) -join ' | ')"
        return $result
    }

    $json = $output | Where-Object { $_ -match '^\{' } | Select-Object -Last 1
    if (-not $json) { $result.Detail = 'child produced no result'; return $result }
    $r = $json | ConvertFrom-Json

    $result.Exported = $r.Exported
    $result.OrphanWorkers = $r.OrphanWorkers
    $result.Dispatcher = $r.Dispatcher
    $result.ErrorId = $r.ErrorId
    $result.ComplexBinding = $r.ComplexBinding
    $result.EnumBinding = $r.EnumBinding
    $result.ScalarBinding = $r.ScalarBinding
    $result.UntypedBinding = $r.UntypedBinding

    if ($r.Exported -ne $result.ManifestCount) {
        $result.Detail = "exported $($r.Exported) != manifest $($result.ManifestCount)"
    }
    elseif ($r.OrphanWorkers -gt 0) {
        $result.Detail = "$($r.OrphanWorkers) worker(s) without their dispatcher"
    }
    elseif ($r.ErrorId -notin @('N/A') -and $r.ErrorId -notlike 'NoGraphSession*') {
        $result.Detail = if ($r.ErrorId -like '*CommandNotFound*') {
            "dispatcher->worker forwarding broken (manifest visibility trap): $($r.ErrorId)"
        } else {
            "unexpected error id: $($r.ErrorId)"
        }
    }
    elseif ($r.ComplexBinding -notin @('OK', 'N/A')) {
        $result.Detail = "complex parameter does not accept a hashtable: $($r.ComplexBinding)"
    }
    elseif ($r.EnumBinding -notin @('OK', 'N/A')) {
        $result.Detail = "enum parameter does not accept its own member name: $($r.EnumBinding)"
    }
    elseif ($r.ScalarBinding -ne 'N/A' -and $r.ScalarBinding -notlike 'OK(*') {
        $result.Detail = "scalar parameter rejects its documented input: $($r.ScalarBinding)"
    }
    # No N/A escape: UntypedValue is emitted into every module, so a missing helper or a zero
    # count is a failure rather than a module that had nothing to test.
    elseif ($r.UntypedBinding -notlike 'OK(*') {
        $result.Detail = "schema-less conversion is wrong: $($r.UntypedBinding)"
    }
    else {
        $result.Pass = $true
    }
    return $result
}

$results = foreach ($name in $Module) {
    Write-Host "=== $name ===" -ForegroundColor Cyan
    $r = Test-OneModule -Name $name
    if ($r.Pass) {
        Write-Host "  PASS: $($r.Exported) cmdlets; dispatcher $($r.Dispatcher) -> $($r.ErrorId); complex $($r.ComplexBinding); enum $($r.EnumBinding); scalar $($r.ScalarBinding); untyped $($r.UntypedBinding)" -ForegroundColor Green
    }
    else {
        Write-Host "  FAIL: $($r.Detail)" -ForegroundColor Yellow
    }
    $r
}

Write-Host ''
$results | Format-Table Module, Pass, Exported, ManifestCount, OrphanWorkers, Dispatcher, ErrorId -AutoSize | Out-Host

if ($results.Pass -contains $false) { exit 1 }
exit 0
