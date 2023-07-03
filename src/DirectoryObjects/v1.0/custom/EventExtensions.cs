// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell
{
    using System;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Graph.PowerShell.Runtime;

    public static class EventExtensions
    {
        /// <summary>
        /// Print event details to the provided stream
        /// </summary>
        /// <param name="getEventData">The event data to print</param>
        /// <param name="signal">The delegate for signaling events to the runtime</param>
        /// <param name="token">The cancellation token for the request</param>
        /// <param name="streamName">The name of the stream to print data to</param>
        /// <param name="eventName">The name of the event to be printed</param>
        public static async void Print(this Func<EventArgs> getEventData, Func<string, CancellationToken, Func<EventArgs>, Task> signal, CancellationToken token, string streamName, string eventName)
        {
            var eventDisplayName = EventFactory.SplitPascalCase(eventName).ToUpperInvariant();
            var data = EventDataConverter.ConvertFrom(getEventData()); // also, we manually use our TypeConverter to return an appropriate type
            if (data.Id != Events.Verbose && data.Id != Events.Warning && data.Id != Events.Debug && data.Id != Events.Information && data.Id != Events.Error)
            {
                await signal(streamName, token, () => EventFactory.CreateLogEvent($"{eventDisplayName} The contents are '{data?.Id}' and '{data?.Message}'"));
                if (data != null)
                {
                    await signal(streamName, token, () => EventFactory.CreateLogEvent($"{eventDisplayName} Parameter: '{data.Parameter}'\n{eventDisplayName} RequestMessage '{data.RequestMessage}'\n{eventDisplayName} Response: '{data.ResponseMessage}'\n{eventDisplayName} Value: '{data.Value}'"));
                    await signal(streamName, token, () => EventFactory.CreateLogEvent($"{eventDisplayName} ExtendedData Type: '{data.ExtendedData?.GetType()}'\n{eventDisplayName} ExtendedData '{data.ExtendedData}'"));
                }
            }
        }
    }
}
