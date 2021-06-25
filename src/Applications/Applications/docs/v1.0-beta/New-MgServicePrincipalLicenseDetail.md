---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipallicensedetail
schema: 2.0.0
---

# New-MgServicePrincipalLicenseDetail

## SYNOPSIS
Create new navigation property to licenseDetails for servicePrincipals

## SYNTAX

### CreateExpanded (Default)
```
New-MgServicePrincipalLicenseDetail -ServicePrincipalId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgServicePrincipalLicenseDetail -ServicePrincipalId <String> -BodyParameter <IMicrosoftGraphLicenseDetails>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgServicePrincipalLicenseDetail -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgServicePrincipalLicenseDetail -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphLicenseDetails> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to licenseDetails for servicePrincipals

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IMicrosoftGraphLicenseDetails
Parameter Sets: Create, CreateViaIdentity
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
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IApplicationsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServicePlans
Information about the service plans assigned with the license.
Read-only, Not nullable
To construct, see NOTES section for SERVICEPLANS properties and create a hash table.

```yaml
Type: IMicrosoftGraphServicePlanInfo[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
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
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails

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

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[UserId <String>]`: key: id of user

SERVICEPLANS <IMicrosoftGraphServicePlanInfo[]>: Information about the service plans assigned with the license. Read-only, Not nullable
  - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
  - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan).'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
  - `[ServicePlanId <String>]`: The unique identifier of the service plan.
  - `[ServicePlanName <String>]`: The name of the service plan.

## RELATED LINKS
