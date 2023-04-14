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

### UpdateExpanded1 (Default)
```
Update-MgExternalConnection -ExternalConnectionId <String>
 [-ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>] [-AdditionalProperties <Hashtable>]
 [-ComplianceSettings <IMicrosoftGraphExternalConnectorsComplianceSettings>]
 [-Configuration <IMicrosoftGraphExternalConnectorsConfiguration>] [-ConnectorId <String>]
 [-Description <String>] [-EnabledContentExperiences <String>]
 [-Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>] [-Id <String>] [-IngestedItemsCount <Int64>]
 [-Items <IMicrosoftGraphExternalConnectorsExternalItem1[]>] [-Name <String>]
 [-Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]
 [-Quota <IMicrosoftGraphExternalConnectorsConnectionQuota>]
 [-Schema <IMicrosoftGraphExternalConnectorsSchema1>]
 [-SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>] [-State <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgExternalConnection -ExternalConnectionId <String>
 -BodyParameter <IMicrosoftGraphExternalConnectorsExternalConnection> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgExternalConnection -InputObject <ISearchIdentity>
 -BodyParameter <IMicrosoftGraphExternalConnectorsExternalConnection> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgExternalConnection -InputObject <ISearchIdentity>
 [-ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>] [-AdditionalProperties <Hashtable>]
 [-ComplianceSettings <IMicrosoftGraphExternalConnectorsComplianceSettings>]
 [-Configuration <IMicrosoftGraphExternalConnectorsConfiguration>] [-ConnectorId <String>]
 [-Description <String>] [-EnabledContentExperiences <String>]
 [-Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>] [-Id <String>] [-IngestedItemsCount <Int64>]
 [-Items <IMicrosoftGraphExternalConnectorsExternalItem1[]>] [-Name <String>]
 [-Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]
 [-Quota <IMicrosoftGraphExternalConnectorsConnectionQuota>]
 [-Schema <IMicrosoftGraphExternalConnectorsSchema1>]
 [-SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>] [-State <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property connections in external

## EXAMPLES

### Example 1: Using the Update-MgExternalConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Name = "Contoso HR Service Tickets"
	Description = "Connection to index HR service tickets"
}
Update-MgExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params
```

