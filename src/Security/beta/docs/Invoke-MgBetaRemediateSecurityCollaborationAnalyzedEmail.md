---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/invoke-mgbetaremediatesecuritycollaborationanalyzedemail
schema: 2.0.0
---

# Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail

## SYNOPSIS
Remove a potential threat from end users' mailboxes.
Remediation means to take prescribed action against a threat.
This API can trigger email purge actions like move to junk, move to deleted items, soft delete, hard delete, or move to Inbox.
This API enables scenarios and use cases such as SOAR integration, playbooks, and automations.
For more information read email remediation, trigger action and track actions.
If there is false positives admins can take move to inbox action.

## SYNTAX

### RemediateExpanded (Default)
```
Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail [-Action <String>]
 [-AdditionalProperties <Hashtable>] [-AnalyzedEmails <IMicrosoftGraphSecurityAnalyzedEmail[]>]
 [-ApproverUpn <String>] [-Description <String>] [-DisplayName <String>] [-RemediateSendersCopy]
 [-ResponseHeadersVariable <String>] [-Severity <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Remediate
```
Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail
 -Body <IPaths12L9AgpSecurityCollaborationAnalyzedemailsMicrosoftGraphSecurityRemediatePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Remove a potential threat from end users' mailboxes.
Remediation means to take prescribed action against a threat.
This API can trigger email purge actions like move to junk, move to deleted items, soft delete, hard delete, or move to Inbox.
This API enables scenarios and use cases such as SOAR integration, playbooks, and automations.
For more information read email remediation, trigger action and track actions.
If there is false positives admins can take move to inbox action.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -Action
remediationAction

```yaml
Type: System.String
Parameter Sets: RemediateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RemediateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AnalyzedEmails
.
To construct, see NOTES section for ANALYZEDEMAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmail[]
Parameter Sets: RemediateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApproverUpn
.

```yaml
Type: System.String
Parameter Sets: RemediateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths12L9AgpSecurityCollaborationAnalyzedemailsMicrosoftGraphSecurityRemediatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Remediate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: RemediateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: RemediateExpanded
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

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemediateSendersCopy
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RemediateExpanded
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

### -Severity
remediationSeverity

