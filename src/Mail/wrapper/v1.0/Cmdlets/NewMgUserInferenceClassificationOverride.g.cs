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
    [GraphRoute("POST", "/users/{user-id}/inferenceClassification/overrides")]
    [Cmdlet(VerbsCommon.New, "MgUserInferenceClassificationOverride", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.InferenceClassificationOverride))]
    public class NewMgUserInferenceClassificationOverrideCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.InferenceClassificationType? ClassifyAs { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.EmailAddress? SenderEmailAddress { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Mail.Client.Models.InferenceClassificationOverride();


    if (this.IsParameterBound(nameof(ClassifyAs)))
        body.ClassifyAs = ClassifyAs;

    if (this.IsParameterBound(nameof(SenderEmailAddress)))
        body.SenderEmailAddress = SenderEmailAddress;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.InferenceClassificationOverride? result;
            try
            {
                result = client.Users[UserId].InferenceClassification.Overrides.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
