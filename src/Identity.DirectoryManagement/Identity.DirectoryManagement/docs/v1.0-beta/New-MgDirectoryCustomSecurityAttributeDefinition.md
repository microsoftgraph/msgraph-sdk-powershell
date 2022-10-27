---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectorycustomsecurityattributedefinition
schema: 2.0.0
---

# New-MgDirectoryCustomSecurityAttributeDefinition

## SYNOPSIS
Create a new customSecurityAttributeDefinition object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectoryCustomSecurityAttributeDefinition [-AdditionalProperties <Hashtable>]
 [-AllowedValues <IMicrosoftGraphAllowedValue[]>] [-AttributeSet <String>] [-Description <String>]
 [-Id <String>] [-IsCollection] [-IsSearchable] [-Name <String>] [-Status <String>] [-Type <String>]
 [-UsePreDefinedValuesOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDirectoryCustomSecurityAttributeDefinition
 -BodyParameter <IMicrosoftGraphCustomSecurityAttributeDefinition> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new customSecurityAttributeDefinition object.

## EXAMPLES

### Example 1: Using the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Active projects for user"
	IsCollection = $true
	IsSearchable = $true
	Name = "Project"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $true
	AllowedValues = @(
		@{
			Id = "Alpine"
			IsActive = $true
		}
		@{
			Id = "Baker"
			IsActive = $true
		}
		@{
			Id = "Cascade"
			IsActive = $true
		}
	)
}
New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```

This example shows how to use the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Target completion date"
	IsCollection = $false
	IsSearchable = $true
	Name = "ProjectDate"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $false
}
New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```

This example shows how to use the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Active projects for user"
	IsCollection = $true
	IsSearchable = $true
	Name = "Project"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $true
}
New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```

This example shows how to use the New-MgDirectoryCustomSecurityAttributeDefinition Cmdlet.
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

### -AllowedValues
Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query.
For example, /directory/customSecurityAttributeDefinitions$expand=allowedValues.
To construct, please use Get-Help -Online and see NOTES section for ALLOWEDVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAllowedValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSet
Name of the attribute set.
Case insensitive.

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

### -BodyParameter
customSecurityAttributeDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of the custom security attribute.
Can be up to 128 characters long and include Unicode characters.
Can be changed later.

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

### -IsCollection
Indicates whether multiple values can be assigned to the custom security attribute.
Cannot be changed later.
If type is set to Boolean, isCollection cannot be set to true.

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

### -IsSearchable
Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values.
Cannot be changed later.

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

### -Name
Name of the custom security attribute.
Must be unique within an attribute set.
Can be up to 32 characters long and include Unicode characters.
Cannot contain spaces or special characters.
Cannot be changed later.
Case insensitive.

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

### -Status
Specifies whether the custom security attribute is active or deactivated.
Acceptable values are Available and Deprecated.
Can be changed later.

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

### -Type
Data type for the custom security attribute values.
Supported types are Boolean, Integer, and String.
Cannot be changed later.

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

### -UsePreDefinedValuesOnly
Indicates whether only predefined values can be assigned to the custom security attribute.
If set to false, free-form values are allowed.
Can later be changed from true to false, but cannot be changed from false to true.
If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALLOWEDVALUES <IMicrosoftGraphAllowedValue[]>: Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions$expand=allowedValues.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.

BODYPARAMETER <IMicrosoftGraphCustomSecurityAttributeDefinition>: customSecurityAttributeDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.
  - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
  - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
  - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values. Cannot be changed later.
  - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
  - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are Available and Deprecated. Can be changed later.
  - `[Type <String>]`: Data type for the custom security attribute values. Supported types are Boolean, Integer, and String. Cannot be changed later.
  - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

## RELATED LINKS

