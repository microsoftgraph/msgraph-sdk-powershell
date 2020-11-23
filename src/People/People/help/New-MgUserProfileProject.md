---
external help file: Microsoft.Graph.People-help.xml
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/new-mguserprofileproject
schema: 2.0.0
---

# New-MgUserProfileProject

## SYNOPSIS
Create new navigation property to projects for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserProfileProject -UserId <String> [-AdditionalProperties <Hashtable>] [-AllowedAudiences <String>]
 [-Categories <String[]>] [-Client <IMicrosoftGraphCompanyDetail>] [-CollaborationTags <String[]>]
 [-Colleagues <IMicrosoftGraphRelatedPerson[]>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-Detail <IMicrosoftGraphPositionDetail>] [-DisplayName <String>] [-Id <String>]
 [-Inference <IMicrosoftGraphInferenceData>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Source <IMicrosoftGraphPersonDataSources>]
 [-Sponsors <IMicrosoftGraphRelatedPerson[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgUserProfileProject -UserId <String> -BodyParameter <IMicrosoftGraphProjectParticipation> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserProfileProject -InputObject <IPeopleIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedAudiences <String>] [-Categories <String[]>] [-Client <IMicrosoftGraphCompanyDetail>]
 [-CollaborationTags <String[]>] [-Colleagues <IMicrosoftGraphRelatedPerson[]>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Detail <IMicrosoftGraphPositionDetail>] [-DisplayName <String>] [-Id <String>]
 [-Inference <IMicrosoftGraphInferenceData>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Source <IMicrosoftGraphPersonDataSources>]
 [-Sponsors <IMicrosoftGraphRelatedPerson[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserProfileProject -InputObject <IPeopleIdentity> -BodyParameter <IMicrosoftGraphProjectParticipation>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to projects for users

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
projectParticipation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphProjectParticipation
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Client
companyDetail
To construct, see NOTES section for CLIENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphCompanyDetail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CollaborationTags
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Colleagues
.
To construct, see NOTES section for COLLEAGUES properties and create a hash table.

```yaml
Type: IMicrosoftGraphRelatedPerson[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Detail
positionDetail
To construct, see NOTES section for DETAIL properties and create a hash table.

```yaml
Type: IMicrosoftGraphPositionDetail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sponsors
.
To construct, see NOTES section for SPONSORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphRelatedPerson[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, Create
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProjectParticipation
### Microsoft.Graph.PowerShell.Models.IPeopleIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProjectParticipation
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphProjectParticipation\>: projectParticipation
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
  \[Categories \<String\[\]\>\]: 
  \[Client \<IMicrosoftGraphCompanyDetail\>\]: companyDetail
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Address \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[Department \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[OfficeLocation \<String\>\]: 
    \[Pronunciation \<String\>\]: 
    \[WebUrl \<String\>\]: 
  \[CollaborationTags \<String\[\]\>\]: 
  \[Colleagues \<IMicrosoftGraphRelatedPerson\[\]\>\]: 
    \[DisplayName \<String\>\]: 
    \[Relationship \<String\>\]: personRelationship
    \[UserPrincipalName \<String\>\]: 
  \[Detail \<IMicrosoftGraphPositionDetail\>\]: positionDetail
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Company \<IMicrosoftGraphCompanyDetail\>\]: companyDetail
    \[Description \<String\>\]: 
    \[EndMonthYear \<DateTime?\>\]: 
    \[JobTitle \<String\>\]: 
    \[Role \<String\>\]: 
    \[StartMonthYear \<DateTime?\>\]: 
    \[Summary \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[Sponsors \<IMicrosoftGraphRelatedPerson\[\]\>\]: 

CLIENT \<IMicrosoftGraphCompanyDetail\>: companyDetail
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Address \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[PostOfficeBox \<String\>\]: 
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
    \[Type \<String\>\]: physicalAddressType
  \[Department \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[OfficeLocation \<String\>\]: 
  \[Pronunciation \<String\>\]: 
  \[WebUrl \<String\>\]: 

COLLEAGUES \<IMicrosoftGraphRelatedPerson\[\]\>: .
  \[DisplayName \<String\>\]: 
  \[Relationship \<String\>\]: personRelationship
  \[UserPrincipalName \<String\>\]: 

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

DETAIL \<IMicrosoftGraphPositionDetail\>: positionDetail
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Company \<IMicrosoftGraphCompanyDetail\>\]: companyDetail
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Address \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[Department \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[OfficeLocation \<String\>\]: 
    \[Pronunciation \<String\>\]: 
    \[WebUrl \<String\>\]: 
  \[Description \<String\>\]: 
  \[EndMonthYear \<DateTime?\>\]: 
  \[JobTitle \<String\>\]: 
  \[Role \<String\>\]: 
  \[StartMonthYear \<DateTime?\>\]: 
  \[Summary \<String\>\]: 

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

SPONSORS \<IMicrosoftGraphRelatedPerson\[\]\>: .
  \[DisplayName \<String\>\]: 
  \[Relationship \<String\>\]: personRelationship
  \[UserPrincipalName \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/new-mguserprofileproject](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/new-mguserprofileproject)

