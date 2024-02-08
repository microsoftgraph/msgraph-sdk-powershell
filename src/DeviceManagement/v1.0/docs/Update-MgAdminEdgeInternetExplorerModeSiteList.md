---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement/update-mgadminedgeinternetexplorermodesitelist
schema: 2.0.0
---

# Update-MgAdminEdgeInternetExplorerModeSiteList

## SYNOPSIS
Update the properties of a browserSiteList object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAdminEdgeInternetExplorerModeSiteList -BrowserSiteListId <String> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-PublishedBy <IMicrosoftGraphIdentitySet>]
 [-PublishedDateTime <DateTime>] [-Revision <String>] [-SharedCookies <IMicrosoftGraphBrowserSharedCookie[]>]
 [-Sites <IMicrosoftGraphBrowserSite[]>] [-Status <BrowserSiteListStatus>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgAdminEdgeInternetExplorerModeSiteList -BrowserSiteListId <String>
 -BodyParameter <IMicrosoftGraphBrowserSiteList> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAdminEdgeInternetExplorerModeSiteList -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphBrowserSiteList> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAdminEdgeInternetExplorerModeSiteList -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-PublishedBy <IMicrosoftGraphIdentitySet>] [-PublishedDateTime <DateTime>] [-Revision <String>]
 [-SharedCookies <IMicrosoftGraphBrowserSharedCookie[]>] [-Sites <IMicrosoftGraphBrowserSite[]>]
 [-Status <BrowserSiteListStatus>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a browserSiteList object.

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
A singleton entity which is used to specify IE mode site list metadata
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBrowserSiteList
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BrowserSiteListId
The unique identifier of browserSiteList

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

### -Description
The description of the site list.

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
The name of the site list.

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

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

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
The date and time when the site list was last modified.

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

### -PublishedBy
identitySet
To construct, see NOTES section for PUBLISHEDBY properties and create a hash table.

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

### -PublishedDateTime
The date and time when the site list was published.

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

### -Revision
The current revision of the site list.

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

### -SharedCookies
A collection of shared cookies defined for the site list.
To construct, see NOTES section for SHAREDCOOKIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBrowserSharedCookie[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sites
A collection of sites defined for the site list.
To construct, see NOTES section for SITES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBrowserSite[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
browserSiteListStatus

```yaml
Type: Microsoft.Graph.PowerShell.Support.BrowserSiteListStatus
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBrowserSiteList

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBrowserSiteList

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphBrowserSiteList>`: A singleton entity which is used to specify IE mode site list metadata
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the site list.
  - `[DisplayName <String>]`: The name of the site list.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the site list was last modified.
  - `[PublishedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[PublishedDateTime <DateTime?>]`: The date and time when the site list was published.
  - `[Revision <String>]`: The current revision of the site list.
  - `[SharedCookies <IMicrosoftGraphBrowserSharedCookie[]>]`: A collection of shared cookies defined for the site list.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Comment <String>]`: The comment for the shared cookie.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the shared cookie was created.
    - `[DeletedDateTime <DateTime?>]`: The date and time when the shared cookie was deleted.
    - `[DisplayName <String>]`: The name of the cookie.
    - `[History <IMicrosoftGraphBrowserSharedCookieHistory[]>]`: The history of modifications applied to the cookie.
      - `[Comment <String>]`: The comment for the shared cookie.
      - `[DisplayName <String>]`: The name of the cookie.
      - `[HostOnly <Boolean?>]`: Controls whether a cookie is a host-only or domain cookie.
      - `[HostOrDomain <String>]`: The URL of the cookie.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Path <String>]`: The path of the cookie.
      - `[PublishedDateTime <DateTime?>]`: The date and time when the cookie was last published.
      - `[SourceEnvironment <BrowserSharedCookieSourceEnvironment?>]`: browserSharedCookieSourceEnvironment
    - `[HostOnly <Boolean?>]`: Controls whether a cookie is a host-only or domain cookie.
    - `[HostOrDomain <String>]`: The URL of the cookie.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the cookie was last modified.
    - `[Path <String>]`: The path of the cookie.
    - `[SourceEnvironment <BrowserSharedCookieSourceEnvironment?>]`: browserSharedCookieSourceEnvironment
    - `[Status <BrowserSharedCookieStatus?>]`: browserSharedCookieStatus
  - `[Sites <IMicrosoftGraphBrowserSite[]>]`: A collection of sites defined for the site list.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowRedirect <Boolean?>]`: Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.
    - `[Comment <String>]`: The comment for the site.
    - `[CompatibilityMode <BrowserSiteCompatibilityMode?>]`: browserSiteCompatibilityMode
    - `[CreatedDateTime <DateTime?>]`: The date and time when the site was created.
    - `[DeletedDateTime <DateTime?>]`: The date and time when the site was deleted.
    - `[History <IMicrosoftGraphBrowserSiteHistory[]>]`: The history of modifications applied to the site.
      - `[AllowRedirect <Boolean?>]`: Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.
      - `[Comment <String>]`: The comment for the site.
      - `[CompatibilityMode <BrowserSiteCompatibilityMode?>]`: browserSiteCompatibilityMode
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[MergeType <BrowserSiteMergeType?>]`: browserSiteMergeType
      - `[PublishedDateTime <DateTime?>]`: The date and time when the site was last published.
      - `[TargetEnvironment <BrowserSiteTargetEnvironment?>]`: browserSiteTargetEnvironment
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the site was last modified.
    - `[MergeType <BrowserSiteMergeType?>]`: browserSiteMergeType
    - `[Status <BrowserSiteStatus?>]`: browserSiteStatus
    - `[TargetEnvironment <BrowserSiteTargetEnvironment?>]`: browserSiteTargetEnvironment
    - `[WebUrl <String>]`: The URL of the site.
  - `[Status <BrowserSiteListStatus?>]`: browserSiteListStatus

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

`LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`PUBLISHEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`SHAREDCOOKIES <IMicrosoftGraphBrowserSharedCookie[]>`: A collection of shared cookies defined for the site list.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Comment <String>]`: The comment for the shared cookie.
  - `[CreatedDateTime <DateTime?>]`: The date and time when the shared cookie was created.
  - `[DeletedDateTime <DateTime?>]`: The date and time when the shared cookie was deleted.
  - `[DisplayName <String>]`: The name of the cookie.
  - `[History <IMicrosoftGraphBrowserSharedCookieHistory[]>]`: The history of modifications applied to the cookie.
    - `[Comment <String>]`: The comment for the shared cookie.
    - `[DisplayName <String>]`: The name of the cookie.
    - `[HostOnly <Boolean?>]`: Controls whether a cookie is a host-only or domain cookie.
    - `[HostOrDomain <String>]`: The URL of the cookie.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Path <String>]`: The path of the cookie.
    - `[PublishedDateTime <DateTime?>]`: The date and time when the cookie was last published.
    - `[SourceEnvironment <BrowserSharedCookieSourceEnvironment?>]`: browserSharedCookieSourceEnvironment
  - `[HostOnly <Boolean?>]`: Controls whether a cookie is a host-only or domain cookie.
  - `[HostOrDomain <String>]`: The URL of the cookie.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the cookie was last modified.
  - `[Path <String>]`: The path of the cookie.
  - `[SourceEnvironment <BrowserSharedCookieSourceEnvironment?>]`: browserSharedCookieSourceEnvironment
  - `[Status <BrowserSharedCookieStatus?>]`: browserSharedCookieStatus

