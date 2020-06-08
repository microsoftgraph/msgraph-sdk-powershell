---
external help file:
Module Name: Microsoft.Graph.Users.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.people/update-mguserperson
schema: 2.0.0
---

# Update-MgUserPerson

## SYNOPSIS
Update the navigation property people in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserPerson -PersonId <String> -UserId <String> [-Birthday <String>] [-CompanyName <String>]
 [-Department <String>] [-DisplayName <String>] [-EmailAddresses <IMicrosoftGraphRankedEmailAddress[]>]
 [-GivenName <String>] [-Id <String>] [-IsFavorite] [-MailboxType <String>] [-OfficeLocation <String>]
 [-PersonNotes <String>] [-PersonType <String>] [-Phones <IMicrosoftGraphPhone1[]>]
 [-PostalAddresses <IMicrosoftGraphLocation1[]>] [-Profession <String>]
 [-Sources <IMicrosoftGraphPersonDataSource[]>] [-Surname <String>] [-Title <String>]
 [-UserPrincipalName <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-YomiCompany <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserPerson -PersonId <String> -UserId <String> -BodyParameter <IMicrosoftGraphPerson1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserPerson -InputObject <IUsersPeopleIdentity> -BodyParameter <IMicrosoftGraphPerson1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserPerson -InputObject <IUsersPeopleIdentity> [-Birthday <String>] [-CompanyName <String>]
 [-Department <String>] [-DisplayName <String>] [-EmailAddresses <IMicrosoftGraphRankedEmailAddress[]>]
 [-GivenName <String>] [-Id <String>] [-IsFavorite] [-MailboxType <String>] [-OfficeLocation <String>]
 [-PersonNotes <String>] [-PersonType <String>] [-Phones <IMicrosoftGraphPhone1[]>]
 [-PostalAddresses <IMicrosoftGraphLocation1[]>] [-Profession <String>]
 [-Sources <IMicrosoftGraphPersonDataSource[]>] [-Surname <String>] [-Title <String>]
 [-UserPrincipalName <String>] [-Websites <IMicrosoftGraphWebsite[]>] [-YomiCompany <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property people in users

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

### -Birthday
The person's birthday.

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

### -BodyParameter
person
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPerson1
Parameter Sets: Update, UpdateViaIdentity
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
The person's display name.

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
.
To construct, see NOTES section for EMAILADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRankedEmailAddress[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersPeopleIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailboxType
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
The location of the person's office.

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

### -PersonId
key: person-id of person

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

### -PersonNotes
Free-form notes that the user has taken about this person.

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

### -PersonType
The type of person.

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

### -Phones
The person's phone numbers.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocation1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonDataSource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
key: user-id of user

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

### -UserPrincipalName
The user principal name (UPN) of the person.
The UPN is an Internet-style login name for the person based on the Internet standard RFC 822.
By convention, this should map to the person's email name.
The general format is alias@domain.

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

### -Websites
The person's websites.
To construct, see NOTES section for WEBSITES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWebsite[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPerson1

### Microsoft.Graph.PowerShell.Models.IUsersPeopleIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPerson1>: person
  - `[Id <String>]`: Read-only.
  - `[Birthday <String>]`: The person's birthday.
  - `[CompanyName <String>]`: The name of the person's company.
  - `[Department <String>]`: The person's department.
  - `[DisplayName <String>]`: The person's display name.
  - `[EmailAddresses <IMicrosoftGraphRankedEmailAddress[]>]`: 
    - `[Address <String>]`: 
    - `[Rank <Double?>]`: 
  - `[GivenName <String>]`: The person's given name.
  - `[IsFavorite <Boolean?>]`: true if the user has flagged this person as a favorite.
  - `[MailboxType <String>]`: 
  - `[OfficeLocation <String>]`: The location of the person's office.
  - `[PersonNotes <String>]`: Free-form notes that the user has taken about this person.
  - `[PersonType <String>]`: The type of person.
  - `[Phones <IMicrosoftGraphPhone1[]>]`: The person's phone numbers.
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[PostalAddresses <IMicrosoftGraphLocation1[]>]`: The person's addresses.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostOfficeBox <String>]`: 
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[AddressType <String>]`: physicalAddressType
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[Profession <String>]`: The person's profession.
  - `[Sources <IMicrosoftGraphPersonDataSource[]>]`: 
    - `[Type <String>]`: 
  - `[Surname <String>]`: The person's surname.
  - `[Title <String>]`: 
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
  - `[Websites <IMicrosoftGraphWebsite[]>]`: The person's websites.
    - `[Address <String>]`: The URL of the website.
    - `[DisplayName <String>]`: The display name of the web site.
    - `[Type <String>]`: websiteType
  - `[YomiCompany <String>]`: The phonetic Japanese name of the person's company.

EMAILADDRESSES <IMicrosoftGraphRankedEmailAddress[]>: .
  - `[Address <String>]`: 
  - `[Rank <Double?>]`: 

INPUTOBJECT <IUsersPeopleIdentity>: Identity Parameter
  - `[PersonId <String>]`: key: person-id of person
  - `[UserId <String>]`: key: user-id of user

PHONES <IMicrosoftGraphPhone1[]>: The person's phone numbers.
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

POSTALADDRESSES <IMicrosoftGraphLocation1[]>: The person's addresses.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostOfficeBox <String>]`: 
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AddressType <String>]`: physicalAddressType
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[DisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[UniqueId <String>]`: For internal use only.
  - `[UniqueIdType <String>]`: locationUniqueIdType

SOURCES <IMicrosoftGraphPersonDataSource[]>: .
  - `[Type <String>]`: 

WEBSITES <IMicrosoftGraphWebsite[]>: The person's websites.
  - `[Address <String>]`: The URL of the website.
  - `[DisplayName <String>]`: The display name of the web site.
  - `[Type <String>]`: websiteType

## RELATED LINKS

