---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.governance/update-mgentitlementmanagementsetting
schema: 2.0.0
---

# Update-MgBetaEntitlementManagementSetting

## SYNOPSIS
Update an existing entitlementManagementSettings object to change one or more of its properties.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaEntitlementManagementSetting [-AdditionalProperties <Hashtable>]
 [-DaysUntilExternalUserDeletedAfterBlocked <Int32>] [-ExternalUserLifecycleAction <String>] [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaEntitlementManagementSetting -BodyParameter <IMicrosoftGraphEntitlementManagementSettings1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update an existing entitlementManagementSettings object to change one or more of its properties.

## EXAMPLES

### Example 1: Using the Update-MgBetaEntitlementManagementSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	ExternalUserLifecycleAction = "None"
}
Update-MgBetaEntitlementManagementSetting -BodyParameter $params
```

This example shows how to use the Update-MgBetaEntitlementManagementSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
entitlementManagementSettings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEntitlementManagementSettings1
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DaysUntilExternalUserDeletedAfterBlocked
If externalUserLifecycleAction is BlockSignInAndDelete, the number of days after an external user is blocked from sign in before their account is deleted.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserLifecycleAction
One of None, BlockSignIn, or BlockSignInAndDelete.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEntitlementManagementSettings1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEntitlementManagementSettings1>: entitlementManagementSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DaysUntilExternalUserDeletedAfterBlocked <Int32?>]`: If externalUserLifecycleAction is BlockSignInAndDelete, the number of days after an external user is blocked from sign in before their account is deleted.
  - `[ExternalUserLifecycleAction <String>]`: One of None, BlockSignIn, or BlockSignInAndDelete.

## RELATED LINKS

