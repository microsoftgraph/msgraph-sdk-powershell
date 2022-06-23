---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackage
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackage

## SYNOPSIS
Represents access package objects.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgEntitlementManagementAccessPackage [-AdditionalProperties <Hashtable>]
 [-AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]
 [-Catalog <IMicrosoftGraphAccessPackageCatalog1>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsHidden] [-ModifiedDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgEntitlementManagementAccessPackage -BodyParameter <IMicrosoftGraphAccessPackage1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Represents access package objects.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentPolicies
.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackage
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Catalog
accessPackageCatalog
To construct, please use Get-Help -Online and see NOTES section for CATALOG properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the access package.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the access package.
Supports $filter (eq, contains).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsHidden
Whether the access package is hidden from the requestor.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTPOLICIES <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]`: 
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
      - `[CatalogType <String>]`: accessPackageCatalogType
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the access package catalog.
      - `[DisplayName <String>]`: The display name of the access package catalog.
      - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[State <String>]`: accessPackageCatalogState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[AllowedTargetScope <String>]`: allowedTargetScope
  - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Description <String>]`: The description of the policy.
  - `[DisplayName <String>]`: The display name of the policy. Supports $filter (eq).
  - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
    - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: expirationPatternType
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[RequestApprovalSettings <IMicrosoftGraphAccessPackageAssignmentApprovalSettings>]`: accessPackageAssignmentApprovalSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsApprovalRequiredForAdd <Boolean?>]`: 
    - `[IsApprovalRequiredForUpdate <Boolean?>]`: 
    - `[Stages <IMicrosoftGraphAccessPackageApprovalStage[]>]`: 
      - `[DurationBeforeAutomaticDenial <TimeSpan?>]`: 
      - `[DurationBeforeEscalation <TimeSpan?>]`: 
      - `[EscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[FallbackEscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[FallbackPrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[IsApproverJustificationRequired <Boolean?>]`: 
      - `[IsEscalationEnabled <Boolean?>]`: 
      - `[PrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
  - `[RequestorSettings <IMicrosoftGraphAccessPackageAssignmentRequestorSettings>]`: accessPackageAssignmentRequestorSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowCustomAssignmentSchedule <Boolean?>]`: 
    - `[EnableOnBehalfRequestorsToAddAccess <Boolean?>]`: 
    - `[EnableOnBehalfRequestorsToRemoveAccess <Boolean?>]`: 
    - `[EnableOnBehalfRequestorsToUpdateAccess <Boolean?>]`: 
    - `[EnableTargetsToSelfAddAccess <Boolean?>]`: 
    - `[EnableTargetsToSelfRemoveAccess <Boolean?>]`: 
    - `[EnableTargetsToSelfUpdateAccess <Boolean?>]`: 
    - `[OnBehalfRequestors <IMicrosoftGraphSubjectSet[]>]`: 
  - `[ReviewSettings <IMicrosoftGraphAccessPackageAssignmentReviewSettings>]`: accessPackageAssignmentReviewSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExpirationBehavior <String>]`: accessReviewExpirationBehavior
    - `[FallbackReviewers <IMicrosoftGraphSubjectSet[]>]`: 
    - `[IsEnabled <Boolean?>]`: 
    - `[IsRecommendationEnabled <Boolean?>]`: 
    - `[IsReviewerJustificationRequired <Boolean?>]`: 
    - `[IsSelfReview <Boolean?>]`: 
    - `[PrimaryReviewers <IMicrosoftGraphSubjectSet[]>]`: 
    - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
      - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
          - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
          - `[FirstDayOfWeek <String>]`: dayOfWeek
          - `[Index <String>]`: weekIndex
          - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
          - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
          - `[Type <String>]`: recurrencePatternType
        - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
          - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
          - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
          - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
          - `[Type <String>]`: recurrenceRangeType
      - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[SpecificAllowedTargets <IMicrosoftGraphSubjectSet[]>]`: 

