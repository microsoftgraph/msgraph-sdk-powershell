---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgpolicyauthenticationmethodpolicy
schema: 2.0.0
---

# Get-MgPolicyAuthenticationMethodPolicy

## SYNOPSIS
The authentication methods and the users that are allowed to use them to sign in and perform multifactor authentication (MFA) in Azure Active Directory (Azure AD).

## SYNTAX

```
Get-MgPolicyAuthenticationMethodPolicy [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
The authentication methods and the users that are allowed to use them to sign in and perform multifactor authentication (MFA) in Azure Active Directory (Azure AD).

## EXAMPLES

### Example 1: Using the Get-MgPolicyAuthenticationMethodPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyAuthenticationMethodPolicy
```

This example shows how to use the Get-MgPolicyAuthenticationMethodPolicy Cmdlet.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationMethodsPolicy

## NOTES

ALIASES

## RELATED LINKS

