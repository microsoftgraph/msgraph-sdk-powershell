---
external help file:
Module Name: Microsoft.Graph.Identity.OnPremisesPublishingProfiles
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.onpremisespublishingprofiles/get-mgonpremispublishingprofileagentgroup
schema: 2.0.0
---

# Get-MgOnPremisPublishingProfileAgentGroup

## SYNOPSIS
Get agentGroups from onPremisesPublishingProfiles

## SYNTAX

### List2 (Default)
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesPublishingProfileId <String> [-Count]
 [-ExpandProperty <String[]>] [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [<CommonParameters>]
```

### Get
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesAgentGroupId <String> -OnPremisesAgentGroupId1 <String>
 -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### Get2
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgOnPremisPublishingProfileAgentGroup -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgOnPremisPublishingProfileAgentGroup -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgOnPremisPublishingProfileAgentGroup -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### List
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesAgentGroupId <String> -OnPremisesAgentId <String>
 -OnPremisesPublishingProfileId <String> [-Count] [-ExpandProperty <String[]>] [-Filter <String>]
 [-PageSize <Int32>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-All]
 [<CommonParameters>]
```

### List1
```
Get-MgOnPremisPublishingProfileAgentGroup -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 [-Count] [-ExpandProperty <String[]>] [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get agentGroups from onPremisesPublishingProfiles

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

### -All
List all pages

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, List1, List2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List, List1, List2
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
Parameter Sets: GetViaIdentity, GetViaIdentity1, GetViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Get, Get1, Get2, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesAgentGroupId1
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: Get, Get1, List, List1
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
Parameter Sets: Get, Get1, Get2, List, List1, List2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1, List2
Aliases: Top, Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List, List1, List2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1, List2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List, List1, List2
Aliases: OrderBy

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

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

