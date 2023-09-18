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
### Example 1: Find Command By Uri
```powershell
PS C:\> Find-MgGraphCommand -Uri "/users/{id}"

   APIVersion: v1.0

Command       Module Method URI              OutputType           Permissions
-------       ------ ------ ---              ----------           -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser1 {DeviceManagementApps.Read.All DeviceManagementApps.Rea…
Remove-MgUser Users  DELETE /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…
Update-MgUser Users  PATCH  /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…

   APIVersion: beta

Command       Module Method URI              OutputType          Permissions
-------       ------ ------ ---              ----------          -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser {DeviceManagementApps.Read.All DeviceManagementApps.Read…
Remove-MgUser Users  DELETE /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…
Update-MgUser Users  PATCH  /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…

```
This example finds all commands that call the provided Microsoft Graph URI.

### Example 2: Find Command By Command
```powershell
PS C:\> Find-MgGraphCommand -Command Send-MgUserMessage -ApiVersion beta

   APIVersion: beta

Command            Module        Method URI                                                         OutputType Permissions
-------            ------        ------ ---                                                         ---------- -----------
Send-MgUserMessage Users.Actions POST   /users/{user-id}/messages/{message-id}/microsoft.graph.send            {Mail.Send}
```
This example looks up a command with the provided command name that calls the beta version of the API.

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

