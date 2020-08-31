---
external help file:
Module Name: Microsoft.Graph.Groups.Endpoint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.endpoint/new-mggroupendpoint
schema: 2.0.0
---

# New-MgGroupEndpoint

## SYNOPSIS
Create new navigation property to endpoints for groups

## SYNTAX

### CreateExpanded (Default)
```
New-MgGroupEndpoint -GroupId <String> [-Capability <String>] [-DeletedDateTime <DateTime>] [-Id <String>]
 [-ProviderId <String>] [-ProviderName <String>] [-ProviderResourceId <String>] [-Uri <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgGroupEndpoint -GroupId <String> -BodyParameter <IMicrosoftGraphEndpoint> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgGroupEndpoint -InputObject <IGroupsEndpointIdentity> -BodyParameter <IMicrosoftGraphEndpoint> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgGroupEndpoint -InputObject <IGroupsEndpointIdentity> [-Capability <String>]
 [-DeletedDateTime <DateTime>] [-Id <String>] [-ProviderId <String>] [-ProviderName <String>]
 [-ProviderResourceId <String>] [-Uri <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to endpoints for groups

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

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEndpoint
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Capability
Describes the capability that is associated with this resource.
(e.g.
Messages, Conversations, etc.) Not nullable.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IGroupsEndpointIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ProviderId
Application id of the publishing underlying service.
Not nullable.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProviderName
Name of the publishing underlying service.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProviderResourceId
For Office 365 groups, this is set to a well-known name for the resource (e.g.
Yammer.FeedURL etc.).
Not nullable.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Uri
URL of the published resource.
Not nullable.
Read-only.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IGroupsEndpointIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEndpoint

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEndpoint

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEndpoint>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Capability <String>]`: Describes the capability that is associated with this resource. (e.g. Messages, Conversations, etc.)  Not nullable. Read-only.
  - `[ProviderId <String>]`: Application id of the publishing underlying service. Not nullable. Read-only.
  - `[ProviderName <String>]`: Name of the publishing underlying service. Read-only.
  - `[ProviderResourceId <String>]`: For Office 365 groups, this is set to a well-known name for the resource (e.g. Yammer.FeedURL etc.). Not nullable. Read-only.
  - `[Uri <String>]`: URL of the published resource. Not nullable. Read-only.

INPUTOBJECT <IGroupsEndpointIdentity>: Identity Parameter
  - `[EndpointId <String>]`: key: endpoint-id of endpoint
  - `[GroupId <String>]`: key: group-id of group

## RELATED LINKS

