---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/update-mgbetasearchentity
schema: 2.0.0
---

# Update-MgBetaSearchEntity

## SYNOPSIS
Update search

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSearchEntity [-Acronyms <IMicrosoftGraphSearchAcronym[]>] [-AdditionalProperties <Hashtable>]
 [-Bookmarks <IMicrosoftGraphSearchBookmark[]>] [-Id <String>] [-Qnas <IMicrosoftGraphSearchQna[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSearchEntity -BodyParameter <IMicrosoftGraphSearchEntity> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update search

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

### -Acronyms
Administrative answer in Microsoft Search results to define common acronyms in an organization.
To construct, see NOTES section for ACRONYMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchAcronym[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
searchEntity
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchEntity
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Bookmarks
Administrative answer in Microsoft Search results for common search queries in an organization.
To construct, see NOTES section for BOOKMARKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchBookmark[]
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

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Qnas
Administrative answer in Microsoft Search results that provide answers for specific search keywords in an organization.
To construct, see NOTES section for QNAS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchQna[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchEntity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSearchEntity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACRONYMS <IMicrosoftGraphSearchAcronym[]>`: Administrative answer in Microsoft Search results to define common acronyms in an organization.
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
  - `[StandsFor <String>]`: What the acronym stands for.
  - `[State <String>]`: answerState

`BODYPARAMETER <IMicrosoftGraphSearchEntity>`: searchEntity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Acronyms <IMicrosoftGraphSearchAcronym[]>]`: Administrative answer in Microsoft Search results to define common acronyms in an organization.
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
    - `[StandsFor <String>]`: What the acronym stands for.
    - `[State <String>]`: answerState
  - `[Bookmarks <IMicrosoftGraphSearchBookmark[]>]`: Administrative answer in Microsoft Search results for common search queries in an organization.
    - `[Description <String>]`: The search answer description that is shown on the search results page.
    - `[DisplayName <String>]`: The search answer name that is displayed in search results.
    - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Date and time when the search answer was created or last edited. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[WebUrl <String>]`: The URL link for the search answer. When users select this search answer from the search results, they're directed to the specified URL.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AvailabilityEndDateTime <DateTime?>]`: Date and time when the bookmark stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[AvailabilityStartDateTime <DateTime?>]`: Date and time when the bookmark starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Categories <String[]>]`: Categories commonly used to describe this bookmark. For example, IT and HR.
    - `[GroupIds <String[]>]`: The list of security groups that are able to view this bookmark.
    - `[IsSuggested <Boolean?>]`: True if this bookmark was suggested to the admin, by a user, or was mined and suggested by Microsoft. Read-only.
    - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
      - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
      - `[ReservedKeywords <String[]>]`: Unique keywords that guarantee the search answer is triggered.
    - `[LanguageTags <String[]>]`: A list of geographically specific language names in which this bookmark can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.
    - `[Platforms <DevicePlatformType[]>]`: List of devices and operating systems that are able to view this bookmark. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.
    - `[PowerAppIds <String[]>]`: List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks directly on the search results page, such as entering vacation time or reporting expenses.
    - `[State <String>]`: answerState
    - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.
      - `[Description <String>]`: The answer variation description that is shown on the search results page.
      - `[DisplayName <String>]`: The answer variation name that is displayed in search results.
      - `[LanguageTag <String>]`: The country or region that can view this answer variation.
      - `[Platform <DevicePlatformType?>]`: Supported platform types.
      - `[WebUrl <String>]`: The URL link for the answer variation. When users select this answer variation from the search results, they're directed to the specified URL.
  - `[Qnas <IMicrosoftGraphSearchQna[]>]`: Administrative answer in Microsoft Search results that provide answers for specific search keywords in an organization.
    - `[Description <String>]`: The search answer description that is shown on the search results page.
    - `[DisplayName <String>]`: The search answer name that is displayed in search results.
    - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Date and time when the search answer was created or last edited. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[WebUrl <String>]`: The URL link for the search answer. When users select this search answer from the search results, they're directed to the specified URL.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AvailabilityEndDateTime <DateTime?>]`: Date and time when the QnA stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[AvailabilityStartDateTime <DateTime?>]`: Date and time when the QnA starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[GroupIds <String[]>]`: The list of security groups that are able to view this QnA.
    - `[IsSuggested <Boolean?>]`: True if a user or Microsoft suggested this QnA to the admin. Read-only.
    - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[LanguageTags <String[]>]`: A list of geographically specific language names in which this QnA can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.
    - `[Platforms <DevicePlatformType[]>]`: List of devices and operating systems that are able to view this QnA. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.
    - `[State <String>]`: answerState
    - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: Variations of a QnA for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.

`BOOKMARKS <IMicrosoftGraphSearchBookmark[]>`: Administrative answer in Microsoft Search results for common search queries in an organization.
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
  - `[AvailabilityEndDateTime <DateTime?>]`: Date and time when the bookmark stops appearing as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[AvailabilityStartDateTime <DateTime?>]`: Date and time when the bookmark starts to appear as a search result. Set as null for always available. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Categories <String[]>]`: Categories commonly used to describe this bookmark. For example, IT and HR.
  - `[GroupIds <String[]>]`: The list of security groups that are able to view this bookmark.
  - `[IsSuggested <Boolean?>]`: True if this bookmark was suggested to the admin, by a user, or was mined and suggested by Microsoft. Read-only.
  - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
    - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
    - `[ReservedKeywords <String[]>]`: Unique keywords that guarantee the search answer is triggered.
  - `[LanguageTags <String[]>]`: A list of geographically specific language names in which this bookmark can be viewed. Each language tag value follows the pattern {language}-{region}. For example, en-us is English as used in the United States. For the list of possible values, see Supported language tags.
  - `[Platforms <DevicePlatformType[]>]`: List of devices and operating systems that are able to view this bookmark. Possible values are: android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, unknown, androidASOP, androidMobileApplicationManagement, iOSMobileApplicationManagement, unknownFutureValue.
  - `[PowerAppIds <String[]>]`: List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks directly on the search results page, such as entering vacation time or reporting expenses.
  - `[State <String>]`: answerState
  - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings apply to all variations.
    - `[Description <String>]`: The answer variation description that is shown on the search results page.
    - `[DisplayName <String>]`: The answer variation name that is displayed in search results.
    - `[LanguageTag <String>]`: The country or region that can view this answer variation.
    - `[Platform <DevicePlatformType?>]`: Supported platform types.
    - `[WebUrl <String>]`: The URL link for the answer variation. When users select this answer variation from the search results, they're directed to the specified URL.

`QNAS <IMicrosoftGraphSearchQna[]>`: Administrative answer in Microsoft Search results that provide answers for specific search keywords in an organization.
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

## RELATED LINKS

