---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/invoke-mgbetaenrollwindowsupdatesdeploymentaudiencememberassetbyid
schema: 2.0.0
---

# Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById

## SYNOPSIS
Invoke action enrollAssetsById

## SYNTAX

### EnrollExpanded (Default)
```
Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById -DeploymentId <String>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-MemberEntityType <String>]
 [-ResponseHeadersVariable <String>] [-UpdateCategory <String>] [-Headers <IDictionary>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Enroll
```
Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById -DeploymentId <String>
 -Body <IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### EnrollViaIdentity
```
Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### EnrollViaIdentityExpanded
```
Invoke-MgBetaEnrollWindowsUpdatesDeploymentAudienceMemberAssetById -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-MemberEntityType <String>]
 [-ResponseHeadersVariable <String>] [-UpdateCategory <String>] [-Headers <IDictionary>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action enrollAssetsById

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: EnrollViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentId
The unique identifier of deployment

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: EnrollExpanded, EnrollViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: EnrollViaIdentity, EnrollViaIdentityExpanded
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
Parameter Sets: EnrollExpanded, EnrollViaIdentityExpanded
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

Invoke-MgBetaEnrollWuDeploymentAudienceMemberAssetGraphBPreId

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

`BODYPARAMETER <IPaths1Cgy4T7AdminWindowsUpdatesDeploymentsDeploymentIdAudienceMembersMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

