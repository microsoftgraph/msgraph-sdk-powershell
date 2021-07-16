---
external help file: Microsoft.Graph.Files-help.xml
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/new-mgdrivelistcolumn
schema: 2.0.0
---

# New-MgDriveListColumn

## SYNOPSIS
The collection of field definitions for this list.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDriveListColumn -DriveId <String> [-AdditionalProperties <Hashtable>] [-Boolean <Hashtable>]
 [-Calculated <IMicrosoftGraphCalculatedColumn>] [-Choice <IMicrosoftGraphChoiceColumn>]
 [-ColumnGroup <String>] [-ContentApprovalStatus <Hashtable>] [-Currency <IMicrosoftGraphCurrencyColumn>]
 [-DateTime <IMicrosoftGraphDateTimeColumn>] [-DefaultValue <IMicrosoftGraphDefaultColumnValue>]
 [-Description <String>] [-DisplayName <String>] [-EnforceUniqueValues] [-Geolocation <Hashtable>] [-Hidden]
 [-HyperlinkOrPicture <IMicrosoftGraphHyperlinkOrPictureColumn>] [-Id <String>] [-Indexed] [-IsDeletable]
 [-IsReorderable] [-IsSealed] [-Lookup <IMicrosoftGraphLookupColumn>] [-Name <String>]
 [-Number <IMicrosoftGraphNumberColumn>] [-PersonOrGroup <IMicrosoftGraphPersonOrGroupColumn>]
 [-PropagateChanges] [-ReadOnly] [-Required] [-SourceColumn <IMicrosoftGraphColumnDefinition>]
 [-Term <IMicrosoftGraphTermColumn>] [-Text <IMicrosoftGraphTextColumn>] [-Thumbnail <Hashtable>]
 [-Type <String>] [-Validation <IMicrosoftGraphColumnValidation>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgDriveListColumn -DriveId <String> -BodyParameter <IMicrosoftGraphColumnDefinition> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgDriveListColumn -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>] [-Boolean <Hashtable>]
 [-Calculated <IMicrosoftGraphCalculatedColumn>] [-Choice <IMicrosoftGraphChoiceColumn>]
 [-ColumnGroup <String>] [-ContentApprovalStatus <Hashtable>] [-Currency <IMicrosoftGraphCurrencyColumn>]
 [-DateTime <IMicrosoftGraphDateTimeColumn>] [-DefaultValue <IMicrosoftGraphDefaultColumnValue>]
 [-Description <String>] [-DisplayName <String>] [-EnforceUniqueValues] [-Geolocation <Hashtable>] [-Hidden]
 [-HyperlinkOrPicture <IMicrosoftGraphHyperlinkOrPictureColumn>] [-Id <String>] [-Indexed] [-IsDeletable]
 [-IsReorderable] [-IsSealed] [-Lookup <IMicrosoftGraphLookupColumn>] [-Name <String>]
 [-Number <IMicrosoftGraphNumberColumn>] [-PersonOrGroup <IMicrosoftGraphPersonOrGroupColumn>]
 [-PropagateChanges] [-ReadOnly] [-Required] [-SourceColumn <IMicrosoftGraphColumnDefinition>]
 [-Term <IMicrosoftGraphTermColumn>] [-Text <IMicrosoftGraphTextColumn>] [-Thumbnail <Hashtable>]
 [-Type <String>] [-Validation <IMicrosoftGraphColumnValidation>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgDriveListColumn -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphColumnDefinition> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The collection of field definitions for this list.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
columnDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphColumnDefinition
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Boolean
booleanColumn

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Calculated
calculatedColumn
To construct, see NOTES section for CALCULATED properties and create a hash table.

```yaml
Type: IMicrosoftGraphCalculatedColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Choice
choiceColumn
To construct, see NOTES section for CHOICE properties and create a hash table.

```yaml
Type: IMicrosoftGraphChoiceColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnGroup
For site columns, the name of the group this column belongs to.
Helps organize related columns.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentApprovalStatus
contentApprovalStatusColumn

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Currency
currencyColumn
To construct, see NOTES section for CURRENCY properties and create a hash table.

```yaml
Type: IMicrosoftGraphCurrencyColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DateTime
dateTimeColumn
To construct, see NOTES section for DATETIME properties and create a hash table.

```yaml
Type: IMicrosoftGraphDateTimeColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultValue
defaultColumnValue
To construct, see NOTES section for DEFAULTVALUE properties and create a hash table.

```yaml
Type: IMicrosoftGraphDefaultColumnValue
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The user-facing description of the column.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The user-facing name of the column.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveId
key: id of drive

```yaml
Type: String
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnforceUniqueValues
If true, no two list items may have the same value for this column.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Geolocation
geolocationColumn

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Hidden
Specifies whether the column is displayed in the user interface.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HyperlinkOrPicture
hyperlinkOrPictureColumn
To construct, see NOTES section for HYPERLINKORPICTURE properties and create a hash table.

```yaml
Type: IMicrosoftGraphHyperlinkOrPictureColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Indexed
Specifies whether the column values can used for sorting and searching.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: IFilesIdentity
Parameter Sets: CreateViaIdentityExpanded1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDeletable
Indicates whether this column can be deleted.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsReorderable
Indicates whether values in the column can be reordered.
Read-only.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSealed
Specifies whether column can be changed.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Lookup
lookupColumn
To construct, see NOTES section for LOOKUP properties and create a hash table.

```yaml
Type: IMicrosoftGraphLookupColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The API-facing name of the column as it appears in the [fields][] on a [listItem][].
For the user-facing name, see displayName.

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Number
numberColumn
To construct, see NOTES section for NUMBER properties and create a hash table.

```yaml
Type: IMicrosoftGraphNumberColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonOrGroup
personOrGroupColumn
To construct, see NOTES section for PERSONORGROUP properties and create a hash table.

```yaml
Type: IMicrosoftGraphPersonOrGroupColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PropagateChanges
If 'True' changes to this column will be propagated to lists that implement the column.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReadOnly
Specifies whether the column values can be modified.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Required
Specifies whether the column value is not optional.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceColumn
columnDefinition
To construct, see NOTES section for SOURCECOLUMN properties and create a hash table.

```yaml
Type: IMicrosoftGraphColumnDefinition
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Term
termColumn
To construct, see NOTES section for TERM properties and create a hash table.

```yaml
Type: IMicrosoftGraphTermColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Text
textColumn
To construct, see NOTES section for TEXT properties and create a hash table.

```yaml
Type: IMicrosoftGraphTextColumn
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Thumbnail
thumbnailColumn

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
columnTypes

```yaml
Type: String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Validation
columnValidation
To construct, see NOTES section for VALIDATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphColumnValidation
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphColumnDefinition>: columnDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Boolean <IMicrosoftGraphBooleanColumn>]`: booleanColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Calculated <IMicrosoftGraphCalculatedColumn>]`: calculatedColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Format <String>]`: For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
    - `[Formula <String>]`: The formula used to compute the value for this column.
    - `[OutputType <String>]`: The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
  - `[Choice <IMicrosoftGraphChoiceColumn>]`: choiceColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowTextEntry <Boolean?>]`: If true, allows custom values that aren't in the configured choices.
    - `[Choices <String[]>]`: The list of values available for this column.
    - `[DisplayAs <String>]`: How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons
  - `[ColumnGroup <String>]`: For site columns, the name of the group this column belongs to. Helps organize related columns.
  - `[ContentApprovalStatus <IMicrosoftGraphContentApprovalStatusColumn>]`: contentApprovalStatusColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Currency <IMicrosoftGraphCurrencyColumn>]`: currencyColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Locale <String>]`: Specifies the locale from which to infer the currency symbol.
  - `[DateTime <IMicrosoftGraphDateTimeColumn>]`: dateTimeColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.
    - `[Format <String>]`: Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime
  - `[DefaultValue <IMicrosoftGraphDefaultColumnValue>]`: defaultColumnValue
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Formula <String>]`: The formula used to compute the default value for this column.
    - `[Value <String>]`: The direct value to use as the default value for this column.
  - `[Description <String>]`: The user-facing description of the column.
  - `[DisplayName <String>]`: The user-facing name of the column.
  - `[EnforceUniqueValues <Boolean?>]`: If true, no two list items may have the same value for this column.
  - `[Geolocation <IMicrosoftGraphGeolocationColumn>]`: geolocationColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Hidden <Boolean?>]`: Specifies whether the column is displayed in the user interface.
  - `[HyperlinkOrPicture <IMicrosoftGraphHyperlinkOrPictureColumn>]`: hyperlinkOrPictureColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsPicture <Boolean?>]`: Specifies whether the display format used for URL columns is an image or a hyperlink.
  - `[Indexed <Boolean?>]`: Specifies whether the column values can used for sorting and searching.
  - `[IsDeletable <Boolean?>]`: Indicates whether this column can be deleted.
  - `[IsReorderable <Boolean?>]`: Indicates whether values in the column can be reordered. Read-only.
  - `[IsSealed <Boolean?>]`: Specifies whether column can be changed.
  - `[Lookup <IMicrosoftGraphLookupColumn>]`: lookupColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Indicates whether multiple values can be selected from the source.
    - `[AllowUnlimitedLength <Boolean?>]`: Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
    - `[ColumnName <String>]`: The name of the lookup source column.
    - `[ListId <String>]`: The unique identifier of the lookup source list.
    - `[PrimaryLookupColumnId <String>]`: If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.
  - `[Name <String>]`: The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.
  - `[Number <IMicrosoftGraphNumberColumn>]`: numberColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DecimalPlaces <String>]`: How many decimal places to display. See below for information about the possible values.
    - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.
    - `[Maximum <Double?>]`: The maximum permitted value.
    - `[Minimum <Double?>]`: The minimum permitted value.
  - `[PersonOrGroup <IMicrosoftGraphPersonOrGroupColumn>]`: personOrGroupColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleSelection <Boolean?>]`: Indicates whether multiple values can be selected from the source.
    - `[ChooseFromType <String>]`: Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.
    - `[DisplayAs <String>]`: How to display the information about the person or group chosen. See below.
  - `[PropagateChanges <Boolean?>]`: If 'True' changes to this column will be propagated to lists that implement the column.
  - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
  - `[Required <Boolean?>]`: Specifies whether the column value is not optional.
  - `[SourceColumn <IMicrosoftGraphColumnDefinition>]`: columnDefinition
  - `[Term <IMicrosoftGraphTermColumn>]`: termColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
    - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
  - `[Text <IMicrosoftGraphTextColumn>]`: textColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleLines <Boolean?>]`: Whether to allow multiple lines of text.
    - `[AppendChangesToExistingText <Boolean?>]`: Whether updates to this column should replace existing text, or append to it.
    - `[LinesForEditing <Int32?>]`: The size of the text box.
    - `[MaxLength <Int32?>]`: The maximum number of characters for the value.
    - `[TextType <String>]`: The type of text being stored. Must be one of plain or richText
  - `[Thumbnail <IMicrosoftGraphThumbnailColumn>]`: thumbnailColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: columnTypes
  - `[Validation <IMicrosoftGraphColumnValidation>]`: columnValidation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultLanguage <String>]`: Default BCP 47 language tag for the description.
    - `[Descriptions <IMicrosoftGraphDisplayNameLocalization[]>]`: Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with this message if validation fails.
      - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
      - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
    - `[Formula <String>]`: The formula to validate column value. For examples, see Examples of common formulas in lists

CALCULATED <IMicrosoftGraphCalculatedColumn>: calculatedColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Format <String>]`: For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
  - `[Formula <String>]`: The formula used to compute the value for this column.
  - `[OutputType <String>]`: The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.

