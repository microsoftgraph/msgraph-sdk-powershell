#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/networkDays_Intl")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionNetworkDays_Intl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionNetworkDays_IntlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? StartDate { get; set; }

        [Parameter(Mandatory = false)]
        public object? EndDate { get; set; }

        [Parameter(Mandatory = false)]
        public object? Weekend { get; set; }

        [Parameter(Mandatory = false)]
        public object? Holidays { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.NetworkDays_Intl.NetworkDays_IntlPostRequestBody();

    if (this.IsParameterBound(nameof(StartDate)))
    {
        var untypedStartDate = UntypedValue.From(StartDate);
        if (untypedStartDate is not null)
            body.StartDate = untypedStartDate;
    }

    if (this.IsParameterBound(nameof(EndDate)))
    {
        var untypedEndDate = UntypedValue.From(EndDate);
        if (untypedEndDate is not null)
            body.EndDate = untypedEndDate;
    }

    if (this.IsParameterBound(nameof(Weekend)))
    {
        var untypedWeekend = UntypedValue.From(Weekend);
        if (untypedWeekend is not null)
            body.Weekend = untypedWeekend;
    }

    if (this.IsParameterBound(nameof(Holidays)))
    {
        var untypedHolidays = UntypedValue.From(Holidays);
        if (untypedHolidays is not null)
            body.Holidays = untypedHolidays;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.NetworkDays_Intl.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
