---
external help file:
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/update-mguserlicensedetail
schema: 2.0.0
---

# Update-MgUserLicenseDetail

## SYNOPSIS
A collection of this user's license details.
Read-only.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserLicenseDetail -LicenseDetailsId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserLicenseDetail -LicenseDetailsId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphLicenseDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserLicenseDetail -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphLicenseDetails>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserLicenseDetail -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
A collection of this user's license details.
Read-only.

## EXAMPLES

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

### -BodyParameter
licenseDetails
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Type: Microsoft.Graph.PowerShell.Models.IUsersIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LicenseDetailsId
key: id of licenseDetails

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

### -ServicePlans
Information about the service plans assigned with the license.
Read-only, Not nullable
To construct, see NOTES section for SERVICEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePlanInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuId
Unique identifier (GUID) for the service SKU.
Equal to the skuId property on the related SubscribedSku object.
Read-only

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

### -SkuPartNumber
Unique SKU display name.
Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'.
Read-only

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

### -UserId
key: id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails

### Microsoft.Graph.PowerShell.Models.IUsersIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphLicenseDetails>: licenseDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans assigned with the license. Read-only, Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan).'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
  - `[SkuPartNumber <String>]`: Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only

INPUTOBJECT <IUsersIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ExtensionId <String>]`: key: id of extension
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[LinkedResourceId <String>]`: key: id of linkedResource
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotificationId <String>]`: key: id of notification
  - `[OutlookCategoryId <String>]`: key: id of outlookCategory
  - `[OutlookTaskFolderId <String>]`: key: id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: id of outlookTask
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user

SERVICEPLANS <IMicrosoftGraphServicePlanInfo[]>: Information about the service plans assigned with the license. Read-only, Not nullable
  - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
  - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan).'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
  - `[ServicePlanId <String>]`: The unique identifier of the service plan.
  - `[ServicePlanName <String>]`: The name of the service plan.

## RELATED LINKS

