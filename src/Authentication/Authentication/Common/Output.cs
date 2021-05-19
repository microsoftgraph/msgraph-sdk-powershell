// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using System;

    public class Output : IOutput
    {
        public Action<string> WriteObject { get; set; }
        public Action<string> WriteDebug { get; set; }
        public Action<Exception, string, int, object> WriteError { get; set; }
        public Action<object, string[]> WriteInformation { get; set; }
        public Action<string> WriteVerbose { get; set; }
    }
}