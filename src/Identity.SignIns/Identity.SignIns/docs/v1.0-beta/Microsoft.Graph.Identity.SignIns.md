---
Module Name: Microsoft.Graph.Identity.SignIns
Module Guid: 8a629b81-efb0-48f0-9be9-141a12a40639
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.SignIns Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.SignIns Cmdlets
### [Confirm-MgRiskyUserCompromised](Confirm-MgRiskyUserCompromised.md)
Invoke action confirmCompromised

### [Get-MgDataPolicyOperation](Get-MgDataPolicyOperation.md)
Get entity from dataPolicyOperations by key

### [Get-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef](Get-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef.md)
Get authenticationContextClassReferences from identity

### [Get-MgIdentityConditionalAccessNamedLocation](Get-MgIdentityConditionalAccessNamedLocation.md)
Get namedLocations from identity

### [Get-MgIdentityConditionalAccessPolicy](Get-MgIdentityConditionalAccessPolicy.md)
Get policies from identity

### [Get-MgIdentityProvider](Get-MgIdentityProvider.md)
Get entity from identityProviders by key

### [Get-MgIdentityUserFlow](Get-MgIdentityUserFlow.md)
Get userFlows from identity

### [Get-MgInformationProtection](Get-MgInformationProtection.md)
Get informationProtection

### [Get-MgInformationProtectionBitlocker](Get-MgInformationProtectionBitlocker.md)
Get bitlocker from informationProtection

### [Get-MgInformationProtectionBitlockerRecoveryKey](Get-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Get-MgInformationProtectionDataLossPreventionPolicy](Get-MgInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from informationProtection

### [Get-MgInformationProtectionPolicy](Get-MgInformationProtectionPolicy.md)
Get policy from informationProtection

### [Get-MgInformationProtectionPolicyLabel](Get-MgInformationProtectionPolicyLabel.md)
Get labels from informationProtection

### [Get-MgInformationProtectionSensitivityPolicySetting](Get-MgInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from informationProtection

### [Get-MgInformationProtectionThreatAssessmentRequest](Get-MgInformationProtectionThreatAssessmentRequest.md)
Get threatAssessmentRequests from informationProtection

### [Get-MgInformationProtectionThreatAssessmentRequestResult](Get-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Get-MgOauth2PermissionGrant](Get-MgOauth2PermissionGrant.md)
Get entity from oauth2PermissionGrants by key

### [Get-MgOauth2PermissionGrantDelta](Get-MgOauth2PermissionGrantDelta.md)
Invoke function delta

### [Get-MgOrganizationCertificateBasedAuthConfiguration](Get-MgOrganizationCertificateBasedAuthConfiguration.md)
Navigation property to manage  certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgOrganizationCertificateBasedAuthConfigurationByRef](Get-MgOrganizationCertificateBasedAuthConfigurationByRef.md)
Navigation property to manage  certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgPolicyAccessReviewPolicy](Get-MgPolicyAccessReviewPolicy.md)
Get accessReviewPolicy from policies

### [Get-MgPolicyActivityBasedTimeoutPolicy](Get-MgPolicyActivityBasedTimeoutPolicy.md)
Get activityBasedTimeoutPolicies from policies

### [Get-MgPolicyAdminConsentRequestPolicy](Get-MgPolicyAdminConsentRequestPolicy.md)
Get adminConsentRequestPolicy from policies

### [Get-MgPolicyAuthenticationFlowPolicy](Get-MgPolicyAuthenticationFlowPolicy.md)
Get authenticationFlowsPolicy from policies

### [Get-MgPolicyAuthenticationMethodPolicy](Get-MgPolicyAuthenticationMethodPolicy.md)
Get authenticationMethodsPolicy from policies

### [Get-MgPolicyAuthorizationPolicy](Get-MgPolicyAuthorizationPolicy.md)
Get authorizationPolicy from policies

