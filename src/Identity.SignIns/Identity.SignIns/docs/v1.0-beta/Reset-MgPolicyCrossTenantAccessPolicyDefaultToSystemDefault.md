---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/reset-mgpolicycrosstenantaccesspolicydefaulttosystemdefault
schema: 2.0.0
---

# Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault

## SYNOPSIS
Reset any changes made to the default configuration in a cross-tenant access policy back to the system default.

## SYNTAX

```
Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Reset any changes made to the default configuration in a cross-tenant access policy back to the system default.

## EXAMPLES

### Example 1: Using the Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault
```

This example shows how to use the Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

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

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

## RELATED LINKS

