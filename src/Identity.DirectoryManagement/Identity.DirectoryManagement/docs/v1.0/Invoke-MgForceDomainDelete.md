---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/invoke-mgforcedomaindelete
schema: 2.0.0
---

# Invoke-MgForceDomainDelete

## SYNOPSIS
Invoke action forceDelete

## SYNTAX

### ForceExpanded1 (Default)
```
Invoke-MgForceDomainDelete -DomainId <String> [-AdditionalProperties <Hashtable>] [-DisableUserAccounts]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Force1
```
Invoke-MgForceDomainDelete -DomainId <String>
 -BodyParameter <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForceViaIdentity1
```
Invoke-MgForceDomainDelete -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForceViaIdentityExpanded1
```
Invoke-MgForceDomainDelete -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-DisableUserAccounts] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action forceDelete

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ForceExpanded1, ForceViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Force1, ForceViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisableUserAccounts
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ForceExpanded1, ForceViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainId
key: id of domain

```yaml
Type: System.String
Parameter Sets: Force1, ForceExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: ForceViaIdentity1, ForceViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.PowerShell.Models.IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsUasdopDomainsDomainIdMicrosoftGraphForcedeletePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisableUserAccounts <Boolean?>]`: 

INPUTOBJECT <IIdentityDirectoryManagementIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: id of administrativeUnit
  - `[CommandId <String>]`: key: id of command
  - `[ContractId <String>]`: key: id of contract
  - `[DeviceId <String>]`: key: id of device
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectoryRoleId <String>]`: key: id of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: key: id of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DirectorySettingTemplateId <String>]`: key: id of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: key: id of domainDnsRecord
  - `[DomainId <String>]`: key: id of domain
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[OrgContactId <String>]`: key: id of orgContact
  - `[OrganizationId <String>]`: key: id of organization
  - `[ProfileCardPropertyId <String>]`: key: id of profileCardProperty
  - `[ScopedRoleMembershipId <String>]`: key: id of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: key: id of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: key: id of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: key: id of subscribedSku
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

