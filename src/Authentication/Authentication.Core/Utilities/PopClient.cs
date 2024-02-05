using System;
using System.IdentityModel;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;
using Azure.Identity.Broker;
using Microsoft.Identity.Client.NativeInterop;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    public class PopClient
    {
        private readonly HttpPipeline _pipeline;
        private AuthenticationRecord _authenticationRecord;
        private readonly InteractiveBrowserCredential _interactiveBrowserCredential;

        public PopClient(TokenCredential credential, IAuthContext authContext, ClientOptions options = null)
        {
            //_interactiveBrowserCredential = (InteractiveBrowserCredential)credential;
            _interactiveBrowserCredential = new InteractiveBrowserCredential(new InteractiveBrowserCredentialBrokerOptions(WindowHandleUtlities.GetConsoleOrTerminalWindow()));

            if (!(credential is ISupportsProofOfPossession))
            {
                throw new ArgumentException("The provided TokenCredential does not support proof of possession.", nameof(credential));
            }

            var pipelineOptions = new HttpPipelineOptions(options);
            pipelineOptions.PerRetryPolicies.Add(new InteractivePopTokenAuthenticationPolicy(_interactiveBrowserCredential, "https://graph.microsoft.com/.default", () => _authenticationRecord));

            _pipeline = HttpPipelineBuilder.Build(pipelineOptions);
        }

        public async ValueTask<Response> GetAsync(Uri uri, CancellationToken cancellationToken = default)
        {
            using var request = _pipeline.CreateRequest();
            request.Method = RequestMethod.Get;
            request.Uri.Reset(uri);
            return await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public Response Get(Uri uri, CancellationToken cancellationToken = default)
        {
            using var request = _pipeline.CreateRequest();
            request.Method = RequestMethod.Get;
            request.Uri.Reset(uri);
            return _pipeline.SendRequest(request, cancellationToken);
        }

        public async ValueTask<AuthenticationRecord> GetAuthRecordAsync()
        {
            _authenticationRecord ??= await _interactiveBrowserCredential.AuthenticateAsync();
            return _authenticationRecord;
        }

        public AuthenticationRecord GetAuthRecord()
        {
            _authenticationRecord ??= _interactiveBrowserCredential.Authenticate();
            return _authenticationRecord;
        }
    }

    public class InteractivePopTokenAuthenticationPolicy : PopTokenAuthenticationPolicy
    {
        private readonly InteractiveBrowserCredential _interactiveBrowserCredential;
        private readonly Func<AuthenticationRecord> _getAuthRecord;

        public InteractivePopTokenAuthenticationPolicy(InteractiveBrowserCredential credential, string scope, Func<AuthenticationRecord> getAuthRecord)
            : base(credential, scope)
        {
            _interactiveBrowserCredential = credential;
            _getAuthRecord = getAuthRecord;
        }

        protected override ValueTask AuthorizeRequestAsync(HttpMessage message)
        {
            var authRecord = _getAuthRecord();
            if (authRecord != null)
            {
                _interactiveBrowserCredential.AuthenticateAsync(new TokenRequestContext(new[] { "https://graph.microsoft.com/.default" })).ConfigureAwait(false);
            }

            return base.AuthorizeRequestAsync(message);
        }
    }
}
