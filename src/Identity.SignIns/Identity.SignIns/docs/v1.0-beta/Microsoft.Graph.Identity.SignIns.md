---
Module Name: Microsoft.Graph.Identity.SignIns
Module Guid: 73f78801-bd1c-4ef7-aab2-7b8ee8b082aa
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

### [Confirm-MgRiskyServicePrincipalCompromised](Confirm-MgRiskyServicePrincipalCompromised.md)
Confirm one or more riskyServicePrincipal objects as compromised.
This action sets the targeted service principal account's risk level to `high`.

### [Confirm-MgRiskyUserCompromised](Confirm-MgRiskyUserCompromised.md)
Confirm one or more riskyUser objects as compromised.
This action sets the targeted user's risk level to high.

### [Find-MgIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode](Find-MgIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Find-MgPolicyAuthenticationStrengthPolicyByMethodMode](Find-MgPolicyAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Get-MgDataPolicyOperation](Get-MgDataPolicyOperation.md)
Retrieve the properties of the dataPolicyOperation object.

### [Get-MgIdentityApiConnector](Get-MgIdentityApiConnector.md)
Represents entry point for API connectors.

### [Get-MgIdentityAuthenticationEventListener](Get-MgIdentityAuthenticationEventListener.md)
Get authenticationEventListeners from identity

### [Get-MgIdentityB2CUserFlow](Get-MgIdentityB2CUserFlow.md)
Represents entry point for B2C identity userflows.

### [Get-MgIdentityB2CUserFlowIdentityProvider](Get-MgIdentityB2CUserFlowIdentityProvider.md)
Get userFlowIdentityProviders from identity

### [Get-MgIdentityB2CUserFlowIdentityProviderByRef](Get-MgIdentityB2CUserFlowIdentityProviderByRef.md)
Get the identity providers in a b2cIdentityUserFlow object.

### [Get-MgIdentityB2CUserFlowLanguage](Get-MgIdentityB2CUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is not enabled by default in B2C user flows.

### [Get-MgIdentityB2CUserFlowLanguageDefaultPage](Get-MgIdentityB2CUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgIdentityB2CUserFlowLanguageDefaultPageContent](Get-MgIdentityB2CUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgIdentityB2CUserFlowLanguageOverridePage](Get-MgIdentityB2CUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgIdentityB2CUserFlowLanguageOverridePageContent](Get-MgIdentityB2CUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgIdentityB2CUserFlowUserAttributeAssignment](Get-MgIdentityB2CUserFlowUserAttributeAssignment.md)
The user attribute assignments included in the user flow.

### [Get-MgIdentityB2CUserFlowUserAttributeAssignmentOrder](Get-MgIdentityB2CUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgIdentityB2CUserFlowUserAttributeAssignmentUserAttribute](Get-MgIdentityB2CUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgIdentityB2XUserFlow](Get-MgIdentityB2XUserFlow.md)
Represents entry point for B2X and self-service sign-up identity userflows.

### [Get-MgIdentityB2XUserFlowIdentityProvider](Get-MgIdentityB2XUserFlowIdentityProvider.md)
Get identityProviders from identity

### [Get-MgIdentityB2XUserFlowIdentityProviderByRef](Get-MgIdentityB2XUserFlowIdentityProviderByRef.md)
Get ref of userFlowIdentityProviders from identity

### [Get-MgIdentityB2XUserFlowLanguage](Get-MgIdentityB2XUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is enabled by default in self-service sign up user flow.
You cannot create custom languages in self-service sign up user flows.

### [Get-MgIdentityB2XUserFlowLanguageDefaultPage](Get-MgIdentityB2XUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgIdentityB2XUserFlowLanguageDefaultPageContent](Get-MgIdentityB2XUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgIdentityB2XUserFlowLanguageOverridePage](Get-MgIdentityB2XUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgIdentityB2XUserFlowLanguageOverridePageContent](Get-MgIdentityB2XUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgIdentityB2XUserFlowUserAttributeAssignment](Get-MgIdentityB2XUserFlowUserAttributeAssignment.md)
The user attribute assignments included in the user flow.

### [Get-MgIdentityB2XUserFlowUserAttributeAssignmentOrder](Get-MgIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgIdentityB2XUserFlowUserAttributeAssignmentUserAttribute](Get-MgIdentityB2XUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgIdentityConditionalAccessAuthenticationContextClassReference](Get-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Read-only.
Nullable.
Returns a collection of the specified authentication context class references.

### [Get-MgIdentityConditionalAccessAuthenticationStrength](Get-MgIdentityConditionalAccessAuthenticationStrength.md)
Defines the authentication strength policies, valid authentication method combinations, and authentication method mode details that can be required by a conditional access policy .

### [Get-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Get-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Names and descriptions of all valid authentication method modes in the system.

### [Get-MgIdentityConditionalAccessAuthenticationStrengthPolicy](Get-MgIdentityConditionalAccessAuthenticationStrengthPolicy.md)
A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.

### [Get-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Get-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.

### [Get-MgIdentityConditionalAccessNamedLocation](Get-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Get-MgIdentityConditionalAccessPolicy](Get-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access policies.

### [Get-MgIdentityConditionalAccessTemplate](Get-MgIdentityConditionalAccessTemplate.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access templates.

### [Get-MgIdentityContinuouAccessEvaluationPolicy](Get-MgIdentityContinuouAccessEvaluationPolicy.md)
Read the properties and relationships of a continuousAccessEvaluationPolicy object.

### [Get-MgIdentityCustomAuthenticationExtension](Get-MgIdentityCustomAuthenticationExtension.md)
Get customAuthenticationExtensions from identity

### [Get-MgIdentityProvider](Get-MgIdentityProvider.md)
Represents entry point for identity provider base.

### [Get-MgIdentityUserFlow](Get-MgIdentityUserFlow.md)
Get userFlows from identity

### [Get-MgIdentityUserFlowAttribute](Get-MgIdentityUserFlowAttribute.md)
Represents entry point for identity userflow attributes.

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
Retrieve the properties of a single delegated permission grant represented by an oAuth2PermissionGrant object.
An **oAuth2PermissionGrant** represents delegated permissions which have been granted for a client application to access an API on behalf of a signed-in user.

### [Get-MgOauth2PermissionGrantDelta](Get-MgOauth2PermissionGrantDelta.md)
Invoke function delta

### [Get-MgOrganizationCertificateBasedAuthConfiguration](Get-MgOrganizationCertificateBasedAuthConfiguration.md)
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgPolicyAccessReviewPolicy](Get-MgPolicyAccessReviewPolicy.md)
Read the properties and relationships of an accessReviewPolicy object.

### [Get-MgPolicyActivityBasedTimeoutPolicy](Get-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Get-MgPolicyAdminConsentRequestPolicy](Get-MgPolicyAdminConsentRequestPolicy.md)
Read the properties and relationships of an adminConsentRequestPolicy object.

### [Get-MgPolicyAppManagementPolicy](Get-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Get-MgPolicyAppManagementPolicyApplyTo](Get-MgPolicyAppManagementPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgPolicyAuthenticationFlowPolicy](Get-MgPolicyAuthenticationFlowPolicy.md)
Read the properties and relationships of an authenticationFlowsPolicy object.

### [Get-MgPolicyAuthenticationMethodPolicy](Get-MgPolicyAuthenticationMethodPolicy.md)
Read the properties and relationships of an authenticationMethodsPolicy object.

### [Get-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Get-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Represents the settings for each authentication method.
Automatically expanded on GET /policies/authenticationMethodsPolicy.

### [Get-MgPolicyAuthenticationStrengthPolicy](Get-MgPolicyAuthenticationStrengthPolicy.md)
The authentication method combinations that are to be used in scenarios defined by Azure AD Conditional Access.

### [Get-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](Get-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.

