#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/directory/inboundSharedUserProfiles/{inboundSharedUserProfile-userId}/removePersonalData")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDirectoryInboundSharedUserProfileRemovePersonalData", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDirectoryInboundSharedUserProfileRemovePersonalDataCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string InboundSharedUserProfileUserId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(InboundSharedUserProfileUserId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Directory.InboundSharedUserProfiles[InboundSharedUserProfileUserId].RemovePersonalData.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, InboundSharedUserProfileUserId);
                return;
            }

        }
    }
}
