---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganizationbranding
schema: 2.0.0
---

# Update-MgOrganizationBranding

## SYNOPSIS
Update the navigation property branding in organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganizationBranding -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-BackgroundColor <String>] [-BackgroundImageInputFile <String>] [-BannerLogoInputFile <String>]
 [-Id <String>] [-Localizations <IMicrosoftGraphOrganizationalBrandingLocalization[]>]
 [-SignInPageText <String>] [-SquareLogoInputFile <String>] [-UsernameHintText <String>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgOrganizationBranding -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganizationalBranding>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganizationBranding -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-BackgroundColor <String>] [-BackgroundImageInputFile <String>]
 [-BannerLogoInputFile <String>] [-Id <String>]
 [-Localizations <IMicrosoftGraphOrganizationalBrandingLocalization[]>] [-SignInPageText <String>]
 [-SquareLogoInputFile <String>] [-UsernameHintText <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganizationBranding -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrganizationalBranding> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property branding in organization

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

### -BackgroundColor
.

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

### -BackgroundImageInputFile
Input File for BackgroundImage (.)

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

### -BannerLogoInputFile
Input File for BannerLogo (.)

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

### -BodyParameter
organizationalBranding
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrganizationalBranding
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Localizations
.
To construct, see NOTES section for LOCALIZATIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOrganizationalBrandingLocalization[]
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

### -SignInPageText
.

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

### -SquareLogoInputFile
Input File for SquareLogo (.)

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

### -UsernameHintText
.

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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphOrganizationalBranding\>: organizationalBranding
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[BackgroundColor \<String\>\]: 
  \[BackgroundImage \<Byte\[\]\>\]: 
  \[BannerLogo \<Byte\[\]\>\]: 
  \[SignInPageText \<String\>\]: 
  \[SquareLogo \<Byte\[\]\>\]: 
  \[UsernameHintText \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Localizations \<IMicrosoftGraphOrganizationalBrandingLocalization\[\]\>\]: 
    \[BackgroundColor \<String\>\]: 
    \[BackgroundImage \<Byte\[\]\>\]: 
    \[BannerLogo \<Byte\[\]\>\]: 
    \[SignInPageText \<String\>\]: 
    \[SquareLogo \<Byte\[\]\>\]: 
    \[UsernameHintText \<String\>\]: 
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

LOCALIZATIONS \<IMicrosoftGraphOrganizationalBrandingLocalization\[\]\>: .
  \[BackgroundColor \<String\>\]: 
  \[BackgroundImage \<Byte\[\]\>\]: 
  \[BannerLogo \<Byte\[\]\>\]: 
  \[SignInPageText \<String\>\]: 
  \[SquareLogo \<Byte\[\]\>\]: 
  \[UsernameHintText \<String\>\]: 
  \[Id \<String\>\]: Read-only.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganizationbranding](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganizationbranding)

