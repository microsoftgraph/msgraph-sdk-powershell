---
external help file:
Module Name: Microsoft.Graph.Planner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.planner/update-mggroupplannerplandetail
schema: 2.0.0
---

# Update-MgGroupPlannerPlanDetail

## SYNOPSIS
Update the navigation property details in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgGroupPlannerPlanDetail -GroupId <String> -PlannerPlanId <String> -IfMatch <String>
 [-AdditionalProperties <Hashtable>] [-CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]
 [-Id <String>] [-ResponseHeadersVariable <String>] [-SharedWith <Hashtable>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgGroupPlannerPlanDetail -GroupId <String> -PlannerPlanId <String> -IfMatch <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanDetails> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgGroupPlannerPlanDetail -InputObject <IPlannerIdentity> -IfMatch <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanDetails> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgGroupPlannerPlanDetail -InputObject <IPlannerIdentity> -IfMatch <String>
 [-AdditionalProperties <Hashtable>] [-CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]
 [-Id <String>] [-ResponseHeadersVariable <String>] [-SharedWith <Hashtable>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property details in groups

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerPlanDetails
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CategoryDescriptions
plannerCategoryDescriptions
To construct, see NOTES section for CATEGORYDESCRIPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerCategoryDescriptions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IfMatch
ETag value.

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.IPlannerIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PlannerPlanId
The unique identifier of plannerPlan

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedWith
plannerUserIds

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails

### Microsoft.Graph.PowerShell.Models.IPlannerIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPlannerPlanDetails>`: plannerPlanDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
  - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

`CATEGORYDESCRIPTIONS <IMicrosoftGraphPlannerCategoryDescriptions>`: plannerCategoryDescriptions
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

`INPUTOBJECT <IPlannerIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[PlannerTaskId <String>]`: The unique identifier of plannerTask
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

