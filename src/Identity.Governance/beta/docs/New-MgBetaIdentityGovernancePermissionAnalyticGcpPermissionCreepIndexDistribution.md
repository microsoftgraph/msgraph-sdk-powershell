---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/new-mgbetaidentitygovernancepermissionanalyticgcppermissioncreepindexdistribution
schema: 2.0.0
---

# New-MgBetaIdentityGovernancePermissionAnalyticGcpPermissionCreepIndexDistribution

## SYNOPSIS
Create new navigation property to permissionsCreepIndexDistributions for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityGovernancePermissionAnalyticGcpPermissionCreepIndexDistribution
 [-AdditionalProperties <Hashtable>] [-AuthorizationSystem <IMicrosoftGraphAuthorizationSystem>]
 [-CreatedDateTime <DateTime>] [-HighRiskProfile <IMicrosoftGraphRiskProfile>] [-Id <String>]
 [-LowRiskProfile <IMicrosoftGraphRiskProfile>] [-MediumRiskProfile <IMicrosoftGraphRiskProfile>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityGovernancePermissionAnalyticGcpPermissionCreepIndexDistribution
 -BodyParameter <IMicrosoftGraphPermissionsCreepIndexDistribution> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to permissionsCreepIndexDistributions for identityGovernance

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationSystem
authorizationSystem
To construct, see NOTES section for AUTHORIZATIONSYSTEM properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthorizationSystem
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permissionsCreepIndexDistribution
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsCreepIndexDistribution
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Defines when the PCI distribution was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HighRiskProfile
riskProfile
To construct, see NOTES section for HIGHRISKPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRiskProfile
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LowRiskProfile
riskProfile
To construct, see NOTES section for LOWRISKPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRiskProfile
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediumRiskProfile
riskProfile
To construct, see NOTES section for MEDIUMRISKPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRiskProfile
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsCreepIndexDistribution

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsCreepIndexDistribution

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTHORIZATIONSYSTEM <IMicrosoftGraphAuthorizationSystem>`: authorizationSystem
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment. Supports $filter(eq, contains) and $orderBy.
  - `[AuthorizationSystemName <String>]`: Name of the authorization system detected after onboarding. Supports $filter(eq,contains) and $orderBy.
  - `[AuthorizationSystemType <String>]`: The type of authorization system. Can be gcp, azure, or aws. Supports $filter(eq).
  - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.

`BODYPARAMETER <IMicrosoftGraphPermissionsCreepIndexDistribution>`: permissionsCreepIndexDistribution
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthorizationSystem <IMicrosoftGraphAuthorizationSystem>]`: authorizationSystem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AuthorizationSystemId <String>]`: ID of the authorization system retrieved from the customer cloud environment. Supports $filter(eq, contains) and $orderBy.
    - `[AuthorizationSystemName <String>]`: Name of the authorization system detected after onboarding. Supports $filter(eq,contains) and $orderBy.
    - `[AuthorizationSystemType <String>]`: The type of authorization system. Can be gcp, azure, or aws. Supports $filter(eq).
    - `[DataCollectionInfo <IMicrosoftGraphDataCollectionInfo>]`: dataCollectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Entitlements <IMicrosoftGraphEntitlementsDataCollectionInfo>]`: entitlementsDataCollectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: Defines when the PCI distribution was created.
  - `[HighRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HumanCount <Int32?>]`: This is the count of human identities that have been assigned to this riskScoreBracket,
    - `[NonHumanCount <Int32?>]`: This is the count of nonhuman identities that have been assigned to this riskScoreBracket
  - `[LowRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile
  - `[MediumRiskProfile <IMicrosoftGraphRiskProfile>]`: riskProfile

`HIGHRISKPROFILE <IMicrosoftGraphRiskProfile>`: riskProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HumanCount <Int32?>]`: This is the count of human identities that have been assigned to this riskScoreBracket,
  - `[NonHumanCount <Int32?>]`: This is the count of nonhuman identities that have been assigned to this riskScoreBracket

`LOWRISKPROFILE <IMicrosoftGraphRiskProfile>`: riskProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HumanCount <Int32?>]`: This is the count of human identities that have been assigned to this riskScoreBracket,
  - `[NonHumanCount <Int32?>]`: This is the count of nonhuman identities that have been assigned to this riskScoreBracket

`MEDIUMRISKPROFILE <IMicrosoftGraphRiskProfile>`: riskProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HumanCount <Int32?>]`: This is the count of human identities that have been assigned to this riskScoreBracket,
  - `[NonHumanCount <Int32?>]`: This is the count of nonhuman identities that have been assigned to this riskScoreBracket

## RELATED LINKS

