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
    [GraphRoute("POST", "/users/{user-id}/messages")]
    [Cmdlet(VerbsCommon.New, "MgUserMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.Message))]
    public class NewMgUserMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeKey { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? BodyPreview { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConversationId { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? ConversationIndex { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasAttachments { get; set; }

        [Parameter(Mandatory = false)]
        public string? InternetMessageId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeliveryReceiptRequested { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDraft { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRead { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReadReceiptRequested { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentFolderId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReceivedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SentDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebLink { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient[]? BccRecipients { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.ItemBody? Body { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient[]? CcRecipients { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.FollowupFlag? Flag { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient? From { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Importance? Importance { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.InferenceClassificationType? InferenceClassification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.InternetMessageHeader[]? InternetMessageHeaders { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient[]? ReplyTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient? Sender { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient[]? ToRecipients { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.ItemBody? UniqueBody { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Mail.Client.Models.Message();

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(ChangeKey)))
        body.ChangeKey = ChangeKey;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(BodyPreview)))
        body.BodyPreview = BodyPreview;

    if (this.IsParameterBound(nameof(ConversationId)))
        body.ConversationId = ConversationId;

    if (this.IsParameterBound(nameof(ConversationIndex)))
        body.ConversationIndex = ConversationIndex;

    if (this.IsParameterBound(nameof(HasAttachments)))
        body.HasAttachments = HasAttachments;

    if (this.IsParameterBound(nameof(InternetMessageId)))
        body.InternetMessageId = InternetMessageId;

    if (this.IsParameterBound(nameof(IsDeliveryReceiptRequested)))
        body.IsDeliveryReceiptRequested = IsDeliveryReceiptRequested;

    if (this.IsParameterBound(nameof(IsDraft)))
        body.IsDraft = IsDraft;

    if (this.IsParameterBound(nameof(IsRead)))
        body.IsRead = IsRead;

    if (this.IsParameterBound(nameof(IsReadReceiptRequested)))
        body.IsReadReceiptRequested = IsReadReceiptRequested;

    if (this.IsParameterBound(nameof(ParentFolderId)))
        body.ParentFolderId = ParentFolderId;

    if (this.IsParameterBound(nameof(ReceivedDateTime)))
        body.ReceivedDateTime = ReceivedDateTime;

    if (this.IsParameterBound(nameof(SentDateTime)))
        body.SentDateTime = SentDateTime;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(WebLink)))
        body.WebLink = WebLink;

    if (this.IsParameterBound(nameof(BccRecipients)))
        body.BccRecipients = BccRecipients!.ToList();

    if (this.IsParameterBound(nameof(Body)))
        body.Body = Body;

    if (this.IsParameterBound(nameof(CcRecipients)))
        body.CcRecipients = CcRecipients!.ToList();

    if (this.IsParameterBound(nameof(Flag)))
        body.Flag = Flag;

    if (this.IsParameterBound(nameof(From)))
        body.From = From;

    if (this.IsParameterBound(nameof(Importance)))
        body.Importance = Importance;

    if (this.IsParameterBound(nameof(InferenceClassification)))
        body.InferenceClassification = InferenceClassification;

    if (this.IsParameterBound(nameof(InternetMessageHeaders)))
        body.InternetMessageHeaders = InternetMessageHeaders!.ToList();

    if (this.IsParameterBound(nameof(ReplyTo)))
        body.ReplyTo = ReplyTo!.ToList();

    if (this.IsParameterBound(nameof(Sender)))
        body.Sender = Sender;

    if (this.IsParameterBound(nameof(ToRecipients)))
        body.ToRecipients = ToRecipients!.ToList();

    if (this.IsParameterBound(nameof(UniqueBody)))
        body.UniqueBody = UniqueBody;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.Message? result;
            try
            {
                result = client.Users[UserId].Messages.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
