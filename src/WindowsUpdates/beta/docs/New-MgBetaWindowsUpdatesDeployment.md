---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/new-mgbetawindowsupdatesdeployment
schema: 2.0.0
---

# New-MgBetaWindowsUpdatesDeployment

## SYNOPSIS
Create a new deployment object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaWindowsUpdatesDeployment [-AdditionalProperties <Hashtable>]
 [-Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>] [-Content <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]
 [-State <IMicrosoftGraphWindowsUpdatesDeploymentState>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaWindowsUpdatesDeployment -BodyParameter <IMicrosoftGraphWindowsUpdatesDeployment> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new deployment object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	Content = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.featureUpdateReference"
		Version = "20H2"
	}
	Settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.windowsDeploymentSettings"
		Rollout = @{
			DevicesPerOffer = 100
		}
		Monitoring = @{
			MonitoringRules = @(
				@{
					"@odata.type" = "#microsoft.graph.windowsUpdates.monitoringRule"
					Signal = "rollback"
					Threshold = 5
					Action = "pauseDeployment"
				}
			)
		}
	}
}
New-MgBetaWindowsUpdatesDeployment -BodyParameter $params
```



## PARAMETERS

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

### -Audience
deploymentAudience
To construct, see NOTES section for AUDIENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentAudience
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
deployment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Content
deployableContent

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

### -CreatedDateTime
The date and time the deployment was created.
Returned by default.
Read-only.

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

### -Id
The unique identifier for an entity.
Read-only.

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

### -LastModifiedDateTime
The date and time the deployment was last modified.
Returned by default.
Read-only.

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

### -Settings
deploymentSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
deploymentState
To construct, see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentState
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment

## NOTES

ALIASES

New-MgBetaWuDeployment

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUDIENCE <IMicrosoftGraphWindowsUpdatesDeploymentAudience>`: deploymentAudience
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableContent <IMicrosoftGraphWindowsUpdatesApplicableContent[]>]`: Content eligible to deploy to devices in the audience. Not nullable. Read-only.
    - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[DisplayName <String>]`: The display name of the content. Read-only.
      - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]`: Collection of devices and recommendations for applicable catalog content.
      - `[DeviceId <String>]`: 
      - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.
  - `[Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to exclude from the audience.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to include in the audience.

`BODYPARAMETER <IMicrosoftGraphWindowsUpdatesDeployment>`: deployment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>]`: deploymentAudience
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ApplicableContent <IMicrosoftGraphWindowsUpdatesApplicableContent[]>]`: Content eligible to deploy to devices in the audience. Not nullable. Read-only.
      - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[DisplayName <String>]`: The display name of the content. Read-only.
        - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[MatchedDevices <IMicrosoftGraphWindowsUpdatesApplicableContentDeviceMatch[]>]`: Collection of devices and recommendations for applicable catalog content.
        - `[DeviceId <String>]`: 
        - `[RecommendedBy <String[]>]`: Collection of vendors who recommend the content.
    - `[Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to exclude from the audience.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to include in the audience.
  - `[Content <IMicrosoftGraphWindowsUpdatesDeployableContent>]`: deployableContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: The date and time the deployment was created. Returned by default. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the deployment was last modified. Returned by default. Read-only.
  - `[Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]`: deploymentSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentApplicability <IMicrosoftGraphWindowsUpdatesContentApplicabilitySettings>]`: contentApplicabilitySettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[OfferWhileRecommendedBy <String[]>]`: Offer if the update is recommended by a vendor in the list, otherwise withhold the offer.
      - `[Safeguard <IMicrosoftGraphWindowsUpdatesSafeguardSettings>]`: safeguardSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisabledSafeguardProfiles <IMicrosoftGraphWindowsUpdatesSafeguardProfile[]>]`: List of safeguards to ignore per device.
          - `[Category <String>]`: safeguardCategory
    - `[Expedite <IMicrosoftGraphWindowsUpdatesExpediteSettings>]`: expediteSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsExpedited <Boolean?>]`: True indicates that the deployment of the content is expedited.
      - `[IsReadinessTest <Boolean?>]`: 
    - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or.'
        - `[Action <String>]`: monitoringAction
        - `[Signal <String>]`: monitoringSignal
        - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger the action. An integer from 1 to 100 (inclusive). This value is ignored when the signal is ineligible and the action is offerFallback.
    - `[Schedule <IMicrosoftGraphWindowsUpdatesScheduleSettings>]`: scheduleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[GradualRollout <IMicrosoftGraphWindowsUpdatesGradualRolloutSettings>]`: gradualRolloutSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DurationBetweenOffers <TimeSpan?>]`: The duration between each set of devices being offered the update. The value is represented in ISO 8601 format for duration. Default value is P1D (one day).
      - `[StartDateTime <DateTime?>]`: The date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[UserExperience <IMicrosoftGraphWindowsUpdatesUserExperienceSettings>]`: userExperienceSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DaysUntilForcedReboot <Int32?>]`: Specifies the number of days after an update is installed, during which the user of the device can control when the device restarts.
  - `[State <IMicrosoftGraphWindowsUpdatesDeploymentState>]`: deploymentState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EffectiveValue <String>]`: deploymentStateValue
    - `[Reasons <IMicrosoftGraphWindowsUpdatesDeploymentStateReason[]>]`: Specifies the reasons the deployment has its state value. Read-only.
      - `[Value <String>]`: deploymentStateReasonValue
    - `[RequestedValue <String>]`: requestedDeploymentStateValue

