---
external help file:
Module Name: Microsoft.Graph.CrossDeviceExperiences
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.crossdeviceexperiences/new-mguseractivity
schema: 2.0.0
---

# New-MgUserActivity

## SYNOPSIS
The user's activities across devices.
Read-only.
Nullable.

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserActivity -UserId <String> [-ActivationUrl <String>] [-ActivitySourceHost <String>]
 [-AdditionalProperties <Hashtable>] [-AppActivityId <String>] [-AppDisplayName <String>]
 [-ContentInfo <Hashtable>] [-ContentUrl <String>] [-CreatedDateTime <DateTime>]
 [-ExpirationDateTime <DateTime>] [-FallbackUrl <String>]
 [-HistoryItems <IMicrosoftGraphActivityHistoryItem1[]>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Status <String>] [-UserTimezone <String>] [-VisualElements <IMicrosoftGraphVisualInfo>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserActivity -UserId <String> -BodyParameter <IMicrosoftGraphUserActivity1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserActivity -InputObject <ICrossDeviceExperiencesIdentity>
 -BodyParameter <IMicrosoftGraphUserActivity1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserActivity -InputObject <ICrossDeviceExperiencesIdentity> [-ActivationUrl <String>]
 [-ActivitySourceHost <String>] [-AdditionalProperties <Hashtable>] [-AppActivityId <String>]
 [-AppDisplayName <String>] [-ContentInfo <Hashtable>] [-ContentUrl <String>] [-CreatedDateTime <DateTime>]
 [-ExpirationDateTime <DateTime>] [-FallbackUrl <String>]
 [-HistoryItems <IMicrosoftGraphActivityHistoryItem1[]>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Status <String>] [-UserTimezone <String>] [-VisualElements <IMicrosoftGraphVisualInfo>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The user's activities across devices.
Read-only.
Nullable.

## EXAMPLES

## PARAMETERS

### -ActivationUrl
Required.
URL used to launch the activity in the best native experience represented by the appId.
Might launch a web-based app if no native app exists.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivitySourceHost
Required.
URL for the domain representing the cross-platform identity mapping for the app.
Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center.
The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain.
For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath.
You must have a unique file and domain (or sub domain) per cross-platform app identity.
For example, a separate file and domain is needed for Word vs.
PowerPoint.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppActivityId
Required.
The unique activity ID in the context of the app - supplied by caller and immutable thereafter.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppDisplayName
Optional.
Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
userActivity
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserActivity1
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInfo
Json

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentUrl
Optional.
Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Set by the server.
DateTime in UTC when the object was created on the server.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
Set by the server.
DateTime in UTC when the object expired on the server.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FallbackUrl
Optional.
URL used to launch the activity in a web-based app, if available.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HistoryItems
Optional.
NavigationProperty/Containment; navigation property to the activity's historyItems.
To construct, please use Get-Help -Online and see NOTES section for HISTORYITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphActivityHistoryItem1[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ICrossDeviceExperiencesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
Set by the server.
DateTime in UTC when the object was modified on the server.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
status

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserTimezone
Optional.
The timezone in which the user's device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VisualElements
visualInfo
To construct, please use Get-Help -Online and see NOTES section for VISUALELEMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVisualInfo
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.ICrossDeviceExperiencesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserActivity1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserActivity1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserActivity1>: userActivity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActivationUrl <String>]`: Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.
  - `[ActivitySourceHost <String>]`: Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.
  - `[AppActivityId <String>]`: Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.
  - `[AppDisplayName <String>]`: Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.
  - `[ContentInfo <IMicrosoftGraphJson>]`: Json
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentUrl <String>]`: Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).
  - `[CreatedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was created on the server.
  - `[ExpirationDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object expired on the server.
  - `[FallbackUrl <String>]`: Optional. URL used to launch the activity in a web-based app, if available.
  - `[HistoryItems <IMicrosoftGraphActivityHistoryItem1[]>]`: Optional. NavigationProperty/Containment; navigation property to the activity's historyItems.
    - `[Id <String>]`: Read-only.
    - `[ActiveDurationSeconds <Int32?>]`: Optional. The duration of active user engagement. if not supplied, this is calculated from the startedDateTime and lastActiveDateTime.
    - `[Activity <IMicrosoftGraphUserActivity1>]`: userActivity
    - `[CreatedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was created on the server.
    - `[ExpirationDateTime <DateTime?>]`: Optional. UTC DateTime when the historyItem will undergo hard-delete. Can be set by the client.
    - `[LastActiveDateTime <DateTime?>]`: Optional. UTC DateTime when the historyItem (activity session) was last understood as active or finished - if null, historyItem status should be Ongoing.
    - `[LastModifiedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was modified on the server.
    - `[StartedDateTime <DateTime?>]`: Required. UTC DateTime when the historyItem (activity session) was started. Required for timeline history.
    - `[Status <String>]`: status
    - `[UserTimezone <String>]`: Optional. The timezone in which the user's device used to generate the activity was located at activity creation time. Values supplied as Olson IDs in order to support cross-platform representation.
  - `[LastModifiedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was modified on the server.
  - `[Status <String>]`: status
  - `[UserTimezone <String>]`: Optional. The timezone in which the user's device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.
  - `[VisualElements <IMicrosoftGraphVisualInfo>]`: visualInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Attribution <IMicrosoftGraphImageInfo>]`: imageInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AddImageQuery <Boolean?>]`: Optional; parameter used to indicate the server is able to render image dynamically in response to parameterization. For example – a high contrast image
      - `[AlternateText <String>]`: Optional; alt-text accessible content for the image
      - `[AlternativeText <String>]`: 
      - `[IconUrl <String>]`: Optional; URI that points to an icon which represents the application used to generate the activity
    - `[BackgroundColor <String>]`: Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color
    - `[Content <IMicrosoftGraphJson>]`: Json
    - `[Description <String>]`: Optional. Longer text description of the user's unique activity (example: document name, first sentence, and/or metadata)
    - `[DisplayText <String>]`: Required. Short text description of the user's unique activity (for example, document name in cases where an activity refers to document creation)

HISTORYITEMS <IMicrosoftGraphActivityHistoryItem1[]>: Optional. NavigationProperty/Containment; navigation property to the activity's historyItems.
  - `[Id <String>]`: Read-only.
  - `[ActiveDurationSeconds <Int32?>]`: Optional. The duration of active user engagement. if not supplied, this is calculated from the startedDateTime and lastActiveDateTime.
  - `[Activity <IMicrosoftGraphUserActivity1>]`: userActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ActivationUrl <String>]`: Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.
    - `[ActivitySourceHost <String>]`: Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.
    - `[AppActivityId <String>]`: Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.
    - `[AppDisplayName <String>]`: Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.
    - `[ContentInfo <IMicrosoftGraphJson>]`: Json
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentUrl <String>]`: Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).
    - `[CreatedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was created on the server.
    - `[ExpirationDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object expired on the server.
    - `[FallbackUrl <String>]`: Optional. URL used to launch the activity in a web-based app, if available.
    - `[HistoryItems <IMicrosoftGraphActivityHistoryItem1[]>]`: Optional. NavigationProperty/Containment; navigation property to the activity's historyItems.
    - `[LastModifiedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was modified on the server.
    - `[Status <String>]`: status
    - `[UserTimezone <String>]`: Optional. The timezone in which the user's device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.
    - `[VisualElements <IMicrosoftGraphVisualInfo>]`: visualInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Attribution <IMicrosoftGraphImageInfo>]`: imageInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AddImageQuery <Boolean?>]`: Optional; parameter used to indicate the server is able to render image dynamically in response to parameterization. For example – a high contrast image
        - `[AlternateText <String>]`: Optional; alt-text accessible content for the image
        - `[AlternativeText <String>]`: 
        - `[IconUrl <String>]`: Optional; URI that points to an icon which represents the application used to generate the activity
      - `[BackgroundColor <String>]`: Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color
      - `[Content <IMicrosoftGraphJson>]`: Json
      - `[Description <String>]`: Optional. Longer text description of the user's unique activity (example: document name, first sentence, and/or metadata)
      - `[DisplayText <String>]`: Required. Short text description of the user's unique activity (for example, document name in cases where an activity refers to document creation)
  - `[CreatedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was created on the server.
  - `[ExpirationDateTime <DateTime?>]`: Optional. UTC DateTime when the historyItem will undergo hard-delete. Can be set by the client.
  - `[LastActiveDateTime <DateTime?>]`: Optional. UTC DateTime when the historyItem (activity session) was last understood as active or finished - if null, historyItem status should be Ongoing.
  - `[LastModifiedDateTime <DateTime?>]`: Set by the server. DateTime in UTC when the object was modified on the server.
  - `[StartedDateTime <DateTime?>]`: Required. UTC DateTime when the historyItem (activity session) was started. Required for timeline history.
  - `[Status <String>]`: status
  - `[UserTimezone <String>]`: Optional. The timezone in which the user's device used to generate the activity was located at activity creation time. Values supplied as Olson IDs in order to support cross-platform representation.

INPUTOBJECT <ICrossDeviceExperiencesIdentity>: Identity Parameter
  - `[ActivityHistoryItemId <String>]`: key: id of activityHistoryItem
  - `[DeviceId <String>]`: key: id of device
  - `[UserActivityId <String>]`: key: id of userActivity
  - `[UserId <String>]`: key: id of user

VISUALELEMENTS <IMicrosoftGraphVisualInfo>: visualInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attribution <IMicrosoftGraphImageInfo>]`: imageInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AddImageQuery <Boolean?>]`: Optional; parameter used to indicate the server is able to render image dynamically in response to parameterization. For example – a high contrast image
    - `[AlternateText <String>]`: Optional; alt-text accessible content for the image
    - `[AlternativeText <String>]`: 
    - `[IconUrl <String>]`: Optional; URI that points to an icon which represents the application used to generate the activity
  - `[BackgroundColor <String>]`: Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color
  - `[Content <IMicrosoftGraphJson>]`: Json
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Optional. Longer text description of the user's unique activity (example: document name, first sentence, and/or metadata)
  - `[DisplayText <String>]`: Required. Short text description of the user's unique activity (for example, document name in cases where an activity refers to document creation)

## RELATED LINKS

