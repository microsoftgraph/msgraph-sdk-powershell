<#
.SYNOPSIS
Offline serialization regression gate for a built or unpacked SchemaExtensions wrapper.

.DESCRIPTION
Run in a fresh PowerShell process with the intended Microsoft.Graph.Authentication on
PSModulePath. Imports the normal manifest, uses the real shared GraphSession and Kiota
serializers, and replaces only the session HttpClient with an in-memory terminal handler.
No token, network request, assembly injection, or Authentication modification is needed.
SchemaExtensions is a small supported module with typed POST/PATCH bodies in both profiles.

.EXAMPLE
pwsh -NoProfile -File .\tools\Test-WrapperSerialization.ps1 -ManifestPath <unpacked.psd1> -ApiVersion v1.0
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)][string]$ManifestPath,
    [Parameter(Mandatory)][ValidateSet('v1.0', 'beta')][string]$ApiVersion
)

$ErrorActionPreference = 'Stop'
if (Get-Module Microsoft.Graph.Authentication) { throw 'Run this gate in a fresh PowerShell process.' }
$manifest = (Resolve-Path -LiteralPath $ManifestPath).Path
$module = Import-Module $manifest -PassThru
$auth = Get-Module Microsoft.Graph.Authentication
if (-not $auth) { throw 'The manifest did not import Authentication.' }
foreach ($name in 'New-MgSchemaExtension', 'Update-MgSchemaExtension', 'Remove-MgSchemaExtension', 'Get-MgSchemaExtension_Get') {
    if (-not $module.ExportedCmdlets.ContainsKey($name)) { throw "Missing compiled cmdlet: $name" }
}

$typeArgs = @{}
if ($PSVersionTable.PSEdition -eq 'Desktop') {
    $typeArgs.ReferencedAssemblies = @('System.dll', 'System.Core.dll', 'System.Net.Http.dll', [System.Management.Automation.PSObject].Assembly.Location)
}
Add-Type @typeArgs -TypeDefinition @'
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

namespace WrapperSerializationTest
{
    public sealed class CapturedRequest
    {
        public string Method;
        public string Uri;
        public string Body;
    }

