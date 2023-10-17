---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetapolicydeviceregistrationpolicy
schema: 2.0.0
---

# Update-MgBetaPolicyDeviceRegistrationPolicy

## SYNOPSIS
Update the properties of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaPolicyDeviceRegistrationPolicy [-AdditionalProperties <Hashtable>]
 [-AzureAdJoin <IMicrosoftGraphAzureAdJoinPolicy>]
 [-AzureAdRegistration <IMicrosoftGraphAzureAdRegistrationPolicy>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LocalAdminPassword <IMicrosoftGraphLocalAdminPasswordSettings>]
 [-MultiFactorAuthConfiguration <String>] [-UserDeviceQuota <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaPolicyDeviceRegistrationPolicy -BodyParameter <IMicrosoftGraphDeviceRegistrationPolicy>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdJoin
azureAdJoinPolicy
To construct, see NOTES section for AZUREADJOIN properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAzureAdJoinPolicy
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureAdRegistration
azureADRegistrationPolicy
To construct, see NOTES section for AZUREADREGISTRATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAzureAdRegistrationPolicy
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
deviceRegistrationPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceRegistrationPolicy
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The description of the device registration policy.
It's always set to Tenant-wide policy that manages intial provisioning controls using quota restrictions, additional authentication and authorization checks.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the device registration policy.
It's always set to Device Registration Policy.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocalAdminPassword
localAdminPasswordSettings
To construct, see NOTES section for LOCALADMINPASSWORD properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocalAdminPasswordSettings
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiFactorAuthConfiguration
multiFactorAuthConfiguration

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserDeviceQuota
Specifies the maximum number of devices that a user can have within your organization before blocking new device registrations.
The default value is set to 50.
If this property isn't specified during the policy update operation, it's automatically reset to 0 to indicate that users aren't allowed to join any devices.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceRegistrationPolicy

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceRegistrationPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AZUREADJOIN <IMicrosoftGraphAzureAdJoinPolicy>`: azureAdJoinPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedGroups <String[]>]`: The identifiers of the groups that are in the scope of the policy. Required when the appliesTo property is set to selected.
  - `[AllowedUsers <String[]>]`: The identifiers of users that are in the scope of the policy. Required when the appliesTo property is set to selected.
  - `[AppliesTo <String>]`: policyScope
  - `[IsAdminConfigurable <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. When an admin has enabled Intune (MEM) to manage devices, this property is set to false and appliesTo defaults to 1 (meaning all).

`AZUREADREGISTRATION <IMicrosoftGraphAzureAdRegistrationPolicy>`: azureADRegistrationPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedGroups <String[]>]`: The identifiers of the groups that are in the scope of the policy. Either this property or allowedUsers is required when the appliesTo property is set to selected.
  - `[AllowedUsers <String[]>]`: The identifiers of users that are in the scope of the policy. Either this property or allowedGroups is required when the appliesTo property is set to selected.
  - `[AppliesTo <String>]`: policyScope
  - `[IsAdminConfigurable <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. When an admin has enabled Intune (MEM) to manage devices, this property is set to false and appliesTo defaults to 1 (meaning all).

`BODYPARAMETER <IMicrosoftGraphDeviceRegistrationPolicy>`: deviceRegistrationPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AzureAdJoin <IMicrosoftGraphAzureAdJoinPolicy>]`: azureAdJoinPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedGroups <String[]>]`: The identifiers of the groups that are in the scope of the policy. Required when the appliesTo property is set to selected.
    - `[AllowedUsers <String[]>]`: The identifiers of users that are in the scope of the policy. Required when the appliesTo property is set to selected.
    - `[AppliesTo <String>]`: policyScope
    - `[IsAdminConfigurable <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. When an admin has enabled Intune (MEM) to manage devices, this property is set to false and appliesTo defaults to 1 (meaning all).
  - `[AzureAdRegistration <IMicrosoftGraphAzureAdRegistrationPolicy>]`: azureADRegistrationPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedGroups <String[]>]`: The identifiers of the groups that are in the scope of the policy. Either this property or allowedUsers is required when the appliesTo property is set to selected.
    - `[AllowedUsers <String[]>]`: The identifiers of users that are in the scope of the policy. Either this property or allowedGroups is required when the appliesTo property is set to selected.
    - `[AppliesTo <String>]`: policyScope
    - `[IsAdminConfigurable <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. When an admin has enabled Intune (MEM) to manage devices, this property is set to false and appliesTo defaults to 1 (meaning all).
  - `[Description <String>]`: The description of the device registration policy. It's always set to Tenant-wide policy that manages intial provisioning controls using quota restrictions, additional authentication and authorization checks. Read-only.
  - `[DisplayName <String>]`: The name of the device registration policy. It's always set to Device Registration Policy. Read-only.
  - `[LocalAdminPassword <IMicrosoftGraphLocalAdminPasswordSettings>]`: localAdminPasswordSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. An admin can set it to true to enable Local Admin Password Solution (LAPS) within their organzation.
  - `[MultiFactorAuthConfiguration <String>]`: multiFactorAuthConfiguration
  - `[UserDeviceQuota <Int32?>]`: Specifies the maximum number of devices that a user can have within your organization before blocking new device registrations. The default value is set to 50. If this property isn't specified during the policy update operation, it's automatically reset to 0 to indicate that users aren't allowed to join any devices.

`LOCALADMINPASSWORD <IMicrosoftGraphLocalAdminPasswordSettings>`: localAdminPasswordSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsEnabled <Boolean?>]`: Specifies whether this policy scope is configurable by the admin. The default value is false. An admin can set it to true to enable Local Admin Password Solution (LAPS) within their organzation.

## RELATED LINKS

