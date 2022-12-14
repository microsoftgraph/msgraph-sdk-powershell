---
external help file:
Module Name: Microsoft.Graph.Beta.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.calendar/get-mgusercalendarview
schema: 2.0.0
---

# Get-MgBetaUserCalendarView

## SYNOPSIS
The calendar view for the calendar.
Navigation property.
Read-only.

## SYNTAX

### List (Default)
```
Get-MgBetaUserCalendarView -UserId <String> -EndDateTime <String> -StartDateTime <String> [-Filter <String>]
 [-Property <String[]>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>]
 [-PageSize <Int32>] [<CommonParameters>]
```

### List1
```
Get-MgBetaUserCalendarView -CalendarId <String> -UserId <String> -EndDateTime <String> -StartDateTime <String>
 [-Filter <String>] [-Property <String[]>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

## DESCRIPTION
The calendar view for the calendar.
Navigation property.
Read-only.

## EXAMPLES

### Example 1: Using the Get-MgBetaUserCalendarView Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserCalendarView -UserId $userId -Startdatetime "2017-01-01T19:00:00-08:00" -Enddatetime "2017-01-07T19:00:00-08:00" 
```

This example shows how to use the Get-MgBetaUserCalendarView Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

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

### -CalendarId
key: id of calendar

```yaml
Type: System.String
Parameter Sets: List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
The end date and time of the time range, represented in ISO 8601 format.
For example, 2019-11-08T20:00:00-08:00

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
The start date and time of the time range, represented in ISO 8601 format.
For example, 2019-11-08T19:00:00-08:00

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: (All)
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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEvent

## NOTES

ALIASES

## RELATED LINKS

