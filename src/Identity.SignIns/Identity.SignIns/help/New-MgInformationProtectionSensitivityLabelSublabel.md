---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabelsublabel
schema: 2.0.0
---

# New-MgInformationProtectionSensitivityLabelSublabel

## SYNOPSIS
Create new navigation property to sublabels for informationProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgInformationProtectionSensitivityLabelSublabel -SensitivityLabelId <String>
 [-AdditionalProperties <Hashtable>] [-ApplicableTo <String>] [-ApplicationMode <String>]
 [-AssignedPolicies <IMicrosoftGraphLabelPolicy[]>] [-AutoLabeling <IMicrosoftGraphAutoLabeling>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsDefault] [-IsEndpointProtectionEnabled]
 [-LabelActions <IMicrosoftGraphLabelActionBase[]>] [-Name <String>] [-Priority <Int32>]
 [-Sublabels <IMicrosoftGraphSensitivityLabel[]>] [-ToolTip <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgInformationProtectionSensitivityLabelSublabel -SensitivityLabelId <String>
 -BodyParameter <IMicrosoftGraphSensitivityLabel> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgInformationProtectionSensitivityLabelSublabel -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplicableTo <String>] [-ApplicationMode <String>]
 [-AssignedPolicies <IMicrosoftGraphLabelPolicy[]>] [-AutoLabeling <IMicrosoftGraphAutoLabeling>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsDefault] [-IsEndpointProtectionEnabled]
 [-LabelActions <IMicrosoftGraphLabelActionBase[]>] [-Name <String>] [-Priority <Int32>]
 [-Sublabels <IMicrosoftGraphSensitivityLabel[]>] [-ToolTip <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgInformationProtectionSensitivityLabelSublabel -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphSensitivityLabel> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sublabels for informationProtection

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicableTo
sensitivityLabelTarget

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationMode
applicationMode

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedPolicies
.
To construct, see NOTES section for ASSIGNEDPOLICIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphLabelPolicy[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoLabeling
autoLabeling
To construct, see NOTES section for AUTOLABELING properties and create a hash table.

```yaml
Type: IMicrosoftGraphAutoLabeling
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sensitivityLabel
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphSensitivityLabel
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IIdentitySignInsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefault
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEndpointProtectionEnabled
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelActions
.
To construct, see NOTES section for LABELACTIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphLabelActionBase[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
.

```yaml
Type: Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensitivityLabelId
key: id of sensitivityLabel

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sublabels
.
To construct, see NOTES section for SUBLABELS properties and create a hash table.

```yaml
Type: IMicrosoftGraphSensitivityLabel[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToolTip
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSensitivityLabel
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSensitivityLabel
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNEDPOLICIES \<IMicrosoftGraphLabelPolicy\[\]\>: .
  \[Id \<String\>\]: 
  \[Name \<String\>\]: 

AUTOLABELING \<IMicrosoftGraphAutoLabeling\>: autoLabeling
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Message \<String\>\]: 
  \[SensitiveTypeIds \<String\[\]\>\]: 

BODYPARAMETER \<IMicrosoftGraphSensitivityLabel\>: sensitivityLabel
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ApplicableTo \<String\>\]: sensitivityLabelTarget
  \[ApplicationMode \<String\>\]: applicationMode
  \[AssignedPolicies \<IMicrosoftGraphLabelPolicy\[\]\>\]: 
    \[Id \<String\>\]: 
    \[Name \<String\>\]: 
  \[AutoLabeling \<IMicrosoftGraphAutoLabeling\>\]: autoLabeling
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Message \<String\>\]: 
    \[SensitiveTypeIds \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsEndpointProtectionEnabled \<Boolean?\>\]: 
  \[LabelActions \<IMicrosoftGraphLabelActionBase\[\]\>\]: 
    \[Name \<String\>\]: 
  \[Name \<String\>\]: 
  \[Priority \<Int32?\>\]: 
  \[Sublabels \<IMicrosoftGraphSensitivityLabel\[\]\>\]: 
  \[ToolTip \<String\>\]: 

INPUTOBJECT \<IIdentitySignInsIdentity\>: Identity Parameter
  \[ActivityBasedTimeoutPolicyId \<String\>\]: key: id of activityBasedTimeoutPolicy
  \[AuthenticationContextClassReferenceId \<String\>\]: key: id of authenticationContextClassReference
  \[AuthenticationMethodId \<String\>\]: key: id of authenticationMethod
  \[AuthorizationPolicyId \<String\>\]: key: id of authorizationPolicy
  \[ClaimsMappingPolicyId \<String\>\]: key: id of claimsMappingPolicy
  \[ConditionalAccessPolicyId \<String\>\]: key: id of conditionalAccessPolicy
  \[DataLossPreventionPolicyId \<String\>\]: key: id of dataLossPreventionPolicy
  \[DataPolicyOperationId \<String\>\]: key: id of dataPolicyOperation
  \[EmailAuthenticationMethodId \<String\>\]: key: id of emailAuthenticationMethod
  \[Fido2AuthenticationMethodId \<String\>\]: key: id of fido2AuthenticationMethod
  \[HomeRealmDiscoveryPolicyId \<String\>\]: key: id of homeRealmDiscoveryPolicy
  \[IdentityProviderId \<String\>\]: key: id of identityProvider
  \[IdentityUserFlowId \<String\>\]: key: id of identityUserFlow
  \[InformationProtectionLabelId \<String\>\]: key: id of informationProtectionLabel
  \[LongRunningOperationId \<String\>\]: key: id of longRunningOperation
  \[NamedLocationId \<String\>\]: key: id of namedLocation
  \[OAuth2PermissionGrantId \<String\>\]: key: id of oAuth2PermissionGrant
  \[OrganizationId \<String\>\]: key: id of organization
  \[PasswordAuthenticationMethodId \<String\>\]: key: id of passwordAuthenticationMethod
  \[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId \<String\>\]: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  \[PermissionGrantConditionSetId \<String\>\]: key: id of permissionGrantConditionSet
  \[PermissionGrantPolicyId \<String\>\]: key: id of permissionGrantPolicy
  \[PhoneAuthenticationMethodId \<String\>\]: key: id of phoneAuthenticationMethod
  \[PrivateLinkResourcePolicyId \<String\>\]: key: id of privateLinkResourcePolicy
  \[RiskDetectionId \<String\>\]: key: id of riskDetection
  \[RiskyUserHistoryItemId \<String\>\]: key: id of riskyUserHistoryItem
  \[RiskyUserId \<String\>\]: key: id of riskyUser
  \[SensitivityLabelId \<String\>\]: key: id of sensitivityLabel
  \[SensitivityLabelId1 \<String\>\]: key: id of sensitivityLabel
  \[ThreatAssessmentRequestId \<String\>\]: key: id of threatAssessmentRequest
  \[ThreatAssessmentResultId \<String\>\]: key: id of threatAssessmentResult
  \[TokenIssuancePolicyId \<String\>\]: key: id of tokenIssuancePolicy
  \[TokenLifetimePolicyId \<String\>\]: key: id of tokenLifetimePolicy
  \[TrustFrameworkKeySetId \<String\>\]: key: id of trustFrameworkKeySet
  \[TrustFrameworkPolicyId \<String\>\]: key: id of trustFrameworkPolicy
  \[UserId \<String\>\]: key: id of user

LABELACTIONS \<IMicrosoftGraphLabelActionBase\[\]\>: .
  \[Name \<String\>\]: 

SUBLABELS \<IMicrosoftGraphSensitivityLabel\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[ApplicableTo \<String\>\]: sensitivityLabelTarget
  \[ApplicationMode \<String\>\]: applicationMode
  \[AssignedPolicies \<IMicrosoftGraphLabelPolicy\[\]\>\]: 
    \[Id \<String\>\]: 
    \[Name \<String\>\]: 
  \[AutoLabeling \<IMicrosoftGraphAutoLabeling\>\]: autoLabeling
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Message \<String\>\]: 
    \[SensitiveTypeIds \<String\[\]\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsEndpointProtectionEnabled \<Boolean?\>\]: 
  \[LabelActions \<IMicrosoftGraphLabelActionBase\[\]\>\]: 
    \[Name \<String\>\]: 
  \[Name \<String\>\]: 
  \[Priority \<Int32?\>\]: 
  \[Sublabels \<IMicrosoftGraphSensitivityLabel\[\]\>\]: 
  \[ToolTip \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabelsublabel](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mginformationprotectionsensitivitylabelsublabel)

