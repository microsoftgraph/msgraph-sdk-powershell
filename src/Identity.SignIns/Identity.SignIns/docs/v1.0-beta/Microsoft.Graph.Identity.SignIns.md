---
Module Name: Microsoft.Graph.Identity.SignIns
Module Guid: 02dfc556-f41b-422b-a074-d20c0784c981
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.SignIns Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.SignIns Cmdlets
### [Confirm-MgInformationProtectionSignature](Confirm-MgInformationProtectionSignature.md)
Invoke action verifySignature

### [Confirm-MgRiskyUserCompromised](Confirm-MgRiskyUserCompromised.md)
Invoke action confirmCompromised

### [Get-MgDataPolicyOperation](Get-MgDataPolicyOperation.md)
Get entity from dataPolicyOperations by key

### [Get-MgIdentityConditionalAccessAuthenticationContextClassReference](Get-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [Get-MgIdentityConditionalAccessNamedLocation](Get-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Get-MgIdentityConditionalAccessPolicy](Get-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access (CA) policies.

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
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgOrganizationCertificateBasedAuthConfigurationByRef](Get-MgOrganizationCertificateBasedAuthConfigurationByRef.md)
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgPolicyAccessReviewPolicy](Get-MgPolicyAccessReviewPolicy.md)
The policy that contains directory-level access review settings.

### [Get-MgPolicyActivityBasedTimeoutPolicy](Get-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Get-MgPolicyAdminConsentRequestPolicy](Get-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Get-MgPolicyAppManagementPolicy](Get-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Get-MgPolicyAppManagementPolicyApplyTo](Get-MgPolicyAppManagementPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgPolicyAppManagementPolicyApplyToByRef](Get-MgPolicyAppManagementPolicyApplyToByRef.md)
Get ref of appliesTo from policies

### [Get-MgPolicyAuthenticationFlowPolicy](Get-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Get-MgPolicyAuthenticationMethodPolicy](Get-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Get-MgPolicyAuthorizationPolicy](Get-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Get-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Get-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Get defaultUserRoleOverrides from policies

### [Get-MgPolicyB2CAuthenticationMethodPolicy](Get-MgPolicyB2CAuthenticationMethodPolicy.md)
The Azure AD B2C policies that define how end users register via local accounts.

### [Get-MgPolicyClaimMappingPolicy](Get-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Get-MgPolicyCrossTenantAccessPolicy](Get-MgPolicyCrossTenantAccessPolicy.md)
The custom rules that define an access scenario when interacting with external Azure AD tenants.

### [Get-MgPolicyCrossTenantAccessPolicyDefault](Get-MgPolicyCrossTenantAccessPolicyDefault.md)
Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.

### [Get-MgPolicyCrossTenantAccessPolicyPartner](Get-MgPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [Get-MgPolicyDefaultAppManagementPolicy](Get-MgPolicyDefaultAppManagementPolicy.md)
The tenant-wide policy that enforces app management restrictions for all applications and service principals.

### [Get-MgPolicyDirectoryRoleAccessReviewPolicy](Get-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Get directoryRoleAccessReviewPolicy from policies

### [Get-MgPolicyExternalIdentityPolicy](Get-MgPolicyExternalIdentityPolicy.md)
Get externalIdentitiesPolicy from policies

### [Get-MgPolicyFeatureRolloutPolicy](Get-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Get-MgPolicyFeatureRolloutPolicyApplyTo](Get-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyHomeRealmDiscoveryPolicy](Get-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Get-MgPolicyMobileAppManagementPolicy](Get-MgPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [Get-MgPolicyMobileDeviceManagementPolicy](Get-MgPolicyMobileDeviceManagementPolicy.md)
Get mobileDeviceManagementPolicies from policies

### [Get-MgPolicyPermissionGrantPolicy](Get-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Get-MgPolicyPermissionGrantPolicyExclude](Get-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyPermissionGrantPolicyInclude](Get-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyRoleManagementPolicy](Get-MgPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [Get-MgPolicyRoleManagementPolicyAssignment](Get-MgPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

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

### [Get-MgPolicyServicePrincipalCreationPolicy](Get-MgPolicyServicePrincipalCreationPolicy.md)
Get servicePrincipalCreationPolicies from policies

### [Get-MgPolicyServicePrincipalCreationPolicyExclude](Get-MgPolicyServicePrincipalCreationPolicyExclude.md)
Get excludes from policies

### [Get-MgPolicyServicePrincipalCreationPolicyInclude](Get-MgPolicyServicePrincipalCreationPolicyInclude.md)
Get includes from policies

