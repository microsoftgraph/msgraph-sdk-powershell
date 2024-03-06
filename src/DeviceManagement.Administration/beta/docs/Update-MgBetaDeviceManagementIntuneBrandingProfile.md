---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/update-mgbetadevicemanagementintunebrandingprofile
schema: 2.0.0
---

# Update-MgBetaDeviceManagementIntuneBrandingProfile

## SYNOPSIS
Update the navigation property intuneBrandingProfiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementIntuneBrandingProfile -IntuneBrandingProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]
 [-CompanyPortalBlockedActions <IMicrosoftGraphCompanyPortalBlockedAction[]>]
 [-ContactItEmailAddress <String>] [-ContactItName <String>] [-ContactItNotes <String>]
 [-ContactItPhoneNumber <String>] [-CreatedDateTime <DateTime>] [-CustomCanSeePrivacyMessage <String>]
 [-CustomCantSeePrivacyMessage <String>] [-CustomPrivacyMessage <String>] [-DisableClientTelemetry]
 [-DisableDeviceCategorySelection] [-DisplayName <String>]
 [-EnrollmentAvailability <EnrollmentAvailabilityOptions>] [-Id <String>] [-IsDefaultProfile]
 [-IsFactoryResetDisabled] [-IsRemoveDeviceDisabled]
 [-LandingPageCustomizedImage <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>]
 [-LightBackgroundLogo <IMicrosoftGraphMimeContent>] [-OnlineSupportSiteName <String>]
 [-OnlineSupportSiteUrl <String>] [-PrivacyUrl <String>] [-ProfileDescription <String>]
 [-ProfileName <String>] [-ResponseHeadersVariable <String>] [-RoleScopeTagIds <String[]>]
 [-SendDeviceOwnershipChangePushNotification] [-ShowAzureAdEnterpriseApps] [-ShowConfigurationManagerApps]
 [-ShowDisplayNameNextToLogo] [-ShowLogo] [-ShowOfficeWebApps] [-ThemeColor <IMicrosoftGraphRgbColor>]
 [-ThemeColorLogo <IMicrosoftGraphMimeContent>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementIntuneBrandingProfile -IntuneBrandingProfileId <String>
 -BodyParameter <IMicrosoftGraphIntuneBrandingProfile> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementIntuneBrandingProfile -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphIntuneBrandingProfile> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementIntuneBrandingProfile -InputObject <IDeviceManagementAdministrationIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]
 [-CompanyPortalBlockedActions <IMicrosoftGraphCompanyPortalBlockedAction[]>]
 [-ContactItEmailAddress <String>] [-ContactItName <String>] [-ContactItNotes <String>]
 [-ContactItPhoneNumber <String>] [-CreatedDateTime <DateTime>] [-CustomCanSeePrivacyMessage <String>]
 [-CustomCantSeePrivacyMessage <String>] [-CustomPrivacyMessage <String>] [-DisableClientTelemetry]
 [-DisableDeviceCategorySelection] [-DisplayName <String>]
 [-EnrollmentAvailability <EnrollmentAvailabilityOptions>] [-Id <String>] [-IsDefaultProfile]
 [-IsFactoryResetDisabled] [-IsRemoveDeviceDisabled]
 [-LandingPageCustomizedImage <IMicrosoftGraphMimeContent>] [-LastModifiedDateTime <DateTime>]
 [-LightBackgroundLogo <IMicrosoftGraphMimeContent>] [-OnlineSupportSiteName <String>]
 [-OnlineSupportSiteUrl <String>] [-PrivacyUrl <String>] [-ProfileDescription <String>]
 [-ProfileName <String>] [-ResponseHeadersVariable <String>] [-RoleScopeTagIds <String[]>]
 [-SendDeviceOwnershipChangePushNotification] [-ShowAzureAdEnterpriseApps] [-ShowConfigurationManagerApps]
 [-ShowDisplayNameNextToLogo] [-ShowLogo] [-ShowOfficeWebApps] [-ThemeColor <IMicrosoftGraphRgbColor>]
 [-ThemeColorLogo <IMicrosoftGraphMimeContent>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property intuneBrandingProfiles in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfileAssignment[]
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile
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
To construct, see NOTES section for COMPANYPORTALBLOCKEDACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCompanyPortalBlockedAction[]
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

### -DisableDeviceCategorySelection
Boolean that indicates if Device Category Selection will be shown in Company Portal

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
Type: Microsoft.Graph.Beta.PowerShell.Support.EnrollmentAvailabilityOptions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntuneBrandingProfileId
The unique identifier of intuneBrandingProfile

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
To construct, see NOTES section for LANDINGPAGECUSTOMIZEDIMAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMimeContent
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
To construct, see NOTES section for LIGHTBACKGROUNDLOGO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMimeContent
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### -ShowConfigurationManagerApps
Boolean that indicates if Configuration Manager Apps will be shown in Company Portal

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
To construct, see NOTES section for THEMECOLOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRgbColor
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
To construct, see NOTES section for THEMECOLORLOGO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMimeContent
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphIntuneBrandingProfileAssignment[]>`: The list of group assignments for the branding profile
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`BODYPARAMETER <IMicrosoftGraphIntuneBrandingProfile>`: This entity contains data which is used in customizing the tenant level appearance of the Company Portal applications as well as the end user web portal.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]`: The list of group assignments for the branding profile
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
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
  - `[DisableDeviceCategorySelection <Boolean?>]`: Boolean that indicates if Device Category Selection will be shown in Company Portal
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
  - `[ShowConfigurationManagerApps <Boolean?>]`: Boolean that indicates if Configuration Manager Apps will be shown in Company Portal
  - `[ShowDisplayNameNextToLogo <Boolean?>]`: Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not
  - `[ShowLogo <Boolean?>]`: Boolean that represents whether the administrator-supplied logo images are shown or not
  - `[ShowOfficeWebApps <Boolean?>]`: Boolean that indicates if Office WebApps will be shown in Company Portal
  - `[ThemeColor <IMicrosoftGraphRgbColor>]`: Color in RGB.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[B <Int32?>]`: Blue value
    - `[G <Int32?>]`: Green value
    - `[R <Int32?>]`: Red value
  - `[ThemeColorLogo <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.

`COMPANYPORTALBLOCKEDACTIONS <IMicrosoftGraphCompanyPortalBlockedAction[]>`: Collection of blocked actions on the company portal as per platform and device ownership types.
  - `[Action <CompanyPortalAction?>]`: Action on a device that can be executed in the Company Portal
  - `[OwnerType <OwnerType?>]`: Owner type of device.
  - `[Platform <DevicePlatformType?>]`: Supported platform types.

`INPUTOBJECT <IDeviceManagementAdministrationIdentity>`: Identity Parameter
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CartToClassAssociationId <String>]`: The unique identifier of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: The unique identifier of cloudPcAuditEvent
  - `[CloudPcBulkActionId <String>]`: The unique identifier of cloudPcBulkAction
  - `[CloudPcDeviceImageId <String>]`: The unique identifier of cloudPcDeviceImage
  - `[CloudPcExportJobId <String>]`: The unique identifier of cloudPcExportJob
  - `[CloudPcExternalPartnerSettingId <String>]`: The unique identifier of cloudPcExternalPartnerSetting
  - `[CloudPcFrontLineServicePlanId <String>]`: The unique identifier of cloudPcFrontLineServicePlan
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

`LANDINGPAGECUSTOMIZEDIMAGE <IMicrosoftGraphMimeContent>`: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

`LIGHTBACKGROUNDLOGO <IMicrosoftGraphMimeContent>`: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

`THEMECOLOR <IMicrosoftGraphRgbColor>`: Color in RGB.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[B <Int32?>]`: Blue value
  - `[G <Int32?>]`: Green value
  - `[R <Int32?>]`: Red value

`THEMECOLORLOGO <IMicrosoftGraphMimeContent>`: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

