---
external help file:
Module Name: Microsoft.Graph.Beta.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.calendar/get-mgplace
schema: 2.0.0
---

# Get-MgBetaPlace

## SYNOPSIS
Get the properties and relationships of a place object specified by either its ID or email address.
The **place** object can be one of the following types: The **room**, **workspace**, and **roomList** resources are derived from the **place** object.

## SYNTAX

### List (Default)
```
Get-MgBetaPlace [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>]
 [<CommonParameters>]
```

### Get
```
Get-MgBetaPlace -PlaceId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaPlace -InputObject <ICalendarIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get the properties and relationships of a place object specified by either its ID or email address.
The **place** object can be one of the following types: The **room**, **workspace**, and **roomList** resources are derived from the **place** object.

## EXAMPLES

### Example 1: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the Get-MgBetaPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
Get-MgBetaPlace -PlaceId $placeId
```

This example shows how to use the Get-MgBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
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
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICalendarIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlaceId
key: id of place

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
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

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

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
Parameter Sets: List
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
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.ICalendarIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlace

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ICalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[CalendarGroupId <String>]`: key: id of calendarGroup
  - `[CalendarId <String>]`: key: id of calendar
  - `[CalendarPermissionId <String>]`: key: id of calendarPermission
  - `[EventId <String>]`: key: id of event
  - `[EventId1 <String>]`: key: id of event
  - `[EventId2 <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[PlaceId <String>]`: key: id of place
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

