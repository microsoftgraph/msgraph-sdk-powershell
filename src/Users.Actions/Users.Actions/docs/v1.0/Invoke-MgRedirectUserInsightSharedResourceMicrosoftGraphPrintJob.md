---
external help file: Microsoft.Graph.Users.Actions-help.xml
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgredirectuserinsightsharedresourcemicrosoftgraphprintjob
schema: 2.0.0
---

# Invoke-MgRedirectUserInsightSharedResourceMicrosoftGraphPrintJob

## SYNOPSIS
Invoke action redirect

## SYNTAX

### RedirectExpanded (Default)
```
Invoke-MgRedirectUserInsightSharedResourceMicrosoftGraphPrintJob -SharedInsightId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Configuration <IMicrosoftGraphPrintJobConfiguration>]
 [-DestinationPrinterId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Redirect
```
Invoke-MgRedirectUserInsightSharedResourceMicrosoftGraphPrintJob -SharedInsightId <String> -UserId <String>
 -BodyParameter <IPaths82AjwzUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphPrintjobMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### RedirectViaIdentityExpanded
```
Invoke-MgRedirectUserInsightSharedResourceMicrosoftGraphPrintJob -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-Configuration <IMicrosoftGraphPrintJobConfiguration>]
 [-DestinationPrinterId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### RedirectViaIdentity
```
Invoke-MgRedirectUserInsightSharedResourceMicrosoftGraphPrintJob -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths82AjwzUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphPrintjobMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action redirect

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths82AjwzUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphPrintjobMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Redirect, RedirectViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
printJobConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintJobConfiguration
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationPrinterId
.

```yaml
Type: String
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IUsersActionsIdentity
Parameter Sets: RedirectViaIdentityExpanded, RedirectViaIdentity
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
Parameter Sets: RedirectExpanded, Redirect
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
Parameter Sets: RedirectExpanded, Redirect
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

### Microsoft.Graph.PowerShell.Models.IPaths82AjwzUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphPrintjobMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema
### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintJob
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths82AjwzUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphPrintjobMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Configuration <IMicrosoftGraphPrintJobConfiguration>]`: printJobConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Collate <Boolean?>]`: Whether the printer should collate pages wehen printing multiple copies of a multi-page document.
    - `[ColorMode <String>]`: printColorMode
    - `[Copies <Int32?>]`: The number of copies that should be printed. Read-only.
    - `[Dpi <Int32?>]`: The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.
    - `[DuplexMode <String>]`: printDuplexMode
    - `[FeedOrientation <String>]`: printerFeedOrientation
    - `[Finishings <String[]>]`: Finishing processes to use when printing.
    - `[FitPdfToPage <Boolean?>]`: 
    - `[InputBin <String>]`: The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.
    - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Bottom <Int32?>]`: The margin in microns from the bottom edge.
      - `[Left <Int32?>]`: The margin in microns from the left edge.
      - `[Right <Int32?>]`: The margin in microns from the right edge.
      - `[Top <Int32?>]`: The margin in microns from the top edge.
    - `[MediaSize <String>]`: The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
    - `[MediaType <String>]`: The default media (such as paper) type to print the document on.
    - `[MultipageLayout <String>]`: printMultipageLayout
    - `[Orientation <String>]`: printOrientation
    - `[OutputBin <String>]`: The output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
    - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: The page ranges to print. Read-only.
      - `[End <Int64?>]`: The inclusive upper bound of the integer range.
      - `[Start <Int64?>]`: The inclusive lower bound of the integer range.
    - `[PagesPerSheet <Int32?>]`: The number of document pages to print on each sheet.
    - `[Quality <String>]`: printQuality
    - `[Scaling <String>]`: printScaling
  - `[DestinationPrinterId <String>]`: 

CONFIGURATION <IMicrosoftGraphPrintJobConfiguration>: printJobConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Collate <Boolean?>]`: Whether the printer should collate pages wehen printing multiple copies of a multi-page document.
  - `[ColorMode <String>]`: printColorMode
  - `[Copies <Int32?>]`: The number of copies that should be printed. Read-only.
  - `[Dpi <Int32?>]`: The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.
  - `[DuplexMode <String>]`: printDuplexMode
  - `[FeedOrientation <String>]`: printerFeedOrientation
  - `[Finishings <String[]>]`: Finishing processes to use when printing.
  - `[FitPdfToPage <Boolean?>]`: 
  - `[InputBin <String>]`: The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.
  - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Bottom <Int32?>]`: The margin in microns from the bottom edge.
    - `[Left <Int32?>]`: The margin in microns from the left edge.
    - `[Right <Int32?>]`: The margin in microns from the right edge.
    - `[Top <Int32?>]`: The margin in microns from the top edge.
  - `[MediaSize <String>]`: The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
  - `[MediaType <String>]`: The default media (such as paper) type to print the document on.
  - `[MultipageLayout <String>]`: printMultipageLayout
  - `[Orientation <String>]`: printOrientation
  - `[OutputBin <String>]`: The output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
  - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: The page ranges to print. Read-only.
    - `[End <Int64?>]`: The inclusive upper bound of the integer range.
    - `[Start <Int64?>]`: The inclusive lower bound of the integer range.
  - `[PagesPerSheet <Int32?>]`: The number of document pages to print on each sheet.
  - `[Quality <String>]`: printQuality
  - `[Scaling <String>]`: printScaling

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[CalendarId <String>]`: key: id of calendar
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
