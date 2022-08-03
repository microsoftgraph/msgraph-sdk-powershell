---
external help file:
Module Name: Microsoft.Graph.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.planner/update-mgplannerplandetail
schema: 2.0.0
---

# Update-MgPlannerPlanDetail

## SYNOPSIS
Update the navigation property details in planner

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgPlannerPlanDetail -PlannerPlanId <String> [-AdditionalProperties <Hashtable>]
 [-CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>] [-ContextDetails <Hashtable>]
 [-Id <String>] [-SharedWith <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgPlannerPlanDetail -PlannerPlanId <String> -BodyParameter <IMicrosoftGraphPlannerPlanDetails1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgPlannerPlanDetail -InputObject <IPlannerIdentity> -BodyParameter <IMicrosoftGraphPlannerPlanDetails1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgPlannerPlanDetail -InputObject <IPlannerIdentity> [-AdditionalProperties <Hashtable>]
 [-CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>] [-ContextDetails <Hashtable>]
 [-Id <String>] [-SharedWith <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property details in planner

## EXAMPLES

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
plannerPlanDetails
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CategoryDescriptions
plannerCategoryDescriptions
To construct, please use Get-Help -Online and see NOTES section for CATEGORYDESCRIPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerCategoryDescriptions
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContextDetails
plannerPlanContextDetailsCollection

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

### -Id
.

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
Type: Microsoft.Graph.PowerShell.Models.IPlannerIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
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

### -PlannerPlanId
key: id of plannerPlan

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

### -SharedWith
plannerUserIds

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails1

### Microsoft.Graph.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlanDetails1>: plannerPlanDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Category1 <String>]`: The label associated with Category 1
    - `[Category10 <String>]`: The label associated with Category 10
    - `[Category11 <String>]`: The label associated with Category 11
    - `[Category12 <String>]`: The label associated with Category 12
    - `[Category13 <String>]`: The label associated with Category 13
    - `[Category14 <String>]`: The label associated with Category 14
    - `[Category15 <String>]`: The label associated with Category 15
    - `[Category16 <String>]`: The label associated with Category 16
    - `[Category17 <String>]`: The label associated with Category 17
    - `[Category18 <String>]`: The label associated with Category 18
    - `[Category19 <String>]`: The label associated with Category 19
    - `[Category2 <String>]`: The label associated with Category 2
    - `[Category20 <String>]`: The label associated with Category 20
    - `[Category21 <String>]`: The label associated with Category 21
    - `[Category22 <String>]`: The label associated with Category 22
    - `[Category23 <String>]`: The label associated with Category 23
    - `[Category24 <String>]`: The label associated with Category 24
    - `[Category25 <String>]`: The label associated with Category 25
    - `[Category3 <String>]`: The label associated with Category 3
    - `[Category4 <String>]`: The label associated with Category 4
    - `[Category5 <String>]`: The label associated with Category 5
    - `[Category6 <String>]`: The label associated with Category 6
    - `[Category7 <String>]`: The label associated with Category 7
    - `[Category8 <String>]`: The label associated with Category 8
    - `[Category9 <String>]`: The label associated with Category 9
  - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

CATEGORYDESCRIPTIONS <IMicrosoftGraphPlannerCategoryDescriptions>: plannerCategoryDescriptions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Category1 <String>]`: The label associated with Category 1
  - `[Category10 <String>]`: The label associated with Category 10
  - `[Category11 <String>]`: The label associated with Category 11
  - `[Category12 <String>]`: The label associated with Category 12
  - `[Category13 <String>]`: The label associated with Category 13
  - `[Category14 <String>]`: The label associated with Category 14
  - `[Category15 <String>]`: The label associated with Category 15
  - `[Category16 <String>]`: The label associated with Category 16
  - `[Category17 <String>]`: The label associated with Category 17
  - `[Category18 <String>]`: The label associated with Category 18
  - `[Category19 <String>]`: The label associated with Category 19
  - `[Category2 <String>]`: The label associated with Category 2
  - `[Category20 <String>]`: The label associated with Category 20
  - `[Category21 <String>]`: The label associated with Category 21
  - `[Category22 <String>]`: The label associated with Category 22
  - `[Category23 <String>]`: The label associated with Category 23
  - `[Category24 <String>]`: The label associated with Category 24
  - `[Category25 <String>]`: The label associated with Category 25
  - `[Category3 <String>]`: The label associated with Category 3
  - `[Category4 <String>]`: The label associated with Category 4
  - `[Category5 <String>]`: The label associated with Category 5
  - `[Category6 <String>]`: The label associated with Category 6
  - `[Category7 <String>]`: The label associated with Category 7
  - `[Category8 <String>]`: The label associated with Category 8
  - `[Category9 <String>]`: The label associated with Category 9

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

