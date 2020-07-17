---
external help file:
Module Name: Microsoft.Graph.Groups.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.functions/invoke-mgcalendargroupcalendarviewcalendar
schema: 2.0.0
---

# Invoke-MgCalendarGroupCalendarViewCalendar

## SYNOPSIS
Invoke function allowedCalendarSharingRoles

## SYNTAX

### Calendar (Default)
```
Invoke-MgCalendarGroupCalendarViewCalendar -EventId <String> -GroupId <String> -User <String>
 [<CommonParameters>]
```

### Calendar3
```
Invoke-MgCalendarGroupCalendarViewCalendar -EventId <String> -GroupId <String> -User <String>
 [<CommonParameters>]
```

### CalendarViaIdentity
```
Invoke-MgCalendarGroupCalendarViewCalendar -InputObject <IGroupsFunctionsIdentity> [<CommonParameters>]
```

### CalendarViaIdentity3
```
Invoke-MgCalendarGroupCalendarViewCalendar -InputObject <IGroupsFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function allowedCalendarSharingRoles

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

### -EventId
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Calendar, Calendar3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Calendar, Calendar3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsFunctionsIdentity
Parameter Sets: CalendarViaIdentity, CalendarViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -User
.

```yaml
Type: System.String
Parameter Sets: Calendar, Calendar3
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

### Microsoft.Graph.PowerShell.Models.IGroupsFunctionsIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IGroupsFunctionsIdentity>: Identity Parameter
  - `[EventId <String>]`: key: event-id of event
  - `[GroupId <String>]`: key: group-id of group
  - `[IncludePersonalNotebooks <Boolean?>]`: 
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[User <String>]`: 

## RELATED LINKS

