#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("POST", "/external/industryData/dataConnectors/{industryDataConnector-id}/microsoft.graph.industryData.validate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgExternalIndustryDataConnectorValidate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgExternalIndustryDataConnectorValidateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IndustryDataConnectorId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IndustryDataConnectorId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.External.IndustryData.DataConnectors[IndustryDataConnectorId].MicrosoftGraphIndustryDataValidate.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IndustryDataConnectorId);
                return;
            }

        }
    }
}
