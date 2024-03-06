---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/new-mgbetadirectorycertificateauthoritycertificatebasedapplicationconfiguration
schema: 2.0.0
---

# New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfiguration

## SYNOPSIS
Create new navigation property to certificateBasedApplicationConfigurations for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfiguration
 [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-TrustedCertificateAuthorities <IMicrosoftGraphCertificateAuthorityAsEntity[]>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfiguration
 -BodyParameter <IMicrosoftGraphCertificateBasedApplicationConfiguration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to certificateBasedApplicationConfigurations for directory

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
certificateBasedApplicationConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCertificateBasedApplicationConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the trusted certificate authorities.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the trusted certificate authorities.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### -TrustedCertificateAuthorities
Collection of trusted certificate authorities.
To construct, see NOTES section for TRUSTEDCERTIFICATEAUTHORITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCertificateAuthorityAsEntity[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCertificateBasedApplicationConfiguration

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCertificateBasedApplicationConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphCertificateBasedApplicationConfiguration>`: certificateBasedApplicationConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TrustedCertificateAuthorities <IMicrosoftGraphCertificateAuthorityAsEntity[]>]`: Collection of trusted certificate authorities.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Certificate <Byte[]>]`: The trusted certificate.
    - `[IsRootAuthority <Boolean?>]`: Indicates if the certificate is a root authority. In a certificateBasedApplicationConfiguration object, at least one object in the trustedCertificateAuthorities collection must be a root authority.
    - `[Issuer <String>]`: The issuer of the trusted certificate.
    - `[IssuerSubjectKeyIdentifier <String>]`: The subject key identifier of the trusted certificate.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the trusted certificate authorities.
  - `[DisplayName <String>]`: The display name of the trusted certificate authorities.

`TRUSTEDCERTIFICATEAUTHORITIES <IMicrosoftGraphCertificateAuthorityAsEntity[]>`: Collection of trusted certificate authorities.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Certificate <Byte[]>]`: The trusted certificate.
  - `[IsRootAuthority <Boolean?>]`: Indicates if the certificate is a root authority. In a certificateBasedApplicationConfiguration object, at least one object in the trustedCertificateAuthorities collection must be a root authority.
  - `[Issuer <String>]`: The issuer of the trusted certificate.
  - `[IssuerSubjectKeyIdentifier <String>]`: The subject key identifier of the trusted certificate.

## RELATED LINKS

