---
external help file: Microsoft.Graph.Authentication-help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission
schema: 2.0.0
---

# Find-MgGraphPermission

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### Search
```
Find-MgGraphPermission [-SearchString] <String> [-ExactMatch] [-PermissionType <String>] [-Online]
 [<CommonParameters>]
```

### All
```
Find-MgGraphPermission [-PermissionType <String>] [-Online] [-All] [<CommonParameters>]
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

### -All
{{ Fill All Description }}

```yaml
Type: SwitchParameter
Parameter Sets: All
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExactMatch
{{ Fill ExactMatch Description }}

```yaml
Type: SwitchParameter
Parameter Sets: Search
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Online
{{ Fill Online Description }}

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionType
{{ Fill PermissionType Description }}

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Accepted values: Any, Delegated, Application

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchString
{{ Fill SearchString Description }}

```yaml
Type: String
Parameter Sets: Search
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

### System.String

## OUTPUTS

### Microsoft.Graph.Custom.Permission

## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission)

