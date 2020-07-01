---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/update-mgexternalconnection
schema: 2.0.0
---

# Update-MgExternalConnection

## SYNOPSIS
Update the navigation property connections in external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgExternalConnection -ExternalConnectionId <String> [-ConfigurationAuthorizedApps <String[]>]
 [-Description <String>] [-Id <String>] [-Items <IMicrosoftGraphExternalItem[]>] [-Name <String>]
 [-Operations <IMicrosoftGraphConnectionOperation[]>] [-SchemaBaseType <String>] [-SchemaId <String>]
 [-SchemaProperties <IMicrosoftGraphProperty[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgExternalConnection -ExternalConnectionId <String> -BodyParameter <IMicrosoftGraphExternalConnection>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgExternalConnection -InputObject <ISearchIdentity> -BodyParameter <IMicrosoftGraphExternalConnection>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgExternalConnection -InputObject <ISearchIdentity> [-ConfigurationAuthorizedApps <String[]>]
 [-Description <String>] [-Id <String>] [-Items <IMicrosoftGraphExternalItem[]>] [-Name <String>]
 [-Operations <IMicrosoftGraphConnectionOperation[]>] [-SchemaBaseType <String>] [-SchemaId <String>]
 [-SchemaProperties <IMicrosoftGraphProperty[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property connections in external

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
externalConnection
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnection
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConfigurationAuthorizedApps
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
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

### -Items
.
To construct, see NOTES section for ITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalItem[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
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

### -Operations
.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectionOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -SchemaBaseType
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

### -SchemaId
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

### -SchemaProperties
.
To construct, see NOTES section for SCHEMAPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProperty[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnection

### Microsoft.Graph.PowerShell.Models.ISearchIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExternalConnection>: externalConnection
  - `[Id <String>]`: Read-only.
  - `[ConfigurationAuthorizedApps <String[]>]`: 
  - `[Description <String>]`: 
  - `[Items <IMicrosoftGraphExternalItem[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Acl <IMicrosoftGraphAcl[]>]`: 
      - `[AccessType <String>]`: accessType
      - `[IdentitySource <String>]`: 
      - `[Type <String>]`: aclType
      - `[Value <String>]`: 
    - `[ContentType <String>]`: externalItemContentType
    - `[ContentValue <String>]`: 
    - `[Properties <IMicrosoftGraphProperties>]`: properties
  - `[Name <String>]`: 
  - `[Operations <IMicrosoftGraphConnectionOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Details <IMicrosoftGraphInnerErrorDetail[]>]`: 
      - `[Message <String>]`: 
      - `[Source <String>]`: 
    - `[ErrorCode <String>]`: 
    - `[Message <String>]`: 
    - `[Status <String>]`: connectionOperationStatus
  - `[SchemaBaseType <String>]`: 
  - `[SchemaId <String>]`: Read-only.
  - `[SchemaProperties <IMicrosoftGraphProperty[]>]`: 
    - `[Aliases <String[]>]`: 
    - `[IsContent <Boolean?>]`: 
    - `[IsQueryable <Boolean?>]`: 
    - `[IsRefinable <Boolean?>]`: 
    - `[IsRetrievable <Boolean?>]`: 
    - `[IsSearchable <Boolean?>]`: 
    - `[Labels <String[]>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: propertyType

INPUTOBJECT <ISearchIdentity>: Identity Parameter
  - `[ConnectionOperationId <String>]`: key: connectionOperation-id of connectionOperation
  - `[ExternalConnectionId <String>]`: key: externalConnection-id of externalConnection
  - `[ExternalItemId <String>]`: key: externalItem-id of externalItem

ITEMS <IMicrosoftGraphExternalItem[]>: .
  - `[Id <String>]`: Read-only.
  - `[Acl <IMicrosoftGraphAcl[]>]`: 
    - `[AccessType <String>]`: accessType
    - `[IdentitySource <String>]`: 
    - `[Type <String>]`: aclType
    - `[Value <String>]`: 
  - `[ContentType <String>]`: externalItemContentType
  - `[ContentValue <String>]`: 
  - `[Properties <IMicrosoftGraphProperties>]`: properties

OPERATIONS <IMicrosoftGraphConnectionOperation[]>: .
  - `[Id <String>]`: Read-only.
  - `[Details <IMicrosoftGraphInnerErrorDetail[]>]`: 
    - `[Message <String>]`: 
    - `[Source <String>]`: 
  - `[ErrorCode <String>]`: 
  - `[Message <String>]`: 
  - `[Status <String>]`: connectionOperationStatus

SCHEMAPROPERTIES <IMicrosoftGraphProperty[]>: .
  - `[Aliases <String[]>]`: 
  - `[IsContent <Boolean?>]`: 
  - `[IsQueryable <Boolean?>]`: 
  - `[IsRefinable <Boolean?>]`: 
  - `[IsRetrievable <Boolean?>]`: 
  - `[IsSearchable <Boolean?>]`: 
  - `[Labels <String[]>]`: 
  - `[Name <String>]`: 
  - `[Type <String>]`: propertyType

## RELATED LINKS

