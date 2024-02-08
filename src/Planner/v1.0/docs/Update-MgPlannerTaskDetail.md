---
external help file:
Module Name: Microsoft.Graph.Planner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.planner/update-mgplannertaskdetail
schema: 2.0.0
---

# Update-MgPlannerTaskDetail

## SYNOPSIS
Update the navigation property details in planner

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPlannerTaskDetail -PlannerTaskId <String> -IfMatch <String> [-AdditionalProperties <Hashtable>]
 [-Checklist <Hashtable>] [-Description <String>] [-Id <String>] [-PreviewType <String>]
 [-References <Hashtable>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPlannerTaskDetail -PlannerTaskId <String> -IfMatch <String>
 -BodyParameter <IMicrosoftGraphPlannerTaskDetails> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPlannerTaskDetail -InputObject <IPlannerIdentity> -IfMatch <String>
 -BodyParameter <IMicrosoftGraphPlannerTaskDetails> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPlannerTaskDetail -InputObject <IPlannerIdentity> -IfMatch <String>
 [-AdditionalProperties <Hashtable>] [-Checklist <Hashtable>] [-Description <String>] [-Id <String>]
 [-PreviewType <String>] [-References <Hashtable>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property details in planner

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Planner
```

$params = @{
	previewType = "noPreview"
	references = @{
		"http%3A//developer%2Emicrosoft%2Ecom" = @{
			"@odata.type" = "microsoft.graph.plannerExternalReference"
			alias = "Documentation"
			previewPriority = " !"
			type = "Other"
		}
		"https%3A//developer%2Emicrosoft%2Ecom/en-us/graph/graph-explorer" = @{
			"@odata.type" = "microsoft.graph.plannerExternalReference"
			previewPriority = "  !!"
		}
		"http%3A//www%2Ebing%2Ecom" = $null
	}
	checklist = @{
		"95e27074-6c4a-447a-aa24-9d718a0b86fa" = @{
			"@odata.type" = "microsoft.graph.plannerChecklistItem"
			title = "Update task details"
			isChecked = $true
		}
		"d280ed1a-9f6b-4f9c-a962-fb4d00dc50ff" = @{
			"@odata.type" = "microsoft.graph.plannerChecklistItem"
			isChecked = $true
		}
		"a93c93c5-10a6-4167-9551-8bafa09967a7" = $null
	}
}

Update-MgPlannerTaskDetail -PlannerTaskId $plannerTaskId -BodyParameter $params-If-Match W/"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="

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
plannerTaskDetails
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -PlannerTaskId
The unique identifier of plannerTask

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

### -PreviewType
plannerPreviewType

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

### -References
plannerExternalReferences

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails

### Microsoft.Graph.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPlannerTaskDetails>`: plannerTaskDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description of the task.
  - `[PreviewType <String>]`: plannerPreviewType
  - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

`INPUTOBJECT <IPlannerIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[PlannerTaskId <String>]`: The unique identifier of plannerTask
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

