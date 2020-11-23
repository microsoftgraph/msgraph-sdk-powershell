---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationtemplate
schema: 2.0.0
---

# New-MgApplicationTemplate

## SYNOPSIS
Add new entity to applicationTemplates

## SYNTAX

### CreateExpanded (Default)
```
New-MgApplicationTemplate [-AdditionalProperties <Hashtable>] [-Categories <String[]>] [-Description <String>]
 [-DisplayName <String>] [-HomePageUrl <String>] [-Id <String>] [-LogoUrl <String>] [-Publisher <String>]
 [-SupportedProvisioningTypes <String[]>] [-SupportedSingleSignOnModes <String[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgApplicationTemplate -BodyParameter <IMicrosoftGraphApplicationTemplate> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to applicationTemplates

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

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
applicationTemplate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphApplicationTemplate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

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
.

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

### -HomePageUrl
.

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

### -LogoUrl
.

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

### -Publisher
.

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

### -SupportedProvisioningTypes
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedSingleSignOnModes
.

```yaml
Type: String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplicationTemplate
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplicationTemplate
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphApplicationTemplate\>: applicationTemplate
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Categories \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[HomePageUrl \<String\>\]: 
  \[LogoUrl \<String\>\]: 
  \[Publisher \<String\>\]: 
  \[SupportedProvisioningTypes \<String\[\]\>\]: 
  \[SupportedSingleSignOnModes \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationtemplate](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgapplicationtemplate)