`SITES <IMicrosoftGraphBrowserSite[]>`: A collection of sites defined for the site list.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowRedirect <Boolean?>]`: Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.
  - `[Comment <String>]`: The comment for the site.
  - `[CompatibilityMode <BrowserSiteCompatibilityMode?>]`: browserSiteCompatibilityMode
  - `[CreatedDateTime <DateTime?>]`: The date and time when the site was created.
  - `[DeletedDateTime <DateTime?>]`: The date and time when the site was deleted.
  - `[History <IMicrosoftGraphBrowserSiteHistory[]>]`: The history of modifications applied to the site.
    - `[AllowRedirect <Boolean?>]`: Controls the behavior of redirected sites. If true, indicates that the site will open in Internet Explorer 11 or Microsoft Edge even if the site is navigated to as part of a HTTP or meta refresh redirection chain.
    - `[Comment <String>]`: The comment for the site.
    - `[CompatibilityMode <BrowserSiteCompatibilityMode?>]`: browserSiteCompatibilityMode
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[MergeType <BrowserSiteMergeType?>]`: browserSiteMergeType
    - `[PublishedDateTime <DateTime?>]`: The date and time when the site was last published.
    - `[TargetEnvironment <BrowserSiteTargetEnvironment?>]`: browserSiteTargetEnvironment
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the site was last modified.
  - `[MergeType <BrowserSiteMergeType?>]`: browserSiteMergeType
  - `[Status <BrowserSiteStatus?>]`: browserSiteStatus
  - `[TargetEnvironment <BrowserSiteTargetEnvironment?>]`: browserSiteTargetEnvironment
  - `[WebUrl <String>]`: The URL of the site.

## RELATED LINKS

