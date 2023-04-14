---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementmobilethreatdefenseconnector
schema: 2.0.0
---

# Update-MgDeviceManagementMobileThreatDefenseConnector

## SYNOPSIS
Update the navigation property mobileThreatDefenseConnectors in deviceManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceManagementMobileThreatDefenseConnector -MobileThreatDefenseConnectorId <String>
 [-AdditionalProperties <Hashtable>] [-AllowPartnerToCollectIosApplicationMetadata]
 [-AllowPartnerToCollectIosPersonalApplicationMetadata] [-AndroidDeviceBlockedOnMissingPartnerData]
 [-AndroidEnabled] [-AndroidMobileApplicationManagementEnabled] [-Id <String>]
 [-IosDeviceBlockedOnMissingPartnerData] [-IosEnabled] [-IosMobileApplicationManagementEnabled]
 [-LastHeartbeatDateTime <DateTime>] [-MicrosoftDefenderForEndpointAttachEnabled]
 [-PartnerState <MobileThreatPartnerTenantState>] [-PartnerUnresponsivenessThresholdInDays <Int32>]
 [-PartnerUnsupportedOSVersionBlocked] [-WindowsDeviceBlockedOnMissingPartnerData] [-WindowsEnabled]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDeviceManagementMobileThreatDefenseConnector -MobileThreatDefenseConnectorId <String>
 -BodyParameter <IMicrosoftGraphMobileThreatDefenseConnector1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceManagementMobileThreatDefenseConnector -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphMobileThreatDefenseConnector1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceManagementMobileThreatDefenseConnector -InputObject <IDeviceManagementAdministrationIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowPartnerToCollectIosApplicationMetadata]
 [-AllowPartnerToCollectIosPersonalApplicationMetadata] [-AndroidDeviceBlockedOnMissingPartnerData]
 [-AndroidEnabled] [-AndroidMobileApplicationManagementEnabled] [-Id <String>]
 [-IosDeviceBlockedOnMissingPartnerData] [-IosEnabled] [-IosMobileApplicationManagementEnabled]
 [-LastHeartbeatDateTime <DateTime>] [-MicrosoftDefenderForEndpointAttachEnabled]
 [-PartnerState <MobileThreatPartnerTenantState>] [-PartnerUnresponsivenessThresholdInDays <Int32>]
 [-PartnerUnsupportedOSVersionBlocked] [-WindowsDeviceBlockedOnMissingPartnerData] [-WindowsEnabled]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property mobileThreatDefenseConnectors in deviceManagement

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

### -AllowPartnerToCollectIosApplicationMetadata
When TRUE, indicates the Mobile Threat Defense partner may collect metadata about installed applications from Intune for IOS devices.
When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about installed applications from Intune for IOS devices.
Default value is FALSE.

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

### -AllowPartnerToCollectIosPersonalApplicationMetadata
When TRUE, indicates the Mobile Threat Defense partner may collect metadata about personally installed applications from Intune for IOS devices.
When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about personally installed applications from Intune for IOS devices.
Default value is FALSE.

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

### -AndroidDeviceBlockedOnMissingPartnerData
For Android, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant

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

### -AndroidEnabled
For Android, set whether data from the Mobile Threat Defense partner should be used during compliance evaluations

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

### -AndroidMobileApplicationManagementEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for Android devices.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for Android devices.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
Default value is FALSE.

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

### -BodyParameter
Entity which represents a connection to Mobile Threat Defense partner.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IosDeviceBlockedOnMissingPartnerData
For IOS, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant

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

### -IosEnabled
For IOS, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations

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

### -IosMobileApplicationManagementEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for IOS devices.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for IOS devices.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
Default value is FALSE.

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

### -LastHeartbeatDateTime
DateTime of last Heartbeat recieved from the Mobile Threat Defense partner

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

### -MicrosoftDefenderForEndpointAttachEnabled
When TRUE, inidicates that configuration profile management via Microsoft Defender for Endpoint is enabled.
When FALSE, inidicates that configuration profile management via Microsoft Defender for Endpoint is disabled.
Default value is FALSE.

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

### -MobileThreatDefenseConnectorId
The unique identifier of mobileThreatDefenseConnector

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

