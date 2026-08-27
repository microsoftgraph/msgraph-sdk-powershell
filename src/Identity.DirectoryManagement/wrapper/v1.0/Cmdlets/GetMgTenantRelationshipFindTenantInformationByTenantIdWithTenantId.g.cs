#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/tenantRelationships/findTenantInformationByTenantId(tenantId='{tenantId}')")]
    [Cmdlet(VerbsCommon.Get, "MgTenantRelationshipFindTenantInformationByTenantIdWithTenantId")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.TenantInformation))]
    public class GetMgTenantRelationshipFindTenantInformationByTenantIdWithTenantIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'tenantId' parameter of this OData function.")]
        public string TenantId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "tenantId", TenantId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.TenantRelationships.FindTenantInformationByTenantIdWithTenantId.FindTenantInformationByTenantIdWithTenantIdRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.TenantInformation? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
