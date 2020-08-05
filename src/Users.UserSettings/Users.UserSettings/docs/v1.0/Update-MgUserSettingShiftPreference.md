---
external help file:
Module Name: Microsoft.Graph.Users.UserSettings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.usersettings/update-mgusersettingshiftpreference
schema: 2.0.0
---

# Update-MgUserSettingShiftPreference

## SYNOPSIS
Update the navigation property shiftPreferences in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserSettingShiftPreference -UserId <String> [-Availability <IMicrosoftGraphShiftAvailability[]>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgUserSettingShiftPreference -UserId <String> -BodyParameter <IMicrosoftGraphShiftPreferences>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserSettingShiftPreference -InputObject <IUsersUserSettingsIdentity>
 -BodyParameter <IMicrosoftGraphShiftPreferences> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserSettingShiftPreference -InputObject <IUsersUserSettingsIdentity>
 [-Availability <IMicrosoftGraphShiftAvailability[]>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property shiftPreferences in users

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

### -Availability
Availability of the user to be scheduled for work and its recurrence pattern.
To construct, see NOTES section for AVAILABILITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftAvailability[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
shiftPreferences
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftPreferences
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersUserSettingsIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftPreferences

### Microsoft.Graph.PowerShell.Models.IUsersUserSettingsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AVAILABILITY <IMicrosoftGraphShiftAvailability[]>: Availability of the user to be scheduled for work and its recurrence pattern.
  - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
  - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
  - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
  - `[PatternIndex <String>]`: weekIndex
  - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
  - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
  - `[PatternType <String>]`: recurrencePatternType
  - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
  - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
  - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
  - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
  - `[RangeType <String>]`: recurrenceRangeType
  - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
    - `[EndTime <String>]`: End time for the time range.
    - `[StartTime <String>]`: Start time for the time range.
  - `[TimeZone <String>]`: Specifies the time zone for the indicated time.

BODYPARAMETER <IMicrosoftGraphShiftPreferences>: shiftPreferences
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
    - `[PatternDayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
    - `[PatternDaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
    - `[PatternFirstDayOfWeek <String>]`: dayOfWeek
    - `[PatternIndex <String>]`: weekIndex
    - `[PatternInterval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
    - `[PatternMonth <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
    - `[PatternType <String>]`: recurrencePatternType
    - `[RangeEndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
    - `[RangeNumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
    - `[RangeRecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
    - `[RangeStartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
    - `[RangeType <String>]`: recurrenceRangeType
    - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
      - `[EndTime <String>]`: End time for the time range.
      - `[StartTime <String>]`: Start time for the time range.
    - `[TimeZone <String>]`: Specifies the time zone for the indicated time.

INPUTOBJECT <IUsersUserSettingsIdentity>: Identity Parameter
  - `[UserId <String>]`: key: user-id of user

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

## RELATED LINKS

