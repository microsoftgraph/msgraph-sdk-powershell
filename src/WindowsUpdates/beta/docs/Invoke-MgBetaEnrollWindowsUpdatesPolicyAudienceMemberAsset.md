---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/invoke-mgbetaenrollwindowsupdatespolicyaudiencememberasset
schema: 2.0.0
---

# Invoke-MgBetaEnrollWindowsUpdatesPolicyAudienceMemberAsset

## SYNOPSIS
Invoke action enrollAssets

## SYNTAX

### EnrollExpanded (Default)
```
Invoke-MgBetaEnrollWindowsUpdatesPolicyAudienceMemberAsset -UpdatePolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Enroll
```
Invoke-MgBetaEnrollWindowsUpdatesPolicyAudienceMemberAsset -UpdatePolicyId <String>
 -Body <IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EnrollViaIdentity
```
Invoke-MgBetaEnrollWindowsUpdatesPolicyAudienceMemberAsset -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EnrollViaIdentityExpanded
```
Invoke-MgBetaEnrollWindowsUpdatesPolicyAudienceMemberAsset -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]
 [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action enrollAssets

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
Parameter Sets: EnrollExpanded, EnrollViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assets
.
To construct, see NOTES section for ASSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: EnrollExpanded, EnrollViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Enroll
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: EnrollViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: EnrollViaIdentity, EnrollViaIdentityExpanded
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
Parameter Sets: EnrollExpanded, EnrollViaIdentityExpanded
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
Parameter Sets: Enroll, EnrollExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

Invoke-MgBetaEnrollWuPolicyAudienceMemberAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSETS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`BODY <IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[UpdateCategory <String>]`: updateCategory

`BODYPARAMETER <IPaths1V9GilxAdminWindowsUpdatesUpdatepoliciesUpdatepolicyIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[UpdateCategory <String>]`: updateCategory

`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

