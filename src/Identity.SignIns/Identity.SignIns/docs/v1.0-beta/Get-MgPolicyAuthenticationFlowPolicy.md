---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/get-mgpolicyauthenticationflowpolicy
schema: 2.0.0
---

# Get-MgBetaPolicyAuthenticationFlowPolicy

## SYNOPSIS
Read the properties and relationships of an authenticationFlowsPolicy object.

## SYNTAX

```
Get-MgBetaPolicyAuthenticationFlowPolicy [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of an authenticationFlowsPolicy object.

## EXAMPLES

### Example 1: Using the Get-MgBetaPolicyAuthenticationFlowPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaPolicyAuthenticationFlowPolicy
```

This example shows how to use the Get-MgBetaPolicyAuthenticationFlowPolicy Cmdlet.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationFlowsPolicy

## NOTES

ALIASES

## RELATED LINKS

