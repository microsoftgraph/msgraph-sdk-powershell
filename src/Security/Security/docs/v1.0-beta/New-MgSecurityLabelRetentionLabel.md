---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritylabelretentionlabel
schema: 2.0.0
---

# New-MgSecurityLabelRetentionLabel

## SYNOPSIS
Create new navigation property to retentionLabels for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityLabelRetentionLabel [-ActionAfterRetentionPeriod <String>] [-AdditionalProperties <Hashtable>]
 [-BehaviorDuringRetentionPeriod <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DefaultRecordBehavior <String>] [-DescriptionForAdmins <String>]
 [-DescriptionForUsers <String>] [-DisplayName <String>]
 [-DispositionReviewStages <IMicrosoftGraphSecurityDispositionReviewStage[]>] [-Id <String>] [-IsInUse]
 [-LabelToBeApplied <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-RetentionDuration <Hashtable>]
 [-RetentionEventType <IMicrosoftGraphSecurityRetentionEventType>] [-RetentionTrigger <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSecurityLabelRetentionLabel -BodyParameter <IMicrosoftGraphSecurityRetentionLabel> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to retentionLabels for security

## EXAMPLES

## PARAMETERS

### -ActionAfterRetentionPeriod
actionAfterRetentionPeriod

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

### -BehaviorDuringRetentionPeriod
behaviorDuringRetentionPeriod

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

### -BodyParameter
retentionLabel
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityRetentionLabel
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Represents the date and time in which the retentionLabel is created.

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

### -DefaultRecordBehavior
defaultRecordBehavior

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

### -DescriptionForAdmins
Provides label information for the admin.
Optional.

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

### -DescriptionForUsers
Provides the label information for the user.
Optional.

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
Unique string that defines a label name.

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

### -DispositionReviewStages
Review stages during which reviewers are notified to determine whether a document must be deleted or retained.
To construct, please use Get-Help -Online and see NOTES section for DISPOSITIONREVIEWSTAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityDispositionReviewStage[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -IsInUse
Specifies whether the label is currently being used.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelToBeApplied
Specifies the replacement label to be applied automatically after the retention period of the current label ends.

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

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The latest date time when the retentionLabel was modified.

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

### -RetentionDuration
retentionDuration

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

### -RetentionEventType
retentionEventType
To construct, please use Get-Help -Online and see NOTES section for RETENTIONEVENTTYPE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityRetentionEventType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetentionTrigger
retentionTrigger

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityRetentionLabel

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityRetentionLabel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecurityRetentionLabel>: retentionLabel
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActionAfterRetentionPeriod <String>]`: actionAfterRetentionPeriod
  - `[BehaviorDuringRetentionPeriod <String>]`: behaviorDuringRetentionPeriod
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Represents the date and time in which the retentionLabel is created.
  - `[DefaultRecordBehavior <String>]`: defaultRecordBehavior
  - `[DescriptionForAdmins <String>]`: Provides label information for the admin. Optional.
  - `[DescriptionForUsers <String>]`: Provides the label information for the user. Optional.
  - `[DisplayName <String>]`: Unique string that defines a label name.
  - `[DispositionReviewStages <IMicrosoftGraphSecurityDispositionReviewStage[]>]`: Review stages during which reviewers are notified to determine whether a document must be deleted or retained.
    - `[Id <String>]`: 
    - `[Name <String>]`: Name representing each stage within a collection.
    - `[ReviewersEmailAddresses <String[]>]`: A collection of reviewers at each stage.
    - `[StageNumber <Int32?>]`: The sequence number for each stage of the disposition review.
  - `[IsInUse <Boolean?>]`: Specifies whether the label is currently being used.
  - `[LabelToBeApplied <String>]`: Specifies the replacement label to be applied automatically after the retention period of the current label ends.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionLabel was modified.
  - `[RetentionDuration <IMicrosoftGraphSecurityRetentionDuration>]`: retentionDuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RetentionEventType <IMicrosoftGraphSecurityRetentionEventType>]`: retentionEventType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date time when the retentionEventType was created.
    - `[Description <String>]`: Optional information about the event type.
    - `[DisplayName <String>]`: Name of the event type.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionEventType was modified.
  - `[RetentionTrigger <String>]`: retentionTrigger

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

DISPOSITIONREVIEWSTAGES <IMicrosoftGraphSecurityDispositionReviewStage[]>: Review stages during which reviewers are notified to determine whether a document must be deleted or retained.
  - `[Id <String>]`: 
  - `[Name <String>]`: Name representing each stage within a collection.
  - `[ReviewersEmailAddresses <String[]>]`: A collection of reviewers at each stage.
  - `[StageNumber <Int32?>]`: The sequence number for each stage of the disposition review.

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

RETENTIONEVENTTYPE <IMicrosoftGraphSecurityRetentionEventType>: retentionEventType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date time when the retentionEventType was created.
  - `[Description <String>]`: Optional information about the event type.
  - `[DisplayName <String>]`: Name of the event type.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionEventType was modified.

## RELATED LINKS

