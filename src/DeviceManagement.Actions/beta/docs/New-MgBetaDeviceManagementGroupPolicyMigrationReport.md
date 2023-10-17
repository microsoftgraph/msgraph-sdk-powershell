---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/new-mgbetadevicemanagementgrouppolicymigrationreport
schema: 2.0.0
---

# New-MgBetaDeviceManagementGroupPolicyMigrationReport

## SYNOPSIS
Invoke action createMigrationReport

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementGroupPolicyMigrationReport [-AdditionalProperties <Hashtable>]
 [-GroupPolicyObjectFile <IMicrosoftGraphGroupPolicyObjectFile>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementGroupPolicyMigrationReport
 -BodyParameter <IPathsDjtigpDevicemanagementGrouppolicymigrationreportsMicrosoftGraphCreatemigrationreportPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action createMigrationReport

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsDjtigpDevicemanagementGrouppolicymigrationreportsMicrosoftGraphCreatemigrationreportPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupPolicyObjectFile
The Group Policy Object file uploaded by admin.
To construct, see NOTES section for GROUPPOLICYOBJECTFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyObjectFile
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsDjtigpDevicemanagementGrouppolicymigrationreportsMicrosoftGraphCreatemigrationreportPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsDjtigpDevicemanagementGrouppolicymigrationreportsMicrosoftGraphCreatemigrationreportPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[GroupPolicyObjectFile <IMicrosoftGraphGroupPolicyObjectFile>]`: The Group Policy Object file uploaded by admin.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Content <String>]`: The Group Policy Object file content.
    - `[CreatedDateTime <DateTime?>]`: The date and time at which the GroupPolicy was first uploaded.
    - `[GroupPolicyObjectId <String>]`: The Group Policy Object GUID from GPO Xml content
    - `[LastModifiedDateTime <DateTime?>]`: The date and time at which the GroupPolicyObjectFile was last modified.
    - `[OuDistinguishedName <String>]`: The distinguished name of the OU.
    - `[RoleScopeTagIds <String[]>]`: The list of scope tags for the configuration.

`GROUPPOLICYOBJECTFILE <IMicrosoftGraphGroupPolicyObjectFile>`: The Group Policy Object file uploaded by admin.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Content <String>]`: The Group Policy Object file content.
  - `[CreatedDateTime <DateTime?>]`: The date and time at which the GroupPolicy was first uploaded.
  - `[GroupPolicyObjectId <String>]`: The Group Policy Object GUID from GPO Xml content
  - `[LastModifiedDateTime <DateTime?>]`: The date and time at which the GroupPolicyObjectFile was last modified.
  - `[OuDistinguishedName <String>]`: The distinguished name of the OU.
  - `[RoleScopeTagIds <String[]>]`: The list of scope tags for the configuration.

## RELATED LINKS

