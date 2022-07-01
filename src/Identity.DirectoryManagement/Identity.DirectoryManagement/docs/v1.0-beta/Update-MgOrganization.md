---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganization
schema: 2.0.0
---

# Update-MgOrganization

## SYNOPSIS
Update organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganization -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-Branding <IMicrosoftGraphOrganizationalBranding1>]
 [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]
 [-CertificateConnectorSetting <IMicrosoftGraphCertificateConnectorSetting>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DirectorySizeQuota <IMicrosoftGraphDirectorySizeQuota>] [-DisplayName <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsMultipleDataLocationsForServicesEnabled]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <MdmAuthority>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfile <IMicrosoftGraphPrivacyProfile>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-Settings <IMicrosoftGraphOrganizationSettings>]
 [-State <String>] [-Street <String>] [-TechnicalNotificationMails <String[]>]
 [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOrganization -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganization> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganization -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrganization> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganization -InputObject <IIdentityDirectoryManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-Branding <IMicrosoftGraphOrganizationalBranding1>]
 [-BusinessPhones <String[]>]
 [-CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]
 [-CertificateConnectorSetting <IMicrosoftGraphCertificateConnectorSetting>] [-City <String>]
 [-Country <String>] [-CountryLetterCode <String>] [-CreatedDateTime <DateTime>] [-DeletedDateTime <DateTime>]
 [-DirectorySizeQuota <IMicrosoftGraphDirectorySizeQuota>] [-DisplayName <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsMultipleDataLocationsForServicesEnabled]
 [-MarketingNotificationEmails <String[]>] [-MobileDeviceManagementAuthority <MdmAuthority>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-PostalCode <String>]
 [-PreferredLanguage <String>] [-PrivacyProfile <IMicrosoftGraphPrivacyProfile>]
 [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>] [-SecurityComplianceNotificationMails <String[]>]
 [-SecurityComplianceNotificationPhones <String[]>] [-Settings <IMicrosoftGraphOrganizationSettings>]
 [-State <String>] [-Street <String>] [-TechnicalNotificationMails <String[]>]
 [-VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update organization

## EXAMPLES

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

### -AssignedPlans
The collection of service plans associated with the tenant.
Not nullable.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNEDPLANS properties and create a hash table.

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
organization
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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

### -Branding
organizationalBranding
To construct, please use Get-Help -Online and see NOTES section for BRANDING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding1
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
Although this is a string collection, only one number can be set for this property.

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
To construct, please use Get-Help -Online and see NOTES section for CERTIFICATEBASEDAUTHCONFIGURATION properties and create a hash table.

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

### -CertificateConnectorSetting
Certificate connector settings.
To construct, please use Get-Help -Online and see NOTES section for CERTIFICATECONNECTORSETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateConnectorSetting
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
Country or region abbreviation for the organization in ISO 3166-2 format.

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
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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

### -DirectorySizeQuota
directorySizeQuota
To construct, please use Get-Help -Online and see NOTES section for DIRECTORYSIZEQUOTA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySizeQuota
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
The collection of open extensions defined for the organization resource.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for EXTENSIONS properties and create a hash table.

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
.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Mobile device management authority.

```yaml
Type: Microsoft.Graph.PowerShell.Support.MdmAuthority
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
The time and date at which the tenant was last synced with the on-premises directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; Nullable.
null if this object has never been synced from an on-premises directory (default).

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
key: id of organization

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
Should follow ISO 639-1 Code; for example en.

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

### -PrivacyProfile
privacyProfile
To construct, please use Get-Help -Online and see NOTES section for PRIVACYPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivacyProfile
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
To construct, please use Get-Help -Online and see NOTES section for PROVISIONEDPLANS properties and create a hash table.

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

### -Settings
organizationSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationSettings
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
To construct, please use Get-Help -Online and see NOTES section for VERIFIEDDOMAINS properties and create a hash table.

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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganization

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNEDPLANS <IMicrosoftGraphAssignedPlan[]>: The collection of service plans associated with the tenant. Not nullable.
  - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CapabilityStatus <String>]`: Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut.
  - `[Service <String>]`: The name of the service; for example, exchange.
  - `[ServicePlanId <String>]`: A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.

BODYPARAMETER <IMicrosoftGraphOrganization>: organization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[AssignedPlans <IMicrosoftGraphAssignedPlan[]>]`: The collection of service plans associated with the tenant. Not nullable.
    - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned; for example: 2013-01-02T19:32:30Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CapabilityStatus <String>]`: Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut.
    - `[Service <String>]`: The name of the service; for example, exchange.
    - `[ServicePlanId <String>]`: A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.
  - `[Branding <IMicrosoftGraphOrganizationalBranding1>]`: organizationalBranding
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BackgroundColor <String>]`: Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
    - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
    - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
    - `[BannerLogoRelativeUrl <String>]`: A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
    - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
    - `[CustomAccountResetCredentialsUrl <String>]`: A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
    - `[CustomCannotAccessYourAccountText <String>]`: A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomCannotAccessYourAccountUrl <String>]`: A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.
    - `[CustomForgotMyPasswordText <String>]`: A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomPrivacyAndCookiesText <String>]`: A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomPrivacyAndCookiesUrl <String>]`: A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
    - `[CustomResetItNowText <String>]`: A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.
    - `[CustomTermsOfUseText <String>]`: A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomTermsOfUseUrl <String>]`: A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.
    - `[Favicon <Byte[]>]`: A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.
    - `[FaviconRelativeUrl <String>]`: A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[HeaderBackgroundColor <String>]`: The RGB color to apply to customize the color of the header.
    - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[HideAccountResetCredentials <Boolean?>]`: Option to hide the self-service password reset (SSPR) hyperlinks such as 'Can't access your account?', 'Forgot my password' and 'Reset it now' on the sign-in form.
      - `[HideCannotAccessYourAccount <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in form.
      - `[HideForgotMyPassword <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Forgot my password' hyperlink on the sign-in form.
      - `[HidePrivacyAndCookies <Boolean?>]`: Option to hide the 'Privacy & Cookies' hyperlink in the footer.
      - `[HideResetItNow <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'reset it now' hyperlink on the sign-in form.
      - `[HideTermsOfUse <Boolean?>]`: Option to hide the 'Terms of Use' hyperlink in the footer.
    - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.
    - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
    - `[SquareLogoRelativeUrl <String>]`: A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[UsernameHintText <String>]`: A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
    - `[Id <String>]`: 
    - `[Localizations <IMicrosoftGraphOrganizationalBrandingLocalization1[]>]`: Add different branding based on a locale.
      - `[BackgroundColor <String>]`: Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
      - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
      - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
      - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
      - `[BannerLogoRelativeUrl <String>]`: A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
      - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
      - `[CustomAccountResetCredentialsUrl <String>]`: A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
      - `[CustomCannotAccessYourAccountText <String>]`: A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.
      - `[CustomCannotAccessYourAccountUrl <String>]`: A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.
      - `[CustomForgotMyPasswordText <String>]`: A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.
      - `[CustomPrivacyAndCookiesText <String>]`: A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
      - `[CustomPrivacyAndCookiesUrl <String>]`: A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
      - `[CustomResetItNowText <String>]`: A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.
      - `[CustomTermsOfUseText <String>]`: A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
      - `[CustomTermsOfUseUrl <String>]`: A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.
      - `[Favicon <Byte[]>]`: A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.
      - `[FaviconRelativeUrl <String>]`: A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
      - `[HeaderBackgroundColor <String>]`: The RGB color to apply to customize the color of the header.
      - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
      - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.
      - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
      - `[SquareLogoRelativeUrl <String>]`: A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
      - `[UsernameHintText <String>]`: A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
      - `[Id <String>]`: 
  - `[BusinessPhones <String[]>]`: Telephone number for the organization. Although this is a string collection, only one number can be set for this property.
  - `[CertificateBasedAuthConfiguration <IMicrosoftGraphCertificateBasedAuthConfiguration[]>]`: Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
    - `[Id <String>]`: 
    - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>]`: Collection of certificate authorities which creates a trusted certificate chain.
      - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
      - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
      - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
      - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
      - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
      - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.
  - `[CertificateConnectorSetting <IMicrosoftGraphCertificateConnectorSetting>]`: Certificate connector settings.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertExpiryTime <DateTime?>]`: Certificate expire time
    - `[ConnectorVersion <String>]`: Version of certificate connector
    - `[EnrollmentError <String>]`: Certificate connector enrollment error
    - `[LastConnectorConnectionTime <DateTime?>]`: Last time certificate connector connected
    - `[LastUploadVersion <Int64?>]`: Version of last uploaded certificate connector
    - `[Status <Int32?>]`: Certificate connector status
  - `[City <String>]`: City name of the address for the organization.
  - `[Country <String>]`: Country/region name of the address for the organization.
  - `[CountryLetterCode <String>]`: Country or region abbreviation for the organization in ISO 3166-2 format.
  - `[CreatedDateTime <DateTime?>]`: Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DirectorySizeQuota <IMicrosoftGraphDirectorySizeQuota>]`: directorySizeQuota
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Total <Int32?>]`: Total amount of the directory quota.
    - `[Used <Int32?>]`: Used amount of the directory quota.
  - `[DisplayName <String>]`: The display name for the tenant.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the organization resource. Nullable.
    - `[Id <String>]`: 
  - `[IsMultipleDataLocationsForServicesEnabled <Boolean?>]`: true if organization is Multi-Geo enabled; false if organization is not Multi-Geo enabled; null (default). Read-only. For more information, see OneDrive Online Multi-Geo.
  - `[MarketingNotificationEmails <String[]>]`: Not nullable.
  - `[MobileDeviceManagementAuthority <MdmAuthority?>]`: Mobile device management authority.
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; Nullable. null if this object has never been synced from an on-premises directory (default).
  - `[PostalCode <String>]`: Postal code of the address for the organization.
  - `[PreferredLanguage <String>]`: The preferred language for the organization. Should follow ISO 639-1 Code; for example en.
  - `[PrivacyProfile <IMicrosoftGraphPrivacyProfile>]`: privacyProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContactEmail <String>]`: A valid smtp email address for the privacy statement contact. Not required.
    - `[StatementUrl <String>]`: A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company's privacy statement. Not required.
  - `[ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]`: Not nullable.
    - `[CapabilityStatus <String>]`: For example, 'Enabled'.
    - `[ProvisioningStatus <String>]`: For example, 'Success'.
    - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'
  - `[SecurityComplianceNotificationMails <String[]>]`: 
  - `[SecurityComplianceNotificationPhones <String[]>]`: 
  - `[Settings <IMicrosoftGraphOrganizationSettings>]`: organizationSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ItemInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.
      - `[IsEnabledInOrganization <Boolean?>]`: true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.
    - `[MicrosoftApplicationDataAccess <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>]`: microsoftApplicationDataAccessSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.
      - `[IsEnabledForAllMicrosoftApplications <Boolean?>]`: When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.
    - `[PeopleInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
    - `[ProfileCardProperties <IMicrosoftGraphProfileCardProperty[]>]`: Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.
      - `[Id <String>]`: 
      - `[Annotations <IMicrosoftGraphProfileCardAnnotation[]>]`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
        - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
        - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
          - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
          - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
      - `[DirectoryPropertyName <String>]`: Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.
  - `[State <String>]`: State name of the address for the organization.
  - `[Street <String>]`: Street name of the address for organization.
  - `[TechnicalNotificationMails <String[]>]`: Not nullable.
  - `[VerifiedDomains <IMicrosoftGraphVerifiedDomain[]>]`: The collection of domains associated with this tenant. Not nullable.
    - `[Capabilities <String>]`: For example, Email, OfficeCommunicationsOnline.
    - `[IsDefault <Boolean?>]`: true if this is the default domain associated with the tenant; otherwise, false.
    - `[IsInitial <Boolean?>]`: true if this is the initial domain associated with the tenant; otherwise, false.
    - `[Name <String>]`: The domain name; for example, contoso.onmicrosoft.com.
    - `[Type <String>]`: For example, Managed.

BRANDING <IMicrosoftGraphOrganizationalBranding1>: organizationalBranding
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BackgroundColor <String>]`: Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
  - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
  - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
  - `[BannerLogoRelativeUrl <String>]`: A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
  - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
  - `[CustomAccountResetCredentialsUrl <String>]`: A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
  - `[CustomCannotAccessYourAccountText <String>]`: A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.
  - `[CustomCannotAccessYourAccountUrl <String>]`: A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.
  - `[CustomForgotMyPasswordText <String>]`: A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.
  - `[CustomPrivacyAndCookiesText <String>]`: A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
  - `[CustomPrivacyAndCookiesUrl <String>]`: A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
  - `[CustomResetItNowText <String>]`: A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.
  - `[CustomTermsOfUseText <String>]`: A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
  - `[CustomTermsOfUseUrl <String>]`: A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.
  - `[Favicon <Byte[]>]`: A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.
  - `[FaviconRelativeUrl <String>]`: A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[HeaderBackgroundColor <String>]`: The RGB color to apply to customize the color of the header.
  - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HideAccountResetCredentials <Boolean?>]`: Option to hide the self-service password reset (SSPR) hyperlinks such as 'Can't access your account?', 'Forgot my password' and 'Reset it now' on the sign-in form.
    - `[HideCannotAccessYourAccount <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in form.
    - `[HideForgotMyPassword <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Forgot my password' hyperlink on the sign-in form.
    - `[HidePrivacyAndCookies <Boolean?>]`: Option to hide the 'Privacy & Cookies' hyperlink in the footer.
    - `[HideResetItNow <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'reset it now' hyperlink on the sign-in form.
    - `[HideTermsOfUse <Boolean?>]`: Option to hide the 'Terms of Use' hyperlink in the footer.
  - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.
  - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
  - `[SquareLogoRelativeUrl <String>]`: A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[UsernameHintText <String>]`: A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
  - `[Id <String>]`: 
  - `[Localizations <IMicrosoftGraphOrganizationalBrandingLocalization1[]>]`: Add different branding based on a locale.
    - `[BackgroundColor <String>]`: Color that appears in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
    - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
    - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG not larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
    - `[BannerLogoRelativeUrl <String>]`: A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
    - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
    - `[CustomAccountResetCredentialsUrl <String>]`: A custom URL for resetting account credentials. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
    - `[CustomCannotAccessYourAccountText <String>]`: A string to replace the default 'Can't access your account?' self-service password reset (SSPR) hyperlink text on the sign-in page. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomCannotAccessYourAccountUrl <String>]`: A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in page. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters. DO NOT USE. Use customAccountResetCredentialsUrl instead.
    - `[CustomForgotMyPasswordText <String>]`: A string to replace the default 'Forgot my password' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomPrivacyAndCookiesText <String>]`: A string to replace the default 'Privacy and Cookies' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomPrivacyAndCookiesUrl <String>]`: A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
    - `[CustomResetItNowText <String>]`: A string to replace the default 'reset it now' hyperlink text on the sign-in form. This text must be in Unicode format and not exceed 256 characters. DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.
    - `[CustomTermsOfUseText <String>]`: A string to replace the the default 'Terms of Use' hyperlink text in the footer. This text must be in Unicode format and not exceed 256 characters.
    - `[CustomTermsOfUseUrl <String>]`: A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer. This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.
    - `[Favicon <Byte[]>]`: A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.
    - `[FaviconRelativeUrl <String>]`: A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[HeaderBackgroundColor <String>]`: The RGB color to apply to customize the color of the header.
    - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
    - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. Use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be in Unicode format and not exceed 1024 characters.
    - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
    - `[SquareLogoRelativeUrl <String>]`: A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[UsernameHintText <String>]`: A string that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
    - `[Id <String>]`: 

