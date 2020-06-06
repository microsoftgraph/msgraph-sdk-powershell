---
external help file:
Module Name: Microsoft.Graph.Identity.TrustFramework
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.trustframework/new-mgtrustframeworkkeysetkey
schema: 2.0.0
---

# New-MgTrustFrameworkKeySetKey

## SYNOPSIS
Invoke action generateKey

## SYNTAX

### GenerateExpanded (Default)
```
New-MgTrustFrameworkKeySetKey -TrustFrameworkKeySetId <String> [-Exp <Int64>] [-Kty <String>] [-Nbf <Int64>]
 [-Use <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Generate
```
New-MgTrustFrameworkKeySetKey -TrustFrameworkKeySetId <String>
 -BodyParameter <IPaths1IaopbhTrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphGeneratekeyPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GenerateViaIdentity
```
New-MgTrustFrameworkKeySetKey -InputObject <IIdentityTrustFrameworkIdentity>
 -BodyParameter <IPaths1IaopbhTrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphGeneratekeyPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GenerateViaIdentityExpanded
```
New-MgTrustFrameworkKeySetKey -InputObject <IIdentityTrustFrameworkIdentity> [-Exp <Int64>] [-Kty <String>]
 [-Nbf <Int64>] [-Use <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action generateKey

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1IaopbhTrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphGeneratekeyPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Generate, GenerateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Exp
.

```yaml
Type: System.Int64
Parameter Sets: GenerateExpanded, GenerateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityTrustFrameworkIdentity
Parameter Sets: GenerateViaIdentity, GenerateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Kty
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded, GenerateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Nbf
.

```yaml
Type: System.Int64
Parameter Sets: GenerateExpanded, GenerateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TrustFrameworkKeySetId
key: trustFrameworkKeySet-id of trustFrameworkKeySet

```yaml
Type: System.String
Parameter Sets: Generate, GenerateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Use
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded, GenerateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityTrustFrameworkIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1IaopbhTrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphGeneratekeyPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFrameworkKey

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1IaopbhTrustframeworkKeysetsTrustframeworkkeysetIdMicrosoftGraphGeneratekeyPostRequestbodyContentApplicationJsonSchema>: .
  - `[Exp <Int64?>]`: 
  - `[Kty <String>]`: 
  - `[Nbf <Int64?>]`: 
  - `[Use <String>]`: 

INPUTOBJECT <IIdentityTrustFrameworkIdentity>: Identity Parameter
  - `[TrustFrameworkKeySetId <String>]`: key: trustFrameworkKeySet-id of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: key: trustFrameworkPolicy-id of trustFrameworkPolicy

## RELATED LINKS

