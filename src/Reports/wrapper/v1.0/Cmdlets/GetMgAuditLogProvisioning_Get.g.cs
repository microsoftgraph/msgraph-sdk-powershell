#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("GET", "/auditLogs/provisioning/{provisioningObjectSummary-id}")]
    [Cmdlet(VerbsCommon.Get, "MgAuditLogProvisioning_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningObjectSummary))]
    public class GetMgAuditLogProvisioning_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProvisioningObjectSummaryId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningObjectSummary? result;
            try
            {
                result = client.AuditLogs.Provisioning[ProvisioningObjectSummaryId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ProvisioningObjectSummaryId);
                return;
            }

            WriteObject(result);
        }
    }
}
