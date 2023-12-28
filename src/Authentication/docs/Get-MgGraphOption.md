---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/get-mggraphoption
schema: 2.0.0
---

# Get-MgGraphOption

## SYNOPSIS
Gets global configurations that apply to the SDK. For example, check if Web Account Manager (WAM) support has been enabled.

## SYNTAX

```
Get-MgGraphOption [<CommonParameters>]
```

## DESCRIPTION
Gets global configurations that apply to the SDK. For example, check if Web Account Manager (WAM) support has been enabled.

## EXAMPLES

### Example 1: Check if WAM support has been enabled
```powershell
PS C:\> Get-MgGraphOption
EnableWAMForMSGraph 
--------------------
                True
```

Confirms if WAM support has been enabled.

## PARAMETERS

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.IGraphOption

## NOTES

## RELATED LINKS
