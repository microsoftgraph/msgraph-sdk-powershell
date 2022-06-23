---
external help file:
Module Name: Microsoft.Graph.PersonalContacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.personalcontacts/update-mgusercontact
schema: 2.0.0
---

# Update-MgUserContact

## SYNOPSIS
The user's contacts.
Read-only.
Nullable.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserContact -ContactId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AssistantName <String>] [-Birthday <DateTime>] [-BusinessAddress <IMicrosoftGraphPhysicalAddress>]
 [-BusinessHomePage <String>] [-BusinessPhones <String[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-Children <String[]>] [-CompanyName <String>] [-CreatedDateTime <DateTime>] [-Department <String>]
 [-DisplayName <String>] [-EmailAddresses <IMicrosoftGraphEmailAddress[]>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-FileAs <String>] [-Generation <String>] [-GivenName <String>]
 [-HomeAddress <IMicrosoftGraphPhysicalAddress>] [-HomePhones <String[]>] [-Id <String>]
 [-ImAddresses <String[]>] [-Initials <String>] [-JobTitle <String>] [-LastModifiedDateTime <DateTime>]
 [-Manager <String>] [-MiddleName <String>] [-MobilePhone <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-NickName <String>]
 [-OfficeLocation <String>] [-OtherAddress <IMicrosoftGraphPhysicalAddress>] [-ParentFolderId <String>]
 [-PersonalNotes <String>] [-Photo <IMicrosoftGraphProfilePhoto>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-Surname <String>] [-Title <String>] [-YomiCompanyName <String>] [-YomiGivenName <String>]
 [-YomiSurname <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserContact -ContactId <String> -UserId <String> -BodyParameter <IMicrosoftGraphContact> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserContact -InputObject <IPersonalContactsIdentity> -BodyParameter <IMicrosoftGraphContact>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserContact -InputObject <IPersonalContactsIdentity> [-AdditionalProperties <Hashtable>]
 [-AssistantName <String>] [-Birthday <DateTime>] [-BusinessAddress <IMicrosoftGraphPhysicalAddress>]
 [-BusinessHomePage <String>] [-BusinessPhones <String[]>] [-Categories <String[]>] [-ChangeKey <String>]
 [-Children <String[]>] [-CompanyName <String>] [-CreatedDateTime <DateTime>] [-Department <String>]
 [-DisplayName <String>] [-EmailAddresses <IMicrosoftGraphEmailAddress[]>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-FileAs <String>] [-Generation <String>] [-GivenName <String>]
 [-HomeAddress <IMicrosoftGraphPhysicalAddress>] [-HomePhones <String[]>] [-Id <String>]
 [-ImAddresses <String[]>] [-Initials <String>] [-JobTitle <String>] [-LastModifiedDateTime <DateTime>]
 [-Manager <String>] [-MiddleName <String>] [-MobilePhone <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>] [-NickName <String>]
 [-OfficeLocation <String>] [-OtherAddress <IMicrosoftGraphPhysicalAddress>] [-ParentFolderId <String>]
 [-PersonalNotes <String>] [-Photo <IMicrosoftGraphProfilePhoto>] [-Profession <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-SpouseName <String>]
 [-Surname <String>] [-Title <String>] [-YomiCompanyName <String>] [-YomiGivenName <String>]
 [-YomiSurname <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The user's contacts.
Read-only.
Nullable.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
contact
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessAddress
physicalAddress
To construct, please use Get-Help -Online and see NOTES section for BUSINESSADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessHomePage
The business home page of the contact.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessPhones
The contact's business phone numbers.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Categories
The categories associated with the item

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContactId
key: id of contact

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddresses
The contact's email addresses.
To construct, please use Get-Help -Online and see NOTES section for EMAILADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailAddress[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HomeAddress
physicalAddress
To construct, please use Get-Help -Online and see NOTES section for HOMEADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HomePhones
The contact's home phone numbers.

```yaml
Type: System.String[]
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImAddresses
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Initials
.

```yaml
Type: System.String
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JobTitle
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manager
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MiddleName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobilePhone
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NickName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeLocation
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OtherAddress
physicalAddress
To construct, please use Get-Help -Online and see NOTES section for OTHERADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentFolderId
.

```yaml
Type: System.String
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonalNotes
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Photo
profilePhoto
To construct, please use Get-Help -Online and see NOTES section for PHOTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Profession
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpouseName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
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
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiCompanyName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiGivenName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -YomiSurname
.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact

### Microsoft.Graph.PowerShell.Models.IPersonalContactsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphContact>: contact
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Id <String>]`: Read-only.
  - `[AssistantName <String>]`: The name of the contact's assistant.
  - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[BusinessAddress <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[BusinessHomePage <String>]`: The business home page of the contact.
  - `[BusinessPhones <String[]>]`: The contact's business phone numbers.
  - `[Children <String[]>]`: The names of the contact's children.
  - `[CompanyName <String>]`: The name of the contact's company.
  - `[Department <String>]`: The contact's department.
  - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
  - `[EmailAddresses <IMicrosoftGraphEmailAddress[]>]`: The contact's email addresses.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[FileAs <String>]`: The name the contact is filed under.
  - `[Generation <String>]`: The contact's generation.
  - `[GivenName <String>]`: The contact's given name.
  - `[HomeAddress <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
  - `[HomePhones <String[]>]`: The contact's home phone numbers.
  - `[ImAddresses <String[]>]`: 
  - `[Initials <String>]`: 
  - `[JobTitle <String>]`: 
  - `[Manager <String>]`: 
  - `[MiddleName <String>]`: 
  - `[MobilePhone <String>]`: 
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[NickName <String>]`: 
  - `[OfficeLocation <String>]`: 
  - `[OtherAddress <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
  - `[ParentFolderId <String>]`: 
  - `[PersonalNotes <String>]`: 
  - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Height <Int32?>]`: The height of the photo. Read-only.
    - `[Width <Int32?>]`: The width of the photo. Read-only.
  - `[Profession <String>]`: 
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[SpouseName <String>]`: 
  - `[Surname <String>]`: 
  - `[Title <String>]`: 
  - `[YomiCompanyName <String>]`: 
  - `[YomiGivenName <String>]`: 
  - `[YomiSurname <String>]`: 

BUSINESSADDRESS <IMicrosoftGraphPhysicalAddress>: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

EMAILADDRESSES <IMicrosoftGraphEmailAddress[]>: The contact's email addresses.
  - `[Address <String>]`: The email address of the person or entity.
  - `[Name <String>]`: The display name of the person or entity.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.

HOMEADDRESS <IMicrosoftGraphPhysicalAddress>: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

INPUTOBJECT <IPersonalContactsIdentity>: Identity Parameter
  - `[ContactFolderId <String>]`: key: id of contactFolder
  - `[ContactFolderId1 <String>]`: key: id of contactFolder
  - `[ContactId <String>]`: key: id of contact
  - `[ExtensionId <String>]`: key: id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: id of user

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

OTHERADDRESS <IMicrosoftGraphPhysicalAddress>: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

PHOTO <IMicrosoftGraphProfilePhoto>: profilePhoto
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Height <Int32?>]`: The height of the photo. Read-only.
  - `[Width <Int32?>]`: The width of the photo. Read-only.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

