---
external help file:
Module Name: Microsoft.Graph.Beta.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.planner/update-mgplannertaskbuckettaskboardformat
schema: 2.0.0
---

# Update-MgBetaPlannerTaskBucketTaskBoardFormat

## SYNOPSIS
Update the properties of **plannerBucketTaskBoardTaskFormat** object.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaPlannerTaskBucketTaskBoardFormat -PlannerTaskId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-OrderHint <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaPlannerTaskBucketTaskBoardFormat -PlannerTaskId <String>
 -BodyParameter <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaPlannerTaskBucketTaskBoardFormat -InputObject <IPlannerIdentity>
 -BodyParameter <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaPlannerTaskBucketTaskBoardFormat -InputObject <IPlannerIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-OrderHint <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of **plannerBucketTaskBoardTaskFormat** object.

## EXAMPLES

### Example 1: Using the Update-MgBetaPlannerTaskBucketTaskBoardFormat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	OrderHint = "A6673H Ejkl!"
}
Update-MgBetaPlannerTaskBucketTaskBoardFormat -PlannerTaskId $plannerTaskId -BodyParameter $params
```

This example shows how to use the Update-MgBetaPlannerTaskBucketTaskBoardFormat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerBucketTaskBoardTaskFormat
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1
Parameter Sets: Update1, UpdateViaIdentity1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPlannerIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OrderHint
Hint used to order tasks in the Bucket view of the Task Board.
The format is defined as outlined here.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PlannerTaskId
key: id of plannerTask

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1

### Microsoft.Graph.Beta.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1>: plannerBucketTaskBoardTaskFormat
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.

INPUTOBJECT <IPlannerIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[PlannerBucketId <String>]`: key: id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: id of plannerDelta
  - `[PlannerPlanId <String>]`: key: id of plannerPlan
  - `[PlannerRosterId <String>]`: key: id of plannerRoster
  - `[PlannerRosterMemberId <String>]`: key: id of plannerRosterMember
  - `[PlannerTaskId <String>]`: key: id of plannerTask
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

