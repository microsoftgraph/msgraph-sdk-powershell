---
external help file:
Module Name: Microsoft.Graph.Identity.DirectorySettingTemplates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorysettingtemplates/get-mgdirectorysettingtemplatemembergroup
schema: 2.0.0
---

# Get-MgDirectorySettingTemplateMemberGroup

## SYNOPSIS
Invoke action getMemberGroups

## SYNTAX

### GetExpanded (Default)
```
Get-MgDirectorySettingTemplateMemberGroup -DirectorySettingTemplateId <String> [-SecurityEnabledOnly]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgDirectorySettingTemplateMemberGroup -DirectorySettingTemplateId <String>
 -BodyParameter <IPathsOliirpDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDirectorySettingTemplateMemberGroup -InputObject <IIdentityDirectorySettingTemplatesIdentity>
 -BodyParameter <IPathsOliirpDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded
```
Get-MgDirectorySettingTemplateMemberGroup -InputObject <IIdentityDirectorySettingTemplatesIdentity>
 [-SecurityEnabledOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getMemberGroups

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
Type: Microsoft.Graph.PowerShell.Models.IPathsOliirpDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -DirectorySettingTemplateId
key: directorySettingTemplate-id of directorySettingTemplate

```yaml
Type: System.String
Parameter Sets: Get, GetExpanded
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingTemplatesIdentity
Parameter Sets: GetViaIdentity, GetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -SecurityEnabledOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectorySettingTemplatesIdentity

### Microsoft.Graph.PowerShell.Models.IPathsOliirpDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPathsOliirpDirectorysettingtemplatesDirectorysettingtemplateIdMicrosoftGraphGetmembergroupsPostRequestbodyContentApplicationJsonSchema>: .
  - `[SecurityEnabledOnly <Boolean?>]`: 

#### INPUTOBJECT <IIdentityDirectorySettingTemplatesIdentity>: Identity Parameter
  - `[DirectorySettingTemplateId <String>]`: key: directorySettingTemplate-id of directorySettingTemplate

## RELATED LINKS

