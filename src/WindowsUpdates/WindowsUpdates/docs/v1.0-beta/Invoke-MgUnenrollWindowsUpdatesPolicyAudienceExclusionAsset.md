---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/invoke-mgunenrollwindowsupdatespolicyaudienceexclusionasset
schema: 2.0.0
---

# Invoke-MgUnenrollWindowsUpdatesPolicyAudienceExclusionAsset

## SYNOPSIS
Invoke action unenrollAssets

## SYNTAX

### UnenrollExpanded (Default)
```
Invoke-MgUnenrollWindowsUpdatesPolicyAudienceExclusionAsset -UpdatePolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Unenroll
```
Invoke-MgUnenrollWindowsUpdatesPolicyAudienceExclusionAsset -UpdatePolicyId <String>
 -BodyParameter <IPaths14C25SeAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceExclusionsMicrosoftGraphWindowsupdatesUnenrollassetsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UnenrollViaIdentity
```
Invoke-MgUnenrollWindowsUpdatesPolicyAudienceExclusionAsset -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPaths14C25SeAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceExclusionsMicrosoftGraphWindowsupdatesUnenrollassetsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UnenrollViaIdentityExpanded
```
Invoke-MgUnenrollWindowsUpdatesPolicyAudienceExclusionAsset -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action unenrollAssets

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UnenrollExpanded, UnenrollViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assets
.
To construct, please use Get-Help -Online and see NOTES section for ASSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: UnenrollExpanded, UnenrollViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths14C25SeAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceExclusionsMicrosoftGraphWindowsupdatesUnenrollassetsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Unenroll, UnenrollViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UnenrollViaIdentity, UnenrollViaIdentityExpanded
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

### -UpdateCategory
updateCategory

```yaml
Type: System.String
Parameter Sets: UnenrollExpanded, UnenrollViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatePolicyId
The unique identifier of updatePolicy

```yaml
Type: System.String
Parameter Sets: Unenroll, UnenrollExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IPaths14C25SeAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceExclusionsMicrosoftGraphWindowsupdatesUnenrollassetsPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Invoke-MgUnenrollWuPolicyAudienceExclusionAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSETS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

BODYPARAMETER <IPaths14C25SeAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceExclusionsMicrosoftGraphWindowsupdatesUnenrollassetsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[UpdateCategory <String>]`: updateCategory

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

