---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.applications/new-mgserviceprincipalhomerealmdiscoverypolicybyref
schema: 2.0.0
---

# New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef

## SYNOPSIS
Create new navigation property ref to homeRealmDiscoveryPolicies for servicePrincipals

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId <String>
 [-AdditionalProperties <Hashtable>] [-OdataId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId <String>
 -BodyParameter <IReferenceCreate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef -InputObject <IApplicationsIdentity>
 -BodyParameter <IReferenceCreate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-OdataId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property ref to homeRealmDiscoveryPolicies for servicePrincipals

## EXAMPLES

### Example 1: Using the New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/policies/homeRealmDiscoveryPolicies/6c6f154f-cb39-4ff9-bf5b-62d5ad585cde"
}
New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```

This example shows how to use the New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IReferenceCreate
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OdataId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IReferenceCreate

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IReferenceCreate>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OdataId <String>]`: 

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: key: id of federatedIdentityCredential
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

