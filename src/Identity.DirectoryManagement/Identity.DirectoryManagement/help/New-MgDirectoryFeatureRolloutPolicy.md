---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryfeaturerolloutpolicy
schema: 2.0.0
---

# New-MgDirectoryFeatureRolloutPolicy

## SYNOPSIS
Create new navigation property to featureRolloutPolicies for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectoryFeatureRolloutPolicy [-AdditionalProperties <Hashtable>]
 [-AppliesTo <IMicrosoftGraphDirectoryObject[]>] [-Description <String>] [-DisplayName <String>]
 [-Feature <String>] [-Id <String>] [-IsAppliedToOrganization] [-IsEnabled] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDirectoryFeatureRolloutPolicy -BodyParameter <IMicrosoftGraphFeatureRolloutPolicy> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to featureRolloutPolicies for directory

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

### -AppliesTo
.
To construct, see NOTES section for APPLIESTO properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
featureRolloutPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphFeatureRolloutPolicy
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

### -Feature
stagedFeatureName

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

### -IsAppliedToOrganization
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

### -IsEnabled
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

APPLIESTO \<IMicrosoftGraphDirectoryObject\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

BODYPARAMETER \<IMicrosoftGraphFeatureRolloutPolicy\>: featureRolloutPolicy
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AppliesTo \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DeletedDateTime \<DateTime?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[Feature \<String\>\]: stagedFeatureName
  \[IsAppliedToOrganization \<Boolean?\>\]: 
  \[IsEnabled \<Boolean?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryfeaturerolloutpolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryfeaturerolloutpolicy)

