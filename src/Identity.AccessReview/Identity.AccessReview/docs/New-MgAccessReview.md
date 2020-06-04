---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/new-mgaccessreview
schema: 2.0.0
---

# New-MgAccessReview

## SYNOPSIS
Add new entity to accessReviews

## SYNTAX

### CreateExpanded (Default)
```
New-MgAccessReview [-AutoReviewSettingNotReviewedResult <String>] [-BusinessFlowTemplateId <String>]
 [-CreatedByDisplayName <String>] [-CreatedById <String>] [-CreatedByIPAddress <String>]
 [-CreatedByUserPrincipalName <String>] [-Decisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-Description <String>] [-DisplayName <String>] [-EndDateTime <DateTime>] [-Id <String>]
 [-Instances <IMicrosoftGraphAccessReview[]>] [-MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-RecurrenceSettingDurationInDays <Int32>] [-RecurrenceSettingRecurrenceCount <Int32>]
 [-RecurrenceSettingRecurrenceEndType <String>] [-RecurrenceSettingRecurrenceType <String>]
 [-ReviewedEntityDisplayName <String>] [-ReviewedEntityId <String>]
 [-Reviewers <IMicrosoftGraphAccessReviewReviewer[]>] [-ReviewerType <String>]
 [-SettingAccessRecommendationsEnabled] [-SettingActivityDurationInDays <Int32>]
 [-SettingAutoApplyReviewResultsEnabled] [-SettingAutoReviewEnabled] [-SettingJustificationRequiredOnApproval]
 [-SettingMailNotificationsEnabled] [-SettingRemindersEnabled] [-StartDateTime <DateTime>] [-Status <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
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

### -AutoReviewSettingNotReviewedResult
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -CreatedByDisplayName
The identity's display name.
Note that this may not always be available or up-to-date.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedById
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedByIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedByUserPrincipalName
The userPrincipalName attribute of the user.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -RecurrenceSettingDurationInDays
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
Dynamic: False
```

### -RecurrenceSettingRecurrenceCount
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
Dynamic: False
```

### -RecurrenceSettingRecurrenceEndType
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
Dynamic: False
```

### -RecurrenceSettingRecurrenceType
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
Dynamic: False
```

### -ReviewedEntityDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ReviewedEntityId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -SettingAccessRecommendationsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingActivityDurationInDays
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
Dynamic: False
```

### -SettingAutoApplyReviewResultsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingAutoReviewEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingJustificationRequiredOnApproval
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingMailNotificationsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingRemindersEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphAccessReview>: accessReview
  - `[Id <String>]`: Read-only.
  - `[AutoReviewSettingNotReviewedResult <String>]`: 
  - `[BusinessFlowTemplateId <String>]`: 
  - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[CreatedById <String>]`: Unique identifier for the identity.
  - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessRecommendation <String>]`: 
    - `[AccessReviewId <String>]`: 
    - `[AppliedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
    - `[AppliedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[AppliedById <String>]`: Unique identifier for the identity.
    - `[AppliedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[AppliedDateTime <DateTime?>]`: 
    - `[ApplyResult <String>]`: 
    - `[Justification <String>]`: 
    - `[ReviewResult <String>]`: 
    - `[ReviewedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
    - `[ReviewedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[ReviewedById <String>]`: Unique identifier for the identity.
    - `[ReviewedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[ReviewedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Instances <IMicrosoftGraphAccessReview[]>]`: 
  - `[MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
  - `[RecurrenceSettingDurationInDays <Int32?>]`: 
  - `[RecurrenceSettingRecurrenceCount <Int32?>]`: 
  - `[RecurrenceSettingRecurrenceEndType <String>]`: 
  - `[RecurrenceSettingRecurrenceType <String>]`: 
  - `[ReviewedEntityDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ReviewedEntityId <String>]`: Unique identifier for the identity.
  - `[ReviewerType <String>]`: 
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[SettingAccessRecommendationsEnabled <Boolean?>]`: 
  - `[SettingActivityDurationInDays <Int32?>]`: 
  - `[SettingAutoApplyReviewResultsEnabled <Boolean?>]`: 
  - `[SettingAutoReviewEnabled <Boolean?>]`: 
  - `[SettingJustificationRequiredOnApproval <Boolean?>]`: 
  - `[SettingMailNotificationsEnabled <Boolean?>]`: 
  - `[SettingRemindersEnabled <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Status <String>]`: 

#### DECISIONS <IMicrosoftGraphAccessReviewDecision[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessRecommendation <String>]`: 
  - `[AccessReviewId <String>]`: 
  - `[AppliedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[AppliedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[AppliedById <String>]`: Unique identifier for the identity.
  - `[AppliedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: 
  - `[ApplyResult <String>]`: 
  - `[Justification <String>]`: 
  - `[ReviewResult <String>]`: 
  - `[ReviewedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[ReviewedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[ReviewedById <String>]`: Unique identifier for the identity.
  - `[ReviewedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[ReviewedDateTime <DateTime?>]`: 

#### INSTANCES <IMicrosoftGraphAccessReview[]>: .
  - `[Id <String>]`: Read-only.
  - `[AutoReviewSettingNotReviewedResult <String>]`: 
  - `[BusinessFlowTemplateId <String>]`: 
  - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[CreatedById <String>]`: Unique identifier for the identity.
  - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessRecommendation <String>]`: 
    - `[AccessReviewId <String>]`: 
    - `[AppliedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
    - `[AppliedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[AppliedById <String>]`: Unique identifier for the identity.
    - `[AppliedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[AppliedDateTime <DateTime?>]`: 
    - `[ApplyResult <String>]`: 
    - `[Justification <String>]`: 
    - `[ReviewResult <String>]`: 
    - `[ReviewedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
    - `[ReviewedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[ReviewedById <String>]`: Unique identifier for the identity.
    - `[ReviewedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[ReviewedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Instances <IMicrosoftGraphAccessReview[]>]`: 
  - `[MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]`: 
  - `[RecurrenceSettingDurationInDays <Int32?>]`: 
  - `[RecurrenceSettingRecurrenceCount <Int32?>]`: 
  - `[RecurrenceSettingRecurrenceEndType <String>]`: 
  - `[RecurrenceSettingRecurrenceType <String>]`: 
  - `[ReviewedEntityDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ReviewedEntityId <String>]`: Unique identifier for the identity.
  - `[ReviewerType <String>]`: 
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[SettingAccessRecommendationsEnabled <Boolean?>]`: 
  - `[SettingActivityDurationInDays <Int32?>]`: 
  - `[SettingAutoApplyReviewResultsEnabled <Boolean?>]`: 
  - `[SettingAutoReviewEnabled <Boolean?>]`: 
  - `[SettingJustificationRequiredOnApproval <Boolean?>]`: 
  - `[SettingMailNotificationsEnabled <Boolean?>]`: 
  - `[SettingRemindersEnabled <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Status <String>]`: 

#### MYDECISIONS <IMicrosoftGraphAccessReviewDecision[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessRecommendation <String>]`: 
  - `[AccessReviewId <String>]`: 
  - `[AppliedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[AppliedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[AppliedById <String>]`: Unique identifier for the identity.
  - `[AppliedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: 
  - `[ApplyResult <String>]`: 
  - `[Justification <String>]`: 
  - `[ReviewResult <String>]`: 
  - `[ReviewedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[ReviewedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[ReviewedById <String>]`: Unique identifier for the identity.
  - `[ReviewedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[ReviewedDateTime <DateTime?>]`: 

#### REVIEWERS <IMicrosoftGraphAccessReviewReviewer[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

## RELATED LINKS

