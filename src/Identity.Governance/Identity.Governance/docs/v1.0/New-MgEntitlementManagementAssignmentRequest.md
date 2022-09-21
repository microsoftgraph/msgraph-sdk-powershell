---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementassignmentrequest
schema: 2.0.0
---

# New-MgEntitlementManagementAssignmentRequest

## SYNOPSIS
In Azure AD Entitlement Management, create a new accessPackageAssignmentRequest object.
This operation is used to assign a user to an access package, or to remove an access package assignment.

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAssignmentRequest [-AccessPackage <IMicrosoftGraphAccessPackage1>]
 [-AdditionalProperties <Hashtable>] [-Assignment <IMicrosoftGraphAccessPackageAssignment>]
 [-CompletedDateTime <DateTime>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-RequestType <String>]
 [-Schedule <IMicrosoftGraphEntitlementManagementSchedule>] [-State <String>] [-Status <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAssignmentRequest -BodyParameter <IMicrosoftGraphAccessPackageAssignmentRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
In Azure AD Entitlement Management, create a new accessPackageAssignmentRequest object.
This operation is used to assign a user to an access package, or to remove an access package assignment.

## EXAMPLES

### Example 1: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminAdd"
	Assignment = @{
		TargetId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
		AssignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		AccessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminAdd"
	Assignment = @{
		TargetId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
		AssignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		AccessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminRemove"
	Assignment = @{
		Id = "a6bb6942-3ae1-4259-9908-0133aaee9377"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "userAdd"
	Assignment = @{
		AccessPackageId = "d7be3253-b9c6-4fab-adef-30d30de8da2b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "userAdd"
	Assignment = @{
		AccessPackageId = "d7be3253-b9c6-4fab-adef-30d30de8da2b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AccessPackage
accessPackage
To construct, please use Get-Help -Online and see NOTES section for ACCESSPACKAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage1
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

### -Assignment
accessPackageAssignment
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageAssignmentRequest
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompletedDateTime
The date of the end of processing, either successful or failure, of a request.
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

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.
Supports $filter.

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

### -Requestor
accessPackageSubject
To construct, please use Get-Help -Online and see NOTES section for REQUESTOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageSubject
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestType
accessPackageRequestType

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

### -Schedule
entitlementManagementSchedule
To construct, please use Get-Help -Online and see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEntitlementManagementSchedule
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
accessPackageRequestState

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

### -Status
More information on the request processing status.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGE <IMicrosoftGraphAccessPackage1>: accessPackage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
    - `[Id <String>]`: 
    - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[AllowedTargetScope <String>]`: allowedTargetScope
    - `[AutomaticRequestSettings <IMicrosoftGraphAccessPackageAutomaticRequestSettings>]`: accessPackageAutomaticRequestSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[GracePeriodBeforeAccessRemoval <TimeSpan?>]`: 
      - `[RemoveAccessWhenTargetLeavesAllowedTargets <Boolean?>]`: 
      - `[RequestAccessForAllowedTargets <Boolean?>]`: If set to true, automatic assignments will be created for targets in the allowed target scope.
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
      - `[CatalogType <String>]`: accessPackageCatalogType
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the access package catalog.
      - `[DisplayName <String>]`: The display name of the access package catalog.
      - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[State <String>]`: accessPackageCatalogState
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Description <String>]`: The description of the policy.
    - `[DisplayName <String>]`: The display name of the policy.
    - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
      - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Type <String>]`: expirationPatternType
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
  - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package.
  - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
  - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

ASSIGNMENT <IMicrosoftGraphAccessPackageAssignment>: accessPackageAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: 
      - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
      - `[AllowedTargetScope <String>]`: allowedTargetScope
      - `[AutomaticRequestSettings <IMicrosoftGraphAccessPackageAutomaticRequestSettings>]`: accessPackageAutomaticRequestSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[GracePeriodBeforeAccessRemoval <TimeSpan?>]`: 
        - `[RemoveAccessWhenTargetLeavesAllowedTargets <Boolean?>]`: 
        - `[RequestAccessForAllowedTargets <Boolean?>]`: If set to true, automatic assignments will be created for targets in the allowed target scope.
      - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
        - `[CatalogType <String>]`: accessPackageCatalogType
        - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Description <String>]`: The description of the access package catalog.
        - `[DisplayName <String>]`: The display name of the access package catalog.
        - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
        - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[State <String>]`: accessPackageCatalogState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of the policy.
      - `[DisplayName <String>]`: The display name of the policy.
      - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
        - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Type <String>]`: expirationPatternType
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[AssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
  - `[ExpiredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
  - `[State <String>]`: accessPackageAssignmentState
  - `[Status <String>]`: More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.
  - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the connected organization.
      - `[DisplayName <String>]`: The display name of the connected organization. Supports $filter (eq).
      - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Id <String>]`: 
        - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: The identity sources in this connected organization, one of azureActiveDirectoryTenant, domainIdentitySource or externalDomainFederation. Nullable.
      - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[State <String>]`: connectedOrganizationState
    - `[DisplayName <String>]`: The display name of the subject.
    - `[Email <String>]`: The email address of the subject.
    - `[ObjectId <String>]`: The object identifier of the subject. null if the subject is not yet a user in the tenant.
    - `[OnPremisesSecurityIdentifier <String>]`: A string representation of the principal's security identifier, if known, or null if the subject does not have a security identifier.
    - `[PrincipalName <String>]`: The principal name, if known, of the subject.
    - `[SubjectType <String>]`: accessPackageSubjectType

BODYPARAMETER <IMicrosoftGraphAccessPackageAssignmentRequest>: accessPackageAssignmentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: 
      - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
      - `[AllowedTargetScope <String>]`: allowedTargetScope
      - `[AutomaticRequestSettings <IMicrosoftGraphAccessPackageAutomaticRequestSettings>]`: accessPackageAutomaticRequestSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[GracePeriodBeforeAccessRemoval <TimeSpan?>]`: 
        - `[RemoveAccessWhenTargetLeavesAllowedTargets <Boolean?>]`: 
        - `[RequestAccessForAllowedTargets <Boolean?>]`: If set to true, automatic assignments will be created for targets in the allowed target scope.
      - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[AccessPackages <IMicrosoftGraphAccessPackage1[]>]`: The access packages in this catalog. Read-only. Nullable.
        - `[CatalogType <String>]`: accessPackageCatalogType
        - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Description <String>]`: The description of the access package catalog.
        - `[DisplayName <String>]`: The display name of the access package catalog.
        - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
        - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[State <String>]`: accessPackageCatalogState
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of the policy.
      - `[DisplayName <String>]`: The display name of the policy.
      - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
        - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Type <String>]`: expirationPatternType
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
    - `[Catalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package. Supports $filter (eq, contains).
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Assignment <IMicrosoftGraphAccessPackageAssignment>]`: accessPackageAssignment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AccessPackage <IMicrosoftGraphAccessPackage1>]`: accessPackage
    - `[AssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[ExpiredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
    - `[State <String>]`: accessPackageAssignmentState
    - `[Status <String>]`: More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.
    - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Description <String>]`: The description of the connected organization.
        - `[DisplayName <String>]`: The display name of the connected organization. Supports $filter (eq).
        - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
          - `[Id <String>]`: 
          - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
        - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: The identity sources in this connected organization, one of azureActiveDirectoryTenant, domainIdentitySource or externalDomainFederation. Nullable.
        - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[State <String>]`: connectedOrganizationState
      - `[DisplayName <String>]`: The display name of the subject.
      - `[Email <String>]`: The email address of the subject.
      - `[ObjectId <String>]`: The object identifier of the subject. null if the subject is not yet a user in the tenant.
      - `[OnPremisesSecurityIdentifier <String>]`: A string representation of the principal's security identifier, if known, or null if the subject does not have a security identifier.
      - `[PrincipalName <String>]`: The principal name, if known, of the subject.
      - `[SubjectType <String>]`: accessPackageSubjectType
  - `[CompletedDateTime <DateTime?>]`: The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter.
  - `[RequestType <String>]`: accessPackageRequestType
  - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
  - `[Schedule <IMicrosoftGraphEntitlementManagementSchedule>]`: entitlementManagementSchedule
  - `[State <String>]`: accessPackageRequestState
  - `[Status <String>]`: More information on the request processing status. Read-only.

REQUESTOR <IMicrosoftGraphAccessPackageSubject>: accessPackageSubject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the connected organization.
    - `[DisplayName <String>]`: The display name of the connected organization. Supports $filter (eq).
    - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: 
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: The identity sources in this connected organization, one of azureActiveDirectoryTenant, domainIdentitySource or externalDomainFederation. Nullable.
    - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[State <String>]`: connectedOrganizationState
  - `[DisplayName <String>]`: The display name of the subject.
  - `[Email <String>]`: The email address of the subject.
  - `[ObjectId <String>]`: The object identifier of the subject. null if the subject is not yet a user in the tenant.
  - `[OnPremisesSecurityIdentifier <String>]`: A string representation of the principal's security identifier, if known, or null if the subject does not have a security identifier.
  - `[PrincipalName <String>]`: The principal name, if known, of the subject.
  - `[SubjectType <String>]`: accessPackageSubjectType

SCHEDULE <IMicrosoftGraphEntitlementManagementSchedule>: entitlementManagementSchedule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
    - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: expirationPatternType
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

## RELATED LINKS

