---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticcategory
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticCategory

## SYNOPSIS
Update the navigation property userExperienceAnalyticsCategories in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticCategory -UserExperienceAnalyticsCategoryId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]
 [-MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticCategory -UserExperienceAnalyticsCategoryId <String>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementUserExperienceAnalyticCategory -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementUserExperienceAnalyticCategory -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]
 [-MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsCategories in deviceManagement

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

### -BodyParameter
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Insights
The insights for the category.
Read-only.
To construct, see NOTES section for INSIGHTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsInsight[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MetricValues
The metric values for the user experience analytics category.
Read-only.
To construct, see NOTES section for METRICVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsMetric[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserExperienceAnalyticsCategoryId
The unique identifier of userExperienceAnalyticsCategory

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Insights <IMicrosoftGraphUserExperienceAnalyticsInsight[]>]`: The insights for the category. Read-only.
    - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
    - `[Severity <UserExperienceAnalyticsInsightSeverity?>]`: Indicates severity of insights. Possible values are: None, Informational, Warning, Error.
    - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics metric.
    - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.
  - `[MetricValues <IMicrosoftGraphUserExperienceAnalyticsMetric[]>]`: The metric values for the user experience analytics category. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Unit <String>]`: The unit of the user experience analytics metric. Examples: none, percentage, count, seconds, score.
    - `[Value <Double?>]`: The value of the user experience analytics metric.

`INPUTOBJECT <IDeviceManagementIdentity>`: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[BrowserSharedCookieId <String>]`: The unique identifier of browserSharedCookie
  - `[BrowserSiteId <String>]`: The unique identifier of browserSite
  - `[BrowserSiteListId <String>]`: The unique identifier of browserSiteList
  - `[DetectedAppId <String>]`: The unique identifier of detectedApp
  - `[DeviceCategoryId <String>]`: The unique identifier of deviceCategory
  - `[DeviceComplianceActionItemId <String>]`: The unique identifier of deviceComplianceActionItem
  - `[DeviceComplianceDeviceStatusId <String>]`: The unique identifier of deviceComplianceDeviceStatus
  - `[DeviceCompliancePolicyAssignmentId <String>]`: The unique identifier of deviceCompliancePolicyAssignment
  - `[DeviceCompliancePolicyId <String>]`: The unique identifier of deviceCompliancePolicy
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: The unique identifier of deviceCompliancePolicySettingStateSummary
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceComplianceScheduledActionForRuleId <String>]`: The unique identifier of deviceComplianceScheduledActionForRule
  - `[DeviceComplianceSettingStateId <String>]`: The unique identifier of deviceComplianceSettingState
  - `[DeviceComplianceUserStatusId <String>]`: The unique identifier of deviceComplianceUserStatus
  - `[DeviceConfigurationAssignmentId <String>]`: The unique identifier of deviceConfigurationAssignment
  - `[DeviceConfigurationDeviceStatusId <String>]`: The unique identifier of deviceConfigurationDeviceStatus
  - `[DeviceConfigurationId <String>]`: The unique identifier of deviceConfiguration
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceConfigurationUserStatusId <String>]`: The unique identifier of deviceConfigurationUserStatus
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[LocalizedNotificationMessageId <String>]`: The unique identifier of localizedNotificationMessage
  - `[MalwareStateForWindowsDeviceId <String>]`: The unique identifier of malwareStateForWindowsDevice
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: The unique identifier of notificationMessageTemplate
  - `[SettingStateDeviceSummaryId <String>]`: The unique identifier of settingStateDeviceSummary
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetailsId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByOSVersion
  - `[UserExperienceAnalyticsAppHealthApplicationPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthApplicationPerformance
  - `[UserExperienceAnalyticsAppHealthDeviceModelPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDeviceModelPerformance
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceDetailsId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDevicePerformanceDetails
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDevicePerformance
  - `[UserExperienceAnalyticsAppHealthOSVersionPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthOSVersionPerformance
  - `[UserExperienceAnalyticsBaselineId <String>]`: The unique identifier of userExperienceAnalyticsBaseline
  - `[UserExperienceAnalyticsCategoryId <String>]`: The unique identifier of userExperienceAnalyticsCategory
  - `[UserExperienceAnalyticsDevicePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsDevicePerformance
  - `[UserExperienceAnalyticsDeviceScoresId <String>]`: The unique identifier of userExperienceAnalyticsDeviceScores
  - `[UserExperienceAnalyticsDeviceStartupHistoryId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupHistory
  - `[UserExperienceAnalyticsDeviceStartupProcessId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupProcess
  - `[UserExperienceAnalyticsMetricHistoryId <String>]`: The unique identifier of userExperienceAnalyticsMetricHistory
  - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of userExperienceAnalyticsMetric
  - `[UserExperienceAnalyticsModelScoresId <String>]`: The unique identifier of userExperienceAnalyticsModelScores
  - `[UserExperienceAnalyticsScoreHistoryId <String>]`: The unique identifier of userExperienceAnalyticsScoreHistory
  - `[UserExperienceAnalyticsWorkFromAnywhereDeviceId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereDevice
  - `[UserExperienceAnalyticsWorkFromAnywhereMetricId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereMetric
  - `[UserExperienceAnalyticsWorkFromAnywhereModelPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereModelPerformance
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLearningSummaryId <String>]`: The unique identifier of windowsInformationProtectionAppLearningSummary
  - `[WindowsInformationProtectionNetworkLearningSummaryId <String>]`: The unique identifier of windowsInformationProtectionNetworkLearningSummary
  - `[WindowsMalwareInformationId <String>]`: The unique identifier of windowsMalwareInformation

`INSIGHTS <IMicrosoftGraphUserExperienceAnalyticsInsight[]>`: The insights for the category. Read-only.
  - `[InsightId <String>]`: The unique identifier of the user experience analytics insight.
  - `[Severity <UserExperienceAnalyticsInsightSeverity?>]`: Indicates severity of insights. Possible values are: None, Informational, Warning, Error.
  - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of the user experience analytics metric.
  - `[Values <IMicrosoftGraphUserExperienceAnalyticsInsightValue[]>]`: The value of the user experience analytics insight.

`METRICVALUES <IMicrosoftGraphUserExperienceAnalyticsMetric[]>`: The metric values for the user experience analytics category. Read-only.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Unit <String>]`: The unit of the user experience analytics metric. Examples: none, percentage, count, seconds, score.
  - `[Value <Double?>]`: The value of the user experience analytics metric.

## RELATED LINKS

