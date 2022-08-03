---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgidentityconditionalaccessauthenticationcontextclassreference
schema: 2.0.0
---

# New-MgIdentityConditionalAccessAuthenticationContextClassReference

## SYNOPSIS
Create new navigation property to authenticationContextClassReferences for identity

## SYNTAX

### CreateExpanded (Default)
```
New-MgIdentityConditionalAccessAuthenticationContextClassReference [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsAvailable] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgIdentityConditionalAccessAuthenticationContextClassReference
 -BodyParameter <IMicrosoftGraphAuthenticationContextClassReference> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to authenticationContextClassReferences for identity

## EXAMPLES

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
authenticationContextClassReference
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
A short explanation of the policies that are enforced by authenticationContextClassReference.
This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences.
For example, selection UX.

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
The display name is the friendly name of the authenticationContextClassReference.
This value should be used to identify the authentication context class reference when building user facing admin experiences.
For example, selection UX.

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

### -Id
.

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

### -IsAvailable
Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps.
When it is set to false it should not be shown in admin UX experiences because the value is not currently available for selection.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuthenticationContextClassReference>: authenticationContextClassReference
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences. For example, selection UX.
  - `[DisplayName <String>]`: The display name is the friendly name of the authenticationContextClassReference. This value should be used to identify the authentication context class reference when building user facing admin experiences. For example, selection UX.
  - `[IsAvailable <Boolean?>]`: Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to false it should not be shown in admin UX experiences because the value is not currently available for selection.

## RELATED LINKS

