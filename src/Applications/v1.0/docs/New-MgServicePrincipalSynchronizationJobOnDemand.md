---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationjobondemand
schema: 2.0.0
---

# New-MgServicePrincipalSynchronizationJobOnDemand

## SYNOPSIS
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

## SYNTAX

### ProvisionExpanded (Default)
```
New-MgServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId <String> -SynchronizationJobId <String>
 [-AdditionalProperties <Hashtable>] [-Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Provision
```
New-MgServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId <String> -SynchronizationJobId <String>
 -BodyParameter <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ProvisionViaIdentity
```
New-MgServicePrincipalSynchronizationJobOnDemand -InputObject <IApplicationsIdentity>
 -BodyParameter <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ProvisionViaIdentityExpanded
```
New-MgServicePrincipalSynchronizationJobOnDemand -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

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
Parameter Sets: ProvisionExpanded, ProvisionViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Provision, ProvisionViaIdentity
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: ProvisionViaIdentity, ProvisionViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Parameters
.
To construct, see NOTES section for PARAMETERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJobApplicationParameters[]
Parameter Sets: ProvisionExpanded, ProvisionViaIdentityExpanded
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

### -ServicePrincipalId
The unique identifier of servicePrincipal

```yaml
Type: System.String
Parameter Sets: Provision, ProvisionExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationJobId
The unique identifier of synchronizationJob

```yaml
Type: System.String
Parameter Sets: Provision, ProvisionExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphStringKeyStringValuePair

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]`: 
    - `[RuleId <String>]`: The identifier of the synchronizationRule to be applied. This rule ID is defined in the schema for a given synchronization job or template.
    - `[Subjects <IMicrosoftGraphSynchronizationJobSubject[]>]`: The identifiers of one or more objects to which a synchronizationJob is to be applied.
      - `[Links <IMicrosoftGraphSynchronizationLinkedObjects>]`: synchronizationLinkedObjects
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Manager <IMicrosoftGraphSynchronizationJobSubject>]`: synchronizationJobSubject
        - `[Members <IMicrosoftGraphSynchronizationJobSubject[]>]`: All group members that you would like to provision.
        - `[Owners <IMicrosoftGraphSynchronizationJobSubject[]>]`: 
      - `[ObjectId <String>]`: The identifier of an object to which a synchronizationJob is to be applied. Can be one of the following: An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD.The user ID for synchronization from Microsoft Entra ID to a third-party.The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Microsoft Entra ID.
      - `[ObjectTypeName <String>]`: The type of the object to which a synchronizationJob is to be applied. Can be one of the following: user for synchronizing between Active Directory and Azure AD.User for synchronizing a user between Microsoft Entra ID and a third-party application. Worker for synchronization a user between Workday and either Active Directory or Microsoft Entra ID.Group for synchronizing a group between Microsoft Entra ID and a third-party application.

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
  - `[UniqueName <String>]`: Alternate key of application
  - `[UserId <String>]`: The unique identifier of user

`PARAMETERS <IMicrosoftGraphSynchronizationJobApplicationParameters[]>`: .
  - `[RuleId <String>]`: The identifier of the synchronizationRule to be applied. This rule ID is defined in the schema for a given synchronization job or template.
  - `[Subjects <IMicrosoftGraphSynchronizationJobSubject[]>]`: The identifiers of one or more objects to which a synchronizationJob is to be applied.
    - `[Links <IMicrosoftGraphSynchronizationLinkedObjects>]`: synchronizationLinkedObjects
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Manager <IMicrosoftGraphSynchronizationJobSubject>]`: synchronizationJobSubject
      - `[Members <IMicrosoftGraphSynchronizationJobSubject[]>]`: All group members that you would like to provision.
      - `[Owners <IMicrosoftGraphSynchronizationJobSubject[]>]`: 
    - `[ObjectId <String>]`: The identifier of an object to which a synchronizationJob is to be applied. Can be one of the following: An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD.The user ID for synchronization from Microsoft Entra ID to a third-party.The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Microsoft Entra ID.
    - `[ObjectTypeName <String>]`: The type of the object to which a synchronizationJob is to be applied. Can be one of the following: user for synchronizing between Active Directory and Azure AD.User for synchronizing a user between Microsoft Entra ID and a third-party application. Worker for synchronization a user between Workday and either Active Directory or Microsoft Entra ID.Group for synchronizing a group between Microsoft Entra ID and a third-party application.

## RELATED LINKS

