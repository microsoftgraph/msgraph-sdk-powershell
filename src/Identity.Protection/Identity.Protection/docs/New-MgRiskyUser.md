---
external help file:
Module Name: Microsoft.Graph.Identity.Protection
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.protection/new-mgriskyuser
schema: 2.0.0
---

# New-MgRiskyUser

## SYNOPSIS
Add new entity to riskyUsers

## SYNTAX

### CreateExpanded (Default)
```
New-MgRiskyUser [-History <IMicrosoftGraphRiskyUserHistoryItem[]>] [-Id <String>] [-IsDeleted] [-IsGuest]
 [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>]
 [-RiskState <String>] [-UserDisplayName <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgRiskyUser -BodyParameter <IMicrosoftGraphRiskyUser> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to riskyUsers

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
riskyUser
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -History
.
To construct, see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsDeleted
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsGuest
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsProcessing
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskDetail
riskDetail

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskLastUpdatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskLevel
riskLevel

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskState
riskState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserPrincipalName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphRiskyUser>: riskyUser
  - `[Id <String>]`: Read-only.
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
    - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
    - `[IsDeleted <Boolean?>]`: 
    - `[IsGuest <Boolean?>]`: 
    - `[IsProcessing <Boolean?>]`: 
    - `[RiskDetail <String>]`: riskDetail
    - `[RiskLastUpdatedDateTime <DateTime?>]`: 
    - `[RiskLevel <String>]`: riskLevel
    - `[RiskState <String>]`: riskState
    - `[UserDisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[ActivityDetail <String>]`: riskDetail
    - `[ActivityEventTypes <String[]>]`: 
    - `[InitiatedBy <String>]`: 
    - `[UserId <String>]`: 
  - `[IsDeleted <Boolean?>]`: 
  - `[IsGuest <Boolean?>]`: 
  - `[IsProcessing <Boolean?>]`: 
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskLastUpdatedDateTime <DateTime?>]`: 
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

#### HISTORY <IMicrosoftGraphRiskyUserHistoryItem[]>: .
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
  - `[IsDeleted <Boolean?>]`: 
  - `[IsGuest <Boolean?>]`: 
  - `[IsProcessing <Boolean?>]`: 
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskLastUpdatedDateTime <DateTime?>]`: 
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[ActivityDetail <String>]`: riskDetail
  - `[ActivityEventTypes <String[]>]`: 
  - `[InitiatedBy <String>]`: 
  - `[UserId <String>]`: 

## RELATED LINKS

