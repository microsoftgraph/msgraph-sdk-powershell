---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapprelationship
schema: 2.0.0
---

# Update-MgDeviceAppMgtMobileAppRelationship

## SYNOPSIS
Update the navigation property relationships in deviceAppManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppMgtMobileAppRelationship -MobileAppId <String> -MobileAppRelationshipId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-TargetDisplayName <String>]
 [-TargetDisplayVersion <String>] [-TargetId <String>] [-TargetPublisher <String>] [-TargetType <String>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppMgtMobileAppRelationship -MobileAppId <String> -MobileAppRelationshipId <String>
 -BodyParameter <IMicrosoftGraphMobileAppRelationship> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppMgtMobileAppRelationship -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-TargetDisplayName <String>]
 [-TargetDisplayVersion <String>] [-TargetId <String>] [-TargetPublisher <String>] [-TargetType <String>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppMgtMobileAppRelationship -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphMobileAppRelationship> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property relationships in deviceAppManagement

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Describes a relationship between two mobile apps.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppRelationship
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
Type: IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MobileAppId
key: id of mobileApp

```yaml
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppRelationshipId
key: id of mobileAppRelationship

```yaml
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetDisplayName
The target mobile app's display name.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetDisplayVersion
The target mobile app's display version.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetId
The target mobile app's app id.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetPublisher
The target mobile app's publisher.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetType
mobileAppRelationshipType

```yaml
Type: String
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppRelationship
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphMobileAppRelationship\>: Describes a relationship between two mobile apps.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[TargetDisplayName \<String\>\]: The target mobile app's display name.
  \[TargetDisplayVersion \<String\>\]: The target mobile app's display version.
  \[TargetId \<String\>\]: The target mobile app's app id.
  \[TargetPublisher \<String\>\]: The target mobile app's publisher.
  \[TargetType \<String\>\]: mobileAppRelationshipType

INPUTOBJECT \<IDevicesCorporateManagementIdentity\>: Identity Parameter
  \[AndroidManagedAppProtectionId \<String\>\]: key: id of androidManagedAppProtection
  \[AppLogCollectionRequestId \<String\>\]: key: id of appLogCollectionRequest
  \[BundleId \<String\>\]: 
  \[Count \<Int64?\>\]: 
  \[DefaultManagedAppProtectionId \<String\>\]: key: id of defaultManagedAppProtection
  \[DeviceAppManagementTaskId \<String\>\]: key: id of deviceAppManagementTask
  \[DeviceCompliancePolicyStateId \<String\>\]: key: id of deviceCompliancePolicyState
  \[DeviceConfigurationStateId \<String\>\]: key: id of deviceConfigurationState
  \[DeviceEnrollmentConfigurationId \<String\>\]: key: id of deviceEnrollmentConfiguration
  \[DeviceId \<String\>\]: 
  \[DeviceInstallStateId \<String\>\]: key: id of deviceInstallState
  \[DeviceLogCollectionResponseId \<String\>\]: key: id of deviceLogCollectionResponse
  \[DeviceManagementTroubleshootingEventId \<String\>\]: key: id of deviceManagementTroubleshootingEvent
  \[EnrollmentConfigurationAssignmentId \<String\>\]: key: id of enrollmentConfigurationAssignment
  \[EnterpriseCodeSigningCertificateId \<String\>\]: key: id of enterpriseCodeSigningCertificate
  \[IosLobAppProvisioningConfigurationAssignmentId \<String\>\]: key: id of iosLobAppProvisioningConfigurationAssignment
  \[IosLobAppProvisioningConfigurationId \<String\>\]: key: id of iosLobAppProvisioningConfiguration
  \[IosManagedAppProtectionId \<String\>\]: key: id of iosManagedAppProtection
  \[ManagedAppOperationId \<String\>\]: key: id of managedAppOperation
  \[ManagedAppPolicyId \<String\>\]: key: id of managedAppPolicy
  \[ManagedAppRegistrationId \<String\>\]: key: id of managedAppRegistration
  \[ManagedAppStatusId \<String\>\]: key: id of managedAppStatus
  \[ManagedDeviceId \<String\>\]: key: id of managedDevice
  \[ManagedDeviceMobileAppConfigurationAssignmentId \<String\>\]: key: id of managedDeviceMobileAppConfigurationAssignment
  \[ManagedDeviceMobileAppConfigurationDeviceStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  \[ManagedDeviceMobileAppConfigurationId \<String\>\]: key: id of managedDeviceMobileAppConfiguration
  \[ManagedDeviceMobileAppConfigurationStateId \<String\>\]: key: id of managedDeviceMobileAppConfigurationState
  \[ManagedDeviceMobileAppConfigurationUserStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationUserStatus
  \[ManagedEBookAssignmentId \<String\>\]: key: id of managedEBookAssignment
  \[ManagedEBookCategoryId \<String\>\]: key: id of managedEBookCategory
  \[ManagedEBookId \<String\>\]: key: id of managedEBook
  \[ManagedMobileAppId \<String\>\]: key: id of managedMobileApp
  \[MdmWindowsInformationProtectionPolicyId \<String\>\]: key: id of mdmWindowsInformationProtectionPolicy
  \[MobileAppAssignmentId \<String\>\]: key: id of mobileAppAssignment
  \[MobileAppCategoryId \<String\>\]: key: id of mobileAppCategory
  \[MobileAppId \<String\>\]: key: id of mobileApp
  \[MobileAppInstallStatusId \<String\>\]: key: id of mobileAppInstallStatus
  \[MobileAppIntentAndStateId \<String\>\]: key: id of mobileAppIntentAndState
  \[MobileAppProvisioningConfigGroupAssignmentId \<String\>\]: key: id of mobileAppProvisioningConfigGroupAssignment
  \[MobileAppRelationshipId \<String\>\]: key: id of mobileAppRelationship
  \[MobileAppTroubleshootingEventId \<String\>\]: key: id of mobileAppTroubleshootingEvent
  \[OfficeClientConfigurationAssignmentId \<String\>\]: key: id of officeClientConfigurationAssignment
  \[OfficeClientConfigurationId \<String\>\]: key: id of officeClientConfiguration
  \[PolicySetAssignmentId \<String\>\]: key: id of policySetAssignment
  \[PolicySetId \<String\>\]: key: id of policySet
  \[PolicySetItemId \<String\>\]: key: id of policySetItem
  \[SecurityBaselineSettingStateId \<String\>\]: key: id of securityBaselineSettingState
  \[SecurityBaselineStateId \<String\>\]: key: id of securityBaselineState
  \[SideLoadingKeyId \<String\>\]: key: id of sideLoadingKey
  \[Status \<String\>\]: 
  \[TargetedManagedAppConfigurationId \<String\>\]: key: id of targetedManagedAppConfiguration
  \[TargetedManagedAppPolicyAssignmentId \<String\>\]: key: id of targetedManagedAppPolicyAssignment
  \[UserAppInstallStatusId \<String\>\]: key: id of userAppInstallStatus
  \[UserId \<String\>\]: key: id of user
  \[UserId1 \<String\>\]: key: id of user
  \[UserInstallStateSummaryId \<String\>\]: key: id of userInstallStateSummary
  \[UserPrincipalName \<String\>\]: 
  \[VppTokenId \<String\>\]: key: id of vppToken
  \[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  \[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  \[WindowsDefenderApplicationControlSupplementalPolicyId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicy
  \[WindowsDeviceMalwareStateId \<String\>\]: key: id of windowsDeviceMalwareState
  \[WindowsInformationProtectionDeviceRegistrationId \<String\>\]: key: id of windowsInformationProtectionDeviceRegistration
  \[WindowsInformationProtectionPolicyId \<String\>\]: key: id of windowsInformationProtectionPolicy
  \[WindowsInformationProtectionWipeActionId \<String\>\]: key: id of windowsInformationProtectionWipeAction

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapprelationship](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapprelationship)

