---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipalsynchronizationjobondemand
schema: 2.0.0
---

# New-MgServicePrincipalSynchronizationJobOnDemand

## SYNOPSIS
Invoke action provisionOnDemand

## SYNTAX

### ProvisionExpanded (Default)
```
New-MgServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId <String> -SynchronizationJobId <String>
 [-AdditionalProperties <Hashtable>] [-Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Provision
```
New-MgServicePrincipalSynchronizationJobOnDemand -ServicePrincipalId <String> -SynchronizationJobId <String>
 -BodyParameter <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ProvisionViaIdentityExpanded
```
New-MgServicePrincipalSynchronizationJobOnDemand -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ProvisionViaIdentity
```
New-MgServicePrincipalSynchronizationJobOnDemand -InputObject <IApplicationsIdentity>
 -BodyParameter <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action provisionOnDemand

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
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
Type: IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Provision, ProvisionViaIdentity
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
Type: IApplicationsIdentity
Parameter Sets: ProvisionViaIdentityExpanded, ProvisionViaIdentity
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
Type: IMicrosoftGraphSynchronizationJobApplicationParameters[]
Parameter Sets: ProvisionExpanded, ProvisionViaIdentityExpanded
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
Type: String
Parameter Sets: ProvisionExpanded, Provision
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
Type: String
Parameter Sets: ProvisionExpanded, Provision
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
Type: SwitchParameter
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
Type: SwitchParameter
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
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphStringKeyStringValuePair
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsJgtujvServiceprincipalsServiceprincipalIdSynchronizationJobsSynchronizationjobIdMicrosoftGraphProvisionondemandPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Parameters <IMicrosoftGraphSynchronizationJobApplicationParameters[]>]`: 
    - `[RuleId <String>]`: The identifier of a the synchronizationRule to be applied.
    - `[Subjects <IMicrosoftGraphSynchronizationJobSubject[]>]`: The identifiers of one or more objects to which a synchronizationJob is to be applied.
      - `[ObjectId <String>]`: The identifier of an object to which a synchronizationJob  is to be applied.
      - `[ObjectTypeName <String>]`: The type of the object to which a synchronizationJob  is to be applied.

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[UserId <String>]`: key: id of user

PARAMETERS <IMicrosoftGraphSynchronizationJobApplicationParameters[]>: .
  - `[RuleId <String>]`: The identifier of a the synchronizationRule to be applied.
  - `[Subjects <IMicrosoftGraphSynchronizationJobSubject[]>]`: The identifiers of one or more objects to which a synchronizationJob is to be applied.
    - `[ObjectId <String>]`: The identifier of an object to which a synchronizationJob  is to be applied.
    - `[ObjectTypeName <String>]`: The type of the object to which a synchronizationJob  is to be applied.

## RELATED LINKS