`SETTINGS <IMicrosoftGraphWindowsUpdatesDeploymentSettings>`: deploymentSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentApplicability <IMicrosoftGraphWindowsUpdatesContentApplicabilitySettings>]`: contentApplicabilitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OfferWhileRecommendedBy <String[]>]`: Offer if the update is recommended by a vendor in the list, otherwise withhold the offer.
    - `[Safeguard <IMicrosoftGraphWindowsUpdatesSafeguardSettings>]`: safeguardSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisabledSafeguardProfiles <IMicrosoftGraphWindowsUpdatesSafeguardProfile[]>]`: List of safeguards to ignore per device.
        - `[Category <String>]`: safeguardCategory
  - `[Expedite <IMicrosoftGraphWindowsUpdatesExpediteSettings>]`: expediteSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsExpedited <Boolean?>]`: True indicates that the deployment of the content is expedited.
    - `[IsReadinessTest <Boolean?>]`: 
  - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or.'
      - `[Action <String>]`: monitoringAction
      - `[Signal <String>]`: monitoringSignal
      - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger the action. An integer from 1 to 100 (inclusive). This value is ignored when the signal is ineligible and the action is offerFallback.
  - `[Schedule <IMicrosoftGraphWindowsUpdatesScheduleSettings>]`: scheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[GradualRollout <IMicrosoftGraphWindowsUpdatesGradualRolloutSettings>]`: gradualRolloutSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationBetweenOffers <TimeSpan?>]`: The duration between each set of devices being offered the update. The value is represented in ISO 8601 format for duration. Default value is P1D (one day).
    - `[StartDateTime <DateTime?>]`: The date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[UserExperience <IMicrosoftGraphWindowsUpdatesUserExperienceSettings>]`: userExperienceSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DaysUntilForcedReboot <Int32?>]`: Specifies the number of days after an update is installed, during which the user of the device can control when the device restarts.

`STATE <IMicrosoftGraphWindowsUpdatesDeploymentState>`: deploymentState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EffectiveValue <String>]`: deploymentStateValue
  - `[Reasons <IMicrosoftGraphWindowsUpdatesDeploymentStateReason[]>]`: Specifies the reasons the deployment has its state value. Read-only.
    - `[Value <String>]`: deploymentStateReasonValue
  - `[RequestedValue <String>]`: requestedDeploymentStateValue

## RELATED LINKS

