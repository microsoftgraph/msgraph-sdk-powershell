---
external help file:
Module Name: Microsoft.Graph.Identity.Protection
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.protection/remove-mgriskyuser
schema: 2.0.0
---

# Remove-MgRiskyUser

## SYNOPSIS
Delete entity from riskyUsers

## SYNTAX

### Delete (Default)
```
Remove-MgRiskyUser -RiskyUserId <String> [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-MgRiskyUser -InputObject <IIdentityProtectionIdentity> [-IfMatch <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete entity from riskyUsers

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

### -IfMatch
ETag

```yaml
Type: System.String
Parameter Sets: (All)
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
Parameter Sets: DeleteViaIdentity
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

### -RiskyUserId
key: riskyUser-id of riskyUser

```yaml
Type: System.String
Parameter Sets: Delete
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

### Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IIdentityProtectionIdentity>: Identity Parameter
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

