---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointdeviceimage
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointDeviceImage

## SYNOPSIS
Create new navigation property to deviceImages for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointDeviceImage [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-ExpirationDate <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-OperatingSystem <String>]
 [-OSBuildNumber <String>] [-OSStatus <String>] [-SourceImageResourceId <String>] [-Status <String>]
 [-StatusDetails <String>] [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointDeviceImage -BodyParameter <IMicrosoftGraphCloudPcDeviceImage> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceImages for deviceManagement

## EXAMPLES

### Example 1: Using the New-MgDeviceManagementVirtualEndpointDeviceImage Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcDeviceImage"
	DisplayName = "Display Name value"
	OsBuildNumber = "OS Build Number value"
	OperatingSystem = "Operating System value"
	Version = "Version value"
	SourceImageResourceId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c58ffff/resourceGroups/Example/providers/Microsoft.Compute/images/exampleImage"
}
New-MgDeviceManagementVirtualEndpointDeviceImage -BodyParameter $params
```

This example shows how to use the New-MgDeviceManagementVirtualEndpointDeviceImage Cmdlet.
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
cloudPcDeviceImage
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcDeviceImage
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the image.

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

### -ExpirationDate
The date the image became unavailable.

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

### -Id
The unique idenfier for an entity.
Read-only.

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

### -LastModifiedDateTime
The data and time that the image was last modified.
The time is shown in ISO 8601 format and Coordinated Universal Time (UTC) time.
For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.

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

### -OperatingSystem
The operating system of the image.
For example, Windows 10 Enterprise.

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

### -OSBuildNumber
The OS build version of the image.
For example, 1909.

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

### -OSStatus
cloudPcDeviceImageOsStatus

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

### -SourceImageResourceId
The ID of the source image resource on Azure.
Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}.

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
cloudPcDeviceImageStatus

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
cloudPcDeviceImageStatusDetails

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

### -Version
The image version.
For example, 0.0.1 and 1.5.13.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcDeviceImage

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcDeviceImage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcDeviceImage>: cloudPcDeviceImage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the image.
  - `[ExpirationDate <DateTime?>]`: The date the image became unavailable.
  - `[LastModifiedDateTime <DateTime?>]`: The data and time that the image was last modified. The time is shown in ISO 8601 format and  Coordinated Universal Time (UTC) time. For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
  - `[OSBuildNumber <String>]`: The OS build version of the image. For example, 1909.
  - `[OSStatus <String>]`: cloudPcDeviceImageOsStatus
  - `[OperatingSystem <String>]`: The operating system of the image. For example, Windows 10 Enterprise.
  - `[SourceImageResourceId <String>]`: The ID of the source image resource on Azure. Required format: /subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}.
  - `[Status <String>]`: cloudPcDeviceImageStatus
  - `[StatusDetails <String>]`: cloudPcDeviceImageStatusDetails
  - `[Version <String>]`: The image version. For example, 0.0.1 and 1.5.13.

## RELATED LINKS

