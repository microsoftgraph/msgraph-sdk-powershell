---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.governance/get-mgidentitygovernancelifecycleworkflowsetting
schema: 2.0.0
---

# Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting

## SYNOPSIS
Read the properties and relationships of a lifecycleManagementSettings object.

## SYNTAX

```
Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of a lifecycleManagementSettings object.

## EXAMPLES

### Example 1: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting
```

This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityGovernanceLifecycleManagementSettings

## NOTES

ALIASES

## RELATED LINKS

