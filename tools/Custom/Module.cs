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
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Runtime.HttpPipeline pipeline)
        {
            pipeline = new Runtime.HttpPipeline(new Runtime.HttpClientFactory(HttpHelpers.GetGraphHttpClient()));
        }
        partial void CustomInit()
        {
            this.EventListener = EventHandler;
        }
        public async Task EventHandler(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, InvocationInfo invocationInfo, string parameterSetName, System.Exception exception)
        {
            switch (id)
            {
                case Events.Finally:
                    await Finally(id, cancellationToken, getEventData, signal);
                    break;
                default:
                    getEventData.Print(signal, cancellationToken, Events.Information, id);
                    break;
            }
        }

        private async Task Finally(string id, CancellationToken cancellationToken, Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal)
        {
            using (Extensions.NoSynchronizationContext)
            {
                var eventData = EventDataConverter.ConvertFrom(getEventData());
                using (var requestFormatter = new HttpMessageFormatter(eventData.RequestMessage as HttpRequestMessage))
                using (var responseFormatter = new HttpMessageFormatter(eventData.ResponseMessage as HttpResponseMessage))
                {
                    var requestString = await requestFormatter.ReadAsStringAsync();
                    var responseString = await responseFormatter.ReadAsStringAsync();
                    await signal(Events.Debug, cancellationToken, () => EventHelper.CreateLogEvent(requestString));
                    await signal(Events.Debug, cancellationToken, () => EventHelper.CreateLogEvent(responseString));
                }
            }
        }
    }
}
