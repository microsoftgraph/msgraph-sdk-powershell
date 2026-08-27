#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/identity/conditionalAccess/deletedItems/namedLocations/{namedLocation-id}/restore")]
    [Cmdlet(VerbsData.Restore, "MgIdentityConditionalAccessDeletedItemNamedLocation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.NamedLocation))]
    public class RestoreMgIdentityConditionalAccessDeletedItemNamedLocationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string NamedLocationId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(NamedLocationId, "Restore"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.NamedLocation? result;
            try
            {
                result = client.Identity.ConditionalAccess.DeletedItems.NamedLocations[NamedLocationId].Restore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, NamedLocationId);
                return;
            }

            WriteObject(result);
        }
    }
}
