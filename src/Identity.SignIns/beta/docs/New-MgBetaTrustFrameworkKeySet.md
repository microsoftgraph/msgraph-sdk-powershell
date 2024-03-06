---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetatrustframeworkkeyset
schema: 2.0.0
---

# New-MgBetaTrustFrameworkKeySet

## SYNOPSIS
Create a new trustFrameworkKeySet.
The ID of the trustFrameworkKeySet is expected in the create request; however, it can be modified by the service.
The modified ID will be available in the response and in the location header.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTrustFrameworkKeySet [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Keys <IMicrosoftGraphTrustFrameworkKey[]>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTrustFrameworkKeySet -BodyParameter <IMicrosoftGraphTrustFrameworkKeySet>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new trustFrameworkKeySet.
The ID of the trustFrameworkKeySet is expected in the create request; however, it can be modified by the service.
The modified ID will be available in the response and in the location header.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "keyset1"
	Keys = @(
		@{
			K = "k-value"
			X5c = @(
				"x5c-value"
			)
			X5t = "x5t-value"
			Kty = "kty-value"
			Use = "use-value"
			Exp = 99
			Nbf = 99
			Kid = "kid-value"
			E = "e-value"
			N = "n-value"
			D = "d-value"
			P = "p-value"
			Q = "q-value"
			Dp = "dp-value"
			Dq = "dq-value"
			Qi = "qi-value"
		}
	)
}
New-MgBetaTrustFrameworkKeySet -BodyParameter $params
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "keyset1"
}
New-MgBetaTrustFrameworkKeySet -BodyParameter $params
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
trustFrameworkKeySet
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrustFrameworkKeySet
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Keys
A collection of the keys.
To construct, see NOTES section for KEYS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrustFrameworkKey[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrustFrameworkKeySet

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrustFrameworkKeySet

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTrustFrameworkKeySet>`: trustFrameworkKeySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Keys <IMicrosoftGraphTrustFrameworkKey[]>]`: A collection of the keys.
    - `[D <String>]`: RSA Key - private exponent. Field can't be read back.
    - `[Dp <String>]`: RSA Key - first exponent. Field can't be read back.
    - `[Dq <String>]`: RSA Key - second exponent. Field can't be read back.
    - `[E <String>]`: RSA Key - public exponent
    - `[Exp <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
    - `[K <String>]`: Symmetric Key for oct key type. Field can't be read back.
    - `[Kid <String>]`: The unique identifier for the key.
    - `[Kty <String>]`: The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.
    - `[N <String>]`: RSA Key - modulus
    - `[Nbf <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
    - `[P <String>]`: RSA Key - first prime. Field can't be read back.
    - `[Q <String>]`: RSA Key - second prime. Field can't be read back.
    - `[Qi <String>]`: RSA Key - Coefficient. Field can't be read back.
    - `[Use <String>]`: The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)
    - `[X5C <String[]>]`: The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.
    - `[X5T <String>]`: The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (also known as digest) of the DER encoding of an X.509 certificate RFC 5280.

`KEYS <IMicrosoftGraphTrustFrameworkKey[]>`: A collection of the keys.
  - `[D <String>]`: RSA Key - private exponent. Field can't be read back.
  - `[Dp <String>]`: RSA Key - first exponent. Field can't be read back.
  - `[Dq <String>]`: RSA Key - second exponent. Field can't be read back.
  - `[E <String>]`: RSA Key - public exponent
  - `[Exp <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
  - `[K <String>]`: Symmetric Key for oct key type. Field can't be read back.
  - `[Kid <String>]`: The unique identifier for the key.
  - `[Kty <String>]`: The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.
  - `[N <String>]`: RSA Key - modulus
  - `[Nbf <Int64?>]`: This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)
  - `[P <String>]`: RSA Key - first prime. Field can't be read back.
  - `[Q <String>]`: RSA Key - second prime. Field can't be read back.
  - `[Qi <String>]`: RSA Key - Coefficient. Field can't be read back.
  - `[Use <String>]`: The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)
  - `[X5C <String[]>]`: The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.
  - `[X5T <String>]`: The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (also known as digest) of the DER encoding of an X.509 certificate RFC 5280.

## RELATED LINKS

