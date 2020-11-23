---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionpolicylabel
schema: 2.0.0
---

# New-MgInformationProtectionPolicyLabel

## SYNOPSIS
Create new navigation property to labels for informationProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgInformationProtectionPolicyLabel [-AdditionalProperties <Hashtable>] [-Color <String>]
 [-Description <String>] [-Id <String>] [-IsActive] [-Name <String>]
 [-Parent <IMicrosoftGraphParentLabelDetails>] [-Sensitivity <Int32>] [-Tooltip <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgInformationProtectionPolicyLabel -BodyParameter <IMicrosoftGraphInformationProtectionLabel> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to labels for informationProtection

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

### -BodyParameter
informationProtectionLabel
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphInformationProtectionLabel
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Color
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

### -IsActive
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

### -Parent
parentLabelDetails
To construct, see NOTES section for PARENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphParentLabelDetails
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sensitivity
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

### -Tooltip
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionLabel
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationProtectionLabel
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphInformationProtectionLabel\>: informationProtectionLabel
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Color \<String\>\]: 
  \[Description \<String\>\]: 
  \[IsActive \<Boolean?\>\]: 
  \[Name \<String\>\]: 
  \[Parent \<IMicrosoftGraphParentLabelDetails\>\]: parentLabelDetails
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Color \<String\>\]: 
    \[Description \<String\>\]: 
    \[Id \<String\>\]: 
    \[IsActive \<Boolean?\>\]: 
    \[Name \<String\>\]: 
    \[Parent \<IMicrosoftGraphParentLabelDetails\>\]: parentLabelDetails
    \[Sensitivity \<Int32?\>\]: 
    \[Tooltip \<String\>\]: 
  \[Sensitivity \<Int32?\>\]: 
  \[Tooltip \<String\>\]: 

PARENT \<IMicrosoftGraphParentLabelDetails\>: parentLabelDetails
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Color \<String\>\]: 
  \[Description \<String\>\]: 
  \[Id \<String\>\]: 
  \[IsActive \<Boolean?\>\]: 
  \[Name \<String\>\]: 
  \[Parent \<IMicrosoftGraphParentLabelDetails\>\]: parentLabelDetails
  \[Sensitivity \<Int32?\>\]: 
  \[Tooltip \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionpolicylabel](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionpolicylabel)

