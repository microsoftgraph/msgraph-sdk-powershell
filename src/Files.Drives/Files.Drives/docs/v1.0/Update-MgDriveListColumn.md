---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/update-mgdrivelistcolumn
schema: 2.0.0
---

# Update-MgDriveListColumn

## SYNOPSIS
Update the navigation property columns in drive

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDriveListColumn -ColumnDefinitionId <String> [-Boolean <IMicrosoftGraphBooleanColumn>]
 [-CalculatedFormat <String>] [-CalculatedFormula <String>] [-CalculatedOutputType <String>]
 [-ChoiceAllowTextEntry] [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>]
 [-CurrencyLocale <String>] [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>]
 [-DefaultValueFormula <String>] [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>]
 [-EnforceUniqueValues] [-Hidden] [-Id <String>] [-Indexed] [-LookupAllowMultipleValues]
 [-LookupAllowUnlimitedLength] [-LookupColumnName <String>] [-LookupListId <String>]
 [-LookupPrimaryLookupColumnId <String>] [-Name <String>] [-NumberDecimalPlaces <String>]
 [-NumberDisplayAs <String>] [-NumberMaximum <Double>] [-NumberMinimum <Double>]
 [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDriveListColumn -ColumnDefinitionId <String> -BodyParameter <IMicrosoftGraphColumnDefinition>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update2
```
Update-MgDriveListColumn -ColumnDefinitionId <String> -DriveId <String>
 -BodyParameter <IMicrosoftGraphColumnDefinition> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded2
```
Update-MgDriveListColumn -ColumnDefinitionId <String> -DriveId <String>
 [-Boolean <IMicrosoftGraphBooleanColumn>] [-CalculatedFormat <String>] [-CalculatedFormula <String>]
 [-CalculatedOutputType <String>] [-ChoiceAllowTextEntry] [-ChoiceChoices <String[]>]
 [-ChoiceDisplayAs <String>] [-ColumnGroup <String>] [-CurrencyLocale <String>] [-DateTimeDisplayAs <String>]
 [-DateTimeFormat <String>] [-DefaultValueFormula <String>] [-DefaultValueValue <String>]
 [-Description <String>] [-DisplayName <String>] [-EnforceUniqueValues] [-Hidden] [-Id <String>] [-Indexed]
 [-LookupAllowMultipleValues] [-LookupAllowUnlimitedLength] [-LookupColumnName <String>]
 [-LookupListId <String>] [-LookupPrimaryLookupColumnId <String>] [-Name <String>]
 [-NumberDecimalPlaces <String>] [-NumberDisplayAs <String>] [-NumberMaximum <Double>]
 [-NumberMinimum <Double>] [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDriveListColumn -InputObject <IFilesDrivesIdentity> -BodyParameter <IMicrosoftGraphColumnDefinition>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgDriveListColumn -InputObject <IFilesDrivesIdentity> -BodyParameter <IMicrosoftGraphColumnDefinition>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDriveListColumn -InputObject <IFilesDrivesIdentity> [-Boolean <IMicrosoftGraphBooleanColumn>]
 [-CalculatedFormat <String>] [-CalculatedFormula <String>] [-CalculatedOutputType <String>]
 [-ChoiceAllowTextEntry] [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>]
 [-CurrencyLocale <String>] [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>]
 [-DefaultValueFormula <String>] [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>]
 [-EnforceUniqueValues] [-Hidden] [-Id <String>] [-Indexed] [-LookupAllowMultipleValues]
 [-LookupAllowUnlimitedLength] [-LookupColumnName <String>] [-LookupListId <String>]
 [-LookupPrimaryLookupColumnId <String>] [-Name <String>] [-NumberDecimalPlaces <String>]
 [-NumberDisplayAs <String>] [-NumberMaximum <Double>] [-NumberMinimum <Double>]
 [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgDriveListColumn -InputObject <IFilesDrivesIdentity> [-Boolean <IMicrosoftGraphBooleanColumn>]
 [-CalculatedFormat <String>] [-CalculatedFormula <String>] [-CalculatedOutputType <String>]
 [-ChoiceAllowTextEntry] [-ChoiceChoices <String[]>] [-ChoiceDisplayAs <String>] [-ColumnGroup <String>]
 [-CurrencyLocale <String>] [-DateTimeDisplayAs <String>] [-DateTimeFormat <String>]
 [-DefaultValueFormula <String>] [-DefaultValueValue <String>] [-Description <String>] [-DisplayName <String>]
 [-EnforceUniqueValues] [-Hidden] [-Id <String>] [-Indexed] [-LookupAllowMultipleValues]
 [-LookupAllowUnlimitedLength] [-LookupColumnName <String>] [-LookupListId <String>]
 [-LookupPrimaryLookupColumnId <String>] [-Name <String>] [-NumberDecimalPlaces <String>]
 [-NumberDisplayAs <String>] [-NumberMaximum <Double>] [-NumberMinimum <Double>]
 [-PersonOrGroupAllowMultipleSelection] [-PersonOrGroupChooseFromType <String>]
 [-PersonOrGroupDisplayAs <String>] [-ReadOnly] [-Required] [-TextAllowMultipleLines]
 [-TextAppendChangesToExistingText] [-TextLinesForEditing <Int32>] [-TextMaxLength <Int32>]
 [-TextType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property columns in drive

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
Parameter Sets: Update1, Update2, UpdateViaIdentity1, UpdateViaIdentity2
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBooleanColumn
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalculatedFormat
For dateTime output types, the format of the value.
Must be one of dateOnly or dateTime.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalculatedFormula
The formula used to compute the value for this column.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalculatedOutputType
The output type used to format values in this column.
Must be one of boolean, currency, dateTime, number, or text.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChoiceAllowTextEntry
If true, allows custom values that aren't in the configured choices.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChoiceChoices
The list of values available for this column.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChoiceDisplayAs
How the choices are to be presented in the UX.
Must be one of checkBoxes, dropDownMenu, or radioButtons

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnDefinitionId
key: columnDefinition-id of columnDefinition

```yaml
Type: System.String
Parameter Sets: Update1, Update2, UpdateExpanded1, UpdateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColumnGroup
For site columns, the name of the group this column belongs to.
Helps organize related columns.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyLocale
Specifies the locale from which to infer the currency symbol.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DateTimeDisplayAs
How the value should be presented in the UX.
Must be one of default, friendly, or standard.
See below for more details.
If unspecified, treated as default.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DateTimeFormat
Indicates whether the value should be presented as a date only or a date and time.
Must be one of dateOnly or dateTime

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultValueFormula
The formula used to compute the default value for this column.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultValueValue
The direct value to use as the default value for this column.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Update2, UpdateExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentity2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LookupAllowMultipleValues
Indicates whether multiple values can be selected from the source.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LookupAllowUnlimitedLength
Indicates whether values in the column should be able to exceed the standard limit of 255 characters.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LookupColumnName
The name of the lookup source column.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LookupListId
The unique identifier of the lookup source list.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LookupPrimaryLookupColumnId
If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup.
Use the list item looked up by the primary as the source for the column named here.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberDecimalPlaces
How many decimal places to display.
See below for information about the possible values.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberDisplayAs
How the value should be presented in the UX.
Must be one of number or percentage.
If unspecified, treated as number.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberMaximum
The maximum permitted value.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumberMinimum
The minimum permitted value.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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

### -PersonOrGroupAllowMultipleSelection
Indicates whether multiple values can be selected from the source.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonOrGroupChooseFromType
Whether to allow selection of people only, or people and groups.
Must be one of peopleAndGroups or peopleOnly.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonOrGroupDisplayAs
How to display the information about the person or group chosen.
See below.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextAllowMultipleLines
Whether to allow multiple lines of text.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextAppendChangesToExistingText
Whether updates to this column should replace existing text, or append to it.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextLinesForEditing
The size of the text box.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextMaxLength
The maximum number of characters for the value.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TextType
The type of text being stored.
Must be one of plain or richText

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnDefinition

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphColumnDefinition>: columnDefinition
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

INPUTOBJECT <IFilesDrivesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveId <String>]`: key: drive-id of drive
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[EndDateTime <String>]`: 
  - `[Interval <String>]`: 
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[Q <String>]`: 
  - `[StartDateTime <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS

