---
external help file:
Module Name: Microsoft.Graph.Identity.DirectorySettings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorysettings/new-mgsettingdirectorysetting
schema: 2.0.0
---

# New-MgSettingDirectorySetting

## SYNOPSIS
Add new entity to settings

## SYNTAX

### CreateExpanded (Default)
```
New-MgSettingDirectorySetting [-DisplayName <String>] [-Id <String>] [-TemplateId <String>]
 [-Values <IMicrosoftGraphSettingValue[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSettingDirectorySetting -BodyParameter <IMicrosoftGraphDirectorySetting> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to settings

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
directorySetting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySetting
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
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
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -TemplateId
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
Dynamic: False
```

### -Values
.
To construct, see NOTES section for VALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSettingValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySetting

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectorySetting

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphDirectorySetting>: directorySetting
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[TemplateId <String>]`: 
  - `[Values <IMicrosoftGraphSettingValue[]>]`: 
    - `[Name <String>]`: Name of the setting (as defined by the groupSettingTemplate).
    - `[Value <String>]`: Value of the setting.

#### VALUES <IMicrosoftGraphSettingValue[]>: .
  - `[Name <String>]`: Name of the setting (as defined by the groupSettingTemplate).
  - `[Value <String>]`: Value of the setting.

## RELATED LINKS

