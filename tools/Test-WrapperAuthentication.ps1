<#
.SYNOPSIS
Verifies a packaged SchemaExtensions wrapper against the packaged Authentication loader offline.

.DESCRIPTION
Run in a fresh PowerShell 7 process with the locally built Authentication module on PSModulePath.
Imports the normal wrapper manifest, exercises real Connect-MgGraph sessions and Kiota serializers,
and captures HTTP after Authentication's real token handler using a terminal DelegatingHandler.
No live OAuth, Graph requests, or dependency assembly injection is used.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$ManifestPath,
    [Parameter(Mandatory)][ValidateSet('v1.0', 'beta')][string]$ApiVersion,
    [string]$Environment = 'Global'
)

$ErrorActionPreference = 'Stop'
if ($PSEdition -ne 'Core') { throw 'This gate requires PowerShell 7.' }
if (Get-Module Microsoft.Graph.Authentication) { throw 'Run this gate in a fresh process.' }
$manifest = (Resolve-Path -LiteralPath $ManifestPath).Path
$module = Import-Module $manifest -PassThru
$auth = Get-Module Microsoft.Graph.Authentication
if (-not $auth -or $auth.Version -lt [version]'2.41.2') { throw 'The manifest must import Authentication 2.41.2 or newer.' }
foreach ($name in 'New-MgSchemaExtension', 'Update-MgSchemaExtension', 'Remove-MgSchemaExtension', 'Get-MgSchemaExtension_Get') {
    if (-not $module.ExportedCmdlets.ContainsKey($name)) { throw "Missing compiled cmdlet: $name" }
}

Add-Type -TypeDefinition @'
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WrapperAuthenticationTest
{
    public sealed class CapturedRequest
    {
        public string Method;
        public string Uri;
        public string Body;
        public string Authorization;
        public string Marker;
    }

    public sealed class TerminalHandler : DelegatingHandler
    {
        public readonly List<CapturedRequest> Requests = new List<CapturedRequest>();
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
        {
            IEnumerable<string> markers;
            Requests.Add(new CapturedRequest {
                Method = request.Method.Method,
                Uri = request.RequestUri.AbsoluteUri,
                Body = request.Content == null ? "" : await request.Content.ReadAsStringAsync(),
                Authorization = request.Headers.Authorization == null ? "" : request.Headers.Authorization.ToString(),
                Marker = request.Headers.TryGetValues("x-offline-marker", out markers) ? string.Join(",", markers) : ""
            });
            if (request.Method == HttpMethod.Delete || request.Method.Method == "PATCH")
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            return new HttpResponseMessage(HttpStatusCode.OK) {
                Content = new StringContent("{\"id\":\"offline-proof\"}", Encoding.UTF8, "application/json")
            };
        }
    }

    public sealed class DeclineHost : PSHost
    {
        private readonly DeclineUI ui = new DeclineUI();
        private readonly Guid instanceId = Guid.NewGuid();
        public int PromptCount { get { return ui.PromptCount; } }
        public override Guid InstanceId { get { return instanceId; } }
        public override string Name { get { return "WrapperAuthenticationDecline"; } }
        public override Version Version { get { return new Version(1, 0); } }
        public override PSHostUserInterface UI { get { return ui; } }
        public override CultureInfo CurrentCulture { get { return CultureInfo.InvariantCulture; } }
        public override CultureInfo CurrentUICulture { get { return CultureInfo.InvariantCulture; } }
        public override void EnterNestedPrompt() { throw new NotSupportedException(); }
        public override void ExitNestedPrompt() { throw new NotSupportedException(); }
        public override void NotifyBeginApplication() { }
        public override void NotifyEndApplication() { }
        public override void SetShouldExit(int exitCode) { throw new InvalidOperationException("Unexpected host exit."); }
    }

    public sealed class DeclineUI : PSHostUserInterface
    {
        public int PromptCount { get; private set; }
        public override PSHostRawUserInterface RawUI { get { return null; } }
        public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
        {
            for (int index = 0; index < choices.Count; index++)
                if (choices[index].Label.Replace("&", "") == "No") {
                    PromptCount++;
                    return index;
                }
            throw new InvalidOperationException("Expected a No confirmation choice.");
        }
        public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
            { throw new InvalidOperationException("Unexpected parameter prompt."); }
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
            { throw new InvalidOperationException("Unexpected credentials prompt."); }
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName,
            PSCredentialTypes types, PSCredentialUIOptions options)
            { throw new InvalidOperationException("Unexpected credentials prompt."); }
        public override string ReadLine() { throw new InvalidOperationException("Unexpected input."); }
        public override SecureString ReadLineAsSecureString() { throw new InvalidOperationException("Unexpected secure input."); }
        public override void Write(string value) { }
        public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value) { }
        public override void WriteLine(string value) { }
        public override void WriteDebugLine(string message) { }
        public override void WriteErrorLine(string value) { }
        public override void WriteProgress(long sourceId, ProgressRecord record) { }
        public override void WriteVerboseLine(string message) { }
        public override void WriteWarningLine(string message) { }
    }
}
'@

