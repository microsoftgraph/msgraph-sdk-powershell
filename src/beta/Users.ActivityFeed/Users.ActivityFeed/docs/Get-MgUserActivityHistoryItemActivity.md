---
external help file:
Module Name: Microsoft.Graph.Users.ActivityFeed
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.activityfeed/get-mguseractivityhistoryitemactivity
schema: 2.0.0
---

# Get-MgUserActivityHistoryItemActivity

## SYNOPSIS
Get activity from users

## SYNTAX

### Get (Default)
```
Get-MgUserActivityHistoryItemActivity -ActivityHistoryItemId <String> -UserActivityId <String>
 -UserId <String> [-Expand <String[]>] [-Select <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserActivityHistoryItemActivity -InputObject <IUsersActivityFeedIdentity> [-Expand <String[]>]
 [-Select <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get activity from users

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

### -ActivityHistoryItemId
key: activityHistoryItem-id of activityHistoryItem

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersActivityFeedIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserActivityId
key: userActivity-id of userActivity

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IUsersActivityFeedIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserActivity

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IUsersActivityFeedIdentity>: Identity Parameter
  - `[ActivityHistoryItemId <String>]`: key: activityHistoryItem-id of activityHistoryItem
  - `[UserActivityId <String>]`: key: userActivity-id of userActivity
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

