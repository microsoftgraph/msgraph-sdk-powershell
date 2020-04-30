---
external help file:
Module Name: Microsoft.Graph.Users.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.planner/get-mguserplannerplan
schema: 2.0.0
---

# Get-MgUserPlannerPlan

## SYNOPSIS
Get plans from users

## SYNTAX

### List (Default)
```
Get-MgUserPlannerPlan -UserId <String> [-Count] [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>]
 [-Search <String>] [-Select <String[]>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgUserPlannerPlan -PlannerPlanId <String> -UserId <String> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserPlannerPlan -InputObject <IUsersPlannerIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get plans from users

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

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Orderby
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
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
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
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
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IUsersPlannerIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IUsersPlannerIdentity>: Identity Parameter
  - `[PlannerBucketId <String>]`: key: plannerBucket-id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: plannerDelta-id of plannerDelta
  - `[PlannerPlanId <String>]`: key: plannerPlan-id of plannerPlan
  - `[PlannerTaskId <String>]`: key: plannerTask-id of plannerTask
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

