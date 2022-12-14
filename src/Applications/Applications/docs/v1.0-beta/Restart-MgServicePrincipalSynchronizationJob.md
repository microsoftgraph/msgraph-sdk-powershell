---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.applications/restart-mgserviceprincipalsynchronizationjob
schema: 2.0.0
---

# Restart-MgBetaServicePrincipalSynchronizationJob

## SYNOPSIS
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

## SYNTAX

### RestartExpanded (Default)
```
Restart-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId <String> -SynchronizationJobId <String>
 [-AdditionalProperties <Hashtable>] [-Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Restart
```
Restart-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId <String> -SynchronizationJobId <String>
 -BodyParameter <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestartViaIdentity
```
Restart-MgBetaServicePrincipalSynchronizationJob -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestartViaIdentityExpanded
```
Restart-MgBetaServicePrincipalSynchronizationJob -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

## EXAMPLES

### Example 1: Using the Restart-MgBetaServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Criteria = @{
		ResetScope = "Watermark, Escrows, QuarantineState"
	}
}
Restart-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```

This example shows how to use the Restart-MgBetaServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RestartExpanded, RestartViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Restart, RestartViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Criteria
synchronizationJobRestartCriteria
To construct, please use Get-Help -Online and see NOTES section for CRITERIA properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSynchronizationJobRestartCriteria
Parameter Sets: RestartExpanded, RestartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
Parameter Sets: RestartViaIdentity, RestartViaIdentityExpanded
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

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: System.String
Parameter Sets: Restart, RestartExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobId
key: id of synchronizationJob

```yaml
Type: System.String
Parameter Sets: Restart, RestartExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths7MrbavServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphRestartPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Criteria <IMicrosoftGraphSynchronizationJobRestartCriteria>]`: synchronizationJobRestartCriteria
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ResetScope <String>]`: synchronizationJobRestartScope

CRITERIA <IMicrosoftGraphSynchronizationJobRestartCriteria>: synchronizationJobRestartCriteria
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ResetScope <String>]`: synchronizationJobRestartScope

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

