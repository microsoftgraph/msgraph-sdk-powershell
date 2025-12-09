---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/set-mgenvironment
schema: 2.0.0
---

# Set-MgRequestContext

## SYNOPSIS
Sets request context for Microsoft Graph invocations

## SYNTAX

```
Set-MgRequestContext [-RetryDelay <Int32>] [-MaxRetry <Int32>] [-RetriesTimeLimit <Int32>]
 [-ClientTimeout <Int32>] [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Sets request context for Microsoft Graph invocations

## EXAMPLES

### Example 1: Set Http client timeout in seconds
```powershell
PS C:\> Set-MgRequestContext -ClientTimeout 5
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:00
```

Sets Http client timeout in seconds.

### Example 2: Set the maximum time in seconds allowed for request retries
```powershell
PS C:\> Set-MgRequestContext -RetriesTimeLimit 2
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```

Sets the maximum time in seconds allowed for request retries.

### Example 3: Set the maximum number of retries for a request
```powershell
PS C:\> Set-MgRequestContext -MaxRetry 2
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```

Sets the maximum number of retries for a request.

### Example 4: Set the waiting time in seconds before retrying a request
```powershell
PS C:\> Set-MgRequestContext -RetryDelay 3
ClientTimeout     RetryDelay                      MaxRetry                 RetriesTimeLimit
-------------     ----------                      --------                 ----------------
00:00:05                   3                             2                         00:00:02
```

Sets the waiting time in seconds before retrying a request.

## PARAMETERS

### -ClientTimeout
Sets the HTTP client timeout in seconds.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -MaxRetry
Sets the maximum number of retries for a request with a maximum value of 10.
This defaults to 3.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
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

### -RetriesTimeLimit
Sets the maximum time in seconds allowed for request retries.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -RetryDelay
Sets the waiting time in seconds before retrying a request with a maximum value of 180 seconds.
This defaults to 3 seconds.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
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

### System.Int32
## OUTPUTS

### Microsoft.Graph.PowerShell.Authentication.Core.Interfaces.IRequestContext
## NOTES

## RELATED LINKS
