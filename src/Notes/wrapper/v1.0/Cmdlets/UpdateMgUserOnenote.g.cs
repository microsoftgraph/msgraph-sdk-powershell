#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("PATCH", "/users/{user-id}/onenote")]
    [Cmdlet(VerbsData.Update, "MgUserOnenote", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote))]
    public class UpdateMgUserOnenoteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote? result;
            try
            {
                result = client.Users[UserId].Onenote.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Onenote.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
