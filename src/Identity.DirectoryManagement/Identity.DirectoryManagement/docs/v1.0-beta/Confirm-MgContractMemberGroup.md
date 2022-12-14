---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.directorymanagement/confirm-mgcontractmembergroup
schema: 2.0.0
---

# Confirm-MgBetaContractMemberGroup

## SYNOPSIS
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

## SYNTAX

### CheckExpanded1 (Default)
```
Confirm-MgBetaContractMemberGroup -ContractId <String> [-AdditionalProperties <Hashtable>] [-GroupIds <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Check1
```
Confirm-MgBetaContractMemberGroup -ContractId <String>
 -BodyParameter <IPaths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity1
```
Confirm-MgBetaContractMemberGroup -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IPaths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded1
```
Confirm-MgBetaContractMemberGroup -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

## EXAMPLES

### Example 1: Check group memberships for a directory object
```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects

$params = @{
	GroupIds = @(
		"f448435d-3ca7-4073-8152-a1fd73c0fd09"
		"bd7c6263-4dd5-4ae8-8c96-556e1c0bece6"
		"93670da6-d731-4366-94b5-abed40b6016b"
		"f5484ab1-4d4d-41ec-a9b8-754b3957bfc7"
		"c9103f26-f3cf-4004-a611-2a14e81b8f79"
	)
}

Confirm-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```

This example shows how to use the Confirm-MgBetaContractMemberGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Check group memberships for the signed-in user
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	GroupIds = @(
		"fee2c45b-915a-4a64b130f4eb9e75525e"
		"4fe90ae065a-478b9400e0a0e1cbd540"
	)
}

# A UPN can also be used as -UserId.
Confirm-MgBetaUserMemberGroup -UserId $userId -BodyParameter $params
```

This example shows how to use the Confirm-MgBetaContractMemberGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Check1, CheckViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContractId
key: id of contract

```yaml
Type: System.String
Parameter Sets: Check1, CheckExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupIds
.

```yaml
Type: System.String[]
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
Aliases:

Required: False
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
Parameter Sets: CheckViaIdentity1, CheckViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths30M7S8ContractsContractIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[GroupIds <String[]>]`: 

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

