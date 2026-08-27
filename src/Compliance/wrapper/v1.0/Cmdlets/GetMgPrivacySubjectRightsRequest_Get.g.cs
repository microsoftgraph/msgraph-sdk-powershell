#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Graph.PowerShell.Compliance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("GET", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}")]
    [Cmdlet(VerbsCommon.Get, "MgPrivacySubjectRightsRequest_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest))]
    public class GetMgPrivacySubjectRightsRequest_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest? result;
            try
            {
                result = client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SubjectRightsRequestId);
                return;
            }

            WriteObject(result);
        }
    }
}
