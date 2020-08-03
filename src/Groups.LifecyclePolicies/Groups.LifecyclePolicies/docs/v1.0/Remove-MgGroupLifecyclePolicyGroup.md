---
external help file:
Module Name: Microsoft.Graph.Groups.LifecyclePolicies
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.lifecyclepolicies/remove-mggrouplifecyclepolicygroup
schema: 2.0.0
---

# Remove-MgGroupLifecyclePolicyGroup

## SYNOPSIS
Invoke action removeGroup

## SYNTAX

### RemoveExpanded (Default)
```
Remove-MgGroupLifecyclePolicyGroup -GroupLifecyclePolicyId <String> [-GroupId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Remove
```
Remove-MgGroupLifecyclePolicyGroup -GroupLifecyclePolicyId <String>
 -BodyParameter <IPathsRh6M23GrouplifecyclepoliciesGrouplifecyclepolicyIdMicrosoftGraphRemovegroupPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RemoveViaIdentity
```
Remove-MgGroupLifecyclePolicyGroup -InputObject <IGroupsLifecyclePoliciesIdentity>
 -BodyParameter <IPathsRh6M23GrouplifecyclepoliciesGrouplifecyclepolicyIdMicrosoftGraphRemovegroupPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RemoveViaIdentityExpanded
```
Remove-MgGroupLifecyclePolicyGroup -InputObject <IGroupsLifecyclePoliciesIdentity> [-GroupId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action removeGroup

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
Type: Microsoft.Graph.PowerShell.Models.IPathsRh6M23GrouplifecyclepoliciesGrouplifecyclepolicyIdMicrosoftGraphRemovegroupPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Remove, RemoveViaIdentity
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
Parameter Sets: RemoveExpanded, RemoveViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupLifecyclePolicyId
key: groupLifecyclePolicy-id of groupLifecyclePolicy

```yaml
Type: System.String
Parameter Sets: Remove, RemoveExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsLifecyclePoliciesIdentity
Parameter Sets: RemoveViaIdentity, RemoveViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IGroupsLifecyclePoliciesIdentity

### Microsoft.Graph.PowerShell.Models.IPathsRh6M23GrouplifecyclepoliciesGrouplifecyclepolicyIdMicrosoftGraphRemovegroupPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsRh6M23GrouplifecyclepoliciesGrouplifecyclepolicyIdMicrosoftGraphRemovegroupPostRequestbodyContentApplicationJsonSchema>: .
  - `[GroupId <String>]`: 

INPUTOBJECT <IGroupsLifecyclePoliciesIdentity>: Identity Parameter
  - `[GroupLifecyclePolicyId <String>]`: key: groupLifecyclePolicy-id of groupLifecyclePolicy

## RELATED LINKS

