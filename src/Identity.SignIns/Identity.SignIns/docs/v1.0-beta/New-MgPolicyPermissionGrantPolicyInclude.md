---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mgpolicypermissiongrantpolicyinclude
schema: 2.0.0
---

# New-MgBetaPolicyPermissionGrantPolicyInclude

## SYNOPSIS
Add conditions under which a permission grant event is *included* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **includes** collection of a  permissionGrantPolicy.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId <String> [-AdditionalProperties <Hashtable>]
 [-CertifiedClientApplicationsOnly] [-ClientApplicationIds <String[]>]
 [-ClientApplicationPublisherIds <String[]>] [-ClientApplicationsFromVerifiedPublisherOnly]
 [-ClientApplicationTenantIds <String[]>] [-Id <String>] [-PermissionClassification <String>]
 [-Permissions <String[]>] [-PermissionType <String>] [-ResourceApplication <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId <String>
 -BodyParameter <IMicrosoftGraphPermissionGrantConditionSet1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaPolicyPermissionGrantPolicyInclude -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphPermissionGrantConditionSet1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaPolicyPermissionGrantPolicyInclude -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-CertifiedClientApplicationsOnly] [-ClientApplicationIds <String[]>]
 [-ClientApplicationPublisherIds <String[]>] [-ClientApplicationsFromVerifiedPublisherOnly]
 [-ClientApplicationTenantIds <String[]>] [-Id <String>] [-PermissionClassification <String>]
 [-Permissions <String[]>] [-PermissionType <String>] [-ResourceApplication <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add conditions under which a permission grant event is *included* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **includes** collection of a  permissionGrantPolicy.

## EXAMPLES

### Example 1: Create a permission grant policy include 
```powershell
Connect-MgBetaGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
New-MgBetaPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId "testtenant-sampleapp-permissions" -PermissionType "application" -ResourceApplication "00000000-0000-0000-0000-000000000000" -Permissions "00000000-0000-0000-0000-000000000000"  | fl

ClientApplicationIds                        : {all}
ClientApplicationPublisherIds               : {all}
ClientApplicationTenantIds                  : {all}
ClientApplicationsFromVerifiedPublisherOnly : False
Id                                          : 084b9abc-cf56-4d84-bdb0-5ad8f3a51038
PermissionClassification                    : all
PermissionType                              : application
Permissions                                 : {00000000-0000-0000-0000-000000000000}
ResourceApplication                         : 00000000-0000-0000-0000-000000000000
AdditionalProperties                        : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/permissionGrantPolicies('testtenant-sampleapp-permissions')/includes/$entity]}
```

This command creates a new permission grant policy include configuration for the specified permission grant policy in Azure AD.

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
permissionGrantConditionSet
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet1
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertifiedClientApplicationsOnly
Set to true to only match on client applications that are Microsoft 365 certified.
Set to false to match on any other client app.
Default is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientApplicationIds
A list of appId values for the client applications to match with, or a list with the single value all to match any client application.
Default is the single value all.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientApplicationPublisherIds
A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher.
Default is the single value all.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientApplicationsFromVerifiedPublisherOnly
Set to true to only match on client applications with a verified publisher.
Set to false to match on any client app, even if it does not have a verified publisher.
Default is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientApplicationTenantIds
A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant.
Default is the single value all.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PermissionClassification
The permission classification for the permission being granted, or all to match with any permission classification (including permissions which are not classified).
Default is all.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionGrantPolicyId
key: id of permissionGrantPolicy

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Permissions
The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission.
The id of delegated permissions can be found in the publishedPermissionScopes property of the API's **servicePrincipal** object.
The id of application permissions can be found in the appRoles property of the API's **servicePrincipal** object.
The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's **servicePrincipal** object.
Default is the single value all.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionType
permissionType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceApplication
The appId of the resource application (e.g.
the API) for which a permission is being granted, or any to match with any resource application or API.
Default is any.

```yaml
Type: System.String
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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet1

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPermissionGrantConditionSet1>: permissionGrantConditionSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CertifiedClientApplicationsOnly <Boolean?>]`: Set to true to only match on client applications that are Microsoft 365 certified. Set to false to match on any other client app. Default is false.
  - `[ClientApplicationIds <String[]>]`: A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.
  - `[ClientApplicationPublisherIds <String[]>]`: A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.
  - `[ClientApplicationTenantIds <String[]>]`: A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.
  - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it does not have a verified publisher. Default is false.
  - `[PermissionClassification <String>]`: The permission classification for the permission being granted, or all to match with any permission classification (including permissions which are not classified). Default is all.
  - `[PermissionType <String>]`: permissionType
  - `[Permissions <String[]>]`: The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the publishedPermissionScopes property of the API's **servicePrincipal** object. The id of application permissions can be found in the appRoles property of the API's **servicePrincipal** object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's **servicePrincipal** object. Default is the single value all.
  - `[ResourceApplication <String>]`: The appId of the resource application (e.g. the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AuthenticationCombinationConfigurationId <String>]`: key: id of authenticationCombinationConfiguration
  - `[AuthenticationContextClassReferenceId <String>]`: key: id of authenticationContextClassReference
  - `[AuthenticationEventListenerId <String>]`: key: id of authenticationEventListener
  - `[AuthenticationMethodConfigurationId <String>]`: key: id of authenticationMethodConfiguration
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthenticationMethodModeDetailId <String>]`: key: id of authenticationMethodModeDetail
  - `[AuthenticationMethodModes <String[]>]`: Usage: authenticationMethodModes={authenticationMethodModes}
  - `[AuthenticationStrengthPolicyId <String>]`: key: id of authenticationStrengthPolicy
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[B2CIdentityUserFlowId <String>]`: key: id of b2cIdentityUserFlow
  - `[B2XIdentityUserFlowId <String>]`: key: id of b2xIdentityUserFlow
  - `[BitlockerRecoveryKeyId <String>]`: key: id of bitlockerRecoveryKey
  - `[CertificateBasedAuthConfigurationId <String>]`: key: id of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[CommandId <String>]`: key: id of command
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[ConditionalAccessTemplateId <String>]`: key: id of conditionalAccessTemplate
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: key: tenantId of crossTenantAccessPolicyConfigurationPartner
  - `[CustomAuthenticationExtensionId <String>]`: key: id of customAuthenticationExtension
  - `[DataLossPreventionPolicyId <String>]`: key: id of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: key: id of dataPolicyOperation
  - `[DefaultUserRoleOverrideId <String>]`: key: id of defaultUserRoleOverride
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EmailAuthenticationMethodId <String>]`: key: id of emailAuthenticationMethod
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[Fido2AuthenticationMethodId <String>]`: key: id of fido2AuthenticationMethod
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[IdentityApiConnectorId <String>]`: key: id of identityApiConnector
  - `[IdentityProviderBaseId <String>]`: key: id of identityProviderBase
  - `[IdentityProviderId <String>]`: key: id of identityProvider
  - `[IdentityUserFlowAttributeAssignmentId <String>]`: key: id of identityUserFlowAttributeAssignment
  - `[IdentityUserFlowAttributeId <String>]`: key: id of identityUserFlowAttribute
  - `[IdentityUserFlowId <String>]`: key: id of identityUserFlow
  - `[InformationProtectionLabelId <String>]`: key: id of informationProtectionLabel
  - `[LongRunningOperationId <String>]`: key: id of longRunningOperation
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of microsoftAuthenticatorAuthenticationMethod
  - `[MobilityManagementPolicyId <String>]`: key: id of mobilityManagementPolicy
  - `[NamedLocationId <String>]`: key: id of namedLocation
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OrganizationId <String>]`: key: id of organization
  - `[PasswordAuthenticationMethodId <String>]`: key: id of passwordAuthenticationMethod
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionGrantConditionSetId <String>]`: key: id of permissionGrantConditionSet
  - `[PermissionGrantPolicyId <String>]`: key: id of permissionGrantPolicy
  - `[PhoneAuthenticationMethodId <String>]`: key: id of phoneAuthenticationMethod
  - `[RiskDetectionId <String>]`: key: id of riskDetection
  - `[RiskyServicePrincipalHistoryItemId <String>]`: key: id of riskyServicePrincipalHistoryItem
  - `[RiskyServicePrincipalId <String>]`: key: id of riskyServicePrincipal
  - `[RiskyUserHistoryItemId <String>]`: key: id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: id of riskyUser
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: key: id of sensitivityLabel
  - `[ServicePrincipalCreationConditionSetId <String>]`: key: id of servicePrincipalCreationConditionSet
  - `[ServicePrincipalCreationPolicyId <String>]`: key: id of servicePrincipalCreationPolicy
  - `[ServicePrincipalRiskDetectionId <String>]`: key: id of servicePrincipalRiskDetection
  - `[SoftwareOathAuthenticationMethodId <String>]`: key: id of softwareOathAuthenticationMethod
  - `[TemporaryAccessPassAuthenticationMethodId <String>]`: key: id of temporaryAccessPassAuthenticationMethod
  - `[ThreatAssessmentRequestId <String>]`: key: id of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: key: id of threatAssessmentResult
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[TrustFrameworkKeySetId <String>]`: key: id of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: key: id of trustFrameworkPolicy
  - `[UnifiedRoleManagementPolicyAssignmentId <String>]`: key: id of unifiedRoleManagementPolicyAssignment
  - `[UnifiedRoleManagementPolicyId <String>]`: key: id of unifiedRoleManagementPolicy
  - `[UnifiedRoleManagementPolicyRuleId <String>]`: key: id of unifiedRoleManagementPolicyRule
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserFlowLanguageConfigurationId <String>]`: key: id of userFlowLanguageConfiguration
  - `[UserFlowLanguagePageId <String>]`: key: id of userFlowLanguagePage
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

