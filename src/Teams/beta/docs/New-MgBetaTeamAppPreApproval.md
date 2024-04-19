---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/new-mgbetateamapppreapproval
schema: 2.0.0
---

# New-MgBetaTeamAppPreApproval

## SYNOPSIS
Create Preapproval policy associated with a Teams App.

## SYNTAX

```
New-MgBetaTeamAppPreApproval -TeamsAppId <String>
 [-ResourceSpecificApplicationPermissionsAllowedForChats <String[]>]
 [-ResourceSpecificApplicationPermissionsAllowedForTeams <String[]>]
 [-SpecificSensitivityLabelIdsApplicableToTeams <String[]>]
 [-TeamLevelSensitivityLabelCondition <MicrosoftGraphSensitivityLabelCondition?>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create Preapproval policy associated with a Teams App.

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

### -ResourceSpecificApplicationPermissionsAllowedForChats
Resource Specific Permissions Allowed for Chats

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceSpecificApplicationPermissionsAllowedForTeams
Resource Specific Permissions Allowed for Teams

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpecificSensitivityLabelIdsApplicableToTeams
Specific Sensitivity label ids applicable to Teams.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamLevelSensitivityLabelCondition
Label selection mode for Teams.

```yaml
Type: System.Nullable`1[[Microsoft.Graph.Beta.PowerShell.Models.MicrosoftGraphSensitivityLabelCondition, Microsoft.Graph.Beta.Teams.private, Version=2.18.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId
key: id of Teams App

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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppPreApproval

## NOTES

ALIASES

## RELATED LINKS

