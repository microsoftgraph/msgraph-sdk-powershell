---
external help file:
Module Name: Microsoft.Graph.Users.Contacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.contacts/new-mgusercontact
schema: 2.0.0
---

# New-MgUserContact

## SYNOPSIS
Create new navigation property to contacts for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserContact -UserId <String> [-AssistantName <String>] [-Birthday <DateTime>] [-Categories <String[]>]
 [-ChangeKey <String>] [-Children <String[]>] [-CompanyName <String>] [-CompletedDateTime <String>]
 [-CompletedDateTimeZone <String>] [-CreatedDateTime <DateTime>] [-Department <String>]
 [-DisplayName <String>] [-DueDateTime <String>] [-DueDateTimeZone <String>]
 [-EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>] [-Extensions <IMicrosoftGraphExtension[]>]
 [-FileAs <String>] [-FlagStatus <String>] [-Gender <String>] [-Generation <String>] [-GivenName <String>]
 [-Id <String>] [-ImAddresses <String[]>] [-Initials <String>] [-IsFavorite] [-JobTitle <String>]
 [-LastModifiedDateTime <DateTime>] [-Manager <String>] [-MiddleName <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-NickName <String>]
 [-OfficeLocation <String>] [-ParentFolderId <String>] [-PersonalNotes <String>]
 [-Phones <IMicrosoftGraphPhone[]>] [-PhotoHeight <Int32>] [-PhotoId <String>] [-PhotoWidth <Int32>]
 [-PostalAddresses <IMicrosoftGraphPhysicalAddress[]>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-StartDateTime <String>] [-StartDateTimeZone <String>] [-Surname <String>] [-Title <String>]
 [-Websites <IMicrosoftGraphWebsite[]>] [-WeddingAnniversary <DateTime>] [-YomiCompanyName <String>]
 [-YomiGivenName <String>] [-YomiSurname <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserContact -UserId <String> -BodyParameter <IMicrosoftGraphContact> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserContact -InputObject <IUsersContactsIdentity> -BodyParameter <IMicrosoftGraphContact> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserContact -InputObject <IUsersContactsIdentity> [-AssistantName <String>] [-Birthday <DateTime>]
 [-Categories <String[]>] [-ChangeKey <String>] [-Children <String[]>] [-CompanyName <String>]
 [-CompletedDateTime <String>] [-CompletedDateTimeZone <String>] [-CreatedDateTime <DateTime>]
 [-Department <String>] [-DisplayName <String>] [-DueDateTime <String>] [-DueDateTimeZone <String>]
 [-EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>] [-Extensions <IMicrosoftGraphExtension[]>]
 [-FileAs <String>] [-FlagStatus <String>] [-Gender <String>] [-Generation <String>] [-GivenName <String>]
 [-Id <String>] [-ImAddresses <String[]>] [-Initials <String>] [-IsFavorite] [-JobTitle <String>]
 [-LastModifiedDateTime <DateTime>] [-Manager <String>] [-MiddleName <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-NickName <String>]
 [-OfficeLocation <String>] [-ParentFolderId <String>] [-PersonalNotes <String>]
 [-Phones <IMicrosoftGraphPhone[]>] [-PhotoHeight <Int32>] [-PhotoId <String>] [-PhotoWidth <Int32>]
 [-PostalAddresses <IMicrosoftGraphPhysicalAddress[]>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-StartDateTime <String>] [-StartDateTimeZone <String>] [-Surname <String>] [-Title <String>]
 [-Websites <IMicrosoftGraphWebsite[]>] [-WeddingAnniversary <DateTime>] [-YomiCompanyName <String>]
 [-YomiGivenName <String>] [-YomiSurname <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to contacts for users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AssistantName
The name of the contact's assistant.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Birthday
The contact's birthday.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
contact
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Categories
The categories associated with the item

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChangeKey
Identifies the version of the item.
Every time the item is changed, changeKey changes as well.
This allows Exchange to apply changes to the correct version of the object.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Children
The names of the contact's children.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CompanyName
The name of the contact's company.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CompletedDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CompletedDateTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Department
The contact's department.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
The contact's display name.
You can specify the display name in a create or update operation.
Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified.
To preserve a pre-existing value, always include it as displayName in an update operation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DueDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DueDateTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EmailAddresses
The contact's email addresses.
To construct, see NOTES section for EMAILADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTypedEmailAddress[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Extensions
The collection of open extensions defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FileAs
The name the contact is filed under.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FlagStatus
followupFlagStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Gender
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Generation
The contact's generation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GivenName
The contact's given name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ImAddresses
The contact's instant messaging (IM) addresses.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Initials
The contact's initials.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersContactsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IsFavorite
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -JobTitle
The contact’s job title.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Manager
The name of the contact's manager.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MiddleName
The contact's middle name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NickName
The contact's nickname.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OfficeLocation
The location of the contact's office.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ParentFolderId
The ID of the contact's parent folder.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PersonalNotes
The user's notes about the contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Phones
.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhotoHeight
The height of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhotoId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhotoWidth
The width of the photo.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PostalAddresses
.
To construct, see NOTES section for POSTALADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Profession
The contact's profession.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the contact.
Read-only.
Nullable.
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SpouseName
The name of the contact's spouse/partner.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StartDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StartDateTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Surname
The contact's surname.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Title
The contact's title.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Websites
.
To construct, see NOTES section for WEBSITES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWebsite[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WeddingAnniversary
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -YomiCompanyName
The phonetic Japanese company name of the contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -YomiGivenName
The phonetic Japanese given name (first name) of the contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -YomiSurname
The phonetic Japanese surname (last name) of the contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact

### Microsoft.Graph.PowerShell.Models.IUsersContactsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphContact>: contact
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AssistantName <String>]`: The name of the contact's assistant.
  - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Children <String[]>]`: The names of the contact's children.
  - `[CompanyName <String>]`: The name of the contact's company.
  - `[CompletedDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[CompletedDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Department <String>]`: The contact's department.
  - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
  - `[DueDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[DueDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>]`: The contact's email addresses.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
    - `[OtherLabel <String>]`: 
    - `[Type <String>]`: emailType
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[FileAs <String>]`: The name the contact is filed under.
  - `[FlagStatus <String>]`: followupFlagStatus
  - `[Gender <String>]`: 
  - `[Generation <String>]`: The contact's generation.
  - `[GivenName <String>]`: The contact's given name.
  - `[ImAddresses <String[]>]`: The contact's instant messaging (IM) addresses.
  - `[Initials <String>]`: The contact's initials.
  - `[IsFavorite <Boolean?>]`: 
  - `[JobTitle <String>]`: The contact’s job title.
  - `[Manager <String>]`: The name of the contact's manager.
  - `[MiddleName <String>]`: The contact's middle name.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[NickName <String>]`: The contact's nickname.
  - `[OfficeLocation <String>]`: The location of the contact's office.
  - `[ParentFolderId <String>]`: The ID of the contact's parent folder.
  - `[PersonalNotes <String>]`: The user's notes about the contact.
  - `[Phones <IMicrosoftGraphPhone[]>]`: 
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[PhotoHeight <Int32?>]`: The height of the photo. Read-only.
  - `[PhotoId <String>]`: Read-only.
  - `[PhotoWidth <Int32?>]`: The width of the photo. Read-only.
  - `[PostalAddresses <IMicrosoftGraphPhysicalAddress[]>]`: 
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: 
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Profession <String>]`: The contact's profession.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[SpouseName <String>]`: The name of the contact's spouse/partner.
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Surname <String>]`: The contact's surname.
  - `[Title <String>]`: The contact's title.
  - `[Websites <IMicrosoftGraphWebsite[]>]`: 
    - `[Address <String>]`: The URL of the website.
    - `[DisplayName <String>]`: The display name of the web site.
    - `[Type <String>]`: websiteType
  - `[WeddingAnniversary <DateTime?>]`: 
  - `[YomiCompanyName <String>]`: The phonetic Japanese company name of the contact.
  - `[YomiGivenName <String>]`: The phonetic Japanese given name (first name) of the contact.
  - `[YomiSurname <String>]`: The phonetic Japanese surname (last name)  of the contact.

#### EMAILADDRESSES <IMicrosoftGraphTypedEmailAddress[]>: The contact's email addresses.
  - `[Address <String>]`: The email address of the person or entity.
  - `[Name <String>]`: The display name of the person or entity.
  - `[OtherLabel <String>]`: 
  - `[Type <String>]`: emailType

#### EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.

#### INPUTOBJECT <IUsersContactsIdentity>: Identity Parameter
  - `[ContactFolderId <String>]`: key: contactFolder-id of contactFolder
  - `[ContactFolderId1 <String>]`: key: contactFolder-id of contactFolder
  - `[ContactId <String>]`: key: contact-id of contact
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

#### MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

#### PHONES <IMicrosoftGraphPhone[]>: .
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

#### POSTALADDRESSES <IMicrosoftGraphPhysicalAddress[]>: .
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostOfficeBox <String>]`: 
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.
  - `[Type <String>]`: physicalAddressType

#### SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

#### WEBSITES <IMicrosoftGraphWebsite[]>: .
  - `[Address <String>]`: The URL of the website.
  - `[DisplayName <String>]`: The display name of the web site.
  - `[Type <String>]`: websiteType

## RELATED LINKS

