---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicycrosstenantaccesspolicypartner
schema: 2.0.0
---

# New-MgPolicyCrossTenantAccessPolicyPartner

## SYNOPSIS
Create a new partner configuration in a cross-tenant access policy.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgPolicyCrossTenantAccessPolicyPartner [-AdditionalProperties <Hashtable>]
 [-B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>] [-IsServiceProvider]
 [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgPolicyCrossTenantAccessPolicyPartner
 -BodyParameter <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create a new partner configuration in a cross-tenant access policy.

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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InboundTrust
crossTenantAccessPolicyInboundTrust
To construct, please use Get-Help -Online and see NOTES section for INBOUNDTRUST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyInboundTrust
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

BODYPARAMETER <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner>: crossTenantAccessPolicyConfigurationPartner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>]`: crossTenantAccessPolicyInboundTrust
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
    - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
    - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.
  - `[IsServiceProvider <Boolean?>]`: Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.
  - `[TenantId <String>]`: The tenant identifier for the partner Azure AD organization. Read-only. Key.

INBOUNDTRUST <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>: crossTenantAccessPolicyInboundTrust
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
  - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
  - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.

## RELATED LINKS

