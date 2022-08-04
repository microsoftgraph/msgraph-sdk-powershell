---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointprovisioningpolicy
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointProvisioningPolicy

## SYNOPSIS
Create new navigation property to provisioningPolicies for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointProvisioningPolicy [-AdditionalProperties <Hashtable>]
 [-AlternateResourceUrl <String>] [-Assignments <IMicrosoftGraphCloudPcProvisioningPolicyAssignment[]>]
 [-CloudPcGroupDisplayName <String>] [-Description <String>] [-DisplayName <String>]
 [-DomainJoinConfiguration <IMicrosoftGraphCloudPcDomainJoinConfiguration>] [-GracePeriodInHours <Int32>]
 [-Id <String>] [-ImageDisplayName <String>] [-ImageId <String>] [-ImageType <String>] [-LocalAdminEnabled]
 [-ManagedBy <String>] [-MicrosoftManagedDesktop <IMicrosoftGraphMicrosoftManagedDesktop>]
 [-OnPremisesConnectionId <String>] [-WindowsSettings <IMicrosoftGraphCloudPcWindowsSettings>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointProvisioningPolicy
 -BodyParameter <IMicrosoftGraphCloudPcProvisioningPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to provisioningPolicies for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlternateResourceUrl
The URL of the alternate resource that links to this provisioning policy.
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

### -Assignments
A defined collection of provisioning policy assignments.
Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned.
Returned only on $expand.
See an example of getting the assignments relationship.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcProvisioningPolicyAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcProvisioningPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcProvisioningPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPcGroupDisplayName
The display name of the Cloud PC group that the Cloud PCs reside in.
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

### -Description
The provisioning policy description.

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

### -DisplayName
The display name for the provisioning policy.

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

### -DomainJoinConfiguration
cloudPcDomainJoinConfiguration
To construct, please use Get-Help -Online and see NOTES section for DOMAINJOINCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcDomainJoinConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GracePeriodInHours
The number of hours to wait before reprovisioning/deprovisioning happens.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageDisplayName
The display name for the OS image you’re provisioning.

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

### -ImageId
The ID of the OS image you want to provision on Cloud PCs.
The format for a gallery type image is: {publisher_offer_sku}.
Supported values for each of the parameters are as follows:publisher: Microsoftwindowsdesktop.
offer: windows-ent-cpc.
sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.

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

### -ImageType
cloudPcProvisioningPolicyImageType

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

### -LocalAdminEnabled
Indicates whether the local admin option is enabled.
If the local admin option is enabled, the end user can be an admin of the Cloud PC device.
Read-only.

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

### -ManagedBy
cloudPcManagementService

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

### -MicrosoftManagedDesktop
microsoftManagedDesktop
To construct, please use Get-Help -Online and see NOTES section for MICROSOFTMANAGEDDESKTOP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftManagedDesktop
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesConnectionId
The ID of the cloudPcOnPremisesConnection.
To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.

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

### -WindowsSettings
cloudPcWindowsSettings
To construct, please use Get-Help -Online and see NOTES section for WINDOWSSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcWindowsSettings
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcProvisioningPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcProvisioningPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphCloudPcProvisioningPolicyAssignment[]>: A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned. Returned only on $expand. See an example of getting the assignments relationship.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphCloudPcManagementAssignmentTarget>]`: cloudPcManagementAssignmentTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphCloudPcProvisioningPolicy>: cloudPcProvisioningPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AlternateResourceUrl <String>]`: The URL of the alternate resource that links to this provisioning policy. Read-only.
  - `[Assignments <IMicrosoftGraphCloudPcProvisioningPolicyAssignment[]>]`: A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned. Returned only on $expand. See an example of getting the assignments relationship.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphCloudPcManagementAssignmentTarget>]`: cloudPcManagementAssignmentTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CloudPcGroupDisplayName <String>]`: The display name of the Cloud PC group that the Cloud PCs reside in. Read-only.
  - `[Description <String>]`: The provisioning policy description.
  - `[DisplayName <String>]`: The display name for the provisioning policy.
  - `[DomainJoinConfiguration <IMicrosoftGraphCloudPcDomainJoinConfiguration>]`: cloudPcDomainJoinConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OnPremisesConnectionId <String>]`: The Azure network connection ID that matches the virtual network IT admins want the provisioning policy to use when they create Cloud PCs. You can use this property in both domain join types: Azure AD joined or Hybrid Azure AD joined. If you enter an onPremisesConnectionId, leave regionName as empty.
    - `[RegionName <String>]`: The supported Azure region where the IT admin wants the provisioning policy to create Cloud PCs. The underlying virtual network will be created and managed by the Windows 365 service. This can only be entered if the IT admin chooses Azure AD joined as the domain join type. If you enter a regionName, leave onPremisesConnectionId as empty.
    - `[Type <String>]`: cloudPcDomainJoinType
  - `[GracePeriodInHours <Int32?>]`: The number of hours to wait before reprovisioning/deprovisioning happens. Read-only.
  - `[ImageDisplayName <String>]`: The display name for the OS image you’re provisioning.
  - `[ImageId <String>]`: The ID of the OS image you want to provision on Cloud PCs. The format for a gallery type image is: {publisher_offer_sku}. Supported values for each of the parameters are as follows:publisher: Microsoftwindowsdesktop. offer: windows-ent-cpc. sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.
  - `[ImageType <String>]`: cloudPcProvisioningPolicyImageType
  - `[LocalAdminEnabled <Boolean?>]`: Indicates whether the local admin option is enabled. If the local admin option is enabled, the end user can be an admin of the Cloud PC device. Read-only.
  - `[ManagedBy <String>]`: cloudPcManagementService
  - `[MicrosoftManagedDesktop <IMicrosoftGraphMicrosoftManagedDesktop>]`: microsoftManagedDesktop
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Profile <String>]`: The name of the Microsoft Managed Desktop profile that the Windows 365 Cloud PC is associated with.
    - `[Type <String>]`: microsoftManagedDesktopType
  - `[OnPremisesConnectionId <String>]`: The ID of the cloudPcOnPremisesConnection. To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.
  - `[WindowsSettings <IMicrosoftGraphCloudPcWindowsSettings>]`: cloudPcWindowsSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Language <String>]`: The Windows language/region tag to use for language pack configuration and localization of the Cloud PC. The default value is en-US, which corresponds to English (United States).

DOMAINJOINCONFIGURATION <IMicrosoftGraphCloudPcDomainJoinConfiguration>: cloudPcDomainJoinConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OnPremisesConnectionId <String>]`: The Azure network connection ID that matches the virtual network IT admins want the provisioning policy to use when they create Cloud PCs. You can use this property in both domain join types: Azure AD joined or Hybrid Azure AD joined. If you enter an onPremisesConnectionId, leave regionName as empty.
  - `[RegionName <String>]`: The supported Azure region where the IT admin wants the provisioning policy to create Cloud PCs. The underlying virtual network will be created and managed by the Windows 365 service. This can only be entered if the IT admin chooses Azure AD joined as the domain join type. If you enter a regionName, leave onPremisesConnectionId as empty.
  - `[Type <String>]`: cloudPcDomainJoinType

MICROSOFTMANAGEDDESKTOP <IMicrosoftGraphMicrosoftManagedDesktop>: microsoftManagedDesktop
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Profile <String>]`: The name of the Microsoft Managed Desktop profile that the Windows 365 Cloud PC is associated with.
  - `[Type <String>]`: microsoftManagedDesktopType

WINDOWSSETTINGS <IMicrosoftGraphCloudPcWindowsSettings>: cloudPcWindowsSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Language <String>]`: The Windows language/region tag to use for language pack configuration and localization of the Cloud PC. The default value is en-US, which corresponds to English (United States).

## RELATED LINKS

