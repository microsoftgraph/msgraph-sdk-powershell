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

namespace DeleteQueryProbe
{
    public sealed class CapturedRequest
    {
        public string Method { get; set; }
        public string Uri { get; set; }
        public string DecodedUri { get; set; }
        public string Body { get; set; }
        public bool HasContent { get; set; }
        public string Authorization { get; set; }
        public Dictionary<string, string> Headers { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    }

    public sealed class CaptureHandler : DelegatingHandler
    {
        public List<CapturedRequest> Requests { get; } = new List<CapturedRequest>();
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
        {
            var captured = new CapturedRequest
            {
                Method = request.Method.Method,
                Uri = request.RequestUri.AbsoluteUri,
                DecodedUri = System.Uri.UnescapeDataString(request.RequestUri.AbsoluteUri),
                Body = request.Content == null ? null : await request.Content.ReadAsStringAsync(),
                HasContent = request.Content != null,
                Authorization = request.Headers.Authorization?.ToString()
            };
            foreach (var header in request.Headers)
                captured.Headers.Add(header.Key, string.Join(",", header.Value));
            Requests.Add(captured);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }

    public sealed class FamilyCaptureHandler : DelegatingHandler
    {
        public List<CapturedRequest> Requests { get; } = new List<CapturedRequest>();
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
        {
            var captured = new CapturedRequest
            {
                Method = request.Method.Method, Uri = request.RequestUri.AbsoluteUri,
                DecodedUri = System.Uri.UnescapeDataString(request.RequestUri.AbsoluteUri),
                HasContent = request.Content != null,
                Body = request.Content == null ? null : await request.Content.ReadAsStringAsync(),
                Authorization = request.Headers.Authorization?.ToString()
            };
            foreach (var header in request.Headers)
                captured.Headers.Add(header.Key, string.Join(",", header.Value));
            Requests.Add(captured);
            var path = request.RequestUri.AbsolutePath;
            if (request.Method == HttpMethod.Delete || request.Method.Method == "PATCH"
                || path.EndsWith("/promote", StringComparison.Ordinal)
                || (path.EndsWith("/$ref", StringComparison.Ordinal) && request.Method != HttpMethod.Get))
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            if (path.EndsWith("/$count", StringComparison.Ordinal))
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("2", Encoding.UTF8, "text/plain") };
            if (path.EndsWith("/content", StringComparison.Ordinal))
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(new byte[] { 1, 2, 3 }) };
            if (path.EndsWith("/owner/$ref", StringComparison.Ordinal))
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("\"https://graph.microsoft.com/directoryObjects/owner\"", Encoding.UTF8, "application/json") };
            var collection = path.EndsWith("/widgets", StringComparison.Ordinal) && request.Method == HttpMethod.Get
                || path.EndsWith("/calendarView", StringComparison.Ordinal)
                || path.EndsWith("/selectedWidgets", StringComparison.Ordinal);
            var delta = path.EndsWith("/delta()", StringComparison.Ordinal);
            var body = collection || delta ? "{\"value\":[{\"id\":\"offline-proof\"}]}" : "{\"id\":\"offline-proof\",\"displayName\":\"returned\"}";
            if (delta)
                body = "{\"value\":[{\"id\":\"offline-proof\"}],\"@odata.deltaLink\":\""
                    + request.RequestUri.GetLeftPart(UriPartial.Path) + "?serverState=next\"}";
            if (collection && path.EndsWith("/widgets", StringComparison.Ordinal) && request.RequestUri.Query.Contains("pages")
                && !request.RequestUri.Query.Contains("continued"))
                body = "{\"value\":[{\"id\":\"offline-proof\"}],\"@odata.nextLink\":\""
                    + request.RequestUri.GetLeftPart(UriPartial.Path) + "?continued=1\"}";
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(body, Encoding.UTF8, "application/json") };
        }
    }

    public sealed class ChoiceHost : PSHost
    {
        private readonly ChoiceUI ui = new ChoiceUI();
        public bool Accept { get => ui.Accept; set => ui.Accept = value; }
        public int PromptCount => ui.PromptCount;
        public override Guid InstanceId { get; } = Guid.NewGuid();
        public override string Name => "RequiredDeleteQueryProbe";
        public override Version Version => new Version(1, 0);
        public override PSHostUserInterface UI => ui;
        public override CultureInfo CurrentCulture => CultureInfo.InvariantCulture;
        public override CultureInfo CurrentUICulture => CultureInfo.InvariantCulture;
        public override void EnterNestedPrompt() => throw new NotSupportedException();
        public override void ExitNestedPrompt() => throw new NotSupportedException();
        public override void NotifyBeginApplication() { }
        public override void NotifyEndApplication() { }
        public override void SetShouldExit(int exitCode) => throw new InvalidOperationException("Unexpected host exit.");
    }

    public sealed class ChoiceUI : PSHostUserInterface
    {
        public bool Accept { get; set; }
        public int PromptCount { get; private set; }
        public override PSHostRawUserInterface RawUI => null;
        public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
        {
            var answer = Accept ? "Yes" : "No";
            for (var index = 0; index < choices.Count; index++)
                if (choices[index].Label.Replace("&", "") == answer)
                {
                    PromptCount++;
                    return index;
                }
            throw new InvalidOperationException("Expected a genuine ShouldProcess confirmation choice.");
        }
        public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions) =>
            throw new InvalidOperationException("Unexpected parameter prompt.");
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName) =>
            throw new InvalidOperationException("Unexpected credentials prompt.");
        public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName,
            PSCredentialTypes types, PSCredentialUIOptions options) => throw new InvalidOperationException("Unexpected credentials prompt.");
        public override string ReadLine() => throw new InvalidOperationException("Unexpected input.");
        public override SecureString ReadLineAsSecureString() => throw new InvalidOperationException("Unexpected secure input.");
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
