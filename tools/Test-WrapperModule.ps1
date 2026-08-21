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
One or more service module names, e.g. Mail. The package for each is located under
<ArtifactsLocation>/<Module>/.

.PARAMETER ArtifactsLocation
Folder holding one subfolder of packages per module. Default: <repo>/artifacts.

.PARAMETER PackagePath
Test these package files directly instead of locating them by module name. Useful for a package
produced somewhere other than the artifacts layout.

.EXAMPLE
.\tools\Test-WrapperModule.ps1 -Module Mail

.EXAMPLE
.\tools\Test-WrapperModule.ps1 -PackagePath .\out\Microsoft.Graph.Mail.2.39.0.nupkg
#>
[CmdletBinding()]
param(
    [string[]]$Module = @(),
    [string[]]$PackagePath = @(),
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$ArtifactsLocation
)

$ErrorActionPreference = 'Stop'

# Everything below reads the PRODUCED PACKAGE, never a build directory. Importing bin/ output
# proves the compiler ran; it does not prove the artifact a user installs contains the assembly,
# its dependencies and a manifest that agrees with them. Those are different failures, and only
# the package can show the second. Working from the package also removes any need to know the
# target framework here - the build output folder is never addressed - so this script cannot go
# stale when the projects retarget.
Add-Type -AssemblyName System.IO.Compression.FileSystem

function Expand-ModulePackage {
    param([Parameter(Mandatory)][string]$Path, [Parameter(Mandatory)][string]$Destination)

    $zip = [System.IO.Compression.ZipFile]::OpenRead($Path)
    try {
        foreach ($entry in $zip.Entries) {
            # NuGet infrastructure is not module content.
            if ($entry.FullName -match '^(_rels|package)/' -or $entry.FullName -eq '[Content_Types].xml' -or $entry.FullName.EndsWith('.nuspec')) { continue }
            if (-not $entry.Name) { continue }
            $target = Join-Path $Destination ($entry.FullName -replace '/', '\')
            New-Item -ItemType Directory -Force -Path (Split-Path $target) | Out-Null
            [System.IO.Compression.ZipFileExtensions]::ExtractToFile($entry, $target, $true)
        }
    }
    finally { $zip.Dispose() }
}

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $ArtifactsLocation) { $ArtifactsLocation = Join-Path $repoRoot 'artifacts' }

# One extraction root for the whole run, removed at the end. Each package is expanded into
# <root>/<ModuleName>/<Version>/ so PowerShell resolves it exactly as an installed module.
$extractRoot = Join-Path ([System.IO.Path]::GetTempPath()) "wrapper-package-test-$PID"
Remove-Item $extractRoot -Recurse -Force -ErrorAction SilentlyContinue
New-Item -ItemType Directory -Force -Path $extractRoot | Out-Null

