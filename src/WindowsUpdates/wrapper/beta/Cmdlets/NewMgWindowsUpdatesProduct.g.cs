#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("POST", "/admin/windows/updates/products")]
    [Cmdlet(VerbsCommon.New, "MgWindowsUpdatesProduct", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Product))]
    public class NewMgWindowsUpdatesProductCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? FriendlyNames { get; set; }

        [Parameter(Mandatory = false)]
        public string? GroupName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Product();

    if (this.IsParameterBound(nameof(FriendlyNames)))
        body.FriendlyNames = FriendlyNames!.ToList();

    if (this.IsParameterBound(nameof(GroupName)))
        body.GroupName = GroupName;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Product? result;
            try
            {
                result = client.Admin.Windows.Updates.Products.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
