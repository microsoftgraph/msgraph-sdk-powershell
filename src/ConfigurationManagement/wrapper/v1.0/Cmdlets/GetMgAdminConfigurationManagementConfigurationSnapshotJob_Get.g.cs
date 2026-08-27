#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.ConfigurationManagement
{
    [GraphRoute("GET", "/admin/configurationManagement/configurationSnapshotJobs/{configurationSnapshotJob-id}")]
    [Cmdlet(VerbsCommon.Get, "MgAdminConfigurationManagementConfigurationSnapshotJob_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationSnapshotJob))]
    public class GetMgAdminConfigurationManagementConfigurationSnapshotJob_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConfigurationSnapshotJobId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationSnapshotJob? result;
            try
            {
                result = client.Admin.ConfigurationManagement.ConfigurationSnapshotJobs[ConfigurationSnapshotJobId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ConfigurationSnapshotJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
