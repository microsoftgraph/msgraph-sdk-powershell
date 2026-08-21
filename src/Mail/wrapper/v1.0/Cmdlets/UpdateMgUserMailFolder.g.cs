#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Mail.Client;
using Microsoft.Graph.PowerShell.Mail.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Mail
{
    [GraphRoute("PATCH", "/users/{user-id}/mailFolders/{mailFolder-id}")]
    [Cmdlet(VerbsData.Update, "MgUserMailFolder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.MailFolder))]
    public class UpdateMgUserMailFolderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ChildFolderCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsHidden { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentFolderId { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalItemCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnreadItemCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MailFolderId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Mail.Client.Models.MailFolder();

    if (this.IsParameterBound(nameof(ChildFolderCount)))
        body.ChildFolderCount = ChildFolderCount;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsHidden)))
        body.IsHidden = IsHidden;

    if (this.IsParameterBound(nameof(ParentFolderId)))
        body.ParentFolderId = ParentFolderId;

    if (this.IsParameterBound(nameof(TotalItemCount)))
        body.TotalItemCount = TotalItemCount;

    if (this.IsParameterBound(nameof(UnreadItemCount)))
        body.UnreadItemCount = UnreadItemCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.MailFolder? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, MailFolderId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].MailFolders[MailFolderId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, MailFolderId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
