#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("DELETE", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgPrivacySubjectRightsRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgPrivacySubjectRightsRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubjectRightsRequestId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SubjectRightsRequestId);
                return;
            }
        }
    }
}
