---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/get-mgbetaentitlementmanagementsetting
schema: 2.0.0
---

# Get-MgBetaEntitlementManagementSetting

## SYNOPSIS
Retrieve the properties of an entitlementManagementSettings object.

## SYNTAX

```
Get-MgBetaEntitlementManagementSetting [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Retrieve the properties of an entitlementManagementSettings object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementSetting
```

Id        DaysUntilExternalUserDeletedAfterBlocked ExternalUserLifecycleAction
--        ---------------------------------------- ---------------------------
singleton 30                                       BlockSignInAndDelete

## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEntitlementManagementSettings

## NOTES

ALIASES

## RELATED LINKS