### [Get-MgPolicyB2CAuthenticationMethodPolicy](Get-MgPolicyB2CAuthenticationMethodPolicy.md)
Get b2cAuthenticationMethodsPolicy from policies

### [Get-MgPolicyClaimMappingPolicy](Get-MgPolicyClaimMappingPolicy.md)
Get claimsMappingPolicies from policies

### [Get-MgPolicyDirectoryRoleAccessReviewPolicy](Get-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Get directoryRoleAccessReviewPolicy from policies

### [Get-MgPolicyFeatureRolloutPolicy](Get-MgPolicyFeatureRolloutPolicy.md)
Get featureRolloutPolicies from policies

### [Get-MgPolicyFeatureRolloutPolicyApplyTo](Get-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyHomeRealmDiscoveryPolicy](Get-MgPolicyHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from policies

### [Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Get identitySecurityDefaultsEnforcementPolicy from policies

### [Get-MgPolicyPermissionGrantPolicy](Get-MgPolicyPermissionGrantPolicy.md)
Get permissionGrantPolicies from policies

### [Get-MgPolicyPermissionGrantPolicyExclude](Get-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyPermissionGrantPolicyInclude](Get-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyRoleManagementPolicy](Get-MgPolicyRoleManagementPolicy.md)
Get roleManagementPolicies from policies

### [Get-MgPolicyRoleManagementPolicyAssignment](Get-MgPolicyRoleManagementPolicyAssignment.md)
Get roleManagementPolicyAssignments from policies

### [Get-MgPolicyRoleManagementPolicyAssignmentPolicy](Get-MgPolicyRoleManagementPolicyAssignmentPolicy.md)
The policy for the assignment.

### [Get-MgPolicyRoleManagementPolicyAssignmentPolicyByRef](Get-MgPolicyRoleManagementPolicyAssignmentPolicyByRef.md)
The policy for the assignment.

### [Get-MgPolicyRoleManagementPolicyEffectiveRule](Get-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [Get-MgPolicyRoleManagementPolicyRule](Get-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [Get-MgPolicyTokenIssuancePolicy](Get-MgPolicyTokenIssuancePolicy.md)
Get tokenIssuancePolicies from policies

### [Get-MgPolicyTokenLifetimePolicy](Get-MgPolicyTokenLifetimePolicy.md)
Get tokenLifetimePolicies from policies

### [Get-MgRiskDetection](Get-MgRiskDetection.md)
Get entity from riskDetections by key

### [Get-MgRiskyUser](Get-MgRiskyUser.md)
Get entity from riskyUsers by key

### [Get-MgRiskyUserHistory](Get-MgRiskyUserHistory.md)
The activity related to user risk level change

### [Get-MgTrustFramework](Get-MgTrustFramework.md)
Get trustFramework

### [Get-MgTrustFrameworkKeySet](Get-MgTrustFrameworkKeySet.md)
Get keySets from trustFramework

### [Get-MgTrustFrameworkKeySetActiveKey](Get-MgTrustFrameworkKeySetActiveKey.md)
Invoke function getActiveKey

### [Get-MgTrustFrameworkPolicy](Get-MgTrustFrameworkPolicy.md)
Get policies from trustFramework

### [Get-MgTrustFrameworkPolicyContent](Get-MgTrustFrameworkPolicyContent.md)
Get media content for the navigation property policies from trustFramework

### [Get-MgUserAuthenticationEmailMethod](Get-MgUserAuthenticationEmailMethod.md)
Get emailMethods from users

### [Get-MgUserAuthenticationFido2Method](Get-MgUserAuthenticationFido2Method.md)
Get fido2Methods from users

### [Get-MgUserAuthenticationMethod](Get-MgUserAuthenticationMethod.md)
Get methods from users

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Get microsoftAuthenticatorMethods from users

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgUserAuthenticationOperation](Get-MgUserAuthenticationOperation.md)
Get operations from users

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Get passwordlessMicrosoftAuthenticatorMethods from users

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Get device from users

### [Get-MgUserAuthenticationPasswordMethod](Get-MgUserAuthenticationPasswordMethod.md)
Get passwordMethods from users

### [Get-MgUserAuthenticationPhoneMethod](Get-MgUserAuthenticationPhoneMethod.md)
Get phoneMethods from users

### [Get-MgUserAuthenticationTemporaryAccessPassMethod](Get-MgUserAuthenticationTemporaryAccessPassMethod.md)
Get temporaryAccessPassMethods from users

### [Get-MgUserAuthenticationWindowHello](Get-MgUserAuthenticationWindowHello.md)
Get windowsHelloForBusinessMethods from users

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.

### [Get-MgUserInformationProtection](Get-MgUserInformationProtection.md)
Get informationProtection from users

### [Invoke-MgAvailableIdentityProviderType](Invoke-MgAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgBufferInformationProtectionDecrypt](Invoke-MgBufferInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBufferInformationProtectionEncrypt](Invoke-MgBufferInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgDismissRiskyUser](Invoke-MgDismissRiskyUser.md)
Invoke action dismiss

### [Invoke-MgExtractInformationProtectionPolicyLabel](Invoke-MgExtractInformationProtectionPolicyLabel.md)
Invoke action extractLabel

### [Invoke-MgUploadTrustFrameworkKeySetCertificate](Invoke-MgUploadTrustFrameworkKeySetCertificate.md)
Invoke action uploadCertificate

### [Invoke-MgUploadTrustFrameworkKeySetPkcs12](Invoke-MgUploadTrustFrameworkKeySetPkcs12.md)
Invoke action uploadPkcs12

### [Invoke-MgUploadTrustFrameworkKeySetSecret](Invoke-MgUploadTrustFrameworkKeySetSecret.md)
Invoke action uploadSecret

### [New-MgDataPolicyOperation](New-MgDataPolicyOperation.md)
Add new entity to dataPolicyOperations

### [New-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef](New-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef.md)
Create new navigation property to authenticationContextClassReferences for identity

### [New-MgIdentityConditionalAccessNamedLocation](New-MgIdentityConditionalAccessNamedLocation.md)
Create new navigation property to namedLocations for identity

### [New-MgIdentityConditionalAccessPolicy](New-MgIdentityConditionalAccessPolicy.md)
Create new navigation property to policies for identity

### [New-MgIdentityProvider](New-MgIdentityProvider.md)
Add new entity to identityProviders

### [New-MgIdentityUserFlow](New-MgIdentityUserFlow.md)
Create new navigation property to userFlows for identity

### [New-MgInformationProtectionBitlockerRecoveryKey](New-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [New-MgInformationProtectionDataLossPreventionPolicy](New-MgInformationProtectionDataLossPreventionPolicy.md)
Create new navigation property to dataLossPreventionPolicies for informationProtection

### [New-MgInformationProtectionPolicyLabel](New-MgInformationProtectionPolicyLabel.md)
Create new navigation property to labels for informationProtection

### [New-MgInformationProtectionThreatAssessmentRequest](New-MgInformationProtectionThreatAssessmentRequest.md)
Create new navigation property to threatAssessmentRequests for informationProtection

### [New-MgInformationProtectionThreatAssessmentRequestResult](New-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [New-MgInvitation](New-MgInvitation.md)
Add new entity to invitations

### [New-MgOauth2PermissionGrant](New-MgOauth2PermissionGrant.md)
Add new entity to oauth2PermissionGrants

### [New-MgOrganizationCertificateBasedAuthConfigurationByRef](New-MgOrganizationCertificateBasedAuthConfigurationByRef.md)
Navigation property to manage  certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [New-MgPolicyActivityBasedTimeoutPolicy](New-MgPolicyActivityBasedTimeoutPolicy.md)
Create new navigation property to activityBasedTimeoutPolicies for policies

### [New-MgPolicyAuthorizationPolicy](New-MgPolicyAuthorizationPolicy.md)
Create new navigation property to authorizationPolicy for policies

### [New-MgPolicyClaimMappingPolicy](New-MgPolicyClaimMappingPolicy.md)
Create new navigation property to claimsMappingPolicies for policies

### [New-MgPolicyFeatureRolloutPolicy](New-MgPolicyFeatureRolloutPolicy.md)
Create new navigation property to featureRolloutPolicies for policies

### [New-MgPolicyFeatureRolloutPolicyApplyTo](New-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [New-MgPolicyHomeRealmDiscoveryPolicy](New-MgPolicyHomeRealmDiscoveryPolicy.md)
Create new navigation property to homeRealmDiscoveryPolicies for policies

### [New-MgPolicyPermissionGrantPolicy](New-MgPolicyPermissionGrantPolicy.md)
Create new navigation property to permissionGrantPolicies for policies

### [New-MgPolicyPermissionGrantPolicyExclude](New-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyPermissionGrantPolicyInclude](New-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyRoleManagementPolicy](New-MgPolicyRoleManagementPolicy.md)
Create new navigation property to roleManagementPolicies for policies

### [New-MgPolicyRoleManagementPolicyAssignment](New-MgPolicyRoleManagementPolicyAssignment.md)
Create new navigation property to roleManagementPolicyAssignments for policies

### [New-MgPolicyRoleManagementPolicyEffectiveRule](New-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [New-MgPolicyRoleManagementPolicyRule](New-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [New-MgPolicyTokenIssuancePolicy](New-MgPolicyTokenIssuancePolicy.md)
Create new navigation property to tokenIssuancePolicies for policies

### [New-MgPolicyTokenLifetimePolicy](New-MgPolicyTokenLifetimePolicy.md)
Create new navigation property to tokenLifetimePolicies for policies

### [New-MgRiskDetection](New-MgRiskDetection.md)
Add new entity to riskDetections

### [New-MgRiskyUser](New-MgRiskyUser.md)
Add new entity to riskyUsers

### [New-MgRiskyUserHistory](New-MgRiskyUserHistory.md)
The activity related to user risk level change

### [New-MgTrustFrameworkKeySet](New-MgTrustFrameworkKeySet.md)
Create new navigation property to keySets for trustFramework

### [New-MgTrustFrameworkKeySetKey](New-MgTrustFrameworkKeySetKey.md)
Invoke action generateKey

### [New-MgTrustFrameworkPolicy](New-MgTrustFrameworkPolicy.md)
Create new navigation property to policies for trustFramework

### [New-MgUserAuthenticationEmailMethod](New-MgUserAuthenticationEmailMethod.md)
Create new navigation property to emailMethods for users

### [New-MgUserAuthenticationFido2Method](New-MgUserAuthenticationFido2Method.md)
Create new navigation property to fido2Methods for users

