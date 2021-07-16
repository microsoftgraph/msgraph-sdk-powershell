---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyb2cauthenticationmethodpolicy
schema: 2.0.0
---

# Update-MgPolicyB2CAuthenticationMethodPolicy

## SYNOPSIS
Update the navigation property b2cAuthenticationMethodsPolicy in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyB2CAuthenticationMethodPolicy [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-IsEmailPasswordAuthenticationEnabled] [-IsPhoneOneTimePasswordAuthenticationEnabled]
 [-IsUserNameAuthenticationEnabled] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPolicyB2CAuthenticationMethodPolicy -BodyParameter <IMicrosoftGraphB2CAuthenticationMethodsPolicy>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property b2cAuthenticationMethodsPolicy in policies

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
b2cAuthenticationMethodsPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphB2CAuthenticationMethodsPolicy
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
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEmailPasswordAuthenticationEnabled
The tenant admin can configure local accounts using email if the email and password authentication method is enabled.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPhoneOneTimePasswordAuthenticationEnabled
The tenant admin can configure local accounts using phone number if the phone number and one-time password authentication method is enabled.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsUserNameAuthenticationEnabled
The tenant admin can configure local accounts using username if the username and password authentication method is enabled.

```yaml
Type: SwitchParameter
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
Type: SwitchParameter
Parameter Sets: (All)
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphB2CAuthenticationMethodsPolicy
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphB2CAuthenticationMethodsPolicy>: b2cAuthenticationMethodsPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[IsEmailPasswordAuthenticationEnabled <Boolean?>]`: The tenant admin can configure local accounts using email if the email and password authentication method is enabled.
  - `[IsPhoneOneTimePasswordAuthenticationEnabled <Boolean?>]`: The tenant admin can configure local accounts using phone number if the phone number and one-time password authentication method is enabled.
  - `[IsUserNameAuthenticationEnabled <Boolean?>]`: The tenant admin can configure local accounts using username if the username and password authentication method is enabled.

## RELATED LINKS
