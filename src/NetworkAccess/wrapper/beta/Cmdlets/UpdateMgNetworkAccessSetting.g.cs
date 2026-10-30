#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/settings")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Settings))]
    public class UpdateMgNetworkAccessSettingCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConditionalAccessSettings? ConditionalAccess { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.CrossTenantAccessSettings? CrossTenantAccess { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.CustomBlockPage? CustomBlockPage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ForwardingOptions? ForwardingOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Settings();


    if (this.IsParameterBound(nameof(ConditionalAccess)))
        body.ConditionalAccess = ConditionalAccess;

    if (this.IsParameterBound(nameof(CrossTenantAccess)))
        body.CrossTenantAccess = CrossTenantAccess;

    if (this.IsParameterBound(nameof(CustomBlockPage)))
        body.CustomBlockPage = CustomBlockPage;

    if (this.IsParameterBound(nameof(ForwardingOptions)))
        body.ForwardingOptions = ForwardingOptions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Settings? result;
            try
            {
                result = client.NetworkAccess.Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
