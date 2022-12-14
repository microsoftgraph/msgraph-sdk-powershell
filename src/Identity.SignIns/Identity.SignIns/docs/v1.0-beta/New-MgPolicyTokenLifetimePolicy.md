---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mgpolicytokenlifetimepolicy
schema: 2.0.0
---

# New-MgBetaPolicyTokenLifetimePolicy

## SYNOPSIS
Create a new tokenLifetimePolicy object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPolicyTokenLifetimePolicy [-AdditionalProperties <Hashtable>]
 [-AppliesTo <IMicrosoftGraphDirectoryObject[]>] [-Definition <String[]>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsOrganizationDefault] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaPolicyTokenLifetimePolicy -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new tokenLifetimePolicy object.

## EXAMPLES

### Example 1: Using the New-MgBetaPolicyTokenLifetimePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgBetaPolicyTokenLifetimePolicy -BodyParameter $params
```

This example shows how to use the New-MgBetaPolicyTokenLifetimePolicy Cmdlet.
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
.
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
tokenLifetimePolicy

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Definition
A string collection containing a JSON string that defines the rules and settings for a policy.
The syntax for the definition differs for each derived policy type.
Required.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### -IsOrganizationDefault
If set to true, activates this policy.
There can be many policies for the same policy type, but only one can be activated as the organization default.
Optional, default value is false.

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

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLIESTO <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

## RELATED LINKS

