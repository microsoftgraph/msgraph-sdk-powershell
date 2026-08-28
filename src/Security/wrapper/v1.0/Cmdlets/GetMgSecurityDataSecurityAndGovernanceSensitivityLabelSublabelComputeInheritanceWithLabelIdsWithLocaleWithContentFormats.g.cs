#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("GET", "/security/dataSecurityAndGovernance/sensitivityLabels/{sensitivityLabel-id}/sublabels/computeInheritance(labelIds={labelIds},locale='{locale}',contentFormats={contentFormats})")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityDataSecurityAndGovernanceSensitivityLabelSublabelComputeInheritanceWithLabelIdsWithLocaleWithContentFormats")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SensitivityLabel))]
    public class GetMgSecurityDataSecurityAndGovernanceSensitivityLabelSublabelComputeInheritanceWithLabelIdsWithLocaleWithContentFormatsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SensitivityLabelId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'labelIds' parameter of this OData function.")]
        public string LabelIds { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'locale' parameter of this OData function.")]
        public string Locale { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 3,
            HelpMessage = "Value for the 'contentFormats' parameter of this OData function.")]
        public string ContentFormats { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "sensitivityLabel%2Did", SensitivityLabelId },
            { "labelIds", LabelIds },
            { "locale", Locale },
            { "contentFormats", ContentFormats },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.SensitivityLabels.Item.Sublabels.ComputeInheritanceWithLabelIdsWithLocaleWithContentFormats.ComputeInheritanceWithLabelIdsWithLocaleWithContentFormatsRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.SensitivityLabel? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SensitivityLabelId);
                return;
            }

            WriteObject(result);
        }
    }
}
