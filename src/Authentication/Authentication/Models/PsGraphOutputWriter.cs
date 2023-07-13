// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    internal class PsGraphOutputWriter : IPSGraphOutputWriter
    {
        public Action<string> WriteObject { get; set; }
        public Action<string> WriteDebug { get; set; }
        public Action<Exception, string, int, object> WriteError { get; set; }
        public Action<object, string> WriteInformation { get; set; }
        public Action<string> WriteVerbose { get; set; }
    }
}