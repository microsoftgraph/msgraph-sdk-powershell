#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("POST", "/external/industryData/referenceDefinitions")]
    [Cmdlet(VerbsCommon.New, "MgExternalIndustryDataReferenceDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ReferenceDefinition))]
    public class NewMgExternalIndustryDataReferenceDefinitionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReferenceType { get; set; }

        [Parameter(Mandatory = false)]
        public int? SortIndex { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ReferenceDefinition();

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsDisabled)))
        body.IsDisabled = IsDisabled;

    if (this.IsParameterBound(nameof(ReferenceType)))
        body.ReferenceType = ReferenceType;

    if (this.IsParameterBound(nameof(SortIndex)))
        body.SortIndex = SortIndex;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ReferenceDefinition? result;
            try
            {
                result = client.External.IndustryData.ReferenceDefinitions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
