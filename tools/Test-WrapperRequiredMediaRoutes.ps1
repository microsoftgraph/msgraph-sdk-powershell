<#
.SYNOPSIS
Compiles a required-selector mixed-media dispatcher with real runtime and local stub workers.

.DESCRIPTION
Checks mandatory explicit labels, Binary versus JSON List/Get selection, parameter validation,
forwarding and binder-bypass rejection. No Graph session, HTTP call or output file is created.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredMediaRoutes.ps1
#>
[CmdletBinding()]
param(
    [string]$GeneratorAssembly = "$PSScriptRoot\WrapperGenerator\bin\Debug\net10.0\WrapperGenerator.dll",
    [string]$RuntimeAssembly = "$PSScriptRoot\..\src\GraphWrapperRuntime\Runtime\bin\Debug\netstandard2.0\Microsoft.Graph.Wrapper.Runtime.dll",
    [Parameter(DontShow)][string]$FixtureRoot,
    [Parameter(DontShow)][switch]$Probe
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $FixtureRoot) {
    $FixtureRoot = Join-Path $repoRoot ".wrapper-required-media-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
if (-not $Probe) {
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Required media probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-RequiredMediaTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-RequiredMediaWorker($Label, $Shape, $Index, $Path, $Parameters, $OutputType, [string[]]$Ids) {
    $naming = [WrapperGenerator.CmdletNaming]::new(
        'VerbsCommon', 'Get', 'MgRequiredMedia', 'GetMgRequiredMediaCommand', $Ids, 'Unused',
        [WrapperGenerator.HeaderParam[]]@(), [WrapperGenerator.OperationKind]::Resource,
        $null, '', '', '', $null, '', $Path, 'GET')
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$Index"),
        $Label, $Shape, [WrapperGenerator.CmdletEmitter+DispatchParameter[]]$Parameters, $OutputType)
}

function Register-RequiredMediaWorker([string]$Name) {
    $source = @'
[CmdletBinding()]
param(
    [string]$MeetingId, [string]$RecordingId, [string]$OutFile,
    [switch]$All, [int]$Top, [Alias('Select')][string[]]$Property,
    [string]$AccessToken, [System.Collections.IDictionary]$Headers
)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:RequiredMediaAttempts.Add($call)
$call
'@
    Set-Item "Function:\global:$Name" ([scriptblock]::Create($source.Replace('__NAME__', $Name)))
}

function Assert-RequiredMediaRejected([scriptblock]$Invocation, [string[]]$Details, [switch]$Binding) {
    $before = $global:RequiredMediaAttempts.Count
    $failure = $null
    try { $null = & $Invocation } catch { $failure = $_ }
    Assert-RequiredMediaTest ($null -ne $failure) 'Invalid media route parameters unexpectedly succeeded.'
    Assert-RequiredMediaTest ($global:RequiredMediaAttempts.Count -eq $before) 'An invalid media route reached a worker.'
    if (-not $Binding) {
        Assert-RequiredMediaTest ($failure.FullyQualifiedErrorId.StartsWith('InvalidGraphRouteParameters')) "Incorrect runtime error identity: $failure"
        Assert-RequiredMediaTest ($failure.CategoryInfo.Category -eq 'InvalidArgument') "Incorrect runtime error category: $failure"
    }
    foreach ($detail in $Details) {
        Assert-RequiredMediaTest ($failure.Exception.Message -match [regex]::Escape($detail)) "Diagnostic missing '$detail': $failure"
    }
}

$workerNames = @()
$module = $null
try {
    foreach ($assembly in $GeneratorAssembly, $RuntimeAssembly) {
        if (-not (Test-Path $assembly)) { throw "Build prerequisite missing: $assembly" }
    }
    $GeneratorAssembly = (Resolve-Path $GeneratorAssembly).Path
    $RuntimeAssembly = (Resolve-Path $RuntimeAssembly).Path
    $null = New-Item $FixtureRoot -ItemType Directory
    Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
    $null = [System.Reflection.Assembly]::LoadFrom($GeneratorAssembly)
    $null = [System.Reflection.Assembly]::LoadFrom($RuntimeAssembly)

    $meeting = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('MeetingId', 'string', $true, 0)
    $recording = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('RecordingId', 'string', $true, 1)
    $outFile = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('OutFile', 'string?', $false, $null)
    $all = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('All', 'SwitchParameter', $false, $null)
    $top = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Top', 'int', $false, $null)
    $property = [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Property', 'string[]?', $false, $null, 'Select')
    $workers = @(
        New-RequiredMediaWorker Binary Get 0 '/communications/onlineMeetings/{meeting-id}/recordings/{recording-id}/content' `
            @($meeting, $recording, $outFile) 'System.Byte[]' @('MeetingId', 'RecordingId')
        New-RequiredMediaWorker Recordings List 1 '/communications/onlineMeetings/{meeting-id}/recordings' `
            @($meeting, $all, $top, $property) System.String @('MeetingId')
        New-RequiredMediaWorker Recordings Get 2 '/communications/onlineMeetings/{meeting-id}/recordings/{recording-id}' `
            @($meeting, $recording, $property) System.String @('MeetingId', 'RecordingId')
    )
    $routes = @($workers | ForEach-Object {
        $route = [WrapperGenerator.MultiRoute]::new('GET', $_.Naming.SourcePath, $_.RouteName)
        $route.ReadKind = if ($_.RouteName -eq 'Binary') {
            [WrapperGenerator.MultiRouteReadKind]::Binary
        } elseif ($_.Shape -eq 'List') {
            [WrapperGenerator.MultiRouteReadKind]::List
        } else {
            [WrapperGenerator.MultiRouteReadKind]::Item
        }
        $route
    })
    $group = [WrapperGenerator.MultiRouteGroup]::new('beta', [WrapperGenerator.MultiRoute[]]$routes, '', 'Route')
    $group.AllowAsymmetricRoutes = $true
    $group.AllowExplicitRouteSelection = $true
    $group.AllowResponseUnion = $true
    $group.AllowMixedMediaReads = $true
    $group.RequireExplicitRoute = $true
    $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
        $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$workers,
        [WrapperGenerator.EmitContext]::new('RequiredMediaInvocationFixture.Client'))
    Assert-RequiredMediaTest (-not $source.Contains('"Published"')) 'Required-selector source must not emit a Published label or branch.'
    Assert-RequiredMediaTest ($source -notmatch '\bpublishedRoute\b|\bdefaultRoutes\b') 'Required-selector source must not emit Published/default preference logic.'
    $sourcePath = Join-Path $FixtureRoot 'RequiredMedia.cs'
    Set-Content $sourcePath $source

    # These wrappers mutate a validly bound selector just before the real dispatcher runs.
    $bypassPath = Join-Path $FixtureRoot 'BinderBypass.cs'
    Set-Content $bypassPath @'
using System.Management.Automation;
namespace RequiredMediaInvocationFixture
{
    [Cmdlet(VerbsCommon.Get, "MgRequiredMediaMissingBypass")]
    public class MissingBypassCommand : GetMgRequiredMediaCommand
    {
        protected override void ProcessRecord() { Route = string.Empty; base.ProcessRecord(); }
    }
    [Cmdlet(VerbsCommon.Get, "MgRequiredMediaPublishedBypass")]
    public class PublishedBypassCommand : GetMgRequiredMediaCommand
    {
        protected override void ProcessRecord() { Route = "Published"; base.ProcessRecord(); }
    }
    [Cmdlet(VerbsCommon.Get, "MgRequiredMediaUnknownBypass")]
    public class UnknownBypassCommand : GetMgRequiredMediaCommand
    {
        protected override void ProcessRecord() { Route = "Unknown"; base.ProcessRecord(); }
    }
}
'@
    $modulePath = Join-Path $FixtureRoot 'Microsoft.Graph.Wrapper.RequiredMediaProbe.dll'
    $references = @(
        $RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location
    ) + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path @($sourcePath, $bypassPath) -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:RequiredMediaAttempts = [System.Collections.Generic.List[object]]::new()
    foreach ($worker in $workers) {
        $name = "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)"
        Register-RequiredMediaWorker $name
        $workerNames += $name
    }

    $command = Get-Command Get-MgRequiredMedia
    Assert-RequiredMediaTest ($command.ParameterSets.Count -eq 1 -and $command.ParameterSets[0].Name -eq 'Route') 'Required media must expose only the Route parameter set.'
    $set = $command.ParameterSets[0]
    Assert-RequiredMediaTest (@($set.Parameters | Where-Object { $_.Name -eq 'Route' -and $_.IsMandatory }).Count -eq 1) 'The route selector must be mandatory.'
    Assert-RequiredMediaTest (@($set.Parameters | Where-Object { $_.Name -eq 'MeetingId' -and $_.IsMandatory }).Count -eq 1) 'The common parent ID must remain mandatory.'
    Assert-RequiredMediaTest (@($set.Parameters | Where-Object { $_.Name -eq 'RecordingId' -and -not $_.IsMandatory }).Count -eq 1) 'The item ID must be optional publicly and checked at dispatch.'
    $validate = @($command.Parameters['Route'].Attributes | Where-Object { $_ -is [System.Management.Automation.ValidateSetAttribute] })[0]
    Assert-RequiredMediaTest ((($validate.ValidValues | Sort-Object) -join ',') -eq 'Binary,Recordings') 'Required media selector must not advertise Published.'
    $instance = [Activator]::CreateInstance($command.ImplementingType)
    Assert-RequiredMediaTest ($instance.Route -eq '') 'Required media must not initialize an endpoint default.'
    $attributes = @($command.ImplementingType.GetCustomAttributes($false))
    $metadata = @($attributes | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-RequiredMediaTest ($metadata.Count -eq 3) 'Required media lost source-operation metadata.'
    foreach ($worker in $workers) {
        Assert-RequiredMediaTest (@($metadata | Where-Object {
            $_.Method -eq 'GET' -and $_.Path -eq $worker.Naming.SourcePath -and $_.ParameterSetName -eq 'Route'
        }).Count -eq 1) 'Required media lost an exact method/path.'
    }
    $outputs = @($attributes | Where-Object { $_ -is [System.Management.Automation.OutputTypeAttribute] })
    foreach ($type in 'System.Byte[]', 'System.String') {
        Assert-RequiredMediaTest (@($outputs | Where-Object {
            $_.ParameterSetName -contains 'Route' -and @($_.Type | Where-Object { $_.Type.FullName -eq $type }).Count -gt 0
        }).Count -gt 0) "Required media lost output type $type."
    }

    Assert-RequiredMediaRejected { Get-MgRequiredMedia -MeetingId m -RecordingId r -ErrorAction Stop } @() -Binding
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Published -MeetingId m -RecordingId r -ErrorAction Stop } @() -Binding
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Unknown -MeetingId m -RecordingId r -ErrorAction Stop } @() -Binding
    Assert-RequiredMediaRejected { Get-MgRequiredMediaMissingBypass -Route Binary -MeetingId m -RecordingId r -ErrorAction Stop } @('No compatible route')
    Assert-RequiredMediaRejected { Get-MgRequiredMediaPublishedBypass -Route Binary -MeetingId m -RecordingId r -ErrorAction Stop } @('Published', 'No compatible route')
    Assert-RequiredMediaRejected { Get-MgRequiredMediaUnknownBypass -Route Binary -MeetingId m -RecordingId r -ErrorAction Stop } @('Unknown', 'No compatible route')
    Assert-RequiredMediaTest ((Get-MgRequiredMedia -Route bInArY -MeetingId m -RecordingId r).Worker -eq 'Get-MgRequiredMedia_Route0') 'Explicit Binary selected the wrong worker.'
    Assert-RequiredMediaTest ((Get-MgRequiredMedia -Route Recordings -MeetingId m).Worker -eq 'Get-MgRequiredMedia_Route1') 'Recordings with only parent IDs must select the JSON list.'
    Assert-RequiredMediaTest ((Get-MgRequiredMedia -Route rEcOrDiNgS -MeetingId m -RecordingId r).Worker -eq 'Get-MgRequiredMedia_Route2') 'Recordings with the item ID must select the JSON item.'
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Binary -MeetingId m -ErrorAction Stop } @('Binary/Get', 'missing', 'RecordingId')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Binary -MeetingId m -RecordingId r -All -ErrorAction Stop } @('Binary/Get', 'unsupported', 'All')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Binary -MeetingId m -RecordingId r -Top 2 -ErrorAction Stop } @('Binary/Get', 'unsupported', 'Top')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Binary -MeetingId m -RecordingId r -Select id -ErrorAction Stop } @('Binary/Get', 'unsupported', 'Property')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Recordings -MeetingId m -OutFile fixture.bin -ErrorAction Stop } @('Recordings/List', 'unsupported', 'OutFile')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Recordings -MeetingId m -RecordingId r -All -ErrorAction Stop } @('Recordings/List', 'RecordingId', 'Recordings/Get', 'All')
    Assert-RequiredMediaRejected { Get-MgRequiredMedia -Route Recordings -MeetingId m -RecordingId r -Top 2 -ErrorAction Stop } @('Recordings/List', 'RecordingId', 'Recordings/Get', 'Top')
    $forwarded = Get-MgRequiredMedia -Route Recordings -MeetingId m -All -Top 2 -Select id,name `
        -Headers @{ 'x-fixture' = 'recordings' } -AccessToken fixture-token -Verbose -ErrorAction Stop
    Assert-RequiredMediaTest ($forwarded.Worker -eq 'Get-MgRequiredMedia_Route1' -and $forwarded.Bound.All.IsPresent -and $forwarded.Bound.Top -eq 2 -and ($forwarded.Bound.Property -join ',') -eq 'id,name') 'Recordings list/query alias forwarding failed.'
    Assert-RequiredMediaTest ($forwarded.Bound.Headers['x-fixture'] -eq 'recordings' -and $forwarded.Bound.AccessToken -eq 'fixture-token' -and $forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction') -and -not $forwarded.Bound.ContainsKey('Route')) 'Recordings inherited/common forwarding or selector stripping failed.'
    $forwarded = Get-MgRequiredMedia -Route Binary -MeetingId m -RecordingId r -OutFile fixture.bin `
        -Headers @{ 'x-fixture' = 'binary' } -AccessToken fixture-token -ErrorAction Stop
    Assert-RequiredMediaTest ($forwarded.Worker -eq 'Get-MgRequiredMedia_Route0' -and $forwarded.Bound.OutFile -eq 'fixture.bin' -and $forwarded.Bound.RecordingId -eq 'r') 'Binary ID/OutFile forwarding failed.'
    Assert-RequiredMediaTest ($forwarded.Bound.Headers['x-fixture'] -eq 'binary' -and $forwarded.Bound.AccessToken -eq 'fixture-token' -and $forwarded.Bound.ContainsKey('ErrorAction') -and -not $forwarded.Bound.ContainsKey('Route')) 'Binary inherited/common forwarding or selector stripping failed.'
    Assert-RequiredMediaTest (-not (Test-Path (Join-Path $FixtureRoot 'fixture.bin'))) 'Stub dispatch must not create an output file.'
    'Required-selector mixed-media dispatch passed real binding, label-only selection, binder-bypass rejection, parameter validation, forwarding and metadata checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable RequiredMediaAttempts -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
    Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
