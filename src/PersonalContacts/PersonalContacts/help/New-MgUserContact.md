---
external help file: Microsoft.Graph.PersonalContacts-help.xml
Module Name: Microsoft.Graph.PersonalContacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontact
schema: 2.0.0
---

# New-MgUserContact

## SYNOPSIS
Create new navigation property to contacts for users

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgUserContact -UserId <String> [-AdditionalProperties <Hashtable>] [-AssistantName <String>]
 [-Birthday <DateTime>] [-Categories <String[]>] [-ChangeKey <String>] [-Children <String[]>]
 [-CompanyName <String>] [-CreatedDateTime <DateTime>] [-Department <String>] [-DisplayName <String>]
 [-EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>] [-Extensions <IMicrosoftGraphExtension[]>]
 [-FileAs <String>] [-Flag <IMicrosoftGraphFollowupFlag>] [-Gender <String>] [-Generation <String>]
 [-GivenName <String>] [-Id <String>] [-ImAddresses <String[]>] [-Initials <String>] [-IsFavorite]
 [-JobTitle <String>] [-LastModifiedDateTime <DateTime>] [-Manager <String>] [-MiddleName <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-NickName <String>]
 [-OfficeLocation <String>] [-ParentFolderId <String>] [-PersonalNotes <String>]
 [-Phones <IMicrosoftGraphPhone[]>] [-Photo <IMicrosoftGraphProfilePhoto>]
 [-PostalAddresses <IMicrosoftGraphPhysicalAddress[]>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-Surname <String>] [-Title <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-WeddingAnniversary <DateTime>]
 [-YomiCompanyName <String>] [-YomiGivenName <String>] [-YomiSurname <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create1
```
New-MgUserContact -UserId <String> -BodyParameter <IMicrosoftGraphContact> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgUserContact -InputObject <IPersonalContactsIdentity> [-AdditionalProperties <Hashtable>]
 [-AssistantName <String>] [-Birthday <DateTime>] [-Categories <String[]>] [-ChangeKey <String>]
 [-Children <String[]>] [-CompanyName <String>] [-CreatedDateTime <DateTime>] [-Department <String>]
 [-DisplayName <String>] [-EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-FileAs <String>] [-Flag <IMicrosoftGraphFollowupFlag>]
 [-Gender <String>] [-Generation <String>] [-GivenName <String>] [-Id <String>] [-ImAddresses <String[]>]
 [-Initials <String>] [-IsFavorite] [-JobTitle <String>] [-LastModifiedDateTime <DateTime>] [-Manager <String>]
 [-MiddleName <String>] [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-NickName <String>] [-OfficeLocation <String>] [-ParentFolderId <String>] [-PersonalNotes <String>]
 [-Phones <IMicrosoftGraphPhone[]>] [-Photo <IMicrosoftGraphProfilePhoto>]
 [-PostalAddresses <IMicrosoftGraphPhysicalAddress[]>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-Surname <String>] [-Title <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-WeddingAnniversary <DateTime>]
 [-YomiCompanyName <String>] [-YomiGivenName <String>] [-YomiSurname <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgUserContact -InputObject <IPersonalContactsIdentity> -BodyParameter <IMicrosoftGraphContact> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to contacts for users

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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssistantName
The name of the contact's assistant.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Birthday
The contact's birthday.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
contact
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphContact
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The categories associated with the item

```yaml
Type: String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChangeKey
Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Children
The names of the contact's children.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyName
The name of the contact's company.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
The contact's department.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The contact's display name.
You can specify the display name in a create or update operation.
Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified.
To preserve a pre-existing value, always include it as displayName in an update operation.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddresses
The contact's email addresses.
To construct, see NOTES section for EMAILADDRESSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphTypedEmailAddress[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExtension[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileAs
The name the contact is filed under.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Flag
followupFlag
To construct, see NOTES section for FLAG properties and create a hash table.

```yaml
Type: IMicrosoftGraphFollowupFlag
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Gender
.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Generation
The contact's generation.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
The contact's given name.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImAddresses
The contact's instant messaging (IM) addresses.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Initials
The contact's initials.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: IPersonalContactsIdentity
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsFavorite
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobTitle
The contact's job title.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manager
The name of the contact's manager.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MiddleName
The contact's middle name.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NickName
The contact's nickname.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeLocation
The location of the contact's office.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentFolderId
The ID of the contact's parent folder.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonalNotes
The user's notes about the contact.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phones
.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhone[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Photo
profilePhoto
To construct, see NOTES section for PHOTO properties and create a hash table.

```yaml
Type: IMicrosoftGraphProfilePhoto
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostalAddresses
.
To construct, see NOTES section for POSTALADDRESSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhysicalAddress[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Profession
The contact's profession.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpouseName
The name of the contact's spouse/partner.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
The contact's surname.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
The contact's title.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Websites
.
To construct, see NOTES section for WEBSITES properties and create a hash table.

```yaml
Type: IMicrosoftGraphWebsite[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WeddingAnniversary
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiCompanyName
The phonetic Japanese company name of the contact.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiGivenName
The phonetic Japanese given name (first name) of the contact.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiSurname
The phonetic Japanese surname (last name) of the contact.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact
### Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphContact1\>: contact
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Categories \<String\[\]\>\]: The categories associated with the item
  \[ChangeKey \<String\>\]: Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.
  \[CreatedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[Id \<String\>\]: Read-only.
  \[AssistantName \<String\>\]: The name of the contact's assistant.
  \[Birthday \<DateTime?\>\]: The contact's birthday.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[BusinessAddress \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
  \[BusinessHomePage \<String\>\]: The business home page of the contact.
  \[BusinessPhones \<String\[\]\>\]: The contact's business phone numbers.
  \[Children \<String\[\]\>\]: The names of the contact's children.
  \[CompanyName \<String\>\]: The name of the contact's company.
  \[Department \<String\>\]: The contact's department.
  \[DisplayName \<String\>\]: The contact's display name.
You can specify the display name in a create or update operation.
Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified.
To preserve a pre-existing value, always include it as displayName in an update operation.
  \[EmailAddresses \<IMicrosoftGraphEmailAddress\[\]\>\]: The contact's email addresses.
    \[Address \<String\>\]: The email address of the person or entity.
    \[Name \<String\>\]: The display name of the person or entity.
  \[Extensions \<IMicrosoftGraphExtension\[\]\>\]: The collection of open extensions defined for the contact.
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
  \[FileAs \<String\>\]: The name the contact is filed under.
  \[Generation \<String\>\]: The contact's generation.
  \[GivenName \<String\>\]: The contact's given name.
  \[HomeAddress \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
  \[HomePhones \<String\[\]\>\]: The contact's home phone numbers.
  \[ImAddresses \<String\[\]\>\]: The contact's instant messaging (IM) addresses.
  \[Initials \<String\>\]: The contact's initials.
  \[JobTitle \<String\>\]: The contact's job title.
  \[Manager \<String\>\]: The name of the contact's manager.
  \[MiddleName \<String\>\]: The contact's middle name.
  \[MobilePhone \<String\>\]: The contact's mobile phone number.
  \[MultiValueExtendedProperties \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>\]: The collection of multi-value extended properties defined for the contact.
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
    \[Value \<String\[\]\>\]: A collection of property values.
  \[NickName \<String\>\]: The contact's nickname.
  \[OfficeLocation \<String\>\]: The location of the contact's office.
  \[OtherAddress \<IMicrosoftGraphPhysicalAddress1\>\]: physicalAddress
  \[ParentFolderId \<String\>\]: The ID of the contact's parent folder.
  \[PersonalNotes \<String\>\]: The user's notes about the contact.
  \[Photo \<IMicrosoftGraphProfilePhoto\>\]: profilePhoto
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Height \<Int32?\>\]: The height of the photo.
Read-only.
    \[Width \<Int32?\>\]: The width of the photo.
Read-only.
  \[Profession \<String\>\]: The contact's profession.
  \[SingleValueExtendedProperties \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>\]: The collection of single-value extended properties defined for the contact.
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
    \[Value \<String\>\]: A property value.
  \[SpouseName \<String\>\]: The name of the contact's spouse/partner.
  \[Surname \<String\>\]: The contact's surname.
  \[Title \<String\>\]: The contact's title.
  \[YomiCompanyName \<String\>\]: The phonetic Japanese company name of the contact.
  \[YomiGivenName \<String\>\]: The phonetic Japanese given name (first name) of the contact.
  \[YomiSurname \<String\>\]: The phonetic Japanese surname (last name)  of the contact.

BUSINESSADDRESS \<IMicrosoftGraphPhysicalAddress1\>: physicalAddress
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[City \<String\>\]: The city.
  \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
  \[PostalCode \<String\>\]: The postal code.
  \[State \<String\>\]: The state.
  \[Street \<String\>\]: The street.

EMAILADDRESSES \<IMicrosoftGraphEmailAddress\[\]\>: The contact's email addresses.
  \[Address \<String\>\]: The email address of the person or entity.
  \[Name \<String\>\]: The display name of the person or entity.

EXTENSIONS \<IMicrosoftGraphExtension\[\]\>: The collection of open extensions defined for the contact.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.

HOMEADDRESS \<IMicrosoftGraphPhysicalAddress1\>: physicalAddress
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[City \<String\>\]: The city.
  \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
  \[PostalCode \<String\>\]: The postal code.
  \[State \<String\>\]: The state.
  \[Street \<String\>\]: The street.

INPUTOBJECT \<IPersonalContactsIdentity\>: Identity Parameter
  \[ContactFolderId \<String\>\]: key: id of contactFolder
  \[ContactFolderId1 \<String\>\]: key: id of contactFolder
  \[ContactId \<String\>\]: key: id of contact
  \[ExtensionId \<String\>\]: key: id of extension
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[UserId \<String\>\]: key: id of user

MULTIVALUEEXTENDEDPROPERTIES \<IMicrosoftGraphMultiValueLegacyExtendedProperty\[\]\>: The collection of multi-value extended properties defined for the contact.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.
  \[Value \<String\[\]\>\]: A collection of property values.

OTHERADDRESS \<IMicrosoftGraphPhysicalAddress1\>: physicalAddress
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[City \<String\>\]: The city.
  \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
  \[PostalCode \<String\>\]: The postal code.
  \[State \<String\>\]: The state.
  \[Street \<String\>\]: The street.

PHOTO \<IMicrosoftGraphProfilePhoto\>: profilePhoto
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Height \<Int32?\>\]: The height of the photo.
Read-only.
  \[Width \<Int32?\>\]: The width of the photo.
Read-only.

SINGLEVALUEEXTENDEDPROPERTIES \<IMicrosoftGraphSingleValueLegacyExtendedProperty\[\]\>: The collection of single-value extended properties defined for the contact.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.
  \[Value \<String\>\]: A property value.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontact](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontact)

