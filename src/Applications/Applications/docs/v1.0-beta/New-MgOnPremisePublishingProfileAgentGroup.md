---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgonpremisepublishingprofileagentgroup
schema: 2.0.0
---

# New-MgOnPremisePublishingProfileAgentGroup

## SYNOPSIS
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

## SYNTAX

### CreateExpanded (Default)
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateExpanded2
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String> -OnPremisesAgentId <String>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateExpanded1
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String>
 -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String> [-AdditionalProperties <Hashtable>]
 [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create2
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String> -OnPremisesAgentId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String>
 -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded2
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity2
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Agents
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.
To construct, see NOTES section for AGENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesAgent[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onPremisesAgentGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesAgentGroup
Parameter Sets: Create2, Create1, Create, CreateViaIdentity2, CreateViaIdentity1, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Display name of the onPremisesAgentGroup.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
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
Type: IApplicationsIdentity
Parameter Sets: CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded, CreateViaIdentity2, CreateViaIdentity1, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefault
Indicates if the onPremisesAgentGroup is the default agent group.
Only a single agent group can be the default onPremisesAgentGroup and is set by the system.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId
key: id of onPremisesAgentGroup

```yaml
Type: String
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentId
key: id of onPremisesAgent

```yaml
Type: String
Parameter Sets: CreateExpanded2, CreateExpanded1, Create2, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesPublishingProfileId
key: id of onPremisesPublishingProfile

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, Create2, Create1, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedResources
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.
To construct, see NOTES section for PUBLISHEDRESOURCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPublishedResource[]
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingType
onPremisesPublishingType

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateExpanded2, CreateExpanded1, CreateViaIdentityExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AGENTS <IMicrosoftGraphOnPremisesAgent[]>: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
    - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
      - `[DisplayName <String>]`: Display Name of the publishedResource.
      - `[PublishingType <String>]`: onPremisesPublishingType
      - `[ResourceName <String>]`: Name of the publishedResource.
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
  - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
  - `[Status <String>]`: agentStatus
  - `[SupportedPublishingTypes <String[]>]`: 

BODYPARAMETER <IMicrosoftGraphOnPremisesAgentGroup>: onPremisesAgentGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
    - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
    - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
    - `[Status <String>]`: agentStatus
    - `[SupportedPublishingTypes <String[]>]`: 
  - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
  - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
  - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
    - `[DisplayName <String>]`: Display Name of the publishedResource.
    - `[PublishingType <String>]`: onPremisesPublishingType
    - `[ResourceName <String>]`: Name of the publishedResource.
  - `[PublishingType <String>]`: onPremisesPublishingType

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

PUBLISHEDRESOURCES <IMicrosoftGraphPublishedResource[]>: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
      - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
      - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
      - `[Status <String>]`: agentStatus
      - `[SupportedPublishingTypes <String[]>]`: 
    - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
    - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[DisplayName <String>]`: Display Name of the publishedResource.
  - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ResourceName <String>]`: Name of the publishedResource.

## RELATED LINKS
