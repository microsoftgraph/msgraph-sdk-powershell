---
external help file:
Module Name: Microsoft.Graph.Identity.OnPremisesPublishingProfiles
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.onpremisespublishingprofiles/get-mgonpremispublishingprofilepublishedresourceagentgroup
schema: 2.0.0
---

# Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup

## SYNOPSIS
Get agentGroups from onPremisesPublishingProfiles

## SYNTAX

### List (Default)
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup -OnPremisesPublishingProfileId <String>
 -PublishedResourceId <String> [-Count] [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>]
 [-Search <String>] [-Select <String[]>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> [-Expand <String[]>]
 [-Select <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentGroupId1 <String> -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String>
 -PublishedResourceId <String> [-Expand <String[]>] [-Select <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup
 -InputObject <IIdentityOnPremisesPublishingProfilesIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### List1
```
Get-MgOnPremisPublishingProfilePublishedResourceAgentGroup -OnPremisesAgentGroupId <String>
 -OnPremisesAgentId <String> -OnPremisesPublishingProfileId <String> -PublishedResourceId <String> [-Count]
 [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>] [-Search <String>] [-Select <String[]>]
 [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
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

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List, List1
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
Parameter Sets: GetViaIdentity, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OnPremisesAgentGroupId
key: onPremisesAgentGroup-id of onPremisesAgentGroup

```yaml
Type: System.String
Parameter Sets: Get, Get1, List1
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
Parameter Sets: Get1
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
Parameter Sets: Get1, List1
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
Parameter Sets: Get, Get1, List, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Orderby
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List, List1
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
Parameter Sets: Get, Get1, List, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1
Aliases:

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

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesAgentGroup

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IIdentityOnPremisesPublishingProfilesIdentity>: Identity Parameter
  - `[OnPremisesAgentGroupId <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: onPremisesPublishingProfile-id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: publishedResource-id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: publishedResource-id of publishedResource

## RELATED LINKS

