---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/update-mgsitecontenttype
schema: 2.0.0
---

# Update-MgSiteContentType

## SYNOPSIS
Update the navigation property contentTypes in sites

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgSiteContentType -ContentTypeId <String> -SiteId <String> [-AdditionalProperties <Hashtable>]
 [-AssociatedHubsUrls <String[]>] [-Base <IMicrosoftGraphContentType>]
 [-BaseTypes <IMicrosoftGraphContentType[]>] [-ColumnLinks <IMicrosoftGraphColumnLink[]>]
 [-ColumnPositions <IMicrosoftGraphColumnDefinition1[]>] [-Columns <IMicrosoftGraphColumnDefinition1[]>]
 [-Description <String>] [-DocumentSet <IMicrosoftGraphDocumentSet1>]
 [-DocumentTemplate <IMicrosoftGraphDocumentSetContent>] [-Group <String>] [-Hidden] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-IsBuiltIn] [-Name <String>]
 [-Order <IMicrosoftGraphContentTypeOrder>] [-ParentId <String>] [-PropagateChanges] [-ReadOnly] [-Sealed]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSiteContentType -ContentTypeId <String> -SiteId <String> -BodyParameter <IMicrosoftGraphContentType>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgSiteContentType -InputObject <ISitesIdentity> -BodyParameter <IMicrosoftGraphContentType> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgSiteContentType -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-AssociatedHubsUrls <String[]>] [-Base <IMicrosoftGraphContentType>]
 [-BaseTypes <IMicrosoftGraphContentType[]>] [-ColumnLinks <IMicrosoftGraphColumnLink[]>]
 [-ColumnPositions <IMicrosoftGraphColumnDefinition1[]>] [-Columns <IMicrosoftGraphColumnDefinition1[]>]
 [-Description <String>] [-DocumentSet <IMicrosoftGraphDocumentSet1>]
 [-DocumentTemplate <IMicrosoftGraphDocumentSetContent>] [-Group <String>] [-Hidden] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-IsBuiltIn] [-Name <String>]
 [-Order <IMicrosoftGraphContentTypeOrder>] [-ParentId <String>] [-PropagateChanges] [-ReadOnly] [-Sealed]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property contentTypes in sites

## EXAMPLES

## PARAMETERS

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

