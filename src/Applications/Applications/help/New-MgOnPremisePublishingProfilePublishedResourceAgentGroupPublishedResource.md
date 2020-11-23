---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgonpremisepublishingprofilepublishedresourceagentgrouppublishedresource
schema: 2.0.0
---

# New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource

## SYNOPSIS
Create new navigation property to publishedResources for onPremisesPublishingProfiles

## SYNTAX

### CreateExpanded (Default)
```
New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> [-AdditionalProperties <Hashtable>]
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-DisplayName <String>] [-Id <String>]
 [-PublishingType <String>] [-ResourceName <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String>
 -BodyParameter <IMicrosoftGraphPublishedResource> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource
 -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-DisplayName <String>] [-Id <String>]
 [-PublishingType <String>] [-ResourceName <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource
 -InputObject <IApplicationsIdentity> -BodyParameter <IMicrosoftGraphPublishedResource> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to publishedResources for onPremisesPublishingProfiles

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgentGroups
.
To construct, see NOTES section for AGENTGROUPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesAgentGroup[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
publishedResource
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPublishedResource
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId
key: id of onPremisesAgentGroup

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedResourceId
key: id of publishedResource

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingType
onPremisesPublishingType

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublishedResource
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublishedResource
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

AGENTGROUPS \<IMicrosoftGraphOnPremisesAgentGroup\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[Agents \<IMicrosoftGraphOnPremisesAgent\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AgentGroups \<IMicrosoftGraphOnPremisesAgentGroup\[\]\>\]: 
    \[ExternalIP \<String\>\]: 
    \[MachineName \<String\>\]: 
    \[Status \<String\>\]: agentStatus
    \[SupportedPublishingTypes \<String\[\]\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[PublishedResources \<IMicrosoftGraphPublishedResource\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AgentGroups \<IMicrosoftGraphOnPremisesAgentGroup\[\]\>\]: 
    \[DisplayName \<String\>\]: 
    \[PublishingType \<String\>\]: onPremisesPublishingType
    \[ResourceName \<String\>\]: 
  \[PublishingType \<String\>\]: onPremisesPublishingType

BODYPARAMETER \<IMicrosoftGraphPublishedResource\>: publishedResource
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AgentGroups \<IMicrosoftGraphOnPremisesAgentGroup\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Agents \<IMicrosoftGraphOnPremisesAgent\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AgentGroups \<IMicrosoftGraphOnPremisesAgentGroup\[\]\>\]: 
      \[ExternalIP \<String\>\]: 
      \[MachineName \<String\>\]: 
      \[Status \<String\>\]: agentStatus
      \[SupportedPublishingTypes \<String\[\]\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[PublishedResources \<IMicrosoftGraphPublishedResource\[\]\>\]: 
    \[PublishingType \<String\>\]: onPremisesPublishingType
  \[DisplayName \<String\>\]: 
  \[PublishingType \<String\>\]: onPremisesPublishingType
  \[ResourceName \<String\>\]: 

INPUTOBJECT \<IApplicationsIdentity\>: Identity Parameter
  \[AppRoleAssignmentId \<String\>\]: key: id of appRoleAssignment
  \[ApplicationId \<String\>\]: key: id of application
  \[ApplicationTemplateId \<String\>\]: key: id of applicationTemplate
  \[ConnectorGroupId \<String\>\]: key: id of connectorGroup
  \[ConnectorId \<String\>\]: key: id of connector
  \[DelegatedPermissionClassificationId \<String\>\]: key: id of delegatedPermissionClassification
  \[DirectoryDefinitionId \<String\>\]: key: id of directoryDefinition
  \[EndpointId \<String\>\]: key: id of endpoint
  \[ExtensionPropertyId \<String\>\]: key: id of extensionProperty
  \[GroupId \<String\>\]: key: id of group
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[OnPremisesAgentGroupId \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentGroupId1 \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentId \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesAgentId1 \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesPublishingProfileId \<String\>\]: key: id of onPremisesPublishingProfile
  \[PublishedResourceId \<String\>\]: key: id of publishedResource
  \[PublishedResourceId1 \<String\>\]: key: id of publishedResource
  \[ServicePrincipalId \<String\>\]: key: id of servicePrincipal
  \[SynchronizationJobId \<String\>\]: key: id of synchronizationJob
  \[SynchronizationTemplateId \<String\>\]: key: id of synchronizationTemplate
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgonpremisepublishingprofilepublishedresourceagentgrouppublishedresource](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgonpremisepublishingprofilepublishedresourceagentgrouppublishedresource)

