---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmdmwindowinformationprotectionpolicy
schema: 2.0.0
---

# New-MgDeviceAppMgtMdmWindowInformationProtectionPolicy

## SYNOPSIS
Create new navigation property to mdmWindowsInformationProtectionPolicies for deviceAppManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceAppMgtMdmWindowInformationProtectionPolicy [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>] [-AzureRightsManagementServicesAllowed]
 [-CreatedDateTime <DateTime>]
 [-DataRecoveryCertificate <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>]
 [-Description <String>] [-DisplayName <String>]
 [-EnforcementLevel <WindowsInformationProtectionEnforcementLevel>] [-EnterpriseDomain <String>]
 [-EnterpriseInternalProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-EnterpriseIPRanges <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>]
 [-EnterpriseIPRangesAreAuthoritative]
 [-EnterpriseNetworkDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-EnterpriseProtectedDomainNames <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-EnterpriseProxiedDomains <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>]
 [-EnterpriseProxyServers <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-EnterpriseProxyServersAreAuthoritative]
 [-ExemptAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]
 [-ExemptApps <IMicrosoftGraphWindowsInformationProtectionApp[]>] [-IconsVisible] [-Id <String>]
 [-IndexingEncryptedStoresOrItemsBlocked] [-IsAssigned] [-LastModifiedDateTime <DateTime>]
 [-NeutralDomainResources <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-ProtectedAppLockerFiles <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>]
 [-ProtectedApps <IMicrosoftGraphWindowsInformationProtectionApp[]>] [-ProtectionUnderLockConfigRequired]
 [-RevokeOnUnenrollDisabled] [-RightsManagementServicesTemplateId <String>]
 [-SmbAutoEncryptedFileExtensions <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>]
 [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceAppMgtMdmWindowInformationProtectionPolicy -BodyParameter <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mdmWindowsInformationProtectionPolicies for deviceAppManagement

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

### -Assignments
Navigation property to list of security groups targeted for policy.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureRightsManagementServicesAllowed
Specifies whether to allow Azure RMS encryption for WIP

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

### -BodyParameter
Policy for Windows information protection with MDM

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the policy was created.

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

### -DataRecoveryCertificate
Windows Information Protection DataRecoveryCertificate
To construct, please use Get-Help -Online and see NOTES section for DATARECOVERYCERTIFICATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The policy's description.

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

### -DisplayName
Policy display name.

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

### -EnforcementLevel
Possible values for WIP Protection enforcement levels

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsInformationProtectionEnforcementLevel
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseDomain
Primary enterprise domain

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

### -EnterpriseInternalProxyServers
This is the comma-separated list of internal proxy servers.
For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'.
These proxies have been configured by the admin to connect to specific resources on the Internet.
They are considered to be enterprise network locations.
The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISEINTERNALPROXYSERVERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseIPRanges
Sets the enterprise IP ranges that define the computers in the enterprise network.
Data that comes from those computers will be considered part of the enterprise and protected.
These locations will be considered a safe destination for enterprise data to be shared to
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISEIPRANGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseIPRangesAreAuthoritative
Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets.
Default is false

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

### -EnterpriseNetworkDomainNames
This is the list of domains that comprise the boundaries of the enterprise.
Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISENETWORKDOMAINNAMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseProtectedDomainNames
List of enterprise domains to be protected
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISEPROTECTEDDOMAINNAMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseProxiedDomains
Contains a list of Enterprise resource domains hosted in the cloud that need to be protected.
Connections to these resources are considered enterprise data.
If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80).
A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISEPROXIEDDOMAINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseProxyServers
This is a list of proxy servers.
Any server not on this list is considered non-enterprise
To construct, please use Get-Help -Online and see NOTES section for ENTERPRISEPROXYSERVERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnterpriseProxyServersAreAuthoritative
Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies.
Default is false

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

