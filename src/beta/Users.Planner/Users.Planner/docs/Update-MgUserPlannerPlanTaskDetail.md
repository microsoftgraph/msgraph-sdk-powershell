---
external help file:
Module Name: Microsoft.Graph.Users.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.planner/update-mguserplannerplantaskdetail
schema: 2.0.0
---

# Update-MgUserPlannerPlanTaskDetail

## SYNOPSIS
Update the navigation property details in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserPlannerPlanTaskDetail -PlannerPlanId <String> -PlannerTaskId <String> -UserId <String>
 [-Checklist <IMicrosoftGraphPlannerChecklistItems>] [-Description <String>] [-Id <String>]
 [-PreviewType <String>] [-References <IMicrosoftGraphPlannerExternalReferences>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserPlannerPlanTaskDetail -PlannerPlanId <String> -PlannerTaskId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphPlannerTaskDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserPlannerPlanTaskDetail -InputObject <IUsersPlannerIdentity>
 -BodyParameter <IMicrosoftGraphPlannerTaskDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserPlannerPlanTaskDetail -InputObject <IUsersPlannerIdentity>
 [-Checklist <IMicrosoftGraphPlannerChecklistItems>] [-Description <String>] [-Id <String>]
 [-PreviewType <String>] [-References <IMicrosoftGraphPlannerExternalReferences>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property details in users

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
Dynamic: False
```

### -Checklist
plannerChecklistItems

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerChecklistItems
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Description
Description of the task

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersPlannerIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -PlannerTaskId
key: plannerTask-id of plannerTask

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -References
plannerExternalReferences

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerExternalReferences
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTaskDetails

### Microsoft.Graph.PowerShell.Models.IUsersPlannerIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphPlannerTaskDetails>: plannerTaskDetails
  - `[Id <String>]`: Read-only.
  - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
  - `[Description <String>]`: Description of the task
  - `[PreviewType <String>]`: plannerPreviewType
  - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences

#### INPUTOBJECT <IUsersPlannerIdentity>: Identity Parameter
  - `[PlannerBucketId <String>]`: key: plannerBucket-id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: plannerDelta-id of plannerDelta
  - `[PlannerPlanId <String>]`: key: plannerPlan-id of plannerPlan
  - `[PlannerTaskId <String>]`: key: plannerTask-id of plannerTask
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

