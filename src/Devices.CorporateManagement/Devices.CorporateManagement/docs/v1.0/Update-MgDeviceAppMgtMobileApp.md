---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapp
schema: 2.0.0
---

# Update-MgDeviceAppMgtMobileApp

## SYNOPSIS
Update the navigation property mobileApps in deviceAppManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppMgtMobileApp -MobileAppId <String> [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphMobileAppAssignment1[]>] [-Categories <IMicrosoftGraphMobileAppCategory[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-Developer <String>] [-DisplayName <String>]
 [-Id <String>] [-InformationUrl <String>] [-IsFeatured] [-LargeIcon <IMicrosoftGraphMimeContent>]
 [-LastModifiedDateTime <DateTime>] [-Notes <String>] [-Owner <String>] [-PrivacyInformationUrl <String>]
 [-Publisher <String>] [-PublishingState <MobileAppPublishingState>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppMgtMobileApp -MobileAppId <String> -BodyParameter <IMicrosoftGraphMobileApp1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppMgtMobileApp -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphMobileApp1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppMgtMobileApp -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphMobileAppAssignment1[]>]
 [-Categories <IMicrosoftGraphMobileAppCategory[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-Developer <String>] [-DisplayName <String>] [-Id <String>] [-InformationUrl <String>] [-IsFeatured]
 [-LargeIcon <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>] [-Notes <String>]
 [-Owner <String>] [-PrivacyInformationUrl <String>] [-Publisher <String>]
 [-PublishingState <MobileAppPublishingState>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property mobileApps in deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignments for this mobile app.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppAssignment1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class containing the base properties for Intune mobile apps.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The list of categories for this app.
To construct, please use Get-Help -Online and see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppCategory[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the app was created.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Developer
The developer of the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The admin provided or imported title of the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InformationUrl
The more information Url.

```yaml
Type: System.String
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsFeatured
The value indicating whether the app is marked as featured by the admin.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeIcon
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for LARGEICON properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time the app was last modified.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppId
key: id of mobileApp

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

### -Notes
Notes for the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
The owner of the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -PrivacyInformationUrl
The privacy statement Url.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publisher
The publisher of the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingState
Indicates the publishing state of an app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.MobileAppPublishingState
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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgDeviceAppManagementMobileApp

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphMobileAppAssignment1[]>: The list of group assignments for this mobile app.
  - `[Id <String>]`: 
  - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
  - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphMobileApp1>: An abstract class containing the base properties for Intune mobile apps.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
    - `[Id <String>]`: 
    - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
    - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
  - `[Description <String>]`: The description of the app.
  - `[Developer <String>]`: The developer of the app.
  - `[DisplayName <String>]`: The admin provided or imported title of the app.
  - `[InformationUrl <String>]`: The more information Url.
  - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
  - `[LargeIcon <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
  - `[Notes <String>]`: Notes for the app.
  - `[Owner <String>]`: The owner of the app.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[Publisher <String>]`: The publisher of the app.
  - `[PublishingState <MobileAppPublishingState?>]`: Indicates the publishing state of an app.

CATEGORIES <IMicrosoftGraphMobileAppCategory[]>: The list of categories for this app.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the app category.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.

INPUTOBJECT <IDevicesCorporateManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: key: id of androidManagedAppProtection
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: key: id of assignmentFilterEvaluationStatusDetails
  - `[BundleId <String>]`: Usage: bundleId='{bundleId}'
  - `[Count <Int64?>]`: Usage: count={count}
  - `[DefaultManagedAppProtectionId <String>]`: key: id of defaultManagedAppProtection
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAppManagementTaskId <String>]`: key: id of deviceAppManagementTask
  - `[DeviceCompliancePolicyStateId <String>]`: key: id of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: key: id of deviceConfigurationState
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: Usage: deviceId='{deviceId}'
  - `[DeviceInstallStateId <String>]`: key: id of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: key: id of deviceManagementTroubleshootingEvent
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnterpriseCodeSigningCertificateId <String>]`: key: id of enterpriseCodeSigningCertificate
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: key: id of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: key: id of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: key: id of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: key: id of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: key: id of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: key: id of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: key: id of managedAppStatus
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: key: id of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: key: id of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: key: id of managedDeviceMobileAppConfigurationState
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: key: id of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: key: id of managedEBookCategory
  - `[ManagedEBookId <String>]`: key: id of managedEBook
  - `[ManagedMobileAppId <String>]`: key: id of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: key: id of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: key: id of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: key: id of mobileAppCategory
  - `[MobileAppId <String>]`: key: id of mobileApp
  - `[MobileAppInstallStatusId <String>]`: key: id of mobileAppInstallStatus
  - `[MobileAppIntentAndStateId <String>]`: key: id of mobileAppIntentAndState
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: key: id of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: key: id of mobileAppRelationship
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: id of officeClientConfiguration
  - `[PolicySetAssignmentId <String>]`: key: id of policySetAssignment
  - `[PolicySetId <String>]`: key: id of policySet
  - `[PolicySetItemId <String>]`: key: id of policySetItem
  - `[SecurityBaselineSettingStateId <String>]`: key: id of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: key: id of securityBaselineState
  - `[SideLoadingKeyId <String>]`: key: id of sideLoadingKey
  - `[Status <String>]`: Usage: status='{status}'
  - `[TargetedManagedAppConfigurationId <String>]`: key: id of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: key: id of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: key: id of userAppInstallStatus
  - `[UserId <String>]`: key: id of user
  - `[UserInstallStateSummaryId <String>]`: key: id of userInstallStateSummary
  - `[UserPrincipalName <String>]`: Usage: userPrincipalName='{userPrincipalName}'
  - `[VppTokenId <String>]`: key: id of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: id of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: key: id of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: key: id of windowsInformationProtectionWipeAction
  - `[WindowsManagedAppProtectionId <String>]`: key: id of windowsManagedAppProtection

LARGEICON <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

