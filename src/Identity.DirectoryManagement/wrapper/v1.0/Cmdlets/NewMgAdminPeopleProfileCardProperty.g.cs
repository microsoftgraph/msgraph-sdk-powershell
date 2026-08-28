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
    [GraphRoute("POST", "/admin/people/profileCardProperties")]
    [Cmdlet(VerbsCommon.New, "MgAdminPeopleProfileCardProperty", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardProperty))]
    public class NewMgAdminPeopleProfileCardPropertyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? DirectoryPropertyName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsVisible { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProfileCardAnnotation[]? Annotations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.Admin.People.ProfileCardProperties.PostAsync(body, requestConfiguration =>
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
