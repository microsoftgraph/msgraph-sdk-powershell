---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetacontact
schema: 2.0.0
---

# Update-MgBetaContact

## SYNOPSIS
Update entity in contacts

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaContact -OrgContactId <String> [-AdditionalProperties <Hashtable>]
 [-Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>] [-CompanyName <String>] [-DeletedDateTime <DateTime>]
 [-Department <String>] [-DirectReports <IMicrosoftGraphDirectoryObject[]>] [-DisplayName <String>]
 [-GivenName <String>] [-Id <String>] [-JobTitle <String>] [-Mail <String>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>] [-OnPremisesSyncEnabled]
 [-Phones <IMicrosoftGraphPhone[]>] [-ProxyAddresses <String[]>] [-ResponseHeadersVariable <String>]
 [-ServiceProvisioningErrors <IMicrosoftGraphServiceProvisioningError[]>] [-Surname <String>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-TransitiveReports <IMicrosoftGraphDirectoryObject[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaContact -OrgContactId <String> -BodyParameter <IMicrosoftGraphOrgContact>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaContact -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrgContact> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaContact -InputObject <IIdentityDirectoryManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>] [-CompanyName <String>] [-DeletedDateTime <DateTime>]
 [-Department <String>] [-DirectReports <IMicrosoftGraphDirectoryObject[]>] [-DisplayName <String>]
 [-GivenName <String>] [-Id <String>] [-JobTitle <String>] [-Mail <String>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>] [-OnPremisesSyncEnabled]
 [-Phones <IMicrosoftGraphPhone[]>] [-ProxyAddresses <String[]>] [-ResponseHeadersVariable <String>]
 [-ServiceProvisioningErrors <IMicrosoftGraphServiceProvisioningError[]>] [-Surname <String>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-TransitiveReports <IMicrosoftGraphDirectoryObject[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in contacts

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
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

### -Addresses
Postal addresses for this organizational contact.
For now a contact can only have one physical address.
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPhysicalOfficeAddress[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
orgContact
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOrgContact
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyName
Name of the company that this organizational contact belong to.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
The name for the department in which the contact works.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -DirectReports
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.) Read-only.
Nullable.
Supports $expand.
To construct, see NOTES section for DIRECTREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for this organizational contact.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values), $search, and $orderby.

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

### -GivenName
First name for this organizational contact.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -JobTitle
Job title for this organizational contact.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -Mail
The SMTP address for the contact, for example, 'jeff@contoso.com'.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -MailNickname
Email alias (portion of email address pre-pending the @ symbol) for this organizational contact.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).

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

### -Manager
directoryObject
To construct, see NOTES section for MANAGER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberOf
Groups that this contact is a member of.
Read-only.
Nullable.
Supports $expand.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
Date and time when this organizational contact was last synchronized from on-premises AD.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Supports $filter (eq, ne, not, ge, le, in).

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesProvisioningErrors
List of any synchronization provisioning errors for this organizational contact.
Supports $filter (eq, not for category and propertyCausingError), /$count eq 0, /$count ne 0.
To construct, see NOTES section for ONPREMISESPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesProvisioningError[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).
Supports $filter (eq, ne, not, in, and eq for null values).

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

### -OrgContactId
The unique identifier of orgContact

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

### -Phones
List of phones for this organizational contact.
Phone types can be mobile, business, and businessFax.
Only one of each type can ever be present in the collection.
Supports $filter (eq, ne, not, in).
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPhone[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAddresses
For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'.
The any operator is required for filter expressions on multi-valued properties.
Supports $filter (eq, not, ge, le, startsWith, /$count eq 0, /$count ne 0).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceProvisioningErrors
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from an orgContact object .
Supports $filter (eq, not, for isResolved and serviceInstance).
To construct, see NOTES section for SERVICEPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphServiceProvisioningError[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
Last name for this organizational contact.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values)

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

### -TransitiveMemberOf
.
To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveReports
The transitive reports for a contact.
Read-only.
To construct, see NOTES section for TRANSITIVEREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOrgContact

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOrgContact

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDRESSES <IMicrosoftGraphPhysicalOfficeAddress[]>`: Postal addresses for this organizational contact. For now a contact can only have one physical address.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

`BODYPARAMETER <IMicrosoftGraphOrgContact>`: orgContact
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>]`: Postal addresses for this organizational contact. For now a contact can only have one physical address.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[CompanyName <String>]`: Name of the company that this organizational contact belong to. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[Department <String>]`: The name for the department in which the contact works. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[DirectReports <IMicrosoftGraphDirectoryObject[]>]`: The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[DisplayName <String>]`: Display name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values), $search, and $orderby.
  - `[GivenName <String>]`: First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[JobTitle <String>]`: Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[Mail <String>]`: The SMTP address for the contact, for example, 'jeff@contoso.com'. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[MailNickname <String>]`: Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).
  - `[Manager <IMicrosoftGraphDirectoryObject>]`: directoryObject
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this contact is a member of. Read-only. Nullable. Supports $expand.
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).
  - `[OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]`: List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not for category and propertyCausingError), /$count eq 0, /$count ne 0.
    - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
    - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
    - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
    - `[Value <String>]`: Value of the property causing the error.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).  Supports $filter (eq, ne, not, in, and eq for null values).
  - `[Phones <IMicrosoftGraphPhone[]>]`: List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[ProxyAddresses <String[]>]`: For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith, /$count eq 0, /$count ne 0).
  - `[ServiceProvisioningErrors <IMicrosoftGraphServiceProvisioningError[]>]`: Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from an orgContact object .  Supports $filter (eq, not, for isResolved and serviceInstance).
    - `[CreatedDateTime <DateTime?>]`: The date and time at which the error occurred.
    - `[IsResolved <Boolean?>]`: Indicates whether the Error has been attended to.
    - `[ServiceInstance <String>]`: Qualified service instance (for example, 'SharePoint/Dublin') that published the service error information.
  - `[Surname <String>]`: Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values)
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[TransitiveReports <IMicrosoftGraphDirectoryObject[]>]`: The transitive reports for a contact. Read-only.

`DIRECTREPORTS <IMicrosoftGraphDirectoryObject[]>`: The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[CertificateAuthorityAsEntityId <String>]`: The unique identifier of certificateAuthorityAsEntity
  - `[CertificateBasedApplicationConfigurationId <String>]`: The unique identifier of certificateBasedApplicationConfiguration
  - `[CommandId <String>]`: The unique identifier of command
  - `[CommerceSubscriptionId <String>]`: Alternate key of companySubscription
  - `[CompanySubscriptionId <String>]`: The unique identifier of companySubscription
  - `[ContractId <String>]`: The unique identifier of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: The unique identifier of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DeviceLocalCredentialInfoId <String>]`: The unique identifier of deviceLocalCredentialInfo
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectoryRoleId <String>]`: The unique identifier of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: The unique identifier of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DirectorySettingTemplateId <String>]`: The unique identifier of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: The unique identifier of domainDnsRecord
  - `[DomainId <String>]`: The unique identifier of domain
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[ExternalUserProfileId <String>]`: The unique identifier of externalUserProfile
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[ImpactedResourceId <String>]`: The unique identifier of impactedResource
  - `[InboundSharedUserProfileUserId <String>]`: The unique identifier of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: The unique identifier of internalDomainFederation
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[OcpSubscriptionId <String>]`: Alternate key of companySubscription
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: The unique identifier of outboundSharedUserProfile
  - `[PendingExternalUserProfileId <String>]`: The unique identifier of pendingExternalUserProfile
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

`MANAGER <IMicrosoftGraphDirectoryObject>`: directoryObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`MEMBEROF <IMicrosoftGraphDirectoryObject[]>`: Groups that this contact is a member of. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`ONPREMISESPROVISIONINGERRORS <IMicrosoftGraphOnPremisesProvisioningError[]>`: List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not for category and propertyCausingError), /$count eq 0, /$count ne 0.
  - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
  - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
  - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
  - `[Value <String>]`: Value of the property causing the error.

`PHONES <IMicrosoftGraphPhone[]>`: List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection. Supports $filter (eq, ne, not, in).
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

`SERVICEPROVISIONINGERRORS <IMicrosoftGraphServiceProvisioningError[]>`: Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from an orgContact object . Supports $filter (eq, not, for isResolved and serviceInstance).
  - `[CreatedDateTime <DateTime?>]`: The date and time at which the error occurred.
  - `[IsResolved <Boolean?>]`: Indicates whether the Error has been attended to.
  - `[ServiceInstance <String>]`: Qualified service instance (for example, 'SharePoint/Dublin') that published the service error information.

`TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`TRANSITIVEREPORTS <IMicrosoftGraphDirectoryObject[]>`: The transitive reports for a contact. Read-only.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

## RELATED LINKS

