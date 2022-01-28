---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/update-mgwindowsupdatesdeploymentaudience
schema: 2.0.0
---

# Update-MgWindowsUpdatesDeploymentAudience

## SYNOPSIS
Invoke action updateAudience

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgWindowsUpdatesDeploymentAudience -DeploymentId <String>
 [-AddExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-AdditionalProperties <Hashtable>]
 [-AddMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-RemoveExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-RemoveMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgWindowsUpdatesDeploymentAudience -DeploymentId <String>
 -BodyParameter <IPathsGxoqhAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgWindowsUpdatesDeploymentAudience -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPathsGxoqhAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgWindowsUpdatesDeploymentAudience -InputObject <IWindowsUpdatesIdentity>
 [-AddExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-AdditionalProperties <Hashtable>]
 [-AddMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-RemoveExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-RemoveMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action updateAudience

## EXAMPLES

## PARAMETERS

### -AddExclusions
.
To construct, please use Get-Help -Online and see NOTES section for ADDEXCLUSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddMembers
.
To construct, please use Get-Help -Online and see NOTES section for ADDMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsGxoqhAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -RemoveExclusions
.
To construct, please use Get-Help -Online and see NOTES section for REMOVEEXCLUSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoveMembers
.
To construct, please use Get-Help -Online and see NOTES section for REMOVEMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsGxoqhAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencePostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgWuDeploymentAudience

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDEXCLUSIONS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: Read-only.

ADDMEMBERS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: Read-only.

BODYPARAMETER <IPathsGxoqhAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AddExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[AddMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
  - `[RemoveExclusions <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
  - `[RemoveMembers <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

REMOVEEXCLUSIONS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: Read-only.

REMOVEMEMBERS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: Read-only.

## RELATED LINKS

