---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/get-mgserviceprincipalmembergroup
schema: 2.0.0
---

# Get-MgServicePrincipalMemberGroup

## SYNOPSIS
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

## SYNTAX

### GetExpanded (Default)
```
Get-MgServicePrincipalMemberGroup -ServicePrincipalId <String> [-AdditionalProperties <Hashtable>]
 [-SecurityEnabledOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgServicePrincipalMemberGroup -ServicePrincipalId <String>
 -BodyParameter <IPaths1850388ServiceprincipalsServiceprincipalIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgServicePrincipalMemberGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths1850388ServiceprincipalsServiceprincipalIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded
```
Get-MgServicePrincipalMemberGroup -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-SecurityEnabledOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.DirectoryObjects
```

$params = @{
	SecurityEnabledOnly = $false
}

Get-MgDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Users.Actions
```

$params = @{
	SecurityEnabledOnly = $true
}

# A UPN can also be used as -UserId.
Get-MgUserMemberGroup -UserId $userId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1850388ServiceprincipalsServiceprincipalIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: GetViaIdentity, GetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SecurityEnabledOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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
Parameter Sets: Get, GetExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IPaths1850388ServiceprincipalsServiceprincipalIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1850388ServiceprincipalsServiceprincipalIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SecurityEnabledOnly <Boolean?>]`: 

`INPUTOBJECT <IApplicationsIdentity>`: Identity Parameter
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
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

