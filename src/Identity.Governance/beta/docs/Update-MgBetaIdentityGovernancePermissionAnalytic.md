---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/update-mgbetaidentitygovernancepermissionanalytic
schema: 2.0.0
---

# Update-MgBetaIdentityGovernancePermissionAnalytic

## SYNOPSIS
Update the navigation property permissionsAnalytics in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaIdentityGovernancePermissionAnalytic [-AdditionalProperties <Hashtable>]
 [-Aws <IMicrosoftGraphPermissionsAnalytics>] [-Azure <IMicrosoftGraphPermissionsAnalytics>]
 [-Gcp <IMicrosoftGraphPermissionsAnalytics>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaIdentityGovernancePermissionAnalytic
 -BodyParameter <IMicrosoftGraphPermissionsAnalyticsAggregation> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property permissionsAnalytics in identityGovernance

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

### -Aws
permissionsAnalytics
To construct, see NOTES section for AWS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Azure
permissionsAnalytics
To construct, see NOTES section for AZURE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permissionsAnalyticsAggregation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalyticsAggregation
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Gcp
permissionsAnalytics
To construct, see NOTES section for GCP properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalytics
Parameter Sets: UpdateExpanded
Aliases:

Required: False
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalyticsAggregation

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionsAnalyticsAggregation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AWS <IMicrosoftGraphPermissionsAnalytics>`: permissionsAnalytics
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

`AZURE <IMicrosoftGraphPermissionsAnalytics>`: permissionsAnalytics
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

`BODYPARAMETER <IMicrosoftGraphPermissionsAnalyticsAggregation>`: permissionsAnalyticsAggregation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Aws <IMicrosoftGraphPermissionsAnalytics>]`: permissionsAnalytics
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
  - `[Azure <IMicrosoftGraphPermissionsAnalytics>]`: permissionsAnalytics
  - `[Gcp <IMicrosoftGraphPermissionsAnalytics>]`: permissionsAnalytics

`GCP <IMicrosoftGraphPermissionsAnalytics>`: permissionsAnalytics
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

## RELATED LINKS

