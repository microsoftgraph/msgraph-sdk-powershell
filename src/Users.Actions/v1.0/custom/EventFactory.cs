// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Graph.PowerShell.Runtime;

namespace Microsoft.Graph.PowerShell
{
    public static class EventFactory
    {
        /// <summary>
        /// Create a tracing event containing a string message
        /// </summary>
        /// <param name="message">The string message to include in event data</param>
        /// <returns>Valid EventData containing the message</returns>
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
        /// <returns>An event containing the debug message</returns>
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
        /// <returns>An event containing the debug message</returns>
        public static EventData CreateWarningEvent(string message)
        {
            return new EventData
            {
                Id = Events.Warning,
                Message = message
            };
        }
        public static string SplitPascalCase(string word)
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
