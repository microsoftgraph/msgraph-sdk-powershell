---
external help file:
Module Name: Microsoft.Graph.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.calendar/update-mgplace
schema: 2.0.0
---

# Update-MgPlace

## SYNOPSIS
Update the properties of place object, which can be a room, workspace, or roomList.
You can identify the **room**, **workspace**, or **roomList** by specifying the **id** or **emailAddress** property.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPlace -PlaceId <String> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress1>] [-DisplayName <String>]
 [-GeoCoordinates <IMicrosoftGraphOutlookGeoCoordinates>] [-Id <String>] [-Phone <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPlace -PlaceId <String> -BodyParameter <IMicrosoftGraphPlace> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPlace -InputObject <ICalendarIdentity> -BodyParameter <IMicrosoftGraphPlace> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPlace -InputObject <ICalendarIdentity> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress1>] [-DisplayName <String>]
 [-GeoCoordinates <IMicrosoftGraphOutlookGeoCoordinates>] [-Id <String>] [-Phone <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of place object, which can be a room, workspace, or roomList.
You can identify the **room**, **workspace**, or **roomList** by specifying the **id** or **emailAddress** property.

## EXAMPLES

### Example 1: Using the Update-MgPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.room"
	Nickname = "Conf Room"
	Building = "1"
	Label = "100"
	Capacity = 
	IsWheelChairAccessible = $false
}
Update-MgPlace -PlaceId $placeId -BodyParameter $params
```

This example shows how to use the Update-MgPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Update-MgPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.roomList"
	DisplayName = "Building 1"
	Phone = "555-555-0100"
	Address = @{
		Street = "4567 Main Street"
		City = "Buffalo"
		State = "NY"
		PostalCode = "98052"
		CountryOrRegion = "USA"
	}
	GeoCoordinates = @{
		Altitude = $null
		Latitude = 47
		Longitude = -122
		Accuracy = $null
		AltitudeAccuracy = $null
	}
}
Update-MgPlace -PlaceId $placeId -BodyParameter $params
```

This example shows how to use the Update-MgPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Update-MgPlace Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.workspace"
	Nickname = "Conf Room"
	Building = "1"
	Label = "100"
	Capacity = 
	IsWheelChairAccessible = $false
}
Update-MgPlace -PlaceId $placeId -BodyParameter $params
```

This example shows how to use the Update-MgPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Address
physicalAddress
To construct, please use Get-Help -Online and see NOTES section for ADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
place
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlace
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name associated with the place.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GeoCoordinates
outlookGeoCoordinates
To construct, please use Get-Help -Online and see NOTES section for GEOCOORDINATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookGeoCoordinates
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ICalendarIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Phone
The phone number of the place.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.ICalendarIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlace

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDRESS <IMicrosoftGraphPhysicalAddress1>: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostOfficeBox <String>]`: The post office box number.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.
  - `[Type <String>]`: physicalAddressType

BODYPARAMETER <IMicrosoftGraphPlace>: place
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[DisplayName <String>]`: The name associated with the place.
  - `[GeoCoordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[Altitude <Double?>]`: The altitude of the location.
    - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[Latitude <Double?>]`: The latitude of the location.
    - `[Longitude <Double?>]`: The longitude of the location.
  - `[Phone <String>]`: The phone number of the place.

GEOCOORDINATES <IMicrosoftGraphOutlookGeoCoordinates>: outlookGeoCoordinates
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[Altitude <Double?>]`: The altitude of the location.
  - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[Latitude <Double?>]`: The latitude of the location.
  - `[Longitude <Double?>]`: The longitude of the location.

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

