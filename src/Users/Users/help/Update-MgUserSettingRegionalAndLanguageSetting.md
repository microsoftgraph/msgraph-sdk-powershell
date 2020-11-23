---
external help file: Microsoft.Graph.Users-help.xml
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/update-mgusersettingregionalandlanguagesetting
schema: 2.0.0
---

# Update-MgUserSettingRegionalAndLanguageSetting

## SYNOPSIS
Update the navigation property regionalAndLanguageSettings in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserSettingRegionalAndLanguageSetting -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AuthoringLanguages <IMicrosoftGraphLocaleInfo[]>] [-DefaultDisplayLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultRegionalFormat <IMicrosoftGraphLocaleInfo>] [-DefaultSpeechInputLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultTranslationLanguage <IMicrosoftGraphLocaleInfo>] [-Id <String>]
 [-RegionalFormatOverrides <IMicrosoftGraphRegionalFormatOverrides>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgUserSettingRegionalAndLanguageSetting -UserId <String>
 -BodyParameter <IMicrosoftGraphRegionalAndLanguageSettings> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserSettingRegionalAndLanguageSetting -InputObject <IUsersIdentity>
 [-AdditionalProperties <Hashtable>] [-AuthoringLanguages <IMicrosoftGraphLocaleInfo[]>]
 [-DefaultDisplayLanguage <IMicrosoftGraphLocaleInfo>] [-DefaultRegionalFormat <IMicrosoftGraphLocaleInfo>]
 [-DefaultSpeechInputLanguage <IMicrosoftGraphLocaleInfo>]
 [-DefaultTranslationLanguage <IMicrosoftGraphLocaleInfo>] [-Id <String>]
 [-RegionalFormatOverrides <IMicrosoftGraphRegionalFormatOverrides>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserSettingRegionalAndLanguageSetting -InputObject <IUsersIdentity>
 -BodyParameter <IMicrosoftGraphRegionalAndLanguageSettings> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property regionalAndLanguageSettings in users

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthoringLanguages
.
To construct, see NOTES section for AUTHORINGLANGUAGES properties and create a hash table.

```yaml
Type: IMicrosoftGraphLocaleInfo[]
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
Type: IMicrosoftGraphRegionalAndLanguageSettings
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
Type: IMicrosoftGraphLocaleInfo
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
Type: IMicrosoftGraphLocaleInfo
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
Type: IMicrosoftGraphLocaleInfo
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
Type: IMicrosoftGraphLocaleInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: IUsersIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegionalFormatOverrides
regionalFormatOverrides
To construct, see NOTES section for REGIONALFORMATOVERRIDES properties and create a hash table.

```yaml
Type: IMicrosoftGraphRegionalFormatOverrides
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRegionalAndLanguageSettings
### Microsoft.Graph.PowerShell.Models.IUsersIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

AUTHORINGLANGUAGES \<IMicrosoftGraphLocaleInfo\[\]\>: .
  \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
  \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

BODYPARAMETER \<IMicrosoftGraphRegionalAndLanguageSettings\>: regionalAndLanguageSettings
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AuthoringLanguages \<IMicrosoftGraphLocaleInfo\[\]\>\]: 
    \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
    \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  \[DefaultDisplayLanguage \<IMicrosoftGraphLocaleInfo\>\]: localeInfo
  \[DefaultRegionalFormat \<IMicrosoftGraphLocaleInfo\>\]: localeInfo
  \[DefaultSpeechInputLanguage \<IMicrosoftGraphLocaleInfo\>\]: localeInfo
  \[DefaultTranslationLanguage \<IMicrosoftGraphLocaleInfo\>\]: localeInfo
  \[RegionalFormatOverrides \<IMicrosoftGraphRegionalFormatOverrides\>\]: regionalFormatOverrides
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Calendar \<String\>\]: 
    \[FirstDayOfWeek \<String\>\]: 
    \[LongDateFormat \<String\>\]: 
    \[LongTimeFormat \<String\>\]: 
    \[ShortDateFormat \<String\>\]: 
    \[ShortTimeFormat \<String\>\]: 
    \[TimeZone \<String\>\]: 

DEFAULTDISPLAYLANGUAGE \<IMicrosoftGraphLocaleInfo\>: localeInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
  \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

DEFAULTREGIONALFORMAT \<IMicrosoftGraphLocaleInfo\>: localeInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
  \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

DEFAULTSPEECHINPUTLANGUAGE \<IMicrosoftGraphLocaleInfo\>: localeInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
  \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

DEFAULTTRANSLATIONLANGUAGE \<IMicrosoftGraphLocaleInfo\>: localeInfo
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: A name representing the user's locale in natural language, for example, 'English (United States)'.
  \[Locale \<String\>\]: A locale representation for the user, which includes the user's preferred language and country/region.
For example, 'en-us'.
The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

INPUTOBJECT \<IUsersIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ExtensionId \<String\>\]: key: id of extension
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[LinkedResourceId \<String\>\]: key: id of linkedResource
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[NotificationId \<String\>\]: key: id of notification
  \[OutlookCategoryId \<String\>\]: key: id of outlookCategory
  \[OutlookTaskFolderId \<String\>\]: key: id of outlookTaskFolder
  \[OutlookTaskGroupId \<String\>\]: key: id of outlookTaskGroup
  \[OutlookTaskId \<String\>\]: key: id of outlookTask
  \[ProfilePhotoId \<String\>\]: key: id of profilePhoto
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[TodoTaskId \<String\>\]: key: id of todoTask
  \[TodoTaskListId \<String\>\]: key: id of todoTaskList
  \[UserId \<String\>\]: key: id of user

REGIONALFORMATOVERRIDES \<IMicrosoftGraphRegionalFormatOverrides\>: regionalFormatOverrides
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Calendar \<String\>\]: 
  \[FirstDayOfWeek \<String\>\]: 
  \[LongDateFormat \<String\>\]: 
  \[LongTimeFormat \<String\>\]: 
  \[ShortDateFormat \<String\>\]: 
  \[ShortTimeFormat \<String\>\]: 
  \[TimeZone \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/update-mgusersettingregionalandlanguagesetting](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/update-mgusersettingregionalandlanguagesetting)

