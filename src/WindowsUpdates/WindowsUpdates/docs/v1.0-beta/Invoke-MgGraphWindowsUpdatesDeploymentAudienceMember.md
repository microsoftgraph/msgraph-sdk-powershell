---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.windowsupdates/invoke-mggraphwindowsupdatesdeploymentaudiencemember
schema: 2.0.0
---

# Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember

## SYNOPSIS
Invoke action unenrollAssetsById

## SYNTAX

### GraphExpanded (Default)
```
Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember -DeploymentId <String>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-MemberEntityType <String>] [-UpdateCategory <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Graph
```
Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember -DeploymentId <String>
 -BodyParameter <IPaths1T38YsrAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GraphViaIdentity
```
Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPaths1T38YsrAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GraphViaIdentityExpanded
```
Invoke-MgBetaGraphWindowsUpdatesDeploymentAudienceMember -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-MemberEntityType <String>] [-UpdateCategory <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action unenrollAssetsById

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GraphExpanded, GraphViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1T38YsrAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Graph, GraphViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentId
key: id of deployment

```yaml
Type: System.String
Parameter Sets: Graph, GraphExpanded
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
Parameter Sets: GraphExpanded, GraphViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: GraphViaIdentity, GraphViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MemberEntityType
.

```yaml
Type: System.String
Parameter Sets: GraphExpanded, GraphViaIdentityExpanded
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

### -UpdateCategory
updateCategory

```yaml
Type: System.String
Parameter Sets: GraphExpanded, GraphViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1T38YsrAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Invoke-MgBetaGraphWuDeploymentAudienceMember

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1T38YsrAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[ResourceConnectionId <String>]`: key: id of resourceConnection
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

## RELATED LINKS

