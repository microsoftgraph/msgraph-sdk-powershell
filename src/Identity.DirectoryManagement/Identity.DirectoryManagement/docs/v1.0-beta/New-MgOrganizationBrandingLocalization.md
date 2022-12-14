---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgorganizationbrandinglocalization
schema: 2.0.0
---

# New-MgOrganizationBrandingLocalization

## SYNOPSIS
Create a new organizationalBrandingLocalization object.
This creates a localized branding and at the same time, the default branding if it doesn't exist.
The default branding is created only once.
It's loaded when a localized branding isn't configured for the user's browser language.
To retrieve the default branding, see Get branding.

## SYNTAX

### CreateExpanded (Default)
```
New-MgOrganizationBrandingLocalization -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-BackgroundColor <String>] [-BackgroundImageInputFile <String>] [-BackgroundImageRelativeUrl <String>]
 [-BannerLogoInputFile <String>] [-BannerLogoRelativeUrl <String>] [-CdnList <String[]>]
 [-CustomAccountResetCredentialsUrl <String>] [-CustomCannotAccessYourAccountText <String>]
 [-CustomCannotAccessYourAccountUrl <String>] [-CustomCssInputFile <String>] [-CustomCssRelativeUrl <String>]
 [-CustomForgotMyPasswordText <String>] [-CustomPrivacyAndCookiesText <String>]
 [-CustomPrivacyAndCookiesUrl <String>] [-CustomResetItNowText <String>] [-CustomTermsOfUseText <String>]
 [-CustomTermsOfUseUrl <String>] [-FaviconInputFile <String>] [-FaviconRelativeUrl <String>]
 [-HeaderBackgroundColor <String>] [-HeaderLogoInputFile <String>] [-HeaderLogoRelativeUrl <String>]
 [-Id <String>] [-LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]
 [-LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]
 [-SignInPageText <String>] [-SquareLogoDarkInputFile <String>] [-SquareLogoDarkRelativeUrl <String>]
 [-SquareLogoInputFile <String>] [-SquareLogoRelativeUrl <String>] [-UsernameHintText <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOrganizationBrandingLocalization -OrganizationId <String> -BodyParameter <Hashtable> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOrganizationBrandingLocalization -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOrganizationBrandingLocalization -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-BackgroundColor <String>] [-BackgroundImageInputFile <String>]
 [-BackgroundImageRelativeUrl <String>] [-BannerLogoInputFile <String>] [-BannerLogoRelativeUrl <String>]
 [-CdnList <String[]>] [-CustomAccountResetCredentialsUrl <String>]
 [-CustomCannotAccessYourAccountText <String>] [-CustomCannotAccessYourAccountUrl <String>]
 [-CustomCssInputFile <String>] [-CustomCssRelativeUrl <String>] [-CustomForgotMyPasswordText <String>]
 [-CustomPrivacyAndCookiesText <String>] [-CustomPrivacyAndCookiesUrl <String>]
 [-CustomResetItNowText <String>] [-CustomTermsOfUseText <String>] [-CustomTermsOfUseUrl <String>]
 [-FaviconInputFile <String>] [-FaviconRelativeUrl <String>] [-HeaderBackgroundColor <String>]
 [-HeaderLogoInputFile <String>] [-HeaderLogoRelativeUrl <String>] [-Id <String>]
 [-LoginPageLayoutConfiguration <IMicrosoftGraphLoginPageLayoutConfiguration>]
 [-LoginPageTextVisibilitySettings <IMicrosoftGraphLoginPageTextVisibilitySettings>]
 [-SignInPageText <String>] [-SquareLogoDarkInputFile <String>] [-SquareLogoDarkRelativeUrl <String>]
 [-SquareLogoInputFile <String>] [-SquareLogoRelativeUrl <String>] [-UsernameHintText <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new organizationalBrandingLocalization object.
This creates a localized branding and at the same time, the default branding if it doesn't exist.
The default branding is created only once.
It's loaded when a localized branding isn't configured for the user's browser language.
To retrieve the default branding, see Get branding.

## EXAMPLES

### Example 1: Using the New-MgOrganizationBrandingLocalization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	Id = "fr-FR"
	SignInPageText = " "
}
New-MgOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params
```

