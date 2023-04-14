---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/update-mgwindowsupdatesdeployment
schema: 2.0.0
---

# Update-MgWindowsUpdatesDeployment

## SYNOPSIS
Update the navigation property deployments in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgWindowsUpdatesDeployment -DeploymentId <String> [-AdditionalProperties <Hashtable>]
 [-Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>] [-Content <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]
 [-State <IMicrosoftGraphWindowsUpdatesDeploymentState>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgWindowsUpdatesDeployment -DeploymentId <String>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeployment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgWindowsUpdatesDeployment -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeployment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgWindowsUpdatesDeployment -InputObject <IWindowsUpdatesIdentity> [-AdditionalProperties <Hashtable>]
 [-Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>] [-Content <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]
 [-State <IMicrosoftGraphWindowsUpdatesDeploymentState>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deployments in admin

## EXAMPLES

### Example 1: Using the Update-MgWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	State = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentState"
		RequestedValue = "paused"
	}
}
Update-MgWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```

This example shows how to use the Update-MgWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Update-MgWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	Settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.windowsDeploymentSettings"
		Monitoring = @{
			MonitoringRules = @(
				@{
					Signal = "rollback"
					Threshold = 5
					Action = "pauseDeployment"
				}
			)
		}
	}
}
Update-MgWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```

This example shows how to use the Update-MgWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -Audience
deploymentAudience
To construct, please use Get-Help -Online and see NOTES section for AUDIENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentAudience
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
deployment
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentId
The unique identifier of deployment

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time the deployment was last modified.
Returned by default.
Read-only.

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

### -Settings
deploymentSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
deploymentState
To construct, please use Get-Help -Online and see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentState
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgWuDeployment

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AUDIENCE <IMicrosoftGraphWindowsUpdatesDeploymentAudience>: deploymentAudience
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

BODYPARAMETER <IMicrosoftGraphWindowsUpdatesDeployment>: deployment
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
    - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or'.
        - `[Action <String>]`: monitoringAction
        - `[Signal <String>]`: monitoringSignal
        - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).
    - `[Schedule <IMicrosoftGraphWindowsUpdatesScheduleSettings>]`: scheduleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[GradualRollout <IMicrosoftGraphWindowsUpdatesGradualRolloutSettings>]`: gradualRolloutSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DurationBetweenOffers <TimeSpan?>]`: The duration between each set of devices being offered the update. The value is represented in ISO 8601 format for duration. Default value is P1D (1 day).
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

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

SETTINGS <IMicrosoftGraphWindowsUpdatesDeploymentSettings>: deploymentSettings
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
  - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or'.
      - `[Action <String>]`: monitoringAction
      - `[Signal <String>]`: monitoringSignal
      - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).
  - `[Schedule <IMicrosoftGraphWindowsUpdatesScheduleSettings>]`: scheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[GradualRollout <IMicrosoftGraphWindowsUpdatesGradualRolloutSettings>]`: gradualRolloutSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationBetweenOffers <TimeSpan?>]`: The duration between each set of devices being offered the update. The value is represented in ISO 8601 format for duration. Default value is P1D (1 day).
    - `[StartDateTime <DateTime?>]`: The date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[UserExperience <IMicrosoftGraphWindowsUpdatesUserExperienceSettings>]`: userExperienceSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DaysUntilForcedReboot <Int32?>]`: Specifies the number of days after an update is installed, during which the user of the device can control when the device restarts.

STATE <IMicrosoftGraphWindowsUpdatesDeploymentState>: deploymentState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EffectiveValue <String>]`: deploymentStateValue
  - `[Reasons <IMicrosoftGraphWindowsUpdatesDeploymentStateReason[]>]`: Specifies the reasons the deployment has its state value. Read-only.
    - `[Value <String>]`: deploymentStateReasonValue
  - `[RequestedValue <String>]`: requestedDeploymentStateValue

## RELATED LINKS

