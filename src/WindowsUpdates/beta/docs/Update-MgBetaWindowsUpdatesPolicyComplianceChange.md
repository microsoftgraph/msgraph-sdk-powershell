---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/update-mgbetawindowsupdatespolicycompliancechange
schema: 2.0.0
---

# Update-MgBetaWindowsUpdatesPolicyComplianceChange

## SYNOPSIS
Update the properties of a contentApproval object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaWindowsUpdatesPolicyComplianceChange -ComplianceChangeId <String> -UpdatePolicyId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Id <String>] [-IsRevoked]
 [-ResponseHeadersVariable <String>] [-RevokedDateTime <DateTime>]
 [-UpdatePolicy <IMicrosoftGraphWindowsUpdatesUpdatePolicy>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaWindowsUpdatesPolicyComplianceChange -ComplianceChangeId <String> -UpdatePolicyId <String>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesComplianceChange> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaWindowsUpdatesPolicyComplianceChange -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesComplianceChange> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaWindowsUpdatesPolicyComplianceChange -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Id <String>] [-IsRevoked]
 [-ResponseHeadersVariable <String>] [-RevokedDateTime <DateTime>]
 [-UpdatePolicy <IMicrosoftGraphWindowsUpdatesUpdatePolicy>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a contentApproval object.

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
complianceChange
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesComplianceChange
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ComplianceChangeId
The unique identifier of complianceChange

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

### -CreatedDateTime
The date and time when a compliance change was created.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsRevoked
True indicates that a compliance change is revoked, preventing further application.
Revoking a compliance change is a final action.

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

### -RevokedDateTime
The date and time when the compliance change was revoked.

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

### -UpdatePolicy
updatePolicy
To construct, see NOTES section for UPDATEPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatePolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatePolicyId
The unique identifier of updatePolicy

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesComplianceChange

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesComplianceChange

## NOTES

ALIASES

Update-MgBetaWuPolicyComplianceChange

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsUpdatesComplianceChange>`: complianceChange
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time when a compliance change was created.
  - `[IsRevoked <Boolean?>]`: True indicates that a compliance change is revoked, preventing further application. Revoking a compliance change is a final action.
  - `[RevokedDateTime <DateTime?>]`: The date and time when the compliance change was revoked.
  - `[UpdatePolicy <IMicrosoftGraphWindowsUpdatesUpdatePolicy>]`: updatePolicy
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
    - `[ComplianceChangeRules <IMicrosoftGraphWindowsUpdatesComplianceChangeRule[]>]`: Rules for governing the automatic creation of compliance changes.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the rule was created.
      - `[LastEvaluatedDateTime <DateTime?>]`: The date and time when the rule was last evaluated.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when the rule was last modified.
    - `[ComplianceChanges <IMicrosoftGraphWindowsUpdatesComplianceChange[]>]`: Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the update policy was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[DeploymentSettings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]`: deploymentSettings
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
        - `[IsReadinessTest <Boolean?>]`: True indicates that the deployment is an expedite readiness test.
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
        - `[OfferAsOptional <Boolean?>]`: Specifies whether the update is offered as Optional rather than Required.

`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

`UPDATEPOLICY <IMicrosoftGraphWindowsUpdatesUpdatePolicy>`: updatePolicy
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
  - `[ComplianceChangeRules <IMicrosoftGraphWindowsUpdatesComplianceChangeRule[]>]`: Rules for governing the automatic creation of compliance changes.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the rule was created.
    - `[LastEvaluatedDateTime <DateTime?>]`: The date and time when the rule was last evaluated.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when the rule was last modified.
  - `[ComplianceChanges <IMicrosoftGraphWindowsUpdatesComplianceChange[]>]`: Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when a compliance change was created.
    - `[IsRevoked <Boolean?>]`: True indicates that a compliance change is revoked, preventing further application. Revoking a compliance change is a final action.
    - `[RevokedDateTime <DateTime?>]`: The date and time when the compliance change was revoked.
    - `[UpdatePolicy <IMicrosoftGraphWindowsUpdatesUpdatePolicy>]`: updatePolicy
  - `[CreatedDateTime <DateTime?>]`: The date and time when the update policy was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[DeploymentSettings <IMicrosoftGraphWindowsUpdatesDeploymentSettings>]`: deploymentSettings
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
      - `[IsReadinessTest <Boolean?>]`: True indicates that the deployment is an expedite readiness test.
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
      - `[OfferAsOptional <Boolean?>]`: Specifies whether the update is offered as Optional rather than Required.

## RELATED LINKS

