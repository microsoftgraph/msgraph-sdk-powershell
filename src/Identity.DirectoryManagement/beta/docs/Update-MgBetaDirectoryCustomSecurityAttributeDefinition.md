---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetadirectorycustomsecurityattributedefinition
schema: 2.0.0
---

# Update-MgBetaDirectoryCustomSecurityAttributeDefinition

## SYNOPSIS
Update the properties of a customSecurityAttributeDefinition object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedValues <IMicrosoftGraphAllowedValue[]>] [-AttributeSet <String>]
 [-Description <String>] [-Id <String>] [-IsCollection] [-IsSearchable] [-Name <String>] [-Status <String>]
 [-Type <String>] [-UsePreDefinedValuesOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId <String>
 -BodyParameter <IMicrosoftGraphCustomSecurityAttributeDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphCustomSecurityAttributeDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowedValues <IMicrosoftGraphAllowedValue[]>] [-AttributeSet <String>]
 [-Description <String>] [-Id <String>] [-IsCollection] [-IsSearchable] [-Name <String>] [-Status <String>]
 [-Type <String>] [-UsePreDefinedValuesOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a customSecurityAttributeDefinition object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	"AllowedValues@delta" = @(
	)
}
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Status = "Deprecated"
}
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params
```



### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Description = "Target completion date (YYYY/MM/DD)"
}
Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params
```



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

### -AllowedValues
Values that are predefined for this custom security attribute.
This navigation property is not returned by default and must be specified in an $expand query.
For example, /directory/customSecurityAttributeDefinitions$expand=allowedValues.
To construct, see NOTES section for ALLOWEDVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAllowedValue[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSet
Name of the attribute set.
Case insensitive.

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

### -BodyParameter
customSecurityAttributeDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CustomSecurityAttributeDefinitionId
The unique identifier of customSecurityAttributeDefinition

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

### -Description
Description of the custom security attribute.
Can be up to 128 characters long and include Unicode characters.
Can be changed later.

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

### -Id
The unique identifier for an entity.
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsCollection
Indicates whether multiple values can be assigned to the custom security attribute.
Cannot be changed later.
If type is set to Boolean, isCollection cannot be set to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSearchable
Indicates whether custom security attribute values are indexed for searching on objects that are assigned attribute values.
Cannot be changed later.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the custom security attribute.
Must be unique within an attribute set.
Can be up to 32 characters long and include Unicode characters.
Cannot contain spaces or special characters.
Cannot be changed later.
Case insensitive.

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

### -Status
Specifies whether the custom security attribute is active or deactivated.
Acceptable values are: Available and Deprecated.
Can be changed later.

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

### -Type
Data type for the custom security attribute values.
Supported types are: Boolean, Integer, and String.
Cannot be changed later.

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

### -UsePreDefinedValuesOnly
Indicates whether only predefined values can be assigned to the custom security attribute.
If set to false, free-form values are allowed.
Can later be changed from true to false, but cannot be changed from false to true.
If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALLOWEDVALUES <IMicrosoftGraphAllowedValue[]>`: Values that are predefined for this custom security attribute. This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions$expand=allowedValues.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.

`BODYPARAMETER <IMicrosoftGraphCustomSecurityAttributeDefinition>`: customSecurityAttributeDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute. This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.
  - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
  - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
  - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values are indexed for searching on objects that are assigned attribute values. Cannot be changed later.
  - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
  - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are: Available and Deprecated. Can be changed later.
  - `[Type <String>]`: Data type for the custom security attribute values. Supported types are: Boolean, Integer, and String. Cannot be changed later.
  - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[CertificateAuthorityAsEntityId <String>]`: The unique identifier of certificateAuthorityAsEntity
  - `[CertificateBasedApplicationConfigurationId <String>]`: The unique identifier of certificateBasedApplicationConfiguration
  - `[CommandId <String>]`: The unique identifier of command
  - `[CompanySubscriptionId <String>]`: The unique identifier of companySubscription
  - `[ContractId <String>]`: The unique identifier of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: The unique identifier of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectoryRoleId <String>]`: The unique identifier of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: The unique identifier of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DirectorySettingTemplateId <String>]`: The unique identifier of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: The unique identifier of domainDnsRecord
  - `[DomainId <String>]`: The unique identifier of domain
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[ImpactedResourceId <String>]`: The unique identifier of impactedResource
  - `[InboundSharedUserProfileUserId <String>]`: The unique identifier of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: The unique identifier of internalDomainFederation
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: The unique identifier of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: The unique identifier of profileCardProperty
  - `[RecommendationId <String>]`: The unique identifier of recommendation
  - `[RoleTemplateId <String>]`: Alternate key of directoryRole
  - `[ScopedRoleMembershipId <String>]`: The unique identifier of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: The unique identifier of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: The unique identifier of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: The unique identifier of subscribedSku
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantReferenceTenantId <String>]`: The unique identifier of tenantReference
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[UsageRightId <String>]`: The unique identifier of usageRight
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

