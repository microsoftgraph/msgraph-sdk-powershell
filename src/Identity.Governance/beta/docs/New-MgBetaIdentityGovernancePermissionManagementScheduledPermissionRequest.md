---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/new-mgbetaidentitygovernancepermissionmanagementscheduledpermissionrequest
schema: 2.0.0
---

# New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest

## SYNOPSIS
Create a new scheduledPermissionsRequest object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest [-Action <String>]
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Id <String>] [-Justification <String>]
 [-Notes <String>] [-RequestedPermissions <IMicrosoftGraphPermissionsDefinition>]
 [-ResponseHeadersVariable <String>] [-ScheduleInfo <IMicrosoftGraphRequestSchedule>] [-StatusDetail <String>]
 [-TicketInfo <IMicrosoftGraphTicketInfo>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityGovernancePermissionManagementScheduledPermissionRequest
 -BodyParameter <IMicrosoftGraphScheduledPermissionsRequest> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new scheduledPermissionsRequest object.

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
unifiedRoleScheduleRequestActions

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

### -BodyParameter
scheduledPermissionsRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphScheduledPermissionsRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Defines when the identity created the request.

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

### -Justification
The identity's justification for the request.

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

### -Notes
Additional context for the permissions request.

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

### -RequestedPermissions
permissionsDefinition
To construct, see NOTES section for REQUESTEDPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsDefinition
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

### -ScheduleInfo
requestSchedule
To construct, see NOTES section for SCHEDULEINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRequestSchedule
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StatusDetail
statusDetail

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

### -TicketInfo
ticketInfo
To construct, see NOTES section for TICKETINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTicketInfo
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphScheduledPermissionsRequest

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphScheduledPermissionsRequest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphScheduledPermissionsRequest>`: scheduledPermissionsRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

`REQUESTEDPERMISSIONS <IMicrosoftGraphPermissionsDefinition>`: permissionsDefinition
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

`SCHEDULEINFO <IMicrosoftGraphRequestSchedule>`: requestSchedule
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

`TICKETINFO <IMicrosoftGraphTicketInfo>`: ticketInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TicketApproverIdentityId <String>]`: ID for the request approver.
  - `[TicketNumber <String>]`: The ticket number.
  - `[TicketSubmitterIdentityId <String>]`: ID for the request submitter.
  - `[TicketSystem <String>]`: The description of the ticket system.

## RELATED LINKS

