---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/update-mgbetaidentitygovernancepermissionmanagement
schema: 2.0.0
---

# Update-MgBetaIdentityGovernancePermissionManagement

## SYNOPSIS
Update the navigation property permissionsManagement in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaIdentityGovernancePermissionManagement [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-PermissionsRequestChanges <IMicrosoftGraphPermissionsRequestChange[]>] [-ResponseHeadersVariable <String>]
 [-ScheduledPermissionsApprovals <IMicrosoftGraphApproval[]>]
 [-ScheduledPermissionsRequests <IMicrosoftGraphScheduledPermissionsRequest[]>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaIdentityGovernancePermissionManagement -BodyParameter <IMicrosoftGraphPermissionsManagement>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property permissionsManagement in identityGovernance

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permissionsManagement
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsManagement
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsRequestChanges
Represents a change event of the scheduledPermissionsRequest entity.
To construct, see NOTES section for PERMISSIONSREQUESTCHANGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsRequestChange[]
Parameter Sets: UpdateExpanded
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

### -ScheduledPermissionsApprovals
.
To construct, see NOTES section for SCHEDULEDPERMISSIONSAPPROVALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphApproval[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScheduledPermissionsRequests
Represents a permissions request that Permissions Management uses to manage permissions for an identity on resources in the authorization system.
This request can be granted, rejected or canceled by identities in Permissions Management.
To construct, see NOTES section for SCHEDULEDPERMISSIONSREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphScheduledPermissionsRequest[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsManagement

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsManagement

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPermissionsManagement>`: permissionsManagement
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[PermissionsRequestChanges <IMicrosoftGraphPermissionsRequestChange[]>]`: Represents a change event of the scheduledPermissionsRequest entity.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActiveOccurrenceStatus <String>]`: permissionsRequestOccurrenceStatus
    - `[ModificationDateTime <DateTime?>]`: Time when the change occurred.
    - `[PermissionsRequestId <String>]`: The ID of the scheduledPermissionsRequest object.
    - `[StatusDetail <String>]`: statusDetail
    - `[TicketId <String>]`: Represents the ticketing system identifier.
  - `[ScheduledPermissionsApprovals <IMicrosoftGraphApproval[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Steps <IMicrosoftGraphApprovalStep[]>]`: Used to represent the decision associated with a single step in the approval process configured in approvalStage.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
      - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
      - `[Justification <String>]`: The justification associated with the approval step decision.
      - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
      - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
  - `[ScheduledPermissionsRequests <IMicrosoftGraphScheduledPermissionsRequest[]>]`: Represents a permissions request that Permissions Management uses to manage permissions for an identity on resources in the authorization system. This request can be granted, rejected or canceled by identities in Permissions Management.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Action <String>]`: unifiedRoleScheduleRequestActions
    - `[CreatedDateTime <DateTime?>]`: Defines when the identity created the request.
    - `[Justification <String>]`: The identity's justification for the request.
    - `[Notes <String>]`: Additional context for the permissions request.
    - `[RequestedPermissions <IMicrosoftGraphPermissionsDefinition>]`: permissionsDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AuthorizationSystemInfo <IMicrosoftGraphPermissionsDefinitionAuthorizationSystem>]`: permissionsDefinitionAuthorizationSystem
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment.
        - `[AuthorizationSystemType <String>]`: The type of authorization system.
      - `[IdentityInfo <IMicrosoftGraphPermissionsDefinitionAuthorizationSystemIdentity>]`: permissionsDefinitionAuthorizationSystemIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExternalId <String>]`: Unique ID of the identity within the external system. Prefixed with rsn: if this is a SAML or ED user in AWS. Alternate key.
        - `[IdentityType <String>]`: permissionsDefinitionIdentityType
        - `[Source <IMicrosoftGraphPermissionsDefinitionIdentitySource>]`: permissionsDefinitionIdentitySource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
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
      - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. In PIM, when the  eligible or active assignment becomes active.
    - `[StatusDetail <String>]`: statusDetail
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TicketApproverIdentityId <String>]`: ID for the request approver.
      - `[TicketNumber <String>]`: The ticket number.
      - `[TicketSubmitterIdentityId <String>]`: ID for the request submitter.
      - `[TicketSystem <String>]`: The description of the ticket system.

`PERMISSIONSREQUESTCHANGES <IMicrosoftGraphPermissionsRequestChange[]>`: Represents a change event of the scheduledPermissionsRequest entity.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveOccurrenceStatus <String>]`: permissionsRequestOccurrenceStatus
  - `[ModificationDateTime <DateTime?>]`: Time when the change occurred.
  - `[PermissionsRequestId <String>]`: The ID of the scheduledPermissionsRequest object.
  - `[StatusDetail <String>]`: statusDetail
  - `[TicketId <String>]`: Represents the ticketing system identifier.

`SCHEDULEDPERMISSIONSAPPROVALS <IMicrosoftGraphApproval[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Steps <IMicrosoftGraphApprovalStep[]>]`: Used to represent the decision associated with a single step in the approval process configured in approvalStage.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
    - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
    - `[Justification <String>]`: The justification associated with the approval step decision.
    - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
    - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.

`SCHEDULEDPERMISSIONSREQUESTS <IMicrosoftGraphScheduledPermissionsRequest[]>`: Represents a permissions request that Permissions Management uses to manage permissions for an identity on resources in the authorization system. This request can be granted, rejected or canceled by identities in Permissions Management.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Action <String>]`: unifiedRoleScheduleRequestActions
  - `[CreatedDateTime <DateTime?>]`: Defines when the identity created the request.
  - `[Justification <String>]`: The identity's justification for the request.
  - `[Notes <String>]`: Additional context for the permissions request.
  - `[RequestedPermissions <IMicrosoftGraphPermissionsDefinition>]`: permissionsDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthorizationSystemInfo <IMicrosoftGraphPermissionsDefinitionAuthorizationSystem>]`: permissionsDefinitionAuthorizationSystem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment.
      - `[AuthorizationSystemType <String>]`: The type of authorization system.
    - `[IdentityInfo <IMicrosoftGraphPermissionsDefinitionAuthorizationSystemIdentity>]`: permissionsDefinitionAuthorizationSystemIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExternalId <String>]`: Unique ID of the identity within the external system. Prefixed with rsn: if this is a SAML or ED user in AWS. Alternate key.
      - `[IdentityType <String>]`: permissionsDefinitionIdentityType
      - `[Source <IMicrosoftGraphPermissionsDefinitionIdentitySource>]`: permissionsDefinitionIdentitySource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
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
    - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. In PIM, when the  eligible or active assignment becomes active.
  - `[StatusDetail <String>]`: statusDetail
  - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[TicketApproverIdentityId <String>]`: ID for the request approver.
    - `[TicketNumber <String>]`: The ticket number.
    - `[TicketSubmitterIdentityId <String>]`: ID for the request submitter.
    - `[TicketSystem <String>]`: The description of the ticket system.

## RELATED LINKS

