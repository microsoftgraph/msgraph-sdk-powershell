---
external help file:
Module Name: Microsoft.Graph.Beta.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.planner/update-mgplannertaskdetail
schema: 2.0.0
---

# Update-MgBetaPlannerTaskDetail

## SYNOPSIS
Update the properties of **plannerTaskDetails** object.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaPlannerTaskDetail -PlannerTaskId <String> [-AdditionalProperties <Hashtable>]
 [-Checklist <Hashtable>] [-Description <String>] [-Id <String>] [-Notes <IMicrosoftGraphItemBody>]
 [-PreviewType <String>] [-References <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaPlannerTaskDetail -PlannerTaskId <String> -BodyParameter <IMicrosoftGraphPlannerTaskDetails1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaPlannerTaskDetail -InputObject <IPlannerIdentity> -BodyParameter <IMicrosoftGraphPlannerTaskDetails1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaPlannerTaskDetail -InputObject <IPlannerIdentity> [-AdditionalProperties <Hashtable>]
 [-Checklist <Hashtable>] [-Description <String>] [-Id <String>] [-Notes <IMicrosoftGraphItemBody>]
 [-PreviewType <String>] [-References <Hashtable>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of **plannerTaskDetails** object.

## EXAMPLES

### Example 1: Using the Update-MgBetaPlannerTaskDetail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	PreviewType = "noPreview"
	References = @{
		"Http%3A//developer%2Emicrosoft%2Ecom" = @{
			"@odata.type" = "Microsoft.Graph.Beta.plannerExternalReference"
			Alias = "Documentation"
			PreviewPriority = " !"
			Type = "Other"
		}
		"Https%3A//developer%2Emicrosoft%2Ecom/graph/graph-explorer" = @{
			"@odata.type" = "Microsoft.Graph.Beta.plannerExternalReference"
			PreviewPriority = "  !!"
		}
		"Http%3A//www%2Ebing%2Ecom" = $null
	}
	Checklist = @{
		"95e27074-6c4a-447a-aa24-9d718a0b86fa" = @{
			"@odata.type" = "Microsoft.Graph.Beta.plannerChecklistItem"
			Title = "Update task details"
			IsChecked = $true
		}
		"D280ed1a-9f6b-4f9c-a962-fb4d00dc50ff" = @{
			"@odata.type" = "Microsoft.Graph.Beta.plannerChecklistItem"
			IsChecked = $true
		}
		"A93c93c5-10a6-4167-9551-8bafa09967a7" = $null
	}
}
Update-MgBetaPlannerTaskDetail -PlannerTaskId $plannerTaskId -BodyParameter $params
```

This example shows how to use the Update-MgBetaPlannerTaskDetail Cmdlet.
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
plannerTaskDetails
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Checklist
plannerChecklistItems

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

### -Description
Description of the task.

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

### -Notes
itemBody
To construct, please use Get-Help -Online and see NOTES section for NOTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphItemBody
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

### -PreviewType
plannerPreviewType

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

### -References
plannerExternalReferences

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails1

### Microsoft.Graph.Beta.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerTaskDetails1>: plannerTaskDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description of the task.
  - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[PreviewType <String>]`: plannerPreviewType
  - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

INPUTOBJECT <IPlannerIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[PlannerBucketId <String>]`: key: id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: id of plannerDelta
  - `[PlannerPlanId <String>]`: key: id of plannerPlan
  - `[PlannerRosterId <String>]`: key: id of plannerRoster
  - `[PlannerRosterMemberId <String>]`: key: id of plannerRosterMember
  - `[PlannerTaskId <String>]`: key: id of plannerTask
  - `[UserId <String>]`: key: id of user

NOTES <IMicrosoftGraphItemBody>: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

## RELATED LINKS

