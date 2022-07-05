---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgtrustframework
schema: 2.0.0
---

# Update-MgTrustFramework

## SYNOPSIS
Update trustFramework

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTrustFramework [-AdditionalProperties <Hashtable>] [-KeySets <IMicrosoftGraphTrustFrameworkKeySet[]>]
 [-Policies <IMicrosoftGraphTrustFrameworkPolicy[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTrustFramework -BodyParameter <IMicrosoftGraphTrustFramework> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update trustFramework

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
trustFramework
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFramework
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeySets
.
To construct, please use Get-Help -Online and see NOTES section for KEYSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFrameworkKeySet[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
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

### -Policies
.
To construct, please use Get-Help -Online and see NOTES section for POLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFrameworkPolicy[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFramework

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTrustFramework>: trustFramework
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[KeySets <IMicrosoftGraphTrustFrameworkKeySet[]>]`: 
    - `[Id <String>]`: 
    - `[Keys <IMicrosoftGraphTrustFrameworkKey[]>]`: A collection of the keys.
      - `[D <String>]`: RSA Key - private exponent. Field cannot be read back.
      - `[Dp <String>]`: RSA Key - first exponent. Field cannot be read back.
      - `[Dq <String>]`: RSA Key - second exponent. Field cannot be read back.
      - `[E <String>]`: RSA Key - public exponent
      - `[Exp <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
      - `[K <String>]`: Symmetric Key for oct key type. Field cannot be read back.
      - `[Kid <String>]`: The unique identifier for the key.
      - `[Kty <String>]`: The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.
      - `[N <String>]`: RSA Key - modulus
      - `[Nbf <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
      - `[P <String>]`: RSA Key - first prime. Field cannot be read back.
      - `[Q <String>]`: RSA Key - second prime. Field cannot be read back.
      - `[Qi <String>]`: RSA Key - Coefficient. Field cannot be read back.
      - `[Use <String>]`: The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)
      - `[X5C <String[]>]`: The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.
      - `[X5T <String>]`: The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (a.k.a. digest) of the DER encoding of an X.509 certificate RFC 5280.
  - `[Policies <IMicrosoftGraphTrustFrameworkPolicy[]>]`: 
    - `[Id <String>]`: 

KEYSETS <IMicrosoftGraphTrustFrameworkKeySet[]>: .
  - `[Id <String>]`: 
  - `[Keys <IMicrosoftGraphTrustFrameworkKey[]>]`: A collection of the keys.
    - `[D <String>]`: RSA Key - private exponent. Field cannot be read back.
    - `[Dp <String>]`: RSA Key - first exponent. Field cannot be read back.
    - `[Dq <String>]`: RSA Key - second exponent. Field cannot be read back.
    - `[E <String>]`: RSA Key - public exponent
    - `[Exp <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
    - `[K <String>]`: Symmetric Key for oct key type. Field cannot be read back.
    - `[Kid <String>]`: The unique identifier for the key.
    - `[Kty <String>]`: The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.
    - `[N <String>]`: RSA Key - modulus
    - `[Nbf <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
    - `[P <String>]`: RSA Key - first prime. Field cannot be read back.
    - `[Q <String>]`: RSA Key - second prime. Field cannot be read back.
    - `[Qi <String>]`: RSA Key - Coefficient. Field cannot be read back.
    - `[Use <String>]`: The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)
    - `[X5C <String[]>]`: The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.
    - `[X5T <String>]`: The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (a.k.a. digest) of the DER encoding of an X.509 certificate RFC 5280.

POLICIES <IMicrosoftGraphTrustFrameworkPolicy[]>: .
  - `[Id <String>]`: 

## RELATED LINKS