CERTIFICATEBASEDAUTHCONFIGURATION <IMicrosoftGraphCertificateBasedAuthConfiguration[]>: Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
  - `[Id <String>]`: 
  - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>]`: Collection of certificate authorities which creates a trusted certificate chain.
    - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
    - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
    - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
    - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
    - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
    - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.

CERTIFICATECONNECTORSETTING <IMicrosoftGraphCertificateConnectorSetting>: Certificate connector settings.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertExpiryTime <DateTime?>]`: Certificate expire time
  - `[ConnectorVersion <String>]`: Version of certificate connector
  - `[EnrollmentError <String>]`: Certificate connector enrollment error
  - `[LastConnectorConnectionTime <DateTime?>]`: Last time certificate connector connected
  - `[LastUploadVersion <Int64?>]`: Version of last uploaded certificate connector
  - `[Status <Int32?>]`: Certificate connector status

DIRECTORYSIZEQUOTA <IMicrosoftGraphDirectorySizeQuota>: directorySizeQuota
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Total <Int32?>]`: Total amount of the directory quota.
  - `[Used <Int32?>]`: Used amount of the directory quota.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the organization resource. Nullable.
  - `[Id <String>]`: 

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

PRIVACYPROFILE <IMicrosoftGraphPrivacyProfile>: privacyProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContactEmail <String>]`: A valid smtp email address for the privacy statement contact. Not required.
  - `[StatementUrl <String>]`: A valid URL format that begins with http:// or https://. Maximum length is 255 characters. The URL that directs to the company's privacy statement. Not required.

