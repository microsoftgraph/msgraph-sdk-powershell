---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/update-mgteamworkdevicehealth
schema: 2.0.0
---

# Update-MgTeamworkDeviceHealth

## SYNOPSIS
Update the navigation property health in teamwork

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamworkDeviceHealth -TeamworkDeviceId <String> [-AdditionalProperties <Hashtable>]
 [-Connection <IMicrosoftGraphTeamworkConnection>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]
 [-PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]
 [-SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgTeamworkDeviceHealth -TeamworkDeviceId <String> -BodyParameter <IMicrosoftGraphTeamworkDeviceHealth>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamworkDeviceHealth -InputObject <ITeamsIdentity>
 -BodyParameter <IMicrosoftGraphTeamworkDeviceHealth> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamworkDeviceHealth -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Connection <IMicrosoftGraphTeamworkConnection>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]
 [-PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]
 [-SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property health in teamwork

## EXAMPLES

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

### -BodyParameter
teamworkDeviceHealth
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDeviceHealth
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Connection
teamworkConnection
To construct, please use Get-Help -Online and see NOTES section for CONNECTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkConnection
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
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The UTC date and time when the device health document was created.

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

### -HardwareHealth
teamworkHardwareHealth
To construct, please use Get-Help -Online and see NOTES section for HARDWAREHEALTH properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkHardwareHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The UTC date and time when the device health detail was last modified.

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

### -LoginStatus
teamworkLoginStatus
To construct, please use Get-Help -Online and see NOTES section for LOGINSTATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkLoginStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -PeripheralsHealth
teamworkPeripheralsHealth
To construct, please use Get-Help -Online and see NOTES section for PERIPHERALSHEALTH properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkPeripheralsHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SoftwareUpdateHealth
teamworkSoftwareUpdateHealth
To construct, please use Get-Help -Online and see NOTES section for SOFTWAREUPDATEHEALTH properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkSoftwareUpdateHealth
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamworkDeviceId
key: id of teamworkDevice

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkDeviceHealth

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamworkDeviceHealth>: teamworkDeviceHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConnectionStatus <String>]`: teamworkConnectionStatus
    - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The UTC date and time when the device health document was created.
  - `[HardwareHealth <IMicrosoftGraphTeamworkHardwareHealth>]`: teamworkHardwareHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[IsOptional <Boolean?>]`: True if the peripheral is optional. Used for health computation.
      - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[DisplayName <String>]`: Display name for the peripheral.
        - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
        - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
    - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time when the device health detail was last modified.
  - `[LoginStatus <IMicrosoftGraphTeamworkLoginStatus>]`: teamworkLoginStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
  - `[PeripheralsHealth <IMicrosoftGraphTeamworkPeripheralsHealth>]`: teamworkPeripheralsHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: The health details about displays.
    - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[SoftwareUpdateHealth <IMicrosoftGraphTeamworkSoftwareUpdateHealth>]`: teamworkSoftwareUpdateHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AvailableVersion <String>]`: The available software version to update.
      - `[CurrentVersion <String>]`: The current software version.
      - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
    - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus

CONNECTION <IMicrosoftGraphTeamworkConnection>: teamworkConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ConnectionStatus <String>]`: teamworkConnectionStatus
  - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

HARDWAREHEALTH <IMicrosoftGraphTeamworkHardwareHealth>: teamworkHardwareHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ComputeHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConnectionStatus <String>]`: teamworkConnectionStatus
      - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
    - `[IsOptional <Boolean?>]`: True if the peripheral is optional. Used for health computation.
    - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: Display name for the peripheral.
      - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
      - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[HdmiIngestHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth

INPUTOBJECT <ITeamsIdentity>: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: key: id of associatedTeamInfo
  - `[ChannelId <String>]`: key: id of channel
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageHostedContentId <String>]`: key: id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[ConversationMemberId <String>]`: key: id of conversationMember
  - `[DeletedTeamId <String>]`: key: id of deletedTeam
  - `[GroupId <String>]`: key: id of group
  - `[OfferShiftRequestId <String>]`: key: id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: id of openShift
  - `[PinnedChatMessageInfoId <String>]`: key: id of pinnedChatMessageInfo
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SchedulingGroupId <String>]`: key: id of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: key: id of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: key: id of shift
  - `[SwapShiftsChangeRequestId <String>]`: key: id of swapShiftsChangeRequest
  - `[TeamId <String>]`: key: id of team
  - `[TeamsAppDefinitionId <String>]`: key: id of teamsAppDefinition
  - `[TeamsAppId <String>]`: key: id of teamsApp
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: key: id of teamsAsyncOperation
  - `[TeamsTabId <String>]`: key: id of teamsTab
  - `[TeamworkDeviceId <String>]`: key: id of teamworkDevice
  - `[TeamworkDeviceOperationId <String>]`: key: id of teamworkDeviceOperation
  - `[TeamworkTagId <String>]`: key: id of teamworkTag
  - `[TeamworkTagMemberId <String>]`: key: id of teamworkTagMember
  - `[TimeCardId <String>]`: key: id of timeCard
  - `[TimeOffId <String>]`: key: id of timeOff
  - `[TimeOffReasonId <String>]`: key: id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: id of timeOffRequest
  - `[UserId <String>]`: key: id of user
  - `[UserScopeTeamsAppInstallationId <String>]`: key: id of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: key: id of workforceIntegration

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

LOGINSTATUS <IMicrosoftGraphTeamworkLoginStatus>: teamworkLoginStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ExchangeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConnectionStatus <String>]`: teamworkConnectionStatus
    - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
  - `[SkypeConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
  - `[TeamsConnection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection

PERIPHERALSHEALTH <IMicrosoftGraphTeamworkPeripheralsHealth>: teamworkPeripheralsHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CommunicationSpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Connection <IMicrosoftGraphTeamworkConnection>]`: teamworkConnection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConnectionStatus <String>]`: teamworkConnectionStatus
      - `[LastModifiedDateTime <DateTime?>]`: Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
    - `[IsOptional <Boolean?>]`: True if the peripheral is optional. Used for health computation.
    - `[Peripheral <IMicrosoftGraphTeamworkPeripheral>]`: teamworkPeripheral
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: Display name for the peripheral.
      - `[ProductId <String>]`: The product ID of the device. Each product from a vendor has its own ID.
      - `[VendorId <String>]`: The unique identifier for the vendor of the device. Each vendor has a unique ID.
  - `[ContentCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[DisplayHealthCollection <IMicrosoftGraphTeamworkPeripheralHealth[]>]`: The health details about displays.
  - `[MicrophoneHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[RoomCameraHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth
  - `[SpeakerHealth <IMicrosoftGraphTeamworkPeripheralHealth>]`: teamworkPeripheralHealth

SOFTWAREUPDATEHEALTH <IMicrosoftGraphTeamworkSoftwareUpdateHealth>: teamworkSoftwareUpdateHealth
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdminAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AvailableVersion <String>]`: The available software version to update.
    - `[CurrentVersion <String>]`: The current software version.
    - `[SoftwareFreshness <String>]`: teamworkSoftwareFreshness
  - `[CompanyPortalSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[FirmwareSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[OperatingSystemSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[PartnerAgentSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus
  - `[TeamsClientSoftwareUpdateStatus <IMicrosoftGraphTeamworkSoftwareUpdateStatus>]`: teamworkSoftwareUpdateStatus

## RELATED LINKS