This example shows how to use the New-MgOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackgroundColor
Color that appears in place of the background image in low-bandwidth connections.
We recommend that you use the primary color of your banner logo or your organization color.
Specify this in hexadecimal format, for example, white is #FFFFFF.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BannerLogoInputFile
Input File for BannerLogo (A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BannerLogoRelativeUrl
A relative URL for the bannerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
organizationalBrandingLocalization

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomAccountResetCredentialsUrl
A custom URL for resetting account credentials.
This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomCannotAccessYourAccountText
A string to replace the default 'Can't access your account' self-service password reset (SSPR) hyperlink text on the sign-in page.
This text must be in Unicode format and not exceed 256 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomCannotAccessYourAccountUrl
A custom URL to replace the default URL of the self-service password reset (SSPR) 'Can't access your account' hyperlink on the sign-in page.
This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.
DO NOT USE.
Use customAccountResetCredentialsUrl instead.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomCssInputFile
Input File for CustomCss (CSS styling that appears on the sign-in page.
The allowed format is .css format only and not larger than 25 KB.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomCssRelativeUrl
A relative URL for the customCSS property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomForgotMyPasswordText
A string to replace the default 'Forgot my password' hyperlink text on the sign-in form.
This text must be in Unicode format and not exceed 256 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomPrivacyAndCookiesText
A string to replace the default 'Privacy and Cookies' hyperlink text in the footer.
This text must be in Unicode format and not exceed 256 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomPrivacyAndCookiesUrl
A custom URL to replace the default URL of the 'Privacy and Cookies' hyperlink in the footer.
This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomResetItNowText
A string to replace the default 'reset it now' hyperlink text on the sign-in form.
This text must be in Unicode format and not exceed 256 characters.
DO NOT USE: Customization of the 'reset it now' hyperlink text is currently not supported.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomTermsOfUseText
A string to replace the the default 'Terms of Use' hyperlink text in the footer.
This text must be in Unicode format and not exceed 256 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomTermsOfUseUrl
A custom URL to replace the default URL of the 'Terms of Use' hyperlink in the footer.
This URL must be in ASCII format or non-ASCII characters must be URL encoded, and not exceed 128characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FaviconInputFile
Input File for Favicon (A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FaviconRelativeUrl
A relative url for the favicon above that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HeaderBackgroundColor
The RGB color to apply to customize the color of the header.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HeaderLogoInputFile
Input File for HeaderLogo (A company logo that appears in the header of the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HeaderLogoRelativeUrl
A relative URL for the headerLogo property that is combined with a CDN base URL from the cdnList to provide the read-only version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LoginPageLayoutConfiguration
loginPageLayoutConfiguration
To construct, please use Get-Help -Online and see NOTES section for LOGINPAGELAYOUTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLoginPageLayoutConfiguration
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoginPageTextVisibilitySettings
loginPageTextVisibilitySettings
To construct, please use Get-Help -Online and see NOTES section for LOGINPAGETEXTVISIBILITYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLoginPageTextVisibilitySettings
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignInPageText
Text that appears at the bottom of the sign-in box.
Use this to communicate additional information, such as the phone number to your help desk or a legal statement.
This text must be in Unicode format and not exceed 1024 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SquareLogoDarkInputFile
Input File for SquareLogoDark (A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SquareLogoDarkRelativeUrl
A relative URL for the squareLogoDark property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SquareLogoInputFile
Input File for SquareLogo (A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.)

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SquareLogoRelativeUrl
A relative URL for the squareLogo property that is combined with a CDN base URL from the cdnList to provide the version served by a CDN.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsernameHintText
A string that shows as the hint in the username textbox on the sign-in screen.
This text must be a Unicode, without links or code, and can't exceed 64 characters.

```yaml
Type: System.String
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

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBrandingLocalization1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

LOGINPAGELAYOUTCONFIGURATION <IMicrosoftGraphLoginPageLayoutConfiguration>: loginPageLayoutConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsFooterShown <Boolean?>]`: Option to show the footer on the sign-in page.
  - `[IsHeaderShown <Boolean?>]`: Option to show the header on the sign-in page.
  - `[LayoutTemplateType <String>]`: layoutTemplateType

LOGINPAGETEXTVISIBILITYSETTINGS <IMicrosoftGraphLoginPageTextVisibilitySettings>: loginPageTextVisibilitySettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HideAccountResetCredentials <Boolean?>]`: Option to hide the self-service password reset (SSPR) hyperlinks such as 'Can't access your account?', 'Forgot my password' and 'Reset it now' on the sign-in form.
  - `[HideCannotAccessYourAccount <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Can't access your account?' hyperlink on the sign-in form.
  - `[HideForgotMyPassword <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'Forgot my password' hyperlink on the sign-in form.
  - `[HidePrivacyAndCookies <Boolean?>]`: Option to hide the 'Privacy & Cookies' hyperlink in the footer.
  - `[HideResetItNow <Boolean?>]`: Option to hide the self-service password reset (SSPR) 'reset it now' hyperlink on the sign-in form.
  - `[HideTermsOfUse <Boolean?>]`: Option to hide the 'Terms of Use' hyperlink in the footer.

## RELATED LINKS

