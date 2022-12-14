---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.directorymanagement/invoke-mgforcedomaindelete
schema: 2.0.0
---

# Invoke-MgBetaForceDomainDelete

## SYNOPSIS
Deletes a domain using an asynchronous operation.
Prior to calling forceDelete, you must update or remove any references to **Exchange** as the provisioning service.
The following actions are performed as part of this operation: After the domain deletion completes, API operations for the deleted domain will return a 404 HTTP response code.
To verify deletion of a domain, you can perform a get domain.
If the domain was successfully deleted, a 404 HTTP response code will be returned in the response.

## SYNTAX

### ForceExpanded (Default)
```
Invoke-MgBetaForceDomainDelete -DomainId <String> [-AdditionalProperties <Hashtable>] [-DisableUserAccounts]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Force
```
Invoke-MgBetaForceDomainDelete -DomainId <String>
 -BodyParameter <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForceViaIdentity
```
Invoke-MgBetaForceDomainDelete -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForceViaIdentityExpanded
```
Invoke-MgBetaForceDomainDelete -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-DisableUserAccounts] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Deletes a domain using an asynchronous operation.
Prior to calling forceDelete, you must update or remove any references to **Exchange** as the provisioning service.
The following actions are performed as part of this operation: After the domain deletion completes, API operations for the deleted domain will return a 404 HTTP response code.
To verify deletion of a domain, you can perform a get domain.
If the domain was successfully deleted, a 404 HTTP response code will be returned in the response.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaForceDomainDelete Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	DisableUserAccounts = $true
}
Invoke-MgBetaForceDomainDelete -DomainId $domainId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaForceDomainDelete Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ForceExpanded, ForceViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Force, ForceViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisableUserAccounts
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ForceExpanded, ForceViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainId
key: id of domain

```yaml
Type: System.String
Parameter Sets: Force, ForceExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: ForceViaIdentity, ForceViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisableUserAccounts <Boolean?>]`: 

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

