---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/update-mgbetaidentitygovernancepermissionanalyticazure
schema: 2.0.0
---

# Update-MgBetaIdentityGovernancePermissionAnalyticAzure

## SYNOPSIS
Update the navigation property azure in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaIdentityGovernancePermissionAnalyticAzure [-AdditionalProperties <Hashtable>]
 [-Findings <IMicrosoftGraphFinding[]>] [-Id <String>]
 [-PermissionsCreepIndexDistributions <IMicrosoftGraphPermissionsCreepIndexDistribution[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaIdentityGovernancePermissionAnalyticAzure -BodyParameter <IMicrosoftGraphPermissionsAnalytics>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property azure in identityGovernance

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
The output of the permissions usage data analysis performed by Permissions Management to assess risk with identities and resources.
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
Represents the Permissions Creep Index (PCI) for the authorization system.
PCI distribution chart shows the classification of human and nonhuman identities based on the PCI score in three buckets (low, medium, high).
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
  - `[Findings <IMicrosoftGraphFinding[]>]`: The output of the permissions usage data analysis performed by Permissions Management to assess risk with identities and resources.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: Defines when the finding was created.
  - `[PermissionsCreepIndexDistributions <IMicrosoftGraphPermissionsCreepIndexDistribution[]>]`: Represents the Permissions Creep Index (PCI) for the authorization system. PCI distribution chart shows the classification of human and nonhuman identities based on the PCI score in three buckets (low, medium, high).
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

`FINDINGS <IMicrosoftGraphFinding[]>`: The output of the permissions usage data analysis performed by Permissions Management to assess risk with identities and resources.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: Defines when the finding was created.

`PERMISSIONSCREEPINDEXDISTRIBUTIONS <IMicrosoftGraphPermissionsCreepIndexDistribution[]>`: Represents the Permissions Creep Index (PCI) for the authorization system. PCI distribution chart shows the classification of human and nonhuman identities based on the PCI score in three buckets (low, medium, high).
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

## RELATED LINKS

