#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("POST", "/administrativeUnits/{administrativeUnit-id}/getMemberObjects")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAdministrativeUnitGetMemberObjects", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.AdministrativeUnits.Item.GetMemberObjects.GetMemberObjectsPostResponse))]
    public class InvokeMgAdministrativeUnitGetMemberObjectsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AdministrativeUnitId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabledOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AdministrativeUnitId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.AdministrativeUnits.Item.GetMemberObjects.GetMemberObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(SecurityEnabledOnly)))
        body.SecurityEnabledOnly = SecurityEnabledOnly;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.AdministrativeUnits.Item.GetMemberObjects.GetMemberObjectsPostResponse? result;
            try
            {
                result = client.AdministrativeUnits[AdministrativeUnitId].GetMemberObjects.PostAsGetMemberObjectsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AdministrativeUnitId);
                return;
            }

            WriteObject(result);
        }
    }
}
