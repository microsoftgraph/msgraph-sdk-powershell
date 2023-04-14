---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmanagedappregistration
schema: 2.0.0
---

# Update-MgDeviceAppMgtManagedAppRegistration

## SYNOPSIS
Update the navigation property managedAppRegistrations in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppMgtManagedAppRegistration -ManagedAppRegistrationId <String>
 [-AdditionalProperties <Hashtable>] [-AppIdentifier <Hashtable>] [-ApplicationVersion <String>]
 [-AppliedPolicies <IMicrosoftGraphManagedAppPolicy[]>] [-CreatedDateTime <DateTime>] [-DeviceName <String>]
 [-DeviceTag <String>] [-DeviceType <String>] [-FlaggedReasons <ManagedAppFlaggedReason[]>] [-Id <String>]
 [-IntendedPolicies <IMicrosoftGraphManagedAppPolicy[]>] [-LastSyncDateTime <DateTime>]
 [-ManagementSdkVersion <String>] [-Operations <IMicrosoftGraphManagedAppOperation[]>]
 [-PlatformVersion <String>] [-UserId <String>] [-Version <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgtManagedAppRegistration -ManagedAppRegistrationId <String>
 -BodyParameter <IMicrosoftGraphManagedAppRegistration> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppMgtManagedAppRegistration -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedAppRegistration> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppMgtManagedAppRegistration -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AppIdentifier <Hashtable>] [-ApplicationVersion <String>]
 [-AppliedPolicies <IMicrosoftGraphManagedAppPolicy[]>] [-CreatedDateTime <DateTime>] [-DeviceName <String>]
 [-DeviceTag <String>] [-DeviceType <String>] [-FlaggedReasons <ManagedAppFlaggedReason[]>] [-Id <String>]
 [-IntendedPolicies <IMicrosoftGraphManagedAppPolicy[]>] [-LastSyncDateTime <DateTime>]
 [-ManagementSdkVersion <String>] [-Operations <IMicrosoftGraphManagedAppOperation[]>]
 [-PlatformVersion <String>] [-UserId <String>] [-Version <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managedAppRegistrations in deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppIdentifier
The identifier for a mobile app.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationVersion
App version

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

### -AppliedPolicies
Zero or more policys already applied on the registered app when it last synchronized with managment service.
To construct, please use Get-Help -Online and see NOTES section for APPLIEDPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppRegistration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date and time of creation

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Host device name

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

### -DeviceTag
App management SDK generated tag, which helps relate apps hosted on the same device.
Not guaranteed to relate apps in all conditions.

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

### -DeviceType
Host device type

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

### -FlaggedReasons
Zero or more reasons an app registration is flagged.
E.g.
app running on rooted device

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedAppFlaggedReason[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntendedPolicies
Zero or more policies admin intended for the app as of now.
To construct, please use Get-Help -Online and see NOTES section for INTENDEDPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSyncDateTime
Date and time of last the app synced with management service.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppRegistrationId
The unique identifier of managedAppRegistration

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

### -ManagementSdkVersion
App management SDK version

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

### -Operations
Zero or more long running operations triggered on the app registration.
To construct, please use Get-Help -Online and see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppOperation[]
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

### -PlatformVersion
Operating System version

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
The user Id to who this app registration belongs.

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

### -Version
Version of the entity.

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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppRegistration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgDeviceAppManagementManagedAppRegistration

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLIEDPOLICIES <IMicrosoftGraphManagedAppPolicy[]>: Zero or more policys already applied on the registered app when it last synchronized with managment service.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[Version <String>]`: Version of the entity.

BODYPARAMETER <IMicrosoftGraphManagedAppRegistration>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplicationVersion <String>]`: App version
  - `[AppliedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policys already applied on the registered app when it last synchronized with managment service.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
    - `[Description <String>]`: The policy's description.
    - `[DisplayName <String>]`: Policy display name.
    - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
    - `[Version <String>]`: Version of the entity.
  - `[CreatedDateTime <DateTime?>]`: Date and time of creation
  - `[DeviceName <String>]`: Host device name
  - `[DeviceTag <String>]`: App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.
  - `[DeviceType <String>]`: Host device type
  - `[FlaggedReasons <ManagedAppFlaggedReason[]>]`: Zero or more reasons an app registration is flagged. E.g. app running on rooted device
  - `[IntendedPolicies <IMicrosoftGraphManagedAppPolicy[]>]`: Zero or more policies admin intended for the app as of now.
  - `[LastSyncDateTime <DateTime?>]`: Date and time of last the app synced with management service.
  - `[ManagementSdkVersion <String>]`: App management SDK version
  - `[Operations <IMicrosoftGraphManagedAppOperation[]>]`: Zero or more long running operations triggered on the app registration.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DisplayName <String>]`: The operation name.
    - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
    - `[State <String>]`: The current state of the operation
    - `[Version <String>]`: Version of the entity.
  - `[PlatformVersion <String>]`: Operating System version
  - `[UserId <String>]`: The user Id to who this app registration belongs.
  - `[Version <String>]`: Version of the entity.

INPUTOBJECT <IDevicesCorporateManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: The unique identifier of androidManagedAppProtection
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: The unique identifier of assignmentFilterEvaluationStatusDetails
  - `[BundleId <String>]`: Usage: bundleId='{bundleId}'
  - `[Count <Int64?>]`: Usage: count={count}
  - `[DefaultManagedAppProtectionId <String>]`: The unique identifier of defaultManagedAppProtection
  - `[DetectedAppId <String>]`: The unique identifier of detectedApp
  - `[DeviceAppManagementTaskId <String>]`: The unique identifier of deviceAppManagementTask
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: Usage: deviceId='{deviceId}'
  - `[DeviceInstallStateId <String>]`: The unique identifier of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[EnrollmentConfigurationAssignmentId <String>]`: The unique identifier of enrollmentConfigurationAssignment
  - `[EnterpriseCodeSigningCertificateId <String>]`: The unique identifier of enterpriseCodeSigningCertificate
  - `[Id <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: The unique identifier of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: The unique identifier of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: The unique identifier of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: The unique identifier of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: The unique identifier of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: The unique identifier of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: The unique identifier of managedAppStatus
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: The unique identifier of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationState
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: The unique identifier of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: The unique identifier of managedEBookCategory
  - `[ManagedEBookId <String>]`: The unique identifier of managedEBook
  - `[ManagedMobileAppId <String>]`: The unique identifier of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: The unique identifier of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: The unique identifier of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: The unique identifier of mobileAppCategory
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[MobileAppInstallStatusId <String>]`: The unique identifier of mobileAppInstallStatus
  - `[MobileAppIntentAndStateId <String>]`: The unique identifier of mobileAppIntentAndState
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: The unique identifier of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: The unique identifier of mobileAppRelationship
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[OfficeClientConfigurationAssignmentId <String>]`: The unique identifier of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: The unique identifier of officeClientConfiguration
  - `[PolicyId <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[PolicySetAssignmentId <String>]`: The unique identifier of policySetAssignment
  - `[PolicySetId <String>]`: The unique identifier of policySet
  - `[PolicySetItemId <String>]`: The unique identifier of policySetItem
  - `[SecurityBaselineSettingStateId <String>]`: The unique identifier of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: The unique identifier of securityBaselineState
  - `[Status <String>]`: Usage: status='{status}'
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: The unique identifier of userAppInstallStatus
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[UserPrincipalName <String>]`: Usage: userPrincipalName='{userPrincipalName}'
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: The unique identifier of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: The unique identifier of windowsInformationProtectionWipeAction
  - `[WindowsManagedAppProtectionId <String>]`: The unique identifier of windowsManagedAppProtection

INTENDEDPOLICIES <IMicrosoftGraphManagedAppPolicy[]>: Zero or more policies admin intended for the app as of now.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[Version <String>]`: Version of the entity.

OPERATIONS <IMicrosoftGraphManagedAppOperation[]>: Zero or more long running operations triggered on the app registration.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The operation name.
  - `[LastModifiedDateTime <DateTime?>]`: The last time the app operation was modified.
  - `[State <String>]`: The current state of the operation
  - `[Version <String>]`: Version of the entity.

## RELATED LINKS

