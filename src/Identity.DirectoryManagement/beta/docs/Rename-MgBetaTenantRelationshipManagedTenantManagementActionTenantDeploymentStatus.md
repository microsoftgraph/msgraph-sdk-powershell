---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/rename-mgbetatenantrelationshipmanagedtenantmanagementactiontenantdeploymentstatus
schema: 2.0.0
---

# Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus

## SYNOPSIS
Invoke action changeDeploymentStatus

## SYNTAX

### ChangeExpanded (Default)
```
Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus
 [-AdditionalProperties <Hashtable>] [-ManagementActionId <String>] [-ManagementTemplateId <String>]
 [-ManagementTemplateVersion <Int32>] [-Status <String>] [-TenantGroupId <String>] [-TenantId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Change
```
Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus
 -BodyParameter <IPathsNmcreiTenantrelationshipsManagedtenantsManagementactiontenantdeploymentstatusesMicrosoftGraphManagedtenantsChangedeploymentstatusPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action changeDeploymentStatus

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ChangeExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsNmcreiTenantrelationshipsManagedtenantsManagementactiontenantdeploymentstatusesMicrosoftGraphManagedtenantsChangedeploymentstatusPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Change
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagementActionId
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementTemplateId
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementTemplateVersion
.

```yaml
Type: System.Int32
Parameter Sets: ChangeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantGroupId
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsNmcreiTenantrelationshipsManagedtenantsManagementactiontenantdeploymentstatusesMicrosoftGraphManagedtenantsChangedeploymentstatusPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagementActionDeploymentStatus

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsNmcreiTenantrelationshipsManagedtenantsManagementactiontenantdeploymentstatusesMicrosoftGraphManagedtenantsChangedeploymentstatusPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagementActionId <String>]`: 
  - `[ManagementTemplateId <String>]`: 
  - `[ManagementTemplateVersion <Int32?>]`: 
  - `[Status <String>]`: 
  - `[TenantGroupId <String>]`: 
  - `[TenantId <String>]`: 

## RELATED LINKS

