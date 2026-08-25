#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/dataPolicyOperations")]
    [Cmdlet(VerbsCommon.New, "MgDataPolicyOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DataPolicyOperation))]
    public class NewMgDataPolicyOperationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? Progress { get; set; }

        [Parameter(Mandatory = false)]
        public string? StorageLocation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SubmittedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DataPolicyOperationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DataPolicyOperation();

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(Progress)))
        body.Progress = Progress;

    if (this.IsParameterBound(nameof(StorageLocation)))
        body.StorageLocation = StorageLocation;

    if (this.IsParameterBound(nameof(SubmittedDateTime)))
        body.SubmittedDateTime = SubmittedDateTime;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DataPolicyOperation? result;
            try
            {
                result = client.DataPolicyOperations.PostAsync(body, requestConfiguration =>
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
