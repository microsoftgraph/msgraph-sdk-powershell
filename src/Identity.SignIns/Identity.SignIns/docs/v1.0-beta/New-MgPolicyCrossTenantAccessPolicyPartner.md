---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicycrosstenantaccesspolicypartner
schema: 2.0.0
---

# New-MgPolicyCrossTenantAccessPolicyPartner

## SYNOPSIS
Create new navigation property to partners for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyCrossTenantAccessPolicyPartner [-AdditionalProperties <Hashtable>]
 [-AutomaticUserConsentSettings <IMicrosoftGraphInboundOutboundPolicyConfiguration>]
 [-B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-IdentitySynchronization <IMicrosoftGraphCrossTenantIdentitySyncPolicyPartner>]
 [-InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>] [-IsServiceProvider]
 [-TenantId <String>] [-TenantRestrictions <IMicrosoftGraphCrossTenantAccessPolicyTenantRestrictions>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPolicyCrossTenantAccessPolicyPartner
 -BodyParameter <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to partners for policies

## EXAMPLES

### Example 1: Using the New-MgPolicyCrossTenantAccessPolicyPartner Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	TenantId = "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"
	B2bDirectConnectOutbound = @{
		UsersAndGroups = @{
			AccessType = "blocked"
			Targets = @(
				@{
					Target = "6f546279-4da5-4b53-a095-09ea0cef9971"
					TargetType = "group"
				}
			)
		}
	}
	B2bDirectConnectInbound = @{
		Applications = @{
			AccessType = "allowed"
			Targets = @(
				@{
					Target = "Office365"
					TargetType = "application"
				}
			)
		}
	}
}
New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $params
```

This example shows how to use the New-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -AutomaticUserConsentSettings
inboundOutboundPolicyConfiguration
To construct, please use Get-Help -Online and see NOTES section for AUTOMATICUSERCONSENTSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInboundOutboundPolicyConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BCollaborationInbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BCOLLABORATIONINBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BCollaborationOutbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BCOLLABORATIONOUTBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BDirectConnectInbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BDIRECTCONNECTINBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BDirectConnectOutbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BDIRECTCONNECTOUTBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
crossTenantAccessPolicyConfigurationPartner
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IdentitySynchronization
crossTenantIdentitySyncPolicyPartner
To construct, please use Get-Help -Online and see NOTES section for IDENTITYSYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantIdentitySyncPolicyPartner
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InboundTrust
crossTenantAccessPolicyInboundTrust
To construct, please use Get-Help -Online and see NOTES section for INBOUNDTRUST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyInboundTrust
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsServiceProvider
Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.

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

### -TenantId
The tenant identifier for the partner Azure AD organization.
Read-only.
Key.

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

### -TenantRestrictions
crossTenantAccessPolicyTenantRestrictions
To construct, please use Get-Help -Online and see NOTES section for TENANTRESTRICTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyTenantRestrictions
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AUTOMATICUSERCONSENTSETTINGS <IMicrosoftGraphInboundOutboundPolicyConfiguration>: inboundOutboundPolicyConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[InboundAllowed <Boolean?>]`: Defines whether external users coming inbound are allowed.
  - `[OutboundAllowed <Boolean?>]`: Defines whether internal users are allowed to go outbound.

B2BCOLLABORATIONINBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BCOLLABORATIONOUTBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BDIRECTCONNECTINBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BDIRECTCONNECTOUTBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

BODYPARAMETER <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner1>: crossTenantAccessPolicyConfigurationPartner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AutomaticUserConsentSettings <IMicrosoftGraphInboundOutboundPolicyConfiguration>]`: inboundOutboundPolicyConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[InboundAllowed <Boolean?>]`: Defines whether external users coming inbound are allowed.
    - `[OutboundAllowed <Boolean?>]`: Defines whether internal users are allowed to go outbound.
  - `[B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
      - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
        - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
        - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
    - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
  - `[B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[IdentitySynchronization <IMicrosoftGraphCrossTenantIdentitySyncPolicyPartner>]`: crossTenantIdentitySyncPolicyPartner
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: Display name for the cross-tenant user synchronization policy. Use the name of the partner Azure AD tenant to easily identify the policy. Optional.
    - `[TenantId <String>]`: Tenant identifier for the partner Azure AD organization. Read-only.
    - `[UserSyncInbound <IMicrosoftGraphCrossTenantUserSyncInbound>]`: crossTenantUserSyncInbound
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsSyncAllowed <Boolean?>]`: Defines whether user objects should be synchronized from the partner tenant. If set to false, any current user synchronization from the source tenant to the target tenant will stop. There is no impact on existing users that have already been synchronized.
  - `[InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>]`: crossTenantAccessPolicyInboundTrust
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
    - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
    - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.
  - `[IsServiceProvider <Boolean?>]`: Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.
  - `[TenantId <String>]`: The tenant identifier for the partner Azure AD organization. Read-only. Key.
  - `[TenantRestrictions <IMicrosoftGraphCrossTenantAccessPolicyTenantRestrictions>]`: crossTenantAccessPolicyTenantRestrictions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[Devices <IMicrosoftGraphDevicesFilter>]`: devicesFilter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Mode <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
      - `[Rule <String>]`: 

IDENTITYSYNCHRONIZATION <IMicrosoftGraphCrossTenantIdentitySyncPolicyPartner>: crossTenantIdentitySyncPolicyPartner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Display name for the cross-tenant user synchronization policy. Use the name of the partner Azure AD tenant to easily identify the policy. Optional.
  - `[TenantId <String>]`: Tenant identifier for the partner Azure AD organization. Read-only.
  - `[UserSyncInbound <IMicrosoftGraphCrossTenantUserSyncInbound>]`: crossTenantUserSyncInbound
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsSyncAllowed <Boolean?>]`: Defines whether user objects should be synchronized from the partner tenant. If set to false, any current user synchronization from the source tenant to the target tenant will stop. There is no impact on existing users that have already been synchronized.

INBOUNDTRUST <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>: crossTenantAccessPolicyInboundTrust
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
  - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
  - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.

TENANTRESTRICTIONS <IMicrosoftGraphCrossTenantAccessPolicyTenantRestrictions>: crossTenantAccessPolicyTenantRestrictions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
  - `[Devices <IMicrosoftGraphDevicesFilter>]`: devicesFilter
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Mode <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Rule <String>]`: 

## RELATED LINKS

