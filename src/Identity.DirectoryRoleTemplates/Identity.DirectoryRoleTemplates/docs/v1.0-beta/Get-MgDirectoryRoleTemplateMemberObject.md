---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryRoleTemplates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directoryroletemplates/get-mgdirectoryroletemplatememberobject
schema: 2.0.0
---

# Get-MgDirectoryRoleTemplateMemberObject

## SYNOPSIS
Invoke action getMemberObjects

## SYNTAX

### GetExpanded1 (Default)
```
Get-MgDirectoryRoleTemplateMemberObject -DirectoryRoleTemplateId <String> [-SecurityEnabledOnly] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Get1
```
Get-MgDirectoryRoleTemplateMemberObject -DirectoryRoleTemplateId <String>
 -BodyParameter <IPaths116Bv3CDirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgDirectoryRoleTemplateMemberObject -InputObject <IIdentityDirectoryRoleTemplatesIdentity>
 -BodyParameter <IPaths116Bv3CDirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded1
```
Get-MgDirectoryRoleTemplateMemberObject -InputObject <IIdentityDirectoryRoleTemplatesIdentity>
 [-SecurityEnabledOnly] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getMemberObjects

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
Type: Microsoft.Graph.PowerShell.Models.IPaths116Bv3CDirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get1, GetViaIdentity1
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
Parameter Sets: Get1, GetExpanded1
Aliases:

Required: True
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
Parameter Sets: GetViaIdentity1, GetViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SecurityEnabledOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: GetExpanded1, GetViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryRoleTemplatesIdentity

### Microsoft.Graph.PowerShell.Models.IPaths116Bv3CDirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths116Bv3CDirectoryroletemplatesDirectoryroletemplateIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>: .
  - `[SecurityEnabledOnly <Boolean?>]`: 

INPUTOBJECT <IIdentityDirectoryRoleTemplatesIdentity>: Identity Parameter
  - `[DirectoryRoleTemplateId <String>]`: key: directoryRoleTemplate-id of directoryRoleTemplate

## RELATED LINKS

