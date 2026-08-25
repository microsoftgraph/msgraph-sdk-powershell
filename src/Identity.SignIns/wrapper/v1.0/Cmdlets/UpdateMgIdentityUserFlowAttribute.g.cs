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
    [GraphRoute("PATCH", "/identity/userFlowAttributes/{identityUserFlowAttribute-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityUserFlowAttribute", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttribute))]
    public class UpdateMgIdentityUserFlowAttributeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IdentityUserFlowAttributeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeDataType? DataType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeType? UserFlowAttributeType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IdentityUserFlowAttributeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttribute();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DataType)))
        body.DataType = DataType;

    if (this.IsParameterBound(nameof(UserFlowAttributeType)))
        body.UserFlowAttributeType = UserFlowAttributeType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttribute? result;
            try
            {
                result = client.Identity.UserFlowAttributes[IdentityUserFlowAttributeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, IdentityUserFlowAttributeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.UserFlowAttributes[IdentityUserFlowAttributeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, IdentityUserFlowAttributeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
