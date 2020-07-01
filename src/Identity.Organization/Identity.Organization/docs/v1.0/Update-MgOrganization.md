---
external help file:
Module Name: Microsoft.Graph.Identity.Organization
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.organization/update-mgorganization
schema: 2.0.0
---

# Update-MgOrganization

## SYNOPSIS
Update entity in organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganization -OrganizationId <String> [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>]
 [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DisplayName <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfileContactEmail <String>] [-PrivacyProfileStatementUrl <String>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-State <String>] [-Street <String>]
 [-TechnicalNotificationMails <String[]>] [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOrganization -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganization> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganization -InputObject <IIdentityOrganizationIdentity>
 -BodyParameter <IMicrosoftGraphOrganization> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganization -InputObject <IIdentityOrganizationIdentity>
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DisplayName <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfileContactEmail <String>] [-PrivacyProfileStatementUrl <String>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-State <String>] [-Street <String>]
 [-TechnicalNotificationMails <String[]>] [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in organization

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

### -AssignedPlans
The collection of service plans associated with the tenant.
Not nullable.
To construct, see NOTES section for ASSIGNEDPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAssignedPlan[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganization
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessPhones
Telephone number for the organization.
NOTE: Although this is a string collection, only one number can be set for this property.

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

### -CertificateBasedAuthConfiguration
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
To construct, see NOTES section for CERTIFICATEBASEDAUTHCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateBasedAuthConfiguration[]
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
Type: System.String
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
Type: System.String
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
Type: System.String
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
Type: System.DateTime
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
Type: System.DateTime
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityOrganizationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MarketingNotificationEmails
Not nullable.

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

### -MobileDeviceManagementAuthority
mdmAuthority

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

### -OnPremisesLastSyncDateTime
The time and date at which the tenant was last synced with the on-premise directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

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

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).

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

### -OrganizationId
key: organization-id of organization

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

### -PostalCode
Postal code of the address for the organization.

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

### -PreferredLanguage
The preferred language for the organization.
Should follow ISO 639-1 Code; for example 'en'.

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

### -PrivacyProfileContactEmail
A valid smtp email address for the privacy statement contact.
Not required.

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

### -PrivacyProfileStatementUrl
A valid URL format that begins with http:// or https://.
Maximum length is 255 characters.
The URL that directs to the company's privacy statement.
Not required.

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

### -ProvisionedPlans
Not nullable.
To construct, see NOTES section for PROVISIONEDPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisionedPlan[]
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
Type: System.String[]
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
Type: System.String[]
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
Type: System.String
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
Type: System.String
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
Type: System.String[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVerifiedDomain[]
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

### Microsoft.Graph.PowerShell.Models.IIdentityOrganizationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganization

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNEDPLANS <IMicrosoftGraphAssignedPlan[]>: The collection of service plans associated with the tenant. Not nullable.
  - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[CapabilityStatus <String>]`: For example, 'Enabled'.
  - `[Service <String>]`: The name of the service; for example, 'Exchange'.
  - `[ServicePlanId <String>]`: A GUID that identifies the service plan.

BODYPARAMETER <IMicrosoftGraphOrganization>: The organization resource represents an instance of global settings and resources which operate and are provisioned at the tenant-level.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AssignedPlans <IMicrosoftGraphAssignedPlan[]>]`: The collection of service plans associated with the tenant. Not nullable.
    - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[CapabilityStatus <String>]`: For example, 'Enabled'.
    - `[Service <String>]`: The name of the service; for example, 'Exchange'.
    - `[ServicePlanId <String>]`: A GUID that identifies the service plan.
  - `[BusinessPhones <String[]>]`: Telephone number for the organization. NOTE: Although this is a string collection, only one number can be set for this property.
  - `[CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]`: Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
    - `[Id <String>]`: Read-only.
    - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>]`: Collection of certificate authorities which creates a trusted certificate chain.
      - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
      - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
      - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
      - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
      - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
      - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.
  - `[City <String>]`: City name of the address for the organization.
  - `[Country <String>]`: Country/region name of the address for the organization.
  - `[CountryLetterCode <String>]`: Country/region abbreviation for the organization.
  - `[CreatedDateTime <DateTime?>]`: Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[DisplayName <String>]`: The display name for the tenant.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the organization. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[MarketingNotificationEmails <String[]>]`: Not nullable.
  - `[MobileDeviceManagementAuthority <String>]`: mdmAuthority
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: The time and date at which the tenant was last synced with the on-premise directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
  - `[PostalCode <String>]`: Postal code of the address for the organization.
  - `[PreferredLanguage <String>]`: The preferred language for the organization. Should follow ISO 639-1 Code; for example 'en'.
  - `[PrivacyProfileContactEmail <String>]`: A valid smtp email address for the privacy statement contact. Not required.
  - `[PrivacyProfileStatementUrl <String>]`: A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company's privacy statement. Not required.
  - `[ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]`: Not nullable.
    - `[CapabilityStatus <String>]`: For example, 'Enabled'.
    - `[ProvisioningStatus <String>]`: For example, 'Success'.
    - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'
  - `[SecurityComplianceNotificationMails <String[]>]`: 
  - `[SecurityComplianceNotificationPhones <String[]>]`: 
  - `[State <String>]`: State name of the address for the organization.
  - `[Street <String>]`: Street name of the address for organization.
  - `[TechnicalNotificationMails <String[]>]`: Not nullable.
  - `[VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>]`: The collection of domains associated with this tenant. Not nullable.
    - `[Capabilities <String>]`: For example, 'Email', 'OfficeCommunicationsOnline'.
    - `[IsDefault <Boolean?>]`: true if this is the default domain associated with the tenant; otherwise, false.
    - `[IsInitial <Boolean?>]`: true if this is the initial domain associated with the tenant; otherwise, false
    - `[Name <String>]`: The domain name; for example, 'contoso.onmicrosoft.com'
    - `[Type <String>]`: For example, 'Managed'.

CERTIFICATEBASEDAUTHCONFIGURATION <IMicrosoftGraphCertificateBasedAuthConfiguration[]>: Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
  - `[Id <String>]`: Read-only.
  - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>]`: Collection of certificate authorities which creates a trusted certificate chain.
    - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
    - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
    - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
    - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
    - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
    - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the organization. Read-only. Nullable.
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IIdentityOrganizationIdentity>: Identity Parameter
  - `[CertificateBasedAuthConfigurationId <String>]`: key: certificateBasedAuthConfiguration-id of certificateBasedAuthConfiguration
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[OrganizationId <String>]`: key: organization-id of organization
  - `[OrganizationalBrandingId <String>]`: key: organizationalBranding-id of organizationalBranding

PROVISIONEDPLANS <IMicrosoftGraphProvisionedPlan[]>: Not nullable.
  - `[CapabilityStatus <String>]`: For example, 'Enabled'.
  - `[ProvisioningStatus <String>]`: For example, 'Success'.
  - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'

VERIFIEDDOMAINS <IMicrosoftGraphVerifiedDomain[]>: The collection of domains associated with this tenant. Not nullable.
  - `[Capabilities <String>]`: For example, 'Email', 'OfficeCommunicationsOnline'.
  - `[IsDefault <Boolean?>]`: true if this is the default domain associated with the tenant; otherwise, false.
  - `[IsInitial <Boolean?>]`: true if this is the initial domain associated with the tenant; otherwise, false
  - `[Name <String>]`: The domain name; for example, 'contoso.onmicrosoft.com'
  - `[Type <String>]`: For example, 'Managed'.

## RELATED LINKS

