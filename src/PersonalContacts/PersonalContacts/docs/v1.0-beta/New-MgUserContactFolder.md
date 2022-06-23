---
external help file:
Module Name: Microsoft.Graph.PersonalContacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/new-mgusercontactfolder
schema: 2.0.0
---

# New-MgUserContactFolder

## SYNOPSIS
The user's contacts folders.
Read-only.
Nullable.

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserContactFolder -UserId <String> [-AdditionalProperties <Hashtable>]
 [-ChildFolders <IMicrosoftGraphContactFolder[]>] [-Contacts <IMicrosoftGraphContact1[]>]
 [-DisplayName <String>] [-Id <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-WellKnownName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserContactFolder -UserId <String> -BodyParameter <IMicrosoftGraphContactFolder> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserContactFolder -InputObject <IPersonalContactsIdentity> -BodyParameter <IMicrosoftGraphContactFolder>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserContactFolder -InputObject <IPersonalContactsIdentity> [-AdditionalProperties <Hashtable>]
 [-ChildFolders <IMicrosoftGraphContactFolder[]>] [-Contacts <IMicrosoftGraphContact1[]>]
 [-DisplayName <String>] [-Id <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]
 [-WellKnownName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The user's contacts folders.
Read-only.
Nullable.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
contactFolder
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChildFolders
The collection of child folders in the folder.
Navigation property.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for CHILDFOLDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Contacts
The contacts in the folder.
Navigation property.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for CONTACTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact1[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The folder's display name.

```yaml
Type: System.String
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
Type: System.String
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the contactFolder.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentFolderId
The ID of the folder's parent folder.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the contactFolder.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
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
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WellKnownName
The name of the folder if the folder is a recognized folder.
Currently contacts is the only recognized contacts folder.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder

### Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphContactFolder>: contactFolder
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ChildFolders <IMicrosoftGraphContactFolder[]>]`: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Contacts <IMicrosoftGraphContact1[]>]`: The contacts in the folder. Navigation property. Read-only. Nullable.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: Read-only.
    - `[AssistantName <String>]`: The name of the contact's assistant.
    - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Children <String[]>]`: The names of the contact's children.
    - `[CompanyName <String>]`: The name of the contact's company.
    - `[Department <String>]`: The contact's department.
    - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
    - `[EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>]`: The contact's email addresses.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
      - `[OtherLabel <String>]`: To specify a custom type of email address, set type to other, and assign otherLabel to a custom string. For example, you may use a specific email address for your volunteer activities. Set type to other, and set otherLabel to a custom string such as Volunteer work.
      - `[Type <String>]`: emailType
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[FileAs <String>]`: The name the contact is filed under.
    - `[Flag <IMicrosoftGraphFollowupFlag>]`: followupFlag
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
      - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[FlagStatus <String>]`: followupFlagStatus
      - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Gender <String>]`: The contact's gender.
    - `[Generation <String>]`: The contact's generation.
    - `[GivenName <String>]`: The contact's given name.
    - `[ImAddresses <String[]>]`: 
    - `[Initials <String>]`: 
    - `[IsFavorite <Boolean?>]`: 
    - `[JobTitle <String>]`: 
    - `[Manager <String>]`: 
    - `[MiddleName <String>]`: 
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NickName <String>]`: 
    - `[OfficeLocation <String>]`: 
    - `[ParentFolderId <String>]`: 
    - `[PersonalNotes <String>]`: 
    - `[Phones <IMicrosoftGraphPhone[]>]`: 
      - `[Number <String>]`: The phone number.
      - `[Type <String>]`: phoneType
    - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Height <Int32?>]`: The height of the photo. Read-only.
      - `[Width <Int32?>]`: The width of the photo. Read-only.
    - `[PostalAddresses <IMicrosoftGraphPhysicalAddress1[]>]`: 
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[Profession <String>]`: 
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
    - `[SpouseName <String>]`: 
    - `[Surname <String>]`: 
    - `[Title <String>]`: 
    - `[Websites <IMicrosoftGraphWebsite[]>]`: 
      - `[Address <String>]`: The URL of the website.
      - `[DisplayName <String>]`: The display name of the web site.
      - `[Type <String>]`: websiteType
    - `[WeddingAnniversary <DateTime?>]`: 
    - `[YomiCompanyName <String>]`: 
    - `[YomiGivenName <String>]`: 
    - `[YomiSurname <String>]`: 
  - `[DisplayName <String>]`: The folder's display name.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[ParentFolderId <String>]`: The ID of the folder's parent folder.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[WellKnownName <String>]`: The name of the folder if the folder is a recognized folder. Currently contacts is the only recognized contacts folder.

CHILDFOLDERS <IMicrosoftGraphContactFolder[]>: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ChildFolders <IMicrosoftGraphContactFolder[]>]`: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Contacts <IMicrosoftGraphContact1[]>]`: The contacts in the folder. Navigation property. Read-only. Nullable.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Id <String>]`: Read-only.
    - `[AssistantName <String>]`: The name of the contact's assistant.
    - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Children <String[]>]`: The names of the contact's children.
    - `[CompanyName <String>]`: The name of the contact's company.
    - `[Department <String>]`: The contact's department.
    - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
    - `[EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>]`: The contact's email addresses.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
      - `[OtherLabel <String>]`: To specify a custom type of email address, set type to other, and assign otherLabel to a custom string. For example, you may use a specific email address for your volunteer activities. Set type to other, and set otherLabel to a custom string such as Volunteer work.
      - `[Type <String>]`: emailType
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[FileAs <String>]`: The name the contact is filed under.
    - `[Flag <IMicrosoftGraphFollowupFlag>]`: followupFlag
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
        - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
      - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[FlagStatus <String>]`: followupFlagStatus
      - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Gender <String>]`: The contact's gender.
    - `[Generation <String>]`: The contact's generation.
    - `[GivenName <String>]`: The contact's given name.
    - `[ImAddresses <String[]>]`: 
    - `[Initials <String>]`: 
    - `[IsFavorite <Boolean?>]`: 
    - `[JobTitle <String>]`: 
    - `[Manager <String>]`: 
    - `[MiddleName <String>]`: 
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NickName <String>]`: 
    - `[OfficeLocation <String>]`: 
    - `[ParentFolderId <String>]`: 
    - `[PersonalNotes <String>]`: 
    - `[Phones <IMicrosoftGraphPhone[]>]`: 
      - `[Number <String>]`: The phone number.
      - `[Type <String>]`: phoneType
    - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Height <Int32?>]`: The height of the photo. Read-only.
      - `[Width <Int32?>]`: The width of the photo. Read-only.
    - `[PostalAddresses <IMicrosoftGraphPhysicalAddress1[]>]`: 
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[Profession <String>]`: 
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
    - `[SpouseName <String>]`: 
    - `[Surname <String>]`: 
    - `[Title <String>]`: 
    - `[Websites <IMicrosoftGraphWebsite[]>]`: 
      - `[Address <String>]`: The URL of the website.
      - `[DisplayName <String>]`: The display name of the web site.
      - `[Type <String>]`: websiteType
    - `[WeddingAnniversary <DateTime?>]`: 
    - `[YomiCompanyName <String>]`: 
    - `[YomiGivenName <String>]`: 
    - `[YomiSurname <String>]`: 
  - `[DisplayName <String>]`: The folder's display name.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[ParentFolderId <String>]`: The ID of the folder's parent folder.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[WellKnownName <String>]`: The name of the folder if the folder is a recognized folder. Currently contacts is the only recognized contacts folder.

