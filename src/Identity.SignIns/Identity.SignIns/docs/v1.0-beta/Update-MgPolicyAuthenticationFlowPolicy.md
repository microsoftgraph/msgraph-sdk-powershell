---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyauthenticationflowpolicy
schema: 2.0.0
---

# Update-MgPolicyAuthenticationFlowPolicy

## SYNOPSIS
Update the navigation property authenticationFlowsPolicy in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyAuthenticationFlowPolicy [-AdditionalProperties <Hashtable>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>]
 [-SelfServiceSignUp <IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPolicyAuthenticationFlowPolicy -BodyParameter <IMicrosoftGraphAuthenticationFlowsPolicy> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authenticationFlowsPolicy in policies

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
authenticationFlowsPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationFlowsPolicy
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Inherited property.
A description of the policy.
This property is not a key.
Optional.
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

### -DisplayName
Inherited property.
The human-readable name of the policy.
This property is not a key.
Optional.
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

### -Id
.

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

### -SelfServiceSignUp
selfServiceSignUpAuthenticationFlowConfiguration
To construct, please use Get-Help -Online and see NOTES section for SELFSERVICESIGNUP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationFlowsPolicy

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuthenticationFlowsPolicy>: authenticationFlowsPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: Inherited property. A description of the policy. This property is not a key. Optional. Read-only.
  - `[DisplayName <String>]`: Inherited property. The human-readable name of the policy. This property is not a key. Optional. Read-only.
  - `[SelfServiceSignUp <IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration>]`: selfServiceSignUpAuthenticationFlowConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Indicates whether self-service sign-up flow is enabled or disabled. The default value is false. This property is not a key. Required.

SELFSERVICESIGNUP <IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration>: selfServiceSignUpAuthenticationFlowConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsEnabled <Boolean?>]`: Indicates whether self-service sign-up flow is enabled or disabled. The default value is false. This property is not a key. Required.

## RELATED LINKS

