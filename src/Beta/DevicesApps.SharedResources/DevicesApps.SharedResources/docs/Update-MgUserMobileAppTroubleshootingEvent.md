---
external help file:
Module Name: Microsoft.Graph.DevicesApps.SharedResources
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.sharedresources/update-mgusermobileapptroubleshootingevent
schema: 2.0.0
---

# Update-MgUserMobileAppTroubleshootingEvent

## SYNOPSIS
Update the navigation property mobileAppTroubleshootingEvents in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserMobileAppTroubleshootingEvent -MobileAppTroubleshootingEventId <String> -UserId <String>
 [-AdditionalInformation <IMicrosoftGraphKeyValuePair[]>] [-ApplicationId <String>]
 [-AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>] [-CorrelationId <String>]
 [-EventDateTime <DateTime>] [-EventName <String>]
 [-History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>] [-Id <String>]
 [-ManagedDeviceIdentifier <String>] [-TroubleshootingErrorDetailContext <String>]
 [-TroubleshootingErrorDetailFailure <String>] [-TroubleshootingErrorDetailFailureDetails <String>]
 [-TroubleshootingErrorDetailRemediation <String>]
 [-TroubleshootingErrorDetailResources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]
 [-UserId1 <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserMobileAppTroubleshootingEvent -MobileAppTroubleshootingEventId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphMobileAppTroubleshootingEvent> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserMobileAppTroubleshootingEvent -InputObject <IDevicesAppsSharedResourcesIdentity>
 -BodyParameter <IMicrosoftGraphMobileAppTroubleshootingEvent> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserMobileAppTroubleshootingEvent -InputObject <IDevicesAppsSharedResourcesIdentity>
 [-UserId <String>] [-AdditionalInformation <IMicrosoftGraphKeyValuePair[]>] [-ApplicationId <String>]
 [-AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>] [-CorrelationId <String>]
 [-EventDateTime <DateTime>] [-EventName <String>]
 [-History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>] [-Id <String>]
 [-ManagedDeviceIdentifier <String>] [-TroubleshootingErrorDetailContext <String>]
 [-TroubleshootingErrorDetailFailure <String>] [-TroubleshootingErrorDetailFailureDetails <String>]
 [-TroubleshootingErrorDetailRemediation <String>]
 [-TroubleshootingErrorDetailResources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property mobileAppTroubleshootingEvents in users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AdditionalInformation
A set of string key and string value pairs which provides additional information on the Troubleshooting event
To construct, see NOTES section for ADDITIONALINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApplicationId
Intune application identifier.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppLogCollectionRequests
The collection property of AppLogUploadRequest.
To construct, see NOTES section for APPLOGCOLLECTIONREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppLogCollectionRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
MobileAppTroubleshootingEvent Entity.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CorrelationId
Id used for tracing the failure in the service.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EventDateTime
Time when the event occurred .

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EventName
Event Name corresponding to the Troubleshooting Event.
It is an Optional field

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -History
Intune Mobile Application Troubleshooting History Item
To construct, see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsSharedResourcesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ManagedDeviceIdentifier
Device identifier created or collected by Intune.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MobileAppTroubleshootingEventId
key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -TroubleshootingErrorDetailContext
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
Dynamic: False
```

### -TroubleshootingErrorDetailFailure
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
Dynamic: False
```

### -TroubleshootingErrorDetailFailureDetails
The detailed description of what went wrong.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TroubleshootingErrorDetailRemediation
The detailed description of how to remediate this issue.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TroubleshootingErrorDetailResources
Links to helpful documentation about this failure.
To construct, see NOTES section for TROUBLESHOOTINGERRORDETAILRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId1
Identifier for the user that tried to enroll the device.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesAppsSharedResourcesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ADDITIONALINFORMATION <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs which provides additional information on the Troubleshooting event
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

#### APPLOGCOLLECTIONREQUESTS <IMicrosoftGraphAppLogCollectionRequest[]>: The collection property of AppLogUploadRequest.
  - `[Id <String>]`: Read-only.
  - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
  - `[CustomLogFolders <String[]>]`: List of log folders. 
  - `[ErrorMessage <String>]`: Error message if any during the upload process
  - `[Status <String>]`: appLogUploadState

#### BODYPARAMETER <IMicrosoftGraphMobileAppTroubleshootingEvent>: MobileAppTroubleshootingEvent Entity.
  - `[AdditionalInformation <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs which provides additional information on the Troubleshooting event
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[CorrelationId <String>]`: Id used for tracing the failure in the service.
  - `[EventDateTime <DateTime?>]`: Time when the event occurred .
  - `[EventName <String>]`: Event Name corresponding to the Troubleshooting Event. It is an Optional field
  - `[TroubleshootingErrorDetailContext <String>]`: 
  - `[TroubleshootingErrorDetailFailure <String>]`: 
  - `[TroubleshootingErrorDetailFailureDetails <String>]`: The detailed description of what went wrong.
  - `[TroubleshootingErrorDetailRemediation <String>]`: The detailed description of how to remediate this issue.
  - `[TroubleshootingErrorDetailResources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
    - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
    - `[Text <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>]`: The collection property of AppLogUploadRequest.
    - `[Id <String>]`: Read-only.
    - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
    - `[CustomLogFolders <String[]>]`: List of log folders. 
    - `[ErrorMessage <String>]`: Error message if any during the upload process
    - `[Status <String>]`: appLogUploadState
  - `[ApplicationId <String>]`: Intune application identifier.
  - `[History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>]`: Intune Mobile Application Troubleshooting History Item
    - `[OccurrenceDateTime <DateTime?>]`: Time when the history item occurred.
    - `[TroubleshootingErrorDetailContext <String>]`: 
    - `[TroubleshootingErrorDetailFailure <String>]`: 
    - `[TroubleshootingErrorDetailFailureDetails <String>]`: The detailed description of what went wrong.
    - `[TroubleshootingErrorDetailRemediation <String>]`: The detailed description of how to remediate this issue.
    - `[TroubleshootingErrorDetailResources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
  - `[ManagedDeviceIdentifier <String>]`: Device identifier created or collected by Intune.
  - `[UserId <String>]`: Identifier for the user that tried to enroll the device.

#### HISTORY <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>: Intune Mobile Application Troubleshooting History Item
  - `[OccurrenceDateTime <DateTime?>]`: Time when the history item occurred.
  - `[TroubleshootingErrorDetailContext <String>]`: 
  - `[TroubleshootingErrorDetailFailure <String>]`: 
  - `[TroubleshootingErrorDetailFailureDetails <String>]`: The detailed description of what went wrong.
  - `[TroubleshootingErrorDetailRemediation <String>]`: The detailed description of how to remediate this issue.
  - `[TroubleshootingErrorDetailResources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
    - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
    - `[Text <String>]`: 

#### INPUTOBJECT <IDevicesAppsSharedResourcesIdentity>: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: key: appLogCollectionRequest-id of appLogCollectionRequest
  - `[MobileAppTroubleshootingEventId <String>]`: key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent
  - `[UserId <String>]`: key: user-id of user

#### TROUBLESHOOTINGERRORDETAILRESOURCES <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>: Links to helpful documentation about this failure.
  - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
  - `[Text <String>]`: 

## RELATED LINKS