### -AssociatedHubsUrls
List of canonical URLs for hub sites with which this content type is associated to.
This will contain all hubsites where this content type is queued to be enforced or is already enforced.
Enforcing a content type means that the content type will be applied to the lists in the enforced sites.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Base
contentType
To construct, please use Get-Help -Online and see NOTES section for BASE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BaseTypes
The collection of content types that are ancestors of this content type.
To construct, please use Get-Help -Online and see NOTES section for BASETYPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
contentType
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ColumnLinks
The collection of columns that are required by this content type
To construct, please use Get-Help -Online and see NOTES section for COLUMNLINKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnLink[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnPositions
Column order information in a content type.
To construct, please use Get-Help -Online and see NOTES section for COLUMNPOSITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Columns
The collection of column definitions for this contentType.
To construct, please use Get-Help -Online and see NOTES section for COLUMNS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition1[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentTypeId
key: id of contentType

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

### -Description
The descriptive text for the item.

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

### -DocumentSet
documentSet
To construct, please use Get-Help -Online and see NOTES section for DOCUMENTSET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDocumentSet1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DocumentTemplate
documentSetContent
To construct, please use Get-Help -Online and see NOTES section for DOCUMENTTEMPLATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDocumentSetContent
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group
The name of the group this content type belongs to.
Helps organize related content types.

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

### -Hidden
Indicates whether the content type is hidden in the list's 'New' menu.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -InheritedFrom
itemReference
To construct, please use Get-Help -Online and see NOTES section for INHERITEDFROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemReference
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
Type: Microsoft.Graph.PowerShell.Models.ISitesIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsBuiltIn
Specifies if a content type is a built-in content type.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the content type.

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

### -Order
contentTypeOrder
To construct, please use Get-Help -Online and see NOTES section for ORDER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentTypeOrder
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentId
The unique identifier of the content type.

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

### -PropagateChanges
If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReadOnly
If true, the content type cannot be modified unless this value is first set to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sealed
If true, the content type cannot be modified by users or through push-down operations.
Only site collection administrators can seal or unseal content types.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
key: id of site

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BASE <IMicrosoftGraphContentType>: contentType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssociatedHubsUrls <String[]>]`: List of canonical URLs for hub sites with which this content type is associated to. This will contain all hubsites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.
  - `[Base <IMicrosoftGraphContentType>]`: contentType
  - `[BaseTypes <IMicrosoftGraphContentType[]>]`: The collection of content types that are ancestors of this content type.
  - `[ColumnLinks <IMicrosoftGraphColumnLink[]>]`: The collection of columns that are required by this content type
    - `[Id <String>]`: 
    - `[Name <String>]`: The name of the column  in this content type.
  - `[ColumnPositions <IMicrosoftGraphColumnDefinition1[]>]`: Column order information in a content type.
    - `[Id <String>]`: 
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
    - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
    - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
    - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
    - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
    - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
    - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The id of the content type.
      - `[Name <String>]`: The name of the content type.
    - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
      - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
        - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
        - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
          - `[Description <String>]`: The description in the localized language.
          - `[LanguageTag <String>]`: The language tag for the label.
        - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
          - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
          - `[LanguageTag <String>]`: The language tag for the label.
          - `[Name <String>]`: The name of the label.
        - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
        - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
          - `[Id <String>]`: 
          - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
          - `[Relationship <String>]`: 
          - `[Set <IMicrosoftGraphTermStoreSet>]`: set
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
            - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
            - `[Description <String>]`: Description giving details on the term usage.
            - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
              - `[LanguageTag <String>]`: The language tag for the label.
              - `[Name <String>]`: The name in the localized language.
            - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: 
              - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
              - `[Description <String>]`: Description that gives details on the term usage.
              - `[DisplayName <String>]`: Name of the group.
              - `[ParentSiteId <String>]`: ID of the parent site of this group.
              - `[Scope <String>]`: 
              - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
            - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
            - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
            - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
          - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
      - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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
  - `[Columns <IMicrosoftGraphColumnDefinition1[]>]`: The collection of column definitions for this contentType.
  - `[Description <String>]`: The descriptive text for the item.
  - `[DocumentSet <IMicrosoftGraphDocumentSet1>]`: documentSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedContentTypes <IMicrosoftGraphContentTypeInfo[]>]`: Content types allowed in document set.
    - `[DefaultContents <IMicrosoftGraphDocumentSetContent[]>]`: Default contents of document set.
      - `[ContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[FileName <String>]`: Name of the file in resource folder that should be added as a default content or a template in the document set
      - `[FolderName <String>]`: Folder name in which the file will be placed when a new document set is created in the library.
    - `[PropagateWelcomePageChanges <Boolean?>]`: Indicates whether to add the name of the document set to each file name.
    - `[SharedColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[ShouldPrefixNameToFile <Boolean?>]`: Add the name of the Document Set to each file name.
    - `[WelcomePageColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[WelcomePageUrl <String>]`: Welcome page absolute URL.
  - `[DocumentTemplate <IMicrosoftGraphDocumentSetContent>]`: documentSetContent
  - `[Group <String>]`: The name of the group this content type belongs to. Helps organize related content types.
  - `[Hidden <Boolean?>]`: Indicates whether the content type is hidden in the list's 'New' menu.
  - `[InheritedFrom <IMicrosoftGraphItemReference>]`: itemReference
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
    - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
    - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
    - `[Name <String>]`: The name of the item being referenced. Read-only.
    - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
    - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
    - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
      - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
      - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
      - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
      - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
      - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
      - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
    - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
  - `[IsBuiltIn <Boolean?>]`: Specifies if a content type is a built-in content type.
  - `[Name <String>]`: The name of the content type.
  - `[Order <IMicrosoftGraphContentTypeOrder>]`: contentTypeOrder
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Default <Boolean?>]`: Whether this is the default Content Type
    - `[Position <Int32?>]`: Specifies the position in which the Content Type appears in the selection UI.
  - `[ParentId <String>]`: The unique identifier of the content type.
  - `[PropagateChanges <Boolean?>]`: If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.
  - `[ReadOnly <Boolean?>]`: If true, the content type cannot be modified unless this value is first set to false.
  - `[Sealed <Boolean?>]`: If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.

BASETYPES <IMicrosoftGraphContentType[]>: The collection of content types that are ancestors of this content type.
  - `[Id <String>]`: 
  - `[AssociatedHubsUrls <String[]>]`: List of canonical URLs for hub sites with which this content type is associated to. This will contain all hubsites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.
  - `[Base <IMicrosoftGraphContentType>]`: contentType
  - `[BaseTypes <IMicrosoftGraphContentType[]>]`: The collection of content types that are ancestors of this content type.
  - `[ColumnLinks <IMicrosoftGraphColumnLink[]>]`: The collection of columns that are required by this content type
    - `[Id <String>]`: 
    - `[Name <String>]`: The name of the column  in this content type.
  - `[ColumnPositions <IMicrosoftGraphColumnDefinition1[]>]`: Column order information in a content type.
    - `[Id <String>]`: 
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
    - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
    - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
    - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
    - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
    - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
    - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The id of the content type.
      - `[Name <String>]`: The name of the content type.
    - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
      - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
        - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
        - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
          - `[Description <String>]`: The description in the localized language.
          - `[LanguageTag <String>]`: The language tag for the label.
        - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
          - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
          - `[LanguageTag <String>]`: The language tag for the label.
          - `[Name <String>]`: The name of the label.
        - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
        - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
          - `[Id <String>]`: 
          - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
          - `[Relationship <String>]`: 
          - `[Set <IMicrosoftGraphTermStoreSet>]`: set
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
            - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
            - `[Description <String>]`: Description giving details on the term usage.
            - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
              - `[LanguageTag <String>]`: The language tag for the label.
              - `[Name <String>]`: The name in the localized language.
            - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: 
              - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
              - `[Description <String>]`: Description that gives details on the term usage.
              - `[DisplayName <String>]`: Name of the group.
              - `[ParentSiteId <String>]`: ID of the parent site of this group.
              - `[Scope <String>]`: 
              - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
            - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
            - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
            - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
          - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
      - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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
  - `[Columns <IMicrosoftGraphColumnDefinition1[]>]`: The collection of column definitions for this contentType.
  - `[Description <String>]`: The descriptive text for the item.
  - `[DocumentSet <IMicrosoftGraphDocumentSet1>]`: documentSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedContentTypes <IMicrosoftGraphContentTypeInfo[]>]`: Content types allowed in document set.
    - `[DefaultContents <IMicrosoftGraphDocumentSetContent[]>]`: Default contents of document set.
      - `[ContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[FileName <String>]`: Name of the file in resource folder that should be added as a default content or a template in the document set
      - `[FolderName <String>]`: Folder name in which the file will be placed when a new document set is created in the library.
    - `[PropagateWelcomePageChanges <Boolean?>]`: Indicates whether to add the name of the document set to each file name.
    - `[SharedColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[ShouldPrefixNameToFile <Boolean?>]`: Add the name of the Document Set to each file name.
    - `[WelcomePageColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[WelcomePageUrl <String>]`: Welcome page absolute URL.
  - `[DocumentTemplate <IMicrosoftGraphDocumentSetContent>]`: documentSetContent
  - `[Group <String>]`: The name of the group this content type belongs to. Helps organize related content types.
  - `[Hidden <Boolean?>]`: Indicates whether the content type is hidden in the list's 'New' menu.
  - `[InheritedFrom <IMicrosoftGraphItemReference>]`: itemReference
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
    - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
    - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
    - `[Name <String>]`: The name of the item being referenced. Read-only.
    - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
    - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
    - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
      - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
      - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
      - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
      - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
      - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
      - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
    - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
  - `[IsBuiltIn <Boolean?>]`: Specifies if a content type is a built-in content type.
  - `[Name <String>]`: The name of the content type.
  - `[Order <IMicrosoftGraphContentTypeOrder>]`: contentTypeOrder
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Default <Boolean?>]`: Whether this is the default Content Type
    - `[Position <Int32?>]`: Specifies the position in which the Content Type appears in the selection UI.
  - `[ParentId <String>]`: The unique identifier of the content type.
  - `[PropagateChanges <Boolean?>]`: If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.
  - `[ReadOnly <Boolean?>]`: If true, the content type cannot be modified unless this value is first set to false.
  - `[Sealed <Boolean?>]`: If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.

BODYPARAMETER <IMicrosoftGraphContentType>: contentType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssociatedHubsUrls <String[]>]`: List of canonical URLs for hub sites with which this content type is associated to. This will contain all hubsites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.
  - `[Base <IMicrosoftGraphContentType>]`: contentType
  - `[BaseTypes <IMicrosoftGraphContentType[]>]`: The collection of content types that are ancestors of this content type.
  - `[ColumnLinks <IMicrosoftGraphColumnLink[]>]`: The collection of columns that are required by this content type
    - `[Id <String>]`: 
    - `[Name <String>]`: The name of the column  in this content type.
  - `[ColumnPositions <IMicrosoftGraphColumnDefinition1[]>]`: Column order information in a content type.
    - `[Id <String>]`: 
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
    - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
    - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
    - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
    - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
    - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
    - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The id of the content type.
      - `[Name <String>]`: The name of the content type.
    - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
      - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
        - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
        - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
          - `[Description <String>]`: The description in the localized language.
          - `[LanguageTag <String>]`: The language tag for the label.
        - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
          - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
          - `[LanguageTag <String>]`: The language tag for the label.
          - `[Name <String>]`: The name of the label.
        - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
        - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
          - `[Id <String>]`: 
          - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
          - `[Relationship <String>]`: 
          - `[Set <IMicrosoftGraphTermStoreSet>]`: set
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
            - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
            - `[Description <String>]`: Description giving details on the term usage.
            - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
              - `[LanguageTag <String>]`: The language tag for the label.
              - `[Name <String>]`: The name in the localized language.
            - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: 
              - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
              - `[Description <String>]`: Description that gives details on the term usage.
              - `[DisplayName <String>]`: Name of the group.
              - `[ParentSiteId <String>]`: ID of the parent site of this group.
              - `[Scope <String>]`: 
              - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
            - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
            - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
            - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
          - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
      - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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
  - `[Columns <IMicrosoftGraphColumnDefinition1[]>]`: The collection of column definitions for this contentType.
  - `[Description <String>]`: The descriptive text for the item.
  - `[DocumentSet <IMicrosoftGraphDocumentSet1>]`: documentSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedContentTypes <IMicrosoftGraphContentTypeInfo[]>]`: Content types allowed in document set.
    - `[DefaultContents <IMicrosoftGraphDocumentSetContent[]>]`: Default contents of document set.
      - `[ContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
      - `[FileName <String>]`: Name of the file in resource folder that should be added as a default content or a template in the document set
      - `[FolderName <String>]`: Folder name in which the file will be placed when a new document set is created in the library.
    - `[PropagateWelcomePageChanges <Boolean?>]`: Indicates whether to add the name of the document set to each file name.
    - `[SharedColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[ShouldPrefixNameToFile <Boolean?>]`: Add the name of the Document Set to each file name.
    - `[WelcomePageColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[WelcomePageUrl <String>]`: Welcome page absolute URL.
  - `[DocumentTemplate <IMicrosoftGraphDocumentSetContent>]`: documentSetContent
  - `[Group <String>]`: The name of the group this content type belongs to. Helps organize related content types.
  - `[Hidden <Boolean?>]`: Indicates whether the content type is hidden in the list's 'New' menu.
  - `[InheritedFrom <IMicrosoftGraphItemReference>]`: itemReference
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
    - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
    - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
    - `[Name <String>]`: The name of the item being referenced. Read-only.
    - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
    - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
    - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
      - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
      - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
      - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
      - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
      - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
      - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
    - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
  - `[IsBuiltIn <Boolean?>]`: Specifies if a content type is a built-in content type.
  - `[Name <String>]`: The name of the content type.
  - `[Order <IMicrosoftGraphContentTypeOrder>]`: contentTypeOrder
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Default <Boolean?>]`: Whether this is the default Content Type
    - `[Position <Int32?>]`: Specifies the position in which the Content Type appears in the selection UI.
  - `[ParentId <String>]`: The unique identifier of the content type.
  - `[PropagateChanges <Boolean?>]`: If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.
  - `[ReadOnly <Boolean?>]`: If true, the content type cannot be modified unless this value is first set to false.
  - `[Sealed <Boolean?>]`: If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.

COLUMNLINKS <IMicrosoftGraphColumnLink[]>: The collection of columns that are required by this content type
  - `[Id <String>]`: 
  - `[Name <String>]`: The name of the column  in this content type.

COLUMNPOSITIONS <IMicrosoftGraphColumnDefinition1[]>: Column order information in a content type.
  - `[Id <String>]`: 
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
  - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
  - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
  - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
  - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
  - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
  - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The id of the content type.
    - `[Name <String>]`: The name of the content type.
  - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
    - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
      - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
      - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
        - `[Description <String>]`: The description in the localized language.
        - `[LanguageTag <String>]`: The language tag for the label.
      - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
        - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name of the label.
      - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
        - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
        - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
        - `[Id <String>]`: 
        - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Relationship <String>]`: 
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
          - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
          - `[Description <String>]`: Description giving details on the term usage.
          - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
            - `[LanguageTag <String>]`: The language tag for the label.
            - `[Name <String>]`: The name in the localized language.
          - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
            - `[Description <String>]`: Description that gives details on the term usage.
            - `[DisplayName <String>]`: Name of the group.
            - `[ParentSiteId <String>]`: ID of the parent site of this group.
            - `[Scope <String>]`: 
            - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
          - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
          - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
          - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
        - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
    - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
    - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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

