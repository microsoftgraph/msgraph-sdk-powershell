---
external help file:
Module Name: Microsoft.Graph.Identity.Protection
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.protection/new-mgriskyuserhistory
schema: 2.0.0
---

# New-MgRiskyUserHistory

## SYNOPSIS
Create new navigation property to history for riskyUsers

## SYNTAX

### CreateExpanded (Default)
```
New-MgRiskyUserHistory -RiskyUserId <String> [-ActivityDetail <String>] [-ActivityEventTypes <String[]>]
 [-History <IMicrosoftGraphRiskyUserHistoryItem[]>] [-Id <String>] [-InitiatedBy <String>] [-IsDeleted]
 [-IsGuest] [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>]
 [-RiskState <String>] [-UserDisplayName <String>] [-UserId <String>] [-UserPrincipalName <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgRiskyUserHistory -RiskyUserId <String> -BodyParameter <IMicrosoftGraphRiskyUserHistoryItem> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgRiskyUserHistory -InputObject <IIdentityProtectionIdentity>
 -BodyParameter <IMicrosoftGraphRiskyUserHistoryItem> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgRiskyUserHistory -InputObject <IIdentityProtectionIdentity> [-ActivityDetail <String>]
 [-ActivityEventTypes <String[]>] [-History <IMicrosoftGraphRiskyUserHistoryItem[]>] [-Id <String>]
 [-InitiatedBy <String>] [-IsDeleted] [-IsGuest] [-IsProcessing] [-RiskDetail <String>]
 [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>] [-RiskState <String>] [-UserDisplayName <String>]
 [-UserId <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to history for riskyUsers

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

### -ActivityDetail
riskDetail

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ActivityEventTypes
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
riskyUserHistoryItem
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InitiatedBy
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IsDeleted
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskyUserId
key: riskyUser-id of riskyUser

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphRiskyUserHistoryItem>: riskyUserHistoryItem
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

#### INPUTOBJECT <IIdentityProtectionIdentity>: Identity Parameter
  - `[AnonymousIPRiskEventId <String>]`: key: anonymousIpRiskEvent-id of anonymousIpRiskEvent
  - `[IdentityRiskEventId <String>]`: key: identityRiskEvent-id of identityRiskEvent
  - `[ImpossibleTravelRiskEventId <String>]`: key: impossibleTravelRiskEvent-id of impossibleTravelRiskEvent
  - `[LeakedCredentialsRiskEventId <String>]`: key: leakedCredentialsRiskEvent-id of leakedCredentialsRiskEvent
  - `[MalwareRiskEventId <String>]`: key: malwareRiskEvent-id of malwareRiskEvent
  - `[RiskDetectionId <String>]`: key: riskDetection-id of riskDetection
  - `[RiskyUserHistoryItemId <String>]`: key: riskyUserHistoryItem-id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: riskyUser-id of riskyUser
  - `[SuspiciousIPRiskEventId <String>]`: key: suspiciousIpRiskEvent-id of suspiciousIpRiskEvent
  - `[UnfamiliarLocationRiskEventId <String>]`: key: unfamiliarLocationRiskEvent-id of unfamiliarLocationRiskEvent

## RELATED LINKS

