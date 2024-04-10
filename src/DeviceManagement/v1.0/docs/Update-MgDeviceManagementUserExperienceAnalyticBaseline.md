---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticbaseline
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticBaseline

## SYNOPSIS
Update the navigation property userExperienceAnalyticsBaselines in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticBaseline -UserExperienceAnalyticsBaselineId <String>
 [-AdditionalProperties <Hashtable>] [-AppHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BatteryHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BestPracticesMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-CreatedDateTime <DateTime>]
 [-DeviceBootPerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-DisplayName <String>]
 [-Id <String>] [-IsBuiltIn] [-RebootAnalyticsMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-ResourcePerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-ResponseHeadersVariable <String>]
 [-WorkFromAnywhereMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticBaseline -UserExperienceAnalyticsBaselineId <String>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBaseline> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementUserExperienceAnalyticBaseline -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsBaseline> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementUserExperienceAnalyticBaseline -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AppHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BatteryHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-BestPracticesMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-CreatedDateTime <DateTime>]
 [-DeviceBootPerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-DisplayName <String>]
 [-Id <String>] [-IsBuiltIn] [-RebootAnalyticsMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-ResourcePerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]
 [-ResponseHeadersVariable <String>]
 [-WorkFromAnywhereMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsBaselines in deviceManagement

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

### -AppHealthMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for APPHEALTHMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BatteryHealthMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for BATTERYHEALTHMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BestPracticesMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for BESTPRACTICESMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics baseline entity contains baseline values against which to compare the user experience analytics scores.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date the custom baseline was created.
The value cannot be modified and is automatically populated when the baseline is created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Returned by default.

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

### -DeviceBootPerformanceMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for DEVICEBOOTPERFORMANCEMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the baseline.

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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsBuiltIn
When TRUE, indicates the current baseline is the commercial median baseline.
When FALSE, indicates it is a custom baseline.
FALSE by default.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootAnalyticsMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for REBOOTANALYTICSMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourcePerformanceMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for RESOURCEPERFORMANCEMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
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

### -UserExperienceAnalyticsBaselineId
The unique identifier of userExperienceAnalyticsBaseline

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

### -WorkFromAnywhereMetrics
The user experience analytics category entity contains the scores and insights for the various metrics of a category.
To construct, see NOTES section for WORKFROMANYWHEREMETRICS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsCategory
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsBaseline

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPHEALTHMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

`BATTERYHEALTHMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

`BESTPRACTICESMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsBaseline>`: The user experience analytics baseline entity contains baseline values against which to compare the user experience analytics scores.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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
  - `[BatteryHealthMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[BestPracticesMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[CreatedDateTime <DateTime?>]`: The date the custom baseline was created. The value cannot be modified and is automatically populated when the baseline is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Returned by default.
  - `[DeviceBootPerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[DisplayName <String>]`: The name of the baseline.
  - `[IsBuiltIn <Boolean?>]`: When TRUE, indicates the current baseline is the commercial median baseline. When FALSE, indicates it is a custom baseline. FALSE by default.
  - `[RebootAnalyticsMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[ResourcePerformanceMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
  - `[WorkFromAnywhereMetrics <IMicrosoftGraphUserExperienceAnalyticsCategory>]`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.

`DEVICEBOOTPERFORMANCEMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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
  - `[UserExperienceAnalyticsDeviceStartupProcessPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupProcessPerformance
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

`REBOOTANALYTICSMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

`RESOURCEPERFORMANCEMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

`WORKFROMANYWHEREMETRICS <IMicrosoftGraphUserExperienceAnalyticsCategory>`: The user experience analytics category entity contains the scores and insights for the various metrics of a category.
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

## RELATED LINKS

