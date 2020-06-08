---
external help file:
Module Name: Microsoft.Graph.Identity.DirectorySettingTemplates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorysettingtemplates/confirm-mgdirectorysettingtemplatemembergroup
schema: 2.0.0
---

# Confirm-MgDirectorySettingTemplateMemberGroup

## SYNOPSIS
Invoke action checkMemberGroups

## SYNTAX

### CheckExpanded (Default)
```
Confirm-MgDirectorySettingTemplateMemberGroup -DirectorySettingTemplateId <String> [-GroupIds <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Check
```
Confirm-MgDirectorySettingTemplateMemberGroup -DirectorySettingTemplateId <String>
 -BodyParameter <IPathsMtp8GiDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity
```
Confirm-MgDirectorySettingTemplateMemberGroup -InputObject <IIdentityDirectorySettingTemplatesIdentity>
 -BodyParameter <IPathsMtp8GiDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded
```
Confirm-MgDirectorySettingTemplateMemberGroup -InputObject <IIdentityDirectorySettingTemplatesIdentity>
 [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action checkMemberGroups

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsMtp8GiDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Check, CheckViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectorySettingTemplateId
key: directorySettingTemplate-id of directorySettingTemplate

```yaml
Type: System.String
Parameter Sets: Check, CheckExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupIds
.

```yaml
Type: System.String[]
Parameter Sets: CheckExpanded, CheckViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingTemplatesIdentity
Parameter Sets: CheckViaIdentity, CheckViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingTemplatesIdentity

### Microsoft.Graph.PowerShell.Models.IPathsMtp8GiDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsMtp8GiDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>: .
  - `[GroupIds <String[]>]`: 

INPUTOBJECT <IIdentityDirectorySettingTemplatesIdentity>: Identity Parameter
  - `[DirectorySettingTemplateId <String>]`: key: directorySettingTemplate-id of directorySettingTemplate

## RELATED LINKS

