#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/caseMembers/{ediscoveryCaseMember-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityCaseEdiscoveryCaseMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseMember))]
    public class UpdateMgSecurityCaseEdiscoveryCaseMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoveryCaseMemberId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SmtpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.RecipientType? RecipientType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoveryCaseMemberId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseMember();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(SmtpAddress)))
        body.SmtpAddress = SmtpAddress;

    if (this.IsParameterBound(nameof(RecipientType)))
        body.RecipientType = RecipientType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryCaseMember? result;
            try
            {
                result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].CaseMembers[EdiscoveryCaseMemberId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryCaseMemberId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].CaseMembers[EdiscoveryCaseMemberId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EdiscoveryCaseMemberId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
