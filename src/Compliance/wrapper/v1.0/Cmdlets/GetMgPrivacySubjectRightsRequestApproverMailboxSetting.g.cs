#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Graph.PowerShell.Compliance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("GET", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}/approvers/{user-id}/mailboxSettings")]
    [Cmdlet(VerbsCommon.Get, "MgPrivacySubjectRightsRequestApproverMailboxSetting")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.MailboxSettings))]
    public class GetMgPrivacySubjectRightsRequestApproverMailboxSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Compliance.Client.Models.MailboxSettings? result;
            try
            {
                result = client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].Approvers[UserId].MailboxSettings.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
