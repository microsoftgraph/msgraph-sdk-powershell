---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgonpremisepublishingprofileagentgroup
schema: 2.0.0
---

# Update-MgOnPremisePublishingProfileAgentGroup

## SYNOPSIS
Update the navigation property agentGroups in onPremisesPublishingProfiles

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> [-AdditionalProperties <Hashtable>]
 [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update2
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded2
```
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> [-AdditionalProperties <Hashtable>]
 [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgOnPremisePublishingProfileAgentGroup -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property agentGroups in onPremisesPublishingProfiles

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Agents
.
To construct, see NOTES section for AGENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgent[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup
Parameter Sets: Update, Update1, Update2, UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentity2
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentity2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefault
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: Update, Update1, Update2, UpdateExpanded, UpdateExpanded1, UpdateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId1
key: id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
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
Type: System.String
Parameter Sets: Update1, Update2, UpdateExpanded1, UpdateExpanded2
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
Type: System.String
Parameter Sets: Update, Update1, Update2, UpdateExpanded, UpdateExpanded1, UpdateExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedResources
.
To construct, see NOTES section for PUBLISHEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublishedResource[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AGENTS <IMicrosoftGraphOnPremisesAgent[]>: .
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: 
    - `[DisplayName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
      - `[DisplayName <String>]`: 
      - `[PublishingType <String>]`: onPremisesPublishingType
      - `[ResourceName <String>]`: 
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ExternalIP <String>]`: 
  - `[MachineName <String>]`: 
  - `[Status <String>]`: agentStatus
  - `[SupportedPublishingTypes <String[]>]`: 

BODYPARAMETER <IMicrosoftGraphOnPremisesAgentGroup>: onPremisesAgentGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
    - `[ExternalIP <String>]`: 
    - `[MachineName <String>]`: 
    - `[Status <String>]`: agentStatus
    - `[SupportedPublishingTypes <String[]>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
    - `[DisplayName <String>]`: 
    - `[PublishingType <String>]`: onPremisesPublishingType
    - `[ResourceName <String>]`: 
  - `[PublishingType <String>]`: onPremisesPublishingType

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
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
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

PUBLISHEDRESOURCES <IMicrosoftGraphPublishedResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: 
      - `[ExternalIP <String>]`: 
      - `[MachineName <String>]`: 
      - `[Status <String>]`: agentStatus
      - `[SupportedPublishingTypes <String[]>]`: 
    - `[DisplayName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: 
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[DisplayName <String>]`: 
  - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ResourceName <String>]`: 

## RELATED LINKS

