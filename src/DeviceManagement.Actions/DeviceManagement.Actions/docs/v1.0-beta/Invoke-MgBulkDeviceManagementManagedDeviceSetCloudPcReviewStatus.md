---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgbulkdevicemanagementmanageddevicesetcloudpcreviewstatus
schema: 2.0.0
---

# Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus

## SYNOPSIS
Set the review status of multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices.

## SYNTAX

### BulkExpanded (Default)
```
Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus [-AdditionalProperties <Hashtable>]
 [-ManagedDeviceIds <String[]>] [-ReviewStatus <IMicrosoftGraphCloudPcReviewStatus>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Bulk
```
Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus
 -BodyParameter <IPaths19Pmn9HDevicemanagementManageddevicesMicrosoftGraphBulksetcloudpcreviewstatusPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Set the review status of multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices.

## EXAMPLES

### Example 1: Using the Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Actions
$params = @{
	ManagedDeviceIds = @(
		"30d0e128-de93-41dc-89ec-33d84bb662a0"
		"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
	)
	ReviewStatus = @{
		InReview = $true
		UserAccessLevel = "restricted"
		AzureStorageAccountId = "/subscriptions/f68bd846-16ad-4b51-a7c6-c84944a3367c/resourceGroups/Review/providers/Microsoft.Storage/storageAccounts/snapshotsUnderReview"
	}
}
Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus -BodyParameter $params
```

This example shows how to use the Invoke-MgBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths19Pmn9HDevicemanagementManageddevicesMicrosoftGraphBulksetcloudpcreviewstatusPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Bulk
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceIds
.

```yaml
Type: System.String[]
Parameter Sets: BulkExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewStatus
cloudPcReviewStatus
To construct, please use Get-Help -Online and see NOTES section for REVIEWSTATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcReviewStatus
Parameter Sets: BulkExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths19Pmn9HDevicemanagementManageddevicesMicrosoftGraphBulksetcloudpcreviewstatusPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcBulkRemoteActionResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths19Pmn9HDevicemanagementManageddevicesMicrosoftGraphBulksetcloudpcreviewstatusPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagedDeviceIds <String[]>]`: 
  - `[ReviewStatus <IMicrosoftGraphCloudPcReviewStatus>]`: cloudPcReviewStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AzureStorageAccountId <String>]`: The resource ID of the Azure Storage account in which the Cloud PC snapshot is being saved.
    - `[AzureStorageAccountName <String>]`: The name of the Azure Storage account in which the Cloud PC snapshot is being saved.
    - `[AzureStorageContainerName <String>]`: The name of the container in an Azure Storage account in which the Cloud PC snapshot is being saved.
    - `[InReview <Boolean?>]`: True if the Cloud PC is set to in review by the administrator.
    - `[RestorePointDateTime <DateTime?>]`: The specific date and time of the Cloud PC snapshot that was taken and saved automatically, when the Cloud PC is set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
    - `[ReviewStartDateTime <DateTime?>]`: The specific date and time when the Cloud PC was set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
    - `[SubscriptionId <String>]`: The ID of the Azure subscription in which the Cloud PC snapshot is being saved, in GUID format.
    - `[SubscriptionName <String>]`: The name of the Azure subscription in which the Cloud PC snapshot is being saved.
    - `[UserAccessLevel <String>]`: cloudPcUserAccessLevel

REVIEWSTATUS <IMicrosoftGraphCloudPcReviewStatus>: cloudPcReviewStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AzureStorageAccountId <String>]`: The resource ID of the Azure Storage account in which the Cloud PC snapshot is being saved.
  - `[AzureStorageAccountName <String>]`: The name of the Azure Storage account in which the Cloud PC snapshot is being saved.
  - `[AzureStorageContainerName <String>]`: The name of the container in an Azure Storage account in which the Cloud PC snapshot is being saved.
  - `[InReview <Boolean?>]`: True if the Cloud PC is set to in review by the administrator.
  - `[RestorePointDateTime <DateTime?>]`: The specific date and time of the Cloud PC snapshot that was taken and saved automatically, when the Cloud PC is set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
  - `[ReviewStartDateTime <DateTime?>]`: The specific date and time when the Cloud PC was set to in review. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
  - `[SubscriptionId <String>]`: The ID of the Azure subscription in which the Cloud PC snapshot is being saved, in GUID format.
  - `[SubscriptionName <String>]`: The name of the Azure subscription in which the Cloud PC snapshot is being saved.
  - `[UserAccessLevel <String>]`: cloudPcUserAccessLevel

## RELATED LINKS

