---
external help file: Microsoft.Graph.People-help.xml
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileaward
schema: 2.0.0
---

# Update-MgUserProfileAward

## SYNOPSIS
Update the navigation property awards in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserProfileAward -PersonAwardId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AllowedAudiences <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-Inference <IMicrosoftGraphInferenceData>]
 [-IssuedDate <DateTime>] [-IssuingAuthority <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Source <IMicrosoftGraphPersonDataSources>] [-ThumbnailUrl <String>]
 [-WebUrl <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgUserProfileAward -PersonAwardId <String> -UserId <String> -BodyParameter <IMicrosoftGraphPersonAward>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserProfileAward -InputObject <IPeopleIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedAudiences <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-Inference <IMicrosoftGraphInferenceData>]
 [-IssuedDate <DateTime>] [-IssuingAuthority <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Source <IMicrosoftGraphPersonDataSources>] [-ThumbnailUrl <String>]
 [-WebUrl <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserProfileAward -InputObject <IPeopleIdentity> -BodyParameter <IMicrosoftGraphPersonAward>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property awards in users

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedAudiences
allowedAudiences

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
personAward
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPersonAward
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Inference
inferenceData
To construct, see NOTES section for INFERENCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphInferenceData
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
Type: IPeopleIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IssuedDate
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IssuingAuthority
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: DateTime
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonAwardId
key: id of personAward

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
personDataSources
To construct, see NOTES section for SOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphPersonDataSources
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThumbnailUrl
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
.

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonAward
### Microsoft.Graph.PowerShell.Models.IPeopleIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPersonAward\>: personAward
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AllowedAudiences \<String\>\]: allowedAudiences
  \[CreatedBy \<IMicrosoftGraphIdentitySet\>\]: identitySet
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Application \<IMicrosoftGraphIdentity\>\]: identity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
    \[Device \<IMicrosoftGraphIdentity\>\]: identity
    \[User \<IMicrosoftGraphIdentity\>\]: identity
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Inference \<IMicrosoftGraphInferenceData\>\]: inferenceData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ConfidenceScore \<Double?\>\]: 
    \[UserHasVerifiedAccuracy \<Boolean?\>\]: 
  \[LastModifiedBy \<IMicrosoftGraphIdentitySet\>\]: identitySet
  \[LastModifiedDateTime \<DateTime?\>\]: 
  \[Source \<IMicrosoftGraphPersonDataSources\>\]: personDataSources
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Type \<String\[\]\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IssuedDate \<DateTime?\>\]: 
  \[IssuingAuthority \<String\>\]: 
  \[ThumbnailUrl \<String\>\]: 
  \[WebUrl \<String\>\]: 

CREATEDBY \<IMicrosoftGraphIdentitySet\>: identitySet
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Application \<IMicrosoftGraphIdentity\>\]: identity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
  \[Device \<IMicrosoftGraphIdentity\>\]: identity
  \[User \<IMicrosoftGraphIdentity\>\]: identity

INFERENCE \<IMicrosoftGraphInferenceData\>: inferenceData
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ConfidenceScore \<Double?\>\]: 
  \[UserHasVerifiedAccuracy \<Boolean?\>\]: 

INPUTOBJECT \<IPeopleIdentity\>: Identity Parameter
  \[ActivityStatisticsId \<String\>\]: key: id of activityStatistics
  \[EducationalActivityId \<String\>\]: key: id of educationalActivity
  \[ItemAddressId \<String\>\]: key: id of itemAddress
  \[ItemEmailId \<String\>\]: key: id of itemEmail
  \[ItemPatentId \<String\>\]: key: id of itemPatent
  \[ItemPhoneId \<String\>\]: key: id of itemPhone
  \[ItemPublicationId \<String\>\]: key: id of itemPublication
  \[LanguageProficiencyId \<String\>\]: key: id of languageProficiency
  \[PersonAnniversaryId \<String\>\]: key: id of personAnniversary
  \[PersonAnnotationId \<String\>\]: key: id of personAnnotation
  \[PersonAwardId \<String\>\]: key: id of personAward
  \[PersonCertificationId \<String\>\]: key: id of personCertification
  \[PersonId \<String\>\]: key: id of person
  \[PersonInterestId \<String\>\]: key: id of personInterest
  \[PersonNameId \<String\>\]: key: id of personName
  \[PersonWebsiteId \<String\>\]: key: id of personWebsite
  \[ProjectParticipationId \<String\>\]: key: id of projectParticipation
  \[SharedInsightId \<String\>\]: key: id of sharedInsight
  \[SkillProficiencyId \<String\>\]: key: id of skillProficiency
  \[TrendingId \<String\>\]: key: id of trending
  \[UsedInsightId \<String\>\]: key: id of usedInsight
  \[UserAccountInformationId \<String\>\]: key: id of userAccountInformation
  \[UserId \<String\>\]: key: id of user
  \[WebAccountId \<String\>\]: key: id of webAccount
  \[WorkPositionId \<String\>\]: key: id of workPosition

LASTMODIFIEDBY \<IMicrosoftGraphIdentitySet\>: identitySet
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Application \<IMicrosoftGraphIdentity\>\]: identity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
  \[Device \<IMicrosoftGraphIdentity\>\]: identity
  \[User \<IMicrosoftGraphIdentity\>\]: identity

SOURCE \<IMicrosoftGraphPersonDataSources\>: personDataSources
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Type \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileaward](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileaward)

