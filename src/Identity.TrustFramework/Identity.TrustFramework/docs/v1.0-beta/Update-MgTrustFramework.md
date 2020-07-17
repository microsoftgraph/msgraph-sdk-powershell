---
external help file:
Module Name: Microsoft.Graph.Identity.TrustFramework
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.trustframework/update-mgtrustframework
schema: 2.0.0
---

# Update-MgTrustFramework

## SYNOPSIS
Update trustFramework

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTrustFramework [-Id <String>] [-KeySets <IMicrosoftGraphTrustFrameworkKeySet[]>]
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
trustFramework
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

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

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeySets
.
To construct, see NOTES section for KEYSETS properties and create a hash table.

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
To construct, see NOTES section for POLICIES properties and create a hash table.

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
  - `[Id <String>]`: Read-only.
  - `[KeySets <IMicrosoftGraphTrustFrameworkKeySet[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Keys <IMicrosoftGraphTrustFrameworkKey[]>]`: 
      - `[D <String>]`: 
      - `[Dp <String>]`: 
      - `[Dq <String>]`: 
      - `[E <String>]`: 
      - `[Exp <Int64?>]`: 
      - `[K <String>]`: 
      - `[Kid <String>]`: 
      - `[Kty <String>]`: 
      - `[N <String>]`: 
      - `[Nbf <Int64?>]`: 
      - `[P <String>]`: 
      - `[Q <String>]`: 
      - `[Qi <String>]`: 
      - `[Use <String>]`: 
      - `[X5C <String[]>]`: 
      - `[X5T <String>]`: 
  - `[Policies <IMicrosoftGraphTrustFrameworkPolicy[]>]`: 
    - `[Id <String>]`: Read-only.

KEYSETS <IMicrosoftGraphTrustFrameworkKeySet[]>: .
  - `[Id <String>]`: Read-only.
  - `[Keys <IMicrosoftGraphTrustFrameworkKey[]>]`: 
    - `[D <String>]`: 
    - `[Dp <String>]`: 
    - `[Dq <String>]`: 
    - `[E <String>]`: 
    - `[Exp <Int64?>]`: 
    - `[K <String>]`: 
    - `[Kid <String>]`: 
    - `[Kty <String>]`: 
    - `[N <String>]`: 
    - `[Nbf <Int64?>]`: 
    - `[P <String>]`: 
    - `[Q <String>]`: 
    - `[Qi <String>]`: 
    - `[Use <String>]`: 
    - `[X5C <String[]>]`: 
    - `[X5T <String>]`: 

POLICIES <IMicrosoftGraphTrustFrameworkPolicy[]>: .
  - `[Id <String>]`: Read-only.

## RELATED LINKS

