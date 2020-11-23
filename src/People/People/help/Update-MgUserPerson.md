---
external help file: Microsoft.Graph.People-help.xml
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserperson
schema: 2.0.0
---

# Update-MgUserPerson

## SYNOPSIS
Update the navigation property people in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserPerson -PersonId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Birthday <String>] [-CompanyName <String>] [-Department <String>] [-DisplayName <String>]
 [-EmailAddresses <IMicrosoftGraphRankedEmailAddress[]>] [-GivenName <String>] [-Id <String>] [-IsFavorite]
 [-MailboxType <String>] [-OfficeLocation <String>] [-PersonNotes <String>] [-PersonType <String>]
 [-Phones <IMicrosoftGraphPhone1[]>] [-PostalAddresses <IMicrosoftGraphLocation1[]>] [-Profession <String>]
 [-Sources <IMicrosoftGraphPersonDataSource[]>] [-Surname <String>] [-Title <String>]
 [-UserPrincipalName <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-YomiCompany <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update1
```
Update-MgUserPerson -PersonId <String> -UserId <String> -BodyParameter <IMicrosoftGraphPerson1> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserPerson -InputObject <IPeopleIdentity> [-AdditionalProperties <Hashtable>] [-Birthday <String>]
 [-CompanyName <String>] [-Department <String>] [-DisplayName <String>]
 [-EmailAddresses <IMicrosoftGraphRankedEmailAddress[]>] [-GivenName <String>] [-Id <String>] [-IsFavorite]
 [-MailboxType <String>] [-OfficeLocation <String>] [-PersonNotes <String>] [-PersonType <String>]
 [-Phones <IMicrosoftGraphPhone1[]>] [-PostalAddresses <IMicrosoftGraphLocation1[]>] [-Profession <String>]
 [-Sources <IMicrosoftGraphPersonDataSource[]>] [-Surname <String>] [-Title <String>]
 [-UserPrincipalName <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-YomiCompany <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserPerson -InputObject <IPeopleIdentity> -BodyParameter <IMicrosoftGraphPerson1> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property people in users

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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Birthday
The person's birthday.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
person
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPerson1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyName
The name of the person's company.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
The person's department.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The person's display name.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddresses
.
To construct, see NOTES section for EMAILADDRESSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphRankedEmailAddress[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
The person's given name.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsFavorite
true if the user has flagged this person as a favorite.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailboxType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeLocation
The location of the person's office.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PersonId
key: id of person

```yaml
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonNotes
Free-form notes that the user has taken about this person.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonType
personType
To construct, see NOTES section for PERSONTYPE properties and create a hash table.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phones
The person's phone numbers.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhone1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostalAddresses
The person's addresses.
To construct, see NOTES section for POSTALADDRESSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphLocation1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Profession
The person's profession.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sources
.
To construct, see NOTES section for SOURCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPersonDataSource[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
The person's surname.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
The user principal name (UPN) of the person.
The UPN is an Internet-style login name for the person based on the Internet standard RFC 822.
By convention, this should map to the person's email name.
The general format is alias@domain.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Websites
The person's websites.
To construct, see NOTES section for WEBSITES properties and create a hash table.

```yaml
Type: IMicrosoftGraphWebsite[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiCompany
The phonetic Japanese name of the person's company.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPerson1
### Microsoft.Graph.PowerShell.Models.IPeopleIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPerson\>: person
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Birthday \<String\>\]: The person's birthday.
  \[CompanyName \<String\>\]: The name of the person's company.
  \[Department \<String\>\]: The person's department.
  \[DisplayName \<String\>\]: The person's display name.
  \[GivenName \<String\>\]: The person's given name.
  \[ImAddress \<String\>\]: The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user.
Read-only.
  \[IsFavorite \<Boolean?\>\]: true if the user has flagged this person as a favorite.
  \[JobTitle \<String\>\]: The person's job title.
  \[OfficeLocation \<String\>\]: The location of the person's office.
  \[PersonNotes \<String\>\]: Free-form notes that the user has taken about this person.
  \[PersonType \<IMicrosoftGraphPersonType\>\]: personType
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Class \<String\>\]: The type of data source, such as Person.
    \[Subclass \<String\>\]: The secondary type of data source, such as OrganizationUser.
  \[Phones \<IMicrosoftGraphPhone\[\]\>\]: The person's phone numbers.
    \[Language \<String\>\]: 
    \[Number \<String\>\]: The phone number.
    \[Region \<String\>\]: 
    \[Type \<String\>\]: phoneType
  \[PostalAddresses \<IMicrosoftGraphLocation\[\]\>\]: The person's addresses.
    \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
    \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      \[Altitude \<Double?\>\]: The altitude of the location.
      \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
      \[Latitude \<Double?\>\]: The latitude of the location.
      \[Longitude \<Double?\>\]: The longitude of the location.
    \[DisplayName \<String\>\]: The name associated with the location.
    \[LocationEmailAddress \<String\>\]: Optional email address of the location.
    \[LocationType \<String\>\]: locationType
    \[LocationUri \<String\>\]: Optional URI representing the location.
    \[UniqueId \<String\>\]: For internal use only.
    \[UniqueIdType \<String\>\]: locationUniqueIdType
  \[Profession \<String\>\]: The person's profession.
  \[ScoredEmailAddresses \<IMicrosoftGraphScoredEmailAddress\[\]\>\]: The person's email addresses.
    \[Address \<String\>\]: The email address.
    \[ItemId \<String\>\]: 
    \[RelevanceScore \<Double?\>\]: The relevance score of the email address.
A relevance score is used as a sort key, in relation to the other returned results.
A higher relevance score value corresponds to a more relevant result.
Relevance is determined by the user's communication and collaboration patterns and business relationships.
    \[SelectionLikelihood \<String\>\]: selectionLikelihoodInfo
  \[Surname \<String\>\]: The person's surname.
  \[UserPrincipalName \<String\>\]: The user principal name (UPN) of the person.
The UPN is an Internet-style login name for the person based on the Internet standard RFC 822.
By convention, this should map to the person's email name.
The general format is alias@domain.
  \[Websites \<IMicrosoftGraphWebsite\[\]\>\]: The person's websites.
    \[Address \<String\>\]: The URL of the website.
    \[DisplayName \<String\>\]: The display name of the web site.
    \[Type \<String\>\]: websiteType
  \[YomiCompany \<String\>\]: The phonetic Japanese name of the person's company.

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

PERSONTYPE \<IMicrosoftGraphPersonType\>: personType
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Class \<String\>\]: The type of data source, such as Person.
  \[Subclass \<String\>\]: The secondary type of data source, such as OrganizationUser.

PHONES \<IMicrosoftGraphPhone\[\]\>: The person's phone numbers.
  \[Language \<String\>\]: 
  \[Number \<String\>\]: The phone number.
  \[Region \<String\>\]: 
  \[Type \<String\>\]: phoneType

POSTALADDRESSES \<IMicrosoftGraphLocation\[\]\>: The person's addresses.
  \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
  \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    \[Altitude \<Double?\>\]: The altitude of the location.
    \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
    \[Latitude \<Double?\>\]: The latitude of the location.
    \[Longitude \<Double?\>\]: The longitude of the location.
  \[DisplayName \<String\>\]: The name associated with the location.
  \[LocationEmailAddress \<String\>\]: Optional email address of the location.
  \[LocationType \<String\>\]: locationType
  \[LocationUri \<String\>\]: Optional URI representing the location.
  \[UniqueId \<String\>\]: For internal use only.
  \[UniqueIdType \<String\>\]: locationUniqueIdType

SCOREDEMAILADDRESSES \<IMicrosoftGraphScoredEmailAddress\[\]\>: The person's email addresses.
  \[Address \<String\>\]: The email address.
  \[ItemId \<String\>\]: 
  \[RelevanceScore \<Double?\>\]: The relevance score of the email address.
A relevance score is used as a sort key, in relation to the other returned results.
A higher relevance score value corresponds to a more relevant result.
Relevance is determined by the user's communication and collaboration patterns and business relationships.
  \[SelectionLikelihood \<String\>\]: selectionLikelihoodInfo

WEBSITES \<IMicrosoftGraphWebsite\[\]\>: The person's websites.
  \[Address \<String\>\]: The URL of the website.
  \[DisplayName \<String\>\]: The display name of the web site.
  \[Type \<String\>\]: websiteType

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserperson](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserperson)

