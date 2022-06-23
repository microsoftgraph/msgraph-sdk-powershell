---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/new-mgsearchqna
schema: 2.0.0
---

# New-MgSearchQna

## SYNOPSIS
Administrative answer in Microsoft Search results which provide answers for specific search keywords in an organization.

## SYNTAX

### CreateExpanded (Default)
```
New-MgSearchQna [-AdditionalProperties <Hashtable>] [-AvailabilityEndDateTime <DateTime>]
 [-AvailabilityStartDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-GroupIds <String[]>] [-Id <String>] [-IsSuggested] [-Keywords <IMicrosoftGraphSearchAnswerKeyword>]
 [-LanguageTags <String[]>] [-LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Platforms <String[]>] [-State <String>]
 [-TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>] [-WebUrl <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgSearchQna -BodyParameter <IMicrosoftGraphSearchQna> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Administrative answer in Microsoft Search results which provide answers for specific search keywords in an organization.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityEndDateTime
Timestamp of when the qna will stop to appear as a search result.
Set as null for always available.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityStartDateTime
Timestamp of when the qna will start to appear as a search result.
Set as null for always available.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
qna
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchQna
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Search answer description shown on search results page.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Search answer name displayed in search results.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupIds
List of security groups able to view this qna.

```yaml
Type: System.String[]
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
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSuggested
True if this qna was suggested to the admin by a user or was mined and suggested by Microsoft.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Keywords
answerKeyword
To construct, please use Get-Help -Online and see NOTES section for KEYWORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchAnswerKeyword
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LanguageTags
A list of language names that are geographically specific and that this QnA can be viewed in.
Each language tag value follows the pattern {language}-{REGION}.
As an example, en-US is English as used in the United States.
See supported language tags for the list of possible values.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Timestamp of when the search answer is created or edited.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platforms
List of devices and operating systems able to view this qna.
Possible values are: unknown, android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, androidASOP.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedVariations
Variations of a qna for different countries or devices.
Use when you need to show different content to users based on their device, country/region, or both.
The date and group settings will apply to all variations.
To construct, please use Get-Help -Online and see NOTES section for TARGETEDVARIATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchAnswerVariant[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
Search answer URL link.
When users click this search answer in search results, they will go to this URL.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchQna

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchQna

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSearchQna>: qna
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Search answer description shown on search results page.
  - `[DisplayName <String>]`: Search answer name displayed in search results.
  - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
    - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
    - `[User <IMicrosoftGraphSearchIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: Timestamp of when the search answer is created or edited. Read-only.
  - `[WebUrl <String>]`: Search answer URL link. When users click this search answer in search results, they will go to this URL.
  - `[Id <String>]`: Read-only.
  - `[AvailabilityEndDateTime <DateTime?>]`: Timestamp of when the qna will stop to appear as a search result. Set as null for always available.
  - `[AvailabilityStartDateTime <DateTime?>]`: Timestamp of when the qna will start to appear as a search result. Set as null for always available.
  - `[GroupIds <String[]>]`: List of security groups able to view this qna.
  - `[IsSuggested <Boolean?>]`: True if this qna was suggested to the admin by a user or was mined and suggested by Microsoft. Read-only.
  - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
    - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
    - `[ReservedKeywords <String[]>]`: Unique keywords that will guarantee the search answer is triggered.
  - `[LanguageTags <String[]>]`: A list of language names that are geographically specific and that this QnA can be viewed in. Each language tag value follows the pattern {language}-{REGION}. As an example, en-US is English as used in the United States. See supported language tags for the list of possible values.
  - `[Platforms <String[]>]`: List of devices and operating systems able to view this qna. Possible values are: unknown, android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, androidASOP.
  - `[State <String>]`: answerState
  - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: Variations of a qna for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.
    - `[Description <String>]`: Answer variation description shown on search results page.
    - `[DisplayName <String>]`: Answer variation name displayed in search results.
    - `[LanguageTag <String>]`: 
    - `[Platform <String>]`: Supported platform types.
    - `[WebUrl <String>]`: Answer variation URL link. When users click this answer variation in search results, they will go to this URL.

KEYWORDS <IMicrosoftGraphSearchAnswerKeyword>: answerKeyword
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Keywords <String[]>]`: A collection of keywords used to trigger the search answer.
  - `[MatchSimilarKeywords <Boolean?>]`: If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.
  - `[ReservedKeywords <String[]>]`: Unique keywords that will guarantee the search answer is triggered.

LASTMODIFIEDBY <IMicrosoftGraphSearchIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
  - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
  - `[User <IMicrosoftGraphSearchIdentity>]`: identity

TARGETEDVARIATIONS <IMicrosoftGraphSearchAnswerVariant[]>: Variations of a qna for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.
  - `[Description <String>]`: Answer variation description shown on search results page.
  - `[DisplayName <String>]`: Answer variation name displayed in search results.
  - `[LanguageTag <String>]`: 
  - `[Platform <String>]`: Supported platform types.
  - `[WebUrl <String>]`: Answer variation URL link. When users click this answer variation in search results, they will go to this URL.

## RELATED LINKS

