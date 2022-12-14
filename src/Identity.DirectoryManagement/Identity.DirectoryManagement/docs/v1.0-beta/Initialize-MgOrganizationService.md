---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.directorymanagement/initialize-mgorganizationservice
schema: 2.0.0
---

# Initialize-MgBetaOrganizationService

## SYNOPSIS
Activate a service for an organization.

## SYNTAX

### ActivateExpanded (Default)
```
Initialize-MgBetaOrganizationService -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-Service <String>] [-ServicePlanId <String>] [-SkuId <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Activate
```
Initialize-MgBetaOrganizationService -OrganizationId <String>
 -BodyParameter <IPaths1M0ZkruOrganizationIdMicrosoftGraphActivateservicePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentity
```
Initialize-MgBetaOrganizationService -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IPaths1M0ZkruOrganizationIdMicrosoftGraphActivateservicePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentityExpanded
```
Initialize-MgBetaOrganizationService -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Service <String>] [-ServicePlanId <String>] [-SkuId <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Activate a service for an organization.

## EXAMPLES

### Example 1: Using the Initialize-MgBetaOrganizationService Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	SkuId = "6fd2c87f-b296-42f0-b197-1e91e994b900"
	ServicePlanId = "a23b959c-7ce8-4e57-9140-b90eb88a9e97"
}
Initialize-MgBetaOrganizationService -OrganizationId $organizationId -BodyParameter $params
```

This example shows how to use the Initialize-MgBetaOrganizationService Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1M0ZkruOrganizationIdMicrosoftGraphActivateservicePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Activate, ActivateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: ActivateViaIdentity, ActivateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OrganizationId
key: id of organization

```yaml
Type: System.String
Parameter Sets: Activate, ActivateExpanded
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

### -Service
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePlanId
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuId
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1M0ZkruOrganizationIdMicrosoftGraphActivateservicePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1M0ZkruOrganizationIdMicrosoftGraphActivateservicePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Service <String>]`: 
  - `[ServicePlanId <String>]`: 
  - `[SkuId <String>]`: 

INPUTOBJECT <IIdentityDirectoryManagementIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: id of administrativeUnit
  - `[AllowedValueId <String>]`: key: id of allowedValue
  - `[AttributeSetId <String>]`: key: id of attributeSet
  - `[CommandId <String>]`: key: id of command
  - `[ContractId <String>]`: key: id of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: key: id of customSecurityAttributeDefinition
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
  - `[IdentityProviderBaseId <String>]`: key: id of identityProviderBase
  - `[InboundSharedUserProfileUserId <String>]`: key: userId of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: key: id of internalDomainFederation
  - `[OnPremisesDirectorySynchronizationId <String>]`: key: id of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: key: id of orgContact
  - `[OrganizationId <String>]`: key: id of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: key: id of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: key: userId of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: key: id of profileCardProperty
  - `[RecommendationId <String>]`: key: id of recommendation
  - `[RecommendationResourceId <String>]`: key: id of recommendationResource
  - `[ScopedRoleMembershipId <String>]`: key: id of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: key: id of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: key: id of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: key: id of subscribedSku
  - `[TenantReferenceTenantId <String>]`: key: tenantId of tenantReference
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

