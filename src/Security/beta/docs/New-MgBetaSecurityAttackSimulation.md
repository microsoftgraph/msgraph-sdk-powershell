---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecurityattacksimulation
schema: 2.0.0
---

# New-MgBetaSecurityAttackSimulation

## SYNOPSIS
Create an attack simulation campaign for a tenant.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityAttackSimulation [-AdditionalProperties <Hashtable>] [-AttackTechnique <String>]
 [-AttackType <String>] [-AutomationId <String>] [-CompletionDateTime <DateTime>]
 [-CreatedBy <IMicrosoftGraphEmailIdentity>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>]
 [-EndUserNotificationSetting <IMicrosoftGraphEndUserNotificationSetting>]
 [-ExcludedAccountTarget <IMicrosoftGraphAccountTargetContent>] [-Id <String>]
 [-IncludedAccountTarget <IMicrosoftGraphAccountTargetContent>] [-IsAutomated]
 [-LandingPage <IMicrosoftGraphLandingPage>] [-LastModifiedBy <IMicrosoftGraphEmailIdentity>]
 [-LastModifiedDateTime <DateTime>] [-LaunchDateTime <DateTime>] [-LoginPage <IMicrosoftGraphLoginPage>]
 [-OAuthConsentAppDetail <IMicrosoftGraphOAuthConsentAppDetail>] [-Payload <IMicrosoftGraphPayload>]
 [-PayloadDeliveryPlatform <String>] [-Report <IMicrosoftGraphSimulationReport>] [-Status <String>]
 [-TrainingSetting <IMicrosoftGraphTrainingSetting>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityAttackSimulation -BodyParameter <IMicrosoftGraphSimulation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create an attack simulation campaign for a tenant.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -AttackTechnique
simulationAttackTechnique

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

### -AttackType
simulationAttackType

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

### -AutomationId
Unique identifier for the attack simulation automation.

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

### -BodyParameter
simulation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSimulation
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompletionDateTime
Date and time of completion of the attack simulation and training campaign.
Supports $filter and $orderby.

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

### -CreatedBy
emailIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEmailIdentity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of creation of the attack simulation and training campaign.

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

### -Description
Description of the attack simulation and training campaign.

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

### -DisplayName
Display name of the attack simulation and training campaign.
Supports $filter and $orderby.

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

### -DurationInDays
Simulation duration in days.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndUserNotificationSetting
endUserNotificationSetting
To construct, see NOTES section for ENDUSERNOTIFICATIONSETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEndUserNotificationSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludedAccountTarget
accountTargetContent
To construct, see NOTES section for EXCLUDEDACCOUNTTARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccountTargetContent
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

### -IncludedAccountTarget
accountTargetContent
To construct, see NOTES section for INCLUDEDACCOUNTTARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccountTargetContent
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAutomated
Flag that represents if the attack simulation and training campaign was created from a simulation automation flow.
Supports $filter and $orderby.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LandingPage
landingPage
To construct, see NOTES section for LANDINGPAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLandingPage
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
emailIdentity
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEmailIdentity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Date and time of the most recent modification of the attack simulation and training campaign.

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

### -LaunchDateTime
Date and time of the launch/start of the attack simulation and training campaign.
Supports $filter and $orderby.

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

### -LoginPage
loginPage
To construct, see NOTES section for LOGINPAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLoginPage
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OAuthConsentAppDetail
oAuthConsentAppDetail
To construct, see NOTES section for OAUTHCONSENTAPPDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOAuthConsentAppDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Payload
payload
To construct, see NOTES section for PAYLOAD properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPayload
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PayloadDeliveryPlatform
payloadDeliveryPlatform

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

### -Report
simulationReport
To construct, see NOTES section for REPORT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSimulationReport
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
simulationStatus

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

### -TrainingSetting
trainingSetting
To construct, see NOTES section for TRAININGSETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTrainingSetting
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSimulation

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSimulation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSimulation>`: simulation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AttackTechnique <String>]`: simulationAttackTechnique
  - `[AttackType <String>]`: simulationAttackType
  - `[AutomationId <String>]`: Unique identifier for the attack simulation automation.
  - `[CompletionDateTime <DateTime?>]`: Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: Date and time of creation of the attack simulation and training campaign.
  - `[Description <String>]`: Description of the attack simulation and training campaign.
  - `[DisplayName <String>]`: Display name of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[DurationInDays <Int32?>]`: Simulation duration in days.
  - `[EndUserNotificationSetting <IMicrosoftGraphEndUserNotificationSetting>]`: endUserNotificationSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NotificationPreference <String>]`: endUserNotificationPreference
    - `[PositiveReinforcement <IMicrosoftGraphPositiveReinforcementNotification>]`: positiveReinforcementNotification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultLanguage <String>]`: 
      - `[EndUserNotification <IMicrosoftGraphEndUserNotification>]`: endUserNotification
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[Details <IMicrosoftGraphEndUserNotificationDetail[]>]`: 
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[EmailContent <String>]`: 
          - `[IsDefaultLangauge <Boolean?>]`: 
          - `[Language <String>]`: 
          - `[Locale <String>]`: 
          - `[SentFrom <IMicrosoftGraphEmailIdentity>]`: emailIdentity
          - `[Subject <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[NotificationType <String>]`: endUserNotificationType
        - `[Source <String>]`: simulationContentSource
        - `[Status <String>]`: simulationContentStatus
        - `[SupportedLocales <String[]>]`: 
      - `[DeliveryPreference <String>]`: notificationDeliveryPreference
    - `[SettingType <String>]`: endUserNotificationSettingType
  - `[ExcludedAccountTarget <IMicrosoftGraphAccountTargetContent>]`: accountTargetContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: accountTargetContentType
  - `[IncludedAccountTarget <IMicrosoftGraphAccountTargetContent>]`: accountTargetContent
  - `[IsAutomated <Boolean?>]`: Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.
  - `[LandingPage <IMicrosoftGraphLandingPage>]`: landingPage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[Details <IMicrosoftGraphLandingPageDetail[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Content <String>]`: 
      - `[IsDefaultLangauge <Boolean?>]`: 
      - `[Language <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Locale <String>]`: 
    - `[Source <String>]`: simulationContentSource
    - `[Status <String>]`: simulationContentStatus
    - `[SupportedLocales <String[]>]`: 
  - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
  - `[LastModifiedDateTime <DateTime?>]`: Date and time of the most recent modification of the attack simulation and training campaign.
  - `[LaunchDateTime <DateTime?>]`: Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[LoginPage <IMicrosoftGraphLoginPage>]`: loginPage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <String>]`: 
    - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Language <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <String>]`: simulationContentSource
    - `[Status <String>]`: simulationContentStatus
  - `[OAuthConsentAppDetail <IMicrosoftGraphOAuthConsentAppDetail>]`: oAuthConsentAppDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AppScope <String>]`: oAuthAppScope
    - `[DisplayLogo <String>]`: 
    - `[DisplayName <String>]`: 
  - `[Payload <IMicrosoftGraphPayload>]`: payload
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Brand <String>]`: payloadBrand
    - `[Complexity <String>]`: payloadComplexity
    - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[CreatedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload.
    - `[Description <String>]`: Description of the attack simulation and training campaign payload.
    - `[Detail <IMicrosoftGraphPayloadDetail>]`: payloadDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Coachmarks <IMicrosoftGraphPayloadCoachmark[]>]`: Payload coachmark details.
        - `[CoachmarkLocation <IMicrosoftGraphCoachmarkLocation>]`: coachmarkLocation
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Length <Int32?>]`: Length of coachmark.
          - `[Offset <Int32?>]`: Offset of coachmark.
          - `[Type <String>]`: coachmarkLocationType
        - `[Description <String>]`: The description about the coachmark.
        - `[Indicator <String>]`: The coachmark indicator.
        - `[IsValid <Boolean?>]`: Indicates whether the coachmark is valid or not.
        - `[Language <String>]`: The coachmark language.
        - `[Order <String>]`: The coachmark order.
      - `[Content <String>]`: Payload content details.
      - `[PhishingUrl <String>]`: The phishing URL used to target a user.
    - `[DisplayName <String>]`: Display name of the attack simulation and training campaign payload. Supports $filter and $orderby.
    - `[Industry <String>]`: payloadIndustry
    - `[IsAutomated <Boolean?>]`: Indicates whether the attack simulation and training campaign payload was created from an automation flow. Supports $filter and $orderby.
    - `[IsControversial <Boolean?>]`: Indicates whether the payload is controversial.
    - `[IsCurrentEvent <Boolean?>]`: Indicates whether the payload is from any recent event.
    - `[Language <String>]`: Payload language.
    - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[LastModifiedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[PayloadTags <String[]>]`: Free text tags for a payload.
    - `[Platform <String>]`: payloadDeliveryPlatform
    - `[PredictedCompromiseRate <Double?>]`: Predicted probability for a payload to phish a targeted user.
    - `[SimulationAttackType <String>]`: simulationAttackType
    - `[Source <String>]`: simulationContentSource
    - `[Status <String>]`: simulationContentStatus
    - `[Technique <String>]`: simulationAttackTechnique
    - `[Theme <String>]`: payloadTheme
  - `[PayloadDeliveryPlatform <String>]`: payloadDeliveryPlatform
  - `[Report <IMicrosoftGraphSimulationReport>]`: simulationReport
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Overview <IMicrosoftGraphSimulationReportOverview>]`: simulationReportOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RecommendedActions <IMicrosoftGraphRecommendedAction[]>]`: List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.
        - `[ActionWebUrl <String>]`: Web URL to the recommended action.
        - `[PotentialScoreImpact <Double?>]`: Potential improvement in the tenant security score from the recommended action.
        - `[Title <String>]`: Title of the recommended action.
      - `[ResolvedTargetsCount <Int32?>]`: Number of valid users in the attack simulation and training campaign.
      - `[SimulationEventsContent <IMicrosoftGraphSimulationEventsContent>]`: simulationEventsContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CompromisedRate <Double?>]`: Actual percentage of users who fell for the simulated attack in an attack simulation and training campaign.
        - `[Events <IMicrosoftGraphSimulationEvent[]>]`: List of simulation events in an attack simulation and training campaign.
          - `[Count <Int32?>]`: Count of the simulation event occurrence in an attack simulation and training campaign.
          - `[EventName <String>]`: Name of the simulation event in an attack simulation and training campaign.
      - `[TrainingEventsContent <IMicrosoftGraphTrainingEventsContent>]`: trainingEventsContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AssignedTrainingsInfos <IMicrosoftGraphAssignedTrainingInfo[]>]`: List of assigned trainings and their information in an attack simulation and training campaign.
          - `[AssignedUserCount <Int32?>]`: Number of users who were assigned the training in an attack simulation and training campaign.
          - `[CompletedUserCount <Int32?>]`: Number of users who completed the training in an attack simulation and training campaign.
          - `[DisplayName <String>]`: Display name of the training in an attack simulation and training campaign.
        - `[TrainingsAssignedUserCount <Int32?>]`: Number of users who were assigned trainings in an attack simulation and training campaign.
    - `[SimulationUsers <IMicrosoftGraphUserSimulationDetails[]>]`: The tenant users and their online actions in an attack simulation and training campaign.
      - `[AssignedTrainingsCount <Int32?>]`: Number of trainings assigned to a user in an attack simulation and training campaign.
      - `[CompletedTrainingsCount <Int32?>]`: Number of trainings completed by a user in an attack simulation and training campaign.
      - `[CompromisedDateTime <DateTime?>]`: Date and time of the compromising online action by a user in an attack simulation and training campaign.
      - `[InProgressTrainingsCount <Int32?>]`: Number of trainings in progress by a user in an attack simulation and training campaign.
      - `[IsCompromised <Boolean?>]`: Indicates whether a user was compromised in an attack simulation and training campaign.
      - `[LatestSimulationActivity <String>]`: Indicates latest user activity.
      - `[ReportedPhishDateTime <DateTime?>]`: Date and time when a user reported the delivered payload as phishing in the attack simulation and training campaign.
      - `[SimulationEvents <IMicrosoftGraphUserSimulationEventInfo[]>]`: List of simulation events of a user in the attack simulation and training campaign.
        - `[Browser <String>]`: Browser information from where the simulation event was initiated by a user in an attack simulation and training campaign.
        - `[EventDateTime <DateTime?>]`: Date and time of the simulation event by a user in an attack simulation and training campaign.
        - `[EventName <String>]`: Name of the simulation event by a user in an attack simulation and training campaign.
        - `[IPAddress <String>]`: IP address from where the simulation event was initiated by a user in an attack simulation and training campaign.
        - `[OSPlatformDeviceDetails <String>]`: The operating system, platform, and device details from where the simulation event was initiated by a user in an attack simulation and training campaign.
      - `[SimulationUser <IMicrosoftGraphAttackSimulationUser>]`: attackSimulationUser
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Display name of the user.
        - `[Email <String>]`: Email address of the user.
        - `[OutOfOfficeDays <Int32?>]`: Number of days the user is OOF during a simulation journey/course of a campaign.
        - `[UserId <String>]`: The id property value of the user resource that represents the user in the Azure Active Directory tenant.
      - `[TrainingEvents <IMicrosoftGraphUserTrainingEventInfo[]>]`: List of training events of a user in the attack simulation and training campaign.
        - `[DisplayName <String>]`: Display name of the training.
        - `[LatestTrainingStatus <String>]`: trainingStatus
        - `[TrainingAssignedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Browser <String>]`: Browser of the user from where the training event was generated.
          - `[ContentDateTime <DateTime?>]`: Date and time of the training content playback by the user.
          - `[IPAddress <String>]`: IP address of the user for the training event.
          - `[OSPlatformDeviceDetails <String>]`: The operating system, platform, and device details of the user for the training event.
          - `[PotentialScoreImpact <Double?>]`: Potential improvement in the tenant security posture after completion of the training by the user.
        - `[TrainingCompletedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo
        - `[TrainingUpdatedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo
  - `[Status <String>]`: simulationStatus
  - `[TrainingSetting <IMicrosoftGraphTrainingSetting>]`: trainingSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SettingType <String>]`: trainingSettingType

`CREATEDBY <IMicrosoftGraphEmailIdentity>`: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Email <String>]`: Email address of the user.

