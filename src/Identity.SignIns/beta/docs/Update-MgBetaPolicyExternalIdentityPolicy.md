---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetapolicyexternalidentitypolicy
schema: 2.0.0
---

# Update-MgBetaPolicyExternalIdentityPolicy

## SYNOPSIS
Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave a Microsoft Entra tenant via self-service controls.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaPolicyExternalIdentityPolicy [-AdditionalProperties <Hashtable>]
 [-AllowDeletedIdentitiesDataRemoval] [-AllowExternalIdentitiesToLeave] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaPolicyExternalIdentityPolicy -BodyParameter <IMicrosoftGraphExternalIdentitiesPolicy> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave a Microsoft Entra tenant via self-service controls.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowDeletedIdentitiesDataRemoval
Reserved for future use.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowExternalIdentitiesToLeave
Defines whether external users can leave the guest tenant.
If set to false, self-service controls are disabled, and the admin of the guest tenant must manually remove the external user from the guest tenant.
When the external user leaves the tenant, their data in the guest tenant is first soft-deleted then permanently deleted in 30 days.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
externalIdentitiesPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalIdentitiesPolicy
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for this policy.
Required.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for this policy.
Required.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalIdentitiesPolicy

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalIdentitiesPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphExternalIdentitiesPolicy>`: externalIdentitiesPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowDeletedIdentitiesDataRemoval <Boolean?>]`: Reserved for future use.
  - `[AllowExternalIdentitiesToLeave <Boolean?>]`: Defines whether external users can leave the guest tenant. If set to false, self-service controls are disabled, and the admin of the guest tenant must manually remove the external user from the guest tenant. When the external user leaves the tenant, their data in the guest tenant is first soft-deleted then permanently deleted in 30 days.

## RELATED LINKS

