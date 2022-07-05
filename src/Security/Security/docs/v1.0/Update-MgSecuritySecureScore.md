---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecuritysecurescore
schema: 2.0.0
---

# Update-MgSecuritySecureScore

## SYNOPSIS
Update the navigation property secureScores in security

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgSecuritySecureScore -SecureScoreId <String> [-ActiveUserCount <Int32>]
 [-AdditionalProperties <Hashtable>] [-AverageComparativeScores <IMicrosoftGraphAverageComparativeScore[]>]
 [-AzureTenantId <String>] [-ControlScores <IMicrosoftGraphControlScore[]>] [-CreatedDateTime <DateTime>]
 [-CurrentScore <Double>] [-EnabledServices <String[]>] [-Id <String>] [-LicensedUserCount <Int32>]
 [-MaxScore <Double>] [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgSecuritySecureScore -SecureScoreId <String> -BodyParameter <IMicrosoftGraphSecureScore> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgSecuritySecureScore -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphSecureScore>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgSecuritySecureScore -InputObject <ISecurityIdentity> [-ActiveUserCount <Int32>]
 [-AdditionalProperties <Hashtable>] [-AverageComparativeScores <IMicrosoftGraphAverageComparativeScore[]>]
 [-AzureTenantId <String>] [-ControlScores <IMicrosoftGraphControlScore[]>] [-CreatedDateTime <DateTime>]
 [-CurrentScore <Double>] [-EnabledServices <String[]>] [-Id <String>] [-LicensedUserCount <Int32>]
 [-MaxScore <Double>] [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property secureScores in security

## EXAMPLES

## PARAMETERS

### -ActiveUserCount
Active user count of the given tenant.

```yaml
Type: System.Int32
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

### -AverageComparativeScores
Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
To construct, please use Get-Help -Online and see NOTES section for AVERAGECOMPARATIVESCORES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAverageComparativeScore[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
GUID string for tenant ID.

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

### -BodyParameter
secureScore
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScore
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ControlScores
Contains tenant scores for a set of controls.
To construct, please use Get-Help -Online and see NOTES section for CONTROLSCORES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphControlScore[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date when the entity is created.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrentScore
Tenant current attained score on specified date.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnabledServices
Microsoft-provided services for the tenant (for example, Exchange online, Skype, SharePoint).

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

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISecurityIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LicensedUserCount
Licensed user count of the given tenant.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxScore
Tenant maximum possible score on specified date.

```yaml
Type: System.Double
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

### -SecureScoreId
key: id of secureScore

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

### -VendorInformation
securityVendorInformation
To construct, please use Get-Help -Online and see NOTES section for VENDORINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityVendorInformation
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScore

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AVERAGECOMPARATIVESCORES <IMicrosoftGraphAverageComparativeScore[]>: Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
  - `[AverageScore <Double?>]`: Average score within specified basis.
  - `[Basis <String>]`: Scope type. The possible values are: AllTenants, TotalSeats, IndustryTypes.

BODYPARAMETER <IMicrosoftGraphSecureScore>: secureScore
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActiveUserCount <Int32?>]`: Active user count of the given tenant.
  - `[AverageComparativeScores <IMicrosoftGraphAverageComparativeScore[]>]`: Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
    - `[AverageScore <Double?>]`: Average score within specified basis.
    - `[Basis <String>]`: Scope type. The possible values are: AllTenants, TotalSeats, IndustryTypes.
  - `[AzureTenantId <String>]`: GUID string for tenant ID.
  - `[ControlScores <IMicrosoftGraphControlScore[]>]`: Contains tenant scores for a set of controls.
    - `[ControlCategory <String>]`: Control action category (Identity, Data, Device, Apps, Infrastructure).
    - `[ControlName <String>]`: Control unique name.
    - `[Description <String>]`: Description of the control.
    - `[Score <Double?>]`: Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).
  - `[CreatedDateTime <DateTime?>]`: The date when the entity is created.
  - `[CurrentScore <Double?>]`: Tenant current attained score on specified date.
  - `[EnabledServices <String[]>]`: Microsoft-provided services for the tenant (for example, Exchange online, Skype, SharePoint).
  - `[LicensedUserCount <Int32?>]`: Licensed user count of the given tenant.
  - `[MaxScore <Double?>]`: Tenant maximum possible score on specified date.
  - `[VendorInformation <IMicrosoftGraphSecurityVendorInformation>]`: securityVendorInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
    - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

CONTROLSCORES <IMicrosoftGraphControlScore[]>: Contains tenant scores for a set of controls.
  - `[ControlCategory <String>]`: Control action category (Identity, Data, Device, Apps, Infrastructure).
  - `[ControlName <String>]`: Control unique name.
  - `[Description <String>]`: Description of the control.
  - `[Score <Double?>]`: Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: id of alert
  - `[AuthoredNoteId <String>]`: key: id of authoredNote
  - `[CaseOperationId <String>]`: key: id of caseOperation
  - `[CloudAppSecurityProfileId <String>]`: key: id of cloudAppSecurityProfile
  - `[DataSourceId <String>]`: key: id of dataSource
  - `[DispositionReviewStageId <String>]`: key: id of dispositionReviewStage
  - `[DomainSecurityProfileId <String>]`: key: id of domainSecurityProfile
  - `[EdiscoveryCaseId <String>]`: key: id of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: key: id of ediscoveryCustodian
  - `[EdiscoveryFileId <String>]`: key: id of ediscoveryFile
  - `[EdiscoveryHoldPolicyId <String>]`: key: id of ediscoveryHoldPolicy
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: key: id of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: key: id of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: key: id of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: key: id of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: key: id of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: key: id of ediscoverySearch
  - `[FileSecurityProfileId <String>]`: key: id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: id of ipSecurityProfile
  - `[ProviderTenantSettingId <String>]`: key: id of providerTenantSetting
  - `[RetentionEventId <String>]`: key: id of retentionEvent
  - `[RetentionEventTypeId <String>]`: key: id of retentionEventType
  - `[RetentionLabelId <String>]`: key: id of retentionLabel
  - `[SecureScoreControlProfileId <String>]`: key: id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: id of secureScore
  - `[SecurityActionId <String>]`: key: id of securityAction
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SimulationAutomationId <String>]`: key: id of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: key: id of simulationAutomationRun
  - `[SimulationId <String>]`: key: id of simulation
  - `[SiteSourceId <String>]`: key: id of siteSource
  - `[SubjectRightsRequestId <String>]`: key: id of subjectRightsRequest
  - `[TiIndicatorId <String>]`: key: id of tiIndicator
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSecurityProfileId <String>]`: key: id of userSecurityProfile
  - `[UserSourceId <String>]`: key: id of userSource

VENDORINFORMATION <IMicrosoftGraphSecurityVendorInformation>: securityVendorInformation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

## RELATED LINKS

