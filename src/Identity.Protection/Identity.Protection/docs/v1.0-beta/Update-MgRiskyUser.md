---
external help file:
Module Name: Microsoft.Graph.Identity.Protection
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.protection/update-mgriskyuser
schema: 2.0.0
---

# Update-MgRiskyUser

## SYNOPSIS
Update entity in riskyUsers

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRiskyUser -RiskyUserId <String> [-History <IMicrosoftGraphRiskyUserHistoryItem[]>] [-Id <String>]
 [-IsDeleted] [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>]
 [-RiskLevel <String>] [-RiskState <String>] [-UserDisplayName <String>] [-UserPrincipalName <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgRiskyUser -RiskyUserId <String> -BodyParameter <IMicrosoftGraphRiskyUser> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgRiskyUser -InputObject <IIdentityProtectionIdentity> -BodyParameter <IMicrosoftGraphRiskyUser>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgRiskyUser -InputObject <IIdentityProtectionIdentity>
 [-History <IMicrosoftGraphRiskyUserHistoryItem[]>] [-Id <String>] [-IsDeleted] [-IsProcessing]
 [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>] [-RiskState <String>]
 [-UserDisplayName <String>] [-UserPrincipalName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in riskyUsers

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
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -History
.
To construct, see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDeleted
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsProcessing
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -RiskDetail
riskDetail

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

### -RiskLastUpdatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RiskyUserId
key: riskyUser-id of riskyUser

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

### -UserDisplayName
.

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

### -UserPrincipalName
.

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

### Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUser

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRiskyUser>: riskyUser
  - `[Id <String>]`: Read-only.
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
    - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
    - `[IsDeleted <Boolean?>]`: 
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
    - `[ActivityRiskEventTypes <String[]>]`: 
    - `[InitiatedBy <String>]`: 
    - `[UserId <String>]`: 
  - `[IsDeleted <Boolean?>]`: 
  - `[IsProcessing <Boolean?>]`: 
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskLastUpdatedDateTime <DateTime?>]`: 
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

HISTORY <IMicrosoftGraphRiskyUserHistoryItem[]>: .
  - `[History <IMicrosoftGraphRiskyUserHistoryItem[]>]`: 
  - `[IsDeleted <Boolean?>]`: 
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
  - `[ActivityRiskEventTypes <String[]>]`: 
  - `[InitiatedBy <String>]`: 
  - `[UserId <String>]`: 

INPUTOBJECT <IIdentityProtectionIdentity>: Identity Parameter
  - `[RiskDetectionId <String>]`: key: riskDetection-id of riskDetection
  - `[RiskyUserHistoryItemId <String>]`: key: riskyUserHistoryItem-id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: riskyUser-id of riskyUser

## RELATED LINKS

