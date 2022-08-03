---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprintconnector
schema: 2.0.0
---

# Update-MgPrintConnector

## SYNOPSIS
Update the navigation property connectors in print

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgPrintConnector -PrintConnectorId <String> [-AdditionalProperties <Hashtable>] [-AppVersion <String>]
 [-DisplayName <String>] [-FullyQualifiedDomainName <String>] [-Id <String>]
 [-Location <IMicrosoftGraphPrinterLocation>] [-OperatingSystem <String>] [-RegisteredDateTime <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgPrintConnector -PrintConnectorId <String> -BodyParameter <IMicrosoftGraphPrintConnector1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgPrintConnector -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintConnector1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgPrintConnector -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-AppVersion <String>] [-DisplayName <String>] [-FullyQualifiedDomainName <String>] [-Id <String>]
 [-Location <IMicrosoftGraphPrinterLocation>] [-OperatingSystem <String>] [-RegisteredDateTime <DateTime>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property connectors in print

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printConnector
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the connector.

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

### -FullyQualifiedDomainName
The connector machine's hostname.

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

### -Id
.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Location
printerLocation
To construct, please use Get-Help -Online and see NOTES section for LOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterLocation
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PrintConnectorId
key: id of printConnector

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

### -RegisteredDateTime
The DateTimeOffset when the connector was registered.

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

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrintConnector1>: printConnector
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppVersion <String>]`: The connector's version.
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
    - `[Latitude <Double?>]`: The latitude that the printer is located at.
    - `[Longitude <Double?>]`: The longitude that the printer is located at.
    - `[Organization <String[]>]`: The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.
    - `[PostalCode <String>]`: The postal code that the printer is located in.
    - `[RoomDescription <String>]`: The description of the room that the printer is located in.
    - `[RoomName <String>]`: The room that the printer is located in. Only numerical values are supported right now.
    - `[Site <String>]`: The site that the printer is located in.
    - `[StateOrProvince <String>]`: The state or province that the printer is located in.
    - `[StreetAddress <String>]`: The street address where the printer is located.
    - `[Subdivision <String[]>]`: The subdivision that the printer is located in. The elements should be in hierarchical order.
    - `[Subunit <String[]>]`: 
  - `[OperatingSystem <String>]`: The connector machine's operating system version.
  - `[RegisteredDateTime <DateTime?>]`: The DateTimeOffset when the connector was registered.

INPUTOBJECT <IDevicesCloudPrintIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[PrintConnectorId <String>]`: key: id of printConnector
  - `[PrintOperationId <String>]`: key: id of printOperation
  - `[PrintServiceEndpointId <String>]`: key: id of printServiceEndpoint
  - `[PrintServiceId <String>]`: key: id of printService
  - `[PrintTaskDefinitionId <String>]`: key: id of printTaskDefinition
  - `[PrintTaskId <String>]`: key: id of printTask
  - `[PrintTaskTriggerId <String>]`: key: id of printTaskTrigger
  - `[PrinterId <String>]`: key: id of printer
  - `[PrinterShareId <String>]`: key: id of printerShare
  - `[UserId <String>]`: key: id of user

LOCATION <IMicrosoftGraphPrinterLocation>: printerLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AltitudeInMeters <Int32?>]`: The altitude, in meters, that the printer is located at.
  - `[Building <String>]`: The building that the printer is located in.
  - `[City <String>]`: The city that the printer is located in.
  - `[CountryOrRegion <String>]`: The country or region that the printer is located in.
  - `[Floor <String>]`: The floor that the printer is located on. Only numerical values are supported right now.
  - `[FloorDescription <String>]`: The description of the floor that the printer is located on.
  - `[Latitude <Double?>]`: The latitude that the printer is located at.
  - `[Longitude <Double?>]`: The longitude that the printer is located at.
  - `[Organization <String[]>]`: The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.
  - `[PostalCode <String>]`: The postal code that the printer is located in.
  - `[RoomDescription <String>]`: The description of the room that the printer is located in.
  - `[RoomName <String>]`: The room that the printer is located in. Only numerical values are supported right now.
  - `[Site <String>]`: The site that the printer is located in.
  - `[StateOrProvince <String>]`: The state or province that the printer is located in.
  - `[StreetAddress <String>]`: The street address where the printer is located.
  - `[Subdivision <String[]>]`: The subdivision that the printer is located in. The elements should be in hierarchical order.
  - `[Subunit <String[]>]`: 

## RELATED LINKS

