---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/disconnect-graph
schema: 2.0.0
---

# Disconnect-MgGraph

## SYNOPSIS
Once you're signed in, you'll remain signed in until you invoke Disconnect-MgGraph. Microsoft Graph PowerShell automatically refreshes the access token for you and sign-in persists across PowerShell sessions because Microsoft Graph PowerShell securely caches the token.

## SYNTAX

```
Disconnect-MgGraph [-SignOutFromBroker] [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
Use Disconnect-MgGraph to sign out. This clears the persisted MSAL token cache from disk when using CurrentUser context scope, as well as removing the in-memory token cache and authentication record. Use the -SignOutFromBroker switch to additionally remove cached accounts from the Windows broker (WAM); note that the broker store is shared at the OS level, so this can also sign you out of other broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell) that use the same Windows account.

## EXAMPLES

### Example 1: Using Disconnect-MgGraph
```powershell
PS C:\> Disconnect-MgGraph
```

Use Disconnect-MgGraph to sign out.

### Example 2: Sign out and also clear the Windows broker (WAM) cache
```powershell
PS C:\> Disconnect-MgGraph -SignOutFromBroker
```

Signs out and additionally removes cached accounts from the Windows broker (WAM). Because the broker store is shared at the OS level, this can also sign you out of other broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell) using the same Windows account.

## PARAMETERS

### -SignOutFromBroker
Also removes cached accounts for this module from the Windows broker (WAM). Because the broker store is shared at the OS level, this can sign you out of other broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell) that use the same Windows account. Has no effect when the broker is not in use.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.IAuthContext
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/disconnect-graph](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/disconnect-graph)

