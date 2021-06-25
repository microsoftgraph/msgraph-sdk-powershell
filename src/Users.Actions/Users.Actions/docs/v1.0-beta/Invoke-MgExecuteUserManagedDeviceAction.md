---
external help file: Microsoft.Graph.Users.Actions-help.xml
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgexecuteusermanageddeviceaction
schema: 2.0.0
---

# Invoke-MgExecuteUserManagedDeviceAction

## SYNOPSIS
Invoke action executeAction

## SYNTAX

### ExecuteExpanded (Default)
```
Invoke-MgExecuteUserManagedDeviceAction -UserId <String> [-ActionName <String>]
 [-AdditionalProperties <Hashtable>] [-DeviceIds <String[]>] [-DeviceName <String>] [-KeepEnrollmentData]
 [-KeepUserData] [-NotificationBody <String>] [-NotificationTitle <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Execute
```
Invoke-MgExecuteUserManagedDeviceAction -UserId <String>
 -BodyParameter <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ExecuteViaIdentityExpanded
```
Invoke-MgExecuteUserManagedDeviceAction -InputObject <IUsersActionsIdentity> [-ActionName <String>]
 [-AdditionalProperties <Hashtable>] [-DeviceIds <String[]>] [-DeviceName <String>] [-KeepEnrollmentData]
 [-KeepUserData] [-NotificationBody <String>] [-NotificationTitle <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ExecuteViaIdentity
```
Invoke-MgExecuteUserManagedDeviceAction -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action executeAction

## EXAMPLES

## PARAMETERS

### -ActionName
managedDeviceRemoteAction

```yaml
Type: String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
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
Type: IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Execute, ExecuteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceIds
.

```yaml
Type: String[]
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
.

```yaml
Type: String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
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
Parameter Sets: ExecuteViaIdentityExpanded, ExecuteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeepEnrollmentData
.

```yaml
Type: SwitchParameter
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepUserData
.

```yaml
Type: SwitchParameter
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationBody
.

```yaml
Type: String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationTitle
.

```yaml
Type: String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: ExecuteExpanded, Execute
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

### Microsoft.Graph.PowerShell.Models.IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBulkManagedDeviceActionResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActionName <String>]`: managedDeviceRemoteAction
  - `[DeviceIds <String[]>]`: 
  - `[DeviceName <String>]`: 
  - `[KeepEnrollmentData <Boolean?>]`: 
  - `[KeepUserData <Boolean?>]`: 
  - `[NotificationBody <String>]`: 
  - `[NotificationTitle <String>]`: 

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
