---
external help file:
Module Name: Microsoft.Graph.Identity.Protection
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.protection/get-mgidentityriskeventidentityriskeventidentityriskevent
schema: 2.0.0
---

# Get-MgIdentityRiskEventIdentityRiskEventIdentityRiskEvent

## SYNOPSIS
Get entity from identityRiskEvents by key

## SYNTAX

### List (Default)
```
Get-MgIdentityRiskEventIdentityRiskEventIdentityRiskEvent [-Count] [-ExpandProperty <String[]>]
 [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [<CommonParameters>]
```

### Get
```
Get-MgIdentityRiskEventIdentityRiskEventIdentityRiskEvent -IdentityRiskEventId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgIdentityRiskEventIdentityRiskEventIdentityRiskEvent -InputObject <IIdentityProtectionIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get entity from identityRiskEvents by key

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
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -IdentityRiskEventId
key: identityRiskEvent-id of identityRiskEvent

```yaml
Type: System.String
Parameter Sets: Get
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityProtectionIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Top

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityRiskEvent

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