### [Get-MgPolicyAuthorizationPolicy](Get-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Get-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Get-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Get defaultUserRoleOverrides from policies

### [Get-MgPolicyB2CAuthenticationMethodPolicy](Get-MgPolicyB2CAuthenticationMethodPolicy.md)
Read the properties of a b2cAuthenticationMethodsPolicy object.

### [Get-MgPolicyClaimMappingPolicy](Get-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Get-MgPolicyCrossTenantAccessPolicy](Get-MgPolicyCrossTenantAccessPolicy.md)
Read the properties and relationships of a crossTenantAccessPolicy object.

### [Get-MgPolicyCrossTenantAccessPolicyDefault](Get-MgPolicyCrossTenantAccessPolicyDefault.md)
Read the default configuration of a cross-tenant access policy.
This default configuration may be the service default assigned by Azure AD (**isServiceDefault** is `true`) or may be customized in your tenant (**isServiceDefault** is `false`).

### [Get-MgPolicyCrossTenantAccessPolicyPartner](Get-MgPolicyCrossTenantAccessPolicyPartner.md)
Defines partner-specific configurations for external Azure Active Directory organizations.

### [Get-MgPolicyDefaultAppManagementPolicy](Get-MgPolicyDefaultAppManagementPolicy.md)
Read the properties of a tenantAppManagementPolicy object.

### [Get-MgPolicyDeviceRegistrationPolicy](Get-MgPolicyDeviceRegistrationPolicy.md)
Read the properties and relationships of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

### [Get-MgPolicyDirectoryRoleAccessReviewPolicy](Get-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Get directoryRoleAccessReviewPolicy from policies

### [Get-MgPolicyExternalIdentityPolicy](Get-MgPolicyExternalIdentityPolicy.md)
Read the properties and relationships of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls.

### [Get-MgPolicyFeatureRolloutPolicy](Get-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Get-MgPolicyFeatureRolloutPolicyApplyTo](Get-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyFeatureRolloutPolicyApplyToById](Get-MgPolicyFeatureRolloutPolicyApplyToById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgPolicyFeatureRolloutPolicyApplyToByRef](Get-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyFeatureRolloutPolicyApplyToUserOwnedObject](Get-MgPolicyFeatureRolloutPolicyApplyToUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgPolicyHomeRealmDiscoveryPolicy](Get-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Retrieve the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Get-MgPolicyMobileAppManagementPolicy](Get-MgPolicyMobileAppManagementPolicy.md)
The policy that defines auto-enrollment configuration for a mobility management (MDM or MAM) application.

### [Get-MgPolicyMobileAppManagementPolicyIncludedGroup](Get-MgPolicyMobileAppManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgPolicyMobileAppManagementPolicyIncludedGroupByRef](Get-MgPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgPolicyMobileDeviceManagementPolicy](Get-MgPolicyMobileDeviceManagementPolicy.md)
Get mobileDeviceManagementPolicies from policies

### [Get-MgPolicyMobileDeviceManagementPolicyIncludedGroup](Get-MgPolicyMobileDeviceManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Get-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

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
The policy that's associated with a policy assignment.
Supports $expand and a nested $expand of the rules and effectiveRules relationships for the policy.

### [Get-MgPolicyRoleManagementPolicyEffectiveRule](Get-MgPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules.
For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval.
Supports $expand.

### [Get-MgPolicyRoleManagementPolicyRule](Get-MgPolicyRoleManagementPolicyRule.md)
The collection of rules like approval rules and expiration rules.
Supports $expand.

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
Risk detection in Azure AD Identity Protection and the associated information about the detection.

### [Get-MgRiskyServicePrincipal](Get-MgRiskyServicePrincipal.md)
Azure AD service principals that are at risk.

### [Get-MgRiskyServicePrincipalHistory](Get-MgRiskyServicePrincipalHistory.md)
Represents the risk history of Azure AD service principals.

### [Get-MgRiskyUser](Get-MgRiskyUser.md)
Users that are flagged as at-risk by Azure AD Identity Protection.

### [Get-MgRiskyUserHistory](Get-MgRiskyUserHistory.md)
Get history from identityProtection

### [Get-MgServicePrincipalRiskDetection](Get-MgServicePrincipalRiskDetection.md)
Represents information about detected at-risk service principals in an Azure AD tenant.

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
Represents the email addresses registered to a user for authentication.

### [Get-MgUserAuthenticationFido2Method](Get-MgUserAuthenticationFido2Method.md)
Represents the FIDO2 security keys registered to a user for authentication.

### [Get-MgUserAuthenticationMethod](Get-MgUserAuthenticationMethod.md)
Represents all authentication methods registered to a user.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
The details of the Microsoft Authenticator app registered to a user for authentication.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommandResponsepayload](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberOf](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwner](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredUser](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgUserAuthenticationOperation](Get-MgUserAuthenticationOperation.md)
Get operations from users

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Represents the Microsoft Authenticator Passwordless Phone Sign-in methods registered to a user for authentication.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Get device from users

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommandResponsepayload](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberOf](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwner](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredUser](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgUserAuthenticationPasswordMethod](Get-MgUserAuthenticationPasswordMethod.md)
Represents the details of the password authentication method registered to a user for authentication.

### [Get-MgUserAuthenticationPhoneMethod](Get-MgUserAuthenticationPhoneMethod.md)
Represents the phone registered to a user for authentication.

### [Get-MgUserAuthenticationSoftwareOathMethod](Get-MgUserAuthenticationSoftwareOathMethod.md)
Get softwareOathMethods from users

### [Get-MgUserAuthenticationTemporaryAccessPassMethod](Get-MgUserAuthenticationTemporaryAccessPassMethod.md)
Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethod](Get-MgUserAuthenticationWindowHelloForBusinessMethod.md)
Represents the Windows Hello for Business authentication method registered to a user for authentication.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommandResponsepayload](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberOf](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwner](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredUser](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceTransitiveMemberOf](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Get-MgUserInformationProtection](Get-MgUserInformationProtection.md)
Get informationProtection from users

### [Get-MgUserInformationProtectionBitlocker](Get-MgUserInformationProtectionBitlocker.md)
Get bitlocker from users

### [Get-MgUserInformationProtectionBitlockerRecoveryKey](Get-MgUserInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Get-MgUserInformationProtectionDataLossPreventionPolicy](Get-MgUserInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from users

### [Get-MgUserInformationProtectionPolicy](Get-MgUserInformationProtectionPolicy.md)
Get policy from users

### [Get-MgUserInformationProtectionPolicyLabel](Get-MgUserInformationProtectionPolicyLabel.md)
Get labels from users

### [Get-MgUserInformationProtectionSensitivityLabel](Get-MgUserInformationProtectionSensitivityLabel.md)
Get sensitivityLabels from users

### [Get-MgUserInformationProtectionSensitivityLabelSublabel](Get-MgUserInformationProtectionSensitivityLabelSublabel.md)
Get sublabels from users

### [Get-MgUserInformationProtectionSensitivityPolicySetting](Get-MgUserInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from users

### [Get-MgUserInformationProtectionThreatAssessmentRequest](Get-MgUserInformationProtectionThreatAssessmentRequest.md)
Get threatAssessmentRequests from users

### [Get-MgUserInformationProtectionThreatAssessmentRequestResult](Get-MgUserInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Invoke-MgAvailableIdentityProviderType](Invoke-MgAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgBufferInformationProtectionDecrypt](Invoke-MgBufferInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBufferInformationProtectionEncrypt](Invoke-MgBufferInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgDismissRiskyServicePrincipal](Invoke-MgDismissRiskyServicePrincipal.md)
Dismiss the risk of one or more riskyServicePrincipal objects.
This action sets the targeted service principal account's risk level to `none`.
You can dismiss up to 60 service principal accounts in one request.

