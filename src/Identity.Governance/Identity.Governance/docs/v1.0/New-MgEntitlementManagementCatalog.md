---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementcatalog
schema: 2.0.0
---

# New-MgEntitlementManagementCatalog

## SYNOPSIS
Create new navigation property to catalogs for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementCatalog [-AccessPackages <IMicrosoftGraphAccessPackage1[]>]
 [-AdditionalProperties <Hashtable>] [-CatalogType <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsExternallyVisible]
 [-ModifiedDateTime <DateTime>] [-State <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementCatalog -BodyParameter <IMicrosoftGraphAccessPackageCatalog1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to catalogs for identityGovernance

## EXAMPLES

## PARAMETERS

### -AccessPackages
The access packages in this catalog.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for ACCESSPACKAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage1[]
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

### -BodyParameter
accessPackageCatalog
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogType
accessPackageCatalogType

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

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

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

### -Description
The description of the access package catalog.

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
The display name of the access package catalog.
Supports $filter (eq, contains).

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

### -IsExternallyVisible
Whether the access packages in this catalog can be requested by users outside of the tenant.

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

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

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

### -State
accessPackageCatalogState

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGES <IMicrosoftGraphAccessPackage1[]>: The access packages in this catalog. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]`: 
    - `[Id <String>]`: 
    - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[AllowedTargetScope <String>]`: allowedTargetScope
    - `[AutomaticRequestSettings <IMicrosoftGraphAccessPackageAutomaticRequestSettings>]`: accessPackageAutomaticRequestSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[GracePeriodBeforeAccessRemoval <TimeSpan?>]`: 
      - `[RemoveAccessWhenTargetLeavesAllowedTargets <Boolean?>]`: 
      - `[RequestAccessForAllowedTargets <Boolean?>]`: 
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable. Supports $expand.
      - `[CatalogType <String>]`: accessPackageCatalogType
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the access package catalog.
      - `[DisplayName <String>]`: The display name of the access package catalog. Supports $filter (eq, contains).
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
      - `[IsApprovalRequiredForAdd <Boolean?>]`: If false, then approval is not required for new requests in this policy.
      - `[IsApprovalRequiredForUpdate <Boolean?>]`: If false, then approval is not required for updates to requests in this policy.
      - `[Stages <IMicrosoftGraphAccessPackageApprovalStage[]>]`: If approval is required, the one, two or three elements of this collection define each of the stages of approval. An empty array is present if no approval is required.
        - `[DurationBeforeAutomaticDenial <TimeSpan?>]`: The number of days that a request can be pending a response before it is automatically denied.
        - `[DurationBeforeEscalation <TimeSpan?>]`: If escalation is required, the time a request can be pending a response from a primary approver.
        - `[EscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests.
        - `[FallbackEscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who are the fallback escalation approvers.
        - `[FallbackPrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who are the fallback primary approvers.
        - `[IsApproverJustificationRequired <Boolean?>]`: Indicates whether the approver is required to provide a justification for approving a request.
        - `[IsEscalationEnabled <Boolean?>]`: If true, then one or more escalationApprovers are configured in this approval stage.
        - `[PrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors or externalSponsors.
    - `[RequestorSettings <IMicrosoftGraphAccessPackageAssignmentRequestorSettings>]`: accessPackageAssignmentRequestorSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowCustomAssignmentSchedule <Boolean?>]`: If false, the requestor is not permitted to include a schedule in their request.
      - `[EnableOnBehalfRequestorsToAddAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to add access for another principal.
      - `[EnableOnBehalfRequestorsToRemoveAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to remove access for another principal.
      - `[EnableOnBehalfRequestorsToUpdateAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to update access for another principal.
      - `[EnableTargetsToSelfAddAccess <Boolean?>]`: If true, allows requestors to create a request to add access for themselves.
      - `[EnableTargetsToSelfRemoveAccess <Boolean?>]`: If true, allows requestors to create a request to remove their access.
      - `[EnableTargetsToSelfUpdateAccess <Boolean?>]`: If true, allows requestors to create a request to update their access.
      - `[OnBehalfRequestors <IMicrosoftGraphSubjectSet[]>]`: The principals who can request on-behalf-of others.
    - `[ReviewSettings <IMicrosoftGraphAccessPackageAssignmentReviewSettings>]`: accessPackageAssignmentReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExpirationBehavior <String>]`: accessReviewExpirationBehavior
      - `[FallbackReviewers <IMicrosoftGraphSubjectSet[]>]`: This collection specifies the users who will be the fallback reviewers when the primary reviewers don't respond.
      - `[IsEnabled <Boolean?>]`: If true, access reviews are required for assignments through this policy.
      - `[IsRecommendationEnabled <Boolean?>]`: Specifies whether to display recommendations to the reviewer. The default value is true.
      - `[IsReviewerJustificationRequired <Boolean?>]`: Specifies whether the reviewer must provide justification for the approval. The default value is true.
      - `[IsSelfReview <Boolean?>]`: Specifies whether the principals can review their own assignments.
      - `[PrimaryReviewers <IMicrosoftGraphSubjectSet[]>]`: This collection specifies the users or group of users who will review the access package assignments.
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
    - `[SpecificAllowedTargets <IMicrosoftGraphSubjectSet[]>]`: The principals that can be assigned access from an access package through this policy.
  - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package.
  - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
  - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

BODYPARAMETER <IMicrosoftGraphAccessPackageCatalog1>: accessPackageCatalog
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: 
    - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy1[]>]`: 
      - `[Id <String>]`: 
      - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
      - `[AllowedTargetScope <String>]`: allowedTargetScope
      - `[AutomaticRequestSettings <IMicrosoftGraphAccessPackageAutomaticRequestSettings>]`: accessPackageAutomaticRequestSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[GracePeriodBeforeAccessRemoval <TimeSpan?>]`: 
        - `[RemoveAccessWhenTargetLeavesAllowedTargets <Boolean?>]`: 
        - `[RequestAccessForAllowedTargets <Boolean?>]`: 
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
        - `[IsApprovalRequiredForAdd <Boolean?>]`: If false, then approval is not required for new requests in this policy.
        - `[IsApprovalRequiredForUpdate <Boolean?>]`: If false, then approval is not required for updates to requests in this policy.
        - `[Stages <IMicrosoftGraphAccessPackageApprovalStage[]>]`: If approval is required, the one, two or three elements of this collection define each of the stages of approval. An empty array is present if no approval is required.
          - `[DurationBeforeAutomaticDenial <TimeSpan?>]`: The number of days that a request can be pending a response before it is automatically denied.
          - `[DurationBeforeEscalation <TimeSpan?>]`: If escalation is required, the time a request can be pending a response from a primary approver.
          - `[EscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests.
          - `[FallbackEscalationApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who are the fallback escalation approvers.
          - `[FallbackPrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who are the fallback primary approvers.
          - `[IsApproverJustificationRequired <Boolean?>]`: Indicates whether the approver is required to provide a justification for approving a request.
          - `[IsEscalationEnabled <Boolean?>]`: If true, then one or more escalationApprovers are configured in this approval stage.
          - `[PrimaryApprovers <IMicrosoftGraphSubjectSet[]>]`: The subjects, typically users, who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors or externalSponsors.
      - `[RequestorSettings <IMicrosoftGraphAccessPackageAssignmentRequestorSettings>]`: accessPackageAssignmentRequestorSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AllowCustomAssignmentSchedule <Boolean?>]`: If false, the requestor is not permitted to include a schedule in their request.
        - `[EnableOnBehalfRequestorsToAddAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to add access for another principal.
        - `[EnableOnBehalfRequestorsToRemoveAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to remove access for another principal.
        - `[EnableOnBehalfRequestorsToUpdateAccess <Boolean?>]`: If true, allows on-behalf-of requestors to create a request to update access for another principal.
        - `[EnableTargetsToSelfAddAccess <Boolean?>]`: If true, allows requestors to create a request to add access for themselves.
        - `[EnableTargetsToSelfRemoveAccess <Boolean?>]`: If true, allows requestors to create a request to remove their access.
        - `[EnableTargetsToSelfUpdateAccess <Boolean?>]`: If true, allows requestors to create a request to update their access.
        - `[OnBehalfRequestors <IMicrosoftGraphSubjectSet[]>]`: The principals who can request on-behalf-of others.
      - `[ReviewSettings <IMicrosoftGraphAccessPackageAssignmentReviewSettings>]`: accessPackageAssignmentReviewSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExpirationBehavior <String>]`: accessReviewExpirationBehavior
        - `[FallbackReviewers <IMicrosoftGraphSubjectSet[]>]`: This collection specifies the users who will be the fallback reviewers when the primary reviewers don't respond.
        - `[IsEnabled <Boolean?>]`: If true, access reviews are required for assignments through this policy.
        - `[IsRecommendationEnabled <Boolean?>]`: Specifies whether to display recommendations to the reviewer. The default value is true.
        - `[IsReviewerJustificationRequired <Boolean?>]`: Specifies whether the reviewer must provide justification for the approval. The default value is true.
        - `[IsSelfReview <Boolean?>]`: Specifies whether the principals can review their own assignments.
        - `[PrimaryReviewers <IMicrosoftGraphSubjectSet[]>]`: This collection specifies the users or group of users who will review the access package assignments.
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
      - `[SpecificAllowedTargets <IMicrosoftGraphSubjectSet[]>]`: The principals that can be assigned access from an access package through this policy.
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog1>]`: accessPackageCatalog
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CatalogType <String>]`: accessPackageCatalogType
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package catalog.
  - `[DisplayName <String>]`: The display name of the access package catalog. Supports $filter (eq, contains).
  - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[State <String>]`: accessPackageCatalogState

## RELATED LINKS

