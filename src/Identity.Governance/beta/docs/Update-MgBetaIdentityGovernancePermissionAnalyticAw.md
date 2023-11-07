---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/update-mgbetaidentitygovernancepermissionanalyticaw
schema: 2.0.0
---

# Update-MgBetaIdentityGovernancePermissionAnalyticAw

## SYNOPSIS
Update the navigation property aws in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaIdentityGovernancePermissionAnalyticAw [-AdditionalProperties <Hashtable>]
 [-Findings <IMicrosoftGraphFinding[]>] [-Id <String>]
 [-PermissionsCreepIndexDistributions <IMicrosoftGraphPermissionsCreepIndexDistribution[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaIdentityGovernancePermissionAnalyticAw -BodyParameter <IMicrosoftGraphPermissionsAnalytics>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property aws in identityGovernance

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permissionsAnalytics
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Findings
.
To construct, see NOTES section for FINDINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFinding[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsCreepIndexDistributions
.
To construct, see NOTES section for PERMISSIONSCREEPINDEXDISTRIBUTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsCreepIndexDistribution[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPermissionsAnalytics>`: permissionsAnalytics
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Findings <IMicrosoftGraphFinding[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
  - `[PermissionsCreepIndexDistributions <IMicrosoftGraphPermissionsCreepIndexDistribution[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AuthorizationSystem <IMicrosoftGraphAuthorizationSystem>]`: authorizationSystem
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AuthorizationSystemId <String>]`: 
      - `[AuthorizationSystemName <String>]`: 
      - `[AuthorizationSystemType <String>]`: 
      - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[HighRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[HumanCount <Int32?>]`: 
      - `[NonHumanCount <Int32?>]`: 
    - `[LowRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
    - `[MediumRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile

`FINDINGS <IMicrosoftGraphFinding[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: 

`PERMISSIONSCREEPINDEXDISTRIBUTIONS <IMicrosoftGraphPermissionsCreepIndexDistribution[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthorizationSystem <IMicrosoftGraphAuthorizationSystem>]`: authorizationSystem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AuthorizationSystemId <String>]`: 
    - `[AuthorizationSystemName <String>]`: 
    - `[AuthorizationSystemType <String>]`: 
    - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[HighRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HumanCount <Int32?>]`: 
    - `[NonHumanCount <Int32?>]`: 
  - `[LowRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
  - `[MediumRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile

## RELATED LINKS

