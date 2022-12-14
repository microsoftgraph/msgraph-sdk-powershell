---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/invoke-mgdismissriskyuser
schema: 2.0.0
---

# Invoke-MgBetaDismissRiskyUser

## SYNOPSIS
Dismiss the risk of one or more riskyUser objects.
This action sets the targeted user's risk level to none.
The maximum count of users to dismiss in one call is 60.

## SYNTAX

### DismissExpanded (Default)
```
Invoke-MgBetaDismissRiskyUser [-AdditionalProperties <Hashtable>] [-UserIds <String[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Dismiss
```
Invoke-MgBetaDismissRiskyUser
 -BodyParameter <IPathsZip9X6IdentityprotectionRiskyusersMicrosoftGraphDismissPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Dismiss the risk of one or more riskyUser objects.
This action sets the targeted user's risk level to none.
The maximum count of users to dismiss in one call is 60.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaDismissRiskyUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	UserIds = @(
		"04487ee0-f4f6-4e7f-8999-facc5a30e232"
		"13387ee0-f4f6-4e7f-8999-facc5120e345"
	)
}
Invoke-MgBetaDismissRiskyUser -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaDismissRiskyUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: DismissExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsZip9X6IdentityprotectionRiskyusersMicrosoftGraphDismissPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Dismiss
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -UserIds
.

```yaml
Type: System.String[]
Parameter Sets: DismissExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsZip9X6IdentityprotectionRiskyusersMicrosoftGraphDismissPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsZip9X6IdentityprotectionRiskyusersMicrosoftGraphDismissPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UserIds <String[]>]`: 

## RELATED LINKS

