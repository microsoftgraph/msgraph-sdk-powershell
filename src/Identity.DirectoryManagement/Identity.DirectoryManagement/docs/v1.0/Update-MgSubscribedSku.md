---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgsubscribedsku
schema: 2.0.0
---

# Update-MgSubscribedSku

## SYNOPSIS
Update entity in subscribedSkus

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgSubscribedSku -SubscribedSkuId <String> [-AdditionalProperties <Hashtable>] [-AppliesTo <String>]
 [-CapabilityStatus <String>] [-ConsumedUnits <Int32>] [-Id <String>]
 [-PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>]
 [-SkuId <String>] [-SkuPartNumber <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSubscribedSku -SubscribedSkuId <String> -BodyParameter <IMicrosoftGraphSubscribedSku> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgSubscribedSku -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphSubscribedSku> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgSubscribedSku -InputObject <IIdentityDirectoryManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-AppliesTo <String>] [-CapabilityStatus <String>] [-ConsumedUnits <Int32>] [-Id <String>]
 [-PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>]
 [-SkuId <String>] [-SkuPartNumber <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in subscribedSkus

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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
subscribedSku
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscribedSku
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CapabilityStatus
Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PrepaidUnits
licenseUnitsDetail
To construct, see NOTES section for PREPAIDUNITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseUnitsDetail
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
To construct, see NOTES section for SERVICEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePlanInfo[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscribedSkuId
key: id of subscribedSku

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSubscribedSku

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSubscribedSku>: subscribedSku
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AppliesTo <String>]`: For example, 'User' or 'Company'.
  - `[CapabilityStatus <String>]`: Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.
  - `[ConsumedUnits <Int32?>]`: The number of licenses that have been assigned.
  - `[PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>]`: licenseUnitsDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Enabled <Int32?>]`: The number of units that are enabled.
    - `[Suspended <Int32?>]`: The number of units that are suspended.
    - `[Warning <Int32?>]`: The number of units that are in warning status.
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans that are available with the SKU. Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: The unique identifier (GUID) for the service SKU.
  - `[SkuPartNumber <String>]`: The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.

INPUTOBJECT <IIdentityDirectoryManagementIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: id of administrativeUnit
  - `[CommandId <String>]`: key: id of command
  - `[ContractId <String>]`: key: id of contract
  - `[DeviceId <String>]`: key: id of device
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectoryRoleId <String>]`: key: id of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: key: id of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DirectorySettingTemplateId <String>]`: key: id of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: key: id of domainDnsRecord
  - `[DomainId <String>]`: key: id of domain
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[OrgContactId <String>]`: key: id of orgContact
  - `[OrganizationId <String>]`: key: id of organization
  - `[OrganizationalBrandingId <String>]`: key: id of organizationalBranding
  - `[ScopedRoleMembershipId <String>]`: key: id of scopedRoleMembership
  - `[SubscribedSkuId <String>]`: key: id of subscribedSku
  - `[UserId <String>]`: key: id of user

PREPAIDUNITS <IMicrosoftGraphLicenseUnitsDetail>: licenseUnitsDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Enabled <Int32?>]`: The number of units that are enabled.
  - `[Suspended <Int32?>]`: The number of units that are suspended.
  - `[Warning <Int32?>]`: The number of units that are in warning status.

SERVICEPLANS <IMicrosoftGraphServicePlanInfo[]>: Information about the service plans that are available with the SKU. Not nullable
  - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
  - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
  - `[ServicePlanId <String>]`: The unique identifier of the service plan.
  - `[ServicePlanName <String>]`: The name of the service plan.

## RELATED LINKS

