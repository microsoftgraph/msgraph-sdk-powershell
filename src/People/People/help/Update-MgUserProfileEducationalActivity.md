---
external help file: Microsoft.Graph.People-help.xml
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileeducationalactivity
schema: 2.0.0
---

# Update-MgUserProfileEducationalActivity

## SYNOPSIS
Update the navigation property educationalActivities in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserProfileEducationalActivity -EducationalActivityId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedAudiences <String>] [-CompletionMonthYear <DateTime>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-EndMonthYear <DateTime>]
 [-Id <String>] [-Inference <IMicrosoftGraphInferenceData>] [-Institution <IMicrosoftGraphInstitutionData>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Program <IMicrosoftGraphEducationalActivityDetail>] [-Source <IMicrosoftGraphPersonDataSources>]
 [-StartMonthYear <DateTime>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgUserProfileEducationalActivity -EducationalActivityId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphEducationalActivity> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserProfileEducationalActivity -InputObject <IPeopleIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedAudiences <String>] [-CompletionMonthYear <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-EndMonthYear <DateTime>] [-Id <String>]
 [-Inference <IMicrosoftGraphInferenceData>] [-Institution <IMicrosoftGraphInstitutionData>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Program <IMicrosoftGraphEducationalActivityDetail>] [-Source <IMicrosoftGraphPersonDataSources>]
 [-StartMonthYear <DateTime>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserProfileEducationalActivity -InputObject <IPeopleIdentity>
 -BodyParameter <IMicrosoftGraphEducationalActivity> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property educationalActivities in users

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
educationalActivity
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphEducationalActivity
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompletionMonthYear
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

### -EducationalActivityId
key: id of educationalActivity

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

### -EndMonthYear
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

### -Institution
institutionData
To construct, see NOTES section for INSTITUTION properties and create a hash table.

```yaml
Type: IMicrosoftGraphInstitutionData
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

### -Program
educationalActivityDetail
To construct, see NOTES section for PROGRAM properties and create a hash table.

```yaml
Type: IMicrosoftGraphEducationalActivityDetail
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -StartMonthYear
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationalActivity
### Microsoft.Graph.PowerShell.Models.IPeopleIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphEducationalActivity\>: educationalActivity
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
  \[CompletionMonthYear \<DateTime?\>\]: 
  \[EndMonthYear \<DateTime?\>\]: 
  \[Institution \<IMicrosoftGraphInstitutionData\>\]: institutionData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[Location \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[WebUrl \<String\>\]: 
  \[Program \<IMicrosoftGraphEducationalActivityDetail\>\]: educationalActivityDetail
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Abbreviation \<String\>\]: 
    \[Activities \<String\[\]\>\]: 
    \[Awards \<String\[\]\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[FieldsOfStudy \<String\[\]\>\]: 
    \[Grade \<String\>\]: 
    \[Notes \<String\>\]: 
    \[WebUrl \<String\>\]: 
  \[StartMonthYear \<DateTime?\>\]: 

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

INSTITUTION \<IMicrosoftGraphInstitutionData\>: institutionData
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[Location \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[PostOfficeBox \<String\>\]: 
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
    \[Type \<String\>\]: physicalAddressType
  \[WebUrl \<String\>\]: 

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

PROGRAM \<IMicrosoftGraphEducationalActivityDetail\>: educationalActivityDetail
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Abbreviation \<String\>\]: 
  \[Activities \<String\[\]\>\]: 
  \[Awards \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[FieldsOfStudy \<String\[\]\>\]: 
  \[Grade \<String\>\]: 
  \[Notes \<String\>\]: 
  \[WebUrl \<String\>\]: 

SOURCE \<IMicrosoftGraphPersonDataSources\>: personDataSources
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Type \<String\[\]\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileeducationalactivity](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofileeducationalactivity)

