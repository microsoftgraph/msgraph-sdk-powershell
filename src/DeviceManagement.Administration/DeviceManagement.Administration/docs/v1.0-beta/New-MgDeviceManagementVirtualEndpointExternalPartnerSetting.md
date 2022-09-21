---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointexternalpartnersetting
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointExternalPartnerSetting

## SYNOPSIS
Create a new cloudPcExternalPartnerSetting object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointExternalPartnerSetting [-AdditionalProperties <Hashtable>]
 [-EnableConnection] [-Id <String>] [-LastSyncDateTime <DateTime>] [-PartnerId <String>] [-Status <String>]
 [-StatusDetails <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointExternalPartnerSetting
 -BodyParameter <IMicrosoftGraphCloudPcExternalPartnerSetting> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new cloudPcExternalPartnerSetting object.

## EXAMPLES

### Example 1: Using the New-MgDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	PartnerId = "198d7140-80bb-4843-8cc4-811377a49a92"
	EnableConnection = $true
}
New-MgDeviceManagementVirtualEndpointExternalPartnerSetting -BodyParameter $params
```

This example shows how to use the New-MgDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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
cloudPcExternalPartnerSetting
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExternalPartnerSetting
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EnableConnection
Enable or disable the connection to an external partner.
If true, an external partner API will accept incoming calls from external partners.
Required.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -LastSyncDateTime
Last data sync time for this external partner.
The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerId
The external partner ID.

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

### -Status
cloudPcExternalPartnerStatus

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

### -StatusDetails
Status details message.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExternalPartnerSetting

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcExternalPartnerSetting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcExternalPartnerSetting>: cloudPcExternalPartnerSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[EnableConnection <Boolean?>]`: Enable or disable the connection to an external partner. If true, an external partner API will accept incoming calls from external partners. Required. Supports $filter (eq).
  - `[LastSyncDateTime <DateTime?>]`: Last data sync time for this external partner. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.
  - `[PartnerId <String>]`: The external partner ID.
  - `[Status <String>]`: cloudPcExternalPartnerStatus
  - `[StatusDetails <String>]`: Status details message.

## RELATED LINKS