### -PartnerState
Partner state of this tenant.

```yaml
Type: Microsoft.Graph.PowerShell.Support.MobileThreatPartnerTenantState
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerUnresponsivenessThresholdInDays
Get or Set days the per tenant tolerance to unresponsiveness for this partner integration

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerUnsupportedOSVersionBlocked
Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Mobile Threat Defense partner

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

### -WindowsDeviceBlockedOnMissingPartnerData
When TRUE, inidicates that Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant for Windows.
When FALSE, inidicates that Intune may make a device compliant without receiving data from the Mobile Threat Defense partner for Windows.
Default value is FALSE.

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

### -WindowsEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during compliance evaluations for Windows.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during compliance evaluations for Windows.
Default value is FALSE.

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphMobileThreatDefenseConnector1>: Entity which represents a connection to Mobile Threat Defense partner.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowPartnerToCollectIosApplicationMetadata <Boolean?>]`: When TRUE, indicates the Mobile Threat Defense partner may collect metadata about installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about installed applications from Intune for IOS devices. Default value is FALSE.
  - `[AllowPartnerToCollectIosPersonalApplicationMetadata <Boolean?>]`: When TRUE, indicates the Mobile Threat Defense partner may collect metadata about personally installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about personally installed applications from Intune for IOS devices. Default value is FALSE.
  - `[AndroidDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Android, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant
  - `[AndroidEnabled <Boolean?>]`: For Android, set whether data from the Mobile Threat Defense partner should be used during compliance evaluations
  - `[AndroidMobileApplicationManagementEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for Android devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for Android devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.
  - `[IosDeviceBlockedOnMissingPartnerData <Boolean?>]`: For IOS, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant
  - `[IosEnabled <Boolean?>]`: For IOS, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations
  - `[IosMobileApplicationManagementEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for IOS devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for IOS devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.
  - `[LastHeartbeatDateTime <DateTime?>]`: DateTime of last Heartbeat recieved from the Mobile Threat Defense partner
  - `[MicrosoftDefenderForEndpointAttachEnabled <Boolean?>]`: When TRUE, inidicates that configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, inidicates that configuration profile management via Microsoft Defender for Endpoint is disabled. Default value is FALSE.
  - `[PartnerState <MobileThreatPartnerTenantState?>]`: Partner state of this tenant.
  - `[PartnerUnresponsivenessThresholdInDays <Int32?>]`: Get or Set days the per tenant tolerance to unresponsiveness for this partner integration
  - `[PartnerUnsupportedOSVersionBlocked <Boolean?>]`: Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Mobile Threat Defense partner
  - `[WindowsDeviceBlockedOnMissingPartnerData <Boolean?>]`: When TRUE, inidicates that Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant for Windows. When FALSE, inidicates that Intune may make a device compliant without receiving data from the Mobile Threat Defense partner for Windows. Default value is FALSE.
  - `[WindowsEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during compliance evaluations for Windows. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during compliance evaluations for Windows. Default value is FALSE.

INPUTOBJECT <IDeviceManagementAdministrationIdentity>: Identity Parameter
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CartToClassAssociationId <String>]`: The unique identifier of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: The unique identifier of cloudPcAuditEvent
  - `[CloudPcDeviceImageId <String>]`: The unique identifier of cloudPcDeviceImage
  - `[CloudPcExportJobId <String>]`: The unique identifier of cloudPcExportJob
  - `[CloudPcExternalPartnerSettingId <String>]`: The unique identifier of cloudPcExternalPartnerSetting
  - `[CloudPcGalleryImageId <String>]`: The unique identifier of cloudPcGalleryImage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: The unique identifier of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyAssignmentId <String>]`: The unique identifier of cloudPcProvisioningPolicyAssignment
  - `[CloudPcProvisioningPolicyId <String>]`: The unique identifier of cloudPcProvisioningPolicy
  - `[CloudPcServicePlanId <String>]`: The unique identifier of cloudPcServicePlan
  - `[CloudPcSharedUseServicePlanId <String>]`: The unique identifier of cloudPcSharedUseServicePlan
  - `[CloudPcSnapshotId <String>]`: The unique identifier of cloudPcSnapshot
  - `[CloudPcSupportedRegionId <String>]`: The unique identifier of cloudPcSupportedRegion
  - `[CloudPcUserSettingAssignmentId <String>]`: The unique identifier of cloudPcUserSettingAssignment
  - `[CloudPcUserSettingId <String>]`: The unique identifier of cloudPcUserSetting
  - `[ComanagementEligibleDeviceId <String>]`: The unique identifier of comanagementEligibleDevice
  - `[ComplianceManagementPartnerId <String>]`: The unique identifier of complianceManagementPartner
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: The unique identifier of deviceAndAppManagementRoleAssignment
  - `[DeviceManagementDomainJoinConnectorId <String>]`: The unique identifier of deviceManagementDomainJoinConnector
  - `[DeviceManagementExchangeConnectorId <String>]`: The unique identifier of deviceManagementExchangeConnector
  - `[DeviceManagementExchangeOnPremisesPolicyId <String>]`: The unique identifier of deviceManagementExchangeOnPremisesPolicy
  - `[DeviceManagementPartnerId <String>]`: The unique identifier of deviceManagementPartner
  - `[GroupPolicyCategoryId <String>]`: The unique identifier of groupPolicyCategory
  - `[GroupPolicyCategoryId1 <String>]`: The unique identifier of groupPolicyCategory
  - `[GroupPolicyDefinitionFileId <String>]`: The unique identifier of groupPolicyDefinitionFile
  - `[GroupPolicyDefinitionId <String>]`: The unique identifier of groupPolicyDefinition
  - `[GroupPolicyMigrationReportId <String>]`: The unique identifier of groupPolicyMigrationReport
  - `[GroupPolicyObjectFileId <String>]`: The unique identifier of groupPolicyObjectFile
  - `[GroupPolicyOperationId <String>]`: The unique identifier of groupPolicyOperation
  - `[GroupPolicyPresentationId <String>]`: The unique identifier of groupPolicyPresentation
  - `[GroupPolicySettingMappingId <String>]`: The unique identifier of groupPolicySettingMapping
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: The unique identifier of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileAssignmentId <String>]`: The unique identifier of intuneBrandingProfileAssignment
  - `[IntuneBrandingProfileId <String>]`: The unique identifier of intuneBrandingProfile
  - `[IosUpdateDeviceStatusId <String>]`: The unique identifier of iosUpdateDeviceStatus
  - `[ManagedAllDeviceCertificateStateId <String>]`: The unique identifier of managedAllDeviceCertificateState
  - `[MobileThreatDefenseConnectorId <String>]`: The unique identifier of mobileThreatDefenseConnector
  - `[NdesConnectorId <String>]`: The unique identifier of ndesConnector
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[ResourceOperationId <String>]`: The unique identifier of resourceOperation
  - `[RestrictedAppsViolationId <String>]`: The unique identifier of restrictedAppsViolation
  - `[RoleAssignmentId <String>]`: The unique identifier of roleAssignment
  - `[RoleDefinitionId <String>]`: The unique identifier of roleDefinition
  - `[RoleScopeTagAutoAssignmentId <String>]`: The unique identifier of roleScopeTagAutoAssignment
  - `[RoleScopeTagId <String>]`: The unique identifier of roleScopeTag
  - `[TelecomExpenseManagementPartnerId <String>]`: The unique identifier of telecomExpenseManagementPartner
  - `[TermsAndConditionsAcceptanceStatusId <String>]`: The unique identifier of termsAndConditionsAcceptanceStatus
  - `[TermsAndConditionsAssignmentId <String>]`: The unique identifier of termsAndConditionsAssignment
  - `[TermsAndConditionsGroupAssignmentId <String>]`: The unique identifier of termsAndConditionsGroupAssignment
  - `[TermsAndConditionsId <String>]`: The unique identifier of termsAndConditions
  - `[UnsupportedGroupPolicyExtensionId <String>]`: The unique identifier of unsupportedGroupPolicyExtension
  - `[UserId <String>]`: The unique identifier of user
  - `[UserPfxCertificateId <String>]`: The unique identifier of userPFXCertificate

## RELATED LINKS

