---
external help file:
Module Name: Microsoft.Graph.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.calendar/get-mguserdefaultcalendar
schema: 2.0.0
---

# Get-MgUserDefaultCalendar

## SYNOPSIS
Get the properties and relationships of a calendar object.
The calendar can be one for a user, \nor the default calendar of a Microsoft 365 group.
There are two scenarios where an app can get another user's calendar:

## SYNTAX

### Get2 (Default)
```
Get-MgUserDefaultCalendar -UserId <String> [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgUserDefaultCalendar -InputObject <ICalendarIdentity> [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get the properties and relationships of a calendar object.
The calendar can be one for a user, \nor the default calendar of a Microsoft 365 group.
There are two scenarios where an app can get another user's calendar:

## EXAMPLES

### Example 1: Using the Get-MgUserDefaultCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserDefaultCalendar -UserId $userId
```

This example shows how to use the Get-MgUserDefaultCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICalendarIdentity
Parameter Sets: GetViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Get2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ICalendarIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendar

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ICalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[CalendarGroupId <String>]`: The unique identifier of calendarGroup
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[CalendarPermissionId <String>]`: The unique identifier of calendarPermission
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[EventId2 <String>]`: The unique identifier of event
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[GroupId <String>]`: The unique identifier of group
  - `[MultiValueLegacyExtendedPropertyId <String>]`: The unique identifier of multiValueLegacyExtendedProperty
  - `[PlaceId <String>]`: The unique identifier of place
  - `[SingleValueLegacyExtendedPropertyId <String>]`: The unique identifier of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

