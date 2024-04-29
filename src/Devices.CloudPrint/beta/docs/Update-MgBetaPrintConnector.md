---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/update-mgbetaprintconnector
schema: 2.0.0
---

# Update-MgBetaPrintConnector

## SYNOPSIS
Update the properties of a printConnector object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaPrintConnector -PrintConnectorId <String> [-AdditionalProperties <Hashtable>]
 [-AppVersion <String>] [-DeviceHealth <IMicrosoftGraphDeviceHealth>] [-DisplayName <String>]
 [-FullyQualifiedDomainName <String>] [-Id <String>] [-Location <IMicrosoftGraphPrinterLocation>]
 [-Name <String>] [-OperatingSystem <String>] [-RegisteredDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaPrintConnector -PrintConnectorId <String> -BodyParameter <IMicrosoftGraphPrintConnector>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaPrintConnector -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintConnector> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaPrintConnector -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-AppVersion <String>] [-DeviceHealth <IMicrosoftGraphDeviceHealth>] [-DisplayName <String>]
 [-FullyQualifiedDomainName <String>] [-Id <String>] [-Location <IMicrosoftGraphPrinterLocation>]
 [-Name <String>] [-OperatingSystem <String>] [-RegisteredDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a printConnector object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -AppVersion
The connector's version.

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

### -BodyParameter
printConnector
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintConnector
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceHealth
deviceHealth
To construct, see NOTES section for DEVICEHEALTH properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the connector.

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

### -FullyQualifiedDomainName
The connector machine's hostname.

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

### -Id
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Location
printerLocation
To construct, see NOTES section for LOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrinterLocation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

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

### -OperatingSystem
The connector machine's operating system version.

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

### -PrintConnectorId
The unique identifier of printConnector

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

### -RegisteredDateTime
The DateTimeOffset when the connector was registered.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintConnector

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPrintConnector>`: printConnector
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppVersion <String>]`: The connector's version.
  - `[DeviceHealth <IMicrosoftGraphDeviceHealth>]`: deviceHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastConnectionTime <DateTime?>]`: The last time the device was connected.
  - `[DisplayName <String>]`: The name of the connector.
  - `[FullyQualifiedDomainName <String>]`: The connector machine's hostname.
  - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AltitudeInMeters <Int32?>]`: The altitude, in meters, that the printer is located at.
    - `[Building <String>]`: The building that the printer is located in.
    - `[City <String>]`: The city that the printer is located in.
    - `[CountryOrRegion <String>]`: The country or region that the printer is located in.
    - `[Floor <String>]`: The floor that the printer is located on. Only numerical values are supported right now.
    - `[FloorDescription <String>]`: The description of the floor that the printer is located on.
    - `[FloorNumber <Int32?>]`: 
    - `[Latitude <Double?>]`: The latitude that the printer is located at.
    - `[Longitude <Double?>]`: The longitude that the printer is located at.
    - `[Organization <String[]>]`: The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.
    - `[PostalCode <String>]`: The postal code that the printer is located in.
    - `[RoomDescription <String>]`: The description of the room that the printer is located in.
    - `[RoomName <String>]`: The room that the printer is located in. Only numerical values are supported right now.
    - `[RoomNumber <Int32?>]`: 
    - `[Site <String>]`: The site that the printer is located in.
    - `[StateOrProvince <String>]`: The state or province that the printer is located in.
    - `[StreetAddress <String>]`: The street address where the printer is located.
    - `[Subdivision <String[]>]`: The subdivision that the printer is located in. The elements should be in hierarchical order.
    - `[Subunit <String[]>]`: 
  - `[Name <String>]`: 
  - `[OperatingSystem <String>]`: The connector machine's operating system version.
  - `[RegisteredDateTime <DateTime?>]`: The DateTimeOffset when the connector was registered.

`DEVICEHEALTH <IMicrosoftGraphDeviceHealth>`: deviceHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastConnectionTime <DateTime?>]`: The last time the device was connected.

`INPUTOBJECT <IDevicesCloudPrintIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PrintConnectorId <String>]`: The unique identifier of printConnector
  - `[PrintDocumentId <String>]`: The unique identifier of printDocument
  - `[PrintJobId <String>]`: The unique identifier of printJob
  - `[PrintOperationId <String>]`: The unique identifier of printOperation
  - `[PrintServiceEndpointId <String>]`: The unique identifier of printServiceEndpoint
  - `[PrintServiceId <String>]`: The unique identifier of printService
  - `[PrintTaskDefinitionId <String>]`: The unique identifier of printTaskDefinition
  - `[PrintTaskId <String>]`: The unique identifier of printTask
  - `[PrintTaskTriggerId <String>]`: The unique identifier of printTaskTrigger
  - `[PrinterId <String>]`: The unique identifier of printer
  - `[PrinterShareId <String>]`: The unique identifier of printerShare
  - `[UserId <String>]`: The unique identifier of user

`LOCATION <IMicrosoftGraphPrinterLocation>`: printerLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AltitudeInMeters <Int32?>]`: The altitude, in meters, that the printer is located at.
  - `[Building <String>]`: The building that the printer is located in.
  - `[City <String>]`: The city that the printer is located in.
  - `[CountryOrRegion <String>]`: The country or region that the printer is located in.
  - `[Floor <String>]`: The floor that the printer is located on. Only numerical values are supported right now.
  - `[FloorDescription <String>]`: The description of the floor that the printer is located on.
  - `[FloorNumber <Int32?>]`: 
  - `[Latitude <Double?>]`: The latitude that the printer is located at.
  - `[Longitude <Double?>]`: The longitude that the printer is located at.
  - `[Organization <String[]>]`: The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.
  - `[PostalCode <String>]`: The postal code that the printer is located in.
  - `[RoomDescription <String>]`: The description of the room that the printer is located in.
  - `[RoomName <String>]`: The room that the printer is located in. Only numerical values are supported right now.
  - `[RoomNumber <Int32?>]`: 
  - `[Site <String>]`: The site that the printer is located in.
  - `[StateOrProvince <String>]`: The state or province that the printer is located in.
  - `[StreetAddress <String>]`: The street address where the printer is located.
  - `[Subdivision <String[]>]`: The subdivision that the printer is located in. The elements should be in hierarchical order.
  - `[Subunit <String[]>]`: 

## RELATED LINKS

