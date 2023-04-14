---
external help file:
Module Name: Microsoft.Graph.Users.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions/invoke-mgrecentuseractivity
schema: 2.0.0
---

# Invoke-MgRecentUserActivity

## SYNOPSIS
Get recent activities for a given user.
This OData function has some default behaviors included to make it operate like a 'most recently used' API.
The service will query for the most recent historyItems, and then pull those related activities.
Activities will be sorted according to the most recent **lastModified** on the **historyItem**.
This means that activities without **historyItems** will not be included in the response.
The UserActivity.ReadWrite.CreatedByApp permission will also apply extra filtering to the response, so that only activities created by your application are returned.
This server-side filtering might result in empty pages if the user is particularly active and other applications have created more recent activities.
To get your application's activities, use the **nextLink** property to paginate.

## SYNTAX

### Recent1 (Default)
```
Invoke-MgRecentUserActivity -UserId <String> [-Count] [-Filter <String>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [<CommonParameters>]
```

### RecentViaIdentity1
```
Invoke-MgRecentUserActivity -InputObject <IUsersFunctionsIdentity> [-Count] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [<CommonParameters>]
```

## DESCRIPTION
Get recent activities for a given user.
This OData function has some default behaviors included to make it operate like a 'most recently used' API.
The service will query for the most recent historyItems, and then pull those related activities.
Activities will be sorted according to the most recent **lastModified** on the **historyItem**.
This means that activities without **historyItems** will not be included in the response.
The UserActivity.ReadWrite.CreatedByApp permission will also apply extra filtering to the response, so that only activities created by your application are returned.
This server-side filtering might result in empty pages if the user is particularly active and other applications have created more recent activities.
To get your application's activities, use the **nextLink** property to paginate.

## EXAMPLES

### Example 1: Using the Invoke-MgRecentUserActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Invoke-MgRecentUserActivity -UserId $userId
```

This example shows how to use the Invoke-MgRecentUserActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersFunctionsIdentity
Parameter Sets: RecentViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Recent1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserActivity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IUsersFunctionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AppConsentRequestId <String>]`: The unique identifier of appConsentRequest
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[ContactFolderId <String>]`: The unique identifier of contactFolder
  - `[ContactFolderId1 <String>]`: The unique identifier of contactFolder
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[EndDateTime <String>]`: Usage: EndDateTime='{EndDateTime}'
  - `[EndDateTime1 <String>]`: Usage: endDateTime='{endDateTime}'
  - `[EventId <String>]`: The unique identifier of event
  - `[GroupId <String>]`: Usage: groupId='{groupId}'
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[On <String>]`: Usage: on='{on}'
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[Q <String>]`: Usage: q='{q}'
  - `[RoomList <String>]`: Usage: RoomList='{RoomList}'
  - `[ServicePlanId <String>]`: Usage: servicePlanId='{servicePlanId}'
  - `[SessionKey <String>]`: Usage: sessionKey='{sessionKey}'
  - `[Skip <Int32?>]`: Usage: skip={skip}
  - `[StartDateTime <String>]`: Usage: StartDateTime='{StartDateTime}'
  - `[StartDateTime1 <String>]`: Usage: startDateTime='{startDateTime}'
  - `[TimeZoneStandard <String>]`: Usage: TimeZoneStandard='{TimeZoneStandard}'
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[Token <String>]`: Usage: token='{token}'
  - `[Top <Int32?>]`: Usage: top={top}
  - `[Upn <String>]`: Usage: upn='{upn}'
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

