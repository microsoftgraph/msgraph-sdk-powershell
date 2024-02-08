---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetaidentityconditionalaccessauthenticationcontextclassreference
schema: 2.0.0
---

# New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference

## SYNOPSIS
Create a new authenticationContextClassReference.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsAvailable] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference
 -BodyParameter <IMicrosoftGraphAuthenticationContextClassReference> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new authenticationContextClassReference.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReference

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference
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
A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences.
For example, a selection UX.

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

### -IsAvailable
Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps.
When it's set to false, it shouldn't be shown in selection UX used to tag resources with authentication context class values.
It will still be shown in the Conditional Access policy authoring experience.
Supports $filter (eq).

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationContextClassReference

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthenticationContextClassReference>`: authenticationContextClassReference
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences. For example, selection UX.
  - `[DisplayName <String>]`: A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences. For example, a selection UX.
  - `[IsAvailable <Boolean?>]`: Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it's set to false, it shouldn't be shown in selection UX used to tag resources with authentication context class values. It will still be shown in the Conditional Access policy authoring experience.  Supports $filter (eq).

## RELATED LINKS

