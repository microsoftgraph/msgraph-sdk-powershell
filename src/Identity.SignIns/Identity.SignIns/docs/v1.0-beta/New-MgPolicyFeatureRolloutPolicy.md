---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mgpolicyfeaturerolloutpolicy
schema: 2.0.0
---

# New-MgBetaPolicyFeatureRolloutPolicy

## SYNOPSIS
Create a new featureRolloutPolicy object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPolicyFeatureRolloutPolicy [-AdditionalProperties <Hashtable>]
 [-AppliesTo <IMicrosoftGraphDirectoryObject[]>] [-Description <String>] [-DisplayName <String>]
 [-Feature <String>] [-Id <String>] [-IsAppliedToOrganization] [-IsEnabled] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaPolicyFeatureRolloutPolicy -BodyParameter <IMicrosoftGraphFeatureRolloutPolicy1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a new featureRolloutPolicy object.

## EXAMPLES

### Example 1: Using the New-MgBetaPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "PassthroughAuthentication rollout policy"
	Description = "PassthroughAuthentication rollout policy"
	Feature = "passthroughAuthentication"
	IsEnabled = $true
	IsAppliedToOrganization = $false
}
New-MgBetaPolicyFeatureRolloutPolicy -BodyParameter $params
```

This example shows how to use the New-MgBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliesTo
Nullable.
Specifies a list of directoryObjects that feature is enabled for.
To construct, please use Get-Help -Online and see NOTES section for APPLIESTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
featureRolloutPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
A description for this feature rollout policy.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for this feature rollout policy.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Feature
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAppliedToOrganization
Indicates whether this feature rollout policy should be applied to the entire organization.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEnabled
Indicates whether the feature rollout is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy1

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLIESTO <IMicrosoftGraphDirectoryObject[]>: Nullable. Specifies a list of directoryObjects that feature is enabled for.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

BODYPARAMETER <IMicrosoftGraphFeatureRolloutPolicy1>: featureRolloutPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Description <String>]`: A description for this feature rollout policy.
  - `[DisplayName <String>]`: The display name for this  feature rollout policy.
  - `[Feature <String>]`: 
  - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
  - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.

## RELATED LINKS

