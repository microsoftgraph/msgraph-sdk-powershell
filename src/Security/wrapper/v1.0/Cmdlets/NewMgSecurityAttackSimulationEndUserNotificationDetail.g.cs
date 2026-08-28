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
    [GraphRoute("POST", "/security/attackSimulation/endUserNotifications/{endUserNotification-id}/details")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAttackSimulationEndUserNotificationDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.EndUserNotificationDetail))]
    public class NewMgSecurityAttackSimulationEndUserNotificationDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EndUserNotificationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EmailContent { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefaultLangauge { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EmailIdentity? SentFrom { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EndUserNotificationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.EndUserNotificationDetail();

    if (this.IsParameterBound(nameof(EmailContent)))
        body.EmailContent = EmailContent;

    if (this.IsParameterBound(nameof(IsDefaultLangauge)))
        body.IsDefaultLangauge = IsDefaultLangauge;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(SentFrom)))
        body.SentFrom = SentFrom;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.EndUserNotificationDetail? result;
            try
            {
                result = client.Security.AttackSimulation.EndUserNotifications[EndUserNotificationId].Details.PostAsync(body, requestConfiguration =>
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
