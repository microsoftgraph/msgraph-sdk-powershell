---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabel
schema: 2.0.0
---

# New-MgInformationProtectionSensitivityLabel

## SYNOPSIS
Create new navigation property to sensitivityLabels for informationProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgInformationProtectionSensitivityLabel [-AdditionalProperties <Hashtable>] [-ApplicableTo <String>]
 [-ApplicationMode <String>] [-AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]
 [-AutoLabeling <IMicrosoftGraphAutoLabeling>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-IsDefault] [-IsEndpointProtectionEnabled] [-LabelActions <IMicrosoftGraphLabelActionBase[]>]
 [-Name <String>] [-Priority <Int32>] [-Sublabels <IMicrosoftGraphSensitivityLabel[]>] [-ToolTip <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgInformationProtectionSensitivityLabel -BodyParameter <IMicrosoftGraphSensitivityLabel> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sensitivityLabels for informationProtection

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicableTo
sensitivityLabelTarget

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationMode
applicationMode

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedPolicies
.
To construct, see NOTES section for ASSIGNEDPOLICIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphLabelPolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoLabeling
autoLabeling
To construct, see NOTES section for AUTOLABELING properties and create a hash table.

```yaml
Type: IMicrosoftGraphAutoLabeling
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sensitivityLabel
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphSensitivityLabel
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDefault
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEndpointProtectionEnabled
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelActions
.
To construct, see NOTES section for LABELACTIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphLabelActionBase[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sublabels
.
To construct, see NOTES section for SUBLABELS properties and create a hash table.

```yaml
Type: IMicrosoftGraphSensitivityLabel[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToolTip
.

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSensitivityLabel
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSensitivityLabel
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNEDPOLICIES \<IMicrosoftGraphLabelPolicy\[\]\>: .
  \[Id \<String\>\]: 
  \[Name \<String\>\]: 

AUTOLABELING \<IMicrosoftGraphAutoLabeling\>: autoLabeling
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Message \<String\>\]: 
  \[SensitiveTypeIds \<String\[\]\>\]: 

BODYPARAMETER \<IMicrosoftGraphSensitivityLabel\>: sensitivityLabel
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ApplicableTo \<String\>\]: sensitivityLabelTarget
  \[ApplicationMode \<String\>\]: applicationMode
  \[AssignedPolicies \<IMicrosoftGraphLabelPolicy\[\]\>\]: 
    \[Id \<String\>\]: 
    \[Name \<String\>\]: 
  \[AutoLabeling \<IMicrosoftGraphAutoLabeling\>\]: autoLabeling
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Message \<String\>\]: 
    \[SensitiveTypeIds \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsEndpointProtectionEnabled \<Boolean?\>\]: 
  \[LabelActions \<IMicrosoftGraphLabelActionBase\[\]\>\]: 
    \[Name \<String\>\]: 
  \[Name \<String\>\]: 
  \[Priority \<Int32?\>\]: 
  \[Sublabels \<IMicrosoftGraphSensitivityLabel\[\]\>\]: 
  \[ToolTip \<String\>\]: 

LABELACTIONS \<IMicrosoftGraphLabelActionBase\[\]\>: .
  \[Name \<String\>\]: 

SUBLABELS \<IMicrosoftGraphSensitivityLabel\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[ApplicableTo \<String\>\]: sensitivityLabelTarget
  \[ApplicationMode \<String\>\]: applicationMode
  \[AssignedPolicies \<IMicrosoftGraphLabelPolicy\[\]\>\]: 
    \[Id \<String\>\]: 
    \[Name \<String\>\]: 
  \[AutoLabeling \<IMicrosoftGraphAutoLabeling\>\]: autoLabeling
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Message \<String\>\]: 
    \[SensitiveTypeIds \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsEndpointProtectionEnabled \<Boolean?\>\]: 
  \[LabelActions \<IMicrosoftGraphLabelActionBase\[\]\>\]: 
    \[Name \<String\>\]: 
  \[Name \<String\>\]: 
  \[Priority \<Int32?\>\]: 
  \[Sublabels \<IMicrosoftGraphSensitivityLabel\[\]\>\]: 
  \[ToolTip \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabel](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabel)