### [New-MgUserAuthenticationMethod](New-MgUserAuthenticationMethod.md)
Create new navigation property to methods for users

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethod](New-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Create new navigation property to microsoftAuthenticatorMethods for users

### [New-MgUserAuthenticationOperation](New-MgUserAuthenticationOperation.md)
Create new navigation property to operations for users

### [New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Create new navigation property to passwordlessMicrosoftAuthenticatorMethods for users

### [New-MgUserAuthenticationPhoneMethod](New-MgUserAuthenticationPhoneMethod.md)
Create new navigation property to phoneMethods for users

### [New-MgUserAuthenticationTemporaryAccessPassMethod](New-MgUserAuthenticationTemporaryAccessPassMethod.md)
Create new navigation property to temporaryAccessPassMethods for users

### [New-MgUserAuthenticationWindowHello](New-MgUserAuthenticationWindowHello.md)
Create new navigation property to windowsHelloForBusinessMethods for users

### [Remove-MgDataPolicyOperation](Remove-MgDataPolicyOperation.md)
Delete entity from dataPolicyOperations

### [Remove-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef](Remove-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef.md)
Delete navigation property authenticationContextClassReferences for identity

### [Remove-MgIdentityConditionalAccessNamedLocation](Remove-MgIdentityConditionalAccessNamedLocation.md)
Delete navigation property namedLocations for identity

### [Remove-MgIdentityConditionalAccessPolicy](Remove-MgIdentityConditionalAccessPolicy.md)
Delete navigation property policies for identity

### [Remove-MgIdentityProvider](Remove-MgIdentityProvider.md)
Delete entity from identityProviders

### [Remove-MgIdentityUserFlow](Remove-MgIdentityUserFlow.md)
Delete navigation property userFlows for identity

### [Remove-MgInformationProtectionBitlocker](Remove-MgInformationProtectionBitlocker.md)
Delete navigation property bitlocker for informationProtection

### [Remove-MgInformationProtectionBitlockerRecoveryKey](Remove-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Remove-MgInformationProtectionDataLossPreventionPolicy](Remove-MgInformationProtectionDataLossPreventionPolicy.md)
Delete navigation property dataLossPreventionPolicies for informationProtection

### [Remove-MgInformationProtectionPolicy](Remove-MgInformationProtectionPolicy.md)
Delete navigation property policy for informationProtection

### [Remove-MgInformationProtectionPolicyLabel](Remove-MgInformationProtectionPolicyLabel.md)
Delete navigation property labels for informationProtection

### [Remove-MgInformationProtectionSensitivityPolicySetting](Remove-MgInformationProtectionSensitivityPolicySetting.md)
Delete navigation property sensitivityPolicySettings for informationProtection

### [Remove-MgInformationProtectionThreatAssessmentRequest](Remove-MgInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for informationProtection

### [Remove-MgInformationProtectionThreatAssessmentRequestResult](Remove-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Remove-MgOauth2PermissionGrant](Remove-MgOauth2PermissionGrant.md)
Delete entity from oauth2PermissionGrants

### [Remove-MgPolicyAccessReviewPolicy](Remove-MgPolicyAccessReviewPolicy.md)
Delete navigation property accessReviewPolicy for policies

### [Remove-MgPolicyActivityBasedTimeoutPolicy](Remove-MgPolicyActivityBasedTimeoutPolicy.md)
Delete navigation property activityBasedTimeoutPolicies for policies

### [Remove-MgPolicyAdminConsentRequestPolicy](Remove-MgPolicyAdminConsentRequestPolicy.md)
Delete navigation property adminConsentRequestPolicy for policies

### [Remove-MgPolicyAuthenticationFlowPolicy](Remove-MgPolicyAuthenticationFlowPolicy.md)
Delete navigation property authenticationFlowsPolicy for policies

### [Remove-MgPolicyAuthenticationMethodPolicy](Remove-MgPolicyAuthenticationMethodPolicy.md)
Delete navigation property authenticationMethodsPolicy for policies

### [Remove-MgPolicyAuthorizationPolicy](Remove-MgPolicyAuthorizationPolicy.md)
Delete navigation property authorizationPolicy for policies

### [Remove-MgPolicyB2CAuthenticationMethodPolicy](Remove-MgPolicyB2CAuthenticationMethodPolicy.md)
Delete navigation property b2cAuthenticationMethodsPolicy for policies

### [Remove-MgPolicyClaimMappingPolicy](Remove-MgPolicyClaimMappingPolicy.md)
Delete navigation property claimsMappingPolicies for policies

### [Remove-MgPolicyDirectoryRoleAccessReviewPolicy](Remove-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Delete navigation property directoryRoleAccessReviewPolicy for policies

### [Remove-MgPolicyFeatureRolloutPolicy](Remove-MgPolicyFeatureRolloutPolicy.md)
Delete navigation property featureRolloutPolicies for policies

### [Remove-MgPolicyFeatureRolloutPolicyApplyTo](Remove-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Remove-MgPolicyHomeRealmDiscoveryPolicy](Remove-MgPolicyHomeRealmDiscoveryPolicy.md)
Delete navigation property homeRealmDiscoveryPolicies for policies

### [Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Delete navigation property identitySecurityDefaultsEnforcementPolicy for policies

### [Remove-MgPolicyPermissionGrantPolicy](Remove-MgPolicyPermissionGrantPolicy.md)
Delete navigation property permissionGrantPolicies for policies

### [Remove-MgPolicyPermissionGrantPolicyExclude](Remove-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyPermissionGrantPolicyInclude](Remove-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyRoleManagementPolicy](Remove-MgPolicyRoleManagementPolicy.md)
Delete navigation property roleManagementPolicies for policies

### [Remove-MgPolicyRoleManagementPolicyAssignment](Remove-MgPolicyRoleManagementPolicyAssignment.md)
Delete navigation property roleManagementPolicyAssignments for policies

### [Remove-MgPolicyRoleManagementPolicyAssignmentPolicyByRef](Remove-MgPolicyRoleManagementPolicyAssignmentPolicyByRef.md)
The policy for the assignment.

### [Remove-MgPolicyRoleManagementPolicyEffectiveRule](Remove-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [Remove-MgPolicyRoleManagementPolicyRule](Remove-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [Remove-MgPolicyTokenIssuancePolicy](Remove-MgPolicyTokenIssuancePolicy.md)
Delete navigation property tokenIssuancePolicies for policies

### [Remove-MgPolicyTokenLifetimePolicy](Remove-MgPolicyTokenLifetimePolicy.md)
Delete navigation property tokenLifetimePolicies for policies

### [Remove-MgRiskDetection](Remove-MgRiskDetection.md)
Delete entity from riskDetections

### [Remove-MgRiskyUser](Remove-MgRiskyUser.md)
Delete entity from riskyUsers

### [Remove-MgRiskyUserHistory](Remove-MgRiskyUserHistory.md)
The activity related to user risk level change

### [Remove-MgTrustFrameworkKeySet](Remove-MgTrustFrameworkKeySet.md)
Delete navigation property keySets for trustFramework

### [Remove-MgTrustFrameworkPolicy](Remove-MgTrustFrameworkPolicy.md)
Delete navigation property policies for trustFramework

### [Remove-MgUserAuthenticationEmailMethod](Remove-MgUserAuthenticationEmailMethod.md)
Delete navigation property emailMethods for users

### [Remove-MgUserAuthenticationFido2Method](Remove-MgUserAuthenticationFido2Method.md)
Delete navigation property fido2Methods for users

### [Remove-MgUserAuthenticationMethod](Remove-MgUserAuthenticationMethod.md)
Delete navigation property methods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Delete navigation property microsoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Remove-MgUserAuthenticationOperation](Remove-MgUserAuthenticationOperation.md)
Delete navigation property operations for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Delete navigation property passwordlessMicrosoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Delete navigation property device for users

### [Remove-MgUserAuthenticationPasswordMethod](Remove-MgUserAuthenticationPasswordMethod.md)
Delete navigation property passwordMethods for users

### [Remove-MgUserAuthenticationPhoneMethod](Remove-MgUserAuthenticationPhoneMethod.md)
Delete navigation property phoneMethods for users

### [Remove-MgUserAuthenticationTemporaryAccessPassMethod](Remove-MgUserAuthenticationTemporaryAccessPassMethod.md)
Delete navigation property temporaryAccessPassMethods for users

### [Remove-MgUserAuthenticationWindowHello](Remove-MgUserAuthenticationWindowHello.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.

### [Remove-MgUserInformationProtection](Remove-MgUserInformationProtection.md)
Delete navigation property informationProtection for users

### [Set-MgPolicyRoleManagementPolicyAssignmentPolicyByRef](Set-MgPolicyRoleManagementPolicyAssignmentPolicyByRef.md)
The policy for the assignment.

### [Set-MgTrustFrameworkPolicyContent](Set-MgTrustFrameworkPolicyContent.md)
Update media content for the navigation property policies in trustFramework

### [Test-MgInformationProtectionDataLossPreventionPolicy](Test-MgInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgInformationProtectionPolicyLabelApplication](Test-MgInformationProtectionPolicyLabelApplication.md)
Invoke action evaluateApplication