### [Get-MgPolicyTokenIssuancePolicy](Get-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Get-MgPolicyTokenLifetimePolicy](Get-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

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

### [Get-MgUserAuthenticationSoftwareOathMethod](Get-MgUserAuthenticationSoftwareOathMethod.md)
Get softwareOathMethods from users

### [Get-MgUserAuthenticationTemporaryAccessPassMethod](Get-MgUserAuthenticationTemporaryAccessPassMethod.md)
Get temporaryAccessPassMethods from users

### [Get-MgUserAuthenticationWindowHello](Get-MgUserAuthenticationWindowHello.md)
Get windowsHelloForBusinessMethods from users

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

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

### [Invoke-MgSignInformationProtectionDigest](Invoke-MgSignInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgUploadTrustFrameworkKeySetCertificate](Invoke-MgUploadTrustFrameworkKeySetCertificate.md)
Invoke action uploadCertificate

### [Invoke-MgUploadTrustFrameworkKeySetPkcs12](Invoke-MgUploadTrustFrameworkKeySetPkcs12.md)
Invoke action uploadPkcs12

### [Invoke-MgUploadTrustFrameworkKeySetSecret](Invoke-MgUploadTrustFrameworkKeySetSecret.md)
Invoke action uploadSecret

### [New-MgDataPolicyOperation](New-MgDataPolicyOperation.md)
Add new entity to dataPolicyOperations

