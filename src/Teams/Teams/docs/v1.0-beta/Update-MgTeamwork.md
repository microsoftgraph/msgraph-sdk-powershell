---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/update-mgteamwork
schema: 2.0.0
---

# Update-MgTeamwork

## SYNOPSIS
Update teamwork

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamwork [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-WorkforceIntegrations <IMicrosoftGraphWorkforceIntegration[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgTeamwork -BodyParameter <IMicrosoftGraphTeamwork> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update teamwork

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamwork
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamwork
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkforceIntegrations
.
To construct, see NOTES section for WORKFORCEINTEGRATIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphWorkforceIntegration[]
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamwork
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTeamwork>: teamwork
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[WorkforceIntegrations <IMicrosoftGraphWorkforceIntegration[]>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: Read-only.
    - `[ApiVersion <Int32?>]`: API version for the call back URL. Start with 1.
    - `[DisplayName <String>]`: Name of the workforce integration.
    - `[EligibilityFilteringEnabledEntities <String>]`: eligibilityFilteringEnabledEntities
    - `[Encryption <IMicrosoftGraphWorkforceIntegrationEncryption>]`: workforceIntegrationEncryption
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Protocol <String>]`: workforceIntegrationEncryptionProtocol
      - `[Secret <String>]`: Encryption shared secret.
    - `[IsActive <Boolean?>]`: Indicates whether this workforce integration is currently active and available.
    - `[SupportedEntities <String>]`: 
    - `[Supports <String>]`: 
    - `[Url <String>]`: Workforce Integration URL for callbacks from the Shifts service.

WORKFORCEINTEGRATIONS <IMicrosoftGraphWorkforceIntegration[]>: .
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[ApiVersion <Int32?>]`: API version for the call back URL. Start with 1.
  - `[DisplayName <String>]`: Name of the workforce integration.
  - `[EligibilityFilteringEnabledEntities <String>]`: eligibilityFilteringEnabledEntities
  - `[Encryption <IMicrosoftGraphWorkforceIntegrationEncryption>]`: workforceIntegrationEncryption
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Protocol <String>]`: workforceIntegrationEncryptionProtocol
    - `[Secret <String>]`: Encryption shared secret.
  - `[IsActive <Boolean?>]`: Indicates whether this workforce integration is currently active and available.
  - `[SupportedEntities <String>]`: 
  - `[Supports <String>]`: 
  - `[Url <String>]`: Workforce Integration URL for callbacks from the Shifts service.

## RELATED LINKS
