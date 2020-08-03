---
external help file:
Module Name: Microsoft.Graph.Identity.OrganizationContacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.organizationcontacts/new-mgcontact
schema: 2.0.0
---

# New-MgContact

## SYNOPSIS
Add new entity to contacts

## SYNTAX

### CreateExpanded (Default)
```
New-MgContact [-Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>] [-CompanyName <String>]
 [-DeletedDateTime <DateTime>] [-Department <String>] [-DirectReports <IMicrosoftGraphDirectoryObject[]>]
 [-DisplayName <String>] [-GivenName <String>] [-Id <String>] [-JobTitle <String>] [-Mail <String>]
 [-MailNickname <String>] [-Manager <IMicrosoftGraphDirectoryObject>]
 [-MemberOf <IMicrosoftGraphDirectoryObject[]>] [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>] [-OnPremisesSyncEnabled]
 [-Phones <IMicrosoftGraphPhone1[]>] [-ProxyAddresses <String[]>] [-Surname <String>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgContact -BodyParameter <IMicrosoftGraphOrgContact1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to contacts

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

### -Addresses
.
To construct, see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalOfficeAddress[]
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectReports
.
To construct, see NOTES section for DIRECTREPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
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
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobTitle
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mail
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailNickname
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberOf
.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesProvisioningErrors
.
To construct, see NOTES section for ONPREMISESPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesProvisioningError[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAddresses
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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


ADDRESSES <IMicrosoftGraphPhysicalOfficeAddress[]>: .
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.

BODYPARAMETER <IMicrosoftGraphOrgContact1>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Addresses <IMicrosoftGraphPhysicalOfficeAddress[]>]`: 
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[CompanyName <String>]`: 
  - `[Department <String>]`: 
  - `[DirectReports <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[GivenName <String>]`: 
  - `[JobTitle <String>]`: 
  - `[Mail <String>]`: 
  - `[MailNickname <String>]`: 
  - `[Manager <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: 
  - `[OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]`: 
    - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
    - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
    - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
    - `[Value <String>]`: Value of the property causing the error.
  - `[OnPremisesSyncEnabled <Boolean?>]`: 
  - `[Phones <IMicrosoftGraphPhone1[]>]`: 
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType
  - `[ProxyAddresses <String[]>]`: 
  - `[Surname <String>]`: 
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 

DIRECTREPORTS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

MANAGER <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

MEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

ONPREMISESPROVISIONINGERRORS <IMicrosoftGraphOnPremisesProvisioningError[]>: .
  - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
  - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
  - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
  - `[Value <String>]`: Value of the property causing the error.

PHONES <IMicrosoftGraphPhone1[]>: .
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

## RELATED LINKS

