---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetainformationprotection
schema: 2.0.0
---

# Update-MgBetaInformationProtection

## SYNOPSIS
Update informationProtection

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaInformationProtection [-AdditionalProperties <Hashtable>] [-Bitlocker <IMicrosoftGraphBitlocker>]
 [-DataLossPreventionPolicies <IMicrosoftGraphDataLossPreventionPolicy[]>] [-Id <String>]
 [-Policy <IMicrosoftGraphInformationProtectionPolicy>] [-ResponseHeadersVariable <String>]
 [-SensitivityLabels <IMicrosoftGraphSensitivityLabel[]>]
 [-SensitivityPolicySettings <IMicrosoftGraphSensitivityPolicySettings>]
 [-ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaInformationProtection -BodyParameter <IMicrosoftGraphInformationProtection>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update informationProtection

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Bitlocker
bitlocker
To construct, see NOTES section for BITLOCKER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBitlocker
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
informationProtection
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtection
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DataLossPreventionPolicies
.
To construct, see NOTES section for DATALOSSPREVENTIONPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDataLossPreventionPolicy[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Policy
informationProtectionPolicy
To construct, see NOTES section for POLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtectionPolicy
Parameter Sets: UpdateExpanded
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

### -SensitivityLabels
.
To construct, see NOTES section for SENSITIVITYLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensitivityPolicySettings
sensitivityPolicySettings
To construct, see NOTES section for SENSITIVITYPOLICYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityPolicySettings
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThreatAssessmentRequests
.
To construct, see NOTES section for THREATASSESSMENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtection

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BITLOCKER <IMicrosoftGraphBitlocker>`: bitlocker
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Microsoft Entra ID.
    - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
    - `[Key <String>]`: The BitLocker recovery key.
    - `[VolumeType <String>]`: volumeType

`BODYPARAMETER <IMicrosoftGraphInformationProtection>`: informationProtection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Bitlocker <IMicrosoftGraphBitlocker>]`: bitlocker
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Microsoft Entra ID.
      - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
      - `[Key <String>]`: The BitLocker recovery key.
      - `[VolumeType <String>]`: volumeType
  - `[DataLossPreventionPolicies <IMicrosoftGraphDataLossPreventionPolicy[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Name <String>]`: 
  - `[Policy <IMicrosoftGraphInformationProtectionPolicy>]`: informationProtectionPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Labels <IMicrosoftGraphInformationProtectionLabel[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Color <String>]`: The color that the UI should display for the label, if configured.
      - `[Description <String>]`: The admin-defined description for the label.
      - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.
      - `[Name <String>]`: The plaintext name of the label.
      - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Color <String>]`: The color that the user interface should display for the label, if configured.
        - `[Description <String>]`: The admin-defined description for the label.
        - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
        - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
        - `[Name <String>]`: The plaintext name of the label.
        - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
        - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
        - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.
      - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
      - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a UI.
  - `[SensitivityLabels <IMicrosoftGraphSensitivityLabel[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ApplicableTo <String>]`: sensitivityLabelTarget
    - `[ApplicationMode <String>]`: applicationMode
    - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
      - `[Id <String>]`: 
      - `[Name <String>]`: 
    - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Message <String>]`: 
      - `[SensitiveTypeIds <String[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[IsEndpointProtectionEnabled <Boolean?>]`: 
    - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
      - `[Name <String>]`: 
    - `[Name <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
    - `[ToolTip <String>]`: 
  - `[SensitivityPolicySettings <IMicrosoftGraphSensitivityPolicySettings>]`: sensitivityPolicySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ApplicableTo <String>]`: sensitivityLabelTarget
    - `[DowngradeSensitivityRequiresJustification <Boolean?>]`: 
    - `[HelpWebUrl <String>]`: 
    - `[IsMandatory <Boolean?>]`: 
  - `[ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <String>]`: threatCategory
    - `[ContentType <String>]`: threatAssessmentContentType
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ExpectedAssessment <String>]`: threatExpectedAssessment
    - `[RequestSource <String>]`: threatAssessmentRequestSource
    - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Message <String>]`: The result message for each threat assessment.
      - `[ResultType <String>]`: threatAssessmentResultType
    - `[Status <String>]`: threatAssessmentStatus

`DATALOSSPREVENTIONPOLICIES <IMicrosoftGraphDataLossPreventionPolicy[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Name <String>]`: 

`POLICY <IMicrosoftGraphInformationProtectionPolicy>`: informationProtectionPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Labels <IMicrosoftGraphInformationProtectionLabel[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Color <String>]`: The color that the UI should display for the label, if configured.
    - `[Description <String>]`: The admin-defined description for the label.
    - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.
    - `[Name <String>]`: The plaintext name of the label.
    - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Color <String>]`: The color that the user interface should display for the label, if configured.
      - `[Description <String>]`: The admin-defined description for the label.
      - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
      - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
      - `[Name <String>]`: The plaintext name of the label.
      - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
      - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
      - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.
    - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
    - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a UI.

`SENSITIVITYLABELS <IMicrosoftGraphSensitivityLabel[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[ApplicationMode <String>]`: applicationMode
  - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
  - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Message <String>]`: 
    - `[SensitiveTypeIds <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsEndpointProtectionEnabled <Boolean?>]`: 
  - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
    - `[Name <String>]`: 
  - `[Name <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
  - `[ToolTip <String>]`: 

`SENSITIVITYPOLICYSETTINGS <IMicrosoftGraphSensitivityPolicySettings>`: sensitivityPolicySettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[DowngradeSensitivityRequiresJustification <Boolean?>]`: 
  - `[HelpWebUrl <String>]`: 
  - `[IsMandatory <Boolean?>]`: 

`THREATASSESSMENTREQUESTS <IMicrosoftGraphThreatAssessmentRequest[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Category <String>]`: threatCategory
  - `[ContentType <String>]`: threatAssessmentContentType
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ExpectedAssessment <String>]`: threatExpectedAssessment
  - `[RequestSource <String>]`: threatAssessmentRequestSource
  - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Message <String>]`: The result message for each threat assessment.
    - `[ResultType <String>]`: threatAssessmentResultType
  - `[Status <String>]`: threatAssessmentStatus

## RELATED LINKS

