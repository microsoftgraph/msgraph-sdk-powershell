---
external help file: Microsoft.Graph.Users.Functions-help.xml
Module Name: Microsoft.Graph.Users.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/invoke-mgcolumnuserinsightsharedresourcemicrosoftgraphworkbookrangebefore72e4
schema: 2.0.0
---

# Invoke-MgColumnUserInsightSharedResourceMicrosoftGraphWorkbookRangeBefore72E4

## SYNOPSIS
Invoke function columnsBefore

## SYNTAX

### Columns (Default)
```
Invoke-MgColumnUserInsightSharedResourceMicrosoftGraphWorkbookRangeBefore72E4 -SharedInsightId <String>
 -UserId <String> [<CommonParameters>]
```

### ColumnsViaIdentity
```
Invoke-MgColumnUserInsightSharedResourceMicrosoftGraphWorkbookRangeBefore72E4
 -InputObject <IUsersFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function columnsBefore

## EXAMPLES

## PARAMETERS

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IUsersFunctionsIdentity
Parameter Sets: ColumnsViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SharedInsightId
key: id of sharedInsight

```yaml
Type: String
Parameter Sets: Columns
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: Columns
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWorkbookRange
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IUsersFunctionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AnotherRange <String>]`: Usage: anotherRange={anotherRange}
  - `[AppConsentRequestId <String>]`: key: id of appConsentRequest
  - `[CalendarId <String>]`: key: id of calendar
  - `[Column <Int32?>]`: Usage: column={column}
  - `[ColumnOffset <Int32?>]`: Usage: columnOffset={columnOffset}
  - `[ContactFolderId <String>]`: key: id of contactFolder
  - `[Count <Int32?>]`: Usage: count={count}
  - `[DeltaColumns <Int32?>]`: Usage: deltaColumns={deltaColumns}
  - `[DeltaRows <Int32?>]`: Usage: deltaRows={deltaRows}
  - `[EndDateTime <String>]`: Usage: EndDateTime={EndDateTime}
  - `[EventId <String>]`: key: id of event
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[On <String>]`: Usage: on={on}
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[RoomList <String>]`: Usage: RoomList={RoomList}
  - `[Row <Int32?>]`: Usage: row={row}
  - `[RowOffset <Int32?>]`: Usage: rowOffset={rowOffset}
  - `[SharedInsightId <String>]`: key: id of sharedInsight
  - `[Skip <Int32?>]`: Usage: skip={skip}
  - `[StartDateTime <String>]`: Usage: StartDateTime={StartDateTime}
  - `[TimeZoneStandard <String>]`: Usage: TimeZoneStandard={TimeZoneStandard}
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[Top <Int32?>]`: Usage: top={top}
  - `[TrendingId <String>]`: key: id of trending
  - `[UsedInsightId <String>]`: key: id of usedInsight
  - `[User <String>]`: Usage: User={User}
  - `[UserId <String>]`: key: id of user
  - `[ValuesOnly <Boolean?>]`: Usage: valuesOnly={valuesOnly}

## RELATED LINKS
