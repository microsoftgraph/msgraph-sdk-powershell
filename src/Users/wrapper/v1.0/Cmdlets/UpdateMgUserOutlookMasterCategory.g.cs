#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}/outlook/masterCategories/{outlookCategory-id}")]
    [Cmdlet(VerbsData.Update, "MgUserOutlookMasterCategory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.OutlookCategory))]
    public class UpdateMgUserOutlookMasterCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OutlookCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.CategoryColor? Color { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OutlookCategoryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.OutlookCategory();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Color)))
        body.Color = Color;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.OutlookCategory? result;
            try
            {
                result = client.Users[UserId].Outlook.MasterCategories[OutlookCategoryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OutlookCategoryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Outlook.MasterCategories[OutlookCategoryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, OutlookCategoryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