BODYPARAMETER <IMicrosoftGraphAccessPackage1>: accessPackage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[AllowedTargetScope <String>]`: allowedTargetScope
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
      - `[CatalogType <String>]`: accessPackageCatalogType
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the access package catalog.
      - `[DisplayName <String>]`: The display name of the access package catalog.
      - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[State <String>]`: accessPackageCatalogState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Description <String>]`: The description of the policy.
    - `[DisplayName <String>]`: The display name of the policy. Supports $filter (eq).
    - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
      - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Type <String>]`: expirationPatternType
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[RequestApprovalSettings <IMicrosoftGraphAccessPackageAssignmentApprovalSettings>]`: accessPackageAssignmentApprovalSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsApprovalRequiredForAdd <Boolean?>]`: 
      - `[IsApprovalRequiredForUpdate <Boolean?>]`: 
      - `[Stages <IMicrosoftGraphAccessPackageApprovalStage[]>]`: 
        - `[DurationBeforeAutomaticDenial <TimeSpan?>]`: 
        - `[DurationBeforeEscalation <TimeSpan?>]`: 
        - `[EscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
        - `[FallbackEscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
        - `[FallbackPrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
        - `[IsApproverJustificationRequired <Boolean?>]`: 
        - `[IsEscalationEnabled <Boolean?>]`: 
        - `[PrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
    - `[RequestorSettings <IMicrosoftGraphAccessPackageAssignmentRequestorSettings>]`: accessPackageAssignmentRequestorSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowCustomAssignmentSchedule <Boolean?>]`: 
      - `[EnableOnBehalfRequestorsToAddAccess <Boolean?>]`: 
      - `[EnableOnBehalfRequestorsToRemoveAccess <Boolean?>]`: 
      - `[EnableOnBehalfRequestorsToUpdateAccess <Boolean?>]`: 
      - `[EnableTargetsToSelfAddAccess <Boolean?>]`: 
      - `[EnableTargetsToSelfRemoveAccess <Boolean?>]`: 
      - `[EnableTargetsToSelfUpdateAccess <Boolean?>]`: 
      - `[OnBehalfRequestors <IMicrosoftGraphSubjectSet[]>]`: 
    - `[ReviewSettings <IMicrosoftGraphAccessPackageAssignmentReviewSettings>]`: accessPackageAssignmentReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExpirationBehavior <String>]`: accessReviewExpirationBehavior
      - `[FallbackReviewers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[IsEnabled <Boolean?>]`: 
      - `[IsRecommendationEnabled <Boolean?>]`: 
      - `[IsReviewerJustificationRequired <Boolean?>]`: 
      - `[IsSelfReview <Boolean?>]`: 
      - `[PrimaryReviewers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
            - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
            - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
            - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
            - `[Type <String>]`: recurrenceRangeType
        - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[SpecificAllowedTargets <IMicrosoftGraphSubjectSet[]>]`: 
  - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package.
  - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
  - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

CATALOG <IMicrosoftGraphAccessPackageCatalog1>: accessPackageCatalog
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
      - `[AllowedTargetScope <String>]`: allowedTargetScope
      - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Description <String>]`: The description of the policy.
      - `[DisplayName <String>]`: The display name of the policy. Supports $filter (eq).
      - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
        - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Type <String>]`: expirationPatternType
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[RequestApprovalSettings <IMicrosoftGraphAccessPackageAssignmentApprovalSettings>]`: accessPackageAssignmentApprovalSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsApprovalRequiredForAdd <Boolean?>]`: 
        - `[IsApprovalRequiredForUpdate <Boolean?>]`: 
        - `[Stages <IMicrosoftGraphAccessPackageApprovalStage[]>]`: 
          - `[DurationBeforeAutomaticDenial <TimeSpan?>]`: 
          - `[DurationBeforeEscalation <TimeSpan?>]`: 
          - `[EscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
          - `[FallbackEscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: 
          - `[FallbackPrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
          - `[IsApproverJustificationRequired <Boolean?>]`: 
          - `[IsEscalationEnabled <Boolean?>]`: 
          - `[PrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: 
      - `[RequestorSettings <IMicrosoftGraphAccessPackageAssignmentRequestorSettings>]`: accessPackageAssignmentRequestorSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AllowCustomAssignmentSchedule <Boolean?>]`: 
        - `[EnableOnBehalfRequestorsToAddAccess <Boolean?>]`: 
        - `[EnableOnBehalfRequestorsToRemoveAccess <Boolean?>]`: 
        - `[EnableOnBehalfRequestorsToUpdateAccess <Boolean?>]`: 
        - `[EnableTargetsToSelfAddAccess <Boolean?>]`: 
        - `[EnableTargetsToSelfRemoveAccess <Boolean?>]`: 
        - `[EnableTargetsToSelfUpdateAccess <Boolean?>]`: 
        - `[OnBehalfRequestors <IMicrosoftGraphSubjectSet[]>]`: 
      - `[ReviewSettings <IMicrosoftGraphAccessPackageAssignmentReviewSettings>]`: accessPackageAssignmentReviewSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExpirationBehavior <String>]`: accessReviewExpirationBehavior
        - `[FallbackReviewers <IMicrosoftGraphSubjectSet[]>]`: 
        - `[IsEnabled <Boolean?>]`: 
        - `[IsRecommendationEnabled <Boolean?>]`: 
        - `[IsReviewerJustificationRequired <Boolean?>]`: 
        - `[IsSelfReview <Boolean?>]`: 
        - `[PrimaryReviewers <IMicrosoftGraphSubjectSet[]>]`: 
        - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
          - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
              - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
              - `[FirstDayOfWeek <String>]`: dayOfWeek
              - `[Index <String>]`: weekIndex
              - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
              - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
              - `[Type <String>]`: recurrencePatternType
            - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
              - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
              - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
              - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
              - `[Type <String>]`: recurrenceRangeType
          - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[SpecificAllowedTargets <IMicrosoftGraphSubjectSet[]>]`: 
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CatalogType <String>]`: accessPackageCatalogType
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package catalog.
  - `[DisplayName <String>]`: The display name of the access package catalog.
  - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[State <String>]`: accessPackageCatalogState

## RELATED LINKS

