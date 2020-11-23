---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgonpremisepublishingprofileagentgrouppublishedresource
schema: 2.0.0
---

# Update-MgOnPremisePublishingProfileAgentGroupPublishedResource

## SYNOPSIS
Update the navigation property publishedResources in onPremisesPublishingProfiles

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> [-AdditionalProperties <Hashtable>]
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-DisplayName <String>] [-Id <String>]
 [-PublishingType <String>] [-ResourceName <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> -OnPremisesAgentId <String>
 [-AdditionalProperties <Hashtable>] [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]
 [-DisplayName <String>] [-Id <String>] [-PublishingType <String>] [-ResourceName <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update1
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> -OnPremisesAgentId <String>
 -BodyParameter <IMicrosoftGraphPublishedResource> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String>
 -BodyParameter <IMicrosoftGraphPublishedResource> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]
 [-DisplayName <String>] [-Id <String>] [-PublishingType <String>] [-ResourceName <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]
 [-DisplayName <String>] [-Id <String>] [-PublishingType <String>] [-ResourceName <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphPublishedResource> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOnPremisePublishingProfileAgentGroupPublishedResource -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphPublishedResource> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property publishedResources in onPremisesPublishingProfiles

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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: Update1, Update, UpdateViaIdentity1, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentity1, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, Update1, Update
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
Parameter Sets: UpdateExpanded1, Update1
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, Update1, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedResourceId
key: id of publishedResource

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateExpanded1, Update1, Update
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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

### System.Boolean
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgonpremisepublishingprofileagentgrouppublishedresource](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgonpremisepublishingprofileagentgrouppublishedresource)