    public sealed class CaptureHandler : HttpMessageHandler
    {
        public readonly List<CapturedRequest> Requests = new List<CapturedRequest>();
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
        {
            Requests.Add(new CapturedRequest {
                Method = request.Method.Method,
                Uri = request.RequestUri.AbsoluteUri,
                Body = request.Content == null ? "" : await request.Content.ReadAsStringAsync()
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
        public override string Name { get { return "WrapperSerializationDecline"; } }
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
$handler = [WrapperSerializationTest.CaptureHandler]::new()
$client = [Net.Http.HttpClient]::new($handler)
$session = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance
$savedClient = $session.GraphHttpClient
$session.GraphHttpClient = $client
$declineHost = [WrapperSerializationTest.DeclineHost]::new()
$runspace = [runspacefactory]::CreateRunspace($declineHost)
$runspace.Open()
$engine = [powershell]::Create()
$engine.Runspace = $runspace
$failures = [Collections.Generic.List[string]]::new()
$checks = [Collections.Generic.List[string]]::new()
$id = 'extension /% space'
$collectionUri = "https://graph.microsoft.com/$ApiVersion/schemaExtensions"
$itemUri = "$collectionUri/$([uri]::EscapeDataString($id))"

function Assert-Request([int]$Index, [string]$Method, [string]$Uri) {
    $request = $handler.Requests[$Index]
    if ($request.Method -cne $Method -or $request.Uri -cne $Uri) {
        throw "Unexpected request: $($request.Method) $($request.Uri); expected $Method $Uri"
    }
}

try {
    $null = $engine.AddCommand('Import-Module').AddParameter('Name', $manifest).AddParameter('ErrorAction', 'Stop').Invoke()
    if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
    $engine.Commands.Clear()
    if (-not [object]::ReferenceEquals($client, [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient())) {
        throw 'Authentication did not retain the shared marker HttpClient.'
    }

    $before = $handler.Requests.Count
    $result = Get-MgSchemaExtension_Get -SchemaExtensionId $id
    if ($result.Id -cne 'offline-proof' -or $handler.Requests.Count -ne $before + 1) { throw 'GET failed.' }
    Assert-Request $before 'GET' $itemUri
    $checks.Add('GET')

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
        $checks.Add("$verb WhatIf")

        $null = $engine.AddCommand($name)
        foreach ($entry in $arguments.GetEnumerator()) { $null = $engine.AddParameter($entry.Key, $entry.Value) }
        $null = $engine.AddParameter('Confirm', $true).Invoke()
        if ($engine.HadErrors) { throw ($engine.Streams.Error | Out-String) }
        $engine.Commands.Clear()
        if ($handler.Requests.Count -ne $before) { throw "Declined Confirm sent HTTP: $name" }
        $checks.Add("$verb declined Confirm")

        try {
            $result = & $name @arguments -Confirm:$false
        }
        catch {
            $failures.Add("$name ($($handler.Requests.Count - $before) HTTP requests): $($_.Exception)")
            continue
        }
        $count = if ($verb -eq 'Update') { 2 } else { 1 }
        if ($handler.Requests.Count -ne $before + $count) { throw "Unexpected request count: $name" }
        $method = switch ($verb) { New { 'POST' } Update { 'PATCH' } Remove { 'DELETE' } }
        $uri = if ($verb -eq 'New') { $collectionUri } else { $itemUri }
        Assert-Request $before $method $uri
        if ($verb -ne 'Remove') {
            $body = $handler.Requests[$before].Body | ConvertFrom-Json
            if ($body.description -cne $arguments.Description -or ($body.targetTypes -join ',') -cne 'User,Group' -or
                @($body.properties).Count -ne 1 -or $body.properties[0].name -cne 'testProperty' -or $body.properties[0].type -cne 'String') {
                throw "Incorrect typed JSON body: $($handler.Requests[$before].Body)"
            }
            if ($result.Id -cne 'offline-proof') { throw "Incorrect typed result: $name" }
        }
        if ($verb -eq 'Update') { Assert-Request ($before + 1) 'GET' $itemUri }
        $checks.Add("$method body/URL/result")
    }
    if ($declineHost.PromptCount -ne 3) { throw "Expected three declined prompts, got $($declineHost.PromptCount)." }
    if ($failures.Count) {
        throw "Serialization failed. Passed gates: $($checks -join ', ').`n$($failures -join [Environment]::NewLine)"
    }

    $assemblies = @([AppDomain]::CurrentDomain.GetAssemblies() | Where-Object {
        $_.GetName().Name -like 'Microsoft.Graph.Authentication*' -or
        $_.GetName().Name -like 'Microsoft.Kiota.*' -or
        $_.GetName().Name -in @('Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate')
    })
    $sources = foreach ($assembly in $assemblies) {
        $name = $assembly.GetName().Name
        $local = $name -in @('Microsoft.IO.RecyclableMemoryStream', 'Microsoft.Kiota.Serialization.Multipart', 'Std.UriTemplate')
        $expectedRoot = if ($local) { Split-Path $manifest } else { $auth.ModuleBase }
        if (-not $assembly.Location.StartsWith("$expectedRoot\", [StringComparison]::OrdinalIgnoreCase)) {
            throw "Wrong assembly source: $name : $($assembly.Location)"
        }
        $context = if ($PSVersionTable.PSEdition -eq 'Core') {
            [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly).Name
        } else { 'AppDomain (Desktop)' }
        if ($PSVersionTable.PSEdition -eq 'Core') {
            $expectedContext = if ($local -or $name -like 'Microsoft.Graph.Authentication*') { 'Default' } else { 'msgraph-load-context' }
            if ($context -cne $expectedContext) { throw "Wrong context for ${name}: $context" }
        }
        [pscustomobject]@{ Name = $name; Version = "$($assembly.GetName().Version)"; Location = $assembly.Location; Context = $context }
    }
    foreach ($required in 'Microsoft.IO.RecyclableMemoryStream', 'Std.UriTemplate', 'Microsoft.Kiota.Serialization.Json', 'Microsoft.Graph.Authentication.Core') {
        if (@($sources | Where-Object Name -eq $required).Count -ne 1) { throw "Expected exactly one loaded $required." }
    }
    if (@($assemblies | Group-Object { $_.GetName().Name } | Where-Object Count -ne 1).Count) { throw 'Duplicate shared assembly identities.' }
    if ($handler.Requests.Count -ne 5 -or $checks.Count -ne 10) { throw 'Incomplete runtime gate coverage.' }
    [pscustomobject]@{
        Profile = $ApiVersion; PowerShell = "$($PSVersionTable.PSVersion)"; Edition = $PSVersionTable.PSEdition
        Authentication = "$($auth.Version)"; AuthenticationPath = $auth.ModuleBase
        SharedGraphSession = $true; Checks = $checks; DeclinedPrompts = $declineHost.PromptCount
        StubbedRequests = $handler.Requests; LiveGraphRequests = 0; Assemblies = @($sources)
    } | ConvertTo-Json -Depth 6
}
finally {
    $session.GraphHttpClient = $savedClient
    $engine.Dispose()
    $runspace.Dispose()
    $client.Dispose()
}
