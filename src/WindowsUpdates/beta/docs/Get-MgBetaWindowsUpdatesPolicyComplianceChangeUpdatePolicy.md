---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/get-mgbetawindowsupdatespolicycompliancechangeupdatepolicy
schema: 2.0.0
---

# Get-MgBetaWindowsUpdatesPolicyComplianceChangeUpdatePolicy

## SYNOPSIS
The policy this compliance change is a member of.

## SYNTAX

### Get (Default)
```
Get-MgBetaWindowsUpdatesPolicyComplianceChangeUpdatePolicy -ComplianceChangeId <String>
 -UpdatePolicyId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaWindowsUpdatesPolicyComplianceChangeUpdatePolicy -InputObject <IWindowsUpdatesIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
The policy this compliance change is a member of.

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

### -ComplianceChangeId
The unique identifier of complianceChange

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -UpdatePolicyId
The unique identifier of updatePolicy

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatePolicy

## NOTES

ALIASES

Get-MgBetaWuPolicyComplianceChangeUpdatePolicy

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

