---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/update-mgserviceprincipalremotedesktopsecurityconfiguration
schema: 2.0.0
---

# Update-MgServicePrincipalRemoteDesktopSecurityConfiguration

## SYNOPSIS
Update the properties of a remoteDesktopSecurityConfiguration object on the servicePrincipal.
Use this configuration to enable or disable the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to authenticate a user to Microsoft Entra joined or Microsoft Entra hybrid joined devices.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgServicePrincipalRemoteDesktopSecurityConfiguration -ServicePrincipalId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-IsRemoteDesktopProtocolEnabled]
 [-TargetDeviceGroups <IMicrosoftGraphTargetDeviceGroup[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgServicePrincipalRemoteDesktopSecurityConfiguration -ServicePrincipalId <String>
 -BodyParameter <IMicrosoftGraphRemoteDesktopSecurityConfiguration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgServicePrincipalRemoteDesktopSecurityConfiguration -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphRemoteDesktopSecurityConfiguration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgServicePrincipalRemoteDesktopSecurityConfiguration -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-IsRemoteDesktopProtocolEnabled]
 [-TargetDeviceGroups <IMicrosoftGraphTargetDeviceGroup[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a remoteDesktopSecurityConfiguration object on the servicePrincipal.
Use this configuration to enable or disable the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to authenticate a user to Microsoft Entra joined or Microsoft Entra hybrid joined devices.

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
remoteDesktopSecurityConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteDesktopSecurityConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsRemoteDesktopProtocolEnabled
Determines if Microsoft Entra ID RDS authentication protocol for RDP is enabled.

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

### -ServicePrincipalId
The unique identifier of servicePrincipal

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

### -TargetDeviceGroups
The collection of target device groups that are associated with the RDS security configuration that will be enabled for SSO when a client connects to the target device over RDP using the new Microsoft Entra ID RDS authentication protocol.
To construct, see NOTES section for TARGETDEVICEGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetDeviceGroup[]
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteDesktopSecurityConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRemoteDesktopSecurityConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphRemoteDesktopSecurityConfiguration>`: remoteDesktopSecurityConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsRemoteDesktopProtocolEnabled <Boolean?>]`: Determines if Microsoft Entra ID RDS authentication protocol for RDP is enabled.
  - `[TargetDeviceGroups <IMicrosoftGraphTargetDeviceGroup[]>]`: The collection of target device groups that are associated with the RDS security configuration that will be enabled for SSO when a client connects to the target device over RDP using the new Microsoft Entra ID RDS authentication protocol.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: Display name for the target device group.

`INPUTOBJECT <IApplicationsIdentity>`: Identity Parameter
  - `[AppId <String>]`: Alternate key of application
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: The unique identifier of appRoleAssignment
  - `[ApplicationId <String>]`: The unique identifier of application
  - `[ApplicationTemplateId <String>]`: The unique identifier of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[DelegatedPermissionClassificationId <String>]`: The unique identifier of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: The unique identifier of directoryDefinition
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[ExtensionPropertyId <String>]`: The unique identifier of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: The unique identifier of federatedIdentityCredential
  - `[GroupId <String>]`: The unique identifier of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SynchronizationJobId <String>]`: The unique identifier of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: The unique identifier of synchronizationTemplate
  - `[TargetDeviceGroupId <String>]`: The unique identifier of targetDeviceGroup
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UserId <String>]`: The unique identifier of user

`TARGETDEVICEGROUPS <IMicrosoftGraphTargetDeviceGroup[]>`: The collection of target device groups that are associated with the RDS security configuration that will be enabled for SSO when a client connects to the target device over RDP using the new Microsoft Entra ID RDS authentication protocol.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: Display name for the target device group.

## RELATED LINKS