$null = Get-MgContext
$core = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' })
if ($core.Count -ne 1) { throw 'Expected a single Authentication.Core assembly.' }
$session = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.GraphSession', $true).GetProperty('Instance').GetValue($null)
. (Join-Path $PSScriptRoot '..\src\Authentication\Authentication\test\TypeHelpers.ps1')
Set-MgTestDataStore
$factory = $core[0].GetType('Microsoft.Graph.PowerShell.Authentication.Core.Http.GraphHttpClientFactory', $true)
$checks = [Collections.Generic.List[string]]::new()
$handlers = [Collections.Generic.List[object]]::new()
$clients = [Collections.Generic.List[Net.Http.HttpClient]]::new()
$token = 'offline-authentication-token'
$id = 'extension /% space'
$endpoint = (Get-MgEnvironment -Name $Environment).GraphEndpoint.TrimEnd('/')
$collectionUri = "$endpoint/$ApiVersion/schemaExtensions"
$itemUri = "$collectionUri/$([uri]::EscapeDataString($id))"
$declineHost = [WrapperAuthenticationTest.DeclineHost]::new()
$runspace = [runspacefactory]::CreateRunspace($declineHost)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace

function Set-OfflineClient {
    $handler = [WrapperAuthenticationTest.TerminalHandler]::new()
    $client = $factory.GetMethod('Create').Invoke($null, @(
        $session.AuthContext, $session.RequestContext, [Net.Http.DelegatingHandler[]]@($handler), $null, $false
    ))
    $handlers.Add($handler)
    $clients.Add($client)
    $session.GraphHttpClient = $client
    if (-not [object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) {
        throw 'Authentication did not retain the shared authenticated HttpClient.'
    }
    return $handler
}

function Assert-Request([object]$Handler, [int]$Index, [string]$Method, [string]$Uri) {
    $request = $Handler.Requests[$Index]
    if ($request.Method -cne $Method -or $request.Uri -cne $Uri -or $request.Authorization -cne "Bearer $token") {
        throw "Incorrect authenticated request: $($request | ConvertTo-Json -Compress)"
    }
}

try {
    Connect-MgGraph -AccessToken (ConvertTo-SecureString $token -AsPlainText -Force) -Environment $Environment -NoWelcome
    $handler = Set-OfflineClient
    $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
    if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
    $engine.Commands.Clear()

    $result = Get-MgSchemaExtension_Get -SchemaExtensionId $id -Headers @{ 'x-offline-marker' = 'session-proof' }
    if ($result.Id -cne 'offline-proof' -or $handler.Requests.Count -ne 1 -or $handler.Requests[0].Marker -cne 'session-proof') {
        throw 'GET/session/header contract failed.'
    }
    Assert-Request $handler 0 'GET' $itemUri
    $checks.Add('GET typed result, shared session, per-request headers')
    $runtime = [AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Wrapper.Runtime' }
    $cache = $runtime.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', $true).GetField('_adapter', [Reflection.BindingFlags]'NonPublic,Static')
    $adapter = $cache.GetValue($null)
    $null = Get-MgSchemaExtension_Get -SchemaExtensionId $id
    if (-not [object]::ReferenceEquals($adapter, $cache.GetValue($null))) { throw 'Session adapter was not reused.' }
    $checks.Add('Session adapter reuse')

    foreach ($verb in 'New', 'Update', 'Remove') {
        $name = "$verb-MgSchemaExtension"
        $arguments = @{}
        if ($verb -ne 'New') { $arguments.SchemaExtensionId = $id }
        if ($verb -ne 'Remove') {
            $arguments.Description = 'typed body proof'
            $arguments.TargetTypes = @('User', 'Group')
            $arguments.Properties = @(@{ Name = 'testProperty'; Type = 'String' })
        }
        $before = $handler.Requests.Count
        $null = & $name @arguments -WhatIf
        if ($handler.Requests.Count -ne $before) { throw "WhatIf sent HTTP: $name" }
        $checks.Add("$verb WhatIf: no HTTP")
        $null = $engine.AddCommand($name)
        foreach ($entry in $arguments.GetEnumerator()) { $null = $engine.AddParameter($entry.Key, $entry.Value) }
        $null = $engine.AddParameter('Confirm', $true).Invoke()
        if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
        $engine.Commands.Clear()
        if ($handler.Requests.Count -ne $before) { throw "Declined Confirm sent HTTP: $name" }
        $checks.Add("$verb declined confirmation: no HTTP")

        try {
            $result = & $name @arguments -Confirm:$false
        }
        catch {
            throw "$name failed after $($handler.Requests.Count - $before) additional HTTP requests: $($_.Exception)"
        }
        $expectedCount = if ($verb -eq 'Update') { 2 } else { 1 }
        if ($handler.Requests.Count -ne $before + $expectedCount) { throw "Unexpected request count: $name" }
        $method = switch ($verb) { New { 'POST' } Update { 'PATCH' } Remove { 'DELETE' } }
        $uri = if ($verb -eq 'New') { $collectionUri } else { $itemUri }
        Assert-Request $handler $before $method $uri
        if ($verb -ne 'Remove') {
            $body = $handler.Requests[$before].Body | ConvertFrom-Json
            if ($body.description -cne $arguments.Description -or ($body.targetTypes -join ',') -cne 'User,Group' -or
                @($body.properties).Count -ne 1 -or $body.properties[0].name -cne 'testProperty' -or
                $body.properties[0].type -cne 'String' -or $result.Id -cne 'offline-proof') {
                throw "Incorrect typed body/result: $($handler.Requests[$before].Body)"
            }
        }
        if ($verb -eq 'Update') { Assert-Request $handler ($before + 1) 'GET' $itemUri }
        $checks.Add("$method typed JSON, URL, mutation/result")
    }
    if ($declineHost.PromptCount -ne 3) { throw 'Expected three genuine declined prompts.' }

    $sharedClient = $session.GraphHttpClient
    $baseAddress = $sharedClient.BaseAddress
    foreach ($profile in 'v1.0', 'beta', 'v1.0', 'beta') {
        $root = [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphServiceRoot($profile)
        $profileAdapter = $runtime.GetType('Microsoft.Graph.Wrapper.Runtime.SessionAdapterCache', $true).
            GetMethod('GetOrCreate').Invoke($null, @($sharedClient, $root))
        $profileClient = [Microsoft.Graph.PowerShell.SchemaExtensions.Client.ApiClient]::new($profileAdapter)
        $before = $handler.Requests.Count
        $result = $profileClient.SchemaExtensions[$id].GetAsync().GetAwaiter().GetResult()
        if ($result.Id -cne 'offline-proof' -or $handler.Requests.Count -ne $before + 1) { throw 'Alternating profile GET failed.' }
        Assert-Request $handler $before 'GET' "$endpoint/$profile/schemaExtensions/$([uri]::EscapeDataString($id))"
        if (-not [object]::ReferenceEquals($sharedClient, $session.GraphHttpClient) -or
            -not [object]::Equals($baseAddress, $sharedClient.BaseAddress)) {
            throw 'Switching profile mutated the shared session transport.'
        }
    }
    $checks.Add('Alternating v1.0/beta requests in one authenticated session retain host and transport')
    $adapter = $cache.GetValue($null)
    Set-MgRequestContext -ClientTimeout 42
    if ($null -ne $session.GraphHttpClient) { throw 'Request-context change did not invalidate the client.' }
    $handler = Set-OfflineClient
    $null = Get-MgSchemaExtension_Get -SchemaExtensionId $id
    Assert-Request $handler 0 'GET' $itemUri
    if ([object]::ReferenceEquals($adapter, $cache.GetValue($null)) -or $session.GraphHttpClient.Timeout.TotalSeconds -ne 42) {
        throw 'Request-context change did not rebuild the adapter with the new timeout.'
    }
    $checks.Add('Request-context invalidation and adapter rebuild')
    $adapter = $cache.GetValue($null)
    $token = 'offline-reconnected-token'
    Connect-MgGraph -AccessToken (ConvertTo-SecureString $token -AsPlainText -Force) -Environment $Environment -NoWelcome
    if ($null -ne $session.GraphHttpClient) { throw 'Reconnect did not invalidate the client.' }
    $handler = Set-OfflineClient
    $null = Get-MgSchemaExtension_Get -SchemaExtensionId $id
    Assert-Request $handler 0 'GET' $itemUri
    if ([object]::ReferenceEquals($adapter, $cache.GetValue($null))) { throw 'Reconnect reused a stale adapter.' }
    $checks.Add('Reconnect uses new token, client and adapter')

    Disconnect-MgGraph | Out-Null
    if ($null -ne $session.GraphHttpClient -or $null -ne (Get-MgContext)) { throw 'Disconnect retained the active session.' }
    try {
        $null = Get-MgSchemaExtension_Get -SchemaExtensionId $id
        throw 'Expected NoGraphSession.'
    }
    catch {
        if ($_.FullyQualifiedErrorId -notlike 'NoGraphSession,*' -or $_.CategoryInfo.Category -ne 'AuthenticationError') { throw }
    }
    $checks.Add('Disconnect preserves NoGraphSession authentication error')

    # Only the test replaces the shared explicit-token client's terminal transport. The generated cmdlet,
    # adapter and token provider still follow their normal path, with no session and no live HTTP.
    $tokenClientField = $runtime.GetType('Microsoft.Graph.Wrapper.Runtime.GraphClientCmdlet', $true).
        GetField('TokenClient', [Reflection.BindingFlags]'NonPublic,Static')
    $tokenClient = $tokenClientField.GetValue($null).Value
    $terminalField = [Net.Http.HttpMessageInvoker].GetField('_handler', [Reflection.BindingFlags]'NonPublic,Instance')
    if (-not $terminalField) { throw 'Cannot safely stub the explicit-token terminal transport on this runtime.' }
    $explicitHandler = [WrapperAuthenticationTest.TerminalHandler]::new()
    $originalTerminal = $terminalField.GetValue($tokenClient)
    $terminalField.SetValue($tokenClient, $explicitHandler)
    try {
        $result = Get-MgSchemaExtension_Get -SchemaExtensionId $id -AccessToken 'explicit-offline-token'
        $token = 'explicit-offline-token'
        if ($result.Id -cne 'offline-proof' -or $explicitHandler.Requests.Count -ne 1 -or $null -ne (Get-MgContext)) {
            throw 'Explicit-token invocation failed without a session.'
        }
        Assert-Request $explicitHandler 0 'GET' "https://graph.microsoft.com/$ApiVersion/schemaExtensions/$([uri]::EscapeDataString($id))"
        $handlers.Add($explicitHandler)
    }
    finally {
        $terminalField.SetValue($tokenClient, $originalTerminal)
        $explicitHandler.Dispose()
    }
    $checks.Add('Generated explicit-token path works independently of session')

    $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    })
    if (@($assemblies | Group-Object { $_.GetName().Name } | Where-Object Count -ne 1).Count) {
        throw 'Duplicate Authentication/Kiota dependency identities.'
    }
    $sources = foreach ($assembly in $assemblies) {
        $name = $assembly.GetName().Name
        $context = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly).Name
        $expected = if ($name -in 'Microsoft.Graph.Authentication', 'Microsoft.Graph.Authentication.Loader') { 'Default' } else { 'Microsoft.Graph.Authentication' }
        if ($context -cne $expected -or -not $assembly.Location.StartsWith("$($auth.ModuleBase)\", [StringComparison]::OrdinalIgnoreCase)) {
            throw "Wrong assembly source/context: $name $($assembly.Location) $context"
        }
        [pscustomobject]@{ Name = $name; Version = "$($assembly.GetName().Version)"; Location = $assembly.Location; Context = $context }
    }
    foreach ($required in 'Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate', 'Microsoft.Kiota.Serialization.Json', 'Microsoft.Graph.Authentication.Core') {
        if (@($sources | Where-Object Name -eq $required).Count -ne 1) { throw "Missing dependency identity: $required" }
    }
    $checks.Add('Single Authentication/Kiota closure, correct packaged source and load contexts')
    [pscustomobject]@{
        Profile = $ApiVersion; Environment = $Environment; Authentication = "$($auth.Version)"; AuthenticationPath = $auth.ModuleBase
        PowerShell = "$($PSVersionTable.PSVersion)"; Checks = @($checks); DeclinedPrompts = $declineHost.PromptCount
        SharedGraphSession = $true; StubbedRequests = @($handlers | ForEach-Object { $_.Requests } | ForEach-Object { $_ })
        LiveGraphRequests = 0; Assemblies = @($sources)
    } | ConvertTo-Json -Depth 6
}
finally {
    $session.GraphHttpClient = $null
    $engine.Dispose()
    $runspace.Dispose()
    foreach ($client in $clients) { $client.Dispose() }
}
