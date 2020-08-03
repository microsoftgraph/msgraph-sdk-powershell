---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/update-mgdeviceappmanagementmultiplepolicyset
schema: 2.0.0
---

# Update-MgDeviceAppManagementMultiplePolicySet

## SYNOPSIS
Invoke action update

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppManagementMultiplePolicySet -PolicySetId <String>
 [-AddedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-Assignments <IMicrosoftGraphPolicySetAssignment[]>]
 [-DeletedPolicySetItems <String[]>] [-UpdatedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppManagementMultiplePolicySet -PolicySetId <String>
 -BodyParameter <IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppManagementMultiplePolicySet -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 -BodyParameter <IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppManagementMultiplePolicySet -InputObject <IDevicesAppsDeviceAppManagementIdentity>
 [-AddedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-Assignments <IMicrosoftGraphPolicySetAssignment[]>]
 [-DeletedPolicySetItems <String[]>] [-UpdatedPolicySetItems <IMicrosoftGraphPolicySetItem[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action update

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

### -AddedPolicySetItems
.
To construct, see NOTES section for ADDEDPOLICYSETITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySetItem[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySetAssignment[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedPolicySetItems
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PolicySetId
key: policySet-id of policySet

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatedPolicySetItems
.
To construct, see NOTES section for UPDATEDPOLICYSETITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySetItem[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IDevicesAppsDeviceAppManagementIdentity

### Microsoft.Graph.PowerShell.Models.IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDEDPOLICYSETITEMS <IMicrosoftGraphPolicySetItem[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySetItem.
  - `[DisplayName <String>]`: DisplayName of the PolicySetItem.
  - `[ErrorCode <String>]`: errorCode
  - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
  - `[ItemType <String>]`: policySetType of the PolicySetItem.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetItem.
  - `[PayloadId <String>]`: PayloadId of the PolicySetItem.
  - `[Status <String>]`: policySetStatus

ASSIGNMENTS <IMicrosoftGraphPolicySetAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetAssignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IPathsNb5PtwDeviceappmanagementPolicysetsPolicysetIdMicrosoftGraphUpdatePostRequestbodyContentApplicationJsonSchema>: .
  - `[AddedPolicySetItems <IMicrosoftGraphPolicySetItem[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySetItem.
    - `[DisplayName <String>]`: DisplayName of the PolicySetItem.
    - `[ErrorCode <String>]`: errorCode
    - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
    - `[ItemType <String>]`: policySetType of the PolicySetItem.
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetItem.
    - `[PayloadId <String>]`: PayloadId of the PolicySetItem.
    - `[Status <String>]`: policySetStatus
  - `[Assignments <IMicrosoftGraphPolicySetAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetAssignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[DeletedPolicySetItems <String[]>]`: 
  - `[UpdatedPolicySetItems <IMicrosoftGraphPolicySetItem[]>]`: 

INPUTOBJECT <IDevicesAppsDeviceAppManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: key: androidManagedAppProtection-id of androidManagedAppProtection
  - `[BundleId <String>]`: 
  - `[Count <Int64?>]`: 
  - `[DefaultManagedAppProtectionId <String>]`: key: defaultManagedAppProtection-id of defaultManagedAppProtection
  - `[DeviceAppManagementTaskId <String>]`: key: deviceAppManagementTask-id of deviceAppManagementTask
  - `[DeviceId <String>]`: 
  - `[DeviceInstallStateId <String>]`: key: deviceInstallState-id of deviceInstallState
  - `[EnterpriseCodeSigningCertificateId <String>]`: key: enterpriseCodeSigningCertificate-id of enterpriseCodeSigningCertificate
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: key: iosLobAppProvisioningConfigurationAssignment-id of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: key: iosLobAppProvisioningConfiguration-id of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: key: iosManagedAppProtection-id of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: key: managedAppOperation-id of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: key: managedAppPolicy-id of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: key: managedAppRegistration-id of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: key: managedAppStatus-id of managedAppStatus
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: key: managedDeviceMobileAppConfigurationAssignment-id of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: key: managedDeviceMobileAppConfigurationDeviceStatus-id of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: key: managedDeviceMobileAppConfiguration-id of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: key: managedDeviceMobileAppConfigurationUserStatus-id of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: key: managedEBookAssignment-id of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: key: managedEBookCategory-id of managedEBookCategory
  - `[ManagedEBookId <String>]`: key: managedEBook-id of managedEBook
  - `[ManagedMobileAppId <String>]`: key: managedMobileApp-id of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: key: mdmWindowsInformationProtectionPolicy-id of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: key: mobileAppAssignment-id of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: key: mobileAppCategory-id of mobileAppCategory
  - `[MobileAppId <String>]`: key: mobileApp-id of mobileApp
  - `[MobileAppInstallStatusId <String>]`: key: mobileAppInstallStatus-id of mobileAppInstallStatus
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: key: mobileAppProvisioningConfigGroupAssignment-id of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: key: mobileAppRelationship-id of mobileAppRelationship
  - `[PolicySetAssignmentId <String>]`: key: policySetAssignment-id of policySetAssignment
  - `[PolicySetId <String>]`: key: policySet-id of policySet
  - `[PolicySetItemId <String>]`: key: policySetItem-id of policySetItem
  - `[SideLoadingKeyId <String>]`: key: sideLoadingKey-id of sideLoadingKey
  - `[Status <String>]`: 
  - `[TargetedManagedAppConfigurationId <String>]`: key: targetedManagedAppConfiguration-id of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: key: targetedManagedAppPolicyAssignment-id of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: key: userAppInstallStatus-id of userAppInstallStatus
  - `[UserInstallStateSummaryId <String>]`: key: userInstallStateSummary-id of userInstallStateSummary
  - `[UserPrincipalName <String>]`: 
  - `[VppTokenId <String>]`: key: vppToken-id of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicyAssignment-id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus-id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: key: windowsDefenderApplicationControlSupplementalPolicy-id of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: windowsInformationProtectionDeviceRegistration-id of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: key: windowsInformationProtectionPolicy-id of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: key: windowsInformationProtectionWipeAction-id of windowsInformationProtectionWipeAction

UPDATEDPOLICYSETITEMS <IMicrosoftGraphPolicySetItem[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: Creation time of the PolicySetItem.
  - `[DisplayName <String>]`: DisplayName of the PolicySetItem.
  - `[ErrorCode <String>]`: errorCode
  - `[GuidedDeploymentTags <String[]>]`: Tags of the guided deployment
  - `[ItemType <String>]`: policySetType of the PolicySetItem.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the PolicySetItem.
  - `[PayloadId <String>]`: PayloadId of the PolicySetItem.
  - `[Status <String>]`: policySetStatus

## RELATED LINKS

