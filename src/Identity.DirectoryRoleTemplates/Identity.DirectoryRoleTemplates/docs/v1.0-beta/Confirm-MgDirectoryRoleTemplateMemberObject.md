---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryRoleTemplates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directoryroletemplates/confirm-mgdirectoryroletemplatememberobject
schema: 2.0.0
---

# Confirm-MgDirectoryRoleTemplateMemberObject

## SYNOPSIS
Invoke action checkMemberObjects

## SYNTAX

### CheckExpanded1 (Default)
```
Confirm-MgDirectoryRoleTemplateMemberObject -DirectoryRoleTemplateId <String> [-Ids <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Check1
```
Confirm-MgDirectoryRoleTemplateMemberObject -DirectoryRoleTemplateId <String>
 -BodyParameter <IPathsYkfgk1DirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity1
```
Confirm-MgDirectoryRoleTemplateMemberObject -InputObject <IIdentityDirectoryRoleTemplatesIdentity>
 -BodyParameter <IPathsYkfgk1DirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded1
```
Confirm-MgDirectoryRoleTemplateMemberObject -InputObject <IIdentityDirectoryRoleTemplatesIdentity>
 [-Ids <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action checkMemberObjects

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
Type: Microsoft.Graph.PowerShell.Models.IPathsYkfgk1DirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Check1, CheckViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryRoleTemplateId
key: directoryRoleTemplate-id of directoryRoleTemplate

```yaml
Type: System.String
Parameter Sets: Check1, CheckExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryRoleTemplatesIdentity
Parameter Sets: CheckViaIdentity1, CheckViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryRoleTemplatesIdentity

### Microsoft.Graph.PowerShell.Models.IPathsYkfgk1DirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsYkfgk1DirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema>: .
  - `[Ids <String[]>]`: 

INPUTOBJECT <IIdentityDirectoryRoleTemplatesIdentity>: Identity Parameter
  - `[DirectoryRoleTemplateId <String>]`: key: directoryRoleTemplate-id of directoryRoleTemplate

## RELATED LINKS

