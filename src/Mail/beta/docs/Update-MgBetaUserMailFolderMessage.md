---
external help file:
Module Name: Microsoft.Graph.Beta.Mail
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.mail/update-mgbetausermailfoldermessage
schema: 2.0.0
---

# Update-MgBetaUserMailFolderMessage

## SYNOPSIS
Update the navigation property messages in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserMailFolderMessage -MailFolderId <String> -MessageId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Attachments <IMicrosoftGraphAttachment[]>]
 [-BccRecipients <IMicrosoftGraphRecipient[]>] [-Body <IMicrosoftGraphItemBody>] [-BodyPreview <String>]
 [-Categories <String[]>] [-CcRecipients <IMicrosoftGraphRecipient[]>] [-ChangeKey <String>]
 [-ConversationId <String>] [-ConversationIndexInputFile <String>] [-CreatedDateTime <DateTime>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Flag <IMicrosoftGraphFollowupFlag>]
 [-From <IMicrosoftGraphRecipient>] [-HasAttachments] [-Id <String>] [-Importance <String>]
 [-InferenceClassification <String>] [-InternetMessageHeaders <IMicrosoftGraphInternetMessageHeader[]>]
 [-InternetMessageId <String>] [-IsDeliveryReceiptRequested] [-IsDraft] [-IsRead] [-IsReadReceiptRequested]
 [-LastModifiedDateTime <DateTime>] [-Mentions <IMicrosoftGraphMention[]>]
 [-MentionsPreview <IMicrosoftGraphMentionsPreview>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>] [-ReceivedDateTime <DateTime>] [-ReplyTo <IMicrosoftGraphRecipient[]>]
 [-ResponseHeadersVariable <String>] [-Sender <IMicrosoftGraphRecipient>] [-SentDateTime <DateTime>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Subject <String>]
 [-ToRecipients <IMicrosoftGraphRecipient[]>] [-UniqueBody <IMicrosoftGraphItemBody>]
 [-UnsubscribeData <String[]>] [-UnsubscribeEnabled] [-WebLink <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaUserMailFolderMessage -MailFolderId <String> -MessageId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphMessage> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserMailFolderMessage -InputObject <IMailIdentity> -BodyParameter <IMicrosoftGraphMessage>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserMailFolderMessage -InputObject <IMailIdentity> [-AdditionalProperties <Hashtable>]
 [-Attachments <IMicrosoftGraphAttachment[]>] [-BccRecipients <IMicrosoftGraphRecipient[]>]
 [-Body <IMicrosoftGraphItemBody>] [-BodyPreview <String>] [-Categories <String[]>]
 [-CcRecipients <IMicrosoftGraphRecipient[]>] [-ChangeKey <String>] [-ConversationId <String>]
 [-ConversationIndexInputFile <String>] [-CreatedDateTime <DateTime>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Flag <IMicrosoftGraphFollowupFlag>]
 [-From <IMicrosoftGraphRecipient>] [-HasAttachments] [-Id <String>] [-Importance <String>]
 [-InferenceClassification <String>] [-InternetMessageHeaders <IMicrosoftGraphInternetMessageHeader[]>]
 [-InternetMessageId <String>] [-IsDeliveryReceiptRequested] [-IsDraft] [-IsRead] [-IsReadReceiptRequested]
 [-LastModifiedDateTime <DateTime>] [-Mentions <IMicrosoftGraphMention[]>]
 [-MentionsPreview <IMicrosoftGraphMentionsPreview>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>] [-ReceivedDateTime <DateTime>] [-ReplyTo <IMicrosoftGraphRecipient[]>]
 [-ResponseHeadersVariable <String>] [-Sender <IMicrosoftGraphRecipient>] [-SentDateTime <DateTime>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-Subject <String>]
 [-ToRecipients <IMicrosoftGraphRecipient[]>] [-UniqueBody <IMicrosoftGraphItemBody>]
 [-UnsubscribeData <String[]>] [-UnsubscribeEnabled] [-WebLink <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property messages in users

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attachments
The fileAttachment and itemAttachment attachments for the message.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAttachment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BccRecipients
The Bcc: recipients for the message.
To construct, see NOTES section for BCCRECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
itemBody
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
message
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMessage
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BodyPreview
The first 255 characters of the message body.
It is in text format.
If the message contains instances of mention, this property would contain a concatenation of these mentions as well.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Categories
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CcRecipients
The Cc: recipients for the message.
To construct, see NOTES section for CCRECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChangeKey
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationId
The ID of the conversation the email belongs to.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConversationIndexInputFile
Input File for ConversationIndex (Indicates the position of the message within the conversation.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the message.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Flag
followupFlag
To construct, see NOTES section for FLAG properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFollowupFlag
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -From
recipient
To construct, see NOTES section for FROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasAttachments
Indicates whether the message has attachments.
This property doesn't include inline attachments, so if a message contains only inline attachments, this property is false.
To verify the existence of inline attachments, parse the body property to look for a src attribute, such as \<IMG src='cid:image001.jpg@01D26CD8.6C05F070'\>.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Importance
importance

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InferenceClassification
inferenceClassificationType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMailIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InternetMessageHeaders
A collection of message headers defined by RFC5322.
The set includes message headers indicating the network path taken by a message from the sender to the recipient.
It can also contain custom message headers that hold app data for the message.
Returned only on applying a $select query option.
Read-only.
To construct, see NOTES section for INTERNETMESSAGEHEADERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInternetMessageHeader[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InternetMessageId
The message ID in the format specified by RFC5322.
Updatable only if isDraft is true.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDeliveryReceiptRequested
Indicates whether a read receipt is requested for the message.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDraft
Indicates whether the message is a draft.
A message is a draft if it hasn't been sent yet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRead
Indicates whether the message has been read.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsReadReceiptRequested
Indicates whether a read receipt is requested for the message.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailFolderId
The unique identifier of mailFolder

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mentions
A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest.
By default, a GET /messages does not return this property unless you apply $expand on the property.
To construct, see NOTES section for MENTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMention[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MentionsPreview
mentionsPreview
To construct, see NOTES section for MENTIONSPREVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMentionsPreview
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MessageId
The unique identifier of message

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the message.
Nullable.
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentFolderId
The unique identifier for the message's parent mailFolder.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReceivedDateTime
The date and time the message was received.
The date and time information uses ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplyTo
The email addresses to use when replying.
To construct, see NOTES section for REPLYTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sender
recipient
To construct, see NOTES section for SENDER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SentDateTime
The date and time the message was sent.
The date and time information uses ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the message.
Nullable.
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the message.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToRecipients
The To: recipients for the message.
To construct, see NOTES section for TORECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UniqueBody
itemBody
To construct, see NOTES section for UNIQUEBODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnsubscribeData
The valid entries parsed from the List-Unsubscribe header.
This is the data for the mail command in the List-Unsubscribe header if UnsubscribeEnabled property is true.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnsubscribeEnabled
Indicates whether the message is enabled for unsubscribe.
Its valueTrue if the list-Unsubscribe header conforms to rfc-2369.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebLink
The URL to open the message in Outlook on the web.You can append an ispopout argument to the end of the URL to change how the message is displayed.
If ispopout is not present or if it is set to 1, then the message is shown in a popout window.
If ispopout is set to 0, the browser shows the message in the Outlook on the web review pane.The message opens in the browser if you are signed in to your mailbox via Outlook on the web.
You are prompted to sign in if you are not already signed in with the browser.This URL cannot be accessed from within an iFrame.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMailIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMessage

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMessage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ATTACHMENTS <IMicrosoftGraphAttachment[]>`: The fileAttachment and itemAttachment attachments for the message.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ContentType <String>]`: The MIME type.
  - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
  - `[Size <Int32?>]`: The length of the attachment in bytes.

`BCCRECIPIENTS <IMicrosoftGraphRecipient[]>`: The Bcc: recipients for the message.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`BODY <IMicrosoftGraphItemBody>`: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

`BODYPARAMETER <IMicrosoftGraphMessage>`: message
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <String[]>]`: 
  - `[ChangeKey <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Attachments <IMicrosoftGraphAttachment[]>]`: The fileAttachment and itemAttachment attachments for the message.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentType <String>]`: The MIME type.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Name <String>]`: The display name of the attachment. This does not need to be the actual file name.
    - `[Size <Int32?>]`: The length of the attachment in bytes.
  - `[BccRecipients <IMicrosoftGraphRecipient[]>]`: The Bcc: recipients for the message.
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.
  - `[Body <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[BodyPreview <String>]`: The first 255 characters of the message body. It is in text format. If the message contains instances of mention, this property would contain a concatenation of these mentions as well.
  - `[CcRecipients <IMicrosoftGraphRecipient[]>]`: The Cc: recipients for the message.
  - `[ConversationId <String>]`: The ID of the conversation the email belongs to.
  - `[ConversationIndex <Byte[]>]`: Indicates the position of the message within the conversation.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the message. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Flag <IMicrosoftGraphFollowupFlag>]`: followupFlag
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[FlagStatus <String>]`: followupFlagStatus
    - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[From <IMicrosoftGraphRecipient>]`: recipient
  - `[HasAttachments <Boolean?>]`: Indicates whether the message has attachments. This property doesn't include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as <IMG src='cid:image001.jpg@01D26CD8.6C05F070'>.
  - `[Importance <String>]`: importance
  - `[InferenceClassification <String>]`: inferenceClassificationType
  - `[InternetMessageHeaders <IMicrosoftGraphInternetMessageHeader[]>]`: A collection of message headers defined by RFC5322. The set includes message headers indicating the network path taken by a message from the sender to the recipient. It can also contain custom message headers that hold app data for the message.  Returned only on applying a $select query option. Read-only.
    - `[Name <String>]`: Represents the key in a key-value pair.
    - `[Value <String>]`: The value in a key-value pair.
  - `[InternetMessageId <String>]`: The message ID in the format specified by RFC5322. Updatable only if isDraft is true.
  - `[IsDeliveryReceiptRequested <Boolean?>]`: Indicates whether a read receipt is requested for the message.
  - `[IsDraft <Boolean?>]`: Indicates whether the message is a draft. A message is a draft if it hasn't been sent yet.
  - `[IsRead <Boolean?>]`: Indicates whether the message has been read.
  - `[IsReadReceiptRequested <Boolean?>]`: Indicates whether a read receipt is requested for the message.
  - `[Mentions <IMicrosoftGraphMention[]>]`: A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest. By default, a GET /messages does not return this property unless you apply $expand on the property.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Application <String>]`: The name of the application where the mention is created. Optional. Not used and defaulted as null for message.
    - `[ClientReference <String>]`: A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.
    - `[CreatedBy <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[CreatedDateTime <DateTime?>]`: The date and time that the mention is created on the client.
    - `[DeepLink <String>]`: A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.
    - `[MentionText <String>]`: Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.
    - `[Mentioned <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[ServerCreatedDateTime <DateTime?>]`: The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.
  - `[MentionsPreview <IMicrosoftGraphMentionsPreview>]`: mentionsPreview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsMentioned <Boolean?>]`: True if the signed-in user is mentioned in the parent resource instance. Read-only. Supports filter.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the message. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[ParentFolderId <String>]`: The unique identifier for the message's parent mailFolder.
  - `[ReceivedDateTime <DateTime?>]`: The date and time the message was received.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ReplyTo <IMicrosoftGraphRecipient[]>]`: The email addresses to use when replying.
  - `[Sender <IMicrosoftGraphRecipient>]`: recipient
  - `[SentDateTime <DateTime?>]`: The date and time the message was sent.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the message. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Value <String>]`: A property value.
  - `[Subject <String>]`: The subject of the message.
  - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: The To: recipients for the message.
  - `[UniqueBody <IMicrosoftGraphItemBody>]`: itemBody
  - `[UnsubscribeData <String[]>]`: The valid entries parsed from the List-Unsubscribe header.  This is the data for the mail command in the List-Unsubscribe header if UnsubscribeEnabled property is true.
  - `[UnsubscribeEnabled <Boolean?>]`: Indicates whether the message is enabled for unsubscribe.  Its valueTrue if the list-Unsubscribe header conforms to rfc-2369.
  - `[WebLink <String>]`: The URL to open the message in Outlook on the web.You can append an ispopout argument to the end of the URL to change how the message is displayed. If ispopout is not present or if it is set to 1, then the message is shown in a popout window. If ispopout is set to 0, the browser shows the message in the Outlook on the web review pane.The message opens in the browser if you are signed in to your mailbox via Outlook on the web. You are prompted to sign in if you are not already signed in with the browser.This URL cannot be accessed from within an iFrame.

`CCRECIPIENTS <IMicrosoftGraphRecipient[]>`: The Cc: recipients for the message.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`EXTENSIONS <IMicrosoftGraphExtension[]>`: The collection of open extensions defined for the message. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`FLAG <IMicrosoftGraphFollowupFlag>`: followupFlag
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[FlagStatus <String>]`: followupFlagStatus
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

`FROM <IMicrosoftGraphRecipient>`: recipient
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`INPUTOBJECT <IMailIdentity>`: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[InferenceClassificationOverrideId <String>]`: The unique identifier of inferenceClassificationOverride
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[MentionId <String>]`: The unique identifier of mention
  - `[MessageId <String>]`: The unique identifier of message
  - `[MessageRuleId <String>]`: The unique identifier of messageRule
  - `[UserConfigurationId <String>]`: The unique identifier of userConfiguration
  - `[UserId <String>]`: The unique identifier of user

`INTERNETMESSAGEHEADERS <IMicrosoftGraphInternetMessageHeader[]>`: A collection of message headers defined by RFC5322. The set includes message headers indicating the network path taken by a message from the sender to the recipient. It can also contain custom message headers that hold app data for the message. Returned only on applying a $select query option. Read-only.
  - `[Name <String>]`: Represents the key in a key-value pair.
  - `[Value <String>]`: The value in a key-value pair.

`MENTIONS <IMicrosoftGraphMention[]>`: A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest. By default, a GET /messages does not return this property unless you apply $expand on the property.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Application <String>]`: The name of the application where the mention is created. Optional. Not used and defaulted as null for message.
  - `[ClientReference <String>]`: A unique identifier that represents a parent of the resource instance. Optional. Not used and defaulted as null for message.
  - `[CreatedBy <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.
  - `[CreatedDateTime <DateTime?>]`: The date and time that the mention is created on the client.
  - `[DeepLink <String>]`: A deep web link to the context of the mention in the resource instance. Optional. Not used and defaulted as null for message.
  - `[MentionText <String>]`: Optional. Not used and defaulted as null for message. To get the mentions in a message, see the bodyPreview property of the message instead.
  - `[Mentioned <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[ServerCreatedDateTime <DateTime?>]`: The date and time that the mention is created on the server. Optional. Not used and defaulted as null for message.

`MENTIONSPREVIEW <IMicrosoftGraphMentionsPreview>`: mentionsPreview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsMentioned <Boolean?>]`: True if the signed-in user is mentioned in the parent resource instance. Read-only. Supports filter.

`MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>`: The collection of multi-value extended properties defined for the message. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String[]>]`: A collection of property values.

`REPLYTO <IMicrosoftGraphRecipient[]>`: The email addresses to use when replying.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`SENDER <IMicrosoftGraphRecipient>`: recipient
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>`: The collection of single-value extended properties defined for the message. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Value <String>]`: A property value.

`TORECIPIENTS <IMicrosoftGraphRecipient[]>`: The To: recipients for the message.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

`UNIQUEBODY <IMicrosoftGraphItemBody>`: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

## RELATED LINKS

