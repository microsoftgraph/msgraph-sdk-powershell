---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/update-mgbetaexternal
schema: 2.0.0
---

# Update-MgBetaExternal

## SYNOPSIS
Update external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaExternal [-AdditionalProperties <Hashtable>]
 [-AuthorizationSystems <IMicrosoftGraphAuthorizationSystem[]>]
 [-Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>]
 [-IndustryData <IMicrosoftGraphIndustryDataRoot>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaExternal -BodyParameter <IMicrosoftGraphExternalConnectorsExternal> [-Confirm] [-WhatIf]
 [<CommonParameters>]
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

### -AuthorizationSystems
Represents an onboarded AWS account, Azure subscription, or GCP project that Microsoft Entra Permissions Management will collect and analyze permissions and actions on.
To construct, see NOTES section for AUTHORIZATIONSYSTEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthorizationSystem[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IndustryData
industryDataRoot
To construct, see NOTES section for INDUSTRYDATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataRoot
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternal

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTHORIZATIONSYSTEMS <IMicrosoftGraphAuthorizationSystem[]>`: Represents an onboarded AWS account, Azure subscription, or GCP project that Microsoft Entra Permissions Management will collect and analyze permissions and actions on.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment. Supports $filter(eq, contains) and $orderBy.
  - `[AuthorizationSystemName <String>]`: Name of the authorization system detected after onboarding. Supports $filter(eq,contains) and $orderBy.
  - `[AuthorizationSystemType <String>]`: The type of authorization system. Can be gcp, azure, or aws. Supports $filter(eq).
  - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.

`BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternal>`: external
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuthorizationSystems <IMicrosoftGraphAuthorizationSystem[]>]`: Represents an onboarded AWS account, Azure subscription, or GCP project that Microsoft Entra Permissions Management will collect and analyze permissions and actions on.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment. Supports $filter(eq, contains) and $orderBy.
    - `[AuthorizationSystemName <String>]`: Name of the authorization system detected after onboarding. Supports $filter(eq,contains) and $orderBy.
    - `[AuthorizationSystemType <String>]`: The type of authorization system. Can be gcp, azure, or aws. Supports $filter(eq).
    - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Connections <IMicrosoftGraphExternalConnectorsExternalConnection[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>]`: activitySettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
        - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
    - `[ComplianceSettings <IMicrosoftGraphExternalConnectorsComplianceSettings>]`: complianceSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EDiscoveryResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: 
        - `[Id <String>]`: The text identifier for the display template; for example, contosoTickets. Maximum 16 characters. Only alphanumeric characters allowed.
        - `[Layout <IMicrosoftGraphJson>]`: Json
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Priority <Int32?>]`: Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported. Must be positive value.
        - `[Rules <IMicrosoftGraphExternalConnectorsPropertyRule[]>]`: Specifies additional rules for selecting this display template based on the item schema. Optional.
          - `[Operation <String>]`: ruleOperation
          - `[Property <String>]`: The property from the externalItem schema. Required.
          - `[Values <String[]>]`: A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.
          - `[ValuesJoinedBy <String>]`: binaryOperator
    - `[Configuration <IMicrosoftGraphExternalConnectorsConfiguration>]`: configuration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Microsoft Entra apps that are allowed to manage the externalConnection and to index content in the externalConnection.
    - `[ConnectorId <String>]`: The Teams App ID. Optional.
    - `[Description <String>]`: Description of the connection displayed in the Microsoft 365 admin center. Optional.
    - `[EnabledContentExperiences <String>]`: contentExperienceType
    - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: The description of the external group. Optional.
      - `[DisplayName <String>]`: The friendly name of the external group. Optional.
      - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or other externalGroups as members.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Type <String>]`: identityType
    - `[IngestedItemsCount <Int64?>]`: The number of items ingested into a connection. This value is refreshed every 15 minutes. If the connection state is draft, then ingestedItemsCount will be null.
    - `[Items <IMicrosoftGraphExternalConnectorsExternalItem[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
        - `[AccessType <String>]`: accessType
        - `[IdentitySource <String>]`: identitySourceType
        - `[Type <String>]`: aclType
        - `[Value <String>]`: The unique identifer of the identity. For Microsoft Entra identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. For external groups, value is set to the ID of the externalGroup.
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
    - `[Quota <IMicrosoftGraphExternalConnectorsConnectionQuota>]`: connectionQuota
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ItemsRemaining <Int64?>]`: The minimum of two values, one representing the items remaining in the connection and the other remaining items at tenant-level. The following equation represents the formula used to calculate the minimum number: min ({max capacity in the connection} – {number of items in the connection}, {tenant quota} – {number of items indexed in all connections}). If the connection is not monetized, such as in a preview connector or preview content experience, then this property is simply the number of remaining items in the connection.
    - `[Schema <IMicrosoftGraphExternalConnectorsSchema>]`: schema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[BaseType <String>]`: Must be set to microsoft.graph.externalItem. Required.
      - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
        - `[Aliases <String[]>]`: A set of aliases or friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
        - `[IsExactMatchRequired <Boolean?>]`: Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.
        - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
        - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
        - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
        - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties aren't added to the search index. Optional.
        - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (for example, better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, containerName, containerUrl, iconUrl. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: containerName, containerUrl, iconUrl.
        - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
        - `[RankingHint <IMicrosoftGraphExternalConnectorsRankingHint>]`: rankingHint
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ImportanceScore <String>]`: importanceScore
        - `[Type <String>]`: propertyType
    - `[SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>]`: searchSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SearchResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of 2 search result templates per connection.
    - `[State <String>]`: connectionState
  - `[IndustryData <IMicrosoftGraphIndustryDataRoot>]`: industryDataRoot
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DataConnectors <IMicrosoftGraphIndustryDataConnector[]>]`: Set of connectors for importing data from source systems.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: The name of the data connector. Maximum supported length is 100 characters.
      - `[SourceSystem <IMicrosoftGraphIndustryDataSourceSystemDefinition>]`: sourceSystemDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: The name of the source system. Maximum supported length is 100 characters.
        - `[UserMatchingSettings <IMicrosoftGraphIndustryDataUserMatchingSetting[]>]`: A collection of user matching settings by roleGroup.
          - `[MatchTarget <IMicrosoftGraphIndustryDataUserMatchTargetReferenceValue>]`: userMatchTargetReferenceValue
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: The code of the desired referenceDefinition entry.
            - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: The unique identifier for an entity. Read-only.
              - `[Code <String>]`: The code value for the definition that must be unique within the referenceType.
              - `[IsDisabled <Boolean?>]`: Indicates whether the definition has been disabled.
              - `[ReferenceType <String>]`: The categorical type for a collection of enumerated values.
              - `[SortIndex <Int32?>]`: The ordering index to present the definitions within a type consistently in user interfaces.
          - `[PriorityOrder <Int32?>]`: The priority order to apply when a user has multiple RefRole codes assigned.
          - `[RoleGroup <IMicrosoftGraphIndustryDataRoleGroup>]`: roleGroup
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: The unique identifier for an entity. Read-only.
            - `[DisplayName <String>]`: The name of the role group.
            - `[Roles <IMicrosoftGraphIndustryDataRoleReferenceValue[]>]`: The set of roles included in the role group.
              - `[Code <String>]`: The code of the desired referenceDefinition entry.
              - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
          - `[SourceIdentifier <IMicrosoftGraphIndustryDataIdentifierTypeReferenceValue>]`: identifierTypeReferenceValue
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: The code of the desired referenceDefinition entry.
            - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
        - `[Vendor <String>]`: The name of the vendor who supplies the source system. Maximum supported length is 100 characters.
    - `[InboundFlows <IMicrosoftGraphIndustryDataInboundFlow[]>]`: Set of data import flow activities to bring data into the canonical store via a connector.
      - `[DisplayName <String>]`: The name of the activity. Maximum supported length is 100 characters.
      - `[ReadinessStatus <String>]`: readinessStatus
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DataConnector <IMicrosoftGraphIndustryDataConnector>]`: industryDataConnector
      - `[DataDomain <String>]`: inboundDomain
      - `[EffectiveDateTime <DateTime?>]`: The start of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ExpirationDateTime <DateTime?>]`: The end of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Year <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>]`: yearTimePeriodDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: The name of the year. Maximum supported length is 100 characters.
        - `[EndDate <DateTime?>]`: The last day of the year using ISO 8601 format for date.
        - `[StartDate <DateTime?>]`: The first day of the year using ISO 8601 format for date.
        - `[Year <IMicrosoftGraphIndustryDataYearReferenceValue>]`: yearReferenceValue
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
    - `[Operations <IMicrosoftGraphLongRunningOperation[]>]`: Set of ephemeral operations that the system runs currently. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The start time of the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastActionDateTime <DateTime?>]`: The time of the last action in the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ResourceLocation <String>]`: URI of the resource that the operation is performed on.
      - `[Status <String>]`: longRunningOperationStatus
      - `[StatusDetail <String>]`: Details about the status of the operation.
    - `[ReferenceDefinitions <IMicrosoftGraphIndustryDataReferenceDefinition[]>]`: Set of user modifiable system picker types.
    - `[RoleGroups <IMicrosoftGraphIndustryDataRoleGroup[]>]`: Set of groups of individual roles that makes role-based admin simpler.
    - `[Runs <IMicrosoftGraphIndustryDataRun[]>]`: Set of ephemeral runs which present the point-in-time that diagnostic state of activities performed by the system. Read-only.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Activities <IMicrosoftGraphIndustryDataRunActivity[]>]`: The set of activities performed during the run.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Activity <IMicrosoftGraphIndustryDataActivity>]`: industryDataActivity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[DisplayName <String>]`: The name of the activity. Maximum supported length is 100 characters.
          - `[ReadinessStatus <String>]`: readinessStatus
        - `[BlockingError <IMicrosoftGraphPublicError>]`: publicError
        - `[Status <String>]`: industryDataActivityStatus
      - `[BlockingError <IMicrosoftGraphPublicError>]`: publicError
      - `[Status <String>]`: industryDataRunStatus
    - `[SourceSystems <IMicrosoftGraphIndustryDataSourceSystemDefinition[]>]`: Set of source definitions that represents real-world external systems.
    - `[Years <IMicrosoftGraphIndustryDataYearTimePeriodDefinition[]>]`: Set of years represented in the system.

