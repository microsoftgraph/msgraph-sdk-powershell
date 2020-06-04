---
external help file:
Module Name: Microsoft.Graph.Identity.Organization
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.organization/update-mgorganizationbranding
schema: 2.0.0
---

# Update-MgOrganizationBranding

## SYNOPSIS
Update the navigation property brandings in organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganizationBranding -OrganizationalBrandingId <String> -OrganizationId <String>
 [-BackgroundColor <String>] [-BackgroundImageInputFile <String>] [-BannerLogoInputFile <String>]
 [-Id <String>] [-Locale <String>] [-SignInPageText <String>] [-SquareLogoInputFile <String>]
 [-UsernameHintText <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOrganizationBranding -OrganizationalBrandingId <String> -OrganizationId <String>
 -BodyParameter <IMicrosoftGraphOrganizationalBranding> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganizationBranding -InputObject <IIdentityOrganizationIdentity>
 -BodyParameter <IMicrosoftGraphOrganizationalBranding> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganizationBranding -InputObject <IIdentityOrganizationIdentity> [-BackgroundColor <String>]
 [-BackgroundImageInputFile <String>] [-BannerLogoInputFile <String>] [-Id <String>] [-Locale <String>]
 [-SignInPageText <String>] [-SquareLogoInputFile <String>] [-UsernameHintText <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property brandings in organization

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

### -BackgroundColor
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

### -BackgroundImageInputFile
Input File for BackgroundImage (.)

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
Input File for BannerLogo (.)

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

### -Locale
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

### -OrganizationalBrandingId
key: organizationalBranding-id of organizationalBranding

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

### -SignInPageText
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
Input File for SquareLogo (.)

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationalBranding

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOrganizationalBranding>: organizationalBranding
  - `[Id <String>]`: Read-only.
  - `[BackgroundColor <String>]`: 
  - `[BackgroundImage <Byte[]>]`: 
  - `[BannerLogo <Byte[]>]`: 
  - `[Locale <String>]`: 
  - `[SignInPageText <String>]`: 
  - `[SquareLogo <Byte[]>]`: 
  - `[UsernameHintText <String>]`: 

INPUTOBJECT <IIdentityOrganizationIdentity>: Identity Parameter
  - `[CertificateBasedAuthConfigurationId <String>]`: key: certificateBasedAuthConfiguration-id of certificateBasedAuthConfiguration
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[OrganizationId <String>]`: key: organization-id of organization
  - `[OrganizationalBrandingId <String>]`: key: organizationalBranding-id of organizationalBranding

## RELATED LINKS

