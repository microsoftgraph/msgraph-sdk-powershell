---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/add-mgenvironment
schema: 2.0.0
---

# Add-MgEnvironment

## SYNOPSIS
 Adds Microsoft Graph environment to the settings file.

## SYNTAX

```
Add-MgEnvironment [-Name] <String> [-AzureADEndpoint] <String> [-GraphEndpoint] <String>
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
 Adds Microsoft Graph environment to the settings file.

## EXAMPLES

### Example 1: Add user defined environment
```powershell
PS C:\> Add-MgEnvironment -Name "Canary" -GraphEndpoint "https://canary.graph.microsoft.com" -AzureADEndpoint "https://login.microsoftonline.com"
Name     AzureADEndpoint                      GraphEndpoint                 Type
----     ---------------                      -------------                 ----
Canary    https://login.microsoftonline.com   https://microsoftgraph.com User-defined
```

Adds user defined environment.

## PARAMETERS

### -AzureADEndpoint
The base URL for Azure AD endpoint to get access tokens for Microsoft Graph endpoint.

```yaml
Type: String
Parameter Sets: (All)
Aliases: AzureADUrl

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -GraphEndpoint
The service root endpoint for Microsoft Graph.

```yaml
Type: String
Parameter Sets: (All)
Aliases: GraphUrl

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The environment name.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

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

### System.String
## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.Models.GraphEnvironment
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/add-mgenvironment](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/add-mgenvironment)

