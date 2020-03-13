---
external help file:
Module Name: Microsoft.Graph.Identity.CertificateBasedAuthConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.certificatebasedauthconfiguration/new-mgcertificatebasedauthconfigurationcertificatebasedauthconfigurationcertificatebasedauthconfiguration
schema: 2.0.0
---

# New-MgCertificateBasedAuthConfigurationCertificateBasedAuthConfigurationCertificateBasedAuthConfiguration

## SYNOPSIS
Add new entity to certificateBasedAuthConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgCertificateBasedAuthConfigurationCertificateBasedAuthConfigurationCertificateBasedAuthConfiguration
 [-CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgCertificateBasedAuthConfigurationCertificateBasedAuthConfigurationCertificateBasedAuthConfiguration
 -BodyParameter <IMicrosoftGraphCertificateBasedAuthConfiguration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to certificateBasedAuthConfiguration

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
certificateBasedAuthConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateBasedAuthConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CertificateAuthorities
Collection of certificate authorities which creates a trusted certificate chain.
To construct, see NOTES section for CERTIFICATEAUTHORITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateAuthority[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateBasedAuthConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertificateBasedAuthConfiguration

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphCertificateBasedAuthConfiguration>: certificateBasedAuthConfiguration
  - `[Id <String>]`: Read-only.
  - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthority[]>]`: Collection of certificate authorities which creates a trusted certificate chain.
    - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
    - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
    - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
    - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
    - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
    - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.

#### CERTIFICATEAUTHORITIES <IMicrosoftGraphCertificateAuthority[]>: Collection of certificate authorities which creates a trusted certificate chain.
  - `[Certificate <Byte[]>]`: Required. The base64 encoded string representing the public certificate.
  - `[CertificateRevocationListUrl <String>]`: The URL of the certificate revocation list.
  - `[DeltaCertificateRevocationListUrl <String>]`: The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.
  - `[IsRootAuthority <Boolean?>]`: Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.
  - `[Issuer <String>]`: The issuer of the certificate, calculated from the certificate value. Read-only.
  - `[IssuerSki <String>]`: The subject key identifier of the certificate, calculated from the certificate value. Read-only.

## RELATED LINKS