### [Invoke-MgDismissRiskyUser](Invoke-MgDismissRiskyUser.md)
Dismiss the risk of one or more riskyUser objects.
This action sets the targeted user's risk level to none.
The maximum count of users to dismiss in one call is 60.

### [Invoke-MgExtractInformationProtectionPolicyLabel](Invoke-MgExtractInformationProtectionPolicyLabel.md)
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

### [Invoke-MgSignInformationProtectionDigest](Invoke-MgSignInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgUploadIdentityApiConnectorClientCertificate](Invoke-MgUploadIdentityApiConnectorClientCertificate.md)
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

### [Invoke-MgUploadTrustFrameworkKeySetCertificate](Invoke-MgUploadTrustFrameworkKeySetCertificate.md)
Upload a certificate to a trustFrameworkKeyset.
The input is a base-64 encoded value of the certificate contents.
This method returns trustFrameworkKey.

### [Invoke-MgUploadTrustFrameworkKeySetPkcs12](Invoke-MgUploadTrustFrameworkKeySetPkcs12.md)
Upload a PKCS12 format key (PFX) to a trustFrameworkKeyset.
The input is a base-64 encoded value of the Pfx certificate contents.
This method returns trustFrameworkKey.

### [Invoke-MgUploadTrustFrameworkKeySetSecret](Invoke-MgUploadTrustFrameworkKeySetSecret.md)
Upload a plain text secret to a trustFrameworkKeyset.
Examples of secrets are application secrets in Azure Active Directory, Google, Facebook, or any other identity provider.
his method returns trustFrameworkKey.

### [Invoke-MgUsageIdentityConditionalAccessAuthenticationStrengthPolicy](Invoke-MgUsageIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Invoke function usage

### [Invoke-MgUsagePolicyAuthenticationStrengthPolicy](Invoke-MgUsagePolicyAuthenticationStrengthPolicy.md)
Invoke function usage

### [New-MgDataPolicyOperation](New-MgDataPolicyOperation.md)
Add new entity to dataPolicyOperations

### [New-MgIdentityApiConnector](New-MgIdentityApiConnector.md)
Create a new identityApiConnector object.

### [New-MgIdentityAuthenticationEventListener](New-MgIdentityAuthenticationEventListener.md)
Create new navigation property to authenticationEventListeners for identity

### [New-MgIdentityB2CUserFlow](New-MgIdentityB2CUserFlow.md)
Create a new b2cIdentityUserFlow object.

### [New-MgIdentityB2CUserFlowIdentityProviderByRef](New-MgIdentityB2CUserFlowIdentityProviderByRef.md)
Create new navigation property ref to identityProviders for identity

### [New-MgIdentityB2CUserFlowLanguage](New-MgIdentityB2CUserFlowLanguage.md)
Create new navigation property to languages for identity

### [New-MgIdentityB2CUserFlowLanguageDefaultPage](New-MgIdentityB2CUserFlowLanguageDefaultPage.md)
Create new navigation property to defaultPages for identity

### [New-MgIdentityB2CUserFlowLanguageOverridePage](New-MgIdentityB2CUserFlowLanguageOverridePage.md)
Create new navigation property to overridesPages for identity

### [New-MgIdentityB2CUserFlowUserAttributeAssignment](New-MgIdentityB2CUserFlowUserAttributeAssignment.md)
Create a new identityUserFlowAttributeAssignment object in a b2cIdentityUserFlow.

### [New-MgIdentityB2XUserFlow](New-MgIdentityB2XUserFlow.md)
Create a new b2xIdentityUserFlow object.

### [New-MgIdentityB2XUserFlowIdentityProviderByRef](New-MgIdentityB2XUserFlowIdentityProviderByRef.md)
Create new navigation property ref to userFlowIdentityProviders for identity

### [New-MgIdentityB2XUserFlowLanguage](New-MgIdentityB2XUserFlowLanguage.md)
Create new navigation property to languages for identity

### [New-MgIdentityB2XUserFlowLanguageDefaultPage](New-MgIdentityB2XUserFlowLanguageDefaultPage.md)
Create new navigation property to defaultPages for identity

### [New-MgIdentityB2XUserFlowLanguageOverridePage](New-MgIdentityB2XUserFlowLanguageOverridePage.md)
Create new navigation property to overridesPages for identity

### [New-MgIdentityB2XUserFlowUserAttributeAssignment](New-MgIdentityB2XUserFlowUserAttributeAssignment.md)
Create a new identityUserFlowAttributeAssignment object in a b2xIdentityUserFlow.

### [New-MgIdentityConditionalAccessAuthenticationContextClassReference](New-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Create a new authenticationContextClassReference.

### [New-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](New-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Create new navigation property to authenticationMethodModes for identity

### [New-MgIdentityConditionalAccessAuthenticationStrengthPolicy](New-MgIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Create new navigation property to policies for identity

### [New-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](New-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Create a new authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be created, and these may only be created for custom authentication strength policies.

### [New-MgIdentityConditionalAccessNamedLocation](New-MgIdentityConditionalAccessNamedLocation.md)
Create a new namedLocation object.
Named locations can be either ipNamedLocation or countryNamedLocation objects.

### [New-MgIdentityConditionalAccessPolicy](New-MgIdentityConditionalAccessPolicy.md)
Create a new conditionalAccessPolicy.

### [New-MgIdentityCustomAuthenticationExtension](New-MgIdentityCustomAuthenticationExtension.md)
Create new navigation property to customAuthenticationExtensions for identity

### [New-MgIdentityProvider](New-MgIdentityProvider.md)
Create an identity provider resource that is of the type specified in the request body.
Among the types of providers derived from identityProviderBase, you can currently create a socialIdentityProvider resource in Azure AD.
In Azure AD B2C, this operation can currently create a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

### [New-MgIdentityUserFlow](New-MgIdentityUserFlow.md)
Create a new userFlow object.

### [New-MgIdentityUserFlowAttribute](New-MgIdentityUserFlowAttribute.md)
Create a new identityUserFlowAttribute object.

### [New-MgInformationProtectionDataLossPreventionPolicy](New-MgInformationProtectionDataLossPreventionPolicy.md)
Create new navigation property to dataLossPreventionPolicies for informationProtection

### [New-MgInformationProtectionPolicyLabel](New-MgInformationProtectionPolicyLabel.md)
Create new navigation property to labels for informationProtection

### [New-MgInformationProtectionThreatAssessmentRequest](New-MgInformationProtectionThreatAssessmentRequest.md)
Create a new threat assessment request.
A threat assessment request can be one of the following types:

### [New-MgInformationProtectionThreatAssessmentRequestResult](New-MgInformationProtectionThreatAssessmentRequestResult.md)
Create new navigation property to results for informationProtection

### [New-MgInvitation](New-MgInvitation.md)
Use this API to create a new invitation.
Invitation adds an external user to the organization.
When creating a new invitation you have several options available:

### [New-MgOauth2PermissionGrant](New-MgOauth2PermissionGrant.md)
Create a delegated permission grant, represented by an oAuth2PermissionGrant object.
A delegated permission grant authorizes a client service principal (representing a client application) to access a resource service principal (representing an API), on behalf of a signed-in user, for the level of access limited by the delegated permissions which were granted.

### [New-MgPolicyActivityBasedTimeoutPolicy](New-MgPolicyActivityBasedTimeoutPolicy.md)
Create a new activityBasedTimeoutPolicy object.

### [New-MgPolicyAppManagementPolicy](New-MgPolicyAppManagementPolicy.md)
Create an appManagementPolicy object.

### [New-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](New-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Create new navigation property to authenticationMethodConfigurations for policies

### [New-MgPolicyAuthenticationStrengthPolicy](New-MgPolicyAuthenticationStrengthPolicy.md)
Create a new custom authenticationStrengthPolicy object.

