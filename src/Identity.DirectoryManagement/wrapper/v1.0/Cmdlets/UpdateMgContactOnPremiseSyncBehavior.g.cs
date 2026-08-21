#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/contacts/{orgContact-id}/onPremisesSyncBehavior")]
    [Cmdlet(VerbsData.Update, "MgContactOnPremiseSyncBehavior", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesSyncBehavior))]
    public class UpdateMgContactOnPremiseSyncBehaviorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrgContactId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsCloudManaged { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrgContactId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesSyncBehavior();

    if (this.IsParameterBound(nameof(IsCloudManaged)))
        body.IsCloudManaged = IsCloudManaged;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesSyncBehavior? result;
            try
            {
                result = client.Contacts[OrgContactId].OnPremisesSyncBehavior.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OrgContactId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Contacts[OrgContactId].OnPremisesSyncBehavior.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, OrgContactId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