PROVISIONEDPLANS <IMicrosoftGraphProvisionedPlan[]>: Not nullable.
  - `[CapabilityStatus <String>]`: For example, 'Enabled'.
  - `[ProvisioningStatus <String>]`: For example, 'Success'.
  - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'

SETTINGS <IMicrosoftGraphOrganizationSettings>: organizationSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ItemInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.
    - `[IsEnabledInOrganization <Boolean?>]`: true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.
  - `[MicrosoftApplicationDataAccess <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>]`: microsoftApplicationDataAccessSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.
    - `[IsEnabledForAllMicrosoftApplications <Boolean?>]`: When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.
  - `[PeopleInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
  - `[ProfileCardProperties <IMicrosoftGraphProfileCardProperty[]>]`: Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.
    - `[Id <String>]`: 
    - `[Annotations <IMicrosoftGraphProfileCardAnnotation[]>]`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
      - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
      - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
        - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
        - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
    - `[DirectoryPropertyName <String>]`: Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.

VERIFIEDDOMAINS <IMicrosoftGraphVerifiedDomain[]>: The collection of domains associated with this tenant. Not nullable.
  - `[Capabilities <String>]`: For example, Email, OfficeCommunicationsOnline.
  - `[IsDefault <Boolean?>]`: true if this is the default domain associated with the tenant; otherwise, false.
  - `[IsInitial <Boolean?>]`: true if this is the initial domain associated with the tenant; otherwise, false.
  - `[Name <String>]`: The domain name; for example, contoso.onmicrosoft.com.
  - `[Type <String>]`: For example, Managed.

## RELATED LINKS

