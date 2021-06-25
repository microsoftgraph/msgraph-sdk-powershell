---
external help file: Microsoft.Graph.Search-help.xml
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/update-mgexternal
schema: 2.0.0
---

# Update-MgExternal

## SYNOPSIS
Update external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgExternal [-AdditionalProperties <Hashtable>]
 [-Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgExternal -BodyParameter <IMicrosoftGraphExternalConnectorsExternal> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update external

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
external
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsExternal
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Connections
.
To construct, see NOTES section for CONNECTIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExternalConnectorsExternalConnection[]
Parameter Sets: UpdateExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternal>: external
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>]`: 
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

CONNECTIONS <IMicrosoftGraphExternalConnectorsExternalConnection[]>: .
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

## RELATED LINKS
