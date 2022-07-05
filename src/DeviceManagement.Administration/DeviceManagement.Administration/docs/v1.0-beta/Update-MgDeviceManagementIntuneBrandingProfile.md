---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementintunebrandingprofile
schema: 2.0.0
---

# Update-MgDeviceManagementIntuneBrandingProfile

## SYNOPSIS
Update the navigation property intuneBrandingProfiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementIntuneBrandingProfile -IntuneBrandingProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]
 [-CompanyPortalBlockedActions <IMicrosoftGraphCompanyPortalBlockedAction[]>]
 [-ContactItEmailAddress <String>] [-ContactItName <String>] [-ContactItNotes <String>]
 [-ContactItPhoneNumber <String>] [-CreatedDateTime <DateTime>] [-CustomCanSeePrivacyMessage <String>]
 [-CustomCantSeePrivacyMessage <String>] [-CustomPrivacyMessage <String>] [-DisableClientTelemetry]
 [-DisplayName <String>] [-EnrollmentAvailability <EnrollmentAvailabilityOptions>] [-Id <String>]
 [-IsDefaultProfile] [-IsFactoryResetDisabled] [-IsRemoveDeviceDisabled]
 [-LandingPageCustomizedImage <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>]
 [-LightBackgroundLogo <IMicrosoftGraphMimeContent>] [-OnlineSupportSiteName <String>]
 [-OnlineSupportSiteUrl <String>] [-PrivacyUrl <String>] [-ProfileDescription <String>]
 [-ProfileName <String>] [-RoleScopeTagIds <String[]>] [-SendDeviceOwnershipChangePushNotification]
 [-ShowAzureAdEnterpriseApps] [-ShowDisplayNameNextToLogo] [-ShowLogo] [-ShowOfficeWebApps]
 [-ThemeColor <IMicrosoftGraphRgbColor>] [-ThemeColorLogo <IMicrosoftGraphMimeContent>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementIntuneBrandingProfile -IntuneBrandingProfileId <String>
 -BodyParameter <IMicrosoftGraphIntuneBrandingProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementIntuneBrandingProfile -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphIntuneBrandingProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementIntuneBrandingProfile -InputObject <IDeviceManagementAdministrationIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]
 [-CompanyPortalBlockedActions <IMicrosoftGraphCompanyPortalBlockedAction[]>]
 [-ContactItEmailAddress <String>] [-ContactItName <String>] [-ContactItNotes <String>]
 [-ContactItPhoneNumber <String>] [-CreatedDateTime <DateTime>] [-CustomCanSeePrivacyMessage <String>]
 [-CustomCantSeePrivacyMessage <String>] [-CustomPrivacyMessage <String>] [-DisableClientTelemetry]
 [-DisplayName <String>] [-EnrollmentAvailability <EnrollmentAvailabilityOptions>] [-Id <String>]
 [-IsDefaultProfile] [-IsFactoryResetDisabled] [-IsRemoveDeviceDisabled]
 [-LandingPageCustomizedImage <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>]
 [-LightBackgroundLogo <IMicrosoftGraphMimeContent>] [-OnlineSupportSiteName <String>]
 [-OnlineSupportSiteUrl <String>] [-PrivacyUrl <String>] [-ProfileDescription <String>]
 [-ProfileName <String>] [-RoleScopeTagIds <String[]>] [-SendDeviceOwnershipChangePushNotification]
 [-ShowAzureAdEnterpriseApps] [-ShowDisplayNameNextToLogo] [-ShowLogo] [-ShowOfficeWebApps]
 [-ThemeColor <IMicrosoftGraphRgbColor>] [-ThemeColorLogo <IMicrosoftGraphMimeContent>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property intuneBrandingProfiles in deviceManagement

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

### -Assignments
The list of group assignments for the branding profile
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfileAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
This entity contains data which is used in customizing the tenant level appearance of the Company Portal applications as well as the end user web portal.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyPortalBlockedActions
Collection of blocked actions on the company portal as per platform and device ownership types.
To construct, please use Get-Help -Online and see NOTES section for COMPANYPORTALBLOCKEDACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCompanyPortalBlockedAction[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContactItEmailAddress
E-mail address of the person/organization responsible for IT support

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

### -ContactItName
Name of the person/organization responsible for IT support

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

### -ContactItNotes
Text comments regarding the person/organization responsible for IT support

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

### -ContactItPhoneNumber
Phone number of the person/organization responsible for IT support

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

### -CreatedDateTime
Time when the BrandingProfile was created

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

### -CustomCanSeePrivacyMessage
Text comments regarding what the admin has access to on the device

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

### -CustomCantSeePrivacyMessage
Text comments regarding what the admin doesn't have access to on the device

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

### -CustomPrivacyMessage
Text comments regarding what the admin doesn't have access to on the device

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

### -DisableClientTelemetry
Applies to telemetry sent from all clients to the Intune service.
When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Company/organization name that is displayed to end users

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

### -EnrollmentAvailability
Options available for enrollment flow customization

```yaml
Type: Microsoft.Graph.PowerShell.Support.EnrollmentAvailabilityOptions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntuneBrandingProfileId
key: id of intuneBrandingProfile

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

### -IsDefaultProfile
Boolean that represents whether the profile is used as default or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFactoryResetDisabled
Boolean that represents whether the adminsistrator has disabled the 'Factory Reset' action on corporate owned devices.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRemoveDeviceDisabled
Boolean that represents whether the adminsistrator has disabled the 'Remove Device' action on corporate owned devices.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LandingPageCustomizedImage
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for LANDINGPAGECUSTOMIZEDIMAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Time when the BrandingProfile was last modified

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

### -LightBackgroundLogo
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for LIGHTBACKGROUNDLOGO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnlineSupportSiteName
Display name of the company/organization’s IT helpdesk site

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

### -OnlineSupportSiteUrl
URL to the company/organization’s IT helpdesk site

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

### -PrivacyUrl
URL to the company/organization’s privacy policy

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

### -ProfileDescription
Description of the profile

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

### -ProfileName
Name of the profile

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

### -RoleScopeTagIds
List of scope tags assigned to the branding profile

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SendDeviceOwnershipChangePushNotification
Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowAzureAdEnterpriseApps
Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowDisplayNameNextToLogo
Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowLogo
Boolean that represents whether the administrator-supplied logo images are shown or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowOfficeWebApps
Boolean that indicates if Office WebApps will be shown in Company Portal

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThemeColor
Color in RGB.
To construct, please use Get-Help -Online and see NOTES section for THEMECOLOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRgbColor
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThemeColorLogo
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for THEMECOLORLOGO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphIntuneBrandingProfileAssignment[]>: The list of group assignments for the branding profile
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphIntuneBrandingProfile>: This entity contains data which is used in customizing the tenant level appearance of the Company Portal applications as well as the end user web portal.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]`: The list of group assignments for the branding profile
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CompanyPortalBlockedActions <IMicrosoftGraphCompanyPortalBlockedAction[]>]`: Collection of blocked actions on the company portal as per platform and device ownership types.
    - `[Action <CompanyPortalAction?>]`: Action on a device that can be executed in the Company Portal
    - `[OwnerType <OwnerType?>]`: Owner type of device.
    - `[Platform <DevicePlatformType?>]`: Supported platform types.
  - `[ContactItEmailAddress <String>]`: E-mail address of the person/organization responsible for IT support
  - `[ContactItName <String>]`: Name of the person/organization responsible for IT support
  - `[ContactItNotes <String>]`: Text comments regarding the person/organization responsible for IT support
  - `[ContactItPhoneNumber <String>]`: Phone number of the person/organization responsible for IT support
  - `[CreatedDateTime <DateTime?>]`: Time when the BrandingProfile was created
  - `[CustomCanSeePrivacyMessage <String>]`: Text comments regarding what the admin has access to on the device
  - `[CustomCantSeePrivacyMessage <String>]`: Text comments regarding what the admin doesn't have access to on the device
  - `[CustomPrivacyMessage <String>]`: Text comments regarding what the admin doesn't have access to on the device
  - `[DisableClientTelemetry <Boolean?>]`: Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.
  - `[DisplayName <String>]`: Company/organization name that is displayed to end users
  - `[EnrollmentAvailability <EnrollmentAvailabilityOptions?>]`: Options available for enrollment flow customization
  - `[IsDefaultProfile <Boolean?>]`: Boolean that represents whether the profile is used as default or not
  - `[IsFactoryResetDisabled <Boolean?>]`: Boolean that represents whether the adminsistrator has disabled the 'Factory Reset' action on corporate owned devices.
  - `[IsRemoveDeviceDisabled <Boolean?>]`: Boolean that represents whether the adminsistrator has disabled the 'Remove Device' action on corporate owned devices.
  - `[LandingPageCustomizedImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: Time when the BrandingProfile was last modified
  - `[LightBackgroundLogo <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
  - `[OnlineSupportSiteName <String>]`: Display name of the company/organization’s IT helpdesk site
  - `[OnlineSupportSiteUrl <String>]`: URL to the company/organization’s IT helpdesk site
  - `[PrivacyUrl <String>]`: URL to the company/organization’s privacy policy
  - `[ProfileDescription <String>]`: Description of the profile
  - `[ProfileName <String>]`: Name of the profile
  - `[RoleScopeTagIds <String[]>]`: List of scope tags assigned to the branding profile
  - `[SendDeviceOwnershipChangePushNotification <Boolean?>]`: Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate
  - `[ShowAzureAdEnterpriseApps <Boolean?>]`: Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal
  - `[ShowDisplayNameNextToLogo <Boolean?>]`: Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not
  - `[ShowLogo <Boolean?>]`: Boolean that represents whether the administrator-supplied logo images are shown or not
  - `[ShowOfficeWebApps <Boolean?>]`: Boolean that indicates if Office WebApps will be shown in Company Portal
  - `[ThemeColor <IMicrosoftGraphRgbColor>]`: Color in RGB.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[B <Int32?>]`: Blue value
    - `[G <Int32?>]`: Green value
    - `[R <Int32?>]`: Red value
  - `[ThemeColorLogo <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.

COMPANYPORTALBLOCKEDACTIONS <IMicrosoftGraphCompanyPortalBlockedAction[]>: Collection of blocked actions on the company portal as per platform and device ownership types.
  - `[Action <CompanyPortalAction?>]`: Action on a device that can be executed in the Company Portal
  - `[OwnerType <OwnerType?>]`: Owner type of device.
  - `[Platform <DevicePlatformType?>]`: Supported platform types.

INPUTOBJECT <IDeviceManagementAdministrationIdentity>: Identity Parameter
  - `[AuditEventId <String>]`: key: id of auditEvent
  - `[CartToClassAssociationId <String>]`: key: id of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: key: id of cloudPcAuditEvent
  - `[CloudPcDeviceImageId <String>]`: key: id of cloudPcDeviceImage
  - `[CloudPcGalleryImageId <String>]`: key: id of cloudPcGalleryImage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: key: id of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyAssignmentId <String>]`: key: id of cloudPcProvisioningPolicyAssignment
  - `[CloudPcProvisioningPolicyId <String>]`: key: id of cloudPcProvisioningPolicy
  - `[CloudPcServicePlanId <String>]`: key: id of cloudPcServicePlan
  - `[CloudPcSnapshotId <String>]`: key: id of cloudPcSnapshot
  - `[CloudPcSupportedRegionId <String>]`: key: id of cloudPcSupportedRegion
  - `[CloudPcUserSettingAssignmentId <String>]`: key: id of cloudPcUserSettingAssignment
  - `[CloudPcUserSettingId <String>]`: key: id of cloudPcUserSetting
  - `[ComanagementEligibleDeviceId <String>]`: key: id of comanagementEligibleDevice
  - `[ComplianceManagementPartnerId <String>]`: key: id of complianceManagementPartner
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: key: id of deviceAndAppManagementRoleAssignment
  - `[DeviceManagementDomainJoinConnectorId <String>]`: key: id of deviceManagementDomainJoinConnector
  - `[DeviceManagementExchangeConnectorId <String>]`: key: id of deviceManagementExchangeConnector
  - `[DeviceManagementExchangeOnPremisesPolicyId <String>]`: key: id of deviceManagementExchangeOnPremisesPolicy
  - `[DeviceManagementPartnerId <String>]`: key: id of deviceManagementPartner
  - `[GroupPolicyCategoryId <String>]`: key: id of groupPolicyCategory
  - `[GroupPolicyCategoryId1 <String>]`: key: id of groupPolicyCategory
  - `[GroupPolicyDefinitionFileId <String>]`: key: id of groupPolicyDefinitionFile
  - `[GroupPolicyDefinitionId <String>]`: key: id of groupPolicyDefinition
  - `[GroupPolicyMigrationReportId <String>]`: key: id of groupPolicyMigrationReport
  - `[GroupPolicyObjectFileId <String>]`: key: id of groupPolicyObjectFile
  - `[GroupPolicyOperationId <String>]`: key: id of groupPolicyOperation
  - `[GroupPolicyPresentationId <String>]`: key: id of groupPolicyPresentation
  - `[GroupPolicySettingMappingId <String>]`: key: id of groupPolicySettingMapping
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: key: id of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileAssignmentId <String>]`: key: id of intuneBrandingProfileAssignment
  - `[IntuneBrandingProfileId <String>]`: key: id of intuneBrandingProfile
  - `[IosUpdateDeviceStatusId <String>]`: key: id of iosUpdateDeviceStatus
  - `[ManagedAllDeviceCertificateStateId <String>]`: key: id of managedAllDeviceCertificateState
  - `[MobileThreatDefenseConnectorId <String>]`: key: id of mobileThreatDefenseConnector
  - `[NdesConnectorId <String>]`: key: id of ndesConnector
  - `[RemoteAssistancePartnerId <String>]`: key: id of remoteAssistancePartner
  - `[ResourceOperationId <String>]`: key: id of resourceOperation
  - `[RestrictedAppsViolationId <String>]`: key: id of restrictedAppsViolation
  - `[RoleAssignmentId <String>]`: key: id of roleAssignment
  - `[RoleDefinitionId <String>]`: key: id of roleDefinition
  - `[RoleScopeTagAutoAssignmentId <String>]`: key: id of roleScopeTagAutoAssignment
  - `[RoleScopeTagId <String>]`: key: id of roleScopeTag
  - `[TelecomExpenseManagementPartnerId <String>]`: key: id of telecomExpenseManagementPartner
  - `[TermsAndConditionsAcceptanceStatusId <String>]`: key: id of termsAndConditionsAcceptanceStatus
  - `[TermsAndConditionsAssignmentId <String>]`: key: id of termsAndConditionsAssignment
  - `[TermsAndConditionsGroupAssignmentId <String>]`: key: id of termsAndConditionsGroupAssignment
  - `[TermsAndConditionsId <String>]`: key: id of termsAndConditions
  - `[UnsupportedGroupPolicyExtensionId <String>]`: key: id of unsupportedGroupPolicyExtension
  - `[UserPfxCertificateId <String>]`: key: id of userPFXCertificate

LANDINGPAGECUSTOMIZEDIMAGE <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

LIGHTBACKGROUNDLOGO <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

THEMECOLOR <IMicrosoftGraphRgbColor>: Color in RGB.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[B <Int32?>]`: Blue value
  - `[G <Int32?>]`: Green value
  - `[R <Int32?>]`: Red value

THEMECOLORLOGO <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

