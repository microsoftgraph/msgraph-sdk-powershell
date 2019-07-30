using Microsoft.Graph.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Graph
{
    public partial class Module
    {
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Runtime.HttpPipeline pipeline)
        {
            pipeline = new Runtime.HttpPipeline(new Runtime.HttpClientFactory(Authentication.GetGraphHttpClient()));
        }

        // CustomInit
    }
}
