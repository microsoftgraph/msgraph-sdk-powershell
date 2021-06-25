---
external help file: Microsoft.Graph.Search-help.xml
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/new-mgexternalconnection
schema: 2.0.0
---

# New-MgExternalConnection

## SYNOPSIS
Create new navigation property to connections for external

## SYNTAX

### CreateExpanded (Default)
```
New-MgExternalConnection [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphExternalConnectorsConfiguration>] [-Description <String>]
 [-Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>] [-Id <String>]
 [-Items <IMicrosoftGraphExternalConnectorsExternalItem[]>] [-Name <String>]
 [-Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]
 [-Schema <IMicrosoftGraphExternalConnectorsSchema>] [-State <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgExternalConnection -BodyParameter <IMicrosoftGraphExternalConnectorsExternalConnection> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to connections for external

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
externalConnection
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsExternalConnection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
configuration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsConfiguration
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Groups
.
To construct, see NOTES section for GROUPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsExternalGroup[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Items
.
To construct, see NOTES section for ITEMS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsExternalItem[]
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: IMicrosoftGraphExternalConnectorsConnectionOperation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schema
schema
To construct, see NOTES section for SCHEMA properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsSchema
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
connectionState

```yaml
Type: String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternalConnection>: externalConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Configuration <IMicrosoftGraphExternalConnectorsConfiguration>]`: configuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthorizedAppIds <String[]>]`: 
  - `[Description <String>]`: 
  - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Members <IMicrosoftGraphExternalConnectorsExternalGroupMember[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[IdentitySource <String>]`: identitySourceType
      - `[Type <String>]`: externalGroupMemberType
  - `[Items <IMicrosoftGraphExternalConnectorsExternalItem[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: 
      - `[AccessType <String>]`: accessType
      - `[IdentitySource <String>]`: identitySourceType
      - `[Type <String>]`: aclType
      - `[Value <String>]`: 
    - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: externalItemContentType
      - `[Value <String>]`: 
    - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: 
  - `[Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Error <IMicrosoftGraphPublicError>]`: publicError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: Represents the error code.
      - `[Details <IMicrosoftGraphPublicErrorDetail[]>]`: Details of the error.
        - `[Code <String>]`: The error code.
        - `[Message <String>]`: The error message.
        - `[Target <String>]`: The target of the error.
      - `[InnerError <IMicrosoftGraphPublicInnerError>]`: publicInnerError
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: The error code.
        - `[Details <IMicrosoftGraphPublicErrorDetail[]>]`: A collection of error details.
        - `[Message <String>]`: The error message.
        - `[Target <String>]`: The target of the error.
      - `[Message <String>]`: A non-localized message for the developer.
      - `[Target <String>]`: The target of the error.
    - `[Status <String>]`: connectionOperationStatus
  - `[Schema <IMicrosoftGraphExternalConnectorsSchema>]`: schema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseType <String>]`: 
    - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: 
      - `[Aliases <String[]>]`: 
      - `[IsQueryable <Boolean?>]`: 
      - `[IsRefinable <Boolean?>]`: 
      - `[IsRetrievable <Boolean?>]`: 
      - `[IsSearchable <Boolean?>]`: 
      - `[Labels <String[]>]`: 
      - `[Name <String>]`: 
      - `[Type <String>]`: propertyType
  - `[State <String>]`: connectionState

CONFIGURATION <IMicrosoftGraphExternalConnectorsConfiguration>: configuration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuthorizedAppIds <String[]>]`: 

GROUPS <IMicrosoftGraphExternalConnectorsExternalGroup[]>: .
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Members <IMicrosoftGraphExternalConnectorsExternalGroupMember[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[IdentitySource <String>]`: identitySourceType
    - `[Type <String>]`: externalGroupMemberType

ITEMS <IMicrosoftGraphExternalConnectorsExternalItem[]>: .
  - `[Id <String>]`: Read-only.
  - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: 
    - `[AccessType <String>]`: accessType
    - `[IdentitySource <String>]`: identitySourceType
    - `[Type <String>]`: aclType
    - `[Value <String>]`: 
  - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: externalItemContentType
    - `[Value <String>]`: 
  - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

OPERATIONS <IMicrosoftGraphExternalConnectorsConnectionOperation[]>: .
  - `[Id <String>]`: Read-only.
  - `[Error <IMicrosoftGraphPublicError>]`: publicError
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: Represents the error code.
    - `[Details <IMicrosoftGraphPublicErrorDetail[]>]`: Details of the error.
      - `[Code <String>]`: The error code.
      - `[Message <String>]`: The error message.
      - `[Target <String>]`: The target of the error.
    - `[InnerError <IMicrosoftGraphPublicInnerError>]`: publicInnerError
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: The error code.
      - `[Details <IMicrosoftGraphPublicErrorDetail[]>]`: A collection of error details.
      - `[Message <String>]`: The error message.
      - `[Target <String>]`: The target of the error.
    - `[Message <String>]`: A non-localized message for the developer.
    - `[Target <String>]`: The target of the error.
  - `[Status <String>]`: connectionOperationStatus

SCHEMA <IMicrosoftGraphExternalConnectorsSchema>: schema
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[BaseType <String>]`: 
  - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: 
    - `[Aliases <String[]>]`: 
    - `[IsQueryable <Boolean?>]`: 
    - `[IsRefinable <Boolean?>]`: 
    - `[IsRetrievable <Boolean?>]`: 
    - `[IsSearchable <Boolean?>]`: 
    - `[Labels <String[]>]`: 
    - `[Name <String>]`: 
    - `[Type <String>]`: propertyType

## RELATED LINKS
