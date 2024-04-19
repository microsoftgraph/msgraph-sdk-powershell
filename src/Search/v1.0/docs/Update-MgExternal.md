---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.search/update-mgexternal
schema: 2.0.0
---

# Update-MgExternal

## SYNOPSIS
Update external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgExternal [-AdditionalProperties <Hashtable>]
 [-Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgExternal -BodyParameter <IMicrosoftGraphExternalConnectorsExternal>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update external

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternal>`: external
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>]`: activitySettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
        - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
    - `[Configuration <IMicrosoftGraphExternalConnectorsConfiguration>]`: configuration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Microsoft Entra apps that are allowed to manage the externalConnection and to index content in the externalConnection.
    - `[ConnectorId <String>]`: The Teams app ID. Optional.
    - `[Description <String>]`: Description of the connection displayed in the Microsoft 365 admin center. Optional.
    - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: The description of the external group. Optional.
      - `[DisplayName <String>]`: The friendly name of the external group. Optional.
      - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or an externalGroup as members.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Type <String>]`: identityType
    - `[Items <IMicrosoftGraphExternalConnectorsExternalItem[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
        - `[AccessType <String>]`: accessType
        - `[Type <String>]`: aclType
        - `[Value <String>]`: The unique identifer of the identity. For Microsoft Entra identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. For external groups value is set to the ID of the externalGroup
      - `[Activities <IMicrosoftGraphExternalConnectorsExternalActivity[]>]`: Returns a list of activities performed on the item. Write-only.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>]`: identity
        - `[StartDateTime <DateTime?>]`: The date and time when the particular activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Type <String>]`: externalActivityType
      - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Type <String>]`: externalItemContentType
        - `[Value <String>]`: The content for the externalItem. Required.
      - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.
    - `[Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[BaseType <String>]`: Must be set to microsoft.graph.externalConnector.externalItem. Required.
      - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
        - `[Aliases <String[]>]`: A set of aliases or a friendly name for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
        - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
        - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
        - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
        - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type String or StringCollection can be searchable. Nonsearchable properties aren't added to the search index. Optional.
        - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (for example, better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl. You must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: iconUrl.
        - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
        - `[Type <String>]`: propertyType
    - `[SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>]`: searchSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SearchResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of 2 search result templates per connection.
        - `[Id <String>]`: The text identifier for the display template; for example, contosoTickets. Maximum 16 characters. Only alphanumeric characters allowed.
        - `[Layout <IMicrosoftGraphJson>]`: Json
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Priority <Int32?>]`: Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported. Must be positive value.
        - `[Rules <IMicrosoftGraphExternalConnectorsPropertyRule[]>]`: Specifies additional rules for selecting this display template based on the item schema. Optional.
          - `[Operation <String>]`: ruleOperation
          - `[Property <String>]`: The property from the externalItem schema. Required.
          - `[Values <String[]>]`: A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.
          - `[ValuesJoinedBy <String>]`: binaryOperator
    - `[State <String>]`: connectionState

`CONNECTIONS <IMicrosoftGraphExternalConnectorsExternalConnection[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>]`: activitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
      - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
  - `[Configuration <IMicrosoftGraphExternalConnectorsConfiguration>]`: configuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Microsoft Entra apps that are allowed to manage the externalConnection and to index content in the externalConnection.
  - `[ConnectorId <String>]`: The Teams app ID. Optional.
  - `[Description <String>]`: Description of the connection displayed in the Microsoft 365 admin center. Optional.
  - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the external group. Optional.
    - `[DisplayName <String>]`: The friendly name of the external group. Optional.
    - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or an externalGroup as members.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Type <String>]`: identityType
  - `[Items <IMicrosoftGraphExternalConnectorsExternalItem[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
      - `[AccessType <String>]`: accessType
      - `[Type <String>]`: aclType
      - `[Value <String>]`: The unique identifer of the identity. For Microsoft Entra identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. For external groups value is set to the ID of the externalGroup
    - `[Activities <IMicrosoftGraphExternalConnectorsExternalActivity[]>]`: Returns a list of activities performed on the item. Write-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>]`: identity
      - `[StartDateTime <DateTime?>]`: The date and time when the particular activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Type <String>]`: externalActivityType
    - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: externalItemContentType
      - `[Value <String>]`: The content for the externalItem. Required.
    - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.
  - `[Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[BaseType <String>]`: Must be set to microsoft.graph.externalConnector.externalItem. Required.
    - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
      - `[Aliases <String[]>]`: A set of aliases or a friendly name for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
      - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
      - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
      - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
      - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type String or StringCollection can be searchable. Nonsearchable properties aren't added to the search index. Optional.
      - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (for example, better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl. You must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: iconUrl.
      - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
      - `[Type <String>]`: propertyType
  - `[SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>]`: searchSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SearchResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of 2 search result templates per connection.
      - `[Id <String>]`: The text identifier for the display template; for example, contosoTickets. Maximum 16 characters. Only alphanumeric characters allowed.
      - `[Layout <IMicrosoftGraphJson>]`: Json
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Priority <Int32?>]`: Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported. Must be positive value.
      - `[Rules <IMicrosoftGraphExternalConnectorsPropertyRule[]>]`: Specifies additional rules for selecting this display template based on the item schema. Optional.
        - `[Operation <String>]`: ruleOperation
        - `[Property <String>]`: The property from the externalItem schema. Required.
        - `[Values <String[]>]`: A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.
        - `[ValuesJoinedBy <String>]`: binaryOperator
  - `[State <String>]`: connectionState

## RELATED LINKS

