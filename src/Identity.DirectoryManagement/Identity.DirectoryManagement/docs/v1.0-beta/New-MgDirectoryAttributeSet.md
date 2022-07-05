---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryattributeset
schema: 2.0.0
---

# New-MgDirectoryAttributeSet

## SYNOPSIS
Create new navigation property to attributeSets for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectoryAttributeSet [-AdditionalProperties <Hashtable>] [-Description <String>] [-Id <String>]
 [-MaxAttributesPerSet <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDirectoryAttributeSet -BodyParameter <IMicrosoftGraphAttributeSet> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to attributeSets for directory

## EXAMPLES

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

### -BodyParameter
attributeSet
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeSet
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description of the attribute set.
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

### -MaxAttributesPerSet
Maximum number of custom security attributes that can be defined in this attribute set.
Default value is null.
If not specified, the administrator can add up to the maximum of 500 active attributes per tenant.
Can be changed later.

```yaml
Type: System.Int32
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeSet

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeSet

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAttributeSet>: attributeSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[MaxAttributesPerSet <Int32?>]`: Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.

## RELATED LINKS