```yaml
Type: System.String
Parameter Sets: RemediateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths12L9AgpSecurityCollaborationAnalyzedemailsMicrosoftGraphSecurityRemediatePostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ANALYZEDEMAILS <IMicrosoftGraphSecurityAnalyzedEmail[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertIds <String[]>]`: A collection of values that contain the IDs of any alerts associated with the email.
  - `[Attachments <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>]`: A collection of the attachments in the email.
    - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AnalysisDateTime <DateTime?>]`: The time of detonation.
      - `[DetonationChain <IMicrosoftGraphSecurityDetonationChain>]`: detonationChain
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ChildNodes <IMicrosoftGraphSecurityDetonationChain[]>]`: A list of all child nodes in the chain.
        - `[Value <String>]`: The value of the chain.
      - `[DetonationObservables <IMicrosoftGraphSecurityDetonationObservables>]`: detonationObservables
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ContactedIps <String[]>]`: The list of all contacted IPs in the detonation.
        - `[ContactedUrls <String[]>]`: The list of all URLs found in the detonation.
        - `[Droppedfiles <String[]>]`: The list of all dropped files in the detonation.
      - `[DetonationVerdict <String>]`: The verdict of the detonation.
      - `[DetonationVerdictReason <String>]`: The reason for the verdict of the detonation.
    - `[FileName <String>]`: The name of the attachment in the email.
    - `[FileType <String>]`: The type of the attachment in the email.
    - `[Sha256 <String>]`: The SHA256 file hash of the attachment.
    - `[ThreatName <String>]`: The threat name associated with the threat type.
    - `[ThreatType <String>]`: threatType
  - `[AttachmentsCount <Int32?>]`: The number of attachments in the email.
  - `[AuthenticationDetails <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>]`: analyzedEmailAuthenticationDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompositeAuthentication <String>]`: A value used by Microsoft 365 to combine email authentication such as SPF, DKIM, and DMARC, to determine whether the message is authentic.
    - `[Dkim <String>]`: DomainKeys identified mail (DKIM). Indicates whether it was pass/fail/soft fail.
    - `[Dmarc <String>]`: Domain-based Message Authentication. Indicates whether it was pass/fail/soft fail.
    - `[SenderPolicyFramework <String>]`: Sender Policy Framework (SPF). Indicates whether it was pass/fail/soft fail.
  - `[BulkComplaintLevel <String>]`: The bulk complaint level of the email. A higher level is more likely to be spam.
  - `[Contexts <String[]>]`: Provides context of the email.
  - `[DetectionMethods <String[]>]`: The methods of detection used.
  - `[Directionality <String>]`: antispamDirectionality
  - `[DistributionList <String>]`: The distribution list details to which the email was sent.
  - `[EmailClusterId <String>]`: The identifier for the group of similar emails clustered based on heuristic analysis of their content.
  - `[ExchangeTransportRules <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>]`: The name of the Exchange transport rules (ETRs) associated with the email.
    - `[Name <String>]`: Name of the Exchange transport rules (ETRs) that are part of the email.
    - `[RuleId <String>]`: The ETR rule ID.
  - `[InternetMessageId <String>]`: A public-facing identifier for the email that is sent. The message ID is in the format specified by RFC2822.
  - `[Language <String>]`: The detected language of the email content.
  - `[LatestDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: deliveryAction
    - `[Location <String>]`: deliveryLocation
  - `[LoggedDateTime <DateTime?>]`: Date-time when the email record was logged.
  - `[NetworkMessageId <String>]`: An internal identifier for the email generated by Microsoft 365.
  - `[OriginalDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
  - `[OverrideSources <String[]>]`: An aggregated list of all overrides with source on email.
  - `[PhishConfidenceLevel <String>]`: The phish confidence level associated with the email
  - `[Policy <String>]`: The action policy that took effect.
  - `[PolicyAction <String>]`: The action taken on the email based on the configured policy.
  - `[RecipientEmailAddresses <String[]>]`: Contains the email addresses of the recipients.
  - `[ReturnPath <String>]`: A field that indicates where and how bounced emails are processed.
  - `[SenderDetail <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>]`: analyzedEmailSenderDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FromAddress <String>]`: The sender email address in the mail From header, also known as the envelope sender or the P1 sender.
    - `[Ipv4 <String>]`: The IPv4 address of the last detected mail server that relayed the message.
    - `[MailFromAddress <String>]`: The sender email address in the From header, which is visible to email recipients on their email clients. Also known as P2 sender.
  - `[SizeInBytes <Int32?>]`: Size of the email in bytes.
  - `[SpamConfidenceLevel <String>]`: Spam confidence of the email.
  - `[Subject <String>]`: Subject of the email.
  - `[ThreatType <String>]`: threatType
  - `[Urls <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>]`: A collection of the URLs in the email.
    - `[DetectionMethod <String>]`: The method used to detect threats in the URL.
    - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
    - `[ThreatType <String>]`: threatType
    - `[Url <String>]`: The URL that is found in the email. This is full URL string, including query parameters.
  - `[UrlsCount <Int32?>]`: The number of URLs in the email.

`BODY <IPaths12L9AgpSecurityCollaborationAnalyzedemailsMicrosoftGraphSecurityRemediatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: remediationAction
  - `[AnalyzedEmails <IMicrosoftGraphSecurityAnalyzedEmail[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertIds <String[]>]`: A collection of values that contain the IDs of any alerts associated with the email.
    - `[Attachments <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>]`: A collection of the attachments in the email.
      - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AnalysisDateTime <DateTime?>]`: The time of detonation.
        - `[DetonationChain <IMicrosoftGraphSecurityDetonationChain>]`: detonationChain
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChildNodes <IMicrosoftGraphSecurityDetonationChain[]>]`: A list of all child nodes in the chain.
          - `[Value <String>]`: The value of the chain.
        - `[DetonationObservables <IMicrosoftGraphSecurityDetonationObservables>]`: detonationObservables
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ContactedIps <String[]>]`: The list of all contacted IPs in the detonation.
          - `[ContactedUrls <String[]>]`: The list of all URLs found in the detonation.
          - `[Droppedfiles <String[]>]`: The list of all dropped files in the detonation.
        - `[DetonationVerdict <String>]`: The verdict of the detonation.
        - `[DetonationVerdictReason <String>]`: The reason for the verdict of the detonation.
      - `[FileName <String>]`: The name of the attachment in the email.
      - `[FileType <String>]`: The type of the attachment in the email.
      - `[Sha256 <String>]`: The SHA256 file hash of the attachment.
      - `[ThreatName <String>]`: The threat name associated with the threat type.
      - `[ThreatType <String>]`: threatType
    - `[AttachmentsCount <Int32?>]`: The number of attachments in the email.
    - `[AuthenticationDetails <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>]`: analyzedEmailAuthenticationDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompositeAuthentication <String>]`: A value used by Microsoft 365 to combine email authentication such as SPF, DKIM, and DMARC, to determine whether the message is authentic.
      - `[Dkim <String>]`: DomainKeys identified mail (DKIM). Indicates whether it was pass/fail/soft fail.
      - `[Dmarc <String>]`: Domain-based Message Authentication. Indicates whether it was pass/fail/soft fail.
      - `[SenderPolicyFramework <String>]`: Sender Policy Framework (SPF). Indicates whether it was pass/fail/soft fail.
    - `[BulkComplaintLevel <String>]`: The bulk complaint level of the email. A higher level is more likely to be spam.
    - `[Contexts <String[]>]`: Provides context of the email.
    - `[DetectionMethods <String[]>]`: The methods of detection used.
    - `[Directionality <String>]`: antispamDirectionality
    - `[DistributionList <String>]`: The distribution list details to which the email was sent.
    - `[EmailClusterId <String>]`: The identifier for the group of similar emails clustered based on heuristic analysis of their content.
    - `[ExchangeTransportRules <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>]`: The name of the Exchange transport rules (ETRs) associated with the email.
      - `[Name <String>]`: Name of the Exchange transport rules (ETRs) that are part of the email.
      - `[RuleId <String>]`: The ETR rule ID.
    - `[InternetMessageId <String>]`: A public-facing identifier for the email that is sent. The message ID is in the format specified by RFC2822.
    - `[Language <String>]`: The detected language of the email content.
    - `[LatestDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: deliveryAction
      - `[Location <String>]`: deliveryLocation
    - `[LoggedDateTime <DateTime?>]`: Date-time when the email record was logged.
    - `[NetworkMessageId <String>]`: An internal identifier for the email generated by Microsoft 365.
    - `[OriginalDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
    - `[OverrideSources <String[]>]`: An aggregated list of all overrides with source on email.
    - `[PhishConfidenceLevel <String>]`: The phish confidence level associated with the email
    - `[Policy <String>]`: The action policy that took effect.
    - `[PolicyAction <String>]`: The action taken on the email based on the configured policy.
    - `[RecipientEmailAddresses <String[]>]`: Contains the email addresses of the recipients.
    - `[ReturnPath <String>]`: A field that indicates where and how bounced emails are processed.
    - `[SenderDetail <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>]`: analyzedEmailSenderDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[FromAddress <String>]`: The sender email address in the mail From header, also known as the envelope sender or the P1 sender.
      - `[Ipv4 <String>]`: The IPv4 address of the last detected mail server that relayed the message.
      - `[MailFromAddress <String>]`: The sender email address in the From header, which is visible to email recipients on their email clients. Also known as P2 sender.
    - `[SizeInBytes <Int32?>]`: Size of the email in bytes.
    - `[SpamConfidenceLevel <String>]`: Spam confidence of the email.
    - `[Subject <String>]`: Subject of the email.
    - `[ThreatType <String>]`: threatType
    - `[Urls <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>]`: A collection of the URLs in the email.
      - `[DetectionMethod <String>]`: The method used to detect threats in the URL.
      - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
      - `[ThreatType <String>]`: threatType
      - `[Url <String>]`: The URL that is found in the email. This is full URL string, including query parameters.
    - `[UrlsCount <Int32?>]`: The number of URLs in the email.
  - `[ApproverUpn <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[RemediateSendersCopy <Boolean?>]`: 
  - `[Severity <String>]`: remediationSeverity

## RELATED LINKS

