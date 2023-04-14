---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/remove-mgwindowsupdatespolicyaudiencemember
schema: 2.0.0
---

# Remove-MgWindowsUpdatesPolicyAudienceMember

## SYNOPSIS
Delete navigation property members for admin

## SYNTAX

### Delete (Default)
```
Remove-MgWindowsUpdatesPolicyAudienceMember -UpdatableAssetId <String> -UpdatePolicyId <String>
 [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-MgWindowsUpdatesPolicyAudienceMember -InputObject <IWindowsUpdatesIdentity> [-IfMatch <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Remove
```
Remove-MgWindowsUpdatesPolicyAudienceMember -UpdatableAssetId <String> -UpdatePolicyId <String>
 -BodyParameter <IPathsQtoif1AdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersUpdatableassetIdMicrosoftGraphWindowsupdatesRemovemembersPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RemoveExpanded
```
Remove-MgWindowsUpdatesPolicyAudienceMember -UpdatableAssetId <String> -UpdatePolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RemoveViaIdentity
```
Remove-MgWindowsUpdatesPolicyAudienceMember -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPathsQtoif1AdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersUpdatableassetIdMicrosoftGraphWindowsupdatesRemovemembersPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RemoveViaIdentityExpanded
```
Remove-MgWindowsUpdatesPolicyAudienceMember -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete navigation property members for admin

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RemoveExpanded, RemoveViaIdentityExpanded
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
Parameter Sets: RemoveExpanded, RemoveViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsQtoif1AdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersUpdatableassetIdMicrosoftGraphWindowsupdatesRemovemembersPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Remove, RemoveViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IfMatch
ETag

```yaml
Type: System.String
Parameter Sets: Delete, DeleteViaIdentity
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
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: DeleteViaIdentity, RemoveViaIdentity, RemoveViaIdentityExpanded
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

### -UpdatableAssetId
The unique identifier of updatableAsset

```yaml
Type: System.String
Parameter Sets: Delete, Remove, RemoveExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdatePolicyId
The unique identifier of updatePolicy

```yaml
Type: System.String
Parameter Sets: Delete, Remove, RemoveExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsQtoif1AdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersUpdatableassetIdMicrosoftGraphWindowsupdatesRemovemembersPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Remove-MgWuPolicyAudienceMember

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSETS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

BODYPARAMETER <IPathsQtoif1AdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersUpdatableassetIdMicrosoftGraphWindowsupdatesRemovemembersPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

