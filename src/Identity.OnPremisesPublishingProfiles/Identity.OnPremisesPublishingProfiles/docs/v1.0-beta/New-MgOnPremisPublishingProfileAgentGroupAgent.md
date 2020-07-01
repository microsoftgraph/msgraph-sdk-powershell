---
external help file:
Module Name: Microsoft.Graph.Identity.OnPremisesPublishingProfiles
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.onpremisespublishingprofiles/new-mgonpremispublishingprofileagentgroupagent
schema: 2.0.0
---

# New-MgOnPremisPublishingProfileAgentGroupAgent

## SYNOPSIS
Create new navigation property to agents for onPremisesPublishingProfiles

## SYNTAX

### CreateExpanded (Default)
```
New-MgOnPremisPublishingProfileAgentGroupAgent -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]
 [-ExternalIP <String>] [-Id <String>] [-MachineName <String>] [-Status <String>]
 [-SupportedPublishingTypes <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOnPremisPublishingProfileAgentGroupAgent -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -BodyParameter <IMicrosoftGraphOnPremisesAgent> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgOnPremisPublishingProfileAgentGroupAgent -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> -BodyParameter <IMicrosoftGraphOnPremisesAgent> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded1
```
New-MgOnPremisPublishingProfileAgentGroupAgent -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]
 [-ExternalIP <String>] [-Id <String>] [-MachineName <String>] [-Status <String>]
 [-SupportedPublishingTypes <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOnPremisPublishingProfileAgentGroupAgent -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgent> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgOnPremisPublishingProfileAgentGroupAgent -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgent> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOnPremisPublishingProfileAgentGroupAgent -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-ExternalIP <String>] [-Id <String>]
 [-MachineName <String>] [-Status <String>] [-SupportedPublishingTypes <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgOnPremisPublishingProfileAgentGroupAgent -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-ExternalIP <String>] [-Id <String>]
 [-MachineName <String>] [-Status <String>] [-SupportedPublishingTypes <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to agents for onPremisesPublishingProfiles

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

### -AgentGroups
.
To construct, see NOTES section for AGENTGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup[]
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onPremisesAgent
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgent
Parameter Sets: Create, Create1, CreateViaIdentity, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExternalIP
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentity1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MachineName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Create, Create1, CreateExpanded, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentId
key: onPremisesAgent-id of onPremisesAgent

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesPublishingProfileId
key: onPremisesPublishingProfile-id of onPremisesPublishingProfile

```yaml
Type: System.String
Parameter Sets: Create, Create1, CreateExpanded, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
agentStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedPublishingTypes
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AGENTGROUPS <IMicrosoftGraphOnPremisesAgentGroup[]>: .
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

BODYPARAMETER <IMicrosoftGraphOnPremisesAgent>: onPremisesAgent
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

INPUTOBJECT <IIdentityOnPremisesPublishingProfilesIdentity>: Identity Parameter
  - `[ConnectorGroupId <String>]`: key: connectorGroup-id of connectorGroup
  - `[ConnectorId <String>]`: key: connector-id of connector
  - `[OnPremisesAgentGroupId <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: onPremisesPublishingProfile-id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: publishedResource-id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: publishedResource-id of publishedResource

## RELATED LINKS