### [New-MgIdentityConditionalAccessAuthenticationContextClassReference](New-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [New-MgIdentityConditionalAccessNamedLocation](New-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [New-MgIdentityConditionalAccessPolicy](New-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access (CA) policies.

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
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [New-MgPolicyActivityBasedTimeoutPolicy](New-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [New-MgPolicyAppManagementPolicy](New-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [New-MgPolicyAppManagementPolicyApplyToByRef](New-MgPolicyAppManagementPolicyApplyToByRef.md)
Create new navigation property ref to appliesTo for policies

### [New-MgPolicyAuthorizationPolicy](New-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [New-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](New-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Create new navigation property to defaultUserRoleOverrides for policies

### [New-MgPolicyClaimMappingPolicy](New-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [New-MgPolicyCrossTenantAccessPolicyPartner](New-MgPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [New-MgPolicyFeatureRolloutPolicy](New-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [New-MgPolicyFeatureRolloutPolicyApplyTo](New-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [New-MgPolicyHomeRealmDiscoveryPolicy](New-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [New-MgPolicyMobileAppManagementPolicy](New-MgPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [New-MgPolicyMobileDeviceManagementPolicy](New-MgPolicyMobileDeviceManagementPolicy.md)
Create new navigation property to mobileDeviceManagementPolicies for policies

### [New-MgPolicyPermissionGrantPolicy](New-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [New-MgPolicyPermissionGrantPolicyExclude](New-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyPermissionGrantPolicyInclude](New-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyRoleManagementPolicy](New-MgPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [New-MgPolicyRoleManagementPolicyAssignment](New-MgPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

### [New-MgPolicyRoleManagementPolicyEffectiveRule](New-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [New-MgPolicyRoleManagementPolicyRule](New-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [New-MgPolicyServicePrincipalCreationPolicy](New-MgPolicyServicePrincipalCreationPolicy.md)
Create new navigation property to servicePrincipalCreationPolicies for policies

### [New-MgPolicyServicePrincipalCreationPolicyExclude](New-MgPolicyServicePrincipalCreationPolicyExclude.md)
Create new navigation property to excludes for policies

### [New-MgPolicyServicePrincipalCreationPolicyInclude](New-MgPolicyServicePrincipalCreationPolicyInclude.md)
Create new navigation property to includes for policies

### [New-MgPolicyTokenIssuancePolicy](New-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [New-MgPolicyTokenLifetimePolicy](New-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

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

### [New-MgUserAuthenticationSoftwareOathMethod](New-MgUserAuthenticationSoftwareOathMethod.md)
Create new navigation property to softwareOathMethods for users

### [New-MgUserAuthenticationTemporaryAccessPassMethod](New-MgUserAuthenticationTemporaryAccessPassMethod.md)
Create new navigation property to temporaryAccessPassMethods for users

### [New-MgUserAuthenticationWindowHello](New-MgUserAuthenticationWindowHello.md)
Create new navigation property to windowsHelloForBusinessMethods for users

### [Remove-MgDataPolicyOperation](Remove-MgDataPolicyOperation.md)
Delete entity from dataPolicyOperations

### [Remove-MgIdentityConditionalAccessAuthenticationContextClassReference](Remove-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [Remove-MgIdentityConditionalAccessNamedLocation](Remove-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Remove-MgIdentityConditionalAccessPolicy](Remove-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access (CA) policies.

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
The policy that contains directory-level access review settings.

### [Remove-MgPolicyActivityBasedTimeoutPolicy](Remove-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Remove-MgPolicyAdminConsentRequestPolicy](Remove-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Remove-MgPolicyAppManagementPolicy](Remove-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Remove-MgPolicyAuthenticationFlowPolicy](Remove-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Remove-MgPolicyAuthenticationMethodPolicy](Remove-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Remove-MgPolicyAuthorizationPolicy](Remove-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Remove-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Remove-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Delete navigation property defaultUserRoleOverrides for policies

### [Remove-MgPolicyB2CAuthenticationMethodPolicy](Remove-MgPolicyB2CAuthenticationMethodPolicy.md)
The Azure AD B2C policies that define how end users register via local accounts.

### [Remove-MgPolicyClaimMappingPolicy](Remove-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Remove-MgPolicyCrossTenantAccessPolicy](Remove-MgPolicyCrossTenantAccessPolicy.md)
The custom rules that define an access scenario when interacting with external Azure AD tenants.

### [Remove-MgPolicyCrossTenantAccessPolicyDefault](Remove-MgPolicyCrossTenantAccessPolicyDefault.md)
Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.

### [Remove-MgPolicyCrossTenantAccessPolicyPartner](Remove-MgPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [Remove-MgPolicyDefaultAppManagementPolicy](Remove-MgPolicyDefaultAppManagementPolicy.md)
The tenant-wide policy that enforces app management restrictions for all applications and service principals.

### [Remove-MgPolicyDirectoryRoleAccessReviewPolicy](Remove-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Delete navigation property directoryRoleAccessReviewPolicy for policies

### [Remove-MgPolicyExternalIdentityPolicy](Remove-MgPolicyExternalIdentityPolicy.md)
Delete navigation property externalIdentitiesPolicy for policies

### [Remove-MgPolicyFeatureRolloutPolicy](Remove-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Remove-MgPolicyFeatureRolloutPolicyApplyTo](Remove-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Remove-MgPolicyHomeRealmDiscoveryPolicy](Remove-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Remove-MgPolicyMobileAppManagementPolicy](Remove-MgPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [Remove-MgPolicyMobileDeviceManagementPolicy](Remove-MgPolicyMobileDeviceManagementPolicy.md)
Delete navigation property mobileDeviceManagementPolicies for policies

### [Remove-MgPolicyPermissionGrantPolicy](Remove-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Remove-MgPolicyPermissionGrantPolicyExclude](Remove-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyPermissionGrantPolicyInclude](Remove-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyRoleManagementPolicy](Remove-MgPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [Remove-MgPolicyRoleManagementPolicyAssignment](Remove-MgPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

### [Remove-MgPolicyRoleManagementPolicyAssignmentPolicyByRef](Remove-MgPolicyRoleManagementPolicyAssignmentPolicyByRef.md)
The policy for the assignment.

### [Remove-MgPolicyRoleManagementPolicyEffectiveRule](Remove-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [Remove-MgPolicyRoleManagementPolicyRule](Remove-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [Remove-MgPolicyServicePrincipalCreationPolicy](Remove-MgPolicyServicePrincipalCreationPolicy.md)
Delete navigation property servicePrincipalCreationPolicies for policies

### [Remove-MgPolicyServicePrincipalCreationPolicyExclude](Remove-MgPolicyServicePrincipalCreationPolicyExclude.md)
Delete navigation property excludes for policies

### [Remove-MgPolicyServicePrincipalCreationPolicyInclude](Remove-MgPolicyServicePrincipalCreationPolicyInclude.md)
Delete navigation property includes for policies

### [Remove-MgPolicyTokenIssuancePolicy](Remove-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Remove-MgPolicyTokenLifetimePolicy](Remove-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

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

### [Remove-MgUserAuthenticationSoftwareOathMethod](Remove-MgUserAuthenticationSoftwareOathMethod.md)
Delete navigation property softwareOathMethods for users

### [Remove-MgUserAuthenticationTemporaryAccessPassMethod](Remove-MgUserAuthenticationTemporaryAccessPassMethod.md)
Delete navigation property temporaryAccessPassMethods for users

### [Remove-MgUserAuthenticationWindowHello](Remove-MgUserAuthenticationWindowHello.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Remove-MgUserInformationProtection](Remove-MgUserInformationProtection.md)
Delete navigation property informationProtection for users

### [Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault](Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault.md)
Invoke action resetToSystemDefault

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

### [Update-MgIdentityConditionalAccessAuthenticationContextClassReference](Update-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [Update-MgIdentityConditionalAccessNamedLocation](Update-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Update-MgIdentityConditionalAccessPolicy](Update-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access (CA) policies.

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
The policy that contains directory-level access review settings.

### [Update-MgPolicyActivityBasedTimeoutPolicy](Update-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Update-MgPolicyAdminConsentRequestPolicy](Update-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Update-MgPolicyAppManagementPolicy](Update-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Update-MgPolicyAuthenticationFlowPolicy](Update-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Update-MgPolicyAuthenticationMethodPolicy](Update-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Update-MgPolicyAuthorizationPolicy](Update-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Update-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Update-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Update the navigation property defaultUserRoleOverrides in policies

### [Update-MgPolicyB2CAuthenticationMethodPolicy](Update-MgPolicyB2CAuthenticationMethodPolicy.md)
The Azure AD B2C policies that define how end users register via local accounts.

### [Update-MgPolicyClaimMappingPolicy](Update-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Update-MgPolicyCrossTenantAccessPolicy](Update-MgPolicyCrossTenantAccessPolicy.md)
The custom rules that define an access scenario when interacting with external Azure AD tenants.

### [Update-MgPolicyCrossTenantAccessPolicyDefault](Update-MgPolicyCrossTenantAccessPolicyDefault.md)
Defines the default configuration for how your organization interacts with external Azure Active Directory organizations.

### [Update-MgPolicyCrossTenantAccessPolicyPartner](Update-MgPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [Update-MgPolicyDefaultAppManagementPolicy](Update-MgPolicyDefaultAppManagementPolicy.md)
The tenant-wide policy that enforces app management restrictions for all applications and service principals.

### [Update-MgPolicyDirectoryRoleAccessReviewPolicy](Update-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Update the navigation property directoryRoleAccessReviewPolicy in policies

### [Update-MgPolicyExternalIdentityPolicy](Update-MgPolicyExternalIdentityPolicy.md)
Update the navigation property externalIdentitiesPolicy in policies

### [Update-MgPolicyFeatureRolloutPolicy](Update-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Update-MgPolicyFeatureRolloutPolicyApplyTo](Update-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Update-MgPolicyHomeRealmDiscoveryPolicy](Update-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Update-MgPolicyMobileAppManagementPolicy](Update-MgPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [Update-MgPolicyMobileDeviceManagementPolicy](Update-MgPolicyMobileDeviceManagementPolicy.md)
Update the navigation property mobileDeviceManagementPolicies in policies

### [Update-MgPolicyPermissionGrantPolicy](Update-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Update-MgPolicyPermissionGrantPolicyExclude](Update-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyPermissionGrantPolicyInclude](Update-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyRoleManagementPolicy](Update-MgPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [Update-MgPolicyRoleManagementPolicyAssignment](Update-MgPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

### [Update-MgPolicyRoleManagementPolicyEffectiveRule](Update-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rule, expiration rule, etc.
evaluated based on inherited referenced rules.
E.g.
If there is a tenant wide policy to enforce enabling approval rule, the effective rule will be to enable approval even if the polcy has a rule to disable approval.

### [Update-MgPolicyRoleManagementPolicyRule](Update-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rule, expiration rule, etc.

### [Update-MgPolicyServicePrincipalCreationPolicy](Update-MgPolicyServicePrincipalCreationPolicy.md)
Update the navigation property servicePrincipalCreationPolicies in policies

### [Update-MgPolicyServicePrincipalCreationPolicyExclude](Update-MgPolicyServicePrincipalCreationPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgPolicyServicePrincipalCreationPolicyInclude](Update-MgPolicyServicePrincipalCreationPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgPolicyTokenIssuancePolicy](Update-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Update-MgPolicyTokenLifetimePolicy](Update-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

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

### [Update-MgUserAuthenticationSoftwareOathMethod](Update-MgUserAuthenticationSoftwareOathMethod.md)
Update the navigation property softwareOathMethods in users

### [Update-MgUserAuthenticationTemporaryAccessPassMethod](Update-MgUserAuthenticationTemporaryAccessPassMethod.md)
Update the navigation property temporaryAccessPassMethods in users

### [Update-MgUserAuthenticationWindowHello](Update-MgUserAuthenticationWindowHello.md)
Update the navigation property windowsHelloForBusinessMethods in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Update-MgUserInformationProtection](Update-MgUserInformationProtection.md)
Update the navigation property informationProtection in users

