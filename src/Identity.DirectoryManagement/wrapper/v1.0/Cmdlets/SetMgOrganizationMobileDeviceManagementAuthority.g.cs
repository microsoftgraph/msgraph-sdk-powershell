#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/organization/{organization-id}/setMobileDeviceManagementAuthority")]
    [Cmdlet(VerbsCommon.Set, "MgOrganizationMobileDeviceManagementAuthority", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Organization.Item.SetMobileDeviceManagementAuthority.SetMobileDeviceManagementAuthorityPostResponse))]
    public class SetMgOrganizationMobileDeviceManagementAuthorityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "Set"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Organization.Item.SetMobileDeviceManagementAuthority.SetMobileDeviceManagementAuthorityPostResponse? result;
            try
            {
                result = client.Organization[OrganizationId].SetMobileDeviceManagementAuthority.PostAsSetMobileDeviceManagementAuthorityPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OrganizationId);
                return;
            }

            WriteObject(result);
        }
    }
}