### [New-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](New-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Create a new authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be created, and these may only be created for custom authentication strength policies.

### [New-MgPolicyAuthorizationPolicy](New-MgPolicyAuthorizationPolicy.md)
Create new navigation property to authorizationPolicy for policies

### [New-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](New-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Create new navigation property to defaultUserRoleOverrides for policies

### [New-MgPolicyClaimMappingPolicy](New-MgPolicyClaimMappingPolicy.md)
Create a new claimsMappingPolicy object.

### [New-MgPolicyCrossTenantAccessPolicyPartner](New-MgPolicyCrossTenantAccessPolicyPartner.md)
Create a new partner configuration in a cross-tenant access policy.

### [New-MgPolicyFeatureRolloutPolicy](New-MgPolicyFeatureRolloutPolicy.md)
Create a new featureRolloutPolicy object.

### [New-MgPolicyFeatureRolloutPolicyApplyTo](New-MgPolicyFeatureRolloutPolicyApplyTo.md)
Create new navigation property to appliesTo for policies

### [New-MgPolicyFeatureRolloutPolicyApplyToByRef](New-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Create new navigation property ref to appliesTo for policies

### [New-MgPolicyHomeRealmDiscoveryPolicy](New-MgPolicyHomeRealmDiscoveryPolicy.md)
Create a new homeRealmDiscoveryPolicy object.

### [New-MgPolicyMobileAppManagementPolicy](New-MgPolicyMobileAppManagementPolicy.md)
Create new navigation property to mobileAppManagementPolicies for policies

### [New-MgPolicyMobileAppManagementPolicyIncludedGroupByRef](New-MgPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Create new navigation property ref to includedGroups for policies

### [New-MgPolicyMobileDeviceManagementPolicy](New-MgPolicyMobileDeviceManagementPolicy.md)
Create new navigation property to mobileDeviceManagementPolicies for policies

### [New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef](New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Create new navigation property ref to includedGroups for policies

### [New-MgPolicyPermissionGrantPolicy](New-MgPolicyPermissionGrantPolicy.md)
Creates a permissionGrantPolicy.
A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).
After creating the permission grant policy, you can add include condition sets to add matching rules, and add exclude condition sets to add exclusion rules.

### [New-MgPolicyPermissionGrantPolicyExclude](New-MgPolicyPermissionGrantPolicyExclude.md)
Add conditions under which a permission grant event is *excluded* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **excludes** collection of a  permissionGrantPolicy.

### [New-MgPolicyPermissionGrantPolicyInclude](New-MgPolicyPermissionGrantPolicyInclude.md)
Add conditions under which a permission grant event is *included* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the **includes** collection of a  permissionGrantPolicy.

### [New-MgPolicyRoleManagementPolicy](New-MgPolicyRoleManagementPolicy.md)
Create new navigation property to roleManagementPolicies for policies

### [New-MgPolicyRoleManagementPolicyAssignment](New-MgPolicyRoleManagementPolicyAssignment.md)
Create new navigation property to roleManagementPolicyAssignments for policies

### [New-MgPolicyRoleManagementPolicyEffectiveRule](New-MgPolicyRoleManagementPolicyEffectiveRule.md)
Create new navigation property to effectiveRules for policies

### [New-MgPolicyRoleManagementPolicyRule](New-MgPolicyRoleManagementPolicyRule.md)
Create new navigation property to rules for policies

### [New-MgPolicyServicePrincipalCreationPolicy](New-MgPolicyServicePrincipalCreationPolicy.md)
Create new navigation property to servicePrincipalCreationPolicies for policies

### [New-MgPolicyServicePrincipalCreationPolicyExclude](New-MgPolicyServicePrincipalCreationPolicyExclude.md)
Create new navigation property to excludes for policies

### [New-MgPolicyServicePrincipalCreationPolicyInclude](New-MgPolicyServicePrincipalCreationPolicyInclude.md)
Create new navigation property to includes for policies

### [New-MgPolicyTokenIssuancePolicy](New-MgPolicyTokenIssuancePolicy.md)
Create a new tokenIssuancePolicy object.

### [New-MgPolicyTokenLifetimePolicy](New-MgPolicyTokenLifetimePolicy.md)
Create a new tokenLifetimePolicy object.

### [New-MgRiskDetection](New-MgRiskDetection.md)
Create new navigation property to riskDetections for identityProtection

### [New-MgRiskyServicePrincipal](New-MgRiskyServicePrincipal.md)
Create new navigation property to riskyServicePrincipals for identityProtection

### [New-MgRiskyServicePrincipalHistory](New-MgRiskyServicePrincipalHistory.md)
Create new navigation property to history for identityProtection

### [New-MgRiskyUser](New-MgRiskyUser.md)
Create new navigation property to riskyUsers for identityProtection

### [New-MgRiskyUserHistory](New-MgRiskyUserHistory.md)
Create new navigation property to history for identityProtection

### [New-MgServicePrincipalRiskDetection](New-MgServicePrincipalRiskDetection.md)
Create new navigation property to servicePrincipalRiskDetections for identityProtection

### [New-MgTrustFrameworkKeySet](New-MgTrustFrameworkKeySet.md)
Create a new trustFrameworkKeySet.
The ID of the **trustFrameworkKeySet** is expected in the create request; however, it can be modified by the service.
The modified ID will be available in the response and in the location header.

### [New-MgTrustFrameworkKeySetKey](New-MgTrustFrameworkKeySetKey.md)
Generate a trustFrameworkKey and a secret automatically in the trustFrameworkKeyset.
The caller doesn't have to provide a secret.

### [New-MgTrustFrameworkPolicy](New-MgTrustFrameworkPolicy.md)
Create new navigation property to policies for trustFramework

### [New-MgUserAuthenticationEmailMethod](New-MgUserAuthenticationEmailMethod.md)
Set a user's emailAuthenticationMethod object.
Email authentication is a self-service password reset method.
A user may only have one email authentication method.

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](New-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgUserAuthenticationOperation](New-MgUserAuthenticationOperation.md)
Create new navigation property to operations for users

### [New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](New-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgUserAuthenticationPhoneMethod](New-MgUserAuthenticationPhoneMethod.md)
Add a new phone authentication method.
A user may only have one phone of each type, captured in the **phoneType** property.
This means, for example, adding a `mobile` phone to a user with a preexisting `mobile` phone will fail.
Additionally, a user must always have a `mobile` phone before adding an `alternateMobile` phone.
Adding a phone number makes it available for use in both Azure multi-factor authentication (MFA) and self-service password reset (SSPR), if enabled.
Additionally, if a user is enabled by policy to use SMS sign-in and a `mobile` number is added, the system will attempt to register the number for use in that system.

### [New-MgUserAuthenticationTemporaryAccessPassMethod](New-MgUserAuthenticationTemporaryAccessPassMethod.md)
Create a new temporaryAccessPassAuthenticationMethod object on a user.
A user can only have one Temporary Access Pass that's usable within its specified lifetime.
If the user requires a new Temporary Access Pass while the current Temporary Access Pass is valid, the admin can create a new Temporary Access Pass for the user, the previous Temporary Access Pass will be deleted, and a new Temporary Access Pass will be created.

### [New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](New-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [New-MgUserInformationProtectionDataLossPreventionPolicy](New-MgUserInformationProtectionDataLossPreventionPolicy.md)
Create new navigation property to dataLossPreventionPolicies for users

### [New-MgUserInformationProtectionPolicyLabel](New-MgUserInformationProtectionPolicyLabel.md)
Create new navigation property to labels for users

### [New-MgUserInformationProtectionSensitivityLabel](New-MgUserInformationProtectionSensitivityLabel.md)
Create new navigation property to sensitivityLabels for users

### [New-MgUserInformationProtectionSensitivityLabelSublabel](New-MgUserInformationProtectionSensitivityLabelSublabel.md)
Create new navigation property to sublabels for users

### [New-MgUserInformationProtectionThreatAssessmentRequest](New-MgUserInformationProtectionThreatAssessmentRequest.md)
Create a new threat assessment request.
A threat assessment request can be one of the following types:

### [New-MgUserInformationProtectionThreatAssessmentRequestResult](New-MgUserInformationProtectionThreatAssessmentRequestResult.md)
Create new navigation property to results for users

### [Remove-MgDataPolicyOperation](Remove-MgDataPolicyOperation.md)
Delete entity from dataPolicyOperations

### [Remove-MgIdentityApiConnector](Remove-MgIdentityApiConnector.md)
Delete navigation property apiConnectors for identity

### [Remove-MgIdentityAuthenticationEventListener](Remove-MgIdentityAuthenticationEventListener.md)
Delete navigation property authenticationEventListeners for identity

### [Remove-MgIdentityB2CUserFlow](Remove-MgIdentityB2CUserFlow.md)
Delete navigation property b2cUserFlows for identity

### [Remove-MgIdentityB2CUserFlowIdentityProviderByRef](Remove-MgIdentityB2CUserFlowIdentityProviderByRef.md)
Delete ref of navigation property identityProviders for identity

### [Remove-MgIdentityB2CUserFlowLanguage](Remove-MgIdentityB2CUserFlowLanguage.md)
Delete navigation property languages for identity

### [Remove-MgIdentityB2CUserFlowLanguageDefaultPage](Remove-MgIdentityB2CUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgIdentityB2CUserFlowLanguageOverridePage](Remove-MgIdentityB2CUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgIdentityB2CUserFlowUserAttributeAssignment](Remove-MgIdentityB2CUserFlowUserAttributeAssignment.md)
Delete navigation property userAttributeAssignments for identity

### [Remove-MgIdentityB2XUserFlow](Remove-MgIdentityB2XUserFlow.md)
Delete navigation property b2xUserFlows for identity

### [Remove-MgIdentityB2XUserFlowIdentityProviderByRef](Remove-MgIdentityB2XUserFlowIdentityProviderByRef.md)
Delete ref of navigation property userFlowIdentityProviders for identity

### [Remove-MgIdentityB2XUserFlowLanguage](Remove-MgIdentityB2XUserFlowLanguage.md)
Delete navigation property languages for identity

### [Remove-MgIdentityB2XUserFlowLanguageDefaultPage](Remove-MgIdentityB2XUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgIdentityB2XUserFlowLanguageOverridePage](Remove-MgIdentityB2XUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgIdentityB2XUserFlowUserAttributeAssignment](Remove-MgIdentityB2XUserFlowUserAttributeAssignment.md)
Delete navigation property userAttributeAssignments for identity

### [Remove-MgIdentityConditionalAccessAuthenticationContextClassReference](Remove-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Delete navigation property authenticationContextClassReferences for identity

### [Remove-MgIdentityConditionalAccessAuthenticationStrength](Remove-MgIdentityConditionalAccessAuthenticationStrength.md)
Delete navigation property authenticationStrengths for identity

### [Remove-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Remove-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Delete navigation property authenticationMethodModes for identity

### [Remove-MgIdentityConditionalAccessAuthenticationStrengthPolicy](Remove-MgIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Delete navigation property policies for identity

### [Remove-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete navigation property combinationConfigurations for identity

### [Remove-MgIdentityConditionalAccessNamedLocation](Remove-MgIdentityConditionalAccessNamedLocation.md)
Delete navigation property namedLocations for identity

### [Remove-MgIdentityConditionalAccessPolicy](Remove-MgIdentityConditionalAccessPolicy.md)
Delete navigation property policies for identity

### [Remove-MgIdentityContinuouAccessEvaluationPolicy](Remove-MgIdentityContinuouAccessEvaluationPolicy.md)
Delete navigation property continuousAccessEvaluationPolicy for identity

### [Remove-MgIdentityCustomAuthenticationExtension](Remove-MgIdentityCustomAuthenticationExtension.md)
Delete navigation property customAuthenticationExtensions for identity

### [Remove-MgIdentityProvider](Remove-MgIdentityProvider.md)
Delete navigation property identityProviders for identity

### [Remove-MgIdentityUserFlow](Remove-MgIdentityUserFlow.md)
Delete navigation property userFlows for identity

### [Remove-MgIdentityUserFlowAttribute](Remove-MgIdentityUserFlowAttribute.md)
Delete navigation property userFlowAttributes for identity

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
Delete navigation property results for informationProtection

### [Remove-MgOauth2PermissionGrant](Remove-MgOauth2PermissionGrant.md)
Delete an oAuth2PermissionGrant, representing a delegated permission grant.
When a delegated permission grant is deleted, the access it granted is revoked.
Existing access tokens will continue to be valid for their lifetime, but new access tokens will not be granted for the delegated permissions identified in the deleted **oAuth2PermissionGrant**.

### [Remove-MgPolicyAccessReviewPolicy](Remove-MgPolicyAccessReviewPolicy.md)
Delete navigation property accessReviewPolicy for policies

### [Remove-MgPolicyActivityBasedTimeoutPolicy](Remove-MgPolicyActivityBasedTimeoutPolicy.md)
Delete navigation property activityBasedTimeoutPolicies for policies

### [Remove-MgPolicyAdminConsentRequestPolicy](Remove-MgPolicyAdminConsentRequestPolicy.md)
Delete navigation property adminConsentRequestPolicy for policies

### [Remove-MgPolicyAppManagementPolicy](Remove-MgPolicyAppManagementPolicy.md)
Delete navigation property appManagementPolicies for policies

### [Remove-MgPolicyAuthenticationFlowPolicy](Remove-MgPolicyAuthenticationFlowPolicy.md)
Delete navigation property authenticationFlowsPolicy for policies

### [Remove-MgPolicyAuthenticationMethodPolicy](Remove-MgPolicyAuthenticationMethodPolicy.md)
Delete navigation property authenticationMethodsPolicy for policies

### [Remove-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Remove-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Delete navigation property authenticationMethodConfigurations for policies

### [Remove-MgPolicyAuthenticationStrengthPolicy](Remove-MgPolicyAuthenticationStrengthPolicy.md)
Delete navigation property authenticationStrengthPolicies for policies

### [Remove-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete navigation property combinationConfigurations for policies

### [Remove-MgPolicyAuthorizationPolicy](Remove-MgPolicyAuthorizationPolicy.md)
Delete navigation property authorizationPolicy for policies

### [Remove-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Remove-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Delete navigation property defaultUserRoleOverrides for policies

### [Remove-MgPolicyB2CAuthenticationMethodPolicy](Remove-MgPolicyB2CAuthenticationMethodPolicy.md)
Delete navigation property b2cAuthenticationMethodsPolicy for policies

### [Remove-MgPolicyClaimMappingPolicy](Remove-MgPolicyClaimMappingPolicy.md)
Delete navigation property claimsMappingPolicies for policies

### [Remove-MgPolicyCrossTenantAccessPolicy](Remove-MgPolicyCrossTenantAccessPolicy.md)
Delete navigation property crossTenantAccessPolicy for policies

### [Remove-MgPolicyCrossTenantAccessPolicyDefault](Remove-MgPolicyCrossTenantAccessPolicyDefault.md)
Delete navigation property default for policies

### [Remove-MgPolicyCrossTenantAccessPolicyPartner](Remove-MgPolicyCrossTenantAccessPolicyPartner.md)
Delete navigation property partners for policies

### [Remove-MgPolicyDefaultAppManagementPolicy](Remove-MgPolicyDefaultAppManagementPolicy.md)
Delete navigation property defaultAppManagementPolicy for policies

### [Remove-MgPolicyDirectoryRoleAccessReviewPolicy](Remove-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Delete navigation property directoryRoleAccessReviewPolicy for policies

### [Remove-MgPolicyExternalIdentityPolicy](Remove-MgPolicyExternalIdentityPolicy.md)
Delete navigation property externalIdentitiesPolicy for policies

### [Remove-MgPolicyFeatureRolloutPolicy](Remove-MgPolicyFeatureRolloutPolicy.md)
Delete navigation property featureRolloutPolicies for policies

### [Remove-MgPolicyFeatureRolloutPolicyApplyToByRef](Remove-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Delete ref of navigation property appliesTo for policies

### [Remove-MgPolicyHomeRealmDiscoveryPolicy](Remove-MgPolicyHomeRealmDiscoveryPolicy.md)
Delete navigation property homeRealmDiscoveryPolicies for policies

### [Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Delete navigation property identitySecurityDefaultsEnforcementPolicy for policies

### [Remove-MgPolicyMobileAppManagementPolicy](Remove-MgPolicyMobileAppManagementPolicy.md)
Delete navigation property mobileAppManagementPolicies for policies

### [Remove-MgPolicyMobileAppManagementPolicyIncludedGroupByRef](Remove-MgPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Delete ref of navigation property includedGroups for policies

### [Remove-MgPolicyMobileDeviceManagementPolicy](Remove-MgPolicyMobileDeviceManagementPolicy.md)
Delete navigation property mobileDeviceManagementPolicies for policies

### [Remove-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Remove-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Delete ref of navigation property includedGroups for policies

### [Remove-MgPolicyPermissionGrantPolicy](Remove-MgPolicyPermissionGrantPolicy.md)
Delete navigation property permissionGrantPolicies for policies

### [Remove-MgPolicyPermissionGrantPolicyExclude](Remove-MgPolicyPermissionGrantPolicyExclude.md)
Delete navigation property excludes for policies

### [Remove-MgPolicyPermissionGrantPolicyInclude](Remove-MgPolicyPermissionGrantPolicyInclude.md)
Delete navigation property includes for policies

### [Remove-MgPolicyRoleManagementPolicy](Remove-MgPolicyRoleManagementPolicy.md)
Delete navigation property roleManagementPolicies for policies

### [Remove-MgPolicyRoleManagementPolicyAssignment](Remove-MgPolicyRoleManagementPolicyAssignment.md)
Delete navigation property roleManagementPolicyAssignments for policies

### [Remove-MgPolicyRoleManagementPolicyEffectiveRule](Remove-MgPolicyRoleManagementPolicyEffectiveRule.md)
Delete navigation property effectiveRules for policies

### [Remove-MgPolicyRoleManagementPolicyRule](Remove-MgPolicyRoleManagementPolicyRule.md)
Delete navigation property rules for policies

### [Remove-MgPolicyServicePrincipalCreationPolicy](Remove-MgPolicyServicePrincipalCreationPolicy.md)
Delete navigation property servicePrincipalCreationPolicies for policies

### [Remove-MgPolicyServicePrincipalCreationPolicyExclude](Remove-MgPolicyServicePrincipalCreationPolicyExclude.md)
Delete navigation property excludes for policies

### [Remove-MgPolicyServicePrincipalCreationPolicyInclude](Remove-MgPolicyServicePrincipalCreationPolicyInclude.md)
Delete navigation property includes for policies

### [Remove-MgPolicyTokenIssuancePolicy](Remove-MgPolicyTokenIssuancePolicy.md)
Delete navigation property tokenIssuancePolicies for policies

### [Remove-MgPolicyTokenLifetimePolicy](Remove-MgPolicyTokenLifetimePolicy.md)
Delete navigation property tokenLifetimePolicies for policies

### [Remove-MgRiskDetection](Remove-MgRiskDetection.md)
Delete navigation property riskDetections for identityProtection

### [Remove-MgRiskyServicePrincipal](Remove-MgRiskyServicePrincipal.md)
Delete navigation property riskyServicePrincipals for identityProtection

### [Remove-MgRiskyServicePrincipalHistory](Remove-MgRiskyServicePrincipalHistory.md)
Delete navigation property history for identityProtection

### [Remove-MgRiskyUser](Remove-MgRiskyUser.md)
Delete navigation property riskyUsers for identityProtection

### [Remove-MgRiskyUserHistory](Remove-MgRiskyUserHistory.md)
Delete navigation property history for identityProtection

### [Remove-MgServicePrincipalRiskDetection](Remove-MgServicePrincipalRiskDetection.md)
Delete navigation property servicePrincipalRiskDetections for identityProtection

### [Remove-MgTrustFrameworkKeySet](Remove-MgTrustFrameworkKeySet.md)
Delete navigation property keySets for trustFramework

### [Remove-MgTrustFrameworkPolicy](Remove-MgTrustFrameworkPolicy.md)
Delete navigation property policies for trustFramework

### [Remove-MgUserAuthenticationEmailMethod](Remove-MgUserAuthenticationEmailMethod.md)
Delete navigation property emailMethods for users

### [Remove-MgUserAuthenticationFido2Method](Remove-MgUserAuthenticationFido2Method.md)
Delete navigation property fido2Methods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Delete navigation property microsoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
Delete navigation property device for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgUserAuthenticationOperation](Remove-MgUserAuthenticationOperation.md)
Delete navigation property operations for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Delete navigation property passwordlessMicrosoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Delete navigation property device for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Remove-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgUserAuthenticationPhoneMethod](Remove-MgUserAuthenticationPhoneMethod.md)
Delete navigation property phoneMethods for users

### [Remove-MgUserAuthenticationSoftwareOathMethod](Remove-MgUserAuthenticationSoftwareOathMethod.md)
Delete navigation property softwareOathMethods for users

### [Remove-MgUserAuthenticationTemporaryAccessPassMethod](Remove-MgUserAuthenticationTemporaryAccessPassMethod.md)
Delete navigation property temporaryAccessPassMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethod](Remove-MgUserAuthenticationWindowHelloForBusinessMethod.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Delete navigation property device for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Remove-MgUserInformationProtection](Remove-MgUserInformationProtection.md)
Delete navigation property informationProtection for users

### [Remove-MgUserInformationProtectionDataLossPreventionPolicy](Remove-MgUserInformationProtectionDataLossPreventionPolicy.md)
Delete navigation property dataLossPreventionPolicies for users

### [Remove-MgUserInformationProtectionPolicy](Remove-MgUserInformationProtectionPolicy.md)
Delete navigation property policy for users

### [Remove-MgUserInformationProtectionPolicyLabel](Remove-MgUserInformationProtectionPolicyLabel.md)
Delete navigation property labels for users

### [Remove-MgUserInformationProtectionSensitivityLabel](Remove-MgUserInformationProtectionSensitivityLabel.md)
Delete navigation property sensitivityLabels for users

### [Remove-MgUserInformationProtectionSensitivityLabelSublabel](Remove-MgUserInformationProtectionSensitivityLabelSublabel.md)
Delete navigation property sublabels for users

### [Remove-MgUserInformationProtectionSensitivityPolicySetting](Remove-MgUserInformationProtectionSensitivityPolicySetting.md)
Delete navigation property sensitivityPolicySettings for users

### [Remove-MgUserInformationProtectionThreatAssessmentRequest](Remove-MgUserInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for users

### [Remove-MgUserInformationProtectionThreatAssessmentRequestResult](Remove-MgUserInformationProtectionThreatAssessmentRequestResult.md)
Delete navigation property results for users

### [Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault](Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault.md)
Reset any changes made to the default configuration in a cross-tenant access policy back to the system default.

### [Set-MgIdentityB2CUserFlowLanguageDefaultPageContent](Set-MgIdentityB2CUserFlowLanguageDefaultPageContent.md)
Update media content for the navigation property defaultPages in identity

### [Set-MgIdentityB2CUserFlowLanguageOverridePageContent](Set-MgIdentityB2CUserFlowLanguageOverridePageContent.md)
Update media content for the navigation property overridesPages in identity

### [Set-MgIdentityB2CUserFlowUserAttributeAssignmentOrder](Set-MgIdentityB2CUserFlowUserAttributeAssignmentOrder.md)
Set the order of identityUserFlowAttributeAssignments being collected within a user flow.

### [Set-MgIdentityB2XUserFlowLanguageDefaultPageContent](Set-MgIdentityB2XUserFlowLanguageDefaultPageContent.md)
Update media content for the navigation property defaultPages in identity

### [Set-MgIdentityB2XUserFlowLanguageOverridePageContent](Set-MgIdentityB2XUserFlowLanguageOverridePageContent.md)
Update media content for the navigation property overridesPages in identity

### [Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder](Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Set the order of identityUserFlowAttributeAssignments being collected within a user flow.

### [Set-MgTrustFrameworkPolicyContent](Set-MgTrustFrameworkPolicyContent.md)
Update media content for the navigation property policies in trustFramework

### [Test-MgIdentityCustomAuthenticationExtensionAuthenticationConfiguration](Test-MgIdentityCustomAuthenticationExtensionAuthenticationConfiguration.md)
Invoke action validateAuthenticationConfiguration

### [Test-MgInformationProtectionDataLossPreventionPolicy](Test-MgInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgInformationProtectionPolicyLabelApplication](Test-MgInformationProtectionPolicyLabelApplication.md)
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

### [Test-MgInformationProtectionPolicyLabelClassificationResult](Test-MgInformationProtectionPolicyLabelClassificationResult.md)
Using classification results, compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide contentInfo, which includes existing content metadata key/value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following:

### [Test-MgInformationProtectionPolicyLabelRemoval](Test-MgInformationProtectionPolicyLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key/value pairs, the API returns an informationProtectionAction that contains some combination of one of more of the following:

### [Test-MgPolicyFeatureRolloutPolicyApplyToProperty](Test-MgPolicyFeatureRolloutPolicyApplyToProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Update-MgDataPolicyOperation](Update-MgDataPolicyOperation.md)
Update entity in dataPolicyOperations

### [Update-MgIdentityApiConnector](Update-MgIdentityApiConnector.md)
Update the navigation property apiConnectors in identity

### [Update-MgIdentityAuthenticationEventListener](Update-MgIdentityAuthenticationEventListener.md)
Update the navigation property authenticationEventListeners in identity

### [Update-MgIdentityB2CUserFlow](Update-MgIdentityB2CUserFlow.md)
Update the navigation property b2cUserFlows in identity

### [Update-MgIdentityB2CUserFlowLanguage](Update-MgIdentityB2CUserFlowLanguage.md)
Update the navigation property languages in identity

### [Update-MgIdentityB2CUserFlowLanguageDefaultPage](Update-MgIdentityB2CUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgIdentityB2CUserFlowLanguageOverridePage](Update-MgIdentityB2CUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgIdentityB2CUserFlowUserAttributeAssignment](Update-MgIdentityB2CUserFlowUserAttributeAssignment.md)
Update the navigation property userAttributeAssignments in identity

### [Update-MgIdentityB2XUserFlow](Update-MgIdentityB2XUserFlow.md)
Update the navigation property b2xUserFlows in identity

### [Update-MgIdentityB2XUserFlowLanguage](Update-MgIdentityB2XUserFlowLanguage.md)
Update the navigation property languages in identity

### [Update-MgIdentityB2XUserFlowLanguageDefaultPage](Update-MgIdentityB2XUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgIdentityB2XUserFlowLanguageOverridePage](Update-MgIdentityB2XUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgIdentityB2XUserFlowUserAttributeAssignment](Update-MgIdentityB2XUserFlowUserAttributeAssignment.md)
Update the navigation property userAttributeAssignments in identity

### [Update-MgIdentityConditionalAccessAuthenticationContextClassReference](Update-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Update the navigation property authenticationContextClassReferences in identity

### [Update-MgIdentityConditionalAccessAuthenticationStrength](Update-MgIdentityConditionalAccessAuthenticationStrength.md)
Update the navigation property authenticationStrengths in identity

### [Update-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Update-MgIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Update the navigation property authenticationMethodModes in identity

### [Update-MgIdentityConditionalAccessAuthenticationStrengthPolicy](Update-MgIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Update the navigation property policies in identity

### [Update-MgIdentityConditionalAccessAuthenticationStrengthPolicyAllowedCombination](Update-MgIdentityConditionalAccessAuthenticationStrengthPolicyAllowedCombination.md)
Update the allowedCombinations property of an authenticationStrengthPolicy object.
To update other properties of an authenticationStrengthPolicy object, use the Update authenticationStrengthPolicy method.

### [Update-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Update-MgIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the navigation property combinationConfigurations in identity

### [Update-MgIdentityConditionalAccessNamedLocation](Update-MgIdentityConditionalAccessNamedLocation.md)
Update the navigation property namedLocations in identity

### [Update-MgIdentityConditionalAccessPolicy](Update-MgIdentityConditionalAccessPolicy.md)
Update the navigation property policies in identity

### [Update-MgIdentityContinuouAccessEvaluationPolicy](Update-MgIdentityContinuouAccessEvaluationPolicy.md)
Update the properties of a continuousAccessEvaluationPolicy object.

### [Update-MgIdentityCustomAuthenticationExtension](Update-MgIdentityCustomAuthenticationExtension.md)
Update the navigation property customAuthenticationExtensions in identity

### [Update-MgIdentityProvider](Update-MgIdentityProvider.md)
Update the navigation property identityProviders in identity

### [Update-MgIdentityUserFlow](Update-MgIdentityUserFlow.md)
Update the navigation property userFlows in identity

### [Update-MgIdentityUserFlowAttribute](Update-MgIdentityUserFlowAttribute.md)
Update the navigation property userFlowAttributes in identity

### [Update-MgInformationProtection](Update-MgInformationProtection.md)
Update informationProtection

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
Update the navigation property results in informationProtection

### [Update-MgOauth2PermissionGrant](Update-MgOauth2PermissionGrant.md)
Update the properties of oAuth2PermissionGrant object, representing a delegated permission grant.
An **oAuth2PermissionGrant** can be updated to change which delegated permissions are granted, by adding or removing items from the list in **scopes**.

### [Update-MgPolicyAccessReviewPolicy](Update-MgPolicyAccessReviewPolicy.md)
Update the properties of an accessReviewPolicy object.

### [Update-MgPolicyActivityBasedTimeoutPolicy](Update-MgPolicyActivityBasedTimeoutPolicy.md)
Update the navigation property activityBasedTimeoutPolicies in policies

### [Update-MgPolicyAdminConsentRequestPolicy](Update-MgPolicyAdminConsentRequestPolicy.md)
Update the properties of an adminConsentRequestPolicy object.

### [Update-MgPolicyAppManagementPolicy](Update-MgPolicyAppManagementPolicy.md)
Update the navigation property appManagementPolicies in policies

### [Update-MgPolicyAuthenticationFlowPolicy](Update-MgPolicyAuthenticationFlowPolicy.md)
Update the Boolean **selfServiceSignUp** property of an authenticationFlowsPolicy object.
The properties **id**, **type**, and **description** cannot be modified.

### [Update-MgPolicyAuthenticationMethodPolicy](Update-MgPolicyAuthenticationMethodPolicy.md)
Update the properties of an authenticationMethodsPolicy object.

### [Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Update the navigation property authenticationMethodConfigurations in policies

### [Update-MgPolicyAuthenticationStrengthPolicy](Update-MgPolicyAuthenticationStrengthPolicy.md)
Update the navigation property authenticationStrengthPolicies in policies

