---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmobileappconfiguration
schema: 2.0.0
---

# New-MgDeviceAppMgtMobileAppConfiguration

## SYNOPSIS
Create new navigation property to mobileAppConfigurations for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtMobileAppConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>]
 [-DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]
 [-DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-TargetedMobileApps <String[]>]
 [-UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>]
 [-UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>] [-Version <Int32>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtMobileAppConfiguration -BodyParameter <IMicrosoftGraphManagedDeviceMobileAppConfiguration>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileAppConfigurations for deviceAppManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignemenets for app configration.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class for Mobile app configuration for enrolled devices.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
DateTime the object was created.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Admin provided description of the Device Configuration.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
List of ManagedDeviceMobileAppConfigurationDeviceStatus.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusSummary
Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
To construct, see NOTES section for DEVICESTATUSSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Admin provided name of the device configuration.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
DateTime the object was last modified.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this App configuration entity.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedMobileApps
the associated app.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatuses
List of ManagedDeviceMobileAppConfigurationUserStatus.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusSummary
Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
To construct, see NOTES section for USERSTATUSSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the device configuration.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNMENTS \<IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment1\[\]\>: The list of group assignemenets for app configration.
  \[Id \<String\>\]: Read-only.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphManagedDeviceMobileAppConfiguration1\>: An abstract class for Mobile app configuration for enrolled devices.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment1\[\]\>\]: The list of group assignemenets for app configration.
    \[Id \<String\>\]: Read-only.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CreatedDateTime \<DateTime?\>\]: DateTime the object was created.
  \[Description \<String\>\]: Admin provided description of the Device Configuration.
  \[DeviceStatusSummary \<IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary1\>\]: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ConfigurationVersion \<Int32?\>\]: Version of the policy for that overview
    \[ErrorCount \<Int32?\>\]: Number of error devices
    \[FailedCount \<Int32?\>\]: Number of failed devices
    \[LastUpdateDateTime \<DateTime?\>\]: Last update time
    \[NotApplicableCount \<Int32?\>\]: Number of not applicable devices
    \[PendingCount \<Int32?\>\]: Number of pending devices
    \[SuccessCount \<Int32?\>\]: Number of succeeded devices
  \[DeviceStatuses \<IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus\[\]\>\]: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
    \[Id \<String\>\]: Read-only.
    \[ComplianceGracePeriodExpirationDateTime \<DateTime?\>\]: The DateTime when device compliance grace period expires
    \[DeviceDisplayName \<String\>\]: Device name of the DevicePolicyStatus.
    \[DeviceModel \<String\>\]: The device model that is being reported
    \[LastReportedDateTime \<DateTime?\>\]: Last modified date time of the policy report.
    \[Status \<String\>\]: complianceStatus
    \[UserName \<String\>\]: The User Name that is being reported
    \[UserPrincipalName \<String\>\]: UserPrincipalName.
  \[DisplayName \<String\>\]: Admin provided name of the device configuration.
  \[LastModifiedDateTime \<DateTime?\>\]: DateTime the object was last modified.
  \[TargetedMobileApps \<String\[\]\>\]: the associated app.
  \[UserStatusSummary \<IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary1\>\]: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ConfigurationVersion \<Int32?\>\]: Version of the policy for that overview
    \[ErrorCount \<Int32?\>\]: Number of error Users
    \[FailedCount \<Int32?\>\]: Number of failed Users
    \[LastUpdateDateTime \<DateTime?\>\]: Last update time
    \[NotApplicableCount \<Int32?\>\]: Number of not applicable users
    \[PendingCount \<Int32?\>\]: Number of pending Users
    \[SuccessCount \<Int32?\>\]: Number of succeeded Users
  \[UserStatuses \<IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus\[\]\>\]: List of ManagedDeviceMobileAppConfigurationUserStatus.
    \[Id \<String\>\]: Read-only.
    \[DevicesCount \<Int32?\>\]: Devices count for that user.
    \[LastReportedDateTime \<DateTime?\>\]: Last modified date time of the policy report.
    \[Status \<String\>\]: complianceStatus
    \[UserDisplayName \<String\>\]: User name of the DevicePolicyStatus.
    \[UserPrincipalName \<String\>\]: UserPrincipalName.
  \[Version \<Int32?\>\]: Version of the device configuration.

DEVICESTATUSES \<IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus\[\]\>: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
  \[Id \<String\>\]: Read-only.
  \[ComplianceGracePeriodExpirationDateTime \<DateTime?\>\]: The DateTime when device compliance grace period expires
  \[DeviceDisplayName \<String\>\]: Device name of the DevicePolicyStatus.
  \[DeviceModel \<String\>\]: The device model that is being reported
  \[LastReportedDateTime \<DateTime?\>\]: Last modified date time of the policy report.
  \[Status \<String\>\]: complianceStatus
  \[UserName \<String\>\]: The User Name that is being reported
  \[UserPrincipalName \<String\>\]: UserPrincipalName.

DEVICESTATUSSUMMARY \<IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary1\>: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ConfigurationVersion \<Int32?\>\]: Version of the policy for that overview
  \[ErrorCount \<Int32?\>\]: Number of error devices
  \[FailedCount \<Int32?\>\]: Number of failed devices
  \[LastUpdateDateTime \<DateTime?\>\]: Last update time
  \[NotApplicableCount \<Int32?\>\]: Number of not applicable devices
  \[PendingCount \<Int32?\>\]: Number of pending devices
  \[SuccessCount \<Int32?\>\]: Number of succeeded devices

USERSTATUSES \<IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus\[\]\>: List of ManagedDeviceMobileAppConfigurationUserStatus.
  \[Id \<String\>\]: Read-only.
  \[DevicesCount \<Int32?\>\]: Devices count for that user.
  \[LastReportedDateTime \<DateTime?\>\]: Last modified date time of the policy report.
  \[Status \<String\>\]: complianceStatus
  \[UserDisplayName \<String\>\]: User name of the DevicePolicyStatus.
  \[UserPrincipalName \<String\>\]: UserPrincipalName.

USERSTATUSSUMMARY \<IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary1\>: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ConfigurationVersion \<Int32?\>\]: Version of the policy for that overview
  \[ErrorCount \<Int32?\>\]: Number of error Users
  \[FailedCount \<Int32?\>\]: Number of failed Users
  \[LastUpdateDateTime \<DateTime?\>\]: Last update time
  \[NotApplicableCount \<Int32?\>\]: Number of not applicable users
  \[PendingCount \<Int32?\>\]: Number of pending Users
  \[SuccessCount \<Int32?\>\]: Number of succeeded Users

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmobileappconfiguration](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmobileappconfiguration)

