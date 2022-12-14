---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.administration/get-mgdevicemanagementvirtualendpointorganizationsetting
schema: 2.0.0
---

# Get-MgBetaDeviceManagementVirtualEndpointOrganizationSetting

## SYNOPSIS
Read the properties and relationships of the cloudPcOrganizationSettings from the current tenant.
A tenant has only one **cloudPcOrganizationSettings** object.

## SYNTAX

```
Get-MgBetaDeviceManagementVirtualEndpointOrganizationSetting [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of the cloudPcOrganizationSettings from the current tenant.
A tenant has only one **cloudPcOrganizationSettings** object.

## EXAMPLES

### Example 1: Using the Get-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointOrganizationSetting
```

This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcOrganizationSettings

## NOTES

ALIASES

## RELATED LINKS

