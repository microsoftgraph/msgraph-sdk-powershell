---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectorycustomsecurityattributedefinition
schema: 2.0.0
---

# New-MgDirectoryCustomSecurityAttributeDefinition

## SYNOPSIS
Create new navigation property to customSecurityAttributeDefinitions for directory

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDirectoryCustomSecurityAttributeDefinition [-AdditionalProperties <Hashtable>]
 [-AllowedValues <IMicrosoftGraphAllowedValue[]>] [-AttributeSet <String>] [-Description <String>]
 [-Id <String>] [-IsCollection] [-IsSearchable] [-Name <String>] [-Status <String>] [-Type <String>]
 [-UsePreDefinedValuesOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDirectoryCustomSecurityAttributeDefinition
 -BodyParameter <IMicrosoftGraphCustomSecurityAttributeDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to customSecurityAttributeDefinitions for directory

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedValues
.
To construct, please use Get-Help -Online and see NOTES section for ALLOWEDVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAllowedValue[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSet
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
customSecurityAttributeDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCollection
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSearchable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsePreDefinedValuesOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALLOWEDVALUES <IMicrosoftGraphAllowedValue[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsActive <Boolean?>]`: 

BODYPARAMETER <IMicrosoftGraphCustomSecurityAttributeDefinition>: customSecurityAttributeDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: 
  - `[AttributeSet <String>]`: 
  - `[Description <String>]`: 
  - `[IsCollection <Boolean?>]`: 
  - `[IsSearchable <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[Status <String>]`: 
  - `[Type <String>]`: 
  - `[UsePreDefinedValuesOnly <Boolean?>]`: 

## RELATED LINKS

