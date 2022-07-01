---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgttargetedmanagedappconfiguration
schema: 2.0.0
---

# New-MgDeviceAppMgtTargetedManagedAppConfiguration

## SYNOPSIS
Create new navigation property to targetedManagedAppConfigurations for deviceAppManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceAppMgtTargetedManagedAppConfiguration [-AdditionalProperties <Hashtable>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>] [-CreatedDateTime <DateTime>]
 [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>] [-Version <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceAppMgtTargetedManagedAppConfiguration
 -BodyParameter <IMicrosoftGraphTargetedManagedAppConfiguration1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to targetedManagedAppConfigurations for deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Apps
List of apps to which the policy is deployed.
To construct, please use Get-Help -Online and see NOTES section for APPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedMobileApp[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the policy was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomSettings
A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
To construct, please use Get-Help -Online and see NOTES section for CUSTOMSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeployedAppCount
Count of apps to which the current policy is deployed.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, please use Get-Help -Online and see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicyDeploymentSummary
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The policy's description.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Policy display name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last time the policy was modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration1

## NOTES

ALIASES

### New-MgDeviceAppManagementTargetedManagedAppConfiguration

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPS <IMicrosoftGraphManagedMobileApp[]>: List of apps to which the policy is deployed.
  - `[Id <String>]`: 
  - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Version <String>]`: Version of the entity.

ASSIGNMENTS <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphTargetedManagedAppConfiguration1>: Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: 
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: 
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.

CUSTOMSETTINGS <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

DEPLOYMENTSUMMARY <IMicrosoftGraphManagedAppPolicyDeploymentSummary>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
  - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
    - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Not yet documented
  - `[LastRefreshTime <DateTime?>]`: Not yet documented
  - `[Version <String>]`: Version of the entity.

## RELATED LINKS

