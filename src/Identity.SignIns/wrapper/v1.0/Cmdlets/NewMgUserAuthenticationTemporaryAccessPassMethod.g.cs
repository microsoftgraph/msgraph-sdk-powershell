#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/users/{user-id}/authentication/temporaryAccessPassMethods")]
    [Cmdlet(VerbsCommon.New, "MgUserAuthenticationTemporaryAccessPassMethod", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TemporaryAccessPassAuthenticationMethod))]
    public class NewMgUserAuthenticationTemporaryAccessPassMethodCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUsable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUsableOnce { get; set; }

        [Parameter(Mandatory = false)]
        public int? LifetimeInMinutes { get; set; }

        [Parameter(Mandatory = false)]
        public string? MethodUsabilityReason { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TemporaryAccessPass { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TemporaryAccessPassAuthenticationMethod();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsUsable)))
        body.IsUsable = IsUsable;

    if (this.IsParameterBound(nameof(IsUsableOnce)))
        body.IsUsableOnce = IsUsableOnce;

    if (this.IsParameterBound(nameof(LifetimeInMinutes)))
        body.LifetimeInMinutes = LifetimeInMinutes;

    if (this.IsParameterBound(nameof(MethodUsabilityReason)))
        body.MethodUsabilityReason = MethodUsabilityReason;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(TemporaryAccessPass)))
        body.TemporaryAccessPass = TemporaryAccessPass;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TemporaryAccessPassAuthenticationMethod? result;
            try
            {
                result = client.Users[UserId].Authentication.TemporaryAccessPassMethods.PostAsync(body, requestConfiguration =>
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
