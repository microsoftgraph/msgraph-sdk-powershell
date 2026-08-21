#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.ConfigurationManagement
{
    [GraphRoute("PATCH", "/admin/configurationManagement/configurationDrifts/{configurationDrift-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminConfigurationManagementConfigurationDrift", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationDrift))]
    public class UpdateMgAdminConfigurationManagementConfigurationDriftCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConfigurationDriftId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.OpenComplexDictionaryType? ResourceInstanceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.DriftStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConfigurationDriftId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationDrift();


    if (this.IsParameterBound(nameof(ResourceInstanceIdentifier)))
        body.ResourceInstanceIdentifier = ResourceInstanceIdentifier;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationDrift? result;
            try
            {
                result = client.Admin.ConfigurationManagement.ConfigurationDrifts[ConfigurationDriftId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ConfigurationDriftId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ConfigurationManagement.ConfigurationDrifts[ConfigurationDriftId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ConfigurationDriftId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