CHOICE <IMicrosoftGraphChoiceColumn>: choiceColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowTextEntry <Boolean?>]`: If true, allows custom values that aren't in the configured choices.
  - `[Choices <String[]>]`: The list of values available for this column.
  - `[DisplayAs <String>]`: How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons

CURRENCY <IMicrosoftGraphCurrencyColumn>: currencyColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Locale <String>]`: Specifies the locale from which to infer the currency symbol.

DATETIME <IMicrosoftGraphDateTimeColumn>: dateTimeColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.
  - `[Format <String>]`: Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime

DEFAULTVALUE <IMicrosoftGraphDefaultColumnValue>: defaultColumnValue
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Formula <String>]`: The formula used to compute the default value for this column.
  - `[Value <String>]`: The direct value to use as the default value for this column.

HYPERLINKORPICTURE <IMicrosoftGraphHyperlinkOrPictureColumn>: hyperlinkOrPictureColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsPicture <Boolean?>]`: Specifies whether the display format used for URL columns is an image or a hyperlink.

INPUTOBJECT <IFilesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[EndDateTime <String>]`: Usage: endDateTime={endDateTime}
  - `[GroupId <String>]`: key: id of group
  - `[Interval <String>]`: Usage: interval={interval}
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[Q <String>]`: Usage: q={q}
  - `[SharedDriveItemId <String>]`: key: id of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime={startDateTime}
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[UserId <String>]`: key: id of user

LOOKUP <IMicrosoftGraphLookupColumn>: lookupColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowMultipleValues <Boolean?>]`: Indicates whether multiple values can be selected from the source.
  - `[AllowUnlimitedLength <Boolean?>]`: Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
  - `[ColumnName <String>]`: The name of the lookup source column.
  - `[ListId <String>]`: The unique identifier of the lookup source list.
  - `[PrimaryLookupColumnId <String>]`: If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.

