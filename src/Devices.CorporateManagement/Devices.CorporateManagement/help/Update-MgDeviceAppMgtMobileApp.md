---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapp
schema: 2.0.0
---

# Update-MgDeviceAppMgtMobileApp

## SYNOPSIS
Update the navigation property mobileApps in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppMgtMobileApp -MobileAppId <String> [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphMobileAppAssignment[]>] [-Categories <IMicrosoftGraphMobileAppCategory[]>]
 [-CreatedDateTime <DateTime>] [-DependentAppCount <Int32>] [-Description <String>] [-Developer <String>]
 [-DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>] [-DisplayName <String>] [-Id <String>]
 [-InformationUrl <String>] [-InstallSummary <IMicrosoftGraphMobileAppInstallSummary>] [-IsAssigned]
 [-IsFeatured] [-LargeIcon <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>] [-Notes <String>]
 [-Owner <String>] [-PrivacyInformationUrl <String>] [-Publisher <String>] [-PublishingState <String>]
 [-Relationships <IMicrosoftGraphMobileAppRelationship[]>] [-RoleScopeTagIds <String[]>]
 [-SupersededAppCount <Int32>] [-SupersedingAppCount <Int32>] [-UploadState <Int32>]
 [-UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgtMobileApp -MobileAppId <String> -BodyParameter <IMicrosoftGraphMobileApp> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppMgtMobileApp -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphMobileAppAssignment[]>]
 [-Categories <IMicrosoftGraphMobileAppCategory[]>] [-CreatedDateTime <DateTime>] [-DependentAppCount <Int32>]
 [-Description <String>] [-Developer <String>] [-DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-InformationUrl <String>]
 [-InstallSummary <IMicrosoftGraphMobileAppInstallSummary>] [-IsAssigned] [-IsFeatured]
 [-LargeIcon <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>] [-Notes <String>]
 [-Owner <String>] [-PrivacyInformationUrl <String>] [-Publisher <String>] [-PublishingState <String>]
 [-Relationships <IMicrosoftGraphMobileAppRelationship[]>] [-RoleScopeTagIds <String[]>]
 [-SupersededAppCount <Int32>] [-SupersedingAppCount <Int32>] [-UploadState <Int32>]
 [-UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppMgtMobileApp -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphMobileApp> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property mobileApps in deviceAppManagement

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignments for this mobile app.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class containing the base properties for Intune mobile apps.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileApp
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The list of categories for this app.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppCategory[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DependentAppCount
The total number of dependencies the child app has.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the app.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
The list of installation states for this mobile app.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppInstallStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InstallSummary
Contains properties for the installation summary of a mobile app.
To construct, see NOTES section for INSTALLSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppInstallSummary
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAssigned
The value indicating whether the app is assigned to at least one group.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFeatured
The value indicating whether the app is marked as featured by the admin.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeIcon
Contains properties for a generic mime content.
To construct, see NOTES section for LARGEICON properties and create a hash table.

```yaml
Type: IMicrosoftGraphMimeContent
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, Update
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivacyInformationUrl
The privacy statement Url.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingState
mobileAppPublishingState

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Relationships
The set of direct relationships for this app.
To construct, see NOTES section for RELATIONSHIPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphMobileAppRelationship[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of scope tag ids for this mobile app.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupersededAppCount
The total number of apps this app is directly or indirectly superseded by.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupersedingAppCount
The total number of apps this app directly or indirectly supersedes.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -UploadState
The upload state.
Possible values are: 0 - `Not Ready`, 1 - `Ready`, 2 - `Processing`.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatuses
The list of installation states for this mobile app.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserAppInstallStatus[]
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNMENTS \<IMicrosoftGraphMobileAppAssignment1\[\]\>: The list of group assignments for this mobile app.
  \[Id \<String\>\]: Read-only.
  \[Intent \<String\>\]: installIntent
  \[Settings \<IMicrosoftGraphMobileAppAssignmentSettings\>\]: Abstract class to contain properties used to assign a mobile app to a group.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphMobileApp1\>: An abstract class containing the base properties for Intune mobile apps.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphMobileAppAssignment1\[\]\>\]: The list of group assignments for this mobile app.
    \[Id \<String\>\]: Read-only.
    \[Intent \<String\>\]: installIntent
    \[Settings \<IMicrosoftGraphMobileAppAssignmentSettings\>\]: Abstract class to contain properties used to assign a mobile app to a group.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Categories \<IMicrosoftGraphMobileAppCategory\[\]\>\]: The list of categories for this app.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: The name of the app category.
    \[LastModifiedDateTime \<DateTime?\>\]: The date and time the mobileAppCategory was last modified.
  \[CreatedDateTime \<DateTime?\>\]: The date and time the app was created.
  \[Description \<String\>\]: The description of the app.
  \[Developer \<String\>\]: The developer of the app.
  \[DisplayName \<String\>\]: The admin provided or imported title of the app.
  \[InformationUrl \<String\>\]: The more information Url.
  \[IsFeatured \<Boolean?\>\]: The value indicating whether the app is marked as featured by the admin.
  \[LargeIcon \<IMicrosoftGraphMimeContent\>\]: Contains properties for a generic mime content.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Type \<String\>\]: Indicates the content mime type.
    \[Value \<Byte\[\]\>\]: The byte array that contains the actual content.
  \[LastModifiedDateTime \<DateTime?\>\]: The date and time the app was last modified.
  \[Notes \<String\>\]: Notes for the app.
  \[Owner \<String\>\]: The owner of the app.
  \[PrivacyInformationUrl \<String\>\]: The privacy statement Url.
  \[Publisher \<String\>\]: The publisher of the app.
  \[PublishingState \<String\>\]: mobileAppPublishingState

CATEGORIES \<IMicrosoftGraphMobileAppCategory\[\]\>: The list of categories for this app.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: The name of the app category.
  \[LastModifiedDateTime \<DateTime?\>\]: The date and time the mobileAppCategory was last modified.

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

LARGEICON \<IMicrosoftGraphMimeContent\>: Contains properties for a generic mime content.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Type \<String\>\]: Indicates the content mime type.
  \[Value \<Byte\[\]\>\]: The byte array that contains the actual content.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapp](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileapp)

