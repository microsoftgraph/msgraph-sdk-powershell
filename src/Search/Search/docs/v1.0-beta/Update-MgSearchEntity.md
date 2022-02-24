---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/update-mgsearchentity
schema: 2.0.0
---

# Update-MgSearchEntity

## SYNOPSIS
Update search

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgSearchEntity [-Acronyms <IMicrosoftGraphSearchAcronym[]>] [-AdditionalProperties <Hashtable>]
 [-Bookmarks <IMicrosoftGraphSearchBookmark[]>] [-Id <String>] [-Qnas <IMicrosoftGraphSearchQna[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSearchEntity -BodyParameter <IMicrosoftGraphSearchEntity1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update search

## EXAMPLES

## PARAMETERS

### -Acronyms
.
To construct, please use Get-Help -Online and see NOTES section for ACRONYMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchAcronym[]
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
searchEntity
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchEntity1
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Bookmarks
.
To construct, please use Get-Help -Online and see NOTES section for BOOKMARKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchBookmark[]
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
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

### -Qnas
.
To construct, please use Get-Help -Online and see NOTES section for QNAS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchQna[]
Parameter Sets: UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchEntity1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACRONYMS <IMicrosoftGraphSearchAcronym[]>: .
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
    - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
    - `[User <IMicrosoftGraphSearchIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[WebUrl <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[StandsFor <String>]`: 
  - `[State <String>]`: answerState

BODYPARAMETER <IMicrosoftGraphSearchEntity1>: searchEntity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Acronyms <IMicrosoftGraphSearchAcronym[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: 
        - `[Id <String>]`: 
      - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
      - `[User <IMicrosoftGraphSearchIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[WebUrl <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[StandsFor <String>]`: 
    - `[State <String>]`: answerState
  - `[Bookmarks <IMicrosoftGraphSearchBookmark[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[WebUrl <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[AvailabilityEndDateTime <DateTime?>]`: 
    - `[AvailabilityStartDateTime <DateTime?>]`: 
    - `[Categories <String[]>]`: 
    - `[GroupIds <String[]>]`: 
    - `[IsSuggested <Boolean?>]`: 
    - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Keywords <String[]>]`: 
      - `[MatchSimilarKeywords <Boolean?>]`: 
      - `[ReservedKeywords <String[]>]`: 
    - `[LanguageTags <String[]>]`: 
    - `[Platforms <String[]>]`: 
    - `[PowerAppIds <String[]>]`: 
    - `[State <String>]`: answerState
    - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LanguageTag <String>]`: 
      - `[Platform <String>]`: Supported platform types.
      - `[WebUrl <String>]`: 
  - `[Qnas <IMicrosoftGraphSearchQna[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[WebUrl <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[AvailabilityEndDateTime <DateTime?>]`: 
    - `[AvailabilityStartDateTime <DateTime?>]`: 
    - `[GroupIds <String[]>]`: 
    - `[IsSuggested <Boolean?>]`: 
    - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[LanguageTags <String[]>]`: 
    - `[Platforms <String[]>]`: 
    - `[State <String>]`: answerState
    - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: 

BOOKMARKS <IMicrosoftGraphSearchBookmark[]>: .
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
    - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
    - `[User <IMicrosoftGraphSearchIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[WebUrl <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[AvailabilityEndDateTime <DateTime?>]`: 
  - `[AvailabilityStartDateTime <DateTime?>]`: 
  - `[Categories <String[]>]`: 
  - `[GroupIds <String[]>]`: 
  - `[IsSuggested <Boolean?>]`: 
  - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Keywords <String[]>]`: 
    - `[MatchSimilarKeywords <Boolean?>]`: 
    - `[ReservedKeywords <String[]>]`: 
  - `[LanguageTags <String[]>]`: 
  - `[Platforms <String[]>]`: 
  - `[PowerAppIds <String[]>]`: 
  - `[State <String>]`: answerState
  - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LanguageTag <String>]`: 
    - `[Platform <String>]`: Supported platform types.
    - `[WebUrl <String>]`: 

QNAS <IMicrosoftGraphSearchQna[]>: .
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphSearchIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphSearchIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
    - `[Device <IMicrosoftGraphSearchIdentity>]`: identity
    - `[User <IMicrosoftGraphSearchIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[WebUrl <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[AvailabilityEndDateTime <DateTime?>]`: 
  - `[AvailabilityStartDateTime <DateTime?>]`: 
  - `[GroupIds <String[]>]`: 
  - `[IsSuggested <Boolean?>]`: 
  - `[Keywords <IMicrosoftGraphSearchAnswerKeyword>]`: answerKeyword
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Keywords <String[]>]`: 
    - `[MatchSimilarKeywords <Boolean?>]`: 
    - `[ReservedKeywords <String[]>]`: 
  - `[LanguageTags <String[]>]`: 
  - `[Platforms <String[]>]`: 
  - `[State <String>]`: answerState
  - `[TargetedVariations <IMicrosoftGraphSearchAnswerVariant[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LanguageTag <String>]`: 
    - `[Platform <String>]`: Supported platform types.
    - `[WebUrl <String>]`: 

## RELATED LINKS

