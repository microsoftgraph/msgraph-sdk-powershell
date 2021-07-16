---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgcommituserinsightsharedresourcemicrosoftgraphmobileappcontentfile
schema: 2.0.0
---

# Invoke-MgCommitUserInsightSharedResourceMicrosoftGraphMobileAppContentFile

## SYNOPSIS
Commits a file of a given app.

## SYNTAX

### CommitExpanded (Default)
```
Invoke-MgCommitUserInsightSharedResourceMicrosoftGraphMobileAppContentFile -SharedInsightId <String>
 -UserId <String> [-AdditionalProperties <Hashtable>]
 [-FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Commit
```
Invoke-MgCommitUserInsightSharedResourceMicrosoftGraphMobileAppContentFile -SharedInsightId <String>
 -UserId <String>
 -BodyParameter <IPaths3Og7OjUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphMobileappcontentfileMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CommitViaIdentity
```
Invoke-MgCommitUserInsightSharedResourceMicrosoftGraphMobileAppContentFile
 -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths3Og7OjUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphMobileappcontentfileMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CommitViaIdentityExpanded
```
Invoke-MgCommitUserInsightSharedResourceMicrosoftGraphMobileAppContentFile
 -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Commits a file of a given app.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CommitExpanded, CommitViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths3Og7OjUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphMobileappcontentfileMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Commit, CommitViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FileEncryptionInfo
Contains properties for file encryption information for the content version of a line of business app.
To construct, see NOTES section for FILEENCRYPTIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileEncryptionInfo
Parameter Sets: CommitExpanded, CommitViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: CommitViaIdentity, CommitViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: Commit, CommitExpanded
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
Parameter Sets: Commit, CommitExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths3Og7OjUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphMobileappcontentfileMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths3Og7OjUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphMobileappcontentfileMicrosoftGraphCommitPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FileEncryptionInfo <IMicrosoftGraphFileEncryptionInfo>]`: Contains properties for file encryption information for the content version of a line of business app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EncryptionKey <Byte[]>]`: The key used to encrypt the file content.
    - `[FileDigest <Byte[]>]`: The file digest prior to encryption.
    - `[FileDigestAlgorithm <String>]`: The file digest algorithm.
    - `[InitializationVector <Byte[]>]`: The initialization vector used for the encryption algorithm.
    - `[Mac <Byte[]>]`: The hash of the encrypted file content + IV (content hash).
    - `[MacKey <Byte[]>]`: The key used to get mac.
    - `[ProfileIdentifier <String>]`: The the profile identifier.

FILEENCRYPTIONINFO <IMicrosoftGraphFileEncryptionInfo>: Contains properties for file encryption information for the content version of a line of business app.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EncryptionKey <Byte[]>]`: The key used to encrypt the file content.
  - `[FileDigest <Byte[]>]`: The file digest prior to encryption.
  - `[FileDigestAlgorithm <String>]`: The file digest algorithm.
  - `[InitializationVector <Byte[]>]`: The initialization vector used for the encryption algorithm.
  - `[Mac <Byte[]>]`: The hash of the encrypted file content + IV (content hash).
  - `[MacKey <Byte[]>]`: The key used to get mac.
  - `[ProfileIdentifier <String>]`: The the profile identifier.

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

