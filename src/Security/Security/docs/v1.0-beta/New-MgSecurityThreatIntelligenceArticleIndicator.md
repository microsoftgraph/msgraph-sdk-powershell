---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritythreatintelligencearticleindicator
schema: 2.0.0
---

# New-MgSecurityThreatIntelligenceArticleIndicator

## SYNOPSIS
Create new navigation property to articleIndicators for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityThreatIntelligenceArticleIndicator [-AdditionalProperties <Hashtable>] [-Artifact <Hashtable>]
 [-Id <String>] [-Source <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSecurityThreatIntelligenceArticleIndicator -BodyParameter <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to articleIndicators for security

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

### -Artifact
artifact

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
articleIndicator

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

### -Source
indicatorSource

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityArticleIndicator

## NOTES

ALIASES

## RELATED LINKS

