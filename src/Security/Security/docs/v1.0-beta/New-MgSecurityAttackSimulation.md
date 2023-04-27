---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityattacksimulation
schema: 2.0.0
---

# New-MgSecurityAttackSimulation

## SYNOPSIS
Create new navigation property to simulations for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityAttackSimulation [-AdditionalProperties <Hashtable>] [-AttackTechnique <String>]
 [-AttackType <String>] [-AutomationId <String>] [-CompletionDateTime <DateTime>]
 [-CreatedBy <IMicrosoftGraphEmailIdentity>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>]
 [-ExcludedAccountTarget <IMicrosoftGraphAccountTargetContent>] [-Id <String>]
 [-IncludedAccountTarget <IMicrosoftGraphAccountTargetContent>] [-IsAutomated]
 [-LastModifiedBy <IMicrosoftGraphEmailIdentity>] [-LastModifiedDateTime <DateTime>]
 [-LaunchDateTime <DateTime>] [-Payload <IMicrosoftGraphPayload>] [-PayloadDeliveryPlatform <String>]
 [-Report <IMicrosoftGraphSimulationReport>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSecurityAttackSimulation -BodyParameter <IMicrosoftGraphSimulation1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to simulations for security

## EXAMPLES

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSimulation1
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
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailIdentity
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

### -ExcludedAccountTarget
accountTargetContent
To construct, please use Get-Help -Online and see NOTES section for EXCLUDEDACCOUNTTARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccountTargetContent
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INCLUDEDACCOUNTTARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccountTargetContent
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

### -LastModifiedBy
emailIdentity
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailIdentity
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

### -Payload
payload
To construct, please use Get-Help -Online and see NOTES section for PAYLOAD properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPayload
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
To construct, please use Get-Help -Online and see NOTES section for REPORT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSimulationReport
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSimulation1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSimulation1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSimulation1>: simulation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AttackTechnique <String>]`: simulationAttackTechnique
  - `[AttackType <String>]`: simulationAttackType
  - `[AutomationId <String>]`: Unique identifier for the attack simulation automation.
  - `[CompletionDateTime <DateTime?>]`: Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: Date and time of creation of the attack simulation and training campaign.
  - `[Description <String>]`: Description of the attack simulation and training campaign.
  - `[DisplayName <String>]`: Display name of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[DurationInDays <Int32?>]`: Simulation duration in days.
  - `[ExcludedAccountTarget <IMicrosoftGraphAccountTargetContent>]`: accountTargetContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: accountTargetContentType
  - `[IncludedAccountTarget <IMicrosoftGraphAccountTargetContent>]`: accountTargetContent
  - `[IsAutomated <Boolean?>]`: Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.
  - `[LastModifiedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
  - `[LastModifiedDateTime <DateTime?>]`: Date and time of the most recent modification of the attack simulation and training campaign.
  - `[LaunchDateTime <DateTime?>]`: Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.
  - `[Payload <IMicrosoftGraphPayload>]`: payload
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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
        - `[UserId <String>]`: This is the id property value of the user resource that represents the user in the Azure Active Directory tenant.
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

CREATEDBY <IMicrosoftGraphEmailIdentity>: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[Email <String>]`: Email address of the user.

EXCLUDEDACCOUNTTARGET <IMicrosoftGraphAccountTargetContent>: accountTargetContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: accountTargetContentType

INCLUDEDACCOUNTTARGET <IMicrosoftGraphAccountTargetContent>: accountTargetContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: accountTargetContentType

LASTMODIFIEDBY <IMicrosoftGraphEmailIdentity>: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity.
  - `[Email <String>]`: Email address of the user.

PAYLOAD <IMicrosoftGraphPayload>: payload
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Brand <String>]`: payloadBrand
  - `[Complexity <String>]`: payloadComplexity
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
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

REPORT <IMicrosoftGraphSimulationReport>: simulationReport
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
      - `[UserId <String>]`: This is the id property value of the user resource that represents the user in the Azure Active Directory tenant.
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

## RELATED LINKS

