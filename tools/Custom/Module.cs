// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NamespacePrefixPlaceholder.PowerShell.Runtime;
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Helpers;

namespace NamespacePrefixPlaceholder.PowerShell
{
    public partial class Module
    {
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Runtime.HttpPipeline pipeline)
        {
            // Call Init to trigger any custom initialization needed after
            // module load and before pipeline is setup and used.
            Init();
            pipeline = new Runtime.HttpPipeline(new Runtime.HttpClientFactory(HttpHelpers.GetGraphHttpClient()));
        }

        /// <summary>
        /// Any needed Custom Initialization.
        /// </summary>
        partial void CustomInit()
        {
            this.EventListener = EventHandler;
        }

        /// <summary>
        /// Common Module Event Listener, allows to handle emitted by CmdLets
        /// </summary>
        /// <param name="id">The ID of the event </param>
        /// <param name="cancellationToken">The cancellation token for the event </param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher</param>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">The cmdlet's parameterset name</param>
        /// <param name="exception">the exception that is being thrown (if available)</param>
        /// <returns>
        /// A <see cref="Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        public async Task EventHandler(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, InvocationInfo invocationInfo, string parameterSetName, System.Exception exception)
        {
            switch (id)
            {
                case Events.CmdletBeginProcessing:
                    await OnCmdletBeginProcessing(id, cancellationToken, getEventData, signal, invocationInfo);
                    break;
                case Events.BeforeCall:
                    if (!IsPsCore())
                        await OnBeforeCall(id, cancellationToken, getEventData, signal);
                    break;
                case Events.ResponseCreated:
                    await OnResponseCreated(id, cancellationToken, getEventData, signal);
                    break;
                case Events.CmdletException:
                    await OnCmdletException(id, cancellationToken, getEventData, signal, exception);
                    break;
                case Events.CmdletEndProcessing:
                    await OnCmdletEndProcessing(id, cancellationToken, getEventData, signal, invocationInfo);
                    break;
            }
        }

        private async Task OnCmdletBeginProcessing(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, InvocationInfo invocationInfo)
        {
            using (Extensions.NoSynchronizationContext)
            {
                string[] commandNameSegment = invocationInfo.MyCommand.Name.Split('_');
                if (commandNameSegment.Length > 1)
                {
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[{id}]: - {commandNameSegment[0]} begin processing with parameterSet '{commandNameSegment[1]}'."));
                }
                else
                {
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[{id}]: - {invocationInfo.MyCommand.Name} begin processing."));
                }
                IAuthContext authContext = Microsoft.Graph.PowerShell.Authentication.GraphSession.Instance.AuthContext;
                if (authContext != null)
                {
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[Authentication]: - AuthType: '{authContext.AuthType}', TokenCredentialType: '{authContext.TokenCredentialType}', ContextScope: '{authContext.ContextScope}', AppName: '{authContext.AppName}'."));
                    var scopes = authContext.Scopes == null ? string.Empty : string.Join(", ", authContext.Scopes);
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[Authentication]: - Scopes: [{scopes}]."));
                }
            }
        }

        private async Task OnBeforeCall(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal)
        {
            using (Extensions.NoSynchronizationContext)
            {
                var eventData = EventDataConverter.ConvertFrom(getEventData());
                var request = eventData?.RequestMessage as HttpRequestMessage;
                if (request != null)
                {
                    await signal(Events.Debug, cancellationToken,
                        () => EventFactory.CreateLogEvent(HttpMessageLogFormatter.GetHttpRequestLogAsync(request)));
                }
            }
        }

        private async Task OnResponseCreated(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal)
        {
            using (Extensions.NoSynchronizationContext)
            {
                var eventData = EventDataConverter.ConvertFrom(getEventData());
                var response = eventData?.ResponseMessage as HttpResponseMessage;
                if (response != null)
                {
                    if (response.Headers.Warning != null && response.Headers.Warning.Any())
                    {
                        string warningHeader = response.Headers.Warning.ToString();
                        await signal(Events.Warning, cancellationToken,
                            () => EventFactory.CreateWarningEvent(warningHeader));
                    }
                    if (IsPsCore())
                    {
                        // Log request after response since all our request header are set via middleware pipeline.
                        var request = response?.RequestMessage;
                        if (request != null)
                        {
                            await signal(Events.Debug, cancellationToken,
                                () => EventFactory.CreateLogEvent(HttpMessageLogFormatter.GetHttpRequestLogAsync(request)));
                        }
                    }

                    await signal(Events.Debug, cancellationToken,
                        () => EventFactory.CreateLogEvent(HttpMessageLogFormatter.GetHttpResponseLogAsync(response)));
                }
            }
        }

        private async Task OnCmdletException(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, Exception exception)
        {
            using (Extensions.NoSynchronizationContext)
            {
                var eventData = EventDataConverter.ConvertFrom(getEventData());
                await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[{id}]: Received exception with message '{eventData?.Message}'"));
            }
        }

        private async Task OnCmdletEndProcessing(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, InvocationInfo invocationInfo)
        {
            using (Extensions.NoSynchronizationContext)
            {
                string[] commandNameSegment = invocationInfo.MyCommand.Name.Split('_');
                if (commandNameSegment.Length > 1)
                {
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[{id}]: - {commandNameSegment[0]} end processing."));
                }
                else
                {
                    await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent($"[{id}]: - {invocationInfo.MyCommand.Name} end processing."));
                }
            }
        }

        private bool IsPsCore()
        {
            var psCoreVersion = new Version(6,0,0);
            return GraphSession.Instance.AuthContext.PSHostVersion >= psCoreVersion;
        }
    }
}