### [Test-MgInformationProtectionPolicyLabelClassificationResult](Test-MgInformationProtectionPolicyLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgInformationProtectionPolicyLabelRemoval](Test-MgInformationProtectionPolicyLabelRemoval.md)
Invoke action evaluateRemoval

### [Update-MgDataPolicyOperation](Update-MgDataPolicyOperation.md)
Update entity in dataPolicyOperations

### [Update-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef](Update-MgIdentityConditionalAccessAuthenticationContextClasserenceByRef.md)
Update the navigation property authenticationContextClassReferences in identity

### [Update-MgIdentityConditionalAccessNamedLocation](Update-MgIdentityConditionalAccessNamedLocation.md)
Update the navigation property namedLocations in identity

### [Update-MgIdentityConditionalAccessPolicy](Update-MgIdentityConditionalAccessPolicy.md)
Update the navigation property policies in identity

### [Update-MgIdentityProvider](Update-MgIdentityProvider.md)
Update entity in identityProviders

### [Update-MgIdentityUserFlow](Update-MgIdentityUserFlow.md)
Update the navigation property userFlows in identity

### [Update-MgInformationProtection](Update-MgInformationProtection.md)
Update informationProtection

### [Update-MgInformationProtectionBitlocker](Update-MgInformationProtectionBitlocker.md)
Update the navigation property bitlocker in informationProtection

### [Update-MgInformationProtectionBitlockerRecoveryKey](Update-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Update-MgInformationProtectionDataLossPreventionPolicy](Update-MgInformationProtectionDataLossPreventionPolicy.md)
Update the navigation property dataLossPreventionPolicies in informationProtection

### [Update-MgInformationProtectionPolicy](Update-MgInformationProtectionPolicy.md)
Update the navigation property policy in informationProtection

### [Update-MgInformationProtectionPolicyLabel](Update-MgInformationProtectionPolicyLabel.md)
Update the navigation property labels in informationProtection

### [Update-MgInformationProtectionSensitivityPolicySetting](Update-MgInformationProtectionSensitivityPolicySetting.md)
Update the navigation property sensitivityPolicySettings in informationProtection

### [Update-MgInformationProtectionThreatAssessmentRequest](Update-MgInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in informationProtection

### [Update-MgInformationProtectionThreatAssessmentRequestResult](Update-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Update-MgOauth2PermissionGrant](Update-MgOauth2PermissionGrant.md)
Update entity in oauth2PermissionGrants

### [Update-MgPolicyAccessReviewPolicy](Update-MgPolicyAccessReviewPolicy.md)
Update the navigation property accessReviewPolicy in policies

### [Update-MgPolicyActivityBasedTimeoutPolicy](Update-MgPolicyActivityBasedTimeoutPolicy.md)
Update the navigation property activityBasedTimeoutPolicies in policies

### [Update-MgPolicyAdminConsentRequestPolicy](Update-MgPolicyAdminConsentRequestPolicy.md)
Update the navigation property adminConsentRequestPolicy in policies

### [Update-MgPolicyAuthenticationFlowPolicy](Update-MgPolicyAuthenticationFlowPolicy.md)
Update the navigation property authenticationFlowsPolicy in policies

### [Update-MgPolicyAuthenticationMethodPolicy](Update-MgPolicyAuthenticationMethodPolicy.md)
Update the navigation property authenticationMethodsPolicy in policies

### [Update-MgPolicyAuthorizationPolicy](Update-MgPolicyAuthorizationPolicy.md)
Update the navigation property authorizationPolicy in policies

### [Update-MgPolicyB2CAuthenticationMethodPolicy](Update-MgPolicyB2CAuthenticationMethodPolicy.md)
Update the navigation property b2cAuthenticationMethodsPolicy in policies

### [Update-MgPolicyClaimMappingPolicy](Update-MgPolicyClaimMappingPolicy.md)
Update the navigation property claimsMappingPolicies in policies

