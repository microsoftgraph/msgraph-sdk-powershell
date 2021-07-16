---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgcontact
schema: 2.0.0
---

# New-MgContact

## SYNOPSIS
Add new entity to contacts

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgContact [-AdditionalProperties <Hashtable>] [-Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>]
 [-CompanyName <String>] [-DeletedDateTime <DateTime>] [-Department <String>]
 [-DirectReports <IMicrosoftGraphDirectoryObject[]>] [-DisplayName <String>] [-GivenName <String>]
 [-Id <String>] [-JobTitle <String>] [-Mail <String>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>] [-OnPremisesSyncEnabled]
 [-Phones <IMicrosoftGraphPhone1[]>] [-ProxyAddresses <String[]>] [-Surname <String>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-TransitiveReports <IMicrosoftGraphDirectoryObject[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgContact -BodyParameter <IMicrosoftGraphOrgContact1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to contacts

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Addresses
Postal addresses for this organizational contact.
For now a contact can only have one physical address.
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalOfficeAddress[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrgContact1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyName
Name of the company that this organizational contact belong to.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
The name for the department in which the contact works.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectReports
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.) Read-only.
Nullable.
To construct, see NOTES section for DIRECTREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for this organizational contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
First name for this organizational contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobTitle
Job title for this organizational contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mail
The SMTP address for the contact, for example, 'jeff@contoso.onmicrosoft.com'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailNickname
Email alias (portion of email address pre-pending the @ symbol) for this organizational contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manager
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for MANAGER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberOf
Groups that this contact is a member of.
Read-only.
Nullable.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
Date and time when this organizational contact was last synchronized from on-premises AD.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesProvisioningErrors
List of any synchronization provisioning errors for this organizational contact.
To construct, see NOTES section for ONPREMISESPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesProvisioningError[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phones
List of phones for this organizational contact.
Phone types can be mobile, business, and businessFax.
Only one of each type can ever be present in the collection.
To construct, see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAddresses
For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'.
The any operator is required for filter expressions on multi-valued properties.
Supports $filter.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
Last name for this organizational contact.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveMemberOf
.
To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveReports
The transitive reports for a contact.
Read-only.
To construct, see NOTES section for TRANSITIVEREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrgContact1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrgContact1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDRESSES <IMicrosoftGraphPhysicalOfficeAddress[]>: Postal addresses for this organizational contact. For now a contact can only have one physical address.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

BODYPARAMETER <IMicrosoftGraphOrgContact1>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>]`: Postal addresses for this organizational contact. For now a contact can only have one physical address.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[CompanyName <String>]`: Name of the company that this organizational contact belong to.
  - `[Department <String>]`: The name for the department in which the contact works.
  - `[DirectReports <IMicrosoftGraphDirectoryObject[]>]`: The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: Display name for this organizational contact.
  - `[GivenName <String>]`: First name for this organizational contact.
  - `[JobTitle <String>]`: Job title for this organizational contact.
  - `[Mail <String>]`: The SMTP address for the contact, for example, 'jeff@contoso.onmicrosoft.com'.
  - `[MailNickname <String>]`: Email alias (portion of email address pre-pending the @ symbol) for this organizational contact.
  - `[Manager <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this contact is a member of. Read-only. Nullable.
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: Date and time when this organizational contact was last synchronized from on-premises AD. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]`: List of any synchronization provisioning errors for this organizational contact.
    - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
    - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
    - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
    - `[Value <String>]`: Value of the property causing the error.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).
  - `[Phones <IMicrosoftGraphPhone1[]>]`: List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection.
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[ProxyAddresses <String[]>]`: For example: 'SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'. The any operator is required for filter expressions on multi-valued properties. Supports $filter.
  - `[Surname <String>]`: Last name for this organizational contact.
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[TransitiveReports <IMicrosoftGraphDirectoryObject[]>]`: The transitive reports for a contact. Read-only.

DIRECTREPORTS <IMicrosoftGraphDirectoryObject[]>: The contact's direct reports. (The users and contacts that have their manager property set to this contact.) Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

MANAGER <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

MEMBEROF <IMicrosoftGraphDirectoryObject[]>: Groups that this contact is a member of. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

ONPREMISESPROVISIONINGERRORS <IMicrosoftGraphOnPremisesProvisioningError[]>: List of any synchronization provisioning errors for this organizational contact.
  - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
  - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
  - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
  - `[Value <String>]`: Value of the property causing the error.

PHONES <IMicrosoftGraphPhone1[]>: List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection.
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

TRANSITIVEREPORTS <IMicrosoftGraphDirectoryObject[]>: The transitive reports for a contact. Read-only.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

## RELATED LINKS

