---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mginformationprotection
schema: 2.0.0
---

# Update-MgInformationProtection

## SYNOPSIS
Update informationProtection

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgInformationProtection [-AdditionalProperties <Hashtable>] [-Bitlocker <IMicrosoftGraphBitlocker>]
 [-Id <String>] [-ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgInformationProtection -BodyParameter <IMicrosoftGraphInformationProtection1> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update informationProtection

## EXAMPLES

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
To construct, please use Get-Help -Online and see NOTES section for BITLOCKER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBitlocker
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtection1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

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

### -ThreatAssessmentRequests
.
To construct, please use Get-Help -Online and see NOTES section for THREATASSESSMENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtection1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BITLOCKER <IMicrosoftGraphBitlocker>: bitlocker
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory.
    - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
    - `[Key <String>]`: The BitLocker recovery key.
    - `[VolumeType <String>]`: volumeType

BODYPARAMETER <IMicrosoftGraphInformationProtection1>: informationProtection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Bitlocker <IMicrosoftGraphBitlocker>]`: bitlocker
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory.
      - `[DeviceId <String>]`: ID of the device the BitLocker key is originally backed up from.
      - `[Key <String>]`: The BitLocker recovery key.
      - `[VolumeType <String>]`: volumeType
  - `[ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>]`: 
    - `[Id <String>]`: 
    - `[Category <String>]`: threatCategory
    - `[ContentType <String>]`: threatAssessmentContentType
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ExpectedAssessment <String>]`: threatExpectedAssessment
    - `[RequestSource <String>]`: threatAssessmentRequestSource
    - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
      - `[Id <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Message <String>]`: The result message for each threat assessment.
      - `[ResultType <String>]`: threatAssessmentResultType
    - `[Status <String>]`: threatAssessmentStatus

THREATASSESSMENTREQUESTS <IMicrosoftGraphThreatAssessmentRequest[]>: .
  - `[Id <String>]`: 
  - `[Category <String>]`: threatCategory
  - `[ContentType <String>]`: threatAssessmentContentType
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ExpectedAssessment <String>]`: threatExpectedAssessment
  - `[RequestSource <String>]`: threatAssessmentRequestSource
  - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Message <String>]`: The result message for each threat assessment.
    - `[ResultType <String>]`: threatAssessmentResultType
  - `[Status <String>]`: threatAssessmentStatus

## RELATED LINKS

