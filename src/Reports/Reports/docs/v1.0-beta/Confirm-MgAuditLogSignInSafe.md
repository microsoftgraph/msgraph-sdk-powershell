---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/confirm-mgauditlogsigninsafe
schema: 2.0.0
---

# Confirm-MgAuditLogSignInSafe

## SYNOPSIS
Allow admins to mark an event in Azure AD sign in logs as safe.
Admins can either mark the events flagged as risky by Azure AD Identity Protection as safe, or they can mark unflagged events as safe.
For details about investigating Identity Protection risks, see How to investigate risk.

## SYNTAX

### ConfirmExpanded (Default)
```
Confirm-MgAuditLogSignInSafe [-AdditionalProperties <Hashtable>] [-RequestIds <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Confirm
```
Confirm-MgAuditLogSignInSafe
 -BodyParameter <IPaths1Yhfzi3AuditlogsSigninsMicrosoftGraphConfirmsafePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Allow admins to mark an event in Azure AD sign in logs as safe.
Admins can either mark the events flagged as risky by Azure AD Identity Protection as safe, or they can mark unflagged events as safe.
For details about investigating Identity Protection risks, see How to investigate risk.

## EXAMPLES

### Example 1: Using the Confirm-MgAuditLogSignInSafe Cmdlet
```powershell
Import-Module Microsoft.Graph.Reports
$params = @{
	RequestIds = @(
		"5a0c76d2-cb57-4ece-9bc1-c323178f116a"
		"96609214-09ef-4f80-9d4a-ace5fceecaec"
		"05020696-4eb8-45a3-918f-8f8bb7ad6015"
	)
}
Confirm-MgAuditLogSignInSafe -BodyParameter $params
```

This example shows how to use the Confirm-MgAuditLogSignInSafe Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ConfirmExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Yhfzi3AuditlogsSigninsMicrosoftGraphConfirmsafePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Confirm
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

### -RequestIds
.

```yaml
Type: System.String[]
Parameter Sets: ConfirmExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Yhfzi3AuditlogsSigninsMicrosoftGraphConfirmsafePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Yhfzi3AuditlogsSigninsMicrosoftGraphConfirmsafePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RequestIds <String[]>]`: 

## RELATED LINKS

