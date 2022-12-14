---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.administration/update-mgdevicemanagementvirtualendpointorganizationsetting
schema: 2.0.0
---

# Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting

## SYNOPSIS
Update the properties of the cloudPcOrganizationSettings object in a tenant.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting [-AdditionalProperties <Hashtable>]
 [-EnableMemAutoEnroll] [-Id <String>] [-OSVersion <String>] [-UserAccountType <String>]
 [-WindowsSettings <IMicrosoftGraphCloudPcWindowsSettings>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting
 -BodyParameter <IMicrosoftGraphCloudPcOrganizationSettings> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of the cloudPcOrganizationSettings object in a tenant.

## EXAMPLES

### Example 1: Using the Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.cloudPcOrganizationSettings"
	EnableMEMAutoEnroll = $true
	OsVersion = "windows11"
	UserAccountType = "standardUser"
	WindowsSettings = @{
		Language = "en-US"
	}
}
Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting -BodyParameter $params
```

This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcOrganizationSettings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcOrganizationSettings
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EnableMemAutoEnroll
Specifies whether new Cloud PCs will be automatically enrolled in Microsoft Endpoint Manager(MEM).
The default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSVersion
cloudPcOperatingSystem

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### -UserAccountType
cloudPcUserAccountType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsSettings
cloudPcWindowsSettings
To construct, please use Get-Help -Online and see NOTES section for WINDOWSSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcWindowsSettings
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcOrganizationSettings

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcOrganizationSettings>: cloudPcOrganizationSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[EnableMemAutoEnroll <Boolean?>]`: Specifies whether new Cloud PCs will be automatically enrolled in Microsoft Endpoint Manager(MEM). The default value is false.
  - `[OSVersion <String>]`: cloudPcOperatingSystem
  - `[UserAccountType <String>]`: cloudPcUserAccountType
  - `[WindowsSettings <IMicrosoftGraphCloudPcWindowsSettings>]`: cloudPcWindowsSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Language <String>]`: The Windows language/region tag to use for language pack configuration and localization of the Cloud PC. The default value is en-US, which corresponds to English (United States).

WINDOWSSETTINGS <IMicrosoftGraphCloudPcWindowsSettings>: cloudPcWindowsSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Language <String>]`: The Windows language/region tag to use for language pack configuration and localization of the Cloud PC. The default value is en-US, which corresponds to English (United States).

## RELATED LINKS

