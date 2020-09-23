---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgaccessreview
schema: 2.0.0
---

# New-MgAccessReview

## SYNOPSIS
Add new entity to accessReviews

## SYNTAX

### CreateExpanded (Default)
```
New-MgAccessReview [-AdditionalProperties <Hashtable>] [-BusinessFlowTemplateId <String>]
 [-CreatedBy <IMicrosoftGraphUserIdentity>] [-Decisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-Description <String>] [-DisplayName <String>] [-EndDateTime <DateTime>] [-Id <String>]
 [-Instances <IMicrosoftGraphAccessReview[]>] [-MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-ReviewedEntity <IMicrosoftGraphIdentity>] [-Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]
 [-ReviewerType <String>] [-Settings <IMicrosoftGraphAccessReviewSettings>] [-StartDateTime <DateTime>]
 [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAccessReview -BodyParameter <IMicrosoftGraphAccessReview> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to accessReviews

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

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

### -BodyParameter
accessReview
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessFlowTemplateId
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

### -CreatedBy
userIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserIdentity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Decisions
.
To construct, see NOTES section for DECISIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewDecision[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
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

### -DisplayName
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

### -EndDateTime
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

### -Id
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

### -Instances
.
To construct, see NOTES section for INSTANCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MyDecisions
.
To construct, see NOTES section for MYDECISIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewDecision[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewedEntity
identity
To construct, see NOTES section for REVIEWEDENTITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reviewers
.
To construct, see NOTES section for REVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewer[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewerType
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

### -Settings
accessReviewSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
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

### -Status
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAccessReview>: accessReview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[BusinessFlowTemplateId <String>]`: 
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessRecommendation <String>]`: 
    - `[AccessReviewId <String>]`: 
    - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[AppliedDateTime <DateTime?>]`: 
    - `[ApplyResult <String>]`: 
    - `[Justification <String>]`: 
    - `[ReviewResult <String>]`: 
    - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[ReviewedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Instances <IMicrosoftGraphAccessReview[]>]`: 
  - `[MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
  - `[ReviewedEntity <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[ReviewerType <String>]`: 
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[Settings <IMicrosoftGraphAccessReviewSettings>]`: accessReviewSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessRecommendationsEnabled <Boolean?>]`: 
    - `[ActivityDurationInDays <Int32?>]`: 
    - `[AutoApplyReviewResultsEnabled <Boolean?>]`: 
    - `[AutoReviewEnabled <Boolean?>]`: 
    - `[AutoReviewSettings <IMicrosoftGraphAutoReviewSettings>]`: autoReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NotReviewedResult <String>]`: 
    - `[JustificationRequiredOnApproval <Boolean?>]`: 
    - `[MailNotificationsEnabled <Boolean?>]`: 
    - `[RecurrenceSettings <IMicrosoftGraphAccessReviewRecurrenceSettings>]`: accessReviewRecurrenceSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationInDays <Int32?>]`: 
      - `[RecurrenceCount <Int32?>]`: 
      - `[RecurrenceEndType <String>]`: 
      - `[RecurrenceType <String>]`: 
    - `[RemindersEnabled <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Status <String>]`: 

CREATEDBY <IMicrosoftGraphUserIdentity>: userIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

DECISIONS <IMicrosoftGraphAccessReviewDecision[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessRecommendation <String>]`: 
  - `[AccessReviewId <String>]`: 
  - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: 
  - `[ApplyResult <String>]`: 
  - `[Justification <String>]`: 
  - `[ReviewResult <String>]`: 
  - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
  - `[ReviewedDateTime <DateTime?>]`: 

INSTANCES <IMicrosoftGraphAccessReview[]>: .
  - `[Id <String>]`: Read-only.
  - `[BusinessFlowTemplateId <String>]`: 
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessRecommendation <String>]`: 
    - `[AccessReviewId <String>]`: 
    - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[AppliedDateTime <DateTime?>]`: 
    - `[ApplyResult <String>]`: 
    - `[Justification <String>]`: 
    - `[ReviewResult <String>]`: 
    - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[ReviewedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Instances <IMicrosoftGraphAccessReview[]>]`: 
  - `[MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
  - `[ReviewedEntity <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[ReviewerType <String>]`: 
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[Settings <IMicrosoftGraphAccessReviewSettings>]`: accessReviewSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessRecommendationsEnabled <Boolean?>]`: 
    - `[ActivityDurationInDays <Int32?>]`: 
    - `[AutoApplyReviewResultsEnabled <Boolean?>]`: 
    - `[AutoReviewEnabled <Boolean?>]`: 
    - `[AutoReviewSettings <IMicrosoftGraphAutoReviewSettings>]`: autoReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NotReviewedResult <String>]`: 
    - `[JustificationRequiredOnApproval <Boolean?>]`: 
    - `[MailNotificationsEnabled <Boolean?>]`: 
    - `[RecurrenceSettings <IMicrosoftGraphAccessReviewRecurrenceSettings>]`: accessReviewRecurrenceSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationInDays <Int32?>]`: 
      - `[RecurrenceCount <Int32?>]`: 
      - `[RecurrenceEndType <String>]`: 
      - `[RecurrenceType <String>]`: 
    - `[RemindersEnabled <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Status <String>]`: 

MYDECISIONS <IMicrosoftGraphAccessReviewDecision[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessRecommendation <String>]`: 
  - `[AccessReviewId <String>]`: 
  - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: 
  - `[ApplyResult <String>]`: 
  - `[Justification <String>]`: 
  - `[ReviewResult <String>]`: 
  - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
  - `[ReviewedDateTime <DateTime?>]`: 

REVIEWEDENTITY <IMicrosoftGraphIdentity>: identity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.

REVIEWERS <IMicrosoftGraphAccessReviewReviewer[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

SETTINGS <IMicrosoftGraphAccessReviewSettings>: accessReviewSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessRecommendationsEnabled <Boolean?>]`: 
  - `[ActivityDurationInDays <Int32?>]`: 
  - `[AutoApplyReviewResultsEnabled <Boolean?>]`: 
  - `[AutoReviewEnabled <Boolean?>]`: 
  - `[AutoReviewSettings <IMicrosoftGraphAutoReviewSettings>]`: autoReviewSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NotReviewedResult <String>]`: 
  - `[JustificationRequiredOnApproval <Boolean?>]`: 
  - `[MailNotificationsEnabled <Boolean?>]`: 
  - `[RecurrenceSettings <IMicrosoftGraphAccessReviewRecurrenceSettings>]`: accessReviewRecurrenceSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DurationInDays <Int32?>]`: 
    - `[RecurrenceCount <Int32?>]`: 
    - `[RecurrenceEndType <String>]`: 
    - `[RecurrenceType <String>]`: 
  - `[RemindersEnabled <Boolean?>]`: 

## RELATED LINKS

