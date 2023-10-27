---
external help file:
Module Name: Microsoft.Graph.Beta.Users
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users/update-mgbetausersetting
schema: 2.0.0
---

# Update-MgBetaUserSetting

## SYNOPSIS
Update the navigation property settings in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserSetting -UserId <String> [-AdditionalProperties <Hashtable>]
 [-ContactMergeSuggestions <IMicrosoftGraphContactMergeSuggestions>]
 [-ContributionToContentDiscoveryAsOrganizationDisabled] [-ContributionToContentDiscoveryDisabled]
 [-Id <String>] [-ItemInsights <IMicrosoftGraphUserInsightsSettings>]
 [-RegionalAndLanguageSettings <IMicrosoftGraphRegionalAndLanguageSettings>]
 [-ShiftPreferences <IMicrosoftGraphShiftPreferences>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaUserSetting -UserId <String> -BodyParameter <IMicrosoftGraphUserSettings> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserSetting -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphUserSettings> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserSetting -InputObject <IUsersIdentity> [-AdditionalProperties <Hashtable>]
 [-ContactMergeSuggestions <IMicrosoftGraphContactMergeSuggestions>]
 [-ContributionToContentDiscoveryAsOrganizationDisabled] [-ContributionToContentDiscoveryDisabled]
 [-Id <String>] [-ItemInsights <IMicrosoftGraphUserInsightsSettings>]
 [-RegionalAndLanguageSettings <IMicrosoftGraphRegionalAndLanguageSettings>]
 [-ShiftPreferences <IMicrosoftGraphShiftPreferences>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property settings in users

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

### -BodyParameter
userSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContactMergeSuggestions
contactMergeSuggestions
To construct, see NOTES section for CONTACTMERGESUGGESTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphContactMergeSuggestions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContributionToContentDiscoveryAsOrganizationDisabled
Reflects the Office Delve organization level setting.
When set to true, the organization doesn't have access to Office Delve.
This setting is read-only and can only be changed by administrators in the SharePoint admin center.

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

### -ContributionToContentDiscoveryDisabled
When set to true, documents in the user's Office Delve are disabled.
Users can control this setting in Office Delve.

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

### -ItemInsights
userInsightsSettings
To construct, see NOTES section for ITEMINSIGHTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserInsightsSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegionalAndLanguageSettings
regionalAndLanguageSettings
To construct, see NOTES section for REGIONALANDLANGUAGESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRegionalAndLanguageSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShiftPreferences
shiftPreferences
To construct, see NOTES section for SHIFTPREFERENCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphShiftPreferences
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserSettings

### Microsoft.Graph.Beta.PowerShell.Models.IUsersIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserSettings>`: userSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ContactMergeSuggestions <IMicrosoftGraphContactMergeSuggestions>]`: contactMergeSuggestions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsEnabled <Boolean?>]`: true if the duplicate contact merge suggestions feature is enabled for the user; false if the feature is disabled. Default value is true.
  - `[ContributionToContentDiscoveryAsOrganizationDisabled <Boolean?>]`: Reflects the Office Delve organization level setting. When set to true, the organization doesn't have access to Office Delve. This setting is read-only and can only be changed by administrators in the SharePoint admin center.
  - `[ContributionToContentDiscoveryDisabled <Boolean?>]`: When set to true, documents in the user's Office Delve are disabled. Users can control this setting in Office Delve.
  - `[ItemInsights <IMicrosoftGraphUserInsightsSettings>]`: userInsightsSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsEnabled <Boolean?>]`: true if user's itemInsights and meeting hours insights are enabled; false if user's itemInsights and meeting hours insights are disabled. Default is true. Optional.
  - `[RegionalAndLanguageSettings <IMicrosoftGraphRegionalAndLanguageSettings>]`: regionalAndLanguageSettings
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
  - `[ShiftPreferences <IMicrosoftGraphShiftPreferences>]`: shiftPreferences
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
      - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
          - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
          - `[FirstDayOfWeek <String>]`: dayOfWeek
          - `[Index <String>]`: weekIndex
          - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
          - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
          - `[Type <String>]`: recurrencePatternType
        - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
          - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
          - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
          - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
          - `[Type <String>]`: recurrenceRangeType
      - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
        - `[EndTime <String>]`: End time for the time range.
        - `[StartTime <String>]`: Start time for the time range.
      - `[TimeZone <String>]`: Specifies the time zone for the indicated time.

`CONTACTMERGESUGGESTIONS <IMicrosoftGraphContactMergeSuggestions>`: contactMergeSuggestions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsEnabled <Boolean?>]`: true if the duplicate contact merge suggestions feature is enabled for the user; false if the feature is disabled. Default value is true.

`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
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
  - `[SharedInsightId <String>]`: The unique identifier of sharedInsight
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[TrendingId <String>]`: The unique identifier of trending
  - `[UsedInsightId <String>]`: The unique identifier of usedInsight
  - `[UserId <String>]`: The unique identifier of user

`ITEMINSIGHTS <IMicrosoftGraphUserInsightsSettings>`: userInsightsSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsEnabled <Boolean?>]`: true if user's itemInsights and meeting hours insights are enabled; false if user's itemInsights and meeting hours insights are disabled. Default is true. Optional.

`REGIONALANDLANGUAGESETTINGS <IMicrosoftGraphRegionalAndLanguageSettings>`: regionalAndLanguageSettings
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

`SHIFTPREFERENCES <IMicrosoftGraphShiftPreferences>`: shiftPreferences
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
    - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
        - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
        - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        - `[Type <String>]`: recurrenceRangeType
    - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
      - `[EndTime <String>]`: End time for the time range.
      - `[StartTime <String>]`: Start time for the time range.
    - `[TimeZone <String>]`: Specifies the time zone for the indicated time.

## RELATED LINKS

