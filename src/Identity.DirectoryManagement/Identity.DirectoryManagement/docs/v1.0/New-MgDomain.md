---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdomain
schema: 2.0.0
---

# New-MgDomain

## SYNOPSIS
Add new entity to domains

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDomain [-AdditionalProperties <Hashtable>] [-AuthenticationType <String>] [-AvailabilityStatus <String>]
 [-DomainNameReferences <IMicrosoftGraphDirectoryObject[]>] [-Id <String>] [-IsAdminManaged] [-IsDefault]
 [-IsInitial] [-IsRoot] [-IsVerified] [-Manufacturer <String>] [-Model <String>]
 [-PasswordNotificationWindowInDays <Int32>] [-PasswordValidityPeriodInDays <Int32>]
 [-ServiceConfigurationRecords <IMicrosoftGraphDomainDnsRecord[]>] [-State <IMicrosoftGraphDomainState>]
 [-SupportedServices <String[]>] [-VerificationDnsRecords <IMicrosoftGraphDomainDnsRecord[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDomain -BodyParameter <IMicrosoftGraphDomain> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to domains

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

### -AuthenticationType
Indicates the configured authentication type for the domain.
The value is either Managed or Federated.
Managed indicates a cloud managed domain where Azure AD performs user authentication.
Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services.
This property is read-only and is not nullable.

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

### -AvailabilityStatus
This property is always null except when the verify action is used.
When the verify action is used, a domain entity is returned in the response.
The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.

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

### -BodyParameter
domain
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomain
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DomainNameReferences
Read-only, Nullable
To construct, please use Get-Help -Online and see NOTES section for DOMAINNAMEREFERENCES properties and create a hash table.

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

### -IsAdminManaged
The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365.
Otherwise, the value is true.
Not nullable

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

### -IsDefault
true if this is the default domain that is used for user creation.
There is only one default domain per company.
Not nullable

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

### -IsInitial
true if this is the initial domain created by Microsoft Online Services (companyname.onmicrosoft.com).
There is only one initial domain per company.
Not nullable

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

### -IsRoot
true if the domain is a verified root domain.
Otherwise, false if the domain is a subdomain or unverified.
Not nullable

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

### -IsVerified
true if the domain has completed domain ownership verification.
Not nullable

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

### -Manufacturer
.

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

### -Model
.

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

### -PasswordNotificationWindowInDays
Specifies the number of days before a user receives notification that their password will expire.
If the property is not set, a default value of 14 days will be used.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordValidityPeriodInDays
Specifies the length of time that a password is valid before it must be changed.
If the property is not set, a default value of 90 days will be used.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceConfigurationRecords
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable
To construct, please use Get-Help -Online and see NOTES section for SERVICECONFIGURATIONRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainDnsRecord[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
domainState
To construct, please use Get-Help -Online and see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainState
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedServices
The capabilities assigned to the domain.
Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.
The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer.
Not nullable

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

### -VerificationDnsRecords
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable
To construct, please use Get-Help -Online and see NOTES section for VERIFICATIONDNSRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomainDnsRecord[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomain

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDomain

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDomain>: domain
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AuthenticationType <String>]`: Indicates the configured authentication type for the domain. The value is either Managed or Federated. Managed indicates a cloud managed domain where Azure AD performs user authentication. Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services. This property is read-only and is not nullable.
  - `[AvailabilityStatus <String>]`: This property is always null except when the verify action is used. When the verify action is used, a domain entity is returned in the response. The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.
  - `[DomainNameReferences <IMicrosoftGraphDirectoryObject[]>]`: Read-only, Nullable
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[IsAdminManaged <Boolean?>]`: The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365. Otherwise, the value is true. Not nullable
  - `[IsDefault <Boolean?>]`: true if this is the default domain that is used for user creation. There is only one default domain per company. Not nullable
  - `[IsInitial <Boolean?>]`: true if this is the initial domain created by Microsoft Online Services (companyname.onmicrosoft.com). There is only one initial domain per company. Not nullable
  - `[IsRoot <Boolean?>]`: true if the domain is a verified root domain. Otherwise, false if the domain is a subdomain or unverified. Not nullable
  - `[IsVerified <Boolean?>]`: true if the domain has completed domain ownership verification. Not nullable
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[PasswordNotificationWindowInDays <Int32?>]`: Specifies the number of days before a user receives notification that their password will expire. If the property is not set, a default value of 14 days will be used.
  - `[PasswordValidityPeriodInDays <Int32?>]`: Specifies the length of time that a password is valid before it must be changed. If the property is not set, a default value of 90 days will be used.
  - `[ServiceConfigurationRecords <IMicrosoftGraphDomainDnsRecord[]>]`: DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable
    - `[Id <String>]`: Read-only.
    - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
    - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
    - `[RecordType <String>]`: Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey
    - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune
    - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable
  - `[State <IMicrosoftGraphDomainState>]`: domainState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastActionDateTime <DateTime?>]`: Timestamp for when the last activity occurred. The value is updated when an operation is scheduled, the asynchronous task starts, and when the operation completes.
    - `[Operation <String>]`: Type of asynchronous operation. The values can be ForceDelete or Verification
    - `[Status <String>]`: Current status of the operation.  Scheduled - Operation has been scheduled but has not started.  InProgress - Task has started and is in progress.  Failed - Operation has failed.
  - `[SupportedServices <String[]>]`: The capabilities assigned to the domain. Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune. The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer. Not nullable
  - `[VerificationDnsRecords <IMicrosoftGraphDomainDnsRecord[]>]`: DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD. Read-only, Nullable

DOMAINNAMEREFERENCES <IMicrosoftGraphDirectoryObject[]>: Read-only, Nullable
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

SERVICECONFIGURATIONRECORDS <IMicrosoftGraphDomainDnsRecord[]>: DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable
  - `[Id <String>]`: Read-only.
  - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
  - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
  - `[RecordType <String>]`: Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey
  - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune
  - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable

STATE <IMicrosoftGraphDomainState>: domainState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastActionDateTime <DateTime?>]`: Timestamp for when the last activity occurred. The value is updated when an operation is scheduled, the asynchronous task starts, and when the operation completes.
  - `[Operation <String>]`: Type of asynchronous operation. The values can be ForceDelete or Verification
  - `[Status <String>]`: Current status of the operation.  Scheduled - Operation has been scheduled but has not started.  InProgress - Task has started and is in progress.  Failed - Operation has failed.

VERIFICATIONDNSRECORDS <IMicrosoftGraphDomainDnsRecord[]>: DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD. Read-only, Nullable
  - `[Id <String>]`: Read-only.
  - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
  - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
  - `[RecordType <String>]`: Indicates what type of DNS record this entity represents.The value can be one of the following: CName, Mx, Srv, TxtKey
  - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record.Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune
  - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable

## RELATED LINKS

