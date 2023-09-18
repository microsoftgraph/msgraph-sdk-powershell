---
external help file: Microsoft.Graph.Authentication-help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphcommand
schema: 2.0.0
---

# Find-MgGraphCommand

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### FindByCommandOrUri (Default)
```
Find-MgGraphCommand [-ApiVersion <String>] [-InputObject] <Object[]> [<CommonParameters>]
```

### FindByUri
```
Find-MgGraphCommand [-Uri] <String[]> [-Method <String>] [-ApiVersion <String>] [<CommonParameters>]
```

### FindByCommand
```
Find-MgGraphCommand [-ApiVersion <String>] -Command <String[]> [<CommonParameters>]
```

## DESCRIPTION
{{ Fill in the Description }}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -ApiVersion
{{ Fill ApiVersion Description }}

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Accepted values: v1.0, beta

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Command
{{ Fill Command Description }}

```yaml
Type: String[]
Parameter Sets: FindByCommand
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
{{ Fill InputObject Description }}

```yaml
Type: Object[]
Parameter Sets: FindByCommandOrUri
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Method
{{ Fill Method Description }}

```yaml
Type: String
Parameter Sets: FindByUri
Aliases:
Accepted values: GET, POST, PUT, PATCH, DELETE

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Uri
{{ Fill Uri Description }}

```yaml
Type: String[]
Parameter Sets: FindByUri
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String[]

### System.Object[]

## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand

## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphcommand](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphcommand)

