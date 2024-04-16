---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/update-mgbetasearchqna
schema: 2.0.0
---

# Update-MgBetaSearchQna

## SYNOPSIS
Update the properties of a qna object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSearchQna -QnaId <String> [-AdditionalProperties <Hashtable>]
 [-AvailabilityEndDateTime <DateTime>] [-AvailabilityStartDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-GroupIds <String[]>] [-Id <String>] [-IsSuggested]
 [-Keywords <IMicrosoftGraphSearchAnswerKeyword>] [-LanguageTags <String[]>]
 [-LastModifiedBy <IMicrosoftGraphSearchIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Platforms <DevicePlatformType[]>] [-ResponseHeadersVariable <String>] [-State <String>]
 [-TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>] [-WebUrl <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSearchQna -QnaId <String> -BodyParameter <IMicrosoftGraphSearchQna>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSearchQna -InputObject <ISearchIdentity> -BodyParameter <IMicrosoftGraphSearchQna>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSearchQna -InputObject <ISearchIdentity> [-AdditionalProperties <Hashtable>]
 [-AvailabilityEndDateTime <DateTime>] [-AvailabilityStartDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-GroupIds <String[]>] [-Id <String>] [-IsSuggested]
 [-Keywords <IMicrosoftGraphSearchAnswerKeyword>] [-LanguageTags <String[]>]
 [-LastModifiedBy <IMicrosoftGraphSearchIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Platforms <DevicePlatformType[]>] [-ResponseHeadersVariable <String>] [-State <String>]
 [-TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>] [-WebUrl <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a qna object.

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityEndDateTime
Date and time when the QnA stops appearing as a search result.
Set as null for always available.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityStartDateTime
Date and time when the QnA starts to appear as a search result.
Set as null for always available.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
qna
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchQna
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The search answer description that is shown on the search results page.

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

### -DisplayName
The search answer name that is displayed in search results.

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

### -GroupIds
The list of security groups that are able to view this QnA.

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

### -Id
The unique identifier for an entity.
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ISearchIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsSuggested
True if a user or Microsoft suggested this QnA to the admin.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Keywords
answerKeyword
To construct, see NOTES section for KEYWORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchAnswerKeyword
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LanguageTags
A list of geographically specific language names in which this QnA can be viewed.
Each language tag value follows the pattern {language}-{region}.
For example, en-us is English as used in the United States.
For the list of possible values, see Supported language tags.

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

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Date and time when the search answer was created or last edited.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platforms
List of devices and operating systems that are able to view this QnA.
Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DevicePlatformType[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QnaId
The unique identifier of qna

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

### -State
answerState

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

### -TargetedVariations
Variations of a QnA for different countries or devices.
Use when you need to show different content to users based on their device, country/region, or both.
The date and group settings apply to all variations.
To construct, see NOTES section for TARGETEDVARIATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchAnswerVariant[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
The URL link for the search answer.
When users select this search answer from the search results, they're directed to the specified URL.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchQna

### Microsoft.Graph.Beta.PowerShell.Models.ISearchIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchQna

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSearchQna>`: qna
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: The search answer description that is shown on the search results page.
  - `[DisplayName <String>]`: The search answer name that is displayed in search results.
  - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
    - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
    - `[User <IMicrosoftGraphSearchIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: Date and time when the search answer was created or last edited. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[WebUrl <String>]`: The URL link for the search answer. When users select this search answer from the search results, they're directed to the specified URL.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AvailabilityEndDateTime <DateTime?>]`: Date and time when the QnA stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[AvailabilityStartDateTime <DateTime?>]`: Date and time when the QnA starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[GroupIds <String[]>]`: The list of security groups that are able to view this QnA.
  - `[IsSuggested <Boolean?>]`: True if a user or Microsoft suggested this QnA to the admin. Read-only.
  - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
    - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
    - `[ReservedKeywords <String[]>]`: Unique keywords that guarantee the search answer is triggered.
  - `[LanguageTags <String[]>]`: A list of geographically specific language names in which this QnA can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.
  - `[Platforms <DevicePlatformType[]>]`: List of devices and operating systems that are able to view this QnA. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.
  - `[State <String>]`: answerState
  - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: Variations of a QnA for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.
    - `[Description <String>]`: The answer variation description that is shown on the search results page.
    - `[DisplayName <String>]`: The answer variation name that is displayed in search results.
    - `[LanguageTag <String>]`: The country or region that can view this answer variation.
    - `[Platform <DevicePlatformType?>]`: Supported platform types.
    - `[WebUrl <String>]`: The URL link for the answer variation. When users select this answer variation from the search results, they're directed to the specified URL.

`INPUTOBJECT <ISearchIdentity>`: Identity Parameter
  - `[AcronymId <String>]`: The unique identifier of acronym
  - `[AuthorizationSystemId <String>]`: The unique identifier of authorizationSystem
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

`KEYWORDS <IMicrosoftGraphSearchAnswerKeyword>`: answerKeyword
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
  - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
  - `[ReservedKeywords <String[]>]`: Unique keywords that guarantee the search answer is triggered.

`LASTMODIFIEDBY <IMicrosoftGraphSearchIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
  - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
  - `[User <IMicrosoftGraphSearchIdentity>]`: identity

`TARGETEDVARIATIONS <IMicrosoftGraphSearchAnswerVariant[]>`: Variations of a QnA for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.
  - `[Description <String>]`: The answer variation description that is shown on the search results page.
  - `[DisplayName <String>]`: The answer variation name that is displayed in search results.
  - `[LanguageTag <String>]`: The country or region that can view this answer variation.
  - `[Platform <DevicePlatformType?>]`: Supported platform types.
  - `[WebUrl <String>]`: The URL link for the answer variation. When users select this answer variation from the search results, they're directed to the specified URL.

## RELATED LINKS