### [Update-MgPolicyDirectoryRoleAccessReviewPolicy](Update-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Update the navigation property directoryRoleAccessReviewPolicy in policies

### [Update-MgPolicyFeatureRolloutPolicy](Update-MgPolicyFeatureRolloutPolicy.md)
Update the navigation property featureRolloutPolicies in policies

### [Update-MgPolicyFeatureRolloutPolicyApplyTo](Update-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Update-MgPolicyHomeRealmDiscoveryPolicy](Update-MgPolicyHomeRealmDiscoveryPolicy.md)
Update the navigation property homeRealmDiscoveryPolicies in policies

### [Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Update the navigation property identitySecurityDefaultsEnforcementPolicy in policies

### [Update-MgPolicyPermissionGrantPolicy](Update-MgPolicyPermissionGrantPolicy.md)
Update the navigation property permissionGrantPolicies in policies

### [Update-MgPolicyPermissionGrantPolicyExclude](Update-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyPermissionGrantPolicyInclude](Update-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyRoleManagementPolicy](Update-MgPolicyRoleManagementPolicy.md)
Update the navigation property roleManagementPolicies in policies

### [Update-MgPolicyRoleManagementPolicyAssignment](Update-MgPolicyRoleManagementPolicyAssignment.md)
Update the navigation property roleManagementPolicyAssignments in policies

### [Update-MgPolicyRoleManagementPolicyEffectiveRule](Update-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [Update-MgPolicyRoleManagementPolicyRule](Update-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [Update-MgPolicyTokenIssuancePolicy](Update-MgPolicyTokenIssuancePolicy.md)
Update the navigation property tokenIssuancePolicies in policies

### [Update-MgPolicyTokenLifetimePolicy](Update-MgPolicyTokenLifetimePolicy.md)
Update the navigation property tokenLifetimePolicies in policies

### [Update-MgRiskDetection](Update-MgRiskDetection.md)
Update entity in riskDetections

### [Update-MgRiskyUser](Update-MgRiskyUser.md)
Update entity in riskyUsers

### [Update-MgRiskyUserHistory](Update-MgRiskyUserHistory.md)
The activity related to user risk level change

### [Update-MgTrustFramework](Update-MgTrustFramework.md)
Update trustFramework

### [Update-MgTrustFrameworkKeySet](Update-MgTrustFrameworkKeySet.md)
Update the navigation property keySets in trustFramework

### [Update-MgTrustFrameworkPolicy](Update-MgTrustFrameworkPolicy.md)
Update the navigation property policies in trustFramework

### [Update-MgUserAuthenticationEmailMethod](Update-MgUserAuthenticationEmailMethod.md)
Update the navigation property emailMethods in users

### [Update-MgUserAuthenticationFido2Method](Update-MgUserAuthenticationFido2Method.md)
Update the navigation property fido2Methods in users

### [Update-MgUserAuthenticationMethod](Update-MgUserAuthenticationMethod.md)
Update the navigation property methods in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethod](Update-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Update the navigation property microsoftAuthenticatorMethods in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Update-MgUserAuthenticationOperation](Update-MgUserAuthenticationOperation.md)
Update the navigation property operations in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Update the navigation property passwordlessMicrosoftAuthenticatorMethods in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Update the navigation property device in users

### [Update-MgUserAuthenticationPhoneMethod](Update-MgUserAuthenticationPhoneMethod.md)
Update the navigation property phoneMethods in users

### [Update-MgUserAuthenticationTemporaryAccessPassMethod](Update-MgUserAuthenticationTemporaryAccessPassMethod.md)
Update the navigation property temporaryAccessPassMethods in users

### [Update-MgUserAuthenticationWindowHello](Update-MgUserAuthenticationWindowHello.md)
Update the navigation property windowsHelloForBusinessMethods in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.

### [Update-MgUserInformationProtection](Update-MgUserInformationProtection.md)
Update the navigation property informationProtection in users

