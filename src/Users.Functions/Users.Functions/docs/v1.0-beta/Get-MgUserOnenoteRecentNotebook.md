---
external help file:
Module Name: Microsoft.Graph.Users.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/get-mguseronenoterecentnotebook
schema: 2.0.0
---

# Get-MgUserOnenoteRecentNotebook

## SYNOPSIS
Invoke function getRecentNotebooks

## SYNTAX

### Get (Default)
```
Get-MgUserOnenoteRecentNotebook -IncludePersonalNotebooks -UserId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserOnenoteRecentNotebook -InputObject <IUsersFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getRecentNotebooks

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -IncludePersonalNotebooks
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersFunctionsIdentity
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
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecentNotebook

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IUsersFunctionsIdentity>: Identity Parameter
  - `[CalendarId <String>]`: key: id of calendar
  - `[ContactFolderId <String>]`: key: id of contactFolder
  - `[EndDateTime <String>]`: 
  - `[EventId <String>]`: key: id of event
  - `[IncludePersonalNotebooks <Boolean?>]`: 
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[RoomList <String>]`: 
  - `[Skip <Int32?>]`: 
  - `[StartDateTime <String>]`: 
  - `[TimeZoneStandard <String>]`: 
  - `[Top <Int32?>]`: 
  - `[User <String>]`: 
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