`CONNECTIONS <IMicrosoftGraphExternalConnectorsExternalConnection[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>]`: activitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
      - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
  - `[ComplianceSettings <IMicrosoftGraphExternalConnectorsComplianceSettings>]`: complianceSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EDiscoveryResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: 
      - `[Id <String>]`: The text identifier for the display template; for example, contosoTickets. Maximum 16 characters. Only alphanumeric characters allowed.
      - `[Layout <IMicrosoftGraphJson>]`: Json
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Priority <Int32?>]`: Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported. Must be positive value.
      - `[Rules <IMicrosoftGraphExternalConnectorsPropertyRule[]>]`: Specifies additional rules for selecting this display template based on the item schema. Optional.
        - `[Operation <String>]`: ruleOperation
        - `[Property <String>]`: The property from the externalItem schema. Required.
        - `[Values <String[]>]`: A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.
        - `[ValuesJoinedBy <String>]`: binaryOperator
  - `[Configuration <IMicrosoftGraphExternalConnectorsConfiguration>]`: configuration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Microsoft Entra apps that are allowed to manage the externalConnection and to index content in the externalConnection.
  - `[ConnectorId <String>]`: The Teams App ID. Optional.
  - `[Description <String>]`: Description of the connection displayed in the Microsoft 365 admin center. Optional.
  - `[EnabledContentExperiences <String>]`: contentExperienceType
  - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the external group. Optional.
    - `[DisplayName <String>]`: The friendly name of the external group. Optional.
    - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or other externalGroups as members.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Type <String>]`: identityType
  - `[IngestedItemsCount <Int64?>]`: The number of items ingested into a connection. This value is refreshed every 15 minutes. If the connection state is draft, then ingestedItemsCount will be null.
  - `[Items <IMicrosoftGraphExternalConnectorsExternalItem[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Acl <IMicrosoftGraphExternalConnectorsAcl[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
      - `[AccessType <String>]`: accessType
      - `[IdentitySource <String>]`: identitySourceType
      - `[Type <String>]`: aclType
      - `[Value <String>]`: The unique identifer of the identity. For Microsoft Entra identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. For external groups, value is set to the ID of the externalGroup.
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
  - `[Quota <IMicrosoftGraphExternalConnectorsConnectionQuota>]`: connectionQuota
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ItemsRemaining <Int64?>]`: The minimum of two values, one representing the items remaining in the connection and the other remaining items at tenant-level. The following equation represents the formula used to calculate the minimum number: min ({max capacity in the connection} – {number of items in the connection}, {tenant quota} – {number of items indexed in all connections}). If the connection is not monetized, such as in a preview connector or preview content experience, then this property is simply the number of remaining items in the connection.
  - `[Schema <IMicrosoftGraphExternalConnectorsSchema>]`: schema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[BaseType <String>]`: Must be set to microsoft.graph.externalItem. Required.
    - `[Properties <IMicrosoftGraphExternalConnectorsProperty[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
      - `[Aliases <String[]>]`: A set of aliases or friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
      - `[IsExactMatchRequired <Boolean?>]`: Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.
      - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
      - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
      - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
      - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties aren't added to the search index. Optional.
      - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (for example, better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, containerName, containerUrl, iconUrl. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: containerName, containerUrl, iconUrl.
      - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
      - `[RankingHint <IMicrosoftGraphExternalConnectorsRankingHint>]`: rankingHint
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ImportanceScore <String>]`: importanceScore
      - `[Type <String>]`: propertyType
  - `[SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>]`: searchSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SearchResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of 2 search result templates per connection.
  - `[State <String>]`: connectionState

`INDUSTRYDATA <IMicrosoftGraphIndustryDataRoot>`: industryDataRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DataConnectors <IMicrosoftGraphIndustryDataConnector[]>]`: Set of connectors for importing data from source systems.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the data connector. Maximum supported length is 100 characters.
    - `[SourceSystem <IMicrosoftGraphIndustryDataSourceSystemDefinition>]`: sourceSystemDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: The name of the source system. Maximum supported length is 100 characters.
      - `[UserMatchingSettings <IMicrosoftGraphIndustryDataUserMatchingSetting[]>]`: A collection of user matching settings by roleGroup.
        - `[MatchTarget <IMicrosoftGraphIndustryDataUserMatchTargetReferenceValue>]`: userMatchTargetReferenceValue
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: The unique identifier for an entity. Read-only.
            - `[Code <String>]`: The code value for the definition that must be unique within the referenceType.
            - `[IsDisabled <Boolean?>]`: Indicates whether the definition has been disabled.
            - `[ReferenceType <String>]`: The categorical type for a collection of enumerated values.
            - `[SortIndex <Int32?>]`: The ordering index to present the definitions within a type consistently in user interfaces.
        - `[PriorityOrder <Int32?>]`: The priority order to apply when a user has multiple RefRole codes assigned.
        - `[RoleGroup <IMicrosoftGraphIndustryDataRoleGroup>]`: roleGroup
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[DisplayName <String>]`: The name of the role group.
          - `[Roles <IMicrosoftGraphIndustryDataRoleReferenceValue[]>]`: The set of roles included in the role group.
            - `[Code <String>]`: The code of the desired referenceDefinition entry.
            - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
        - `[SourceIdentifier <IMicrosoftGraphIndustryDataIdentifierTypeReferenceValue>]`: identifierTypeReferenceValue
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
      - `[Vendor <String>]`: The name of the vendor who supplies the source system. Maximum supported length is 100 characters.
  - `[InboundFlows <IMicrosoftGraphIndustryDataInboundFlow[]>]`: Set of data import flow activities to bring data into the canonical store via a connector.
    - `[DisplayName <String>]`: The name of the activity. Maximum supported length is 100 characters.
    - `[ReadinessStatus <String>]`: readinessStatus
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DataConnector <IMicrosoftGraphIndustryDataConnector>]`: industryDataConnector
    - `[DataDomain <String>]`: inboundDomain
    - `[EffectiveDateTime <DateTime?>]`: The start of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ExpirationDateTime <DateTime?>]`: The end of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Year <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>]`: yearTimePeriodDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: The name of the year. Maximum supported length is 100 characters.
      - `[EndDate <DateTime?>]`: The last day of the year using ISO 8601 format for date.
      - `[StartDate <DateTime?>]`: The first day of the year using ISO 8601 format for date.
      - `[Year <IMicrosoftGraphIndustryDataYearReferenceValue>]`: yearReferenceValue
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: The code of the desired referenceDefinition entry.
        - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
  - `[Operations <IMicrosoftGraphLongRunningOperation[]>]`: Set of ephemeral operations that the system runs currently. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The start time of the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastActionDateTime <DateTime?>]`: The time of the last action in the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ResourceLocation <String>]`: URI of the resource that the operation is performed on.
    - `[Status <String>]`: longRunningOperationStatus
    - `[StatusDetail <String>]`: Details about the status of the operation.
  - `[ReferenceDefinitions <IMicrosoftGraphIndustryDataReferenceDefinition[]>]`: Set of user modifiable system picker types.
  - `[RoleGroups <IMicrosoftGraphIndustryDataRoleGroup[]>]`: Set of groups of individual roles that makes role-based admin simpler.
  - `[Runs <IMicrosoftGraphIndustryDataRun[]>]`: Set of ephemeral runs which present the point-in-time that diagnostic state of activities performed by the system. Read-only.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Activities <IMicrosoftGraphIndustryDataRunActivity[]>]`: The set of activities performed during the run.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Activity <IMicrosoftGraphIndustryDataActivity>]`: industryDataActivity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: The name of the activity. Maximum supported length is 100 characters.
        - `[ReadinessStatus <String>]`: readinessStatus
      - `[BlockingError <IMicrosoftGraphPublicError>]`: publicError
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
      - `[Status <String>]`: industryDataActivityStatus
    - `[BlockingError <IMicrosoftGraphPublicError>]`: publicError
    - `[Status <String>]`: industryDataRunStatus
  - `[SourceSystems <IMicrosoftGraphIndustryDataSourceSystemDefinition[]>]`: Set of source definitions that represents real-world external systems.
  - `[Years <IMicrosoftGraphIndustryDataYearTimePeriodDefinition[]>]`: Set of years represented in the system.

## RELATED LINKS

