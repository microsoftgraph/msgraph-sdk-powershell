---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.signins/new-mgriskyuser
schema: 2.0.0
---

# New-MgRiskyUser

## SYNOPSIS
Create new navigation property to riskyUsers for identityProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgRiskyUser [-AdditionalProperties <Hashtable>] [-History <IMicrosoftGraphRiskyUserHistoryItem[]>]
 [-Id <String>] [-IsDeleted] [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>]
 [-RiskLevel <String>] [-RiskState <String>] [-UserDisplayName <String>] [-UserPrincipalName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgRiskyUser -BodyParameter <IMicrosoftGraphRiskyUser> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to riskyUsers for identityProtection

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
```

Get-MgRiskyUser

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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
```

### -History
The activity related to user risk level change
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
```

### -Id
The unique idenfier for an entity.
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
```

### -IsDeleted
Indicates whether the user is deleted.
Possible values are: true, false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsProcessing
Indicates whether a user's risky state is being processed by the backend.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -RiskLastUpdatedDateTime
The date and time that the risky user was last updated.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -UserDisplayName
Risky user display name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
Risky user principal name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphRiskyUser>`: riskyUser
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: The activity related to user risk level change
    - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: The activity related to user risk level change
    - `[IsDeleted <Boolean?>]`: Indicates whether the user is deleted. Possible values are: true, false.
    - `[IsProcessing <Boolean?>]`: Indicates whether a user's risky state is being processed by the backend.
    - `[RiskDetail <String>]`: riskDetail
    - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[RiskLevel <String>]`: riskLevel
    - `[RiskState <String>]`: riskState
    - `[UserDisplayName <String>]`: Risky user display name.
    - `[UserPrincipalName <String>]`: Risky user principal name.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Activity <IMicrosoftGraphRiskUserActivity>]`: riskUserActivity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Detail <String>]`: riskDetail
      - `[RiskEventTypes <String[]>]`: The type of risk event detected.
    - `[InitiatedBy <String>]`: The ID of actor that does the operation.
    - `[UserId <String>]`: The ID of the user.
  - `[IsDeleted <Boolean?>]`: Indicates whether the user is deleted. Possible values are: true, false.
  - `[IsProcessing <Boolean?>]`: Indicates whether a user's risky state is being processed by the backend.
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: Risky user display name.
  - `[UserPrincipalName <String>]`: Risky user principal name.

`HISTORY <IMicrosoftGraphRiskyUserHistoryItem[]>`: The activity related to user risk level change
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: The activity related to user risk level change
  - `[IsDeleted <Boolean?>]`: Indicates whether the user is deleted. Possible values are: true, false.
  - `[IsProcessing <Boolean?>]`: Indicates whether a user's risky state is being processed by the backend.
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: Risky user display name.
  - `[UserPrincipalName <String>]`: Risky user principal name.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Activity <IMicrosoftGraphRiskUserActivity>]`: riskUserActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Detail <String>]`: riskDetail
    - `[RiskEventTypes <String[]>]`: The type of risk event detected.
  - `[InitiatedBy <String>]`: The ID of actor that does the operation.
  - `[UserId <String>]`: The ID of the user.

## RELATED LINKS