CONTACTS <IMicrosoftGraphContact1[]>: The contacts in the folder. Navigation property. Read-only. Nullable.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[AssistantName <String>]`: The name of the contact's assistant.
  - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Children <String[]>]`: The names of the contact's children.
  - `[CompanyName <String>]`: The name of the contact's company.
  - `[Department <String>]`: The contact's department.
  - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
  - `[EmailAddresses <IMicrosoftGraphTypedEmailAddress[]>]`: The contact's email addresses.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
    - `[OtherLabel <String>]`: To specify a custom type of email address, set type to other, and assign otherLabel to a custom string. For example, you may use a specific email address for your volunteer activities. Set type to other, and set otherLabel to a custom string such as Volunteer work.
    - `[Type <String>]`: emailType
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[FileAs <String>]`: The name the contact is filed under.
  - `[Flag <IMicrosoftGraphFollowupFlag>]`: followupFlag
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompletedDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[DueDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[FlagStatus <String>]`: followupFlagStatus
    - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Gender <String>]`: The contact's gender.
  - `[Generation <String>]`: The contact's generation.
  - `[GivenName <String>]`: The contact's given name.
  - `[ImAddresses <String[]>]`: 
  - `[Initials <String>]`: 
  - `[IsFavorite <Boolean?>]`: 
  - `[JobTitle <String>]`: 
  - `[Manager <String>]`: 
  - `[MiddleName <String>]`: 
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[NickName <String>]`: 
  - `[OfficeLocation <String>]`: 
  - `[ParentFolderId <String>]`: 
  - `[PersonalNotes <String>]`: 
  - `[Phones <IMicrosoftGraphPhone[]>]`: 
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Height <Int32?>]`: The height of the photo. Read-only.
    - `[Width <Int32?>]`: The width of the photo. Read-only.
  - `[PostalAddresses <IMicrosoftGraphPhysicalAddress1[]>]`: 
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Profession <String>]`: 
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[SpouseName <String>]`: 
  - `[Surname <String>]`: 
  - `[Title <String>]`: 
  - `[Websites <IMicrosoftGraphWebsite[]>]`: 
    - `[Address <String>]`: The URL of the website.
    - `[DisplayName <String>]`: The display name of the web site.
    - `[Type <String>]`: websiteType
  - `[WeddingAnniversary <DateTime?>]`: 
  - `[YomiCompanyName <String>]`: 
  - `[YomiGivenName <String>]`: 
  - `[YomiSurname <String>]`: 

INPUTOBJECT <IPersonalContactsIdentity>: Identity Parameter
  - `[ContactFolderId <String>]`: key: id of contactFolder
  - `[ContactFolderId1 <String>]`: key: id of contactFolder
  - `[ContactId <String>]`: key: id of contact
  - `[ExtensionId <String>]`: key: id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: id of user

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

