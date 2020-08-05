---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/update-mgconnectionitem
schema: 2.0.0
---

# Update-MgConnectionItem

## SYNOPSIS
Update the navigation property items in connections

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgConnectionItem -ExternalConnectionId <String> -ExternalItemId <String> [-Acl <IMicrosoftGraphAcl[]>]
 [-ContentType <String>] [-ContentValue <String>] [-Id <String>] [-Properties <IMicrosoftGraphProperties>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgConnectionItem -ExternalConnectionId <String> -ExternalItemId <String>
 -BodyParameter <IMicrosoftGraphExternalItem> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgConnectionItem -InputObject <ISearchIdentity> -BodyParameter <IMicrosoftGraphExternalItem>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgConnectionItem -InputObject <ISearchIdentity> [-Acl <IMicrosoftGraphAcl[]>] [-ContentType <String>]
 [-ContentValue <String>] [-Id <String>] [-Properties <IMicrosoftGraphProperties>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property items in connections

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

### -Acl
.
To construct, see NOTES section for ACL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAcl[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
externalItem
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalItem
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentType
externalItemContentType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentValue
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalConnectionId
key: externalConnection-id of externalConnection

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalItemId
key: externalItem-id of externalItem

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ISearchIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Properties
properties

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProperties
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalItem

### Microsoft.Graph.PowerShell.Models.ISearchIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACL <IMicrosoftGraphAcl[]>: .
  - `[AccessType <String>]`: accessType
  - `[IdentitySource <String>]`: 
  - `[Type <String>]`: aclType
  - `[Value <String>]`: 

BODYPARAMETER <IMicrosoftGraphExternalItem>: externalItem
  - `[Id <String>]`: Read-only.
  - `[Acl <IMicrosoftGraphAcl[]>]`: 
    - `[AccessType <String>]`: accessType
    - `[IdentitySource <String>]`: 
    - `[Type <String>]`: aclType
    - `[Value <String>]`: 
  - `[ContentType <String>]`: externalItemContentType
  - `[ContentValue <String>]`: 
  - `[Properties <IMicrosoftGraphProperties>]`: properties

INPUTOBJECT <ISearchIdentity>: Identity Parameter
  - `[ConnectionOperationId <String>]`: key: connectionOperation-id of connectionOperation
  - `[ExternalConnectionId <String>]`: key: externalConnection-id of externalConnection
  - `[ExternalItemId <String>]`: key: externalItem-id of externalItem

## RELATED LINKS

