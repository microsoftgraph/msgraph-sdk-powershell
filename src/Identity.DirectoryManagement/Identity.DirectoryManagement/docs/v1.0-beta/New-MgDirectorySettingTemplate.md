---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectorysettingtemplate
schema: 2.0.0
---

# New-MgDirectorySettingTemplate

## SYNOPSIS
Add new entity to directorySettingTemplates

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectorySettingTemplate [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-Values <IMicrosoftGraphSettingTemplateValue[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDirectorySettingTemplate -BodyParameter <IMicrosoftGraphDirectorySettingTemplate> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to directorySettingTemplates

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectorySettingTemplate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the template.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name of the template.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Values
Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.
Read-only.
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: IMicrosoftGraphSettingTemplateValue[]
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySettingTemplate
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySettingTemplate
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDirectorySettingTemplate>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: Description of the template. Read-only.
  - `[DisplayName <String>]`: Display name of the template. Read-only.
  - `[Values <IMicrosoftGraphSettingTemplateValue[]>]`: Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.  Read-only.
    - `[DefaultValue <String>]`: Default value for the setting. Read-only.
    - `[Description <String>]`: Description of the setting. Read-only.
    - `[Name <String>]`: Name of the setting. Read-only.
    - `[Type <String>]`: Type of the setting. Read-only.

VALUES <IMicrosoftGraphSettingTemplateValue[]>: Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template. Read-only.
  - `[DefaultValue <String>]`: Default value for the setting. Read-only.
  - `[Description <String>]`: Description of the setting. Read-only.
  - `[Name <String>]`: Name of the setting. Read-only.
  - `[Type <String>]`: Type of the setting. Read-only.

## RELATED LINKS
