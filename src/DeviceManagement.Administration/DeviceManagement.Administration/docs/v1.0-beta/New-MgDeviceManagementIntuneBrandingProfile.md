---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementintunebrandingprofile
schema: 2.0.0
---

# New-MgDeviceManagementIntuneBrandingProfile

## SYNOPSIS
Create new navigation property to intuneBrandingProfiles for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementIntuneBrandingProfile [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphIntuneBrandingProfileAssignment[]>]
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
 [-ThemeColor <IMicrosoftGraphRgbColor>] [-ThemeColorLogo <IMicrosoftGraphMimeContent>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementIntuneBrandingProfile -BodyParameter <IMicrosoftGraphIntuneBrandingProfile> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to intuneBrandingProfiles for deviceManagement

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

### -Assignments
The list of group assignments for the branding profile
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfileAssignment[]
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### -IsDefaultProfile
Boolean that represents whether the profile is used as default or not

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

### -IsFactoryResetDisabled
Boolean that represents whether the adminsistrator has disabled the 'Factory Reset' action on corporate owned devices.

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

### -IsRemoveDeviceDisabled
Boolean that represents whether the adminsistrator has disabled the 'Remove Device' action on corporate owned devices.

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

### -LandingPageCustomizedImage
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for LANDINGPAGECUSTOMIZEDIMAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIntuneBrandingProfile

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

