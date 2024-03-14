---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecuritycollaborationanalyzedemail
schema: 2.0.0
---

# New-MgBetaSecurityCollaborationAnalyzedEmail

## SYNOPSIS
Create new navigation property to analyzedEmails for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityCollaborationAnalyzedEmail [-AdditionalProperties <Hashtable>] [-AlertIds <String[]>]
 [-Attachments <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>] [-AttachmentsCount <Int32>]
 [-AuthenticationDetails <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>]
 [-BulkComplaintLevel <String>] [-Contexts <String[]>] [-DetectionMethods <String[]>]
 [-Directionality <String>] [-DistributionList <String>] [-EmailClusterId <String>]
 [-ExchangeTransportRules <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>] [-Id <String>]
 [-InternetMessageId <String>] [-Language <String>]
 [-LatestDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>] [-LoggedDateTime <DateTime>]
 [-NetworkMessageId <String>] [-OriginalDelivery <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>]
 [-OverrideSources <String[]>] [-PhishConfidenceLevel <String>] [-Policy <String>] [-PolicyAction <String>]
 [-RecipientEmailAddresses <String[]>] [-ResponseHeadersVariable <String>] [-ReturnPath <String>]
 [-SenderDetail <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>] [-SizeInBytes <Int32>]
 [-SpamConfidenceLevel <String>] [-Subject <String>] [-ThreatType <String>]
 [-Urls <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>] [-UrlsCount <Int32>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityCollaborationAnalyzedEmail -BodyParameter <IMicrosoftGraphSecurityAnalyzedEmail>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to analyzedEmails for security

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertIds
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attachments
.
To construct, see NOTES section for ATTACHMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailAttachment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttachmentsCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationDetails
analyzedEmailAuthenticationDetail
To construct, see NOTES section for AUTHENTICATIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
analyzedEmail
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmail
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BulkComplaintLevel
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Contexts
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DetectionMethods
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Directionality
antispamDirectionality

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DistributionList
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailClusterId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeTransportRules
.
To construct, see NOTES section for EXCHANGETRANSPORTRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InternetMessageId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Language
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LatestDelivery
analyzedEmailDeliveryDetail
To construct, see NOTES section for LATESTDELIVERY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoggedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkMessageId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OriginalDelivery
analyzedEmailDeliveryDetail
To construct, see NOTES section for ORIGINALDELIVERY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OverrideSources
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhishConfidenceLevel
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Policy
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyAction
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecipientEmailAddresses
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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

### -ReturnPath
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SenderDetail
analyzedEmailSenderDetail
To construct, see NOTES section for SENDERDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailSenderDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SizeInBytes
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpamConfidenceLevel
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThreatType
threatType

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Urls
.
To construct, see NOTES section for URLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmailUrl[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UrlsCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmail

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAnalyzedEmail

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ATTACHMENTS <IMicrosoftGraphSecurityAnalyzedEmailAttachment[]>`: .
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

`AUTHENTICATIONDETAILS <IMicrosoftGraphSecurityAnalyzedEmailAuthenticationDetail>`: analyzedEmailAuthenticationDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CompositeAuthentication <String>]`: 
  - `[Dkim <String>]`: 
  - `[Dmarc <String>]`: 
  - `[SenderPolicyFramework <String>]`: 

`BODYPARAMETER <IMicrosoftGraphSecurityAnalyzedEmail>`: analyzedEmail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

`EXCHANGETRANSPORTRULES <IMicrosoftGraphSecurityAnalyzedEmailExchangeTransportRuleInfo[]>`: .
  - `[Name <String>]`: 
  - `[RuleId <String>]`: 

`LATESTDELIVERY <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>`: analyzedEmailDeliveryDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: deliveryAction
  - `[Location <String>]`: deliveryLocation

`ORIGINALDELIVERY <IMicrosoftGraphSecurityAnalyzedEmailDeliveryDetail>`: analyzedEmailDeliveryDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: deliveryAction
  - `[Location <String>]`: deliveryLocation

`SENDERDETAIL <IMicrosoftGraphSecurityAnalyzedEmailSenderDetail>`: analyzedEmailSenderDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FromAddress <String>]`: 
  - `[Ipv4 <String>]`: 
  - `[MailFromAddress <String>]`: 

`URLS <IMicrosoftGraphSecurityAnalyzedEmailUrl[]>`: .
  - `[DetectionMethod <String>]`: 
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
  - `[ThreatType <String>]`: threatType
  - `[Url <String>]`: 

## RELATED LINKS

