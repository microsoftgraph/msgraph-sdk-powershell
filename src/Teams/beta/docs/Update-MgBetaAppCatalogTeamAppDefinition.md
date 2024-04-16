---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/update-mgbetaappcatalogteamappdefinition
schema: 2.0.0
---

# Update-MgBetaAppCatalogTeamAppDefinition

## SYNOPSIS
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaAppCatalogTeamAppDefinition -TeamsAppDefinitionId <String> -TeamsAppId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedInstallationScopes <String>]
 [-Authorization <IMicrosoftGraphTeamsAppAuthorization>] [-AzureAdAppId <String>] [-Bot <Hashtable>]
 [-ColorIcon <IMicrosoftGraphTeamsAppIcon>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-DashboardCards <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-OutlineIcon <IMicrosoftGraphTeamsAppIcon>] [-PublishingState <String>] [-ResponseHeadersVariable <String>]
 [-Shortdescription <String>] [-TeamsAppId1 <String>] [-Version <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaAppCatalogTeamAppDefinition -TeamsAppDefinitionId <String> -TeamsAppId <String>
 -BodyParameter <IMicrosoftGraphTeamsAppDefinition> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaAppCatalogTeamAppDefinition -InputObject <ITeamsIdentity>
 -BodyParameter <IMicrosoftGraphTeamsAppDefinition> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaAppCatalogTeamAppDefinition -InputObject <ITeamsIdentity> [-TeamsAppId <String>]
 [-AdditionalProperties <Hashtable>] [-AllowedInstallationScopes <String>]
 [-Authorization <IMicrosoftGraphTeamsAppAuthorization>] [-AzureAdAppId <String>] [-Bot <Hashtable>]
 [-ColorIcon <IMicrosoftGraphTeamsAppIcon>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-DashboardCards <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-OutlineIcon <IMicrosoftGraphTeamsAppIcon>] [-PublishingState <String>] [-ResponseHeadersVariable <String>]
 [-Shortdescription <String>] [-Version <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedInstallationScopes
teamsAppInstallationScopes

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Authorization
teamsAppAuthorization
To construct, see NOTES section for AUTHORIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppAuthorization
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdAppId
The WebApplicationInfo.Id from the Teams app manifest.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsAppDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Bot
teamworkBot

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColorIcon
teamsAppIcon
To construct, see NOTES section for COLORICON properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppIcon
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DashboardCards
Dashboard cards specified in the Teams app manifest.
To construct, see NOTES section for DASHBOARDCARDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppDashboardCardDefinition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the app provided by the app developer.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutlineIcon
teamsAppIcon
To construct, see NOTES section for OUTLINEICON properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppIcon
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingState
teamsAppPublishingState

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Shortdescription
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppDefinitionId
The unique identifier of teamsAppDefinition

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId
The unique identifier of teamsApp

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId1
The ID from the Teams app manifest.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The version number of the application.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition

### Microsoft.Graph.Beta.PowerShell.Models.ITeamsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTHORIZATION <IMicrosoftGraphTeamsAppAuthorization>`: teamsAppAuthorization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RequiredPermissionSet <IMicrosoftGraphTeamsAppPermissionSet>]`: teamsAppPermissionSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ResourceSpecificPermissions <IMicrosoftGraphTeamsAppResourceSpecificPermission[]>]`: A collection of resource-specific permissions.
      - `[PermissionType <String>]`: teamsAppResourceSpecificPermissionType
      - `[PermissionValue <String>]`: The name of the resource-specific permission.

`BODYPARAMETER <IMicrosoftGraphTeamsAppDefinition>`: teamsAppDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
  - `[Authorization <IMicrosoftGraphTeamsAppAuthorization>]`: teamsAppAuthorization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RequiredPermissionSet <IMicrosoftGraphTeamsAppPermissionSet>]`: teamsAppPermissionSet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ResourceSpecificPermissions <IMicrosoftGraphTeamsAppResourceSpecificPermission[]>]`: A collection of resource-specific permissions.
        - `[PermissionType <String>]`: teamsAppResourceSpecificPermissionType
        - `[PermissionValue <String>]`: The name of the resource-specific permission.
  - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
  - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
      - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
    - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DashboardCards <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>]`: Dashboard cards specified in the Teams app manifest.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentSource <IMicrosoftGraphTeamsAppDashboardCardContentSource>]`: teamsAppDashboardCardContentSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BotConfiguration <IMicrosoftGraphTeamsAppDashboardCardBotConfiguration>]`: teamsAppDashboardCardBotConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BotId <String>]`: The ID (usually a GUID) of the bot associated with the specific teamsAppDefinition. This is a unique app ID for the bot as registered with the Bot Framework.
      - `[SourceType <String>]`: teamsAppDashboardCardSourceType
    - `[DefaultSize <String>]`: teamsAppDashboardCardSize
    - `[Description <String>]`: The description for the card. Required.
    - `[DisplayName <String>]`: The name of the card. Required.
    - `[Icon <IMicrosoftGraphTeamsAppDashboardCardIcon>]`: teamsAppDashboardCardIcon
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IconUrl <String>]`: The icon for the card, displayed in the toolbox and card bar, is represented as a URL. The preferred size for raster images is 28x28 pixels. If this property has a value, the officeFabricIconFontName property is ignored.
      - `[OfficeUiFabricIconName <String>]`: The friendly name of the Office UI Fabric/Fluent UI icon for the card that is used when the iconUrl property isn't specified. For example, 'officeUIFabricIconName': 'Search'.
    - `[PickerGroupId <String>]`: ID for the group in the card picker. Required.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
  - `[PublishingState <String>]`: teamsAppPublishingState
  - `[Shortdescription <String>]`: 
  - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
  - `[Version <String>]`: The version number of the application.

`COLORICON <IMicrosoftGraphTeamsAppIcon>`: teamsAppIcon
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
    - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
  - `[WebUrl <String>]`: The web URL that can be used for downloading the image.

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`DASHBOARDCARDS <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>`: Dashboard cards specified in the Teams app manifest.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ContentSource <IMicrosoftGraphTeamsAppDashboardCardContentSource>]`: teamsAppDashboardCardContentSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BotConfiguration <IMicrosoftGraphTeamsAppDashboardCardBotConfiguration>]`: teamsAppDashboardCardBotConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BotId <String>]`: The ID (usually a GUID) of the bot associated with the specific teamsAppDefinition. This is a unique app ID for the bot as registered with the Bot Framework.
    - `[SourceType <String>]`: teamsAppDashboardCardSourceType
  - `[DefaultSize <String>]`: teamsAppDashboardCardSize
  - `[Description <String>]`: The description for the card. Required.
  - `[DisplayName <String>]`: The name of the card. Required.
  - `[Icon <IMicrosoftGraphTeamsAppDashboardCardIcon>]`: teamsAppDashboardCardIcon
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IconUrl <String>]`: The icon for the card, displayed in the toolbox and card bar, is represented as a URL. The preferred size for raster images is 28x28 pixels. If this property has a value, the officeFabricIconFontName property is ignored.
    - `[OfficeUiFabricIconName <String>]`: The friendly name of the Office UI Fabric/Fluent UI icon for the card that is used when the iconUrl property isn't specified. For example, 'officeUIFabricIconName': 'Search'.
  - `[PickerGroupId <String>]`: ID for the group in the card picker. Required.

`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DayNoteId <String>]`: The unique identifier of dayNote
  - `[DeletedChatId <String>]`: The unique identifier of deletedChat
  - `[DeletedTeamId <String>]`: The unique identifier of deletedTeam
  - `[GroupId <String>]`: The unique identifier of group
  - `[OfferShiftRequestId <String>]`: The unique identifier of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: The unique identifier of openShiftChangeRequest
  - `[OpenShiftId <String>]`: The unique identifier of openShift
  - `[PinnedChatMessageInfoId <String>]`: The unique identifier of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: The unique identifier of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: The unique identifier of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: The unique identifier of shift
  - `[ShiftsRoleDefinitionId <String>]`: The unique identifier of shiftsRoleDefinition
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamTemplateDefinitionId <String>]`: The unique identifier of teamTemplateDefinition
  - `[TeamTemplateId <String>]`: The unique identifier of teamTemplate
  - `[TeamsAppDashboardCardDefinitionId <String>]`: The unique identifier of teamsAppDashboardCardDefinition
  - `[TeamsAppDefinitionId <String>]`: The unique identifier of teamsAppDefinition
  - `[TeamsAppId <String>]`: The unique identifier of teamsApp
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: The unique identifier of teamsAsyncOperation
  - `[TeamsTabId <String>]`: The unique identifier of teamsTab
  - `[TeamworkDeviceId <String>]`: The unique identifier of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: The unique identifier of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: The unique identifier of teamworkTag
  - `[TeamworkTagMemberId <String>]`: The unique identifier of teamworkTagMember
  - `[TimeCardId <String>]`: The unique identifier of timeCard
  - `[TimeOffId <String>]`: The unique identifier of timeOff
  - `[TimeOffReasonId <String>]`: The unique identifier of timeOffReason
  - `[TimeOffRequestId <String>]`: The unique identifier of timeOffRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserScopeTeamsAppInstallationId <String>]`: The unique identifier of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: The unique identifier of workforceIntegration

`OUTLINEICON <IMicrosoftGraphTeamsAppIcon>`: teamsAppIcon
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
    - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
  - `[WebUrl <String>]`: The web URL that can be used for downloading the image.

## RELATED LINKS

