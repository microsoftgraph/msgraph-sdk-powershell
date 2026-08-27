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
    [GraphRoute("POST", "/admin/configurationManagement/configurationDrifts")]
    [Cmdlet(VerbsCommon.New, "MgAdminConfigurationManagementConfigurationDrift", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationDrift))]
    public class NewMgAdminConfigurationManagementConfigurationDriftCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.OpenComplexDictionaryType? ResourceInstanceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.DriftStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.Admin.ConfigurationManagement.ConfigurationDrifts.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
