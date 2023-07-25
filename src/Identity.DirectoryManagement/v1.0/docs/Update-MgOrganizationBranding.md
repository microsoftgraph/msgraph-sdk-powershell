---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganizationbranding
schema: 2.0.0
---

# Update-MgOrganizationBranding

## SYNOPSIS
Update the properties of the default branding object specified by the organizationalBranding resource.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganizationBranding -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-BackgroundColor <String>] [-BackgroundImageInputFile <String>] [-BackgroundImageRelativeUrl <String>]
 [-BannerLogoInputFile <String>] [-BannerLogoRelativeUrl <String>] [-CdnList <String[]>]
 [-CustomAccountResetCredentialsUrl <String>] [-CustomCannotAccessYourAccountText <String>]
 [-CustomCannotAccessYourAccountUrl <String>] [-CustomCssInputFile <String>] [-CustomCssRelativeUrl <String>]
 [-CustomForgotMyPasswordText <String>] [-CustomPrivacyAndCookiesText <String>]
 [-CustomPrivacyAndCookiesUrl <String>] [-CustomResetItNowText <String>] [-CustomTermsOfUseText <String>]
 [-CustomTermsOfUseUrl <String>] [-FaviconInputFile <String>] [-FaviconRelativeUrl <String>]
 [-HeaderBackgroundColor <String>] [-HeaderLogoInputFile <String>] [-HeaderLogoRelativeUrl <String>]
 [-Id <String>] [-Localizations <IMicrosoftGraphOrganizationalBrandingLocalization[]>]
 [-LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]
 [-LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]
 [-SignInPageText <String>] [-SquareLogoDarkInputFile <String>] [-SquareLogoDarkRelativeUrl <String>]
 [-SquareLogoInputFile <String>] [-SquareLogoRelativeUrl <String>] [-UsernameHintText <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOrganizationBranding -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganizationalBranding>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganizationBranding -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrganizationalBranding> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganizationBranding -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-BackgroundColor <String>] [-BackgroundImageInputFile <String>]
 [-BackgroundImageRelativeUrl <String>] [-BannerLogoInputFile <String>] [-BannerLogoRelativeUrl <String>]
 [-CdnList <String[]>] [-CustomAccountResetCredentialsUrl <String>]
 [-CustomCannotAccessYourAccountText <String>] [-CustomCannotAccessYourAccountUrl <String>]
 [-CustomCssInputFile <String>] [-CustomCssRelativeUrl <String>] [-CustomForgotMyPasswordText <String>]
 [-CustomPrivacyAndCookiesText <String>] [-CustomPrivacyAndCookiesUrl <String>]
 [-CustomResetItNowText <String>] [-CustomTermsOfUseText <String>] [-CustomTermsOfUseUrl <String>]
 [-FaviconInputFile <String>] [-FaviconRelativeUrl <String>] [-HeaderBackgroundColor <String>]
 [-HeaderLogoInputFile <String>] [-HeaderLogoRelativeUrl <String>] [-Id <String>]
 [-Localizations <IMicrosoftGraphOrganizationalBrandingLocalization[]>]
 [-LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]
 [-LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]
 [-SignInPageText <String>] [-SquareLogoDarkInputFile <String>] [-SquareLogoDarkRelativeUrl <String>]
 [-SquareLogoInputFile <String>] [-SquareLogoRelativeUrl <String>] [-UsernameHintText <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of the default branding object specified by the organizationalBranding resource.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
```

$params = @{
	signInPageText = "Default"
	usernameHintText = "DefaultHint"
}

Update-MgOrganizationBranding -OrganizationId $organizationId -BodyParameter $params

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

### -BackgroundColor
Color that will appear in place of the background image in low-bandwidth connections.
We recommend that you use the primary color of your banner logo or your organization color.
Specify this in hexadecimal format, for example, white is #FFFFFF.

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

### -BackgroundImageInputFile
Input File for BackgroundImage (Image that appears as the background of the sign-in page.
The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels.
A smaller image will reduce bandwidth requirements and make the page load faster.)

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

### -BackgroundImageRelativeUrl
A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
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

### -BannerLogoInputFile
Input File for BannerLogo (A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG no larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.)

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

### -BannerLogoRelativeUrl
A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN.
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

### -BodyParameter
organizationalBranding
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CdnList
A list of base URLs for all available CDN providers that are serving the assets of the current resource.
Several CDN providers are used at the same time for high availability of read requests.
Read-only.

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

### -CustomAccountResetCredentialsUrl
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

### -CustomCannotAccessYourAccountText
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

### -CustomCannotAccessYourAccountUrl
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

### -CustomCssInputFile
Input File for CustomCss (.)

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

### -CustomCssRelativeUrl
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

### -CustomForgotMyPasswordText
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

### -CustomPrivacyAndCookiesText
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

### -CustomPrivacyAndCookiesUrl
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

### -CustomResetItNowText
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

### -CustomTermsOfUseText
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

### -CustomTermsOfUseUrl
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

### -FaviconInputFile
Input File for Favicon (.)

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

### -FaviconRelativeUrl
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

### -HeaderBackgroundColor
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

### -HeaderLogoInputFile
Input File for HeaderLogo (.)

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

### -HeaderLogoRelativeUrl
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

### -Id
The unique idenfier for an entity.
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Localizations
Add different branding based on a locale.
To construct, see NOTES section for LOCALIZATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBrandingLocalization[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoginPageLayoutConfiguration
loginPageLayoutConfiguration
To construct, see NOTES section for LOGINPAGELAYOUTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLoginPageLayoutConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoginPageTextVisibilitySettings
loginPageTextVisibilitySettings
To construct, see NOTES section for LOGINPAGETEXTVISIBILITYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLoginPageTextVisibilitySettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationId
The unique identifier of organization

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

### -SignInPageText
Text that appears at the bottom of the sign-in box.
You can use this to communicate additional information, such as the phone number to your help desk or a legal statement.
This text must be Unicode and not exceed 1024 characters.

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

### -SquareLogoDarkInputFile
Input File for SquareLogoDark (.)

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

### -SquareLogoDarkRelativeUrl
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

### -SquareLogoInputFile
Input File for SquareLogo (A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.)

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

### -SquareLogoRelativeUrl
A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
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

### -UsernameHintText
String that shows as the hint in the username textbox on the sign-in screen.
This text must be a Unicode, without links or code, and can't exceed 64 characters.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphOrganizationalBranding>`: organizationalBranding
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BackgroundColor <String>]`: Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
  - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
  - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
  - `[BannerLogoRelativeUrl <String>]`: A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
  - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
  - `[CustomAccountResetCredentialsUrl <String>]`: 
  - `[CustomCannotAccessYourAccountText <String>]`: 
  - `[CustomCannotAccessYourAccountUrl <String>]`: 
  - `[CustomCss <Byte[]>]`: 
  - `[CustomCssRelativeUrl <String>]`: 
  - `[CustomForgotMyPasswordText <String>]`: 
  - `[CustomPrivacyAndCookiesText <String>]`: 
  - `[CustomPrivacyAndCookiesUrl <String>]`: 
  - `[CustomResetItNowText <String>]`: 
  - `[CustomTermsOfUseText <String>]`: 
  - `[CustomTermsOfUseUrl <String>]`: 
  - `[Favicon <Byte[]>]`: 
  - `[FaviconRelativeUrl <String>]`: 
  - `[HeaderBackgroundColor <String>]`: 
  - `[HeaderLogo <Byte[]>]`: 
  - `[HeaderLogoRelativeUrl <String>]`: 
  - `[LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]`: loginPageLayoutConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsFooterShown <Boolean?>]`: 
    - `[IsHeaderShown <Boolean?>]`: 
    - `[LayoutTemplateType <String>]`: layoutTemplateType
  - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HideAccountResetCredentials <Boolean?>]`: 
    - `[HideCannotAccessYourAccount <Boolean?>]`: 
    - `[HideForgotMyPassword <Boolean?>]`: 
    - `[HidePrivacyAndCookies <Boolean?>]`: 
    - `[HideResetItNow <Boolean?>]`: 
    - `[HideTermsOfUse <Boolean?>]`: 
  - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.
  - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
  - `[SquareLogoDark <Byte[]>]`: 
  - `[SquareLogoDarkRelativeUrl <String>]`: 
  - `[SquareLogoRelativeUrl <String>]`: A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[UsernameHintText <String>]`: String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Localizations <IMicrosoftGraphOrganizationalBrandingLocalization[]>]`: Add different branding based on a locale.
    - `[BackgroundColor <String>]`: Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
    - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
    - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
    - `[BannerLogoRelativeUrl <String>]`: A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
    - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
    - `[CustomAccountResetCredentialsUrl <String>]`: 
    - `[CustomCannotAccessYourAccountText <String>]`: 
    - `[CustomCannotAccessYourAccountUrl <String>]`: 
    - `[CustomCss <Byte[]>]`: 
    - `[CustomCssRelativeUrl <String>]`: 
    - `[CustomForgotMyPasswordText <String>]`: 
    - `[CustomPrivacyAndCookiesText <String>]`: 
    - `[CustomPrivacyAndCookiesUrl <String>]`: 
    - `[CustomResetItNowText <String>]`: 
    - `[CustomTermsOfUseText <String>]`: 
    - `[CustomTermsOfUseUrl <String>]`: 
    - `[Favicon <Byte[]>]`: 
    - `[FaviconRelativeUrl <String>]`: 
    - `[HeaderBackgroundColor <String>]`: 
    - `[HeaderLogo <Byte[]>]`: 
    - `[HeaderLogoRelativeUrl <String>]`: 
    - `[LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]`: loginPageLayoutConfiguration
    - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
    - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.
    - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
    - `[SquareLogoDark <Byte[]>]`: 
    - `[SquareLogoDarkRelativeUrl <String>]`: 
    - `[SquareLogoRelativeUrl <String>]`: A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
    - `[UsernameHintText <String>]`: String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[ContractId <String>]`: The unique identifier of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: The unique identifier of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectoryRoleId <String>]`: The unique identifier of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: The unique identifier of directoryRoleTemplate
  - `[DomainDnsRecordId <String>]`: The unique identifier of domainDnsRecord
  - `[DomainId <String>]`: The unique identifier of domain
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[InternalDomainFederationId <String>]`: The unique identifier of internalDomainFederation
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[RoleTemplateId <String>]`: Alternate key of directoryRole
  - `[ScopedRoleMembershipId <String>]`: The unique identifier of scopedRoleMembership
  - `[SubscribedSkuId <String>]`: The unique identifier of subscribedSku
  - `[UserId <String>]`: The unique identifier of user

`LOCALIZATIONS <IMicrosoftGraphOrganizationalBrandingLocalization[]>`: Add different branding based on a locale.
  - `[BackgroundColor <String>]`: Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.
  - `[BackgroundImage <Byte[]>]`: Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.
  - `[BackgroundImageRelativeUrl <String>]`: A relative URL for the backgroundImage property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[BannerLogo <Byte[]>]`: A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.
  - `[BannerLogoRelativeUrl <String>]`: A relative url for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN. Read-only.
  - `[CdnList <String[]>]`: A list of base URLs for all available CDN providers that are serving the assets of the current resource. Several CDN providers are used at the same time for high availability of read requests. Read-only.
  - `[CustomAccountResetCredentialsUrl <String>]`: 
  - `[CustomCannotAccessYourAccountText <String>]`: 
  - `[CustomCannotAccessYourAccountUrl <String>]`: 
  - `[CustomCss <Byte[]>]`: 
  - `[CustomCssRelativeUrl <String>]`: 
  - `[CustomForgotMyPasswordText <String>]`: 
  - `[CustomPrivacyAndCookiesText <String>]`: 
  - `[CustomPrivacyAndCookiesUrl <String>]`: 
  - `[CustomResetItNowText <String>]`: 
  - `[CustomTermsOfUseText <String>]`: 
  - `[CustomTermsOfUseUrl <String>]`: 
  - `[Favicon <Byte[]>]`: 
  - `[FaviconRelativeUrl <String>]`: 
  - `[HeaderBackgroundColor <String>]`: 
  - `[HeaderLogo <Byte[]>]`: 
  - `[HeaderLogoRelativeUrl <String>]`: 
  - `[LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]`: loginPageLayoutConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsFooterShown <Boolean?>]`: 
    - `[IsHeaderShown <Boolean?>]`: 
    - `[LayoutTemplateType <String>]`: layoutTemplateType
  - `[LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]`: loginPageTextVisibilitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HideAccountResetCredentials <Boolean?>]`: 
    - `[HideCannotAccessYourAccount <Boolean?>]`: 
    - `[HideForgotMyPassword <Boolean?>]`: 
    - `[HidePrivacyAndCookies <Boolean?>]`: 
    - `[HideResetItNow <Boolean?>]`: 
    - `[HideTermsOfUse <Boolean?>]`: 
  - `[SignInPageText <String>]`: Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.
  - `[SquareLogo <Byte[]>]`: A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.
  - `[SquareLogoDark <Byte[]>]`: 
  - `[SquareLogoDarkRelativeUrl <String>]`: 
  - `[SquareLogoRelativeUrl <String>]`: A relative url for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN. Read-only.
  - `[UsernameHintText <String>]`: String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`LOGINPAGELAYOUTCONFIGURATION <IMicrosoftGraphLoginPageLayoutConfiguration>`: loginPageLayoutConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsFooterShown <Boolean?>]`: 
  - `[IsHeaderShown <Boolean?>]`: 
  - `[LayoutTemplateType <String>]`: layoutTemplateType

`LOGINPAGETEXTVISIBILITYSETTINGS <IMicrosoftGraphLoginPageTextVisibilitySettings>`: loginPageTextVisibilitySettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HideAccountResetCredentials <Boolean?>]`: 
  - `[HideCannotAccessYourAccount <Boolean?>]`: 
  - `[HideForgotMyPassword <Boolean?>]`: 
  - `[HidePrivacyAndCookies <Boolean?>]`: 
  - `[HideResetItNow <Boolean?>]`: 
  - `[HideTermsOfUse <Boolean?>]`: 

## RELATED LINKS

