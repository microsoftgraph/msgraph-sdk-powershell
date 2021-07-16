---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementmobileapptroubleshootingevent
schema: 2.0.0
---

# New-MgDeviceManagementMobileAppTroubleshootingEvent

## SYNOPSIS
The collection property of MobileAppTroubleshootingEvent.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMobileAppTroubleshootingEvent [-AdditionalInformation <IMicrosoftGraphKeyValuePair[]>]
 [-AdditionalProperties <Hashtable>] [-AppLogCollectionRequests <IMicrosoftGraphAppLogCollectionRequest[]>]
 [-ApplicationId <String>] [-CorrelationId <String>] [-EventDateTime <DateTime>] [-EventName <String>]
 [-History <IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]>] [-Id <String>]
 [-ManagedDeviceIdentifier <String>]
 [-TroubleshootingErrorDetails <IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails>] [-UserId <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMobileAppTroubleshootingEvent
 -BodyParameter <IMicrosoftGraphMobileAppTroubleshootingEvent> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The collection property of MobileAppTroubleshootingEvent.

## EXAMPLES

## PARAMETERS

### -AdditionalInformation
A set of string key and string value pairs which provides additional information on the Troubleshooting event
To construct, see NOTES section for ADDITIONALINFORMATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
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
Type: Hashtable
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
Type: String
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
To construct, see NOTES section for APPLOGCOLLECTIONREQUESTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAppLogCollectionRequest[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
MobileAppTroubleshootingEvent Entity.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppTroubleshootingEvent
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
Type: String
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
Type: DateTime
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
Type: String
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
To construct, see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppTroubleshootingHistoryItem[]
Parameter Sets: CreateExpanded
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
Type: String
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
Type: String
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
To construct, see NOTES section for TROUBLESHOOTINGERRORDETAILS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementTroubleshootingErrorDetails
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
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppTroubleshootingEvent
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDITIONALINFORMATION <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs which provides additional information on the Troubleshooting event
  - `[Name <String>]`: Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.
  - `[Value <String>]`: Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).

APPLOGCOLLECTIONREQUESTS <IMicrosoftGraphAppLogCollectionRequest[]>: The collection property of AppLogUploadRequest.
  - `[Id <String>]`: Read-only.
  - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
  - `[CustomLogFolders <String[]>]`: List of log folders.
  - `[ErrorMessage <String>]`: Error message if any during the upload process
  - `[Status <String>]`: appLogUploadState

BODYPARAMETER <IMicrosoftGraphMobileAppTroubleshootingEvent>: MobileAppTroubleshootingEvent Entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdditionalInformation <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs which provides additional information on the Troubleshooting event
    - `[Name <String>]`: Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.
    - `[Value <String>]`: Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).
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
