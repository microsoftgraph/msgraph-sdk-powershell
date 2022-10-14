---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgpolicycrosstenantaccesspolicydefault
schema: 2.0.0
---

# Get-MgPolicyCrossTenantAccessPolicyDefault

## SYNOPSIS
Read the default configuration of a cross-tenant access policy.
This default configuration may be the service default assigned by Azure AD (**isServiceDefault** is `true`) or may be customized in your tenant (**isServiceDefault** is `false`).

## SYNTAX

```
Get-MgPolicyCrossTenantAccessPolicyDefault [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Read the default configuration of a cross-tenant access policy.
This default configuration may be the service default assigned by Azure AD (**isServiceDefault** is `true`) or may be customized in your tenant (**isServiceDefault** is `false`).

## EXAMPLES

### Example 1: Using the Get-MgPolicyCrossTenantAccessPolicyDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyCrossTenantAccessPolicyDefault
```

This example shows how to use the Get-MgPolicyCrossTenantAccessPolicyDefault Cmdlet.
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationDefault1

## NOTES

ALIASES

## RELATED LINKS

