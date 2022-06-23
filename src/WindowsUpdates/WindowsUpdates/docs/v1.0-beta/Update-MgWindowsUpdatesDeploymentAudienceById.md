---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/update-mgwindowsupdatesdeploymentaudiencebyid
schema: 2.0.0
---

# Update-MgWindowsUpdatesDeploymentAudienceById

## SYNOPSIS
Invoke action updateAudienceById

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgWindowsUpdatesDeploymentAudienceById -DeploymentId <String> [-AddExclusions <String[]>]
 [-AdditionalProperties <Hashtable>] [-AddMembers <String[]>] [-MemberEntityType <String>]
 [-RemoveExclusions <String[]>] [-RemoveMembers <String[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgWindowsUpdatesDeploymentAudienceById -DeploymentId <String>
 -BodyParameter <IPaths1Yczx1TAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencebyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgWindowsUpdatesDeploymentAudienceById -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPaths1Yczx1TAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencebyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgWindowsUpdatesDeploymentAudienceById -InputObject <IWindowsUpdatesIdentity>
 [-AddExclusions <String[]>] [-AdditionalProperties <Hashtable>] [-AddMembers <String[]>]
 [-MemberEntityType <String>] [-RemoveExclusions <String[]>] [-RemoveMembers <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action updateAudienceById

## EXAMPLES

## PARAMETERS

### -AddExclusions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddMembers
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Yczx1TAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencebyidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update1, UpdateViaIdentity1
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
Parameter Sets: Update1, UpdateExpanded1
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
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -RemoveExclusions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemoveMembers
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths1Yczx1TAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencebyidPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgWuDeploymentAudienceById

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Yczx1TAdminWindowsUpdatesDeploymentsDeploymentIdAudienceMicrosoftGraphWindowsupdatesUpdateaudiencebyidPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AddExclusions <String[]>]`: 
  - `[AddMembers <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[RemoveExclusions <String[]>]`: 
  - `[RemoveMembers <String[]>]`: 

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

## RELATED LINKS

