---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.windowsupdates/update-mgwindowsupdatesdeployment
schema: 2.0.0
---

# Update-MgBetaWindowsUpdatesDeployment

## SYNOPSIS
Update the navigation property deployments in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaWindowsUpdatesDeployment -DeploymentId <String> [-AdditionalProperties <Hashtable>]
 [-Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>] [-Content <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]
 [-State <IMicrosoftGraphWindowsUpdatesDeploymentState>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaWindowsUpdatesDeployment -DeploymentId <String>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeployment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaWindowsUpdatesDeployment -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesDeployment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaWindowsUpdatesDeployment -InputObject <IWindowsUpdatesIdentity> [-AdditionalProperties <Hashtable>]
 [-Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>] [-Content <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]
 [-State <IMicrosoftGraphWindowsUpdatesDeploymentState>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deployments in admin

## EXAMPLES

### Example 1: Using the Update-MgBetaWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.windowsUpdates.deployment"
	State = @{
		"@odata.type" = "Microsoft.Graph.Beta.windowsUpdates.deploymentState"
		RequestedValue = "paused"
	}
}
Update-MgBetaWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```

This example shows how to use the Update-MgBetaWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Update-MgBetaWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.windowsUpdates.deployment"
	Settings = @{
		"@odata.type" = "Microsoft.Graph.Beta.windowsUpdates.windowsDeploymentSettings"
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
Update-MgBetaWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```

This example shows how to use the Update-MgBetaWindowsUpdatesDeployment Cmdlet.
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentAudience
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment
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
key: id of deployment

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentSettings
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeploymentState
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesDeployment

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgBetaWuDeployment

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AUDIENCE <IMicrosoftGraphWindowsUpdatesDeploymentAudience>: deploymentAudience
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to exclude from the audience.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to include in the audience.

BODYPARAMETER <IMicrosoftGraphWindowsUpdatesDeployment>: deployment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Audience <IMicrosoftGraphWindowsUpdatesDeploymentAudience>]`: deploymentAudience
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Exclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to exclude from the audience.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Members <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: Specifies the assets to include in the audience.
  - `[Content <IMicrosoftGraphWindowsUpdatesDeployableContent>]`: deployableContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: The date and time the deployment was created. Returned by default. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the deployment was last modified. Returned by default. Read-only.
  - `[Settings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]`: deploymentSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or'.
        - `[Action <String>]`: monitoringAction
        - `[Signal <String>]`: monitoringSignal
        - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).
    - `[Rollout <IMicrosoftGraphWindowsUpdatesRolloutSettings>]`: rolloutSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DevicesPerOffer <Int32?>]`: Specifies the number of devices that are offered at the same time. Has no effect when endDateTime is set. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
      - `[DurationBetweenOffers <String>]`: Specifies duration between each set of devices being offered the update. Has an effect when endDateTime or devicesPerOffer are defined. Default value is P1D (1 day).
      - `[EndDateTime <DateTime?>]`: Specifies the date before which all devices currently in the deployment are offered the update. Devices added after this date are offered immediately. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
      - `[StartDateTime <DateTime?>]`: Date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned.
    - `[Safeguard <IMicrosoftGraphWindowsUpdatesSafeguardSettings>]`: safeguardSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisabledSafeguardProfiles <IMicrosoftGraphWindowsUpdatesSafeguardProfile[]>]`: List of safeguards to ignore per device.
        - `[Category <String>]`: safeguardCategory
  - `[State <IMicrosoftGraphWindowsUpdatesDeploymentState>]`: deploymentState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reasons <IMicrosoftGraphWindowsUpdatesDeploymentStateReason[]>]`: Specifies the reasons the deployment has its state value. Read-only.
      - `[Value <String>]`: deploymentStateReasonValue
    - `[RequestedValue <String>]`: requestedDeploymentStateValue
    - `[Value <String>]`: deploymentStateValue

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[ResourceConnectionId <String>]`: key: id of resourceConnection
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

SETTINGS <IMicrosoftGraphWindowsUpdatesDeploymentSettings>: deploymentSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Monitoring <IMicrosoftGraphWindowsUpdatesMonitoringSettings>]`: monitoringSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MonitoringRules <IMicrosoftGraphWindowsUpdatesMonitoringRule[]>]`: Specifies the rules through which monitoring signals can trigger actions on the deployment. Rules are combined using 'or'.
      - `[Action <String>]`: monitoringAction
      - `[Signal <String>]`: monitoringSignal
      - `[Threshold <Int32?>]`: The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).
  - `[Rollout <IMicrosoftGraphWindowsUpdatesRolloutSettings>]`: rolloutSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DevicesPerOffer <Int32?>]`: Specifies the number of devices that are offered at the same time. Has no effect when endDateTime is set. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
    - `[DurationBetweenOffers <String>]`: Specifies duration between each set of devices being offered the update. Has an effect when endDateTime or devicesPerOffer are defined. Default value is P1D (1 day).
    - `[EndDateTime <DateTime?>]`: Specifies the date before which all devices currently in the deployment are offered the update. Devices added after this date are offered immediately. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
    - `[StartDateTime <DateTime?>]`: Date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned.
  - `[Safeguard <IMicrosoftGraphWindowsUpdatesSafeguardSettings>]`: safeguardSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisabledSafeguardProfiles <IMicrosoftGraphWindowsUpdatesSafeguardProfile[]>]`: List of safeguards to ignore per device.
      - `[Category <String>]`: safeguardCategory

STATE <IMicrosoftGraphWindowsUpdatesDeploymentState>: deploymentState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Reasons <IMicrosoftGraphWindowsUpdatesDeploymentStateReason[]>]`: Specifies the reasons the deployment has its state value. Read-only.
    - `[Value <String>]`: deploymentStateReasonValue
  - `[RequestedValue <String>]`: requestedDeploymentStateValue
  - `[Value <String>]`: deploymentStateValue

## RELATED LINKS

