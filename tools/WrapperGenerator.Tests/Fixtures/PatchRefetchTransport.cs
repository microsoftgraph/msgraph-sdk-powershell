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

namespace PatchRefetchTransport
{
    public sealed class CapturedRequest
    {
        public string Method;
        public string Uri;
        public string Body;
        public string Marker;
        public string Multiple;
        public string IfMatch;
        public int ResponseStatus;
    }

    public sealed class CaptureHandler : HttpMessageHandler
    {
        public readonly List<CapturedRequest> Requests = new List<CapturedRequest>();
        public bool ReturnPatchBody;
        private static string Header(HttpRequestMessage request, string name)
        {
            IEnumerable<string> values;
            return request.Headers.TryGetValues(name, out values) ? string.Join(",", values) : "";
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
        {
            var captured = new CapturedRequest {
                Method = request.Method.Method, Uri = request.RequestUri.AbsoluteUri,
                Body = request.Content == null ? "" : await request.Content.ReadAsStringAsync(),
                Marker = Header(request, "X-Refetch-Proof"), Multiple = Header(request, "X-Multiple"),
                IfMatch = Header(request, "If-Match")
            };
            Requests.Add(captured);
            if (request.Method == HttpMethod.Put || (request.Method.Method == "PATCH" && !ReturnPatchBody)) {
                captured.ResponseStatus = 204;
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            captured.ResponseStatus = 200;
            return new HttpResponseMessage(HttpStatusCode.OK) {
                Content = new StringContent(request.Method.Method == "PATCH"
                    ? "{\"id\":\"patch-body\"}" : "{\"id\":\"refetched\"}", Encoding.UTF8, "application/json")
            };
        }
    }

    public sealed class ConfirmationHost : PSHost
    {
        private readonly ConfirmationUI ui = new ConfirmationUI();
        private readonly Guid id = Guid.NewGuid();
        public bool Accept { get { return ui.Accept; } set { ui.Accept = value; } }
        public int PromptCount { get { return ui.Prompts; } }
        public override Guid InstanceId { get { return id; } }
        public override string Name { get { return "PatchRefetchConfirmation"; } }
        public override Version Version { get { return new Version(1, 0); } }
        public override PSHostUserInterface UI { get { return ui; } }
        public override CultureInfo CurrentCulture { get { return CultureInfo.InvariantCulture; } }
        public override CultureInfo CurrentUICulture { get { return CultureInfo.InvariantCulture; } }
        public override void EnterNestedPrompt() { throw new NotSupportedException(); }
        public override void ExitNestedPrompt() { throw new NotSupportedException(); }
        public override void NotifyBeginApplication() { }
        public override void NotifyEndApplication() { }
        public override void SetShouldExit(int exitCode) { throw new InvalidOperationException("Unexpected exit."); }
    }

    public sealed class ConfirmationUI : PSHostUserInterface
    {
        public bool Accept;
        public int Prompts { get; private set; }
        public override PSHostRawUserInterface RawUI { get { return null; } }
        public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int fallback)
        {
            string expected = Accept ? "Yes" : "No";
            for (int i = 0; i < choices.Count; i++)
                if (choices[i].Label.Replace("&", "") == expected) { Prompts++; return i; }
            throw new InvalidOperationException("Missing confirmation choice: " + expected);
        }
        public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
            { throw new InvalidOperationException("Unexpected parameter prompt."); }
        public override PSCredential PromptForCredential(string caption, string message, string user, string target)
            { throw new InvalidOperationException("Unexpected credential prompt."); }
        public override PSCredential PromptForCredential(string caption, string message, string user, string target,
            PSCredentialTypes types, PSCredentialUIOptions options) { throw new InvalidOperationException("Unexpected credential prompt."); }
        public override string ReadLine() { throw new InvalidOperationException("Unexpected input."); }
        public override SecureString ReadLineAsSecureString() { throw new InvalidOperationException("Unexpected input."); }
        public override void Write(string value) { }
        public override void Write(ConsoleColor foreground, ConsoleColor background, string value) { }
        public override void WriteLine(string value) { }
        public override void WriteDebugLine(string value) { }
        public override void WriteErrorLine(string value) { }
        public override void WriteProgress(long source, ProgressRecord record) { }
        public override void WriteVerboseLine(string value) { }
        public override void WriteWarningLine(string value) { }
    }
}