This example shows how to use the Update-MgExternalConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -ActivitySettings
activitySettings
To construct, please use Get-Help -Online and see NOTES section for ACTIVITYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsActivitySettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
externalConnection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ComplianceSettings
complianceSettings
To construct, please use Get-Help -Online and see NOTES section for COMPLIANCESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsComplianceSettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Configuration
configuration
To construct, please use Get-Help -Online and see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsConfiguration
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectorId
The Teams App ID.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the connection displayed in the Microsoft 365 admin center.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnabledContentExperiences
contentExperienceType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalConnectionId
The unique identifier of externalConnection

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Groups
.
To construct, please use Get-Help -Online and see NOTES section for GROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalGroup[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IngestedItemsCount
The number of items ingested into a connection.
This value is refreshed every 15 minutes.
If the connection state is draft, then ingestedItemsCount will be null.

```yaml
Type: System.Int64
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISearchIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Items
.
To construct, please use Get-Help -Online and see NOTES section for ITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalItem1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The display name of the connection to be displayed in the Microsoft 365 admin center.
Maximum length of 128 characters.
Required.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
.
To construct, please use Get-Help -Online and see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsConnectionOperation[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -Quota
connectionQuota
To construct, please use Get-Help -Online and see NOTES section for QUOTA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsConnectionQuota
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schema
schema
To construct, please use Get-Help -Online and see NOTES section for SCHEMA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsSchema1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchSettings
searchSettings
To construct, please use Get-Help -Online and see NOTES section for SEARCHSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsSearchSettings
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalConnection

### Microsoft.Graph.PowerShell.Models.ISearchIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIVITYSETTINGS <IMicrosoftGraphExternalConnectorsActivitySettings>: activitySettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
    - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.

BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternalConnection>: externalConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActivitySettings <IMicrosoftGraphExternalConnectorsActivitySettings>]`: activitySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UrlToItemResolvers <IMicrosoftGraphExternalConnectorsUrlToItemResolverBase[]>]`: Specifies configurations to identify an externalItem based on a shared URL.
      - `[Priority <Int32?>]`: The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
  - `[ComplianceSettings <IMicrosoftGraphExternalConnectorsComplianceSettings>]`: complianceSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EDiscoveryResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of two eDiscovery result templates per connection.
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
    - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Azure Active Directory apps that are allowed to manage the externalConnection and to index content in the externalConnection.
  - `[ConnectorId <String>]`: The Teams App ID. Optional.
  - `[Description <String>]`: Description of the connection displayed in the Microsoft 365 admin center. Optional.
  - `[EnabledContentExperiences <String>]`: contentExperienceType
  - `[Groups <IMicrosoftGraphExternalConnectorsExternalGroup[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: The description of the external group. Optional.
    - `[DisplayName <String>]`: The friendly name of the external group. Optional.
    - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Azure Active Directory users, Azure Active Directory groups, or an externalGroup as members.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Type <String>]`: identityType
  - `[IngestedItemsCount <Int64?>]`: The number of items ingested into a connection. This value is refreshed every 15 minutes. If the connection state is draft, then ingestedItemsCount will be null.
  - `[Items <IMicrosoftGraphExternalConnectorsExternalItem1[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Acl <IMicrosoftGraphExternalConnectorsAcl1[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
      - `[AccessType <String>]`: accessType
      - `[IdentitySource <String>]`: identitySourceType
      - `[Type <String>]`: aclType
      - `[Value <String>]`: The unique identifer of the identity. In case of Azure Active Directory identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. In case of external groups value is set to the ID of the externalGroup.
    - `[Activities <IMicrosoftGraphExternalConnectorsExternalActivity[]>]`: Write-only property. Returns results.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>]`: identity
      - `[StartDateTime <DateTime?>]`: When the particular activity occurred.
      - `[Type <String>]`: externalActivityType
    - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: externalItemContentType
      - `[Value <String>]`: The content for the externalItem. Required.
    - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.
  - `[Operations <IMicrosoftGraphExternalConnectorsConnectionOperation[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ItemsRemaining <Int64?>]`: The minimum of two values, one representing the items remaining in the connection and the other remaining items at tenant-level. The following equation represents the formula used to calculate the minimum number: min ({max capacity in the connection} – {number of items in the connection}, {tenant quota} – {number of items indexed in all connections}). If the connection is not monetized, such as in a preview connector or preview content experience, then this property is simply the number of remaining items in the connection.
  - `[Schema <IMicrosoftGraphExternalConnectorsSchema1>]`: schema
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[BaseType <String>]`: Must be set to microsoft.graph.externalItem. Required.
    - `[Properties <IMicrosoftGraphExternalConnectorsProperty1[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
      - `[Aliases <String[]>]`: A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
      - `[IsExactMatchRequired <Boolean?>]`: Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.
      - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
      - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
      - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
      - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.
      - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl, containerName, containerUrl. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: iconUrl, containerName, containerUrl.
      - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
      - `[Type <String>]`: propertyType
  - `[SearchSettings <IMicrosoftGraphExternalConnectorsSearchSettings>]`: searchSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SearchResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of 2 search result templates per connection.
  - `[State <String>]`: connectionState

COMPLIANCESETTINGS <IMicrosoftGraphExternalConnectorsComplianceSettings>: complianceSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EDiscoveryResultTemplates <IMicrosoftGraphExternalConnectorsDisplayTemplate[]>]`: Enables the developer to define the appearance of the content and configure conditions that dictate when the template should be displayed. Maximum of two eDiscovery result templates per connection.
    - `[Id <String>]`: The text identifier for the display template; for example, contosoTickets. Maximum 16 characters. Only alphanumeric characters allowed.
    - `[Layout <IMicrosoftGraphJson>]`: Json
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Priority <Int32?>]`: Defines the priority of a display template. A display template with priority 1 is evaluated before a template with priority 4. Gaps in priority values are supported. Must be positive value.
    - `[Rules <IMicrosoftGraphExternalConnectorsPropertyRule[]>]`: Specifies additional rules for selecting this display template based on the item schema. Optional.
      - `[Operation <String>]`: ruleOperation
      - `[Property <String>]`: The property from the externalItem schema. Required.
      - `[Values <String[]>]`: A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.
      - `[ValuesJoinedBy <String>]`: binaryOperator

CONFIGURATION <IMicrosoftGraphExternalConnectorsConfiguration>: configuration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuthorizedAppIds <String[]>]`: A collection of application IDs for registered Azure Active Directory apps that are allowed to manage the externalConnection and to index content in the externalConnection.

GROUPS <IMicrosoftGraphExternalConnectorsExternalGroup[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: The description of the external group. Optional.
  - `[DisplayName <String>]`: The friendly name of the external group. Optional.
  - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Azure Active Directory users, Azure Active Directory groups, or an externalGroup as members.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Type <String>]`: identityType

INPUTOBJECT <ISearchIdentity>: Identity Parameter
  - `[AcronymId <String>]`: The unique identifier of acronym
  - `[BookmarkId <String>]`: The unique identifier of bookmark
  - `[ConnectionOperationId <String>]`: The unique identifier of connectionOperation
  - `[ExternalActivityId <String>]`: The unique identifier of externalActivity
  - `[ExternalConnectionId <String>]`: The unique identifier of externalConnection
  - `[ExternalGroupId <String>]`: The unique identifier of externalGroup
  - `[ExternalItemId <String>]`: The unique identifier of externalItem
  - `[IdentityId <String>]`: The unique identifier of identity
  - `[InboundFlowId <String>]`: The unique identifier of inboundFlow
  - `[IndustryDataConnectorId <String>]`: The unique identifier of industryDataConnector
  - `[IndustryDataRunActivityId <String>]`: The unique identifier of industryDataRunActivity
  - `[IndustryDataRunId <String>]`: The unique identifier of industryDataRun
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[QnaId <String>]`: The unique identifier of qna
  - `[ReferenceDefinitionId <String>]`: The unique identifier of referenceDefinition
  - `[RoleGroupId <String>]`: The unique identifier of roleGroup
  - `[SourceSystemDefinitionId <String>]`: The unique identifier of sourceSystemDefinition
  - `[YearTimePeriodDefinitionId <String>]`: The unique identifier of yearTimePeriodDefinition

ITEMS <IMicrosoftGraphExternalConnectorsExternalItem1[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Acl <IMicrosoftGraphExternalConnectorsAcl1[]>]`: An array of access control entries. Each entry specifies the access granted to a user or group. Required.
    - `[AccessType <String>]`: accessType
    - `[IdentitySource <String>]`: identitySourceType
    - `[Type <String>]`: aclType
    - `[Value <String>]`: The unique identifer of the identity. In case of Azure Active Directory identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. In case of external groups value is set to the ID of the externalGroup.
  - `[Activities <IMicrosoftGraphExternalConnectorsExternalActivity[]>]`: Write-only property. Returns results.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Type <String>]`: identityType
    - `[StartDateTime <DateTime?>]`: When the particular activity occurred.
    - `[Type <String>]`: externalActivityType
  - `[Content <IMicrosoftGraphExternalConnectorsExternalItemContent>]`: externalItemContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: externalItemContentType
    - `[Value <String>]`: The content for the externalItem. Required.
  - `[Properties <IMicrosoftGraphExternalConnectorsProperties>]`: properties
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

OPERATIONS <IMicrosoftGraphExternalConnectorsConnectionOperation[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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

QUOTA <IMicrosoftGraphExternalConnectorsConnectionQuota>: connectionQuota
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ItemsRemaining <Int64?>]`: The minimum of two values, one representing the items remaining in the connection and the other remaining items at tenant-level. The following equation represents the formula used to calculate the minimum number: min ({max capacity in the connection} – {number of items in the connection}, {tenant quota} – {number of items indexed in all connections}). If the connection is not monetized, such as in a preview connector or preview content experience, then this property is simply the number of remaining items in the connection.

SCHEMA <IMicrosoftGraphExternalConnectorsSchema1>: schema
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[BaseType <String>]`: Must be set to microsoft.graph.externalItem. Required.
  - `[Properties <IMicrosoftGraphExternalConnectorsProperty1[]>]`: The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
    - `[Aliases <String[]>]`: A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^. Optional.
    - `[IsExactMatchRequired <Boolean?>]`: Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.
    - `[IsQueryable <Boolean?>]`: Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
    - `[IsRefinable <Boolean?>]`: Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
    - `[IsRetrievable <Boolean?>]`: Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
    - `[IsSearchable <Boolean?>]`: Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.
    - `[Labels <String[]>]`: Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl, containerName, containerUrl. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: iconUrl, containerName, containerUrl.
    - `[Name <String>]`: The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &, ?, @, #, /, ~, ', ', <, >, `, ^.  Required.
    - `[Type <String>]`: propertyType

SEARCHSETTINGS <IMicrosoftGraphExternalConnectorsSearchSettings>: searchSettings
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

## RELATED LINKS

