---
external help file:
Module Name: Microsoft.Graph.Identity.Organization
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.organization/new-mgorganizationextension
schema: 2.0.0
---

# New-MgOrganizationExtension

## SYNOPSIS
Create new navigation property to extensions for organization

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgOrganizationExtension -OrganizationId <String> [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgOrganizationExtension -OrganizationId <String> -BodyParameter <IMicrosoftGraphExtension> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgOrganizationExtension -InputObject <IIdentityOrganizationIdentity>
 -BodyParameter <IMicrosoftGraphExtension> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgOrganizationExtension -InputObject <IIdentityOrganizationIdentity> [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to extensions for organization

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

### -BodyParameter
extension
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension
Parameter Sets: Create1, CreateViaIdentity1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OrganizationId
key: organization-id of organization

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExtension>: extension
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IIdentityOrganizationIdentity>: Identity Parameter
  - `[CertificateBasedAuthConfigurationId <String>]`: key: certificateBasedAuthConfiguration-id of certificateBasedAuthConfiguration
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[OrganizationId <String>]`: key: organization-id of organization
  - `[OrganizationalBrandingId <String>]`: key: organizationalBranding-id of organizationalBranding

## RELATED LINKS

