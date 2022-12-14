---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/update-mgidentityconditionalaccessauthenticationstrength
schema: 2.0.0
---

# Update-MgBetaIdentityConditionalAccessAuthenticationStrength

## SYNOPSIS
Update the navigation property authenticationStrengths in identity

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaIdentityConditionalAccessAuthenticationStrength [-AdditionalProperties <Hashtable>]
 [-AuthenticationCombinations <String[]>]
 [-AuthenticationMethodModes <IMicrosoftGraphAuthenticationMethodModeDetail[]>] [-Id <String>]
 [-Policies <IMicrosoftGraphAuthenticationStrengthPolicy[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaIdentityConditionalAccessAuthenticationStrength
 -BodyParameter <IMicrosoftGraphAuthenticationStrengthRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authenticationStrengths in identity

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

### -AuthenticationCombinations
A collection of all valid authentication method combinations in the system.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationMethodModes
Names and descriptions of all valid authentication method modes in the system.
To construct, please use Get-Help -Online and see NOTES section for AUTHENTICATIONMETHODMODES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationMethodModeDetail[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
authenticationStrengthRoot
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
To construct, please use Get-Help -Online and see NOTES section for POLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthRoot

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AUTHENTICATIONMETHODMODES <IMicrosoftGraphAuthenticationMethodModeDetail[]>: Names and descriptions of all valid authentication method modes in the system.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AuthenticationMethod <String>]`: baseAuthenticationMethod
  - `[DisplayName <String>]`: The display name of this mode

BODYPARAMETER <IMicrosoftGraphAuthenticationStrengthRoot>: authenticationStrengthRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AuthenticationCombinations <String[]>]`: A collection of all valid authentication method combinations in the system.
  - `[AuthenticationMethodModes <IMicrosoftGraphAuthenticationMethodModeDetail[]>]`: Names and descriptions of all valid authentication method modes in the system.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AuthenticationMethod <String>]`: baseAuthenticationMethod
    - `[DisplayName <String>]`: The display name of this mode
  - `[Policies <IMicrosoftGraphAuthenticationStrengthPolicy[]>]`: A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AllowedCombinations <String[]>]`: A collection of authentication method modes that are required be used to satify this authentication strength.
    - `[CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object that's defined for the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is 'fido2'.
    - `[CreatedDateTime <DateTime?>]`: The datetime when this policy was created.
    - `[Description <String>]`: The human-readable description of this policy.
    - `[DisplayName <String>]`: The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).
    - `[ModifiedDateTime <DateTime?>]`: The datetime when this policy was last modified.
    - `[PolicyType <String>]`: authenticationStrengthPolicyType
    - `[RequirementsSatisfied <String>]`: authenticationStrengthRequirements

POLICIES <IMicrosoftGraphAuthenticationStrengthPolicy[]>: A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedCombinations <String[]>]`: A collection of authentication method modes that are required be used to satify this authentication strength.
  - `[CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object that's defined for the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is 'fido2'.
  - `[CreatedDateTime <DateTime?>]`: The datetime when this policy was created.
  - `[Description <String>]`: The human-readable description of this policy.
  - `[DisplayName <String>]`: The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).
  - `[ModifiedDateTime <DateTime?>]`: The datetime when this policy was last modified.
  - `[PolicyType <String>]`: authenticationStrengthPolicyType
  - `[RequirementsSatisfied <String>]`: authenticationStrengthRequirements

## RELATED LINKS

