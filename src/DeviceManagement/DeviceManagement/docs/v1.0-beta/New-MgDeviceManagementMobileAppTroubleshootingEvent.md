---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementmobileapptroubleshootingevent
schema: 2.0.0
---

# New-MgDeviceManagementMobileAppTroubleshootingEvent

## SYNOPSIS
Create new navigation property to mobileAppTroubleshootingEvents for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMobileAppTroubleshootingEvent [-AdditionalInformation <IMicrosoftGraphKeyValuePair[]>]
 [-AdditionalProperties <Hashtable>] [-ApplicationId <String>]
 [-AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>] [-CorrelationId <String>]
 [-EventDateTime <DateTime>] [-EventName <String>]
 [-History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>] [-Id <String>]
 [-ManagedDeviceIdentifier <String>]
 [-TroubleshootingErrorDetails <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>]
 [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMobileAppTroubleshootingEvent
 -BodyParameter <IMicrosoftGraphMobileAppTroubleshootingEvent> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileAppTroubleshootingEvents for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalInformation
A set of string key and string value pairs which provides additional information on the Troubleshooting event
To construct, please use Get-Help -Online and see NOTES section for ADDITIONALINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId
Intune application identifier.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppLogCollectionRequests
The collection property of AppLogUploadRequest.
To construct, please use Get-Help -Online and see NOTES section for APPLOGCOLLECTIONREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppLogCollectionRequest[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Event representing a users device application install status.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CorrelationId
Id used for tracing the failure in the service.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventDateTime
Time when the event occurred .

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventName
Event Name corresponding to the Troubleshooting Event.
It is an Optional field

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -History
Intune Mobile Application Troubleshooting History Item
To construct, please use Get-Help -Online and see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceIdentifier
Device identifier created or collected by Intune.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TroubleshootingErrorDetails
Object containing detailed information about the error and its remediation.
To construct, please use Get-Help -Online and see NOTES section for TROUBLESHOOTINGERRORDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
Identifier for the user that tried to enroll the device.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDITIONALINFORMATION <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs which provides additional information on the Troubleshooting event
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

APPLOGCOLLECTIONREQUESTS <IMicrosoftGraphAppLogCollectionRequest[]>: The collection property of AppLogUploadRequest.
  - `[Id <String>]`: 
  - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
  - `[CustomLogFolders <String[]>]`: List of log folders.
  - `[ErrorMessage <String>]`: Error message if any during the upload process
  - `[Status <AppLogUploadState?>]`: AppLogUploadStatus

BODYPARAMETER <IMicrosoftGraphMobileAppTroubleshootingEvent>: Event representing a users device application install status.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdditionalInformation <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs which provides additional information on the Troubleshooting event
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[CorrelationId <String>]`: Id used for tracing the failure in the service.
  - `[EventDateTime <DateTime?>]`: Time when the event occurred .
  - `[EventName <String>]`: Event Name corresponding to the Troubleshooting Event. It is an Optional field
  - `[TroubleshootingErrorDetails <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>]`: Object containing detailed information about the error and its remediation.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Context <String>]`: Not yet documented
    - `[Failure <String>]`: Not yet documented
    - `[FailureDetails <String>]`: The detailed description of what went wrong.
    - `[Remediation <String>]`: The detailed description of how to remediate this issue.
    - `[Resources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
      - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
      - `[Text <String>]`: Not yet documented
  - `[Id <String>]`: 
  - `[AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>]`: The collection property of AppLogUploadRequest.
    - `[Id <String>]`: 
    - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
    - `[CustomLogFolders <String[]>]`: List of log folders.
    - `[ErrorMessage <String>]`: Error message if any during the upload process
    - `[Status <AppLogUploadState?>]`: AppLogUploadStatus
  - `[ApplicationId <String>]`: Intune application identifier.
  - `[History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>]`: Intune Mobile Application Troubleshooting History Item
    - `[OccurrenceDateTime <DateTime?>]`: Time when the history item occurred.
    - `[TroubleshootingErrorDetails <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>]`: Object containing detailed information about the error and its remediation.
  - `[ManagedDeviceIdentifier <String>]`: Device identifier created or collected by Intune.
  - `[UserId <String>]`: Identifier for the user that tried to enroll the device.

HISTORY <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>: Intune Mobile Application Troubleshooting History Item
  - `[OccurrenceDateTime <DateTime?>]`: Time when the history item occurred.
  - `[TroubleshootingErrorDetails <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>]`: Object containing detailed information about the error and its remediation.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Context <String>]`: Not yet documented
    - `[Failure <String>]`: Not yet documented
    - `[FailureDetails <String>]`: The detailed description of what went wrong.
    - `[Remediation <String>]`: The detailed description of how to remediate this issue.
    - `[Resources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
      - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
      - `[Text <String>]`: Not yet documented

TROUBLESHOOTINGERRORDETAILS <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>: Object containing detailed information about the error and its remediation.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Context <String>]`: Not yet documented
  - `[Failure <String>]`: Not yet documented
  - `[FailureDetails <String>]`: The detailed description of what went wrong.
  - `[Remediation <String>]`: The detailed description of how to remediate this issue.
  - `[Resources <IMicrosoftGraphDeviceManagementTroubleshootingErrorResource[]>]`: Links to helpful documentation about this failure.
    - `[Link <String>]`: The link to the web resource. Can contain any of the following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
    - `[Text <String>]`: Not yet documented

## RELATED LINKS

