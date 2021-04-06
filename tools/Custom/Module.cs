// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Graph.PowerShell.Authentication.Models;

    using System;
    using System.Linq;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;

    public partial class Module
    {
        /// <summary>
        /// The selected Microsoft Graph profile.
        /// </summary>
        public string ProfileName { get; set; } = "v1.0";
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
            if (invocationInfo.BoundParameters.ContainsKey("Debug"))
            {
                switch (id)
                {
                    case Events.BeforeCall:
                        await BeforeCall(id, cancellationToken, getEventData, signal);
                        break;
                    case Events.Finally:
                        await Finally(id, cancellationToken, getEventData, signal);
                        break;
                    default:
                        getEventData.Print(signal, cancellationToken, Events.Information, id);
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the Finally event, which is called just after a response is received.
        /// </summary>
        /// <param name="id">The ID of the event</param>
        /// <param name="cancellationToken">The cancellation token for the event</param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher</param>
        /// <returns>
        /// A <see cref="Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        private async Task Finally(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal)
        {
            using (Extensions.NoSynchronizationContext)
            {
 				var eventData = EventDataConverter.ConvertFrom(getEventData());
                var responseFormatter = new HttpMessageFormatter(eventData.ResponseMessage as HttpResponseMessage);
                var responseString = await responseFormatter.ReadAsStringAsync();
                await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent(responseString));
            }
        }

        /// <summary>
        /// Handles the BeforeCall event, which is called just before Request is sent.
        /// </summary>
        /// <param name="id">The ID of the event</param>
        /// <param name="cancellationToken">The cancellation token for the event</param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher</param>
        /// <returns>
        /// A <see cref="Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        private async Task BeforeCall(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal)
        {
            using (Extensions.NoSynchronizationContext)
            {
  				var eventData = EventDataConverter.ConvertFrom(getEventData());
                var requestFormatter = new HttpMessageFormatter(eventData.RequestMessage as HttpRequestMessage);
                var requestString = await requestFormatter.ReadAsStringAsync();
                await signal(Events.Debug, cancellationToken, () => EventFactory.CreateLogEvent(requestString));
            }

        }
    }
}