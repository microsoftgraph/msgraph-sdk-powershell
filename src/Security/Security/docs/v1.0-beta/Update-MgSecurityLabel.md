---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecuritylabel
schema: 2.0.0
---

# Update-MgSecurityLabel

## SYNOPSIS
Update the navigation property labels in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityLabel [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-RetentionLabels <IMicrosoftGraphSecurityRetentionLabel[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityLabel -BodyParameter <IMicrosoftGraphSecurityLabelsRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property labels in security

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
labelsRoot
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityLabelsRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -RetentionLabels
.
To construct, please use Get-Help -Online and see NOTES section for RETENTIONLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityRetentionLabel[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityLabelsRoot

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecurityLabelsRoot>: labelsRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[RetentionLabels <IMicrosoftGraphSecurityRetentionLabel[]>]`: 
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

RETENTIONLABELS <IMicrosoftGraphSecurityRetentionLabel[]>: .
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

## RELATED LINKS

