---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mgenvironment
schema: 2.0.0
---

# Get-MgRequestContext

## SYNOPSIS
Gets graph request context details

## SYNTAX

```
Get-MgRequestContext [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Gets graph request context details

## EXAMPLES

### Example 1: Get request context
```powershell
PS C:\> Get-MgRequestContext
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```

Gets graph request context details

## PARAMETERS

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

### None
## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.Core.Interfaces.IRequestContext
## NOTES

## RELATED LINKS
