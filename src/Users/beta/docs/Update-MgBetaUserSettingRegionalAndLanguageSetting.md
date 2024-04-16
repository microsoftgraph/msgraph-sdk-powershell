---
external help file:
Module Name: Microsoft.Graph.Beta.Users
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users/update-mgbetausersettingregionalandlanguagesetting
schema: 2.0.0
---

# Update-MgBetaUserSettingRegionalAndLanguageSetting

## SYNOPSIS
Update some or all of the properties of a regionalAndLanguageSettings object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserSettingRegionalAndLanguageSetting -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AuthoringLanguages <IMicrosoftGraphLocaleInfo[]>] [-DefaultDisplayLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultRegionalFormat <IMicrosoftGraphLocaleInfo>]
 [-DefaultSpeechInputLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultTranslationLanguage <IMicrosoftGraphLocaleInfo>] [-Id <String>]
 [-RegionalFormatOverrides <IMicrosoftGraphRegionalFormatOverrides>] [-ResponseHeadersVariable <String>]
 [-TranslationPreferences <IMicrosoftGraphTranslationPreferences>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaUserSettingRegionalAndLanguageSetting -UserId <String>
 -BodyParameter <IMicrosoftGraphRegionalAndLanguageSettings> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserSettingRegionalAndLanguageSetting -InputObject <IUsersIdentity>
 -BodyParameter <IMicrosoftGraphRegionalAndLanguageSettings> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserSettingRegionalAndLanguageSetting -InputObject <IUsersIdentity>
 [-AdditionalProperties <Hashtable>] [-AuthoringLanguages <IMicrosoftGraphLocaleInfo[]>]
 [-DefaultDisplayLanguage <IMicrosoftGraphLocaleInfo>] [-DefaultRegionalFormat <IMicrosoftGraphLocaleInfo>]
 [-DefaultSpeechInputLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultTranslationLanguage <IMicrosoftGraphLocaleInfo>] [-Id <String>]
 [-RegionalFormatOverrides <IMicrosoftGraphRegionalFormatOverrides>] [-ResponseHeadersVariable <String>]
 [-TranslationPreferences <IMicrosoftGraphTranslationPreferences>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update some or all of the properties of a regionalAndLanguageSettings object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	AuthoringLanguages = @(
		@{
			Locale = "en-US"
		}
		@{
			Locale = "es-MX"
		}
	)
	DefaultRegionalFormat = @{
		Locale = "en-US"
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserSettingRegionalAndLanguageSetting -UserId $userId -BodyParameter $params
```



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

### -AuthoringLanguages
Prioritized list of languages the user reads and authors in.Returned by default.
Not nullable.
To construct, see NOTES section for AUTHORINGLANGUAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
regionalAndLanguageSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRegionalAndLanguageSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultDisplayLanguage
localeInfo
To construct, see NOTES section for DEFAULTDISPLAYLANGUAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultRegionalFormat
localeInfo
To construct, see NOTES section for DEFAULTREGIONALFORMAT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultSpeechInputLanguage
localeInfo
To construct, see NOTES section for DEFAULTSPEECHINPUTLANGUAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultTranslationLanguage
localeInfo
To construct, see NOTES section for DEFAULTTRANSLATIONLANGUAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -RegionalFormatOverrides
regionalFormatOverrides
To construct, see NOTES section for REGIONALFORMATOVERRIDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRegionalFormatOverrides
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -TranslationPreferences
translationPreferences
To construct, see NOTES section for TRANSLATIONPREFERENCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTranslationPreferences
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRegionalAndLanguageSettings

### Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRegionalAndLanguageSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTHORINGLANGUAGES <IMicrosoftGraphLocaleInfo[]>`: Prioritized list of languages the user reads and authors in.Returned by default. Not nullable.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`BODYPARAMETER <IMicrosoftGraphRegionalAndLanguageSettings>`: regionalAndLanguageSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthoringLanguages <IMicrosoftGraphLocaleInfo[]>]`: Prioritized list of languages the user reads and authors in.Returned by default. Not nullable.
    - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
    - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  - `[DefaultDisplayLanguage <IMicrosoftGraphLocaleInfo>]`: localeInfo
  - `[DefaultRegionalFormat <IMicrosoftGraphLocaleInfo>]`: localeInfo
  - `[DefaultSpeechInputLanguage <IMicrosoftGraphLocaleInfo>]`: localeInfo
  - `[DefaultTranslationLanguage <IMicrosoftGraphLocaleInfo>]`: localeInfo
  - `[RegionalFormatOverrides <IMicrosoftGraphRegionalFormatOverrides>]`: regionalFormatOverrides
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Calendar <String>]`: The calendar to use, e.g., Gregorian Calendar.Returned by default.
    - `[FirstDayOfWeek <String>]`: The first day of the week to use, e.g., Sunday.Returned by default.
    - `[LongDateFormat <String>]`: The long date time format to be used for displaying dates.Returned by default.
    - `[LongTimeFormat <String>]`: The long time format to be used for displaying time.Returned by default.
    - `[ShortDateFormat <String>]`: The short date time format to be used for displaying dates.Returned by default.
    - `[ShortTimeFormat <String>]`: The short time format to be used for displaying time.Returned by default.
    - `[TimeZone <String>]`: The timezone to be used for displaying time.Returned by default.
  - `[TranslationPreferences <IMicrosoftGraphTranslationPreferences>]`: translationPreferences
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LanguageOverrides <IMicrosoftGraphTranslationLanguageOverride[]>]`: Translation override behavior for languages, if any.Returned by default.
      - `[LanguageTag <String>]`: The language to apply the override.Returned by default. Not nullable.
      - `[TranslationBehavior <String>]`: translationBehavior
    - `[TranslationBehavior <String>]`: translationBehavior
    - `[UntranslatedLanguages <String[]>]`: The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings, and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include the language code without any country or region association. For example, it would specify 'fr' for the neutral French culture, but not 'fr-FR' for the French culture in France. Returned by default. Read only.

`DEFAULTDISPLAYLANGUAGE <IMicrosoftGraphLocaleInfo>`: localeInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`DEFAULTREGIONALFORMAT <IMicrosoftGraphLocaleInfo>`: localeInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`DEFAULTSPEECHINPUTLANGUAGE <IMicrosoftGraphLocaleInfo>`: localeInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`DEFAULTTRANSLATIONLANGUAGE <IMicrosoftGraphLocaleInfo>`: localeInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
  - `[AppId <String>]`: Alternate key of servicePrincipal
  - `[AttachmentBaseId <String>]`: The unique identifier of attachmentBase
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[AttachmentSessionId <String>]`: The unique identifier of attachmentSession
  - `[ChecklistItemId <String>]`: The unique identifier of checklistItem
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[LicenseDetailsId <String>]`: The unique identifier of licenseDetails
  - `[LinkedResourceId <String>]`: The unique identifier of linkedResource
  - `[NotificationId <String>]`: The unique identifier of notification
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OutlookCategoryId <String>]`: The unique identifier of outlookCategory
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[ProfilePhotoId <String>]`: The unique identifier of profilePhoto
  - `[ServicePrincipalId <String>]`: The unique identifier of servicePrincipal
  - `[ServiceStorageQuotaBreakdownId <String>]`: The unique identifier of serviceStorageQuotaBreakdown
  - `[SharedInsightId <String>]`: The unique identifier of sharedInsight
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[TrendingId <String>]`: The unique identifier of trending
  - `[UsedInsightId <String>]`: The unique identifier of usedInsight
  - `[UserId <String>]`: The unique identifier of user
  - `[WindowsSettingId <String>]`: The unique identifier of windowsSetting
  - `[WindowsSettingInstanceId <String>]`: The unique identifier of windowsSettingInstance

`REGIONALFORMATOVERRIDES <IMicrosoftGraphRegionalFormatOverrides>`: regionalFormatOverrides
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Calendar <String>]`: The calendar to use, e.g., Gregorian Calendar.Returned by default.
  - `[FirstDayOfWeek <String>]`: The first day of the week to use, e.g., Sunday.Returned by default.
  - `[LongDateFormat <String>]`: The long date time format to be used for displaying dates.Returned by default.
  - `[LongTimeFormat <String>]`: The long time format to be used for displaying time.Returned by default.
  - `[ShortDateFormat <String>]`: The short date time format to be used for displaying dates.Returned by default.
  - `[ShortTimeFormat <String>]`: The short time format to be used for displaying time.Returned by default.
  - `[TimeZone <String>]`: The timezone to be used for displaying time.Returned by default.

`TRANSLATIONPREFERENCES <IMicrosoftGraphTranslationPreferences>`: translationPreferences
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LanguageOverrides <IMicrosoftGraphTranslationLanguageOverride[]>]`: Translation override behavior for languages, if any.Returned by default.
    - `[LanguageTag <String>]`: The language to apply the override.Returned by default. Not nullable.
    - `[TranslationBehavior <String>]`: translationBehavior
  - `[TranslationBehavior <String>]`: translationBehavior
  - `[UntranslatedLanguages <String[]>]`: The list of languages the user does not need translated. This is computed from the authoringLanguages collection in regionalAndLanguageSettings, and the languageOverrides collection in translationPreferences. The list specifies neutral culture values that include the language code without any country or region association. For example, it would specify 'fr' for the neutral French culture, but not 'fr-FR' for the French culture in France. Returned by default. Read only.

## RELATED LINKS

