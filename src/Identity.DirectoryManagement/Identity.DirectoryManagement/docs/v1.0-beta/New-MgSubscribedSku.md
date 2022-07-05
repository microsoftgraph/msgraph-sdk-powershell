---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgsubscribedsku
schema: 2.0.0
---

# New-MgSubscribedSku

## SYNOPSIS
Add new entity to subscribedSkus

## SYNTAX

### CreateExpanded (Default)
```
New-MgSubscribedSku [-AdditionalProperties <Hashtable>] [-AppliesTo <String>] [-CapabilityStatus <String>]
 [-ConsumedUnits <Int32>] [-Id <String>] [-PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>]
 [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSubscribedSku -BodyParameter <IMicrosoftGraphSubscribedSku> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to subscribedSkus

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

### -AppliesTo
For example, 'User' or 'Company'.

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

### -BodyParameter
subscribedSku
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscribedSku
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CapabilityStatus
Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.
The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.

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

### -ConsumedUnits
The number of licenses that have been assigned.

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

### -PrepaidUnits
licenseUnitsDetail
To construct, please use Get-Help -Online and see NOTES section for PREPAIDUNITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseUnitsDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePlans
Information about the service plans that are available with the SKU.
Not nullable
To construct, please use Get-Help -Online and see NOTES section for SERVICEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePlanInfo[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuId
The unique identifier (GUID) for the service SKU.

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

### -SkuPartNumber
The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'.
To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscribedSku

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscribedSku

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSubscribedSku>: subscribedSku
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppliesTo <String>]`: For example, 'User' or 'Company'.
  - `[CapabilityStatus <String>]`: Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.
  - `[ConsumedUnits <Int32?>]`: The number of licenses that have been assigned.
  - `[PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>]`: licenseUnitsDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Enabled <Int32?>]`: The number of units that are enabled for the active subscription of the service SKU.
    - `[Suspended <Int32?>]`: The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.
    - `[Warning <Int32?>]`: The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans that are available with the SKU. Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: The unique identifier (GUID) for the service SKU.
  - `[SkuPartNumber <String>]`: The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.

PREPAIDUNITS <IMicrosoftGraphLicenseUnitsDetail>: licenseUnitsDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Enabled <Int32?>]`: The number of units that are enabled for the active subscription of the service SKU.
  - `[Suspended <Int32?>]`: The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.
  - `[Warning <Int32?>]`: The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).

SERVICEPLANS <IMicrosoftGraphServicePlanInfo[]>: Information about the service plans that are available with the SKU. Not nullable
  - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
  - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
  - `[ServicePlanId <String>]`: The unique identifier of the service plan.
  - `[ServicePlanName <String>]`: The name of the service plan.

## RELATED LINKS

