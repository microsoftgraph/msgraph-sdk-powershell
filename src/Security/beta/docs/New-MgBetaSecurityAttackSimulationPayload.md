---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecurityattacksimulationpayload
schema: 2.0.0
---

# New-MgBetaSecurityAttackSimulationPayload

## SYNOPSIS
Create new navigation property to payloads for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityAttackSimulationPayload [-AdditionalProperties <Hashtable>] [-Brand <String>]
 [-Complexity <String>] [-CreatedBy <IMicrosoftGraphEmailIdentity>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-Detail <IMicrosoftGraphPayloadDetail>] [-DisplayName <String>] [-Id <String>]
 [-Industry <String>] [-IsAutomated] [-IsControversial] [-IsCurrentEvent] [-Language <String>]
 [-LastModifiedBy <IMicrosoftGraphEmailIdentity>] [-LastModifiedDateTime <DateTime>] [-PayloadTags <String[]>]
 [-Platform <String>] [-PredictedCompromiseRate <Double>] [-ResponseHeadersVariable <String>]
 [-SimulationAttackType <String>] [-Source <String>] [-Status <String>] [-Technique <String>]
 [-Theme <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityAttackSimulationPayload -BodyParameter <IMicrosoftGraphPayload>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to payloads for security

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
payload
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPayload
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Brand
payloadBrand

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

### -Complexity
payloadComplexity

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
Date and time when the attack simulation and training campaign payload.
The timestamp represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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
Description of the attack simulation and training campaign payload.

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

### -Detail
payloadDetail
To construct, see NOTES section for DETAIL properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPayloadDetail
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name of the attack simulation and training campaign payload.
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Industry
payloadIndustry

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

### -IsAutomated
Indicates whether the attack simulation and training campaign payload was created from an automation flow.
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

### -IsControversial
Indicates whether the payload is controversial.

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

### -IsCurrentEvent
Indicates whether the payload is from any recent event.

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

### -Language
Payload language.

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
Date and time when the attack simulation and training campaign payload was last modified.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -PayloadTags
Free text tags for a payload.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
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

### -PredictedCompromiseRate
Predicted probability for a payload to phish a targeted user.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
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

### -SimulationAttackType
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

### -Source
simulationContentSource

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

### -Status
simulationContentStatus

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

### -Technique
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

### -Theme
payloadTheme

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPayload

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPayload

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPayload>`: payload
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Brand <String>]`: payloadBrand
  - `[Complexity <String>]`: payloadComplexity
  - `[CreatedBy <IMicrosoftGraphEmailIdentity>]`: emailIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: Email address of the user.
  - `[CreatedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload. The timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
  - `[LastModifiedDateTime <DateTime?>]`: Date and time when the attack simulation and training campaign payload was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[PayloadTags <String[]>]`: Free text tags for a payload.
  - `[Platform <String>]`: payloadDeliveryPlatform
  - `[PredictedCompromiseRate <Double?>]`: Predicted probability for a payload to phish a targeted user.
  - `[SimulationAttackType <String>]`: simulationAttackType
  - `[Source <String>]`: simulationContentSource
  - `[Status <String>]`: simulationContentStatus
  - `[Technique <String>]`: simulationAttackTechnique
  - `[Theme <String>]`: payloadTheme

`CREATEDBY <IMicrosoftGraphEmailIdentity>`: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Email <String>]`: Email address of the user.

`DETAIL <IMicrosoftGraphPayloadDetail>`: payloadDetail
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

`LASTMODIFIEDBY <IMicrosoftGraphEmailIdentity>`: emailIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Email <String>]`: Email address of the user.

## RELATED LINKS

