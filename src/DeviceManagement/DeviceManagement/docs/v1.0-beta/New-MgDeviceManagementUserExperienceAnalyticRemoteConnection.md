---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticremoteconnection
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticRemoteConnection

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsRemoteConnection for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticRemoteConnection [-AdditionalProperties <Hashtable>]
 [-CloudPcFailurePercentage <Double>] [-CloudPcRoundTripTime <Double>] [-CloudPcSignInTime <Double>]
 [-CoreBootTime <Double>] [-CoreSignInTime <Double>] [-DeviceCount <Int32>] [-DeviceId <String>]
 [-DeviceName <String>] [-Id <String>] [-Manufacturer <String>] [-Model <String>] [-RemoteSignInTime <Double>]
 [-UserPrincipalName <String>] [-VirtualNetwork <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticRemoteConnection
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsRemoteConnection> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsRemoteConnection for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analyte remote connection entity.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsRemoteConnection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcFailurePercentage
The sign in failure percentage of Cloud PC Device.
Valid values 0 to 100

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloudPcRoundTripTime
The round tip time of Cloud PC Device.
Valid values 0 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloudPcSignInTime
The sign in time of Cloud PC Device.
Valid values 0 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoreBootTime
The core boot time of Cloud PC Device.
Valid values 0 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CoreSignInTime
The core sign in time of Cloud PC Device.
Valid values 0 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCount
The count of remote connection.
Valid values 0 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
The id of the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
The name of the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
The user experience analytics manufacturer.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
The user experience analytics device model.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoteSignInTime
The remote sign in time of Cloud PC Device.
Valid values 0 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
The user experience analytics userPrincipalName.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VirtualNetwork
The user experience analytics virtual network.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsRemoteConnection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsRemoteConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsRemoteConnection>: The user experience analyte remote connection entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CloudPcFailurePercentage <Double?>]`: The sign in failure percentage of Cloud PC Device. Valid values 0 to 100
  - `[CloudPcRoundTripTime <Double?>]`: The round tip time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308
  - `[CloudPcSignInTime <Double?>]`: The sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308
  - `[CoreBootTime <Double?>]`: The core boot time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308
  - `[CoreSignInTime <Double?>]`: The core sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308
  - `[DeviceCount <Int32?>]`: The count of remote connection. Valid values 0 to 2147483647
  - `[DeviceId <String>]`: The id of the device.
  - `[DeviceName <String>]`: The name of the device.
  - `[Manufacturer <String>]`: The user experience analytics manufacturer.
  - `[Model <String>]`: The user experience analytics device model.
  - `[RemoteSignInTime <Double?>]`: The remote sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308
  - `[UserPrincipalName <String>]`: The user experience analytics userPrincipalName.
  - `[VirtualNetwork <String>]`: The user experience analytics virtual network.

## RELATED LINKS

