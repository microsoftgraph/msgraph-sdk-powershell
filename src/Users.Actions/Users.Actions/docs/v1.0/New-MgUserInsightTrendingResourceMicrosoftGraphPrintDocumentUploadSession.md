---
external help file: Microsoft.Graph.Users.Actions-help.xml
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/new-mguserinsighttrendingresourcemicrosoftgraphprintdocumentuploadsession
schema: 2.0.0
---

# New-MgUserInsightTrendingResourceMicrosoftGraphPrintDocumentUploadSession

## SYNOPSIS
Invoke action createUploadSession

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserInsightTrendingResourceMicrosoftGraphPrintDocumentUploadSession -TrendingId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Properties <IMicrosoftGraphPrintDocumentUploadProperties>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgUserInsightTrendingResourceMicrosoftGraphPrintDocumentUploadSession -TrendingId <String> -UserId <String>
 -BodyParameter <IPaths11Er69AUsersUserIdInsightsTrendingIdResourceMicrosoftGraphPrintdocumentMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserInsightTrendingResourceMicrosoftGraphPrintDocumentUploadSession -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-Properties <IMicrosoftGraphPrintDocumentUploadProperties>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserInsightTrendingResourceMicrosoftGraphPrintDocumentUploadSession -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths11Er69AUsersUserIdInsightsTrendingIdResourceMicrosoftGraphPrintdocumentMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action createUploadSession

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IPaths11Er69AUsersUserIdInsightsTrendingIdResourceMicrosoftGraphPrintdocumentMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IUsersActionsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Properties
printDocumentUploadProperties
To construct, see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintDocumentUploadProperties
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TrendingId
key: id of trending

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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
Parameter Sets: CreateExpanded, Create
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

### Microsoft.Graph.PowerShell.Models.IPaths11Er69AUsersUserIdInsightsTrendingIdResourceMicrosoftGraphPrintdocumentMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema
### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUploadSession
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths11Er69AUsersUserIdInsightsTrendingIdResourceMicrosoftGraphPrintdocumentMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Properties <IMicrosoftGraphPrintDocumentUploadProperties>]`: printDocumentUploadProperties
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentType <String>]`: The document's content (MIME) type.
    - `[DocumentName <String>]`: The document's name.
    - `[Size <Int64?>]`: The document's size in bytes.

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

PROPERTIES <IMicrosoftGraphPrintDocumentUploadProperties>: printDocumentUploadProperties
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentType <String>]`: The document's content (MIME) type.
  - `[DocumentName <String>]`: The document's name.
  - `[Size <Int64?>]`: The document's size in bytes.

## RELATED LINKS
