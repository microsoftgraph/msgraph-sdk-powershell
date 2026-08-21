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
    [GraphRoute("PATCH", "/admin/people/profileCardProperties/{profileCardProperty-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminPeopleProfileCardProperty", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardProperty))]
    public class UpdateMgAdminPeopleProfileCardPropertyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProfileCardPropertyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DirectoryPropertyName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsVisible { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardAnnotation[]? Annotations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ProfileCardPropertyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardProperty();

    if (this.IsParameterBound(nameof(DirectoryPropertyName)))
        body.DirectoryPropertyName = DirectoryPropertyName;

    if (this.IsParameterBound(nameof(IsVisible)))
        body.IsVisible = IsVisible;

    if (this.IsParameterBound(nameof(Annotations)))
        body.Annotations = Annotations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardProperty? result;
            try
            {
                result = client.Admin.People.ProfileCardProperties[ProfileCardPropertyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ProfileCardPropertyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.People.ProfileCardProperties[ProfileCardPropertyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ProfileCardPropertyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
