---
external help file:
Module Name: Microsoft.Graph.Groups.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.planner/update-mggroupplannerplandetail
schema: 2.0.0
---

# Update-MgGroupPlannerPlanDetail

## SYNOPSIS
Update the navigation property details in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgGroupPlannerPlanDetail -GroupId <String> -PlannerPlanId <String>
 [-CategoryDescriptionCategory1 <String>] [-CategoryDescriptionCategory2 <String>]
 [-CategoryDescriptionCategory3 <String>] [-CategoryDescriptionCategory4 <String>]
 [-CategoryDescriptionCategory5 <String>] [-CategoryDescriptionCategory6 <String>]
 [-ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>] [-Id <String>]
 [-SharedWith <IMicrosoftGraphPlannerUserIds>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgGroupPlannerPlanDetail -GroupId <String> -PlannerPlanId <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgGroupPlannerPlanDetail -InputObject <IGroupsPlannerIdentity>
 -BodyParameter <IMicrosoftGraphPlannerPlanDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgGroupPlannerPlanDetail -InputObject <IGroupsPlannerIdentity> [-CategoryDescriptionCategory1 <String>]
 [-CategoryDescriptionCategory2 <String>] [-CategoryDescriptionCategory3 <String>]
 [-CategoryDescriptionCategory4 <String>] [-CategoryDescriptionCategory5 <String>]
 [-CategoryDescriptionCategory6 <String>]
 [-ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>] [-Id <String>]
 [-SharedWith <IMicrosoftGraphPlannerUserIds>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property details in groups

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

### -CategoryDescriptionCategory1
The label associated with Category 1

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

### -CategoryDescriptionCategory2
The label associated with Category 2

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

### -CategoryDescriptionCategory3
The label associated with Category 3

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

### -CategoryDescriptionCategory4
The label associated with Category 4

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

### -CategoryDescriptionCategory5
The label associated with Category 5

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

### -CategoryDescriptionCategory6
The label associated with Category 6

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

### -ContextDetails
plannerPlanContextDetailsCollection

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanContextDetailsCollection
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

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

### -Id
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsPlannerIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
key: plannerPlan-id of plannerPlan

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

### -SharedWith
plannerUserIds

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUserIds
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

### Microsoft.Graph.PowerShell.Models.IGroupsPlannerIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlanDetails>: plannerPlanDetails
  - `[Id <String>]`: Read-only.
  - `[CategoryDescriptionCategory1 <String>]`: The label associated with Category 1
  - `[CategoryDescriptionCategory2 <String>]`: The label associated with Category 2
  - `[CategoryDescriptionCategory3 <String>]`: The label associated with Category 3
  - `[CategoryDescriptionCategory4 <String>]`: The label associated with Category 4
  - `[CategoryDescriptionCategory5 <String>]`: The label associated with Category 5
  - `[CategoryDescriptionCategory6 <String>]`: The label associated with Category 6
  - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
  - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds

INPUTOBJECT <IGroupsPlannerIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: group-id of group
  - `[PlannerBucketId <String>]`: key: plannerBucket-id of plannerBucket
  - `[PlannerPlanId <String>]`: key: plannerPlan-id of plannerPlan
  - `[PlannerTaskId <String>]`: key: plannerTask-id of plannerTask

## RELATED LINKS

