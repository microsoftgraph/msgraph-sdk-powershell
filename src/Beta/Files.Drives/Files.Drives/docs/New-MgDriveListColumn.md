---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/new-mgdrivelistcolumn
schema: 2.0.0
---

# New-MgDriveListColumn

## SYNOPSIS
Create new navigation property to columns for drives

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDriveListColumn [-Boolean <IMicrosoftGraphBooleanColumn>] [-CalculatedFormat <String>]
 [-CalculatedFormula <String>] [-CalculatedOutputType <String>] [-ChoiceAllowTextEntry]
 [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>] [-CurrencyLocale <String>]
 [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>] [-DefaultValueFormula <String>]
 [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>] [-EnforceUniqueValues]
 [-Geolocation <IMicrosoftGraphGeolocationColumn>] [-Hidden] [-Id <String>] [-Indexed]
 [-LookupAllowMultipleValues] [-LookupAllowUnlimitedLength] [-LookupColumnName <String>]
 [-LookupListId <String>] [-LookupPrimaryLookupColumnId <String>] [-Name <String>]
 [-NumberDecimalPlaces <String>] [-NumberDisplayAs <String>] [-NumberMaximum <Double>]
 [-NumberMinimum <Double>] [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDriveListColumn -DriveId <String> -BodyParameter <IMicrosoftGraphColumnDefinition> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgDriveListColumn -BodyParameter <IMicrosoftGraphColumnDefinition> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded
```
New-MgDriveListColumn -DriveId <String> [-Boolean <IMicrosoftGraphBooleanColumn>] [-CalculatedFormat <String>]
 [-CalculatedFormula <String>] [-CalculatedOutputType <String>] [-ChoiceAllowTextEntry]
 [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>] [-CurrencyLocale <String>]
 [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>] [-DefaultValueFormula <String>]
 [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>] [-EnforceUniqueValues]
 [-Geolocation <IMicrosoftGraphGeolocationColumn>] [-Hidden] [-Id <String>] [-Indexed]
 [-LookupAllowMultipleValues] [-LookupAllowUnlimitedLength] [-LookupColumnName <String>]
 [-LookupListId <String>] [-LookupPrimaryLookupColumnId <String>] [-Name <String>]
 [-NumberDecimalPlaces <String>] [-NumberDisplayAs <String>] [-NumberMaximum <Double>]
 [-NumberMinimum <Double>] [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDriveListColumn -InputObject <IFilesDrivesIdentity> -BodyParameter <IMicrosoftGraphColumnDefinition>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDriveListColumn -InputObject <IFilesDrivesIdentity> [-Boolean <IMicrosoftGraphBooleanColumn>]
 [-CalculatedFormat <String>] [-CalculatedFormula <String>] [-CalculatedOutputType <String>]
 [-ChoiceAllowTextEntry] [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>]
 [-CurrencyLocale <String>] [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>]
 [-DefaultValueFormula <String>] [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>]
 [-EnforceUniqueValues] [-Geolocation <IMicrosoftGraphGeolocationColumn>] [-Hidden] [-Id <String>] [-Indexed]
 [-LookupAllowMultipleValues] [-LookupAllowUnlimitedLength] [-LookupColumnName <String>]
 [-LookupListId <String>] [-LookupPrimaryLookupColumnId <String>] [-Name <String>]
 [-NumberDecimalPlaces <String>] [-NumberDisplayAs <String>] [-NumberMaximum <Double>]
 [-NumberMinimum <Double>] [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to columns for drives

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
columnDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition
Parameter Sets: Create, Create1, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Boolean
booleanColumn

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBooleanColumn
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CalculatedFormat
For dateTime output types, the format of the value.
Must be one of dateOnly or dateTime.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CalculatedFormula
The formula used to compute the value for this column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CalculatedOutputType
The output type used to format values in this column.
Must be one of boolean, currency, dateTime, number, or text.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChoiceAllowTextEntry
If true, allows custom values that aren't in the configured choices.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChoiceChoices
The list of values available for this column.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ChoiceDisplayAs
How the choices are to be presented in the UX.
Must be one of checkBoxes, dropDownMenu, or radioButtons

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ColumnGroup
For site columns, the name of the group this column belongs to.
Helps organize related columns.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyLocale
Specifies the locale from which to infer the currency symbol.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DateTimeDisplayAs
How the value should be presented in the UX.
Must be one of default, friendly, or standard.
See below for more details.
If unspecified, treated as default.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DateTimeFormat
Indicates whether the value should be presented as a date only or a date and time.
Must be one of dateOnly or dateTime

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefaultValueFormula
The formula used to compute the default value for this column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DefaultValueValue
The direct value to use as the default value for this column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Description
The user-facing description of the column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
The user-facing name of the column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EnforceUniqueValues
If true, no two list items may have the same value for this column.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Geolocation
geolocationColumn

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGeolocationColumn
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Hidden
Specifies whether the column is displayed in the user interface.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Indexed
Specifies whether the column values can used for sorting and searching.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LookupAllowMultipleValues
Indicates whether multiple values can be selected from the source.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LookupAllowUnlimitedLength
Indicates whether values in the column should be able to exceed the standard limit of 255 characters.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LookupColumnName
The name of the lookup source column.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LookupListId
The unique identifier of the lookup source list.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LookupPrimaryLookupColumnId
If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup.
Use the list item looked up by the primary as the source for the column named here.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The API-facing name of the column as it appears in the [fields][] on a [listItem][].
For the user-facing name, see displayName.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NumberDecimalPlaces
How many decimal places to display.
See below for information about the possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NumberDisplayAs
How the value should be presented in the UX.
Must be one of number or percentage.
If unspecified, treated as number.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NumberMaximum
The maximum permitted value.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NumberMinimum
The minimum permitted value.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PersonOrGroupAllowMultipleSelection
Indicates whether multiple values can be selected from the source.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PersonOrGroupChooseFromType
Whether to allow selection of people only, or people and groups.
Must be one of peopleAndGroups or peopleOnly.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PersonOrGroupDisplayAs
How to display the information about the person or group chosen.
See below.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ReadOnly
Specifies whether the column values can be modified.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Required
Specifies whether the column value is not optional.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TextAllowMultipleLines
Whether to allow multiple lines of text.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TextAppendChangesToExistingText
Whether updates to this column should replace existing text, or append to it.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TextLinesForEditing
The size of the text box.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TextMaxLength
The maximum number of characters for the value.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TextType
The type of text being stored.
Must be one of plain or richText

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphColumnDefinition>: columnDefinition
  - `[Id <String>]`: Read-only.
  - `[Boolean <IMicrosoftGraphBooleanColumn>]`: booleanColumn
  - `[CalculatedFormat <String>]`: For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
  - `[CalculatedFormula <String>]`: The formula used to compute the value for this column.
  - `[CalculatedOutputType <String>]`: The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
  - `[ChoiceAllowTextEntry <Boolean?>]`: If true, allows custom values that aren't in the configured choices.
  - `[ChoiceChoices <String[]>]`: The list of values available for this column.
  - `[ChoiceDisplayAs <String>]`: How the choices are to be presented in the UX. Must be one of checkBoxes, dropDownMenu, or radioButtons
  - `[ColumnGroup <String>]`: For site columns, the name of the group this column belongs to. Helps organize related columns.
  - `[CurrencyLocale <String>]`: Specifies the locale from which to infer the currency symbol.
  - `[DateTimeDisplayAs <String>]`: How the value should be presented in the UX. Must be one of default, friendly, or standard. See below for more details. If unspecified, treated as default.
  - `[DateTimeFormat <String>]`: Indicates whether the value should be presented as a date only or a date and time. Must be one of dateOnly or dateTime
  - `[DefaultValueFormula <String>]`: The formula used to compute the default value for this column.
  - `[DefaultValueValue <String>]`: The direct value to use as the default value for this column.
  - `[Description <String>]`: The user-facing description of the column.
  - `[DisplayName <String>]`: The user-facing name of the column.
  - `[EnforceUniqueValues <Boolean?>]`: If true, no two list items may have the same value for this column.
  - `[Geolocation <IMicrosoftGraphGeolocationColumn>]`: geolocationColumn
  - `[Hidden <Boolean?>]`: Specifies whether the column is displayed in the user interface.
  - `[Indexed <Boolean?>]`: Specifies whether the column values can used for sorting and searching.
  - `[LookupAllowMultipleValues <Boolean?>]`: Indicates whether multiple values can be selected from the source.
  - `[LookupAllowUnlimitedLength <Boolean?>]`: Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
  - `[LookupColumnName <String>]`: The name of the lookup source column.
  - `[LookupListId <String>]`: The unique identifier of the lookup source list.
  - `[LookupPrimaryLookupColumnId <String>]`: If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.
  - `[Name <String>]`: The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.
  - `[NumberDecimalPlaces <String>]`: How many decimal places to display. See below for information about the possible values.
  - `[NumberDisplayAs <String>]`: How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.
  - `[NumberMaximum <Double?>]`: The maximum permitted value.
  - `[NumberMinimum <Double?>]`: The minimum permitted value.
  - `[PersonOrGroupAllowMultipleSelection <Boolean?>]`: Indicates whether multiple values can be selected from the source.
  - `[PersonOrGroupChooseFromType <String>]`: Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.
  - `[PersonOrGroupDisplayAs <String>]`: How to display the information about the person or group chosen. See below.
  - `[ReadOnly <Boolean?>]`: Specifies whether the column values can be modified.
  - `[Required <Boolean?>]`: Specifies whether the column value is not optional.
  - `[TextAllowMultipleLines <Boolean?>]`: Whether to allow multiple lines of text.
  - `[TextAppendChangesToExistingText <Boolean?>]`: Whether updates to this column should replace existing text, or append to it.
  - `[TextLinesForEditing <Int32?>]`: The size of the text box.
  - `[TextMaxLength <Int32?>]`: The maximum number of characters for the value.
  - `[TextType <String>]`: The type of text being stored. Must be one of plain or richText

#### INPUTOBJECT <IFilesDrivesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveId <String>]`: key: drive-id of drive
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[Q <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS

