---
Module Name: Microsoft.Graph.Beta.Identity.SignIns
Module Guid: e36cfed7-9f0f-45d4-9f92-de7d024a849f
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Identity.SignIns Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Identity.SignIns Cmdlets
### [Confirm-MgBetaInformationProtectionSignature](Confirm-MgBetaInformationProtectionSignature.md)
Invoke action verifySignature

### [Confirm-MgBetaRiskyServicePrincipalCompromised](Confirm-MgBetaRiskyServicePrincipalCompromised.md)
Confirm one or more riskyServicePrincipal objects as compromised.
This action sets the targeted service principal account's risk level to `high`.
When the risk level of the service principal is confirmed as compromised, the service principal object is disabled and its **disabledByMicrosoftStatus** property is updated.

### [Confirm-MgBetaRiskyUserCompromised](Confirm-MgBetaRiskyUserCompromised.md)
Confirm one or more riskyUser objects as compromised.
This action sets the targeted user's risk level to high.

### [Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode](Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Find-MgBetaPolicyAuthenticationStrengthPolicyByMethodMode](Find-MgBetaPolicyAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Get-MgBetaDataPolicyOperation](Get-MgBetaDataPolicyOperation.md)
Retrieve the properties of the dataPolicyOperation object.

### [Get-MgBetaIdentityApiConnector](Get-MgBetaIdentityApiConnector.md)
Represents entry point for API connectors.

### [Get-MgBetaIdentityAuthenticationEventListener](Get-MgBetaIdentityAuthenticationEventListener.md)
Get authenticationEventListeners from identity

### [Get-MgBetaIdentityB2CUserFlow](Get-MgBetaIdentityB2CUserFlow.md)
Represents entry point for B2C identity userflows.

### [Get-MgBetaIdentityB2CUserFlowIdentityProvider](Get-MgBetaIdentityB2CUserFlowIdentityProvider.md)
Get userFlowIdentityProviders from identity

### [Get-MgBetaIdentityB2CUserFlowIdentityProviderByRef](Get-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Get the identity providers in a b2cIdentityUserFlow object.

### [Get-MgBetaIdentityB2CUserFlowLanguage](Get-MgBetaIdentityB2CUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is not enabled by default in B2C user flows.

### [Get-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Get-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent](Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgBetaIdentityB2CUserFlowLanguageOverridePage](Get-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgBetaIdentityB2CUserFlowLanguageOverridePageContent](Get-MgBetaIdentityB2CUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
The user attribute assignments included in the user flow.

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentUserAttribute](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgBetaIdentityB2XUserFlow](Get-MgBetaIdentityB2XUserFlow.md)
Represents entry point for B2X and self-service sign-up identity userflows.

### [Get-MgBetaIdentityB2XUserFlowIdentityProvider](Get-MgBetaIdentityB2XUserFlowIdentityProvider.md)
Get identityProviders from identity

### [Get-MgBetaIdentityB2XUserFlowIdentityProviderByRef](Get-MgBetaIdentityB2XUserFlowIdentityProviderByRef.md)
Get ref of userFlowIdentityProviders from identity

### [Get-MgBetaIdentityB2XUserFlowLanguage](Get-MgBetaIdentityB2XUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is enabled by default in self-service sign up user flow.
You cannot create custom languages in self-service sign up user flows.

### [Get-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Get-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent](Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgBetaIdentityB2XUserFlowLanguageOverridePage](Get-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgBetaIdentityB2XUserFlowLanguageOverridePageContent](Get-MgBetaIdentityB2XUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
The user attribute assignments included in the user flow.

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentUserAttribute](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrength](Get-MgBetaIdentityConditionalAccessAuthenticationStrength.md)
Defines the authentication strength policies, valid authentication method combinations, and authentication method mode details that can be required by a conditional access policy .

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Names and descriptions of all valid authentication method modes in the system.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.

### [Get-MgBetaIdentityConditionalAccessNamedLocation](Get-MgBetaIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Get-MgBetaIdentityConditionalAccessPolicy](Get-MgBetaIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access policies.

### [Get-MgBetaIdentityConditionalAccessTemplate](Get-MgBetaIdentityConditionalAccessTemplate.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access templates.

### [Get-MgBetaIdentityContinuouAccessEvaluationPolicy](Get-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Read the properties and relationships of a continuousAccessEvaluationPolicy object.

### [Get-MgBetaIdentityCustomAuthenticationExtension](Get-MgBetaIdentityCustomAuthenticationExtension.md)
Get customAuthenticationExtensions from identity

### [Get-MgBetaIdentityProvider](Get-MgBetaIdentityProvider.md)
Represents entry point for identity provider base.

### [Get-MgBetaIdentityUserFlow](Get-MgBetaIdentityUserFlow.md)
Get userFlows from identity

### [Get-MgBetaIdentityUserFlowAttribute](Get-MgBetaIdentityUserFlowAttribute.md)
Represents entry point for identity userflow attributes.

### [Get-MgBetaInformationProtection](Get-MgBetaInformationProtection.md)
Get informationProtection

### [Get-MgBetaInformationProtectionBitlocker](Get-MgBetaInformationProtectionBitlocker.md)
Get bitlocker from informationProtection

### [Get-MgBetaInformationProtectionBitlockerRecoveryKey](Get-MgBetaInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Get-MgBetaInformationProtectionDataLossPreventionPolicy](Get-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from informationProtection

### [Get-MgBetaInformationProtectionPolicy](Get-MgBetaInformationProtectionPolicy.md)
Get policy from informationProtection

### [Get-MgBetaInformationProtectionPolicyLabel](Get-MgBetaInformationProtectionPolicyLabel.md)
Get labels from informationProtection

### [Get-MgBetaInformationProtectionSensitivityPolicySetting](Get-MgBetaInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from informationProtection

### [Get-MgBetaInformationProtectionThreatAssessmentRequest](Get-MgBetaInformationProtectionThreatAssessmentRequest.md)
Get threatAssessmentRequests from informationProtection

### [Get-MgBetaInformationProtectionThreatAssessmentRequestResult](Get-MgBetaInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Get-MgBetaOauth2PermissionGrant](Get-MgBetaOauth2PermissionGrant.md)
Retrieve the properties of a single delegated permission grant represented by an oAuth2PermissionGrant object.
An **oAuth2PermissionGrant** represents delegated permissions which have been granted for a client application to access an API on behalf of a signed-in user.

### [Get-MgBetaOauth2PermissionGrantDelta](Get-MgBetaOauth2PermissionGrantDelta.md)
Invoke function delta

### [Get-MgBetaOrganizationCertificateBasedAuthConfiguration](Get-MgBetaOrganizationCertificateBasedAuthConfiguration.md)
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgBetaPolicyAccessReviewPolicy](Get-MgBetaPolicyAccessReviewPolicy.md)
Read the properties and relationships of an accessReviewPolicy object.

### [Get-MgBetaPolicyActivityBasedTimeoutPolicy](Get-MgBetaPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Get-MgBetaPolicyAdminConsentRequestPolicy](Get-MgBetaPolicyAdminConsentRequestPolicy.md)
Read the properties and relationships of an adminConsentRequestPolicy object.

### [Get-MgBetaPolicyAppManagementPolicy](Get-MgBetaPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Get-MgBetaPolicyAppManagementPolicyApplyTo](Get-MgBetaPolicyAppManagementPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyAuthenticationFlowPolicy](Get-MgBetaPolicyAuthenticationFlowPolicy.md)
Read the properties and relationships of an authenticationFlowsPolicy object.

### [Get-MgBetaPolicyAuthenticationMethodPolicy](Get-MgBetaPolicyAuthenticationMethodPolicy.md)
Read the properties and relationships of an authenticationMethodsPolicy object.

### [Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Represents the settings for each authentication method.
Automatically expanded on GET /policies/authenticationMethodsPolicy.

### [Get-MgBetaPolicyAuthenticationStrengthPolicy](Get-MgBetaPolicyAuthenticationStrengthPolicy.md)
The authentication method combinations that are to be used in scenarios defined by Azure AD Conditional Access.

### [Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.

### [Get-MgBetaPolicyAuthorizationPolicy](Get-MgBetaPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Get defaultUserRoleOverrides from policies

### [Get-MgBetaPolicyB2CAuthenticationMethodPolicy](Get-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Read the properties of a b2cAuthenticationMethodsPolicy object.

### [Get-MgBetaPolicyClaimMappingPolicy](Get-MgBetaPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Get-MgBetaPolicyCrossTenantAccessPolicy](Get-MgBetaPolicyCrossTenantAccessPolicy.md)
Read the properties and relationships of a crossTenantAccessPolicy object.

### [Get-MgBetaPolicyCrossTenantAccessPolicyDefault](Get-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Read the default configuration of a cross-tenant access policy.
This default configuration may be the service default assigned by Azure AD (**isServiceDefault** is `true`) or may be customized in your tenant (**isServiceDefault** is `false`).

### [Get-MgBetaPolicyCrossTenantAccessPolicyPartner](Get-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [Get-MgBetaPolicyDefaultAppManagementPolicy](Get-MgBetaPolicyDefaultAppManagementPolicy.md)
Read the properties of a tenantAppManagementPolicy object.

### [Get-MgBetaPolicyDeviceRegistrationPolicy](Get-MgBetaPolicyDeviceRegistrationPolicy.md)
Read the properties and relationships of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

### [Get-MgBetaPolicyDirectoryRoleAccessReviewPolicy](Get-MgBetaPolicyDirectoryRoleAccessReviewPolicy.md)
Get directoryRoleAccessReviewPolicy from policies

### [Get-MgBetaPolicyExternalIdentityPolicy](Get-MgBetaPolicyExternalIdentityPolicy.md)
Read the properties and relationships of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls.

### [Get-MgBetaPolicyFeatureRolloutPolicy](Get-MgBetaPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyTo](Get-MgBetaPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToById](Get-MgBetaPolicyFeatureRolloutPolicyApplyToById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](Get-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToUserOwnedObject](Get-MgBetaPolicyFeatureRolloutPolicyApplyToUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaPolicyHomeRealmDiscoveryPolicy](Get-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Get-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Retrieve the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Get-MgBetaPolicyMobileAppManagementPolicy](Get-MgBetaPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroup](Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileDeviceManagementPolicy](Get-MgBetaPolicyMobileDeviceManagementPolicy.md)
Get mobileDeviceManagementPolicies from policies

### [Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroup](Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyPermissionGrantPolicy](Get-MgBetaPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Get-MgBetaPolicyPermissionGrantPolicyExclude](Get-MgBetaPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Get-MgBetaPolicyPermissionGrantPolicyInclude](Get-MgBetaPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Get-MgBetaPolicyRoleManagementPolicy](Get-MgBetaPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [Get-MgBetaPolicyRoleManagementPolicyAssignment](Get-MgBetaPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

### [Get-MgBetaPolicyRoleManagementPolicyAssignmentPolicy](Get-MgBetaPolicyRoleManagementPolicyAssignmentPolicy.md)
The policy that's associated with a policy assignment.
Supports $expand and a nested $expand of the rules and effectiveRules relationships for the policy.

### [Get-MgBetaPolicyRoleManagementPolicyEffectiveRule](Get-MgBetaPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules.
For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval.
Supports $expand.

### [Get-MgBetaPolicyRoleManagementPolicyRule](Get-MgBetaPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rules and expiration rules.
Supports $expand.

### [Get-MgBetaPolicyServicePrincipalCreationPolicy](Get-MgBetaPolicyServicePrincipalCreationPolicy.md)
Get servicePrincipalCreationPolicies from policies

### [Get-MgBetaPolicyServicePrincipalCreationPolicyExclude](Get-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Get excludes from policies

### [Get-MgBetaPolicyServicePrincipalCreationPolicyInclude](Get-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Get includes from policies

### [Get-MgBetaPolicyTokenIssuancePolicy](Get-MgBetaPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Get-MgBetaPolicyTokenLifetimePolicy](Get-MgBetaPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

### [Get-MgBetaRiskDetection](Get-MgBetaRiskDetection.md)
Risk detection in Azure AD Identity Protection and the associated information about the detection.

### [Get-MgBetaRiskyServicePrincipal](Get-MgBetaRiskyServicePrincipal.md)
Azure AD service principals that are at risk.

### [Get-MgBetaRiskyServicePrincipalHistory](Get-MgBetaRiskyServicePrincipalHistory.md)
Represents the risk history of Azure AD service principals.

### [Get-MgBetaRiskyUser](Get-MgBetaRiskyUser.md)
Users that are flagged as at-risk by Azure AD Identity Protection.

### [Get-MgBetaRiskyUserHistory](Get-MgBetaRiskyUserHistory.md)
Get history from identityProtection

### [Get-MgBetaServicePrincipalRiskDetection](Get-MgBetaServicePrincipalRiskDetection.md)
Represents information about detected at-risk service principals in an Azure AD tenant.

### [Get-MgBetaTrustFramework](Get-MgBetaTrustFramework.md)
Get trustFramework

### [Get-MgBetaTrustFrameworkKeySet](Get-MgBetaTrustFrameworkKeySet.md)
Get keySets from trustFramework

### [Get-MgBetaTrustFrameworkKeySetActiveKey](Get-MgBetaTrustFrameworkKeySetActiveKey.md)
Invoke function getActiveKey

### [Get-MgBetaTrustFrameworkPolicy](Get-MgBetaTrustFrameworkPolicy.md)
Get policies from trustFramework

### [Get-MgBetaTrustFrameworkPolicyContent](Get-MgBetaTrustFrameworkPolicyContent.md)
Get media content for the navigation property policies from trustFramework

### [Get-MgBetaUserAuthenticationEmailMethod](Get-MgBetaUserAuthenticationEmailMethod.md)
Represents the email addresses registered to a user for authentication.

### [Get-MgBetaUserAuthenticationFido2Method](Get-MgBetaUserAuthenticationFido2Method.md)
Represents the FIDO2 security keys registered to a user for authentication.

### [Get-MgBetaUserAuthenticationMethod](Get-MgBetaUserAuthenticationMethod.md)
Represents all authentication methods registered to a user.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod.md)
The details of the Microsoft Authenticator app registered to a user for authentication.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommandResponsepayload](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberOf](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwner](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredUser](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgBetaUserAuthenticationOperation](Get-MgBetaUserAuthenticationOperation.md)
Get operations from users

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Represents the Microsoft Authenticator Passwordless Phone Sign-in methods registered to a user for authentication.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Get device from users

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommandResponsepayload](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberOf](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwner](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredUser](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgBetaUserAuthenticationPasswordMethod](Get-MgBetaUserAuthenticationPasswordMethod.md)
Represents the details of the password authentication method registered to a user for authentication.

### [Get-MgBetaUserAuthenticationPhoneMethod](Get-MgBetaUserAuthenticationPhoneMethod.md)
Represents the phone registered to a user for authentication.

### [Get-MgBetaUserAuthenticationSoftwareOathMethod](Get-MgBetaUserAuthenticationSoftwareOathMethod.md)
Get softwareOathMethods from users

### [Get-MgBetaUserAuthenticationTemporaryAccessPassMethod](Get-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethod](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethod.md)
Represents the Windows Hello for Business authentication method registered to a user for authentication.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommandResponsepayload](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberOf](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwner](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredUser](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceTransitiveMemberOf](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgBetaUserInformationProtection](Get-MgBetaUserInformationProtection.md)
Get informationProtection from users

### [Get-MgBetaUserInformationProtectionBitlocker](Get-MgBetaUserInformationProtectionBitlocker.md)
Get bitlocker from users

### [Get-MgBetaUserInformationProtectionBitlockerRecoveryKey](Get-MgBetaUserInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Get-MgBetaUserInformationProtectionDataLossPreventionPolicy](Get-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from users

### [Get-MgBetaUserInformationProtectionPolicy](Get-MgBetaUserInformationProtectionPolicy.md)
Get policy from users

### [Get-MgBetaUserInformationProtectionPolicyLabel](Get-MgBetaUserInformationProtectionPolicyLabel.md)
Get labels from users

### [Get-MgBetaUserInformationProtectionSensitivityLabel](Get-MgBetaUserInformationProtectionSensitivityLabel.md)
Get sensitivityLabels from users

### [Get-MgBetaUserInformationProtectionSensitivityLabelSublabel](Get-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Get sublabels from users

### [Get-MgBetaUserInformationProtectionSensitivityPolicySetting](Get-MgBetaUserInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from users

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequest](Get-MgBetaUserInformationProtectionThreatAssessmentRequest.md)
Get threatAssessmentRequests from users

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequestResult](Get-MgBetaUserInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Invoke-MgBetaAvailableIdentityProviderType](Invoke-MgBetaAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgBetaBufferInformationProtectionDecrypt](Invoke-MgBetaBufferInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBetaBufferInformationProtectionEncrypt](Invoke-MgBetaBufferInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgBetaDismissRiskyServicePrincipal](Invoke-MgBetaDismissRiskyServicePrincipal.md)
Dismiss the risk of one or more riskyServicePrincipal objects.
This action sets the targeted service principal account's risk level to `none`.
You can dismiss up to 60 service principal accounts in one request.

### [Invoke-MgBetaDismissRiskyUser](Invoke-MgBetaDismissRiskyUser.md)
Dismiss the risk of one or more riskyUser objects.
This action sets the targeted user's risk level to none.
The maximum count of users to dismiss in one call is 60.

### [Invoke-MgBetaExtractInformationProtectionPolicyLabel](Invoke-MgBetaExtractInformationProtectionPolicyLabel.md)
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

### [Invoke-MgBetaSignInformationProtectionDigest](Invoke-MgBetaSignInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgBetaUploadIdentityApiConnectorClientCertificate](Invoke-MgBetaUploadIdentityApiConnectorClientCertificate.md)
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

### [Invoke-MgBetaUploadTrustFrameworkKeySetCertificate](Invoke-MgBetaUploadTrustFrameworkKeySetCertificate.md)
Upload a certificate to a trustFrameworkKeyset.
The input is a base-64 encoded value of the certificate contents.
This method returns trustFrameworkKey.

### [Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12](Invoke-MgBetaUploadTrustFrameworkKeySetPkcs12.md)
Upload a PKCS12 format key (PFX) to a trustFrameworkKeyset.
The input is a base-64 encoded value of the Pfx certificate contents.
This method returns trustFrameworkKey.

### [Invoke-MgBetaUploadTrustFrameworkKeySetSecret](Invoke-MgBetaUploadTrustFrameworkKeySetSecret.md)
Upload a plain text secret to a trustFrameworkKeyset.
Examples of secrets are application secrets in Azure Active Directory, Google, Facebook, or any other identity provider.
his method returns trustFrameworkKey.

### [Invoke-MgBetaUsageIdentityConditionalAccessAuthenticationStrengthPolicy](Invoke-MgBetaUsageIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Invoke function usage

### [Invoke-MgBetaUsagePolicyAuthenticationStrengthPolicy](Invoke-MgBetaUsagePolicyAuthenticationStrengthPolicy.md)
Invoke function usage

### [New-MgBetaDataPolicyOperation](New-MgBetaDataPolicyOperation.md)
Add new entity to dataPolicyOperations

### [New-MgBetaIdentityApiConnector](New-MgBetaIdentityApiConnector.md)
Create a new identityApiConnector object.

### [New-MgBetaIdentityAuthenticationEventListener](New-MgBetaIdentityAuthenticationEventListener.md)
Create new navigation property to authenticationEventListeners for identity

### [New-MgBetaIdentityB2CUserFlow](New-MgBetaIdentityB2CUserFlow.md)
Create a new b2cIdentityUserFlow object.

### [New-MgBetaIdentityB2CUserFlowIdentityProviderByRef](New-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Create new navigation property ref to identityProviders for identity

### [New-MgBetaIdentityB2CUserFlowLanguage](New-MgBetaIdentityB2CUserFlowLanguage.md)
Create new navigation property to languages for identity

### [New-MgBetaIdentityB2CUserFlowLanguageDefaultPage](New-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Create new navigation property to defaultPages for identity

### [New-MgBetaIdentityB2CUserFlowLanguageOverridePage](New-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Create new navigation property to overridesPages for identity

### [New-MgBetaIdentityB2CUserFlowUserAttributeAssignment](New-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Create a new identityUserFlowAttributeAssignment object in a b2cIdentityUserFlow.

### [New-MgBetaIdentityB2XUserFlow](New-MgBetaIdentityB2XUserFlow.md)
Create a new b2xIdentityUserFlow object.

### [New-MgBetaIdentityB2XUserFlowIdentityProviderByRef](New-MgBetaIdentityB2XUserFlowIdentityProviderByRef.md)
Create new navigation property ref to userFlowIdentityProviders for identity

### [New-MgBetaIdentityB2XUserFlowLanguage](New-MgBetaIdentityB2XUserFlowLanguage.md)
Create new navigation property to languages for identity

### [New-MgBetaIdentityB2XUserFlowLanguageDefaultPage](New-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Create new navigation property to defaultPages for identity

### [New-MgBetaIdentityB2XUserFlowLanguageOverridePage](New-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Create new navigation property to overridesPages for identity

### [New-MgBetaIdentityB2XUserFlowUserAttributeAssignment](New-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
Create a new identityUserFlowAttributeAssignment object in a b2xIdentityUserFlow.

### [New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Create a new authenticationContextClassReference.

### [New-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](New-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Create new navigation property to authenticationMethodModes for identity

### [New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Create new navigation property to policies for identity

### [New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](New-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Create a new authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be created, and these may only be created for custom authentication strength policies.

### [New-MgBetaIdentityConditionalAccessNamedLocation](New-MgBetaIdentityConditionalAccessNamedLocation.md)
Create a new namedLocation object.
Named locations can be either ipNamedLocation or countryNamedLocation objects.

### [New-MgBetaIdentityConditionalAccessPolicy](New-MgBetaIdentityConditionalAccessPolicy.md)
Create a new conditionalAccessPolicy.

### [New-MgBetaIdentityCustomAuthenticationExtension](New-MgBetaIdentityCustomAuthenticationExtension.md)
Create new navigation property to customAuthenticationExtensions for identity

### [New-MgBetaIdentityProvider](New-MgBetaIdentityProvider.md)
Create an identity provider resource that is of the type specified in the request body.
Among the types of providers derived from identityProviderBase, you can currently create a socialIdentityProvider resource in Azure AD.
In Azure AD B2C, this operation can currently create a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

### [New-MgBetaIdentityUserFlow](New-MgBetaIdentityUserFlow.md)
Create a new userFlow object.

### [New-MgBetaIdentityUserFlowAttribute](New-MgBetaIdentityUserFlowAttribute.md)
Create a new identityUserFlowAttribute object.

### [New-MgBetaInformationProtectionDataLossPreventionPolicy](New-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Create new navigation property to dataLossPreventionPolicies for informationProtection

### [New-MgBetaInformationProtectionPolicyLabel](New-MgBetaInformationProtectionPolicyLabel.md)
Create new navigation property to labels for informationProtection

### [New-MgBetaInformationProtectionThreatAssessmentRequest](New-MgBetaInformationProtectionThreatAssessmentRequest.md)
Create a new threat assessment request.
A threat assessment request can be one of the following types:

### [New-MgBetaInformationProtectionThreatAssessmentRequestResult](New-MgBetaInformationProtectionThreatAssessmentRequestResult.md)
Create new navigation property to results for informationProtection

### [New-MgBetaInvitation](New-MgBetaInvitation.md)
Use this API to create a new invitation.
Invitation adds an external user to the organization.
When creating a new invitation you have several options available:

### [New-MgBetaOauth2PermissionGrant](New-MgBetaOauth2PermissionGrant.md)
Create a delegated permission grant, represented by an oAuth2PermissionGrant object.
A delegated permission grant authorizes a client service principal (representing a client application) to access a resource service principal (representing an API), on behalf of a signed-in user, for the level of access limited by the delegated permissions which were granted.

### [New-MgBetaPolicyActivityBasedTimeoutPolicy](New-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Create a new activityBasedTimeoutPolicy object.

### [New-MgBetaPolicyAppManagementPolicy](New-MgBetaPolicyAppManagementPolicy.md)
Create an appManagementPolicy object.

### [New-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](New-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Create new navigation property to authenticationMethodConfigurations for policies

### [New-MgBetaPolicyAuthenticationStrengthPolicy](New-MgBetaPolicyAuthenticationStrengthPolicy.md)
Create a new custom authenticationStrengthPolicy object.

### [New-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](New-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Create a new authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be created, and these may only be created for custom authentication strength policies.

### [New-MgBetaPolicyAuthorizationPolicy](New-MgBetaPolicyAuthorizationPolicy.md)
Create new navigation property to authorizationPolicy for policies

### [New-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](New-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Create new navigation property to defaultUserRoleOverrides for policies

### [New-MgBetaPolicyClaimMappingPolicy](New-MgBetaPolicyClaimMappingPolicy.md)
Create a new claimsMappingPolicy object.

### [New-MgBetaPolicyCrossTenantAccessPolicyPartner](New-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Create a new partner configuration in a cross-tenant access policy.

### [New-MgBetaPolicyFeatureRolloutPolicy](New-MgBetaPolicyFeatureRolloutPolicy.md)
Create a new featureRolloutPolicy object.

### [New-MgBetaPolicyFeatureRolloutPolicyApplyTo](New-MgBetaPolicyFeatureRolloutPolicyApplyTo.md)
Create new navigation property to appliesTo for policies

### [New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Create new navigation property ref to appliesTo for policies

### [New-MgBetaPolicyHomeRealmDiscoveryPolicy](New-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Create a new homeRealmDiscoveryPolicy object.

### [New-MgBetaPolicyMobileAppManagementPolicy](New-MgBetaPolicyMobileAppManagementPolicy.md)
Create new navigation property to mobileAppManagementPolicies for policies

### [New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Create new navigation property ref to includedGroups for policies

### [New-MgBetaPolicyMobileDeviceManagementPolicy](New-MgBetaPolicyMobileDeviceManagementPolicy.md)
Create new navigation property to mobileDeviceManagementPolicies for policies

### [New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Create new navigation property ref to includedGroups for policies

### [New-MgBetaPolicyPermissionGrantPolicy](New-MgBetaPolicyPermissionGrantPolicy.md)
Creates a permissionGrantPolicy.
A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).
After creating the permission grant policy, you can add include condition sets to add matching rules, and add exclude condition sets to add exclusion rules.

### [New-MgBetaPolicyPermissionGrantPolicyExclude](New-MgBetaPolicyPermissionGrantPolicyExclude.md)
Add conditions under which a permission grant event is *excluded* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **excludes** collection of a  permissionGrantPolicy.

### [New-MgBetaPolicyPermissionGrantPolicyInclude](New-MgBetaPolicyPermissionGrantPolicyInclude.md)
Add conditions under which a permission grant event is *included* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **includes** collection of a  permissionGrantPolicy.

### [New-MgBetaPolicyRoleManagementPolicy](New-MgBetaPolicyRoleManagementPolicy.md)
Create new navigation property to roleManagementPolicies for policies

### [New-MgBetaPolicyRoleManagementPolicyAssignment](New-MgBetaPolicyRoleManagementPolicyAssignment.md)
Create new navigation property to roleManagementPolicyAssignments for policies

### [New-MgBetaPolicyRoleManagementPolicyEffectiveRule](New-MgBetaPolicyRoleManagementPolicyEffectiveRule.md)
Create new navigation property to effectiveRules for policies

### [New-MgBetaPolicyRoleManagementPolicyRule](New-MgBetaPolicyRoleManagementPolicyRule.md)
Create new navigation property to rules for policies

### [New-MgBetaPolicyServicePrincipalCreationPolicy](New-MgBetaPolicyServicePrincipalCreationPolicy.md)
Create new navigation property to servicePrincipalCreationPolicies for policies

### [New-MgBetaPolicyServicePrincipalCreationPolicyExclude](New-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Create new navigation property to excludes for policies

### [New-MgBetaPolicyServicePrincipalCreationPolicyInclude](New-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Create new navigation property to includes for policies

### [New-MgBetaPolicyTokenIssuancePolicy](New-MgBetaPolicyTokenIssuancePolicy.md)
Create a new tokenIssuancePolicy object.

### [New-MgBetaPolicyTokenLifetimePolicy](New-MgBetaPolicyTokenLifetimePolicy.md)
Create a new tokenLifetimePolicy object.

### [New-MgBetaRiskDetection](New-MgBetaRiskDetection.md)
Create new navigation property to riskDetections for identityProtection

### [New-MgBetaRiskyServicePrincipal](New-MgBetaRiskyServicePrincipal.md)
Create new navigation property to riskyServicePrincipals for identityProtection

### [New-MgBetaRiskyServicePrincipalHistory](New-MgBetaRiskyServicePrincipalHistory.md)
Create new navigation property to history for identityProtection

### [New-MgBetaRiskyUser](New-MgBetaRiskyUser.md)
Create new navigation property to riskyUsers for identityProtection

### [New-MgBetaRiskyUserHistory](New-MgBetaRiskyUserHistory.md)
Create new navigation property to history for identityProtection

### [New-MgBetaServicePrincipalRiskDetection](New-MgBetaServicePrincipalRiskDetection.md)
Create new navigation property to servicePrincipalRiskDetections for identityProtection

### [New-MgBetaTrustFrameworkKeySet](New-MgBetaTrustFrameworkKeySet.md)
Create a new trustFrameworkKeySet.
The ID of the **trustFrameworkKeySet** is expected in the create request; however, it can be modified by the service.
The modified ID will be available in the response and in the location header.

### [New-MgBetaTrustFrameworkKeySetKey](New-MgBetaTrustFrameworkKeySetKey.md)
Generate a trustFrameworkKey and a secret automatically in the trustFrameworkKeyset.
The caller doesn't have to provide a secret.

### [New-MgBetaTrustFrameworkPolicy](New-MgBetaTrustFrameworkPolicy.md)
Create new navigation property to policies for trustFramework

### [New-MgBetaUserAuthenticationEmailMethod](New-MgBetaUserAuthenticationEmailMethod.md)
Set a user's emailAuthenticationMethod object.
Email authentication is a self-service password reset method.
A user may only have one email authentication method.

### [New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](New-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgBetaUserAuthenticationOperation](New-MgBetaUserAuthenticationOperation.md)
Create new navigation property to operations for users

### [New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](New-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgBetaUserAuthenticationPhoneMethod](New-MgBetaUserAuthenticationPhoneMethod.md)
Add a new phone authentication method.
A user may only have one phone of each type, captured in the **phoneType** property.
This means, for example, adding a `mobile` phone to a user with a preexisting `mobile` phone will fail.
Additionally, a user must always have a `mobile` phone before adding an `alternateMobile` phone.
Adding a phone number makes it available for use in both Azure multi-factor authentication (MFA) and self-service password reset (SSPR), if enabled.
Additionally, if a user is enabled by policy to use SMS sign-in and a `mobile` number is added, the system will attempt to register the number for use in that system.

### [New-MgBetaUserAuthenticationTemporaryAccessPassMethod](New-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Create a new temporaryAccessPassAuthenticationMethod object on a user.
A user can only have one Temporary Access Pass that's usable within its specified lifetime.
If the user requires a new Temporary Access Pass while the current Temporary Access Pass is valid, the admin can create a new Temporary Access Pass for the user, the previous Temporary Access Pass will be deleted, and a new Temporary Access Pass will be created.

### [New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](New-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgBetaUserInformationProtectionDataLossPreventionPolicy](New-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Create new navigation property to dataLossPreventionPolicies for users

### [New-MgBetaUserInformationProtectionPolicyLabel](New-MgBetaUserInformationProtectionPolicyLabel.md)
Create new navigation property to labels for users

### [New-MgBetaUserInformationProtectionSensitivityLabel](New-MgBetaUserInformationProtectionSensitivityLabel.md)
Create new navigation property to sensitivityLabels for users

### [New-MgBetaUserInformationProtectionSensitivityLabelSublabel](New-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Create new navigation property to sublabels for users

### [New-MgBetaUserInformationProtectionThreatAssessmentRequest](New-MgBetaUserInformationProtectionThreatAssessmentRequest.md)
Create a new threat assessment request.
A threat assessment request can be one of the following types:

### [New-MgBetaUserInformationProtectionThreatAssessmentRequestResult](New-MgBetaUserInformationProtectionThreatAssessmentRequestResult.md)
Create new navigation property to results for users

### [Remove-MgBetaDataPolicyOperation](Remove-MgBetaDataPolicyOperation.md)
Delete entity from dataPolicyOperations

### [Remove-MgBetaIdentityApiConnector](Remove-MgBetaIdentityApiConnector.md)
Delete navigation property apiConnectors for identity

### [Remove-MgBetaIdentityAuthenticationEventListener](Remove-MgBetaIdentityAuthenticationEventListener.md)
Delete navigation property authenticationEventListeners for identity

### [Remove-MgBetaIdentityB2CUserFlow](Remove-MgBetaIdentityB2CUserFlow.md)
Delete navigation property b2cUserFlows for identity

### [Remove-MgBetaIdentityB2CUserFlowIdentityProviderByRef](Remove-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Delete ref of navigation property identityProviders for identity

### [Remove-MgBetaIdentityB2CUserFlowLanguage](Remove-MgBetaIdentityB2CUserFlowLanguage.md)
Delete navigation property languages for identity

### [Remove-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Remove-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgBetaIdentityB2CUserFlowLanguageOverridePage](Remove-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Remove-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Delete navigation property userAttributeAssignments for identity

### [Remove-MgBetaIdentityB2XUserFlow](Remove-MgBetaIdentityB2XUserFlow.md)
Delete navigation property b2xUserFlows for identity

### [Remove-MgBetaIdentityB2XUserFlowIdentityProviderByRef](Remove-MgBetaIdentityB2XUserFlowIdentityProviderByRef.md)
Delete ref of navigation property userFlowIdentityProviders for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguage](Remove-MgBetaIdentityB2XUserFlowLanguage.md)
Delete navigation property languages for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Remove-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguageOverridePage](Remove-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Remove-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
Delete navigation property userAttributeAssignments for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Remove-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Delete navigation property authenticationContextClassReferences for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrength](Remove-MgBetaIdentityConditionalAccessAuthenticationStrength.md)
Delete navigation property authenticationStrengths for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Delete navigation property authenticationMethodModes for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Delete navigation property policies for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete navigation property combinationConfigurations for identity

### [Remove-MgBetaIdentityConditionalAccessNamedLocation](Remove-MgBetaIdentityConditionalAccessNamedLocation.md)
Delete navigation property namedLocations for identity

### [Remove-MgBetaIdentityConditionalAccessPolicy](Remove-MgBetaIdentityConditionalAccessPolicy.md)
Delete navigation property policies for identity

### [Remove-MgBetaIdentityContinuouAccessEvaluationPolicy](Remove-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Delete navigation property continuousAccessEvaluationPolicy for identity

### [Remove-MgBetaIdentityCustomAuthenticationExtension](Remove-MgBetaIdentityCustomAuthenticationExtension.md)
Delete navigation property customAuthenticationExtensions for identity

### [Remove-MgBetaIdentityProvider](Remove-MgBetaIdentityProvider.md)
Delete navigation property identityProviders for identity

### [Remove-MgBetaIdentityUserFlow](Remove-MgBetaIdentityUserFlow.md)
Delete navigation property userFlows for identity

### [Remove-MgBetaIdentityUserFlowAttribute](Remove-MgBetaIdentityUserFlowAttribute.md)
Delete navigation property userFlowAttributes for identity

### [Remove-MgBetaInformationProtectionDataLossPreventionPolicy](Remove-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Delete navigation property dataLossPreventionPolicies for informationProtection

### [Remove-MgBetaInformationProtectionPolicy](Remove-MgBetaInformationProtectionPolicy.md)
Delete navigation property policy for informationProtection

### [Remove-MgBetaInformationProtectionPolicyLabel](Remove-MgBetaInformationProtectionPolicyLabel.md)
Delete navigation property labels for informationProtection

### [Remove-MgBetaInformationProtectionSensitivityPolicySetting](Remove-MgBetaInformationProtectionSensitivityPolicySetting.md)
Delete navigation property sensitivityPolicySettings for informationProtection

### [Remove-MgBetaInformationProtectionThreatAssessmentRequest](Remove-MgBetaInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for informationProtection

### [Remove-MgBetaInformationProtectionThreatAssessmentRequestResult](Remove-MgBetaInformationProtectionThreatAssessmentRequestResult.md)
Delete navigation property results for informationProtection

### [Remove-MgBetaOauth2PermissionGrant](Remove-MgBetaOauth2PermissionGrant.md)
Delete an oAuth2PermissionGrant, representing a delegated permission grant.
When a delegated permission grant is deleted, the access it granted is revoked.
Existing access tokens will continue to be valid for their lifetime, but new access tokens will not be granted for the delegated permissions identified in the deleted **oAuth2PermissionGrant**.

### [Remove-MgBetaPolicyAccessReviewPolicy](Remove-MgBetaPolicyAccessReviewPolicy.md)
Delete navigation property accessReviewPolicy for policies

### [Remove-MgBetaPolicyActivityBasedTimeoutPolicy](Remove-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Delete navigation property activityBasedTimeoutPolicies for policies

### [Remove-MgBetaPolicyAdminConsentRequestPolicy](Remove-MgBetaPolicyAdminConsentRequestPolicy.md)
Delete navigation property adminConsentRequestPolicy for policies

### [Remove-MgBetaPolicyAppManagementPolicy](Remove-MgBetaPolicyAppManagementPolicy.md)
Delete navigation property appManagementPolicies for policies

### [Remove-MgBetaPolicyAuthenticationFlowPolicy](Remove-MgBetaPolicyAuthenticationFlowPolicy.md)
Delete navigation property authenticationFlowsPolicy for policies

### [Remove-MgBetaPolicyAuthenticationMethodPolicy](Remove-MgBetaPolicyAuthenticationMethodPolicy.md)
Delete navigation property authenticationMethodsPolicy for policies

### [Remove-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Remove-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Delete navigation property authenticationMethodConfigurations for policies

### [Remove-MgBetaPolicyAuthenticationStrengthPolicy](Remove-MgBetaPolicyAuthenticationStrengthPolicy.md)
Delete navigation property authenticationStrengthPolicies for policies

### [Remove-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete navigation property combinationConfigurations for policies

### [Remove-MgBetaPolicyAuthorizationPolicy](Remove-MgBetaPolicyAuthorizationPolicy.md)
Delete navigation property authorizationPolicy for policies

### [Remove-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Remove-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Delete navigation property defaultUserRoleOverrides for policies

### [Remove-MgBetaPolicyB2CAuthenticationMethodPolicy](Remove-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Delete navigation property b2cAuthenticationMethodsPolicy for policies

### [Remove-MgBetaPolicyClaimMappingPolicy](Remove-MgBetaPolicyClaimMappingPolicy.md)
Delete navigation property claimsMappingPolicies for policies

### [Remove-MgBetaPolicyCrossTenantAccessPolicy](Remove-MgBetaPolicyCrossTenantAccessPolicy.md)
Delete navigation property crossTenantAccessPolicy for policies

### [Remove-MgBetaPolicyCrossTenantAccessPolicyDefault](Remove-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Delete navigation property default for policies

### [Remove-MgBetaPolicyCrossTenantAccessPolicyPartner](Remove-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Delete navigation property partners for policies

### [Remove-MgBetaPolicyDefaultAppManagementPolicy](Remove-MgBetaPolicyDefaultAppManagementPolicy.md)
Delete navigation property defaultAppManagementPolicy for policies

### [Remove-MgBetaPolicyDirectoryRoleAccessReviewPolicy](Remove-MgBetaPolicyDirectoryRoleAccessReviewPolicy.md)
Delete navigation property directoryRoleAccessReviewPolicy for policies

### [Remove-MgBetaPolicyExternalIdentityPolicy](Remove-MgBetaPolicyExternalIdentityPolicy.md)
Delete navigation property externalIdentitiesPolicy for policies

### [Remove-MgBetaPolicyFeatureRolloutPolicy](Remove-MgBetaPolicyFeatureRolloutPolicy.md)
Delete navigation property featureRolloutPolicies for policies

### [Remove-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](Remove-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Delete ref of navigation property appliesTo for policies

### [Remove-MgBetaPolicyHomeRealmDiscoveryPolicy](Remove-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Delete navigation property homeRealmDiscoveryPolicies for policies

### [Remove-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Delete navigation property identitySecurityDefaultsEnforcementPolicy for policies

### [Remove-MgBetaPolicyMobileAppManagementPolicy](Remove-MgBetaPolicyMobileAppManagementPolicy.md)
Delete navigation property mobileAppManagementPolicies for policies

### [Remove-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](Remove-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Delete ref of navigation property includedGroups for policies

### [Remove-MgBetaPolicyMobileDeviceManagementPolicy](Remove-MgBetaPolicyMobileDeviceManagementPolicy.md)
Delete navigation property mobileDeviceManagementPolicies for policies

### [Remove-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Remove-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Delete ref of navigation property includedGroups for policies

### [Remove-MgBetaPolicyPermissionGrantPolicy](Remove-MgBetaPolicyPermissionGrantPolicy.md)
Delete navigation property permissionGrantPolicies for policies

### [Remove-MgBetaPolicyPermissionGrantPolicyExclude](Remove-MgBetaPolicyPermissionGrantPolicyExclude.md)
Delete navigation property excludes for policies

### [Remove-MgBetaPolicyPermissionGrantPolicyInclude](Remove-MgBetaPolicyPermissionGrantPolicyInclude.md)
Delete navigation property includes for policies

### [Remove-MgBetaPolicyRoleManagementPolicy](Remove-MgBetaPolicyRoleManagementPolicy.md)
Delete navigation property roleManagementPolicies for policies

### [Remove-MgBetaPolicyRoleManagementPolicyAssignment](Remove-MgBetaPolicyRoleManagementPolicyAssignment.md)
Delete navigation property roleManagementPolicyAssignments for policies

### [Remove-MgBetaPolicyRoleManagementPolicyEffectiveRule](Remove-MgBetaPolicyRoleManagementPolicyEffectiveRule.md)
Delete navigation property effectiveRules for policies

### [Remove-MgBetaPolicyRoleManagementPolicyRule](Remove-MgBetaPolicyRoleManagementPolicyRule.md)
Delete navigation property rules for policies

### [Remove-MgBetaPolicyServicePrincipalCreationPolicy](Remove-MgBetaPolicyServicePrincipalCreationPolicy.md)
Delete navigation property servicePrincipalCreationPolicies for policies

### [Remove-MgBetaPolicyServicePrincipalCreationPolicyExclude](Remove-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Delete navigation property excludes for policies

### [Remove-MgBetaPolicyServicePrincipalCreationPolicyInclude](Remove-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Delete navigation property includes for policies

### [Remove-MgBetaPolicyTokenIssuancePolicy](Remove-MgBetaPolicyTokenIssuancePolicy.md)
Delete navigation property tokenIssuancePolicies for policies

### [Remove-MgBetaPolicyTokenLifetimePolicy](Remove-MgBetaPolicyTokenLifetimePolicy.md)
Delete navigation property tokenLifetimePolicies for policies

### [Remove-MgBetaRiskDetection](Remove-MgBetaRiskDetection.md)
Delete navigation property riskDetections for identityProtection

### [Remove-MgBetaRiskyServicePrincipal](Remove-MgBetaRiskyServicePrincipal.md)
Delete navigation property riskyServicePrincipals for identityProtection

### [Remove-MgBetaRiskyServicePrincipalHistory](Remove-MgBetaRiskyServicePrincipalHistory.md)
Delete navigation property history for identityProtection

### [Remove-MgBetaRiskyUser](Remove-MgBetaRiskyUser.md)
Delete navigation property riskyUsers for identityProtection

### [Remove-MgBetaRiskyUserHistory](Remove-MgBetaRiskyUserHistory.md)
Delete navigation property history for identityProtection

### [Remove-MgBetaServicePrincipalRiskDetection](Remove-MgBetaServicePrincipalRiskDetection.md)
Delete navigation property servicePrincipalRiskDetections for identityProtection

### [Remove-MgBetaTrustFrameworkKeySet](Remove-MgBetaTrustFrameworkKeySet.md)
Delete navigation property keySets for trustFramework

### [Remove-MgBetaTrustFrameworkPolicy](Remove-MgBetaTrustFrameworkPolicy.md)
Delete navigation property policies for trustFramework

### [Remove-MgBetaUserAuthenticationEmailMethod](Remove-MgBetaUserAuthenticationEmailMethod.md)
Delete navigation property emailMethods for users

### [Remove-MgBetaUserAuthenticationFido2Method](Remove-MgBetaUserAuthenticationFido2Method.md)
Delete navigation property fido2Methods for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod.md)
Delete navigation property microsoftAuthenticatorMethods for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
Delete navigation property device for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgBetaUserAuthenticationOperation](Remove-MgBetaUserAuthenticationOperation.md)
Delete navigation property operations for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Delete navigation property passwordlessMicrosoftAuthenticatorMethods for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Delete navigation property device for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgBetaUserAuthenticationPhoneMethod](Remove-MgBetaUserAuthenticationPhoneMethod.md)
Delete navigation property phoneMethods for users

### [Remove-MgBetaUserAuthenticationSoftwareOathMethod](Remove-MgBetaUserAuthenticationSoftwareOathMethod.md)
Delete navigation property softwareOathMethods for users

### [Remove-MgBetaUserAuthenticationTemporaryAccessPassMethod](Remove-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Delete navigation property temporaryAccessPassMethods for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethod](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethod.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Delete navigation property device for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Remove-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgBetaUserInformationProtection](Remove-MgBetaUserInformationProtection.md)
Delete navigation property informationProtection for users

### [Remove-MgBetaUserInformationProtectionDataLossPreventionPolicy](Remove-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Delete navigation property dataLossPreventionPolicies for users

### [Remove-MgBetaUserInformationProtectionPolicy](Remove-MgBetaUserInformationProtectionPolicy.md)
Delete navigation property policy for users

### [Remove-MgBetaUserInformationProtectionPolicyLabel](Remove-MgBetaUserInformationProtectionPolicyLabel.md)
Delete navigation property labels for users

### [Remove-MgBetaUserInformationProtectionSensitivityLabel](Remove-MgBetaUserInformationProtectionSensitivityLabel.md)
Delete navigation property sensitivityLabels for users

### [Remove-MgBetaUserInformationProtectionSensitivityLabelSublabel](Remove-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Delete navigation property sublabels for users

### [Remove-MgBetaUserInformationProtectionSensitivityPolicySetting](Remove-MgBetaUserInformationProtectionSensitivityPolicySetting.md)
Delete navigation property sensitivityPolicySettings for users

### [Remove-MgBetaUserInformationProtectionThreatAssessmentRequest](Remove-MgBetaUserInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for users

### [Remove-MgBetaUserInformationProtectionThreatAssessmentRequestResult](Remove-MgBetaUserInformationProtectionThreatAssessmentRequestResult.md)
Delete navigation property results for users

### [Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault](Reset-MgBetaPolicyCrossTenantAccessPolicyDefaultToSystemDefault.md)
Reset any changes made to the default configuration in a cross-tenant access policy back to the system default.

### [Set-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent](Set-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent.md)
Update media content for the navigation property defaultPages in identity

### [Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent](Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent.md)
Update media content for the navigation property overridesPages in identity

### [Set-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder](Set-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder.md)
Set the order of identityUserFlowAttributeAssignments being collected within a user flow.

### [Set-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent](Set-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent.md)
Update media content for the navigation property defaultPages in identity

### [Set-MgBetaIdentityB2XUserFlowLanguageOverridePageContent](Set-MgBetaIdentityB2XUserFlowLanguageOverridePageContent.md)
Update media content for the navigation property overridesPages in identity

### [Set-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder](Set-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Set the order of identityUserFlowAttributeAssignments being collected within a user flow.

### [Set-MgBetaTrustFrameworkPolicyContent](Set-MgBetaTrustFrameworkPolicyContent.md)
Update media content for the navigation property policies in trustFramework

### [Test-MgBetaIdentityCustomAuthenticationExtensionAuthenticationConfiguration](Test-MgBetaIdentityCustomAuthenticationExtensionAuthenticationConfiguration.md)
Invoke action validateAuthenticationConfiguration

### [Test-MgBetaInformationProtectionDataLossPreventionPolicy](Test-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgBetaInformationProtectionPolicyLabelApplication](Test-MgBetaInformationProtectionPolicyLabelApplication.md)
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

### [Test-MgBetaInformationProtectionPolicyLabelClassificationResult](Test-MgBetaInformationProtectionPolicyLabelClassificationResult.md)
Using classification results, compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide contentInfo, which includes existing content metadata key/value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following:

### [Test-MgBetaInformationProtectionPolicyLabelRemoval](Test-MgBetaInformationProtectionPolicyLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key/value pairs, the API returns an informationProtectionAction that contains some combination of one of more of the following:

### [Test-MgBetaPolicyFeatureRolloutPolicyApplyToProperty](Test-MgBetaPolicyFeatureRolloutPolicyApplyToProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Update-MgBetaDataPolicyOperation](Update-MgBetaDataPolicyOperation.md)
Update entity in dataPolicyOperations

### [Update-MgBetaIdentityApiConnector](Update-MgBetaIdentityApiConnector.md)
Update the navigation property apiConnectors in identity

### [Update-MgBetaIdentityAuthenticationEventListener](Update-MgBetaIdentityAuthenticationEventListener.md)
Update the navigation property authenticationEventListeners in identity

### [Update-MgBetaIdentityB2CUserFlow](Update-MgBetaIdentityB2CUserFlow.md)
Update the navigation property b2cUserFlows in identity

### [Update-MgBetaIdentityB2CUserFlowLanguage](Update-MgBetaIdentityB2CUserFlowLanguage.md)
Update the navigation property languages in identity

### [Update-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Update-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgBetaIdentityB2CUserFlowLanguageOverridePage](Update-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Update-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Update the navigation property userAttributeAssignments in identity

### [Update-MgBetaIdentityB2XUserFlow](Update-MgBetaIdentityB2XUserFlow.md)
Update the navigation property b2xUserFlows in identity

### [Update-MgBetaIdentityB2XUserFlowLanguage](Update-MgBetaIdentityB2XUserFlowLanguage.md)
Update the navigation property languages in identity

### [Update-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Update-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgBetaIdentityB2XUserFlowLanguageOverridePage](Update-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Update-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
Update the navigation property userAttributeAssignments in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Update the navigation property authenticationContextClassReferences in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationStrength](Update-MgBetaIdentityConditionalAccessAuthenticationStrength.md)
Update the navigation property authenticationStrengths in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Update-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Update the navigation property authenticationMethodModes in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Update the navigation property policies in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyAllowedCombination](Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyAllowedCombination.md)
Update the allowedCombinations property of an authenticationStrengthPolicy object.
To update other properties of an authenticationStrengthPolicy object, use the Update authenticationStrengthPolicy method.

### [Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Update-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the navigation property combinationConfigurations in identity

### [Update-MgBetaIdentityConditionalAccessNamedLocation](Update-MgBetaIdentityConditionalAccessNamedLocation.md)
Update the navigation property namedLocations in identity

### [Update-MgBetaIdentityConditionalAccessPolicy](Update-MgBetaIdentityConditionalAccessPolicy.md)
Update the navigation property policies in identity

### [Update-MgBetaIdentityContinuouAccessEvaluationPolicy](Update-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Update the properties of a continuousAccessEvaluationPolicy object.

### [Update-MgBetaIdentityCustomAuthenticationExtension](Update-MgBetaIdentityCustomAuthenticationExtension.md)
Update the navigation property customAuthenticationExtensions in identity

### [Update-MgBetaIdentityProvider](Update-MgBetaIdentityProvider.md)
Update the navigation property identityProviders in identity

### [Update-MgBetaIdentityUserFlow](Update-MgBetaIdentityUserFlow.md)
Update the navigation property userFlows in identity

### [Update-MgBetaIdentityUserFlowAttribute](Update-MgBetaIdentityUserFlowAttribute.md)
Update the navigation property userFlowAttributes in identity

### [Update-MgBetaInformationProtection](Update-MgBetaInformationProtection.md)
Update informationProtection

### [Update-MgBetaInformationProtectionDataLossPreventionPolicy](Update-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Update the navigation property dataLossPreventionPolicies in informationProtection

### [Update-MgBetaInformationProtectionPolicy](Update-MgBetaInformationProtectionPolicy.md)
Update the navigation property policy in informationProtection

### [Update-MgBetaInformationProtectionPolicyLabel](Update-MgBetaInformationProtectionPolicyLabel.md)
Update the navigation property labels in informationProtection

### [Update-MgBetaInformationProtectionSensitivityPolicySetting](Update-MgBetaInformationProtectionSensitivityPolicySetting.md)
Update the navigation property sensitivityPolicySettings in informationProtection

### [Update-MgBetaInformationProtectionThreatAssessmentRequest](Update-MgBetaInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in informationProtection

### [Update-MgBetaInformationProtectionThreatAssessmentRequestResult](Update-MgBetaInformationProtectionThreatAssessmentRequestResult.md)
Update the navigation property results in informationProtection

### [Update-MgBetaOauth2PermissionGrant](Update-MgBetaOauth2PermissionGrant.md)
Update the properties of oAuth2PermissionGrant object, representing a delegated permission grant.
An **oAuth2PermissionGrant** can be updated to change which delegated permissions are granted, by adding or removing items from the list in **scopes**.

### [Update-MgBetaPolicyAccessReviewPolicy](Update-MgBetaPolicyAccessReviewPolicy.md)
Update the properties of an accessReviewPolicy object.

### [Update-MgBetaPolicyActivityBasedTimeoutPolicy](Update-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Update the navigation property activityBasedTimeoutPolicies in policies

### [Update-MgBetaPolicyAdminConsentRequestPolicy](Update-MgBetaPolicyAdminConsentRequestPolicy.md)
Update the properties of an adminConsentRequestPolicy object.

### [Update-MgBetaPolicyAppManagementPolicy](Update-MgBetaPolicyAppManagementPolicy.md)
Update the navigation property appManagementPolicies in policies

### [Update-MgBetaPolicyAuthenticationFlowPolicy](Update-MgBetaPolicyAuthenticationFlowPolicy.md)
Update the Boolean **selfServiceSignUp** property of an authenticationFlowsPolicy object.
The properties **id**, **type**, and **description** cannot be modified.

### [Update-MgBetaPolicyAuthenticationMethodPolicy](Update-MgBetaPolicyAuthenticationMethodPolicy.md)
Update the properties of an authenticationMethodsPolicy object.

### [Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Update the navigation property authenticationMethodConfigurations in policies

### [Update-MgBetaPolicyAuthenticationStrengthPolicy](Update-MgBetaPolicyAuthenticationStrengthPolicy.md)
Update the navigation property authenticationStrengthPolicies in policies

### [Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination](Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination.md)
Update the allowedCombinations property of an authenticationStrengthPolicy object.
To update other properties of an authenticationStrengthPolicy object, use the Update authenticationStrengthPolicy method.

### [Update-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Update-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the navigation property combinationConfigurations in policies

### [Update-MgBetaPolicyAuthorizationPolicy](Update-MgBetaPolicyAuthorizationPolicy.md)
Update the navigation property authorizationPolicy in policies

### [Update-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Update-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Update the navigation property defaultUserRoleOverrides in policies

### [Update-MgBetaPolicyB2CAuthenticationMethodPolicy](Update-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Update the properties of a b2cAuthenticationMethodsPolicy object.

### [Update-MgBetaPolicyClaimMappingPolicy](Update-MgBetaPolicyClaimMappingPolicy.md)
Update the navigation property claimsMappingPolicies in policies

### [Update-MgBetaPolicyCrossTenantAccessPolicy](Update-MgBetaPolicyCrossTenantAccessPolicy.md)
Update the properties of a cross-tenant access policy.

### [Update-MgBetaPolicyCrossTenantAccessPolicyDefault](Update-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Update the default configuration of a cross-tenant access policy.

### [Update-MgBetaPolicyCrossTenantAccessPolicyPartner](Update-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Update the navigation property partners in policies

### [Update-MgBetaPolicyDefaultAppManagementPolicy](Update-MgBetaPolicyDefaultAppManagementPolicy.md)
Update the properties of a tenantAppManagementPolicy object.

### [Update-MgBetaPolicyDirectoryRoleAccessReviewPolicy](Update-MgBetaPolicyDirectoryRoleAccessReviewPolicy.md)
Update the navigation property directoryRoleAccessReviewPolicy in policies

### [Update-MgBetaPolicyExternalIdentityPolicy](Update-MgBetaPolicyExternalIdentityPolicy.md)
Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls.

### [Update-MgBetaPolicyFeatureRolloutPolicy](Update-MgBetaPolicyFeatureRolloutPolicy.md)
Update the navigation property featureRolloutPolicies in policies

### [Update-MgBetaPolicyHomeRealmDiscoveryPolicy](Update-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Update the navigation property homeRealmDiscoveryPolicies in policies

### [Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Update the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Update-MgBetaPolicyMobileAppManagementPolicy](Update-MgBetaPolicyMobileAppManagementPolicy.md)
Update the navigation property mobileAppManagementPolicies in policies

### [Update-MgBetaPolicyMobileDeviceManagementPolicy](Update-MgBetaPolicyMobileDeviceManagementPolicy.md)
Update the navigation property mobileDeviceManagementPolicies in policies

### [Update-MgBetaPolicyPermissionGrantPolicy](Update-MgBetaPolicyPermissionGrantPolicy.md)
Update the navigation property permissionGrantPolicies in policies

### [Update-MgBetaPolicyPermissionGrantPolicyExclude](Update-MgBetaPolicyPermissionGrantPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgBetaPolicyPermissionGrantPolicyInclude](Update-MgBetaPolicyPermissionGrantPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgBetaPolicyRoleManagementPolicy](Update-MgBetaPolicyRoleManagementPolicy.md)
Update the navigation property roleManagementPolicies in policies

### [Update-MgBetaPolicyRoleManagementPolicyAssignment](Update-MgBetaPolicyRoleManagementPolicyAssignment.md)
Update the navigation property roleManagementPolicyAssignments in policies

### [Update-MgBetaPolicyRoleManagementPolicyEffectiveRule](Update-MgBetaPolicyRoleManagementPolicyEffectiveRule.md)
Update the navigation property effectiveRules in policies

### [Update-MgBetaPolicyRoleManagementPolicyRule](Update-MgBetaPolicyRoleManagementPolicyRule.md)
Update the navigation property rules in policies

### [Update-MgBetaPolicyServicePrincipalCreationPolicy](Update-MgBetaPolicyServicePrincipalCreationPolicy.md)
Update the navigation property servicePrincipalCreationPolicies in policies

### [Update-MgBetaPolicyServicePrincipalCreationPolicyExclude](Update-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgBetaPolicyServicePrincipalCreationPolicyInclude](Update-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgBetaPolicyTokenIssuancePolicy](Update-MgBetaPolicyTokenIssuancePolicy.md)
Update the navigation property tokenIssuancePolicies in policies

### [Update-MgBetaPolicyTokenLifetimePolicy](Update-MgBetaPolicyTokenLifetimePolicy.md)
Update the navigation property tokenLifetimePolicies in policies

### [Update-MgBetaRiskDetection](Update-MgBetaRiskDetection.md)
Update the navigation property riskDetections in identityProtection

### [Update-MgBetaRiskyServicePrincipal](Update-MgBetaRiskyServicePrincipal.md)
Update the navigation property riskyServicePrincipals in identityProtection

### [Update-MgBetaRiskyServicePrincipalHistory](Update-MgBetaRiskyServicePrincipalHistory.md)
Update the navigation property history in identityProtection

### [Update-MgBetaRiskyUser](Update-MgBetaRiskyUser.md)
Update the navigation property riskyUsers in identityProtection

### [Update-MgBetaRiskyUserHistory](Update-MgBetaRiskyUserHistory.md)
Update the navigation property history in identityProtection

### [Update-MgBetaServicePrincipalRiskDetection](Update-MgBetaServicePrincipalRiskDetection.md)
Update the navigation property servicePrincipalRiskDetections in identityProtection

### [Update-MgBetaTrustFramework](Update-MgBetaTrustFramework.md)
Update trustFramework

### [Update-MgBetaTrustFrameworkKeySet](Update-MgBetaTrustFrameworkKeySet.md)
Update the navigation property keySets in trustFramework

### [Update-MgBetaTrustFrameworkPolicy](Update-MgBetaTrustFrameworkPolicy.md)
Update the navigation property policies in trustFramework

### [Update-MgBetaUserAuthenticationEmailMethod](Update-MgBetaUserAuthenticationEmailMethod.md)
Update the navigation property emailMethods in users

### [Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice](Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
Update the navigation property device in users

### [Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Update-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgBetaUserAuthenticationOperation](Update-MgBetaUserAuthenticationOperation.md)
Update the navigation property operations in users

### [Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Update the navigation property device in users

### [Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Update-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgBetaUserAuthenticationPhoneMethod](Update-MgBetaUserAuthenticationPhoneMethod.md)
Update the navigation property phoneMethods in users

### [Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice](Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Update the navigation property device in users

### [Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Update-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgBetaUserInformationProtection](Update-MgBetaUserInformationProtection.md)
Update the navigation property informationProtection in users

### [Update-MgBetaUserInformationProtectionDataLossPreventionPolicy](Update-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Update the navigation property dataLossPreventionPolicies in users

### [Update-MgBetaUserInformationProtectionPolicy](Update-MgBetaUserInformationProtectionPolicy.md)
Update the navigation property policy in users

### [Update-MgBetaUserInformationProtectionPolicyLabel](Update-MgBetaUserInformationProtectionPolicyLabel.md)
Update the navigation property labels in users

### [Update-MgBetaUserInformationProtectionSensitivityLabel](Update-MgBetaUserInformationProtectionSensitivityLabel.md)
Update the navigation property sensitivityLabels in users

### [Update-MgBetaUserInformationProtectionSensitivityLabelSublabel](Update-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Update the navigation property sublabels in users

### [Update-MgBetaUserInformationProtectionSensitivityPolicySetting](Update-MgBetaUserInformationProtectionSensitivityPolicySetting.md)
Update the navigation property sensitivityPolicySettings in users

### [Update-MgBetaUserInformationProtectionThreatAssessmentRequest](Update-MgBetaUserInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in users

### [Update-MgBetaUserInformationProtectionThreatAssessmentRequestResult](Update-MgBetaUserInformationProtectionThreatAssessmentRequestResult.md)
Update the navigation property results in users

