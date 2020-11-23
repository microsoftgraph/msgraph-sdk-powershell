---
external help file: Microsoft.Graph.Users.Functions-help.xml
Module Name: Microsoft.Graph.Users.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/get-mgusermanagedapppolicy
schema: 2.0.0
---

# Get-MgUserManagedAppPolicy

## SYNOPSIS
Invoke function getManagedAppPolicies

## SYNTAX

### Get (Default)
```
Get-MgUserManagedAppPolicy -UserId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserManagedAppPolicy -InputObject <IUsersFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getManagedAppPolicies

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IUsersFunctionsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IUsersFunctionsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy1
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IUsersFunctionsIdentity\>: Identity Parameter
  \[CalendarId \<String\>\]: key: id of calendar
  \[ContactFolderId \<String\>\]: key: id of contactFolder
  \[EndDateTime \<String\>\]: 
  \[EventId \<String\>\]: key: id of event
  \[IncludePersonalNotebooks \<Boolean?\>\]: 
  \[MailFolderId \<String\>\]: key: id of mailFolder
  \[ManagedDeviceId \<String\>\]: key: id of managedDevice
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[RoomList \<String\>\]: 
  \[Skip \<Int32?\>\]: 
  \[StartDateTime \<String\>\]: 
  \[TimeZoneStandard \<String\>\]: 
  \[TodoTaskListId \<String\>\]: key: id of todoTaskList
  \[Top \<Int32?\>\]: 
  \[User \<String\>\]: 
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/get-mgusermanagedapppolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/get-mgusermanagedapppolicy)

