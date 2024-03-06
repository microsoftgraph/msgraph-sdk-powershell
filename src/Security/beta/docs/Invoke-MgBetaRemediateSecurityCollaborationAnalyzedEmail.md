---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/invoke-mgbetaremediatesecuritycollaborationanalyzedemail
schema: 2.0.0
---

# Invoke-MgBetaRemediateSecurityCollaborationAnalyzedEmail

## SYNOPSIS
Invoke action remediate

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
Invoke action remediate

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
  - `[AlertIds <String[]>]`: 
  - `[Attachments <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>]`: 
    - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AnalysisDateTime <DateTime?>]`: 
      - `[DetonationChain <IMicrosoftGraphSecurityDetonationChain>]`: detonationChain
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ChildNodes <IMicrosoftGraphSecurityDetonationChain[]>]`: 
        - `[Value <String>]`: 
      - `[DetonationObservables <IMicrosoftGraphSecurityDetonationObservables>]`: detonationObservables
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ContactedIps <String[]>]`: 
        - `[ContactedUrls <String[]>]`: 
        - `[Droppedfiles <String[]>]`: 
      - `[DetonationVerdict <String>]`: 
      - `[DetonationVerdictReason <String>]`: 
    - `[FileName <String>]`: 
    - `[FileType <String>]`: 
    - `[Sha256 <String>]`: 
    - `[ThreatName <String>]`: 
    - `[ThreatType <String>]`: threatType
  - `[AttachmentsCount <Int32?>]`: 
  - `[AuthenticationDetails <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>]`: analyzedEmailAuthenticationDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompositeAuthentication <String>]`: 
    - `[Dkim <String>]`: 
    - `[Dmarc <String>]`: 
    - `[SenderPolicyFramework <String>]`: 
  - `[BulkComplaintLevel <String>]`: 
  - `[Contexts <String[]>]`: 
  - `[DetectionMethods <String[]>]`: 
  - `[Directionality <String>]`: antispamDirectionality
  - `[DistributionList <String>]`: 
  - `[EmailClusterId <String>]`: 
  - `[ExchangeTransportRules <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>]`: 
    - `[Name <String>]`: 
    - `[RuleId <String>]`: 
  - `[InternetMessageId <String>]`: 
  - `[Language <String>]`: 
  - `[LatestDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: deliveryAction
    - `[Location <String>]`: deliveryLocation
  - `[LoggedDateTime <DateTime?>]`: 
  - `[NetworkMessageId <String>]`: 
  - `[OriginalDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
  - `[OverrideSources <String[]>]`: 
  - `[PhishConfidenceLevel <String>]`: 
  - `[Policy <String>]`: 
  - `[PolicyAction <String>]`: 
  - `[RecipientEmailAddresses <String[]>]`: 
  - `[ReturnPath <String>]`: 
  - `[SenderDetail <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>]`: analyzedEmailSenderDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FromAddress <String>]`: 
    - `[Ipv4 <String>]`: 
    - `[MailFromAddress <String>]`: 
  - `[SizeInBytes <Int32?>]`: 
  - `[SpamConfidenceLevel <String>]`: 
  - `[Subject <String>]`: 
  - `[ThreatType <String>]`: threatType
  - `[Urls <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>]`: 
    - `[DetectionMethod <String>]`: 
    - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
    - `[ThreatType <String>]`: threatType
    - `[Url <String>]`: 
  - `[UrlsCount <Int32?>]`: 

`BODY <IPaths12L9AgpSecurityCollaborationAnalyzedemailsMicrosoftGraphSecurityRemediatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: remediationAction
  - `[AnalyzedEmails <IMicrosoftGraphSecurityAnalyzedEmail[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertIds <String[]>]`: 
    - `[Attachments <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>]`: 
      - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AnalysisDateTime <DateTime?>]`: 
        - `[DetonationChain <IMicrosoftGraphSecurityDetonationChain>]`: detonationChain
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChildNodes <IMicrosoftGraphSecurityDetonationChain[]>]`: 
          - `[Value <String>]`: 
        - `[DetonationObservables <IMicrosoftGraphSecurityDetonationObservables>]`: detonationObservables
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ContactedIps <String[]>]`: 
          - `[ContactedUrls <String[]>]`: 
          - `[Droppedfiles <String[]>]`: 
        - `[DetonationVerdict <String>]`: 
        - `[DetonationVerdictReason <String>]`: 
      - `[FileName <String>]`: 
      - `[FileType <String>]`: 
      - `[Sha256 <String>]`: 
      - `[ThreatName <String>]`: 
      - `[ThreatType <String>]`: threatType
    - `[AttachmentsCount <Int32?>]`: 
    - `[AuthenticationDetails <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>]`: analyzedEmailAuthenticationDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompositeAuthentication <String>]`: 
      - `[Dkim <String>]`: 
      - `[Dmarc <String>]`: 
      - `[SenderPolicyFramework <String>]`: 
    - `[BulkComplaintLevel <String>]`: 
    - `[Contexts <String[]>]`: 
    - `[DetectionMethods <String[]>]`: 
    - `[Directionality <String>]`: antispamDirectionality
    - `[DistributionList <String>]`: 
    - `[EmailClusterId <String>]`: 
    - `[ExchangeTransportRules <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>]`: 
      - `[Name <String>]`: 
      - `[RuleId <String>]`: 
    - `[InternetMessageId <String>]`: 
    - `[Language <String>]`: 
    - `[LatestDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: deliveryAction
      - `[Location <String>]`: deliveryLocation
    - `[LoggedDateTime <DateTime?>]`: 
    - `[NetworkMessageId <String>]`: 
    - `[OriginalDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]`: analyzedEmailDeliveryDetail
    - `[OverrideSources <String[]>]`: 
    - `[PhishConfidenceLevel <String>]`: 
    - `[Policy <String>]`: 
    - `[PolicyAction <String>]`: 
    - `[RecipientEmailAddresses <String[]>]`: 
    - `[ReturnPath <String>]`: 
    - `[SenderDetail <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>]`: analyzedEmailSenderDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[FromAddress <String>]`: 
      - `[Ipv4 <String>]`: 
      - `[MailFromAddress <String>]`: 
    - `[SizeInBytes <Int32?>]`: 
    - `[SpamConfidenceLevel <String>]`: 
    - `[Subject <String>]`: 
    - `[ThreatType <String>]`: threatType
    - `[Urls <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>]`: 
      - `[DetectionMethod <String>]`: 
      - `[DetonationDetails <IMicrosoftGraphSecurityDetonationDetails>]`: detonationDetails
      - `[ThreatType <String>]`: threatType
      - `[Url <String>]`: 
    - `[UrlsCount <Int32?>]`: 
  - `[ApproverUpn <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[RemediateSendersCopy <Boolean?>]`: 
  - `[Severity <String>]`: remediationSeverity

## RELATED LINKS

