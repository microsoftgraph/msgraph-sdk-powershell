---
external help file: Microsoft.Graph.Users.Actions-help.xml
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgtargetuserinsightsharedresourcemicrosoftgraphmanagedappprotectionapp
schema: 2.0.0
---

# Invoke-MgTargetUserInsightSharedResourceMicrosoftGraphManagedAppProtectionApp

## SYNOPSIS
Invoke action targetApps

## SYNTAX

### TargetExpanded (Default)
```
Invoke-MgTargetUserInsightSharedResourceMicrosoftGraphManagedAppProtectionApp -SharedInsightId <String>
 -UserId <String> [-AdditionalProperties <Hashtable>] [-Apps <IMicrosoftGraphManagedMobileApp[]>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Target
```
Invoke-MgTargetUserInsightSharedResourceMicrosoftGraphManagedAppProtectionApp -SharedInsightId <String>
 -UserId <String>
 -BodyParameter <IPathsO756IrUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphManagedappprotectionMicrosoftGraphTargetappsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### TargetViaIdentityExpanded
```
Invoke-MgTargetUserInsightSharedResourceMicrosoftGraphManagedAppProtectionApp
 -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### TargetViaIdentity
```
Invoke-MgTargetUserInsightSharedResourceMicrosoftGraphManagedAppProtectionApp
 -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsO756IrUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphManagedappprotectionMicrosoftGraphTargetappsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action targetApps

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: TargetExpanded, TargetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Apps
.
To construct, see NOTES section for APPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedMobileApp[]
Parameter Sets: TargetExpanded, TargetViaIdentityExpanded
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
Type: IPathsO756IrUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphManagedappprotectionMicrosoftGraphTargetappsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Target, TargetViaIdentity
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
Parameter Sets: TargetViaIdentityExpanded, TargetViaIdentity
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
Type: SwitchParameter
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
Type: String
Parameter Sets: TargetExpanded, Target
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
Parameter Sets: TargetExpanded, Target
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

### Microsoft.Graph.PowerShell.Models.IPathsO756IrUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphManagedappprotectionMicrosoftGraphTargetappsPostRequestbodyContentApplicationJsonSchema
### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPS <IMicrosoftGraphManagedMobileApp[]>: .
  - `[Id <String>]`: Read-only.
  - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Version <String>]`: Version of the entity.

BODYPARAMETER <IPathsO756IrUsersUserIdInsightsSharedSharedinsightIdResourceMicrosoftGraphManagedappprotectionMicrosoftGraphTargetappsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.

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