NUMBER <IMicrosoftGraphNumberColumn>: numberColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DecimalPlaces <String>]`: How many decimal places to display. See below for information about the possible values.
  - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.
  - `[Maximum <Double?>]`: The maximum permitted value.
  - `[Minimum <Double?>]`: The minimum permitted value.

PERSONORGROUP <IMicrosoftGraphPersonOrGroupColumn>: personOrGroupColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowMultipleSelection <Boolean?>]`: Indicates whether multiple values can be selected from the source.
  - `[ChooseFromType <String>]`: Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.
  - `[DisplayAs <String>]`: How to display the information about the person or group chosen. See below.

SOURCECOLUMN <IMicrosoftGraphColumnDefinition>: columnDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Boolean <IMicrosoftGraphBooleanColumn>]`: booleanColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Calculated <IMicrosoftGraphCalculatedColumn>]`: calculatedColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Format <String>]`: For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
    - `[Formula <String>]`: The formula used to compute the value for this column.
    - `[OutputType <String>]`: The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
  - `[Choice <IMicrosoftGraphChoiceColumn>]`: choiceColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowTextEntry <Boolean?>]`: If true, allows custom values that aren't in the configured choices.
    - `[Choices <String[]>]`: The list of values available for this column.
    - `[DisplayAs <String>]`: How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons
  - `[ColumnGroup <String>]`: For site columns, the name of the group this column belongs to. Helps organize related columns.
  - `[ContentApprovalStatus <IMicrosoftGraphContentApprovalStatusColumn>]`: contentApprovalStatusColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Currency <IMicrosoftGraphCurrencyColumn>]`: currencyColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Locale <String>]`: Specifies the locale from which to infer the currency symbol.
  - `[DateTime <IMicrosoftGraphDateTimeColumn>]`: dateTimeColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.
    - `[Format <String>]`: Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime
  - `[DefaultValue <IMicrosoftGraphDefaultColumnValue>]`: defaultColumnValue
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Formula <String>]`: The formula used to compute the default value for this column.
    - `[Value <String>]`: The direct value to use as the default value for this column.
  - `[Description <String>]`: The user-facing description of the column.
  - `[DisplayName <String>]`: The user-facing name of the column.
  - `[EnforceUniqueValues <Boolean?>]`: If true, no two list items may have the same value for this column.
  - `[Geolocation <IMicrosoftGraphGeolocationColumn>]`: geolocationColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Hidden <Boolean?>]`: Specifies whether the column is displayed in the user interface.
  - `[HyperlinkOrPicture <IMicrosoftGraphHyperlinkOrPictureColumn>]`: hyperlinkOrPictureColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsPicture <Boolean?>]`: Specifies whether the display format used for URL columns is an image or a hyperlink.
  - `[Indexed <Boolean?>]`: Specifies whether the column values can used for sorting and searching.
  - `[IsDeletable <Boolean?>]`: Indicates whether this column can be deleted.
  - `[IsReorderable <Boolean?>]`: Indicates whether values in the column can be reordered. Read-only.
  - `[IsSealed <Boolean?>]`: Specifies whether column can be changed.
  - `[Lookup <IMicrosoftGraphLookupColumn>]`: lookupColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Indicates whether multiple values can be selected from the source.
    - `[AllowUnlimitedLength <Boolean?>]`: Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
    - `[ColumnName <String>]`: The name of the lookup source column.
    - `[ListId <String>]`: The unique identifier of the lookup source list.
    - `[PrimaryLookupColumnId <String>]`: If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.
  - `[Name <String>]`: The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.
  - `[Number <IMicrosoftGraphNumberColumn>]`: numberColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DecimalPlaces <String>]`: How many decimal places to display. See below for information about the possible values.
    - `[DisplayAs <String>]`: How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.
    - `[Maximum <Double?>]`: The maximum permitted value.
    - `[Minimum <Double?>]`: The minimum permitted value.
  - `[PersonOrGroup <IMicrosoftGraphPersonOrGroupColumn>]`: personOrGroupColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleSelection <Boolean?>]`: Indicates whether multiple values can be selected from the source.
    - `[ChooseFromType <String>]`: Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.
    - `[DisplayAs <String>]`: How to display the information about the person or group chosen. See below.
  - `[PropagateChanges <Boolean?>]`: If 'True' changes to this column will be propagated to lists that implement the column.
  - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
  - `[Required <Boolean?>]`: Specifies whether the column value is not optional.
  - `[SourceColumn <IMicrosoftGraphColumnDefinition>]`: columnDefinition
  - `[Term <IMicrosoftGraphTermColumn>]`: termColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
    - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
  - `[Text <IMicrosoftGraphTextColumn>]`: textColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleLines <Boolean?>]`: Whether to allow multiple lines of text.
    - `[AppendChangesToExistingText <Boolean?>]`: Whether updates to this column should replace existing text, or append to it.
    - `[LinesForEditing <Int32?>]`: The size of the text box.
    - `[MaxLength <Int32?>]`: The maximum number of characters for the value.
    - `[TextType <String>]`: The type of text being stored. Must be one of plain or richText
  - `[Thumbnail <IMicrosoftGraphThumbnailColumn>]`: thumbnailColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: columnTypes
  - `[Validation <IMicrosoftGraphColumnValidation>]`: columnValidation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultLanguage <String>]`: Default BCP 47 language tag for the description.
    - `[Descriptions <IMicrosoftGraphDisplayNameLocalization[]>]`: Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with this message if validation fails.
      - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
      - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
    - `[Formula <String>]`: The formula to validate column value. For examples, see Examples of common formulas in lists

TERM <IMicrosoftGraphTermColumn>: termColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
  - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.

TEXT <IMicrosoftGraphTextColumn>: textColumn
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowMultipleLines <Boolean?>]`: Whether to allow multiple lines of text.
  - `[AppendChangesToExistingText <Boolean?>]`: Whether updates to this column should replace existing text, or append to it.
  - `[LinesForEditing <Int32?>]`: The size of the text box.
  - `[MaxLength <Int32?>]`: The maximum number of characters for the value.
  - `[TextType <String>]`: The type of text being stored. Must be one of plain or richText

VALIDATION <IMicrosoftGraphColumnValidation>: columnValidation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DefaultLanguage <String>]`: Default BCP 47 language tag for the description.
  - `[Descriptions <IMicrosoftGraphDisplayNameLocalization[]>]`: Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with this message if validation fails.
    - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
    - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
  - `[Formula <String>]`: The formula to validate column value. For examples, see Examples of common formulas in lists

## RELATED LINKS

## RELATED LINKS
