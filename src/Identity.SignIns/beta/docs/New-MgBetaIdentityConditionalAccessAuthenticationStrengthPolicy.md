---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetaidentityconditionalaccessauthenticationstrengthpolicy
schema: 2.0.0
---

# New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy

## SYNOPSIS
Create new navigation property to policies for identity

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy [-AdditionalProperties <Hashtable>]
 [-AllowedCombinations <String[]>]
 [-CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-PolicyType <String>] [-RequirementsSatisfied <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy
 -BodyParameter <IMicrosoftGraphAuthenticationStrengthPolicy> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to policies for identity

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedCombinations
A collection of authentication method modes that are required be used to satify this authentication strength.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
authenticationStrengthPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CombinationConfigurations
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
To construct, see NOTES section for COMBINATIONCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationCombinationConfiguration[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The datetime when this policy was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The human-readable description of this policy.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The human-readable display name of this policy.
Supports $filter (eq, ne, not , and in).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The datetime when this policy was last modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyType
authenticationStrengthPolicyType

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequirementsSatisfied
authenticationStrengthRequirements

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthenticationStrengthPolicy>`: authenticationStrengthPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedCombinations <String[]>]`: A collection of authentication method modes that are required be used to satify this authentication strength.
  - `[CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object defined for the authenticationStrengthPolicy. For fido2combinationConfigurations use 'fido2', for x509certificatecombinationconfiguration use 'x509CertificateSingleFactor' or 'x509CertificateMultiFactor'.
  - `[CreatedDateTime <DateTime?>]`: The datetime when this policy was created.
  - `[Description <String>]`: The human-readable description of this policy.
  - `[DisplayName <String>]`: The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).
  - `[ModifiedDateTime <DateTime?>]`: The datetime when this policy was last modified.
  - `[PolicyType <String>]`: authenticationStrengthPolicyType
  - `[RequirementsSatisfied <String>]`: authenticationStrengthRequirements

`COMBINATIONCONFIGURATIONS <IMicrosoftGraphAuthenticationCombinationConfiguration[]>`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object defined for the authenticationStrengthPolicy. For fido2combinationConfigurations use 'fido2', for x509certificatecombinationconfiguration use 'x509CertificateSingleFactor' or 'x509CertificateMultiFactor'.

## RELATED LINKS

