---
external help file:
Module Name: Microsoft.Graph.Beta.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications/set-mgbetaapplicationsynchronizationsecret
schema: 2.0.0
---

# Set-MgBetaApplicationSynchronizationSecret

## SYNOPSIS
Update property secrets value.

## SYNTAX

### Set (Default)
```
Set-MgBetaApplicationSynchronizationSecret -ApplicationId <String>
 -BodyParameter <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgBetaApplicationSynchronizationSecret -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update property secrets value.

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

### -ApplicationId
The unique identifier of application

```yaml
Type: System.String
Parameter Sets: Set
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Array of microsoft.graph.synchronizationSecretKeyStringValuePair
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]
Parameter Sets: (All)
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IApplicationsIdentity
Parameter Sets: SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>`: Array of microsoft.graph.synchronizationSecretKeyStringValuePair
  - `[Key <String>]`: synchronizationSecret
  - `[Value <String>]`: The value of the secret.

`INPUTOBJECT <IApplicationsIdentity>`: Identity Parameter
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: The unique identifier of appRoleAssignment
  - `[ApplicationId <String>]`: The unique identifier of application
  - `[ApplicationTemplateId <String>]`: The unique identifier of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: The unique identifier of connectorGroup
  - `[ConnectorId <String>]`: The unique identifier of connector
  - `[DelegatedPermissionClassificationId <String>]`: The unique identifier of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: The unique identifier of directoryDefinition
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[ExtensionPropertyId <String>]`: The unique identifier of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: The unique identifier of federatedIdentityCredential
  - `[GroupId <String>]`: The unique identifier of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: The unique identifier of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: The unique identifier of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: The unique identifier of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: The unique identifier of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: The unique identifier of publishedResource
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[SynchronizationJobId <String>]`: The unique identifier of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: The unique identifier of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