`ENDUSERNOTIFICATIONSETTING <IMicrosoftGraphEndUserNotificationSetting>`: endUserNotificationSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[NotificationPreference <String>]`: endUserNotificationPreference
  - `[PositiveReinforcement <IMicrosoftGraphPositiveReinforcementNotification>]`: positiveReinforcementNotification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultLanguage <String>]`: 
    - `[EndUserNotification <IMicrosoftGraphEndUserNotification>]`: endUserNotification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
        - `[Email <String>]`: Email address of the user.
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[Details <IMicrosoftGraphEndUserNotificationDetail[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[EmailContent <String>]`: 
        - `[IsDefaultLangauge <Boolean?>]`: 
        - `[Language <String>]`: 
        - `[Locale <String>]`: 
        - `[SentFrom <IMicrosoftGraphEmailIdentity>]`: emailIdentity
        - `[Subject <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[NotificationType <String>]`: endUserNotificationType
      - `[Source <String>]`: simulationContentSource
      - `[Status <String>]`: simulationContentStatus
      - `[SupportedLocales <String[]>]`: 
    - `[DeliveryPreference <String>]`: notificationDeliveryPreference
  - `[SettingType <String>]`: endUserNotificationSettingType

`EXCLUDEDACCOUNTTARGET <IMicrosoftGraphAccountTargetContent>`: accountTargetContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: accountTargetContentType

`INCLUDEDACCOUNTTARGET <IMicrosoftGraphAccountTargetContent>`: accountTargetContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: accountTargetContentType

`LANDINGPAGE <IMicrosoftGraphLandingPage>`: landingPage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[Details <IMicrosoftGraphLandingPageDetail[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <String>]`: 
    - `[IsDefaultLangauge <Boolean?>]`: 
    - `[Language <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Locale <String>]`: 
  - `[Source <String>]`: simulationContentSource
  - `[Status <String>]`: simulationContentStatus
  - `[SupportedLocales <String[]>]`: 

`LASTMODIFIEDBY <IMicrosoftGraphEmailIdentity>`: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Email <String>]`: Email address of the user.

`LOGINPAGE <IMicrosoftGraphLoginPage>`: loginPage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Content <String>]`: 
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Language <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <String>]`: simulationContentSource
  - `[Status <String>]`: simulationContentStatus

`OAUTHCONSENTAPPDETAIL <IMicrosoftGraphOAuthConsentAppDetail>`: oAuthConsentAppDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppScope <String>]`: oAuthAppScope
  - `[DisplayLogo <String>]`: 
  - `[DisplayName <String>]`: 

`PAYLOAD <IMicrosoftGraphPayload>`: payload
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Brand <String>]`: payloadBrand
  - `[Complexity <String>]`: payloadComplexity
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload.
  - `[Description <String>]`: Description of the attack simulation and training campaign payload.
  - `[Detail <IMicrosoftGraphPayloadDetail>]`: payloadDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Coachmarks <IMicrosoftGraphPayloadCoachmark[]>]`: Payload coachmark details.
      - `[CoachmarkLocation <IMicrosoftGraphCoachmarkLocation>]`: coachmarkLocation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Length <Int32?>]`: Length of coachmark.
        - `[Offset <Int32?>]`: Offset of coachmark.
        - `[Type <String>]`: coachmarkLocationType
      - `[Description <String>]`: The description about the coachmark.
      - `[Indicator <String>]`: The coachmark indicator.
      - `[IsValid <Boolean?>]`: Indicates whether the coachmark is valid or not.
      - `[Language <String>]`: The coachmark language.
      - `[Order <String>]`: The coachmark order.
    - `[Content <String>]`: Payload content details.
    - `[PhishingUrl <String>]`: The phishing URL used to target a user.
  - `[DisplayName <String>]`: Display name of the attack simulation and training campaign payload. Supports $filter and $orderby.
  - `[Industry <String>]`: payloadIndustry
  - `[IsAutomated <Boolean?>]`: Indicates whether the attack simulation and training campaign payload was created from an automation flow. Supports $filter and $orderby.
  - `[IsControversial <Boolean?>]`: Indicates whether the payload is controversial.
  - `[IsCurrentEvent <Boolean?>]`: Indicates whether the payload is from any recent event.
  - `[Language <String>]`: Payload language.
  - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
  - `[LastModifiedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[PayloadTags <String[]>]`: Free text tags for a payload.
  - `[Platform <String>]`: payloadDeliveryPlatform
  - `[PredictedCompromiseRate <Double?>]`: Predicted probability for a payload to phish a targeted user.
  - `[SimulationAttackType <String>]`: simulationAttackType
  - `[Source <String>]`: simulationContentSource
  - `[Status <String>]`: simulationContentStatus
  - `[Technique <String>]`: simulationAttackTechnique
  - `[Theme <String>]`: payloadTheme

`REPORT <IMicrosoftGraphSimulationReport>`: simulationReport
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Overview <IMicrosoftGraphSimulationReportOverview>]`: simulationReportOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RecommendedActions <IMicrosoftGraphRecommendedAction[]>]`: List of recommended actions for a tenant to improve its security posture based on the attack simulation and training campaign attack type.
      - `[ActionWebUrl <String>]`: Web URL to the recommended action.
      - `[PotentialScoreImpact <Double?>]`: Potential improvement in the tenant security score from the recommended action.
      - `[Title <String>]`: Title of the recommended action.
    - `[ResolvedTargetsCount <Int32?>]`: Number of valid users in the attack simulation and training campaign.
    - `[SimulationEventsContent <IMicrosoftGraphSimulationEventsContent>]`: simulationEventsContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompromisedRate <Double?>]`: Actual percentage of users who fell for the simulated attack in an attack simulation and training campaign.
      - `[Events <IMicrosoftGraphSimulationEvent[]>]`: List of simulation events in an attack simulation and training campaign.
        - `[Count <Int32?>]`: Count of the simulation event occurrence in an attack simulation and training campaign.
        - `[EventName <String>]`: Name of the simulation event in an attack simulation and training campaign.
    - `[TrainingEventsContent <IMicrosoftGraphTrainingEventsContent>]`: trainingEventsContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedTrainingsInfos <IMicrosoftGraphAssignedTrainingInfo[]>]`: List of assigned trainings and their information in an attack simulation and training campaign.
        - `[AssignedUserCount <Int32?>]`: Number of users who were assigned the training in an attack simulation and training campaign.
        - `[CompletedUserCount <Int32?>]`: Number of users who completed the training in an attack simulation and training campaign.
        - `[DisplayName <String>]`: Display name of the training in an attack simulation and training campaign.
      - `[TrainingsAssignedUserCount <Int32?>]`: Number of users who were assigned trainings in an attack simulation and training campaign.
  - `[SimulationUsers <IMicrosoftGraphUserSimulationDetails[]>]`: The tenant users and their online actions in an attack simulation and training campaign.
    - `[AssignedTrainingsCount <Int32?>]`: Number of trainings assigned to a user in an attack simulation and training campaign.
    - `[CompletedTrainingsCount <Int32?>]`: Number of trainings completed by a user in an attack simulation and training campaign.
    - `[CompromisedDateTime <DateTime?>]`: Date and time of the compromising online action by a user in an attack simulation and training campaign.
    - `[InProgressTrainingsCount <Int32?>]`: Number of trainings in progress by a user in an attack simulation and training campaign.
    - `[IsCompromised <Boolean?>]`: Indicates whether a user was compromised in an attack simulation and training campaign.
    - `[LatestSimulationActivity <String>]`: Indicates latest user activity.
    - `[ReportedPhishDateTime <DateTime?>]`: Date and time when a user reported the delivered payload as phishing in the attack simulation and training campaign.
    - `[SimulationEvents <IMicrosoftGraphUserSimulationEventInfo[]>]`: List of simulation events of a user in the attack simulation and training campaign.
      - `[Browser <String>]`: Browser information from where the simulation event was initiated by a user in an attack simulation and training campaign.
      - `[EventDateTime <DateTime?>]`: Date and time of the simulation event by a user in an attack simulation and training campaign.
      - `[EventName <String>]`: Name of the simulation event by a user in an attack simulation and training campaign.
      - `[IPAddress <String>]`: IP address from where the simulation event was initiated by a user in an attack simulation and training campaign.
      - `[OSPlatformDeviceDetails <String>]`: The operating system, platform, and device details from where the simulation event was initiated by a user in an attack simulation and training campaign.
    - `[SimulationUser <IMicrosoftGraphAttackSimulationUser>]`: attackSimulationUser
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Display name of the user.
      - `[Email <String>]`: Email address of the user.
      - `[OutOfOfficeDays <Int32?>]`: Number of days the user is OOF during a simulation journey/course of a campaign.
      - `[UserId <String>]`: The id property value of the user resource that represents the user in the Azure Active Directory tenant.
    - `[TrainingEvents <IMicrosoftGraphUserTrainingEventInfo[]>]`: List of training events of a user in the attack simulation and training campaign.
      - `[DisplayName <String>]`: Display name of the training.
      - `[LatestTrainingStatus <String>]`: trainingStatus
      - `[TrainingAssignedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Browser <String>]`: Browser of the user from where the training event was generated.
        - `[ContentDateTime <DateTime?>]`: Date and time of the training content playback by the user.
        - `[IPAddress <String>]`: IP address of the user for the training event.
        - `[OSPlatformDeviceDetails <String>]`: The operating system, platform, and device details of the user for the training event.
        - `[PotentialScoreImpact <Double?>]`: Potential improvement in the tenant security posture after completion of the training by the user.
      - `[TrainingCompletedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo
      - `[TrainingUpdatedProperties <IMicrosoftGraphUserTrainingContentEventInfo>]`: userTrainingContentEventInfo

`TRAININGSETTING <IMicrosoftGraphTrainingSetting>`: trainingSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SettingType <String>]`: trainingSettingType

## RELATED LINKS

