---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganization
schema: 2.0.0
---

# Update-MgOrganization

## SYNOPSIS
Update entity in organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganization -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-Branding <IMicrosoftGraphOrganizationalBranding>]
 [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]
 [-CertificateConnectorSetting <IMicrosoftGraphCertificateConnectorSetting>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DirectorySizeQuota <IMicrosoftGraphDirectorySizeQuota>] [-DisplayName <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsMultipleDataLocationsForServicesEnabled]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfile <IMicrosoftGraphPrivacyProfile>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-Settings <IMicrosoftGraphOrganizationSettings>]
 [-State <String>] [-Street <String>] [-TechnicalNotificationMails <String[]>]
 [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgOrganization -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganization1> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganization -InputObject <IIdentityDirectoryManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-Branding <IMicrosoftGraphOrganizationalBranding>]
 [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]
 [-CertificateConnectorSetting <IMicrosoftGraphCertificateConnectorSetting>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DirectorySizeQuota <IMicrosoftGraphDirectorySizeQuota>] [-DisplayName <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsMultipleDataLocationsForServicesEnabled]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfile <IMicrosoftGraphPrivacyProfile>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-Settings <IMicrosoftGraphOrganizationSettings>]
 [-State <String>] [-Street <String>] [-TechnicalNotificationMails <String[]>]
 [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganization -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrganization1> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update entity in organization

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedPlans
The collection of service plans associated with the tenant.
Not nullable.
To construct, see NOTES section for ASSIGNEDPLANS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAssignedPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The organization resource represents an instance of global settings and resources which operate and are provisioned at the tenant-level.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrganization1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Branding
organizationalBranding
To construct, see NOTES section for BRANDING properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrganizationalBranding
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessPhones
Telephone number for the organization.
NOTE: Although this is a string collection, only one number can be set for this property.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateBasedAuthConfiguration
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
To construct, see NOTES section for CERTIFICATEBASEDAUTHCONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphCertificateBasedAuthConfiguration[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateConnectorSetting
Certificate connector settings.
To construct, see NOTES section for CERTIFICATECONNECTORSETTING properties and create a hash table.

```yaml
Type: IMicrosoftGraphCertificateConnectorSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -City
City name of the address for the organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Country
Country/region name of the address for the organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountryLetterCode
Country/region abbreviation for the organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Timestamp of when the organization was created.
The value cannot be modified and is automatically populated when the organization is created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectorySizeQuota
directorySizeQuota
To construct, see NOTES section for DIRECTORYSIZEQUOTA properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectorySizeQuota
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the tenant.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the organization.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExtension[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsMultipleDataLocationsForServicesEnabled
true if organization is Multi-Geo enabled; false if organization is not Multi-Geo enabled; null (default).
Read-only.
For more information, see OneDrive Online Multi-Geo.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -MarketingNotificationEmails
Not nullable.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileDeviceManagementAuthority
mdmAuthority

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
The time and date at which the tenant was last synced with the on-premise directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationId
key: id of organization

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostalCode
Postal code of the address for the organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredLanguage
The preferred language for the organization.
Should follow ISO 639-1 Code; for example 'en'.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivacyProfile
privacyProfile
To construct, see NOTES section for PRIVACYPROFILE properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrivacyProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProvisionedPlans
Not nullable.
To construct, see NOTES section for PROVISIONEDPLANS properties and create a hash table.

```yaml
Type: IMicrosoftGraphProvisionedPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityComplianceNotificationMails
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityComplianceNotificationPhones
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
organizationSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrganizationSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
State name of the address for the organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Street
Street name of the address for organization.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TechnicalNotificationMails
Not nullable.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VerifiedDomains
The collection of domains associated with this tenant.
Not nullable.
To construct, see NOTES section for VERIFIEDDOMAINS properties and create a hash table.

```yaml
Type: IMicrosoftGraphVerifiedDomain[]
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganization1
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNEDPLANS \<IMicrosoftGraphAssignedPlan\[\]\>: The collection of service plans associated with the tenant.
Not nullable.
  \[AssignedDateTime \<DateTime?\>\]: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[CapabilityStatus \<String\>\]: For example, 'Enabled'.
  \[Service \<String\>\]: The name of the service; for example, 'Exchange'.
  \[ServicePlanId \<String\>\]: A GUID that identifies the service plan.

BODYPARAMETER \<IMicrosoftGraphOrganization\>: The organization resource represents an instance of global settings and resources which operate and are provisioned at the tenant-level.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeletedDateTime \<DateTime?\>\]: 
  \[Id \<String\>\]: Read-only.
  \[AssignedPlans \<IMicrosoftGraphAssignedPlan\[\]\>\]: The collection of service plans associated with the tenant.
Not nullable.
    \[AssignedDateTime \<DateTime?\>\]: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    \[CapabilityStatus \<String\>\]: For example, 'Enabled'.
    \[Service \<String\>\]: The name of the service; for example, 'Exchange'.
    \[ServicePlanId \<String\>\]: A GUID that identifies the service plan.
  \[BusinessPhones \<String\[\]\>\]: Telephone number for the organization.
NOTE: Although this is a string collection, only one number can be set for this property.
  \[CertificateBasedAuthConfiguration \<IMicrosoftGraphCertificateBasedAuthConfiguration\[\]\>\]: Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
    \[Id \<String\>\]: Read-only.
    \[CertificateAuthorities \<IMicrosoftGraphCertificateAuthority\[\]\>\]: Collection of certificate authorities which creates a trusted certificate chain.
      \[Certificate \<Byte\[\]\>\]: Required.
The base64 encoded string representing the public certificate.
      \[CertificateRevocationListUrl \<String\>\]: The URL of the certificate revocation list.
      \[DeltaCertificateRevocationListUrl \<String\>\]: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
      \[IsRootAuthority \<Boolean?\>\]: Required.
true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
      \[Issuer \<String\>\]: The issuer of the certificate, calculated from the certificate value.
Read-only.
      \[IssuerSki \<String\>\]: The subject key identifier of the certificate, calculated from the certificate value.
Read-only.
  \[City \<String\>\]: City name of the address for the organization.
  \[Country \<String\>\]: Country/region name of the address for the organization.
  \[CountryLetterCode \<String\>\]: Country/region abbreviation for the organization.
  \[CreatedDateTime \<DateTime?\>\]: Timestamp of when the organization was created.
The value cannot be modified and is automatically populated when the organization is created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.
  \[DisplayName \<String\>\]: The display name for the tenant.
  \[Extensions \<IMicrosoftGraphExtension\[\]\>\]: The collection of open extensions defined for the organization.
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
  \[MarketingNotificationEmails \<String\[\]\>\]: Not nullable.
  \[MobileDeviceManagementAuthority \<String\>\]: mdmAuthority
  \[OnPremisesLastSyncDateTime \<DateTime?\>\]: The time and date at which the tenant was last synced with the on-premise directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.
  \[OnPremisesSyncEnabled \<Boolean?\>\]: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
  \[PostalCode \<String\>\]: Postal code of the address for the organization.
  \[PreferredLanguage \<String\>\]: The preferred language for the organization.
Should follow ISO 639-1 Code; for example 'en'.
  \[PrivacyProfile \<IMicrosoftGraphPrivacyProfile\>\]: privacyProfile
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ContactEmail \<String\>\]: A valid smtp email address for the privacy statement contact.
Not required.
    \[StatementUrl \<String\>\]: A valid URL format that begins with http:// or https://.
Maximum length is 255 characters.
The URL that directs to the company's privacy statement.
Not required.
  \[ProvisionedPlans \<IMicrosoftGraphProvisionedPlan\[\]\>\]: Not nullable.
    \[CapabilityStatus \<String\>\]: For example, 'Enabled'.
    \[ProvisioningStatus \<String\>\]: For example, 'Success'.
    \[Service \<String\>\]: The name of the service; for example, 'AccessControlS2S'
  \[SecurityComplianceNotificationMails \<String\[\]\>\]: 
  \[SecurityComplianceNotificationPhones \<String\[\]\>\]: 
  \[State \<String\>\]: State name of the address for the organization.
  \[Street \<String\>\]: Street name of the address for organization.
  \[TechnicalNotificationMails \<String\[\]\>\]: Not nullable.
  \[TenantType \<String\>\]: 
  \[VerifiedDomains \<IMicrosoftGraphVerifiedDomain\[\]\>\]: The collection of domains associated with this tenant.
Not nullable.
    \[Capabilities \<String\>\]: For example, 'Email', 'OfficeCommunicationsOnline'.
    \[IsDefault \<Boolean?\>\]: true if this is the default domain associated with the tenant; otherwise, false.
    \[IsInitial \<Boolean?\>\]: true if this is the initial domain associated with the tenant; otherwise, false
    \[Name \<String\>\]: The domain name; for example, 'contoso.onmicrosoft.com'
    \[Type \<String\>\]: For example, 'Managed'.

CERTIFICATEBASEDAUTHCONFIGURATION \<IMicrosoftGraphCertificateBasedAuthConfiguration\[\]\>: Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
  \[Id \<String\>\]: Read-only.
  \[CertificateAuthorities \<IMicrosoftGraphCertificateAuthority\[\]\>\]: Collection of certificate authorities which creates a trusted certificate chain.
    \[Certificate \<Byte\[\]\>\]: Required.
The base64 encoded string representing the public certificate.
    \[CertificateRevocationListUrl \<String\>\]: The URL of the certificate revocation list.
    \[DeltaCertificateRevocationListUrl \<String\>\]: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
    \[IsRootAuthority \<Boolean?\>\]: Required.
true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
    \[Issuer \<String\>\]: The issuer of the certificate, calculated from the certificate value.
Read-only.
    \[IssuerSki \<String\>\]: The subject key identifier of the certificate, calculated from the certificate value.
Read-only.

EXTENSIONS \<IMicrosoftGraphExtension\[\]\>: The collection of open extensions defined for the organization.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.

INPUTOBJECT \<IIdentityDirectoryManagementIdentity\>: Identity Parameter
  \[AdministrativeUnitId \<String\>\]: key: id of administrativeUnit
  \[CommandId \<String\>\]: key: id of command
  \[ContractId \<String\>\]: key: id of contract
  \[DeviceId \<String\>\]: key: id of device
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[DirectoryRoleId \<String\>\]: key: id of directoryRole
  \[DirectoryRoleTemplateId \<String\>\]: key: id of directoryRoleTemplate
  \[DirectorySettingId \<String\>\]: key: id of directorySetting
  \[DirectorySettingTemplateId \<String\>\]: key: id of directorySettingTemplate
  \[DomainDnsRecordId \<String\>\]: key: id of domainDnsRecord
  \[DomainId \<String\>\]: key: id of domain
  \[ExtensionId \<String\>\]: key: id of extension
  \[FeatureRolloutPolicyId \<String\>\]: key: id of featureRolloutPolicy
  \[OrgContactId \<String\>\]: key: id of orgContact
  \[OrganizationId \<String\>\]: key: id of organization
  \[ProfileCardPropertyId \<String\>\]: key: id of profileCardProperty
  \[ScopedRoleMembershipId \<String\>\]: key: id of scopedRoleMembership
  \[SharedEmailDomainId \<String\>\]: key: id of sharedEmailDomain
  \[SharedEmailDomainInvitationId \<String\>\]: key: id of sharedEmailDomainInvitation
  \[SubscribedSkuId \<String\>\]: key: id of subscribedSku
  \[UserId \<String\>\]: key: id of user

PRIVACYPROFILE \<IMicrosoftGraphPrivacyProfile\>: privacyProfile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ContactEmail \<String\>\]: A valid smtp email address for the privacy statement contact.
Not required.
  \[StatementUrl \<String\>\]: A valid URL format that begins with http:// or https://.
Maximum length is 255 characters.
The URL that directs to the company's privacy statement.
Not required.

PROVISIONEDPLANS \<IMicrosoftGraphProvisionedPlan\[\]\>: Not nullable.
  \[CapabilityStatus \<String\>\]: For example, 'Enabled'.
  \[ProvisioningStatus \<String\>\]: For example, 'Success'.
  \[Service \<String\>\]: The name of the service; for example, 'AccessControlS2S'

VERIFIEDDOMAINS \<IMicrosoftGraphVerifiedDomain\[\]\>: The collection of domains associated with this tenant.
Not nullable.
  \[Capabilities \<String\>\]: For example, 'Email', 'OfficeCommunicationsOnline'.
  \[IsDefault \<Boolean?\>\]: true if this is the default domain associated with the tenant; otherwise, false.
  \[IsInitial \<Boolean?\>\]: true if this is the initial domain associated with the tenant; otherwise, false
  \[Name \<String\>\]: The domain name; for example, 'contoso.onmicrosoft.com'
  \[Type \<String\>\]: For example, 'Managed'.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganization](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganization)

## RELATED LINKS