function Test-OnePackage {
    param([string]$Name, [string]$Path, [bool]$SkipStaleness = $false)

    $result = [pscustomobject]@{
        Module = $Name; Pass = $false; Exported = 0; ManifestCount = 0
        ManifestFunctionCount = 0; ExportedCmdlets = 0; ExportedFunctions = 0
        OrphanWorkers = 0; Dispatcher = ''; ErrorId = ''; ComplexBinding = ''; EnumBinding = ''; ScalarBinding = ''
        UntypedBinding = ''; Detail = ''
    }

    if (-not $Path -or -not (Test-Path $Path)) {
        $result.Detail = "no package found for '$Name' under $ArtifactsLocation"
        return $result
    }

    $staging = Join-Path $extractRoot ([guid]::NewGuid().ToString('N'))
    New-Item -ItemType Directory -Force -Path $staging | Out-Null
    Expand-ModulePackage -Path $Path -Destination $staging

    # The manifest inside the package names the module. Nothing here derives that name from the
    # module argument, so a package whose identity changes is still tested rather than skipped.
    $manifests = @(Get-ChildItem $staging -Filter '*.psd1' -File)
    if ($manifests.Count -ne 1) {
        $result.Detail = "expected exactly one manifest in '$([System.IO.Path]::GetFileName($Path))'; found $($manifests.Count)"
        return $result
    }
    $moduleName = $manifests[0].BaseName
    # Re-home into <ModuleName>/<Version> so the module is importable by name, the way it is
    # once installed, rather than only by explicit path.
    $manifestData = Import-PowerShellDataFile -Path $manifests[0].FullName
    $versioned = Join-Path $staging "..\$moduleName\$($manifestData.ModuleVersion)"
    New-Item -ItemType Directory -Force -Path $versioned | Out-Null
    Copy-Item (Join-Path $staging '*') $versioned -Recurse -Force
    $psd1 = Join-Path $versioned "$moduleName.psd1"

    # Every assembly the manifest requires must actually be in the package. Import-Module would
    # surface this too, but as an opaque load failure rather than a named missing dependency.
    foreach ($required in @($manifestData.RequiredAssemblies)) {
        if (-not $required) { continue }
        if (-not (Test-Path (Join-Path $versioned $required))) {
            $result.Detail = "package does not contain required assembly '$required'"
            return $result
        }
    }

    # A package older than the sources it was built from passes every check below while proving
    # nothing about the current generator, so staleness is refused rather than tested around.
    # Every generated input counts, not just the cmdlets: a regenerated client with an unchanged
    # cmdlet is exactly the case where a parameter's CLR type moves out from under the
    # assignment, so watching Cmdlets/ alone would miss the change most likely to invalidate a
    # runtime result.
    # Each branch fails closed. A guard that skips itself when it finds nothing to compare is
    # the same vacuity as a binding check that reports OK having exercised no case: it turns an
    # unknown into a pass. The one exception is an explicit -PackagePath target, where there is
    # no module source to compare against by construction - that is reported, not silently skipped.
    if ($SkipStaleness) {
        $result.Detail = ''
    }
    else {
        $wrapperSrc = Join-Path $repoRoot "src\$Name\wrapper\$ApiVersion"
        if (-not (Test-Path $wrapperSrc)) {
            $result.Detail = "no committed source at $wrapperSrc; staleness is unknowable and a pass here would prove nothing"
            return $result
        }
        $inputs = @(Get-ChildItem -Path $wrapperSrc -Recurse -File -Include *.cs, *.csproj -ErrorAction SilentlyContinue |
            Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' })
        if (-not $inputs) {
            $result.Detail = "no compile inputs found under $wrapperSrc; staleness is unknowable and a pass here would prove nothing"
            return $result
        }
        $newest = ($inputs | Sort-Object LastWriteTimeUtc -Descending | Select-Object -First 1)
        $packedAt = (Get-Item $Path).LastWriteTimeUtc
        if ($packedAt -lt $newest.LastWriteTimeUtc) {
            $rel = $newest.FullName.Substring($wrapperSrc.Length).TrimStart('\')
            $result.Detail = "stale package: packed $($packedAt.ToString('MM-dd HH:mm')) predates $rel ($($newest.LastWriteTimeUtc.ToString('MM-dd HH:mm'))); rebuild and repack"
            return $result
        }
    }

    # Counted per command TYPE. An integrated module exports proxy functions as well as wrapper
    # cmdlets, so comparing every exported command against CmdletsToExport alone would always
    # differ by the number of functions and say nothing about either surface.
    $result.ManifestCount = @($manifestData.CmdletsToExport | Where-Object { $_ -and $_ -ne '*' }).Count
    $result.ManifestFunctionCount = @($manifestData.FunctionsToExport | Where-Object { $_ -and $_ -ne '*' }).Count

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
    ExportedCmdlets = @(`$cmds | Where-Object CommandType -eq 'Cmdlet').Count
    ExportedFunctions = @(`$cmds | Where-Object CommandType -eq 'Function').Count
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
    $result.ExportedCmdlets = $r.ExportedCmdlets
    $result.ExportedFunctions = $r.ExportedFunctions
    $result.OrphanWorkers = $r.OrphanWorkers
    $result.Dispatcher = $r.Dispatcher
    $result.ErrorId = $r.ErrorId
    $result.ComplexBinding = $r.ComplexBinding
    $result.EnumBinding = $r.EnumBinding
    $result.ScalarBinding = $r.ScalarBinding
    $result.UntypedBinding = $r.UntypedBinding

    if ($r.ExportedCmdlets -ne $result.ManifestCount) {
        $result.Detail = "exported $($r.ExportedCmdlets) cmdlet(s) != manifest CmdletsToExport $($result.ManifestCount)"
    }
    elseif ($r.ExportedFunctions -ne $result.ManifestFunctionCount) {
        $result.Detail = "exported $($r.ExportedFunctions) function(s) != manifest FunctionsToExport $($result.ManifestFunctionCount)"
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

# Resolve what to test: explicit package paths, or the newest package per named module. Newest
# rather than any, because more than one version can accumulate in an artifacts folder and
# silently testing an old one would be worse than failing.
$targets = @(
    foreach ($p in $PackagePath) {
        if (-not (Test-Path $p)) { throw "Package not found: $p" }
        [pscustomobject]@{ Name = [System.IO.Path]::GetFileNameWithoutExtension($p); Path = (Resolve-Path $p).Path; SkipStaleness = $true }
    }
    foreach ($name in $Module) {
        $found = @(Get-ChildItem (Join-Path $ArtifactsLocation $name) -Filter '*.nupkg' -File -ErrorAction SilentlyContinue |
            Sort-Object LastWriteTimeUtc -Descending)
        [pscustomobject]@{ Name = $name; Path = if ($found) { $found[0].FullName } else { $null }; SkipStaleness = $false }
    }
)
if ($targets.Count -eq 0) { throw 'Nothing to test: supply -Module or -PackagePath.' }

$results = foreach ($target in $targets) {
    $name = $target.Name
    Write-Host "=== $name ===" -ForegroundColor Cyan
    $r = Test-OnePackage -Name $name -Path $target.Path -SkipStaleness $target.SkipStaleness
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

# Extracted packages are scratch, and leaving them behind would let a later run import a module
# from a previous one.
Remove-Item $extractRoot -Recurse -Force -ErrorAction SilentlyContinue

if ($results.Pass -contains $false) { exit 1 }
exit 0
