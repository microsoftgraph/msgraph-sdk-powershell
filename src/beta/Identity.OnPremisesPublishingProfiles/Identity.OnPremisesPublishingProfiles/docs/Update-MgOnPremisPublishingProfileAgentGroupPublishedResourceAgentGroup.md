---
external help file:
Module Name: Microsoft.Graph.Identity.OnPremisesPublishingProfiles
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.onpremisespublishingprofiles/update-mgonpremispublishingprofileagentgrouppublishedresourceagentgroup
schema: 2.0.0
---

# Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup

## SYNOPSIS
Update the navigation property agentGroups in onPremisesPublishingProfiles

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesPublishingProfileId <String> -PublishedResourceId <String>
 [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesPublishingProfileId <String> -PublishedResourceId <String>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 -PublishedResourceId <String> -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 -PublishedResourceId <String> [-Agents <IMicrosoftGraphOnPremisesAgent[]>] [-DisplayName <String>]
 [-Id <String>] [-IsDefault] [-PublishedResources <IMicrosoftGraphPublishedResource[]>]
 [-PublishingType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 -BodyParameter <IMicrosoftGraphOnPremisesAgentGroup> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity> [-Agents <IMicrosoftGraphOnPremisesAgent[]>]
 [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgOnPremisPublishingProfileAgentGroupPublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity> [-Agents <IMicrosoftGraphOnPremisesAgent[]>]
 [-DisplayName <String>] [-Id <String>] [-IsDefault]
 [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-PublishingType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
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

### -Agents
.
To construct, see NOTES section for AGENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgent[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
onPremisesAgentGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IsDefault
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OnPremisesAgentGroupId
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OnPremisesAgentGroupId1
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OnPremisesAgentId
key: onPremisesAgent-id of onPremisesAgent

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OnPremisesPublishingProfileId
key: onPremisesPublishingProfile-id of onPremisesPublishingProfile

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -PublishedResourceId
key: publishedResource-id of publishedResource

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublishedResources
.
To construct, see NOTES section for PUBLISHEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublishedResource[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublishingType
onPremisesPublishingType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### AGENTS <IMicrosoftGraphOnPremisesAgent[]>: .
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

#### BODYPARAMETER <IMicrosoftGraphOnPremisesAgentGroup>: onPremisesAgentGroup
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

#### INPUTOBJECT <IIdentityOnPremisesPublishingProfilesIdentity>: Identity Parameter
  - `[OnPremisesAgentGroupId <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: onPremisesPublishingProfile-id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: publishedResource-id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: publishedResource-id of publishedResource

#### PUBLISHEDRESOURCES <IMicrosoftGraphPublishedResource[]>: .
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