### [Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination](Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination.md)
Update the allowedCombinations property of an authenticationStrengthPolicy object.
To update other properties of an authenticationStrengthPolicy object, use the Update authenticationStrengthPolicy method.

### [Update-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](Update-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the navigation property combinationConfigurations in policies

### [Update-MgPolicyAuthorizationPolicy](Update-MgPolicyAuthorizationPolicy.md)
Update the navigation property authorizationPolicy in policies

### [Update-MgPolicyAuthorizationPolicyDefaultUserRoleOverride](Update-MgPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Update the navigation property defaultUserRoleOverrides in policies

### [Update-MgPolicyB2CAuthenticationMethodPolicy](Update-MgPolicyB2CAuthenticationMethodPolicy.md)
Update the properties of a b2cAuthenticationMethodsPolicy object.

### [Update-MgPolicyClaimMappingPolicy](Update-MgPolicyClaimMappingPolicy.md)
Update the navigation property claimsMappingPolicies in policies

### [Update-MgPolicyCrossTenantAccessPolicy](Update-MgPolicyCrossTenantAccessPolicy.md)
Update the properties of a cross-tenant access policy.

### [Update-MgPolicyCrossTenantAccessPolicyDefault](Update-MgPolicyCrossTenantAccessPolicyDefault.md)
Update the default configuration of a cross-tenant access policy.

### [Update-MgPolicyCrossTenantAccessPolicyPartner](Update-MgPolicyCrossTenantAccessPolicyPartner.md)
Update the navigation property partners in policies

### [Update-MgPolicyDefaultAppManagementPolicy](Update-MgPolicyDefaultAppManagementPolicy.md)
Update the properties of a tenantAppManagementPolicy object.

### [Update-MgPolicyDirectoryRoleAccessReviewPolicy](Update-MgPolicyDirectoryRoleAccessReviewPolicy.md)
Update the navigation property directoryRoleAccessReviewPolicy in policies

### [Update-MgPolicyExternalIdentityPolicy](Update-MgPolicyExternalIdentityPolicy.md)
Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls.

### [Update-MgPolicyFeatureRolloutPolicy](Update-MgPolicyFeatureRolloutPolicy.md)
Update the navigation property featureRolloutPolicies in policies

### [Update-MgPolicyHomeRealmDiscoveryPolicy](Update-MgPolicyHomeRealmDiscoveryPolicy.md)
Update the navigation property homeRealmDiscoveryPolicies in policies

### [Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Update the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Update-MgPolicyMobileAppManagementPolicy](Update-MgPolicyMobileAppManagementPolicy.md)
Update the navigation property mobileAppManagementPolicies in policies

### [Update-MgPolicyMobileDeviceManagementPolicy](Update-MgPolicyMobileDeviceManagementPolicy.md)
Update the navigation property mobileDeviceManagementPolicies in policies

### [Update-MgPolicyPermissionGrantPolicy](Update-MgPolicyPermissionGrantPolicy.md)
Update the navigation property permissionGrantPolicies in policies

### [Update-MgPolicyPermissionGrantPolicyExclude](Update-MgPolicyPermissionGrantPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgPolicyPermissionGrantPolicyInclude](Update-MgPolicyPermissionGrantPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgPolicyRoleManagementPolicy](Update-MgPolicyRoleManagementPolicy.md)
Update the navigation property roleManagementPolicies in policies

### [Update-MgPolicyRoleManagementPolicyAssignment](Update-MgPolicyRoleManagementPolicyAssignment.md)
Update the navigation property roleManagementPolicyAssignments in policies

### [Update-MgPolicyRoleManagementPolicyEffectiveRule](Update-MgPolicyRoleManagementPolicyEffectiveRule.md)
Update the navigation property effectiveRules in policies

### [Update-MgPolicyRoleManagementPolicyRule](Update-MgPolicyRoleManagementPolicyRule.md)
Update the navigation property rules in policies

### [Update-MgPolicyServicePrincipalCreationPolicy](Update-MgPolicyServicePrincipalCreationPolicy.md)
Update the navigation property servicePrincipalCreationPolicies in policies

### [Update-MgPolicyServicePrincipalCreationPolicyExclude](Update-MgPolicyServicePrincipalCreationPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgPolicyServicePrincipalCreationPolicyInclude](Update-MgPolicyServicePrincipalCreationPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgPolicyTokenIssuancePolicy](Update-MgPolicyTokenIssuancePolicy.md)
Update the navigation property tokenIssuancePolicies in policies

### [Update-MgPolicyTokenLifetimePolicy](Update-MgPolicyTokenLifetimePolicy.md)
Update the navigation property tokenLifetimePolicies in policies

### [Update-MgRiskDetection](Update-MgRiskDetection.md)
Update the navigation property riskDetections in identityProtection

### [Update-MgRiskyServicePrincipal](Update-MgRiskyServicePrincipal.md)
Update the navigation property riskyServicePrincipals in identityProtection

### [Update-MgRiskyServicePrincipalHistory](Update-MgRiskyServicePrincipalHistory.md)
Update the navigation property history in identityProtection

### [Update-MgRiskyUser](Update-MgRiskyUser.md)
Update the navigation property riskyUsers in identityProtection

### [Update-MgRiskyUserHistory](Update-MgRiskyUserHistory.md)
Update the navigation property history in identityProtection

### [Update-MgServicePrincipalRiskDetection](Update-MgServicePrincipalRiskDetection.md)
Update the navigation property servicePrincipalRiskDetections in identityProtection

### [Update-MgTrustFramework](Update-MgTrustFramework.md)
Update trustFramework

### [Update-MgTrustFrameworkKeySet](Update-MgTrustFrameworkKeySet.md)
Update the navigation property keySets in trustFramework

### [Update-MgTrustFrameworkPolicy](Update-MgTrustFrameworkPolicy.md)
Update the navigation property policies in trustFramework

### [Update-MgUserAuthenticationEmailMethod](Update-MgUserAuthenticationEmailMethod.md)
Update the navigation property emailMethods in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
Update the navigation property device in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgUserAuthenticationOperation](Update-MgUserAuthenticationOperation.md)
Update the navigation property operations in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Update the navigation property device in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights](Update-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgUserAuthenticationPhoneMethod](Update-MgUserAuthenticationPhoneMethod.md)
Update the navigation property phoneMethods in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Update the navigation property device in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand](Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension](Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights](Update-MgUserAuthenticationWindowHelloForBusinessMethodDeviceUsageRights.md)
Update the navigation property usageRights in users

### [Update-MgUserInformationProtection](Update-MgUserInformationProtection.md)
Update the navigation property informationProtection in users

### [Update-MgUserInformationProtectionDataLossPreventionPolicy](Update-MgUserInformationProtectionDataLossPreventionPolicy.md)
Update the navigation property dataLossPreventionPolicies in users

### [Update-MgUserInformationProtectionPolicy](Update-MgUserInformationProtectionPolicy.md)
Update the navigation property policy in users

### [Update-MgUserInformationProtectionPolicyLabel](Update-MgUserInformationProtectionPolicyLabel.md)
Update the navigation property labels in users

### [Update-MgUserInformationProtectionSensitivityLabel](Update-MgUserInformationProtectionSensitivityLabel.md)
Update the navigation property sensitivityLabels in users

### [Update-MgUserInformationProtectionSensitivityLabelSublabel](Update-MgUserInformationProtectionSensitivityLabelSublabel.md)
Update the navigation property sublabels in users

### [Update-MgUserInformationProtectionSensitivityPolicySetting](Update-MgUserInformationProtectionSensitivityPolicySetting.md)
Update the navigation property sensitivityPolicySettings in users

### [Update-MgUserInformationProtectionThreatAssessmentRequest](Update-MgUserInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in users

### [Update-MgUserInformationProtectionThreatAssessmentRequestResult](Update-MgUserInformationProtectionThreatAssessmentRequestResult.md)
Update the navigation property results in users

