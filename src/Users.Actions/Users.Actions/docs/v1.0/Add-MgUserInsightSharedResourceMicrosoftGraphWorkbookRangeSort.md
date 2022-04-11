---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/add-mguserinsightsharedresourcemicrosoftgraphworkbookrangesort
schema: 2.0.0
---

# Add-MgUserInsightSharedResourceMicrosoftGraphWorkbookRangeSort

## SYNOPSIS
Invoke action apply

## SYNTAX

### ApplyExpanded (Default)
```
Add-MgUserInsightSharedResourceMicrosoftGraphWorkbookRangeSort -SharedInsightId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Fields <IMicrosoftGraphWorkbookSortField[]>] [-HasHeaders] [-MatchCase]
 [-Method <String>] [-Orientation <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Apply
```
Add-MgUserInsightSharedResourceMicrosoftGraphWorkbookRangeSort -SharedInsightId <String> -UserId <String>
 -BodyParameter <IPaths6JuhlhUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphWorkbookrangesortMicrosoftGraphApplyPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentity
```
Add-MgUserInsightSharedResourceMicrosoftGraphWorkbookRangeSort -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths6JuhlhUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphWorkbookrangesortMicrosoftGraphApplyPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentityExpanded
```
Add-MgUserInsightSharedResourceMicrosoftGraphWorkbookRangeSort -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-Fields <IMicrosoftGraphWorkbookSortField[]>] [-HasHeaders] [-MatchCase]
 [-Method <String>] [-Orientation <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action apply

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths6JuhlhUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphWorkbookrangesortMicrosoftGraphApplyPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Apply, ApplyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Fields
.
To construct, please use Get-Help -Online and see NOTES section for FIELDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWorkbookSortField[]
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasHeaders
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: ApplyViaIdentity, ApplyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MatchCase
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Method
.

```yaml
Type: System.String
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Orientation
.

```yaml
Type: System.String
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### -SharedInsightId
key: id of sharedInsight

```yaml
Type: System.String
Parameter Sets: Apply, ApplyExpanded
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
Type: System.String
Parameter Sets: Apply, ApplyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
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
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IPaths6JuhlhUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphWorkbookrangesortMicrosoftGraphApplyPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths6JuhlhUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphWorkbookrangesortMicrosoftGraphApplyPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Fields <IMicrosoftGraphWorkbookSortField[]>]`: 
    - `[Ascending <Boolean?>]`: Represents whether the sorting is done in an ascending fashion.
    - `[Color <String>]`: Represents the color that is the target of the condition if the sorting is on font or cell color.
    - `[DataOption <String>]`: Represents additional sorting options for this field. The possible values are: Normal, TextAsNumber.
    - `[Icon <IMicrosoftGraphWorkbookIcon>]`: workbookIcon
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Index <Int32?>]`: Represents the index of the icon in the given set.
      - `[Set <String>]`: Represents the set that the icon is part of. The possible values are: Invalid, ThreeArrows, ThreeArrowsGray, ThreeFlags, ThreeTrafficLights1, ThreeTrafficLights2, ThreeSigns, ThreeSymbols, ThreeSymbols2, FourArrows, FourArrowsGray, FourRedToBlack, FourRating, FourTrafficLights, FiveArrows, FiveArrowsGray, FiveRating, FiveQuarters, ThreeStars, ThreeTriangles, FiveBoxes.
    - `[Key <Int32?>]`: Represents the column (or row, depending on the sort orientation) that the condition is on. Represented as an offset from the first column (or row).
    - `[SortOn <String>]`: Represents the type of sorting of this condition. The possible values are: Value, CellColor, FontColor, Icon.
  - `[HasHeaders <Boolean?>]`: 
  - `[MatchCase <Boolean?>]`: 
  - `[Method <String>]`: 
  - `[Orientation <String>]`: 

FIELDS <IMicrosoftGraphWorkbookSortField[]>: .
  - `[Ascending <Boolean?>]`: Represents whether the sorting is done in an ascending fashion.
  - `[Color <String>]`: Represents the color that is the target of the condition if the sorting is on font or cell color.
  - `[DataOption <String>]`: Represents additional sorting options for this field. The possible values are: Normal, TextAsNumber.
  - `[Icon <IMicrosoftGraphWorkbookIcon>]`: workbookIcon
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Index <Int32?>]`: Represents the index of the icon in the given set.
    - `[Set <String>]`: Represents the set that the icon is part of. The possible values are: Invalid, ThreeArrows, ThreeArrowsGray, ThreeFlags, ThreeTrafficLights1, ThreeTrafficLights2, ThreeSigns, ThreeSymbols, ThreeSymbols2, FourArrows, FourArrowsGray, FourRedToBlack, FourRating, FourTrafficLights, FiveArrows, FiveArrowsGray, FiveRating, FiveQuarters, ThreeStars, ThreeTriangles, FiveBoxes.
  - `[Key <Int32?>]`: Represents the column (or row, depending on the sort orientation) that the condition is on. Represented as an offset from the first column (or row).
  - `[SortOn <String>]`: Represents the type of sorting of this condition. The possible values are: Value, CellColor, FontColor, Icon.

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceDecisionItemId <String>]`: key: id of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[BaseTaskId <String>]`: key: id of baseTask
  - `[BaseTaskListId <String>]`: key: id of baseTaskList
  - `[CalendarId <String>]`: key: id of calendar
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[EventId <String>]`: key: id of event
  - `[EventId1 <String>]`: key: id of event
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[MailFolderId1 <String>]`: key: id of mailFolder
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[MessageId <String>]`: key: id of message
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: id of outlookTask
  - `[SharedInsightId <String>]`: key: id of sharedInsight
  - `[TrendingId <String>]`: key: id of trending
  - `[UsedInsightId <String>]`: key: id of usedInsight
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

