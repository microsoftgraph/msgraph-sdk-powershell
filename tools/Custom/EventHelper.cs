// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell
{
    public static class EventHelper
    {
        /// <summary>
        /// Create a tracing event containing a string message
        /// </summary>
        /// <param name="message">The string message to include in event data</param>
        /// <returns>Valid EventData containign the message</returns>
        public static EventData CreateLogEvent(Task<string> message)
        {
            return new EventData
            {
                Id = Guid.NewGuid().ToString(),
                Message = message.Result
            };
        }

        /// <summary>
        /// Create a new debug message event
        /// </summary>
        /// <param name="message">The message</param>
        /// <returns>An event cotnainng the debug message</returns>
        public static EventData CreateDebugEvent(string message)
        {
            return new EventData
            {
                Id = Events.Debug,
                Message = message
            };
        }

        /// <summary>
        /// Create a new debug message event
        /// </summary>
        /// <param name="message">The message</param>
        /// <returns>An event cotnainng the debug message</returns>
        public static EventData CreateWarningEvent(string message)
        {
            return new EventData
            {
                Id = Events.Warning,
                Message = message
            };
        }

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
            var eventDisplayName = SplitPascalCase(eventName).ToUpperInvariant();
            var data = EventDataConverter.ConvertFrom(getEventData()); // also, we manually use our TypeConverter to return an appropriate type
            if (data.Id != "Verbose" && data.Id != "Warning" && data.Id != "Debug" && data.Id != "Information" && data.Id != "Error")
            {
                await signal(streamName, token, () => EventHelper.CreateLogEvent($"{eventDisplayName} The contents are '{data?.Id}' and '{data?.Message}'"));
                if (data != null)
                {
                    await signal(streamName, token, () => EventHelper.CreateLogEvent($"{eventDisplayName} Parameter: '{data.Parameter}'\n{eventDisplayName} RequestMessage '{data.RequestMessage}'\n{eventDisplayName} Response: '{data.ResponseMessage}'\n{eventDisplayName} Value: '{data.Value}'"));
                    await signal(streamName, token, () => EventHelper.CreateLogEvent($"{eventDisplayName} ExtendedData Type: '{data.ExtendedData?.GetType()}'\n{eventDisplayName} ExtendedData '{data.ExtendedData}'"));
                }
            }
        }

        static string SplitPascalCase(string word)
        {
            var regex = new Regex("([a-z]+)([A-Z])");
            var output = regex.Replace(word, "$1 $2");
            regex = new Regex("([A-Z])([A-Z][a-z])");
            return regex.Replace(output, "$1 $2");
        }

        public static EventArgs CreateLogEvent(string message)
        {
            return new EventData
            {
                Id = Guid.NewGuid().ToString(),
                Message = message
            };
        }
    }
}