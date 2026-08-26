#nullable enable

using System;
using System.Collections;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.Wrapper.Runtime
{
    // The shared skeleton of every generated wrapper cmdlet: the -AccessToken/-Headers surface,
    // transport acquisition, and Graph error translation. Derived cmdlets own only what is
    // unique to their operation - path parameters, body binding, and the request itself.
    public abstract class GraphClientCmdlet : PSCmdlet
    {
        // One shared HttpClient for every -AccessToken invocation in the process. The token
        // rides per-request (see StaticBearerTokenAuthenticationProvider), so different tokens
        // share this client safely; constructing a client per invocation leaks one un-disposed
        // connection pool per call instead.
        private static readonly Lazy<HttpClient> TokenClient = new(() => new HttpClient());

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public IDictionary? Headers { get; set; }

        protected bool IsParameterBound(string parameterName)
            => MyInvocation?.BoundParameters.ContainsKey(parameterName) ?? false;

        // The transport for this invocation. -AccessToken gets a per-token provider over the
        // shared client; otherwise the Connect-MgGraph session's client (which carries the full
        // auth handler pipeline) with the session-keyed cached adapter. No active session is a
        // terminating error, same id and message the generated cmdlets have always produced.
        protected IRequestAdapter GetRequestAdapter()
        {
            if (IsParameterBound(nameof(AccessToken)))
            {
                return new HttpClientRequestAdapter(
                    new StaticBearerTokenAuthenticationProvider(AccessToken!),
                    httpClient: TokenClient.Value);
            }

            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            HttpClient sessionClient;
            try
            {
                sessionClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession", ErrorCategory.AuthenticationError, targetObject: null));
                throw; // unreachable; ThrowTerminatingError does not return
            }

            return SessionAdapterCache.GetOrCreate(sessionClient);
        }

        // Copies -Headers onto one outgoing request. Called inside the request-configuration
        // lambda, so the headers apply per request rather than to the shared client.
        protected void AddRequestHeaders(RequestHeaders requestHeaders)
        {
            if (Headers is null)
                return;

            foreach (DictionaryEntry entry in Headers)
            {
                var name = entry.Key?.ToString();
                if (name is null)
                    continue;
                requestHeaders.Add(name, entry.Value?.ToString() ?? string.Empty);
            }
        }

        // A caller-supplied continuation link (-DeltaLink) is handed to kiota's WithUrl, which
        // sends it verbatim and ignores every other path and query parameter - and the auth header
        // is attached afterwards. An off-tenant URL would therefore receive the caller's Graph
        // token. The link is checked against the adapter's OWN BaseUrl rather than a hard-coded
        // host, so national clouds and custom endpoints keep working with no list to maintain.
        protected string ValidateContinuationUrl(string url, IRequestAdapter adapter, string parameterName)
        {
            // Each branch rethrows the same exception it reported: ThrowTerminatingError does not
            // return, but the compiler cannot know that, and a bare throw is only legal in a catch.
            if (!Uri.TryCreate(url, UriKind.Absolute, out var link))
            {
                var invalid = new ArgumentException($"-{parameterName} must be an absolute URL.", parameterName);
                ThrowTerminatingError(new ErrorRecord(
                    invalid, "InvalidContinuationUrl", ErrorCategory.InvalidArgument, url));
                throw invalid;
            }

            // BaseUrl is set by the generated ApiClient constructor before any request is issued,
            // so it is populated by the time a cmdlet reaches this call.
            if (!Uri.TryCreate(adapter?.BaseUrl, UriKind.Absolute, out var expected))
            {
                var unknown = new InvalidOperationException(
                    $"Cannot validate -{parameterName}: the request adapter has no base URL.");
                ThrowTerminatingError(new ErrorRecord(
                    unknown, "UnknownServiceRoot", ErrorCategory.InvalidOperation, url));
                throw unknown;
            }

            if (!string.Equals(link.Scheme, expected.Scheme, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(link.Host, expected.Host, StringComparison.OrdinalIgnoreCase))
            {
                var mismatch = new ArgumentException(
                    $"-{parameterName} points at '{link.Scheme}://{link.Host}', but this session is connected to " +
                    $"'{expected.Scheme}://{expected.Host}'. Refusing to send credentials to another host.",
                    parameterName);
                ThrowTerminatingError(new ErrorRecord(
                    mismatch, "ContinuationUrlHostMismatch", ErrorCategory.SecurityError, url));
                throw mismatch;
            }

            return url;
        }

        // The single error surface for a failed Graph call, identical across every cmdlet.
        protected void ThrowGraphRequestFailed(Exception exception, object? targetObject)
        {
            ThrowTerminatingError(new ErrorRecord(
                exception, "GraphRequestFailed", ErrorCategory.InvalidOperation, targetObject));
        }
    }
}
