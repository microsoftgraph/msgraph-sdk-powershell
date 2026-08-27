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
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messageRules")]
    [Cmdlet(VerbsCommon.New, "MgUserMailFolderChildFolderMessageRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRule))]
    public class NewMgUserMailFolderChildFolderMessageRuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MailFolderId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasError { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReadOnly { get; set; }

        [Parameter(Mandatory = false)]
        public int? Sequence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRuleActions? Actions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRulePredicates? Conditions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRulePredicates? Exceptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MailFolderId1, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRule();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HasError)))
        body.HasError = HasError;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsReadOnly)))
        body.IsReadOnly = IsReadOnly;

    if (this.IsParameterBound(nameof(Sequence)))
        body.Sequence = Sequence;

    if (this.IsParameterBound(nameof(Actions)))
        body.Actions = Actions;

    if (this.IsParameterBound(nameof(Conditions)))
        body.Conditions = Conditions;

    if (this.IsParameterBound(nameof(Exceptions)))
        body.Exceptions = Exceptions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.MessageRule? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].ChildFolders[MailFolderId1].MessageRules.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
