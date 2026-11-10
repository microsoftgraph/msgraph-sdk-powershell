// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Collections;
using System.Linq;
using System.Management.Automation;
using System.Security;
using System.Threading.Tasks;
using static Microsoft.Graph.PowerShell.Authentication.Helpers.AsyncHelpers;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    /// <summary>
    /// Gets an access token for the current <c>Connect-MgGraph</c> session. The token is cached and
    /// is only refreshed when it is close to expiry (less than 5 minutes remaining) or when
    /// <c>-ForceRefresh</c> is specified.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "MgAccessToken", HelpUri = "https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgaccesstoken")]
    [OutputType(typeof(SecureString))]
    [OutputType(typeof(MgAccessTokenInfo))]
    public class GetMgAccessToken : PSCmdlet
    {
        [Parameter(Mandatory = false, Position = 0, HelpMessage = Constants.HelpMessages.Scopes)]
        public string[] Scopes { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.HelpMessages.ForceRefresh)]
        [Alias("Force")]
        public SwitchParameter ForceRefresh { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.HelpMessages.AsObject)]
        public SwitchParameter AsObject { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, default))
                {
                    GraphSessionInitializer.InitializeOutput(asyncCommandRuntime);
                    asyncCommandRuntime.Wait(ProcessRecordAsync());
                }
            }
            catch (AggregateException aggregateException)
            {
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    var errorRecords = innerException.Data;
                    if (errorRecords.Count > 1)
                        foreach (DictionaryEntry dictionaryEntry in errorRecords)
                            WriteError((ErrorRecord)dictionaryEntry.Value);
                    else
                        WriteError(new ErrorRecord(innerException, string.Empty, ErrorCategory.NotSpecified, null));
                }
            }
            catch (Exception exception) when (exception as PipelineStoppedException == null ||
                                              (exception as PipelineStoppedException).InnerException != null)
            {
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        private async Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                IAuthContext authContext = GraphSession.Instance.AuthContext;
                if (authContext is null)
                    throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext);

                if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
                {
                    if (MyInvocation.BoundParameters.ContainsKey(nameof(Scopes)))
                        throw new PSInvalidOperationException(string.Format(ErrorConstants.Message.UserProvidedAccessTokenParameterNotSupported, nameof(Scopes)));
                    if (MyInvocation.BoundParameters.ContainsKey(nameof(ForceRefresh)))
                        throw new PSInvalidOperationException(string.Format(ErrorConstants.Message.UserProvidedAccessTokenParameterNotSupported, nameof(ForceRefresh)));
                }

                string[] requestedScopes = Scopes != null && Scopes.Any() ? Scopes : authContext.Scopes;
                if (requestedScopes == null || !requestedScopes.Any())
                    throw new PSInvalidOperationException(Core.ErrorConstants.Message.MissingAuthContext);

                var accessToken = await AuthenticationHelpers.GetAccessTokenAsync(authContext, requestedScopes, ForceRefresh.IsPresent).ConfigureAwait(false);

                if (AsObject.IsPresent)
                {
                    WriteObject(new MgAccessTokenInfo
                    {
                        Token = accessToken.Token,
                        ExpiresOn = accessToken.ExpiresOn,
                        Scopes = requestedScopes
                    });
                }
                else
                {
                    WriteObject(accessToken.Token);
                }
            }
        }
    }
}
