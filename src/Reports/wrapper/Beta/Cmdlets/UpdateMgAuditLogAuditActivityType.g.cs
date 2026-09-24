#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/auditLogs/auditActivityTypes/{auditActivityType-id}")]
    [Cmdlet(VerbsData.Update, "MgAuditLogAuditActivityType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.AuditActivityType))]
    public class UpdateMgAuditLogAuditActivityTypeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuditActivityTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public string? Category { get; set; }

        [Parameter(Mandatory = false)]
        public string? Service { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuditActivityTypeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.AuditActivityType();

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(Service)))
        body.Service = Service;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.AuditActivityType? result;
            try
            {
                result = client.AuditLogs.AuditActivityTypes[AuditActivityTypeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AuditActivityTypeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AuditLogs.AuditActivityTypes[AuditActivityTypeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AuditActivityTypeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
