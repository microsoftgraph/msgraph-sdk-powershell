---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetapolicycrosstenantaccesspolicytemplate
schema: 2.0.0
---

# Update-MgBetaPolicyCrossTenantAccessPolicyTemplate

## SYNOPSIS
Update the navigation property templates in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaPolicyCrossTenantAccessPolicyTemplate [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-MultiTenantOrganizationIdentitySynchronization <IMicrosoftGraphMultiTenantOrganizationIdentitySyncPolicyTemplate>]
 [-MultiTenantOrganizationPartnerConfiguration <IMicrosoftGraphMultiTenantOrganizationPartnerConfigurationTemplate>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaPolicyCrossTenantAccessPolicyTemplate -BodyParameter <IMicrosoftGraphPolicyTemplate>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property templates in policies

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

### -BodyParameter
policyTemplate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPolicyTemplate
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiTenantOrganizationIdentitySynchronization
multiTenantOrganizationIdentitySyncPolicyTemplate
To construct, see NOTES section for MULTITENANTORGANIZATIONIDENTITYSYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationIdentitySyncPolicyTemplate
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MultiTenantOrganizationPartnerConfiguration
multiTenantOrganizationPartnerConfigurationTemplate
To construct, see NOTES section for MULTITENANTORGANIZATIONPARTNERCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationPartnerConfigurationTemplate
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPolicyTemplate

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPolicyTemplate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPolicyTemplate>`: policyTemplate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[MultiTenantOrganizationIdentitySynchronization <IMicrosoftGraphMultiTenantOrganizationIdentitySyncPolicyTemplate>]`: multiTenantOrganizationIdentitySyncPolicyTemplate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[TemplateApplicationLevel <String>]`: templateApplicationLevel
    - `[UserSyncInbound <IMicrosoftGraphCrossTenantUserSyncInbound>]`: crossTenantUserSyncInbound
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsSyncAllowed <Boolean?>]`: Defines whether user objects should be synchronized from the partner tenant. false causes any current user synchronization from the source tenant to the target tenant to stop. This property has no impact on existing users who have already been synchronized.
  - `[MultiTenantOrganizationPartnerConfiguration <IMicrosoftGraphMultiTenantOrganizationPartnerConfigurationTemplate>]`: multiTenantOrganizationPartnerConfigurationTemplate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
          - `[Target <String>]`: Can be one of the following values:  The unique identifier of the user, group, or application  AllUsers  AllApplications - Refers to any Microsoft cloud application.  Office365 - Includes the applications mentioned as part of the Office365 suite.
          - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
      - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
    - `[B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
    - `[B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
    - `[InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>]`: crossTenantAccessPolicyInboundTrust
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Microsoft Entra organizations are trusted.
      - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether Microsoft Entra hybrid joined devices from external Microsoft Entra organizations are trusted.
      - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Microsoft Entra organizations is trusted.
    - `[TemplateApplicationLevel <String>]`: templateApplicationLevel

`MULTITENANTORGANIZATIONIDENTITYSYNCHRONIZATION <IMicrosoftGraphMultiTenantOrganizationIdentitySyncPolicyTemplate>`: multiTenantOrganizationIdentitySyncPolicyTemplate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[TemplateApplicationLevel <String>]`: templateApplicationLevel
  - `[UserSyncInbound <IMicrosoftGraphCrossTenantUserSyncInbound>]`: crossTenantUserSyncInbound
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsSyncAllowed <Boolean?>]`: Defines whether user objects should be synchronized from the partner tenant. false causes any current user synchronization from the source tenant to the target tenant to stop. This property has no impact on existing users who have already been synchronized.

`MULTITENANTORGANIZATIONPARTNERCONFIGURATION <IMicrosoftGraphMultiTenantOrganizationPartnerConfigurationTemplate>`: multiTenantOrganizationPartnerConfigurationTemplate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[Target <String>]`: Can be one of the following values:  The unique identifier of the user, group, or application  AllUsers  AllApplications - Refers to any Microsoft cloud application.  Office365 - Includes the applications mentioned as part of the Office365 suite.
        - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
    - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
  - `[B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>]`: crossTenantAccessPolicyInboundTrust
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Microsoft Entra organizations are trusted.
    - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether Microsoft Entra hybrid joined devices from external Microsoft Entra organizations are trusted.
    - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Microsoft Entra organizations is trusted.
  - `[TemplateApplicationLevel <String>]`: templateApplicationLevel

## RELATED LINKS

