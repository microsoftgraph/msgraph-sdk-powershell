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

### UpdateExpanded (Default)
```
Update-MgPrintConnector -PrintConnectorId <String> [-AdditionalProperties <Hashtable>] [-AppVersion <String>]
 [-DeviceHealth <IMicrosoftGraphDeviceHealth>] [-FullyQualifiedDomainName <String>] [-Id <String>]
 [-Location <IMicrosoftGraphPrinterLocation>] [-Name <String>] [-OperatingSystem <String>]
 [-RegisteredDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrintConnector -PrintConnectorId <String> -BodyParameter <IMicrosoftGraphPrintConnector> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrintConnector -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintConnector> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrintConnector -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-AppVersion <String>] [-DeviceHealth <IMicrosoftGraphDeviceHealth>] [-FullyQualifiedDomainName <String>]
 [-Id <String>] [-Location <IMicrosoftGraphPrinterLocation>] [-Name <String>] [-OperatingSystem <String>]
 [-RegisteredDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property connectors in print

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

### -BodyParameter
printConnector
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FullyQualifiedDomainName
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

### -Id
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterLocation
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredDateTime
.

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

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrintConnector>: printConnector
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AppVersion <String>]`: 
  - `[DeviceHealth <IMicrosoftGraphDeviceHealth>]`: deviceHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastConnectionTime <DateTime?>]`: 
  - `[FullyQualifiedDomainName <String>]`: 
  - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AltitudeInMeters <Int32?>]`: 
    - `[Building <String>]`: 
    - `[City <String>]`: 
    - `[CountryOrRegion <String>]`: 
    - `[FloorDescription <String>]`: 
    - `[FloorNumber <Int32?>]`: 
    - `[Latitude <Single?>]`: 
    - `[Longitude <Single?>]`: 
    - `[Organization <String[]>]`: 
    - `[PostalCode <String>]`: 
    - `[RoomDescription <String>]`: 
    - `[RoomNumber <Int32?>]`: 
    - `[Site <String>]`: 
    - `[StateOrProvince <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Subdivision <String[]>]`: 
    - `[Subunit <String[]>]`: 
  - `[Name <String>]`: 
  - `[OperatingSystem <String>]`: 
  - `[RegisteredDateTime <DateTime?>]`: 

DEVICEHEALTH <IMicrosoftGraphDeviceHealth>: deviceHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastConnectionTime <DateTime?>]`: 

INPUTOBJECT <IDevicesCloudPrintIdentity>: Identity Parameter
  - `[GroupId <String>]`: 
  - `[PeriodEnd <DateTime?>]`: 
  - `[PeriodStart <DateTime?>]`: 
  - `[PrintConnectorId <String>]`: key: id of printConnector
  - `[PrintIdentityId <String>]`: key: id of printIdentity
  - `[PrintOperationId <String>]`: key: id of printOperation
  - `[PrintServiceEndpointId <String>]`: key: id of printServiceEndpoint
  - `[PrintServiceId <String>]`: key: id of printService
  - `[PrintTaskDefinitionId <String>]`: key: id of printTaskDefinition
  - `[PrintTaskId <String>]`: key: id of printTask
  - `[PrintTaskTriggerId <String>]`: key: id of printTaskTrigger
  - `[PrintUserIdentityId <String>]`: key: id of printUserIdentity
  - `[PrinterId <String>]`: key: id of printer
  - `[PrinterId1 <String>]`: 
  - `[PrinterShareId <String>]`: key: id of printerShare
  - `[ReportRootId <String>]`: key: id of reportRoot
  - `[TimeSpanInMinutes <Int32?>]`: 
  - `[TopListsSize <Int32?>]`: 
  - `[UserId <String>]`: 

LOCATION <IMicrosoftGraphPrinterLocation>: printerLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AltitudeInMeters <Int32?>]`: 
  - `[Building <String>]`: 
  - `[City <String>]`: 
  - `[CountryOrRegion <String>]`: 
  - `[FloorDescription <String>]`: 
  - `[FloorNumber <Int32?>]`: 
  - `[Latitude <Single?>]`: 
  - `[Longitude <Single?>]`: 
  - `[Organization <String[]>]`: 
  - `[PostalCode <String>]`: 
  - `[RoomDescription <String>]`: 
  - `[RoomNumber <Int32?>]`: 
  - `[Site <String>]`: 
  - `[StateOrProvince <String>]`: 
  - `[StreetAddress <String>]`: 
  - `[Subdivision <String[]>]`: 
  - `[Subunit <String[]>]`: 

## RELATED LINKS

