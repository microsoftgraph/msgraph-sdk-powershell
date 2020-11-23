---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintconnector
schema: 2.0.0
---

# New-MgPrintConnector

## SYNOPSIS
Create new navigation property to connectors for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintConnector [-AdditionalProperties <Hashtable>] [-AppVersion <String>]
 [-DeviceHealth <IMicrosoftGraphDeviceHealth>] [-DisplayName <String>] [-FullyQualifiedDomainName <String>]
 [-Id <String>] [-Location <IMicrosoftGraphPrinterLocation>] [-Name <String>] [-OperatingSystem <String>]
 [-RegisteredDateTime <DateTime>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgPrintConnector -BodyParameter <IMicrosoftGraphPrintConnector> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to connectors for print

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: IMicrosoftGraphPrintConnector
Parameter Sets: Create
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
Type: IMicrosoftGraphDeviceHealth
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
printerLocation
To construct, see NOTES section for LOCATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrinterLocation
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredDateTime
.

```yaml
Type: DateTime
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrintConnector\>: printConnector
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AppVersion \<String\>\]: 
  \[DeviceHealth \<IMicrosoftGraphDeviceHealth\>\]: deviceHealth
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[LastConnectionTime \<DateTime?\>\]: 
  \[DisplayName \<String\>\]: 
  \[FullyQualifiedDomainName \<String\>\]: 
  \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AltitudeInMeters \<Int32?\>\]: 
    \[Building \<String\>\]: 
    \[City \<String\>\]: 
    \[CountryOrRegion \<String\>\]: 
    \[FloorDescription \<String\>\]: 
    \[FloorNumber \<Int32?\>\]: 
    \[Latitude \<Single?\>\]: 
    \[Longitude \<Single?\>\]: 
    \[Organization \<String\[\]\>\]: 
    \[PostalCode \<String\>\]: 
    \[RoomDescription \<String\>\]: 
    \[RoomNumber \<Int32?\>\]: 
    \[Site \<String\>\]: 
    \[StateOrProvince \<String\>\]: 
    \[StreetAddress \<String\>\]: 
    \[Subdivision \<String\[\]\>\]: 
    \[Subunit \<String\[\]\>\]: 
  \[Name \<String\>\]: 
  \[OperatingSystem \<String\>\]: 
  \[RegisteredDateTime \<DateTime?\>\]: 

DEVICEHEALTH \<IMicrosoftGraphDeviceHealth\>: deviceHealth
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[LastConnectionTime \<DateTime?\>\]: 

LOCATION \<IMicrosoftGraphPrinterLocation\>: printerLocation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AltitudeInMeters \<Int32?\>\]: 
  \[Building \<String\>\]: 
  \[City \<String\>\]: 
  \[CountryOrRegion \<String\>\]: 
  \[FloorDescription \<String\>\]: 
  \[FloorNumber \<Int32?\>\]: 
  \[Latitude \<Single?\>\]: 
  \[Longitude \<Single?\>\]: 
  \[Organization \<String\[\]\>\]: 
  \[PostalCode \<String\>\]: 
  \[RoomDescription \<String\>\]: 
  \[RoomNumber \<Int32?\>\]: 
  \[Site \<String\>\]: 
  \[StateOrProvince \<String\>\]: 
  \[StreetAddress \<String\>\]: 
  \[Subdivision \<String\[\]\>\]: 
  \[Subunit \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintconnector](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintconnector)