### -ExemptAppLockerFiles
Another way to input exempt apps through xml files
To construct, please use Get-Help -Online and see NOTES section for EXEMPTAPPLOCKERFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExemptApps
Exempt applications can also access enterprise data, but the data handled by those applications are not protected.
This is because some critical enterprise applications may have compatibility problems with encrypted data.
To construct, please use Get-Help -Online and see NOTES section for EXEMPTAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionApp[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IconsVisible
Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu.
Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app

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

### -Id
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

### -IndexingEncryptedStoresOrItemsBlocked
This switch is for the Windows Search Indexer, to allow or disallow indexing of items

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

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

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

### -LastModifiedDateTime
Last time the policy was modified.

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

### -NeutralDomainResources
List of domain names that can used for work or personal resource
To construct, please use Get-Help -Online and see NOTES section for NEUTRALDOMAINRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectedAppLockerFiles
Another way to input protected apps through xml files
To construct, please use Get-Help -Online and see NOTES section for PROTECTEDAPPLOCKERFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectedApps
Protected applications can access enterprise data and the data handled by those applications are protected with encryption
To construct, please use Get-Help -Online and see NOTES section for PROTECTEDAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionApp[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionUnderLockConfigRequired
Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured

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

### -RevokeOnUnenrollDisabled
This policy controls whether to revoke the WIP keys when a device unenrolls from the management service.
If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment.
If the keys are not revoked, there will be no revoked file cleanup subsequently.

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

### -RightsManagementServicesTemplateId
TemplateID GUID to use for RMS encryption.
The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access

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

### -SmbAutoEncryptedFileExtensions
Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
To construct, please use Get-Help -Online and see NOTES section for SMBAUTOENCRYPTEDFILEEXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsInformationProtectionResourceCollection[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the entity.

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

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMdmWindowsInformationProtectionPolicy1

## NOTES

ALIASES

### New-MgDeviceAppManagementMdmWindowInformationProtectionPolicy

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>: Navigation property to list of security groups targeted for policy.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

DATARECOVERYCERTIFICATE <IMicrosoftGraphWindowsInformationProtectionDataRecoveryCertificate>: Windows Information Protection DataRecoveryCertificate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Certificate <Byte[]>]`: Data recovery Certificate
  - `[Description <String>]`: Data recovery Certificate description
  - `[ExpirationDateTime <DateTime?>]`: Data recovery Certificate expiration datetime
  - `[SubjectName <String>]`: Data recovery Certificate subject name

ENTERPRISEINTERNALPROXYSERVERS <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

ENTERPRISEIPRANGES <IMicrosoftGraphWindowsInformationProtectionIPRangeCollection[]>: Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
  - `[DisplayName <String>]`: Display name
  - `[Ranges <IMicrosoftGraphIPRange[]>]`: Collection of ip ranges

ENTERPRISENETWORKDOMAINNAMES <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

ENTERPRISEPROTECTEDDOMAINNAMES <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: List of enterprise domains to be protected
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

ENTERPRISEPROXIEDDOMAINS <IMicrosoftGraphWindowsInformationProtectionProxiedDomainCollection[]>: Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
  - `[DisplayName <String>]`: Display name
  - `[ProxiedDomains <IMicrosoftGraphProxiedDomain[]>]`: Collection of proxied domains
    - `[IPAddressOrFqdn <String>]`: The IP address or FQDN
    - `[Proxy <String>]`: Proxy IP or FQDN

ENTERPRISEPROXYSERVERS <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: This is a list of proxy servers. Any server not on this list is considered non-enterprise
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

EXEMPTAPPLOCKERFILES <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>: Another way to input exempt apps through xml files
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The friendly name
  - `[File <Byte[]>]`: File as a byte array
  - `[FileHash <String>]`: SHA256 hash of the file
  - `[Version <String>]`: Version of the entity.

EXEMPTAPPS <IMicrosoftGraphWindowsInformationProtectionApp[]>: Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
  - `[Denied <Boolean?>]`: If true, app is denied protection or exemption.
  - `[Description <String>]`: The app's description.
  - `[DisplayName <String>]`: App display name.
  - `[ProductName <String>]`: The product name.
  - `[PublisherName <String>]`: The publisher name

NEUTRALDOMAINRESOURCES <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: List of domain names that can used for work or personal resource
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

PROTECTEDAPPLOCKERFILES <IMicrosoftGraphWindowsInformationProtectionAppLockerFile[]>: Another way to input protected apps through xml files
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The friendly name
  - `[File <Byte[]>]`: File as a byte array
  - `[FileHash <String>]`: SHA256 hash of the file
  - `[Version <String>]`: Version of the entity.

PROTECTEDAPPS <IMicrosoftGraphWindowsInformationProtectionApp[]>: Protected applications can access enterprise data and the data handled by those applications are protected with encryption
  - `[Denied <Boolean?>]`: If true, app is denied protection or exemption.
  - `[Description <String>]`: The app's description.
  - `[DisplayName <String>]`: App display name.
  - `[ProductName <String>]`: The product name.
  - `[PublisherName <String>]`: The publisher name

SMBAUTOENCRYPTEDFILEEXTENSIONS <IMicrosoftGraphWindowsInformationProtectionResourceCollection[]>: Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
  - `[DisplayName <String>]`: Display name
  - `[Resources <String[]>]`: Collection of resources

## RELATED LINKS