COLUMNS <IMicrosoftGraphColumnDefinition1[]>: The collection of column definitions for this contentType.
  - `[Id <String>]`: 
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
  - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
  - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
  - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
  - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
  - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
  - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The id of the content type.
    - `[Name <String>]`: The name of the content type.
  - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
    - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
      - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
      - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
        - `[Description <String>]`: The description in the localized language.
        - `[LanguageTag <String>]`: The language tag for the label.
      - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
        - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
        - `[LanguageTag <String>]`: The language tag for the label.
        - `[Name <String>]`: The name of the label.
      - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
      - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
        - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
        - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
      - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
        - `[Id <String>]`: 
        - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Relationship <String>]`: 
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
          - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
          - `[Description <String>]`: Description giving details on the term usage.
          - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
            - `[LanguageTag <String>]`: The language tag for the label.
            - `[Name <String>]`: The name in the localized language.
          - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
            - `[Description <String>]`: Description that gives details on the term usage.
            - `[DisplayName <String>]`: Name of the group.
            - `[ParentSiteId <String>]`: ID of the parent site of this group.
            - `[Scope <String>]`: 
            - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
          - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
          - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
          - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
        - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
      - `[Set <IMicrosoftGraphTermStoreSet>]`: set
    - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
    - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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

DOCUMENTSET <IMicrosoftGraphDocumentSet1>: documentSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedContentTypes <IMicrosoftGraphContentTypeInfo[]>]`: Content types allowed in document set.
    - `[Id <String>]`: The id of the content type.
    - `[Name <String>]`: The name of the content type.
  - `[DefaultContents <IMicrosoftGraphDocumentSetContent[]>]`: Default contents of document set.
    - `[ContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
    - `[FileName <String>]`: Name of the file in resource folder that should be added as a default content or a template in the document set
    - `[FolderName <String>]`: Folder name in which the file will be placed when a new document set is created in the library.
  - `[PropagateWelcomePageChanges <Boolean?>]`: Indicates whether to add the name of the document set to each file name.
  - `[SharedColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
    - `[Id <String>]`: 
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
    - `[IsSealed <Boolean?>]`: Specifies whether the column can be changed.
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
    - `[PropagateChanges <Boolean?>]`: If true, changes to this column will be propagated to lists that implement the column.
    - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
    - `[Required <Boolean?>]`: Specifies whether the column value isn't optional.
    - `[SourceColumn <IMicrosoftGraphColumnDefinition1>]`: columnDefinition
    - `[SourceContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
    - `[Term <IMicrosoftGraphTermColumn1>]`: termColumn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowMultipleValues <Boolean?>]`: Specifies whether the column will allow more than one value
      - `[ParentTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children of current term.
        - `[CreatedDateTime <DateTime?>]`: Date and time of term creation. Read-only.
        - `[Descriptions <IMicrosoftGraphTermStoreLocalizedDescription[]>]`: Description about term that is dependent on the languageTag.
          - `[Description <String>]`: The description in the localized language.
          - `[LanguageTag <String>]`: The language tag for the label.
        - `[Labels <IMicrosoftGraphTermStoreLocalizedLabel[]>]`: Label metadata for a term.
          - `[IsDefault <Boolean?>]`: Indicates whether the label is the default label.
          - `[LanguageTag <String>]`: The language tag for the label.
          - `[Name <String>]`: The name of the label.
        - `[LastModifiedDateTime <DateTime?>]`: Last date and time of term modification. Read-only.
        - `[Properties <IMicrosoftGraphKeyValue[]>]`: Collection of properties on the term.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: To indicate which terms are related to the current term as either pinned or reused.
          - `[Id <String>]`: 
          - `[FromTerm <IMicrosoftGraphTermStoreTerm>]`: term
          - `[Relationship <String>]`: 
          - `[Set <IMicrosoftGraphTermStoreSet>]`: set
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
            - `[Children <IMicrosoftGraphTermStoreTerm[]>]`: Children terms of set in term [store].
            - `[CreatedDateTime <DateTime?>]`: Date and time of set creation. Read-only.
            - `[Description <String>]`: Description giving details on the term usage.
            - `[LocalizedNames <IMicrosoftGraphTermStoreLocalizedName[]>]`: Name of the set for each languageTag.
              - `[LanguageTag <String>]`: The language tag for the label.
              - `[Name <String>]`: The name in the localized language.
            - `[ParentGroup <IMicrosoftGraphTermStoreGroup1>]`: group
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: 
              - `[CreatedDateTime <DateTime?>]`: Date and time of the group creation. Read-only.
              - `[Description <String>]`: Description that gives details on the term usage.
              - `[DisplayName <String>]`: Name of the group.
              - `[ParentSiteId <String>]`: ID of the parent site of this group.
              - `[Scope <String>]`: 
              - `[Sets <IMicrosoftGraphTermStoreSet[]>]`: All sets under the group in a term [store].
            - `[Properties <IMicrosoftGraphKeyValue[]>]`: Custom properties for the set.
            - `[Relations <IMicrosoftGraphTermStoreRelation1[]>]`: Indicates which terms have been pinned or reused directly under the set.
            - `[Terms <IMicrosoftGraphTermStoreTerm[]>]`: All the terms under the set.
          - `[ToTerm <IMicrosoftGraphTermStoreTerm>]`: term
        - `[Set <IMicrosoftGraphTermStoreSet>]`: set
      - `[ShowFullyQualifiedName <Boolean?>]`: Specifies whether to display the entire term path or only the term label.
      - `[TermSet <IMicrosoftGraphTermStoreSet>]`: set
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
  - `[ShouldPrefixNameToFile <Boolean?>]`: Add the name of the Document Set to each file name.
  - `[WelcomePageColumns <IMicrosoftGraphColumnDefinition1[]>]`: 
  - `[WelcomePageUrl <String>]`: Welcome page absolute URL.

DOCUMENTTEMPLATE <IMicrosoftGraphDocumentSetContent>: documentSetContent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentType <IMicrosoftGraphContentTypeInfo>]`: contentTypeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The id of the content type.
    - `[Name <String>]`: The name of the content type.
  - `[FileName <String>]`: Name of the file in resource folder that should be added as a default content or a template in the document set
  - `[FolderName <String>]`: Folder name in which the file will be placed when a new document set is created in the library.

INHERITEDFROM <IMicrosoftGraphItemReference>: itemReference
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
  - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
  - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
  - `[Name <String>]`: The name of the item being referenced. Read-only.
  - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
  - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
  - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
    - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
    - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
    - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
    - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
    - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
    - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
  - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.

INPUTOBJECT <ISitesIdentity>: Identity Parameter
  - `[BaseItemId <String>]`: key: id of baseItem
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ContentTypeId1 <String>]`: key: id of contentType
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: key: id of group
  - `[GroupId1 <String>]`: key: id of group
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: key: id of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: key: id of permission
  - `[RelationId <String>]`: key: id of relation
  - `[RichLongRunningOperationId <String>]`: key: id of richLongRunningOperation
  - `[SetId <String>]`: key: id of set
  - `[SetId1 <String>]`: key: id of set
  - `[SiteId <String>]`: key: id of site
  - `[SiteId1 <String>]`: key: id of site
  - `[SitePageId <String>]`: key: id of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[StoreId <String>]`: key: id of store
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[TermId <String>]`: key: id of term
  - `[TermId1 <String>]`: key: id of term
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: key: id of user

ORDER <IMicrosoftGraphContentTypeOrder>: contentTypeOrder
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Default <Boolean?>]`: Whether this is the default Content Type
  - `[Position <Int32?>]`: Specifies the position in which the Content Type appears in the selection UI.

## RELATED LINKS

