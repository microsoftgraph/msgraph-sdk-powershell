---
external help file:
Module Name: Microsoft.Graph.Beta.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.groups/invoke-mgrenewgrouplifecyclepolicy
schema: 2.0.0
---

# Invoke-MgBetaRenewGroupLifecyclePolicy

## SYNOPSIS
Renew a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

## SYNTAX

### RenewExpanded (Default)
```
Invoke-MgBetaRenewGroupLifecyclePolicy [-AdditionalProperties <Hashtable>] [-GroupId <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Renew
```
Invoke-MgBetaRenewGroupLifecyclePolicy
 -BodyParameter <IPaths8F8L4QGrouplifecyclepoliciesMicrosoftGraphRenewgroupPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Renew a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaRenewGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	GroupId = "ffffffff-ffff-ffff-ffff-ffffffffffff"
}
Invoke-MgBetaRenewGroupLifecyclePolicy -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRenewGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RenewExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths8F8L4QGrouplifecyclepoliciesMicrosoftGraphRenewgroupPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Renew
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupId
.

```yaml
Type: System.String
Parameter Sets: RenewExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths8F8L4QGrouplifecyclepoliciesMicrosoftGraphRenewgroupPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths8F8L4QGrouplifecyclepoliciesMicrosoftGraphRenewgroupPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[GroupId <String>]`: 

## RELATED LINKS

