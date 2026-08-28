#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CloudPrint
{
    [GraphRoute("POST", "/print/shares/{printerShare-id}/jobs")]
    [Cmdlet(VerbsCommon.New, "MgPrintShareJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJob))]
    public class NewMgPrintShareJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterShareId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AcknowledgedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsFetchable { get; set; }

        [Parameter(Mandatory = false)]
        public string? RedirectedFrom { get; set; }

        [Parameter(Mandatory = false)]
        public string? RedirectedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJobConfiguration? Configuration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.UserIdentity? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJobStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrinterShareId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJob();

    if (this.IsParameterBound(nameof(AcknowledgedDateTime)))
        body.AcknowledgedDateTime = AcknowledgedDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

    if (this.IsParameterBound(nameof(IsFetchable)))
        body.IsFetchable = IsFetchable;

    if (this.IsParameterBound(nameof(RedirectedFrom)))
        body.RedirectedFrom = RedirectedFrom;

    if (this.IsParameterBound(nameof(RedirectedTo)))
        body.RedirectedTo = RedirectedTo;

    if (this.IsParameterBound(nameof(Configuration)))
        body.Configuration = Configuration;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJob? result;
            try
            {
                result = client.Print.Shares[PrinterShareId].Jobs.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
