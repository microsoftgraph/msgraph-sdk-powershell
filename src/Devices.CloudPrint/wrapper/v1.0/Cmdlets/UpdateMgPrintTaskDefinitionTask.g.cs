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
    [GraphRoute("PATCH", "/print/taskDefinitions/{printTaskDefinition-id}/tasks/{printTask-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintTaskDefinitionTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTask))]
    public class UpdateMgPrintTaskDefinitionTaskCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrintTaskDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ParentUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskDefinition? Definition { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskTrigger? Trigger { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTask();

    if (this.IsParameterBound(nameof(ParentUrl)))
        body.ParentUrl = ParentUrl;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Definition)))
        body.Definition = Definition;

    if (this.IsParameterBound(nameof(Trigger)))
        body.Trigger = Trigger;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTask? result;
            try
            {
                result = client.Print.TaskDefinitions[PrintTaskDefinitionId].Tasks[PrintTaskId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PrintTaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.TaskDefinitions[PrintTaskDefinitionId].Tasks[PrintTaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, PrintTaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
