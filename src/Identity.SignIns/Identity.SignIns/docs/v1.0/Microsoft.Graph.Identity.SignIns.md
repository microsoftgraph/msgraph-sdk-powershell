---
Module Name: Microsoft.Graph.Identity.SignIns
Module Guid: d7cae808-f975-49fa-a433-3aabe8b9a652
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.SignIns Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.SignIns Cmdlets
### [Confirm-MgRiskyServicePrincipalCompromised](Confirm-MgRiskyServicePrincipalCompromised.md)
Invoke action confirmCompromised

### [Confirm-MgRiskyUserCompromised](Confirm-MgRiskyUserCompromised.md)
Invoke action confirmCompromised

### [Get-MgDataPolicyOperation](Get-MgDataPolicyOperation.md)
Retrieve the properties of a **dataPolicyOperation** object.

### [Get-MgIdentityApiConnector](Get-MgIdentityApiConnector.md)
Represents entry point for API connectors.

### [Get-MgIdentityB2XUserFlow](Get-MgIdentityB2XUserFlow.md)
Represents entry point for B2X/self-service sign-up identity userflows.

### [Get-MgIdentityB2XUserFlowIdentityProvider](Get-MgIdentityB2XUserFlowIdentityProvider.md)
The identity providers included in the user flow.

### [Get-MgIdentityB2XUserFlowIdentityProviderByRef](Get-MgIdentityB2XUserFlowIdentityProviderByRef.md)
Get ref of userFlowIdentityProviders from identity

### [Get-MgIdentityB2XUserFlowLanguage](Get-MgIdentityB2XUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is enabled by default in self-service sign-up user flow.
You cannot create custom languages in self-service sign-up user flows.

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

### [Get-MgIdentityConditionalAccessNamedLocation](Get-MgIdentityConditionalAccessNamedLocation.md)
Read-only.
Nullable.
Returns a collection of the specified named locations.

### [Get-MgIdentityConditionalAccessPolicy](Get-MgIdentityConditionalAccessPolicy.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access (CA) policies.

### [Get-MgIdentityConditionalAccessTemplate](Get-MgIdentityConditionalAccessTemplate.md)
Read-only.
Nullable.
Returns a collection of the specified Conditional Access templates.

### [Get-MgIdentityProvider](Get-MgIdentityProvider.md)
Get identityProviders from identity

### [Get-MgIdentityUserFlowAttribute](Get-MgIdentityUserFlowAttribute.md)
Represents entry point for identity userflow attributes.

### [Get-MgInformationProtection](Get-MgInformationProtection.md)
Get informationProtection

### [Get-MgInformationProtectionBitlocker](Get-MgInformationProtectionBitlocker.md)
Get bitlocker from informationProtection

### [Get-MgInformationProtectionBitlockerRecoveryKey](Get-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Get-MgInformationProtectionThreatAssessmentRequest](Get-MgInformationProtectionThreatAssessmentRequest.md)
Get threatAssessmentRequests from informationProtection

### [Get-MgInformationProtectionThreatAssessmentRequestResult](Get-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Get-MgInvitationInvitedUserMailboxSetting](Get-MgInvitationInvitedUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgOauth2PermissionGrant](Get-MgOauth2PermissionGrant.md)
Retrieve the properties of a single delegated permission grant represented by an oAuth2PermissionGrant object.
An **oAuth2PermissionGrant** represents delegated permissions which have been granted for a client application to access an API on behalf of a signed-in user.

### [Get-MgOauth2PermissionGrantDelta](Get-MgOauth2PermissionGrantDelta.md)
Invoke function delta

### [Get-MgOrganizationCertificateBasedAuthConfiguration](Get-MgOrganizationCertificateBasedAuthConfiguration.md)
Navigation property to manage certificate-based authentication configuration.
Only a single instance of certificateBasedAuthConfiguration can be created in the collection.

### [Get-MgPolicyActivityBasedTimeoutPolicy](Get-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Get-MgPolicyAdminConsentRequestPolicy](Get-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Get-MgPolicyAppManagementPolicy](Get-MgPolicyAppManagementPolicy.md)
The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.

### [Get-MgPolicyAppManagementPolicyApplyTo](Get-MgPolicyAppManagementPolicyApplyTo.md)
Collection of applications and service principals to which the policy is applied.

### [Get-MgPolicyAuthenticationFlowPolicy](Get-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Get-MgPolicyAuthenticationMethodPolicy](Get-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multifactor authentication (MFA) in Azure Active Directory (Azure AD).

### [Get-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Get-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Represents the settings for each authentication method.
Automatically expanded on GET /policies/authenticationMethodsPolicy.

### [Get-MgPolicyAuthenticationStrengthPolicy](Get-MgPolicyAuthenticationStrengthPolicy.md)
The authentication method combinations that are to be used in scenarios defined by Azure AD Conditional Access.

### [Get-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](Get-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.

### [Get-MgPolicyAuthorizationPolicy](Get-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

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

### [Get-MgPolicyFeatureRolloutPolicy](Get-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Get-MgPolicyFeatureRolloutPolicyApplyTo](Get-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyFeatureRolloutPolicyApplyToAvailableExtensionProperty](Get-MgPolicyFeatureRolloutPolicyApplyToAvailableExtensionProperty.md)
Invoke action getAvailableExtensionProperties

### [Get-MgPolicyFeatureRolloutPolicyApplyToById](Get-MgPolicyFeatureRolloutPolicyApplyToById.md)
Invoke action getByIds

### [Get-MgPolicyFeatureRolloutPolicyApplyToByRef](Get-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgPolicyFeatureRolloutPolicyApplyToDelta](Get-MgPolicyFeatureRolloutPolicyApplyToDelta.md)
Invoke function delta

### [Get-MgPolicyHomeRealmDiscoveryPolicy](Get-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Get-MgPolicyPermissionGrantPolicy](Get-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Get-MgPolicyPermissionGrantPolicyExclude](Get-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyPermissionGrantPolicyInclude](Get-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Get-MgPolicyRoleManagementPolicy](Get-MgPolicyRoleManagementPolicy.md)
Specifies the various policies associated with scopes and roles.

### [Get-MgPolicyRoleManagementPolicyAssignment](Get-MgPolicyRoleManagementPolicyAssignment.md)
The assignment of a role management policy to a role definition object.

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
The activity related to user risk level change

### [Get-MgServicePrincipalRiskDetection](Get-MgServicePrincipalRiskDetection.md)
Represents information about detected at-risk service principals in an Azure AD tenant.

### [Get-MgUserAuthenticationEmailMethod](Get-MgUserAuthenticationEmailMethod.md)
The email address registered to a user for authentication.

### [Get-MgUserAuthenticationFido2Method](Get-MgUserAuthenticationFido2Method.md)
Represents the FIDO2 security keys registered to a user for authentication.

### [Get-MgUserAuthenticationMethod](Get-MgUserAuthenticationMethod.md)
Represents all authentication methods registered to a user.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
The details of the Microsoft Authenticator app registered to a user for authentication.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgUserAuthenticationOperation](Get-MgUserAuthenticationOperation.md)
Represents the status of a long-running operation.

### [Get-MgUserAuthenticationPasswordMethod](Get-MgUserAuthenticationPasswordMethod.md)
Represents the password that's registered to a user for authentication.
For security, the password itself will never be returned in the object, but action can be taken to reset a password.

### [Get-MgUserAuthenticationPhoneMethod](Get-MgUserAuthenticationPhoneMethod.md)
The phone numbers registered to a user for authentication.

### [Get-MgUserAuthenticationSoftwareOathMethod](Get-MgUserAuthenticationSoftwareOathMethod.md)
The software OATH TOTP applications registered to a user for authentication.

### [Get-MgUserAuthenticationTemporaryAccessPassMethod](Get-MgUserAuthenticationTemporaryAccessPassMethod.md)
Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethod](Get-MgUserAuthenticationWindowHelloForBusinessMethod.md)
Represents the Windows Hello for Business authentication method registered to a user for authentication.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Invoke-MgAvailableIdentityProviderType](Invoke-MgAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgDismissRiskyServicePrincipal](Invoke-MgDismissRiskyServicePrincipal.md)
Invoke action dismiss

### [Invoke-MgDismissRiskyUser](Invoke-MgDismissRiskyUser.md)
Invoke action dismiss

### [Invoke-MgUploadIdentityApiConnectorClientCertificate](Invoke-MgUploadIdentityApiConnectorClientCertificate.md)
Invoke action uploadClientCertificate

### [Invoke-MgUsagePolicyAuthenticationStrengthPolicy](Invoke-MgUsagePolicyAuthenticationStrengthPolicy.md)
Invoke function usage

### [New-MgDataPolicyOperation](New-MgDataPolicyOperation.md)
Add new entity to dataPolicyOperations

### [New-MgIdentityApiConnector](New-MgIdentityApiConnector.md)
Create new navigation property to apiConnectors for identity

### [New-MgIdentityB2XUserFlow](New-MgIdentityB2XUserFlow.md)
Create new navigation property to b2xUserFlows for identity

### [New-MgIdentityB2XUserFlowIdentityProviderByRef](New-MgIdentityB2XUserFlowIdentityProviderByRef.md)
Create new navigation property ref to userFlowIdentityProviders for identity

### [New-MgIdentityB2XUserFlowLanguage](New-MgIdentityB2XUserFlowLanguage.md)
Create new navigation property to languages for identity

### [New-MgIdentityB2XUserFlowLanguageDefaultPage](New-MgIdentityB2XUserFlowLanguageDefaultPage.md)
Create new navigation property to defaultPages for identity

### [New-MgIdentityB2XUserFlowLanguageOverridePage](New-MgIdentityB2XUserFlowLanguageOverridePage.md)
Create new navigation property to overridesPages for identity

### [New-MgIdentityB2XUserFlowUserAttributeAssignment](New-MgIdentityB2XUserFlowUserAttributeAssignment.md)
Create new navigation property to userAttributeAssignments for identity

### [New-MgIdentityConditionalAccessAuthenticationContextClassReference](New-MgIdentityConditionalAccessAuthenticationContextClassReference.md)
Create new navigation property to authenticationContextClassReferences for identity

### [New-MgIdentityConditionalAccessNamedLocation](New-MgIdentityConditionalAccessNamedLocation.md)
Create new navigation property to namedLocations for identity

### [New-MgIdentityConditionalAccessPolicy](New-MgIdentityConditionalAccessPolicy.md)
Create new navigation property to policies for identity

### [New-MgIdentityProvider](New-MgIdentityProvider.md)
Create new navigation property to identityProviders for identity

### [New-MgIdentityUserFlowAttribute](New-MgIdentityUserFlowAttribute.md)
Create new navigation property to userFlowAttributes for identity

### [New-MgInformationProtectionThreatAssessmentRequest](New-MgInformationProtectionThreatAssessmentRequest.md)
Create new navigation property to threatAssessmentRequests for informationProtection

### [New-MgInformationProtectionThreatAssessmentRequestResult](New-MgInformationProtectionThreatAssessmentRequestResult.md)
Create new navigation property to results for informationProtection

### [New-MgInvitation](New-MgInvitation.md)
Use this API to create a new invitation.
Invitation adds an external user to the organization.
When creating a new invitation you have several options available:

### [New-MgOauth2PermissionGrant](New-MgOauth2PermissionGrant.md)
Create a delegated permission grant represented by an oAuth2PermissionGrant object.
A delegated permission grant authorizes a client service principal (representing a client application) to access a resource service principal (representing an API), on behalf of a signed-in user, for the level of access limited by the delegated permissions which were granted.

### [New-MgPolicyActivityBasedTimeoutPolicy](New-MgPolicyActivityBasedTimeoutPolicy.md)
Create new navigation property to activityBasedTimeoutPolicies for policies

### [New-MgPolicyAppManagementPolicy](New-MgPolicyAppManagementPolicy.md)
Create new navigation property to appManagementPolicies for policies

### [New-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](New-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Create new navigation property to authenticationMethodConfigurations for policies

### [New-MgPolicyAuthenticationStrengthPolicy](New-MgPolicyAuthenticationStrengthPolicy.md)
Create new navigation property to authenticationStrengthPolicies for policies

### [New-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](New-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Create new navigation property to combinationConfigurations for policies

### [New-MgPolicyClaimMappingPolicy](New-MgPolicyClaimMappingPolicy.md)
Create new navigation property to claimsMappingPolicies for policies

### [New-MgPolicyCrossTenantAccessPolicyPartner](New-MgPolicyCrossTenantAccessPolicyPartner.md)
Create new navigation property to partners for policies

### [New-MgPolicyFeatureRolloutPolicy](New-MgPolicyFeatureRolloutPolicy.md)
Create new navigation property to featureRolloutPolicies for policies

### [New-MgPolicyFeatureRolloutPolicyApplyTo](New-MgPolicyFeatureRolloutPolicyApplyTo.md)
Create new navigation property to appliesTo for policies

### [New-MgPolicyFeatureRolloutPolicyApplyToByRef](New-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Create new navigation property ref to appliesTo for policies

### [New-MgPolicyHomeRealmDiscoveryPolicy](New-MgPolicyHomeRealmDiscoveryPolicy.md)
Create new navigation property to homeRealmDiscoveryPolicies for policies

### [New-MgPolicyPermissionGrantPolicy](New-MgPolicyPermissionGrantPolicy.md)
Create new navigation property to permissionGrantPolicies for policies

### [New-MgPolicyPermissionGrantPolicyExclude](New-MgPolicyPermissionGrantPolicyExclude.md)
Create new navigation property to excludes for policies

### [New-MgPolicyPermissionGrantPolicyInclude](New-MgPolicyPermissionGrantPolicyInclude.md)
Create new navigation property to includes for policies

### [New-MgPolicyRoleManagementPolicy](New-MgPolicyRoleManagementPolicy.md)
Create new navigation property to roleManagementPolicies for policies

### [New-MgPolicyRoleManagementPolicyAssignment](New-MgPolicyRoleManagementPolicyAssignment.md)
Create new navigation property to roleManagementPolicyAssignments for policies

### [New-MgPolicyRoleManagementPolicyEffectiveRule](New-MgPolicyRoleManagementPolicyEffectiveRule.md)
Create new navigation property to effectiveRules for policies

### [New-MgPolicyRoleManagementPolicyRule](New-MgPolicyRoleManagementPolicyRule.md)
Create new navigation property to rules for policies

### [New-MgPolicyTokenIssuancePolicy](New-MgPolicyTokenIssuancePolicy.md)
Create new navigation property to tokenIssuancePolicies for policies

### [New-MgPolicyTokenLifetimePolicy](New-MgPolicyTokenLifetimePolicy.md)
Create new navigation property to tokenLifetimePolicies for policies

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

### [New-MgUserAuthenticationEmailMethod](New-MgUserAuthenticationEmailMethod.md)
Create new navigation property to emailMethods for users

### [New-MgUserAuthenticationOperation](New-MgUserAuthenticationOperation.md)
Create new navigation property to operations for users

### [New-MgUserAuthenticationPhoneMethod](New-MgUserAuthenticationPhoneMethod.md)
Create new navigation property to phoneMethods for users

### [New-MgUserAuthenticationTemporaryAccessPassMethod](New-MgUserAuthenticationTemporaryAccessPassMethod.md)
Create new navigation property to temporaryAccessPassMethods for users

### [Remove-MgDataPolicyOperation](Remove-MgDataPolicyOperation.md)
Delete entity from dataPolicyOperations

### [Remove-MgIdentityApiConnector](Remove-MgIdentityApiConnector.md)
Delete navigation property apiConnectors for identity

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

### [Remove-MgIdentityConditionalAccessNamedLocation](Remove-MgIdentityConditionalAccessNamedLocation.md)
Delete navigation property namedLocations for identity

### [Remove-MgIdentityConditionalAccessPolicy](Remove-MgIdentityConditionalAccessPolicy.md)
Delete navigation property policies for identity

### [Remove-MgIdentityProvider](Remove-MgIdentityProvider.md)
Delete navigation property identityProviders for identity

### [Remove-MgIdentityUserFlowAttribute](Remove-MgIdentityUserFlowAttribute.md)
Delete navigation property userFlowAttributes for identity

### [Remove-MgInformationProtectionThreatAssessmentRequest](Remove-MgInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for informationProtection

### [Remove-MgInformationProtectionThreatAssessmentRequestResult](Remove-MgInformationProtectionThreatAssessmentRequestResult.md)
Delete navigation property results for informationProtection

### [Remove-MgOauth2PermissionGrant](Remove-MgOauth2PermissionGrant.md)
Delete a delegated permission grant, represented by an oAuth2PermissionGrant object.
When a delegated permission grant is deleted, the access it granted is revoked.
Existing access tokens will continue to be valid for their lifetime, but new access tokens will not be granted for the delegated permissions identified in the deleted **oAuth2PermissionGrant**.

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

### [Remove-MgPolicyFeatureRolloutPolicy](Remove-MgPolicyFeatureRolloutPolicy.md)
Delete navigation property featureRolloutPolicies for policies

### [Remove-MgPolicyFeatureRolloutPolicyApplyToByRef](Remove-MgPolicyFeatureRolloutPolicyApplyToByRef.md)
Delete ref of navigation property appliesTo for policies

### [Remove-MgPolicyHomeRealmDiscoveryPolicy](Remove-MgPolicyHomeRealmDiscoveryPolicy.md)
Delete navigation property homeRealmDiscoveryPolicies for policies

### [Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Delete navigation property identitySecurityDefaultsEnforcementPolicy for policies

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

### [Remove-MgUserAuthenticationEmailMethod](Remove-MgUserAuthenticationEmailMethod.md)
Delete navigation property emailMethods for users

### [Remove-MgUserAuthenticationFido2Method](Remove-MgUserAuthenticationFido2Method.md)
Delete navigation property fido2Methods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Delete navigation property microsoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationOperation](Remove-MgUserAuthenticationOperation.md)
Delete navigation property operations for users

### [Remove-MgUserAuthenticationPhoneMethod](Remove-MgUserAuthenticationPhoneMethod.md)
Delete navigation property phoneMethods for users

### [Remove-MgUserAuthenticationSoftwareOathMethod](Remove-MgUserAuthenticationSoftwareOathMethod.md)
Delete navigation property softwareOathMethods for users

### [Remove-MgUserAuthenticationTemporaryAccessPassMethod](Remove-MgUserAuthenticationTemporaryAccessPassMethod.md)
Delete navigation property temporaryAccessPassMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethod](Remove-MgUserAuthenticationWindowHelloForBusinessMethod.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault](Reset-MgPolicyCrossTenantAccessPolicyDefaultToSystemDefault.md)
Invoke action resetToSystemDefault

### [Set-MgIdentityB2XUserFlowLanguageDefaultPageContent](Set-MgIdentityB2XUserFlowLanguageDefaultPageContent.md)
Update media content for the navigation property defaultPages in identity

### [Set-MgIdentityB2XUserFlowLanguageOverridePageContent](Set-MgIdentityB2XUserFlowLanguageOverridePageContent.md)
Update media content for the navigation property overridesPages in identity

### [Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder](Set-MgIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Invoke action setOrder

### [Test-MgPolicyFeatureRolloutPolicyApplyToProperty](Test-MgPolicyFeatureRolloutPolicyApplyToProperty.md)
Invoke action validateProperties

### [Update-MgDataPolicyOperation](Update-MgDataPolicyOperation.md)
Update entity in dataPolicyOperations

### [Update-MgIdentityApiConnector](Update-MgIdentityApiConnector.md)
Update the navigation property apiConnectors in identity

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

### [Update-MgIdentityConditionalAccessNamedLocation](Update-MgIdentityConditionalAccessNamedLocation.md)
Update the navigation property namedLocations in identity

### [Update-MgIdentityConditionalAccessPolicy](Update-MgIdentityConditionalAccessPolicy.md)
Update the navigation property policies in identity

### [Update-MgIdentityProvider](Update-MgIdentityProvider.md)
Update the navigation property identityProviders in identity

### [Update-MgIdentityUserFlowAttribute](Update-MgIdentityUserFlowAttribute.md)
Update the navigation property userFlowAttributes in identity

### [Update-MgInformationProtection](Update-MgInformationProtection.md)
Update informationProtection

### [Update-MgInformationProtectionThreatAssessmentRequest](Update-MgInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in informationProtection

### [Update-MgInformationProtectionThreatAssessmentRequestResult](Update-MgInformationProtectionThreatAssessmentRequestResult.md)
Update the navigation property results in informationProtection

### [Update-MgInvitationInvitedUserMailboxSetting](Update-MgInvitationInvitedUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgOauth2PermissionGrant](Update-MgOauth2PermissionGrant.md)
Update the properties of oAuth2PermissionGrant object, representing a delegated permission grant.
An **oAuth2PermissionGrant** can be updated to change which delegated permissions are granted, by adding or removing items from the list in **scopes**.

### [Update-MgPolicyActivityBasedTimeoutPolicy](Update-MgPolicyActivityBasedTimeoutPolicy.md)
Update the navigation property activityBasedTimeoutPolicies in policies

### [Update-MgPolicyAdminConsentRequestPolicy](Update-MgPolicyAdminConsentRequestPolicy.md)
Update the navigation property adminConsentRequestPolicy in policies

### [Update-MgPolicyAppManagementPolicy](Update-MgPolicyAppManagementPolicy.md)
Update the navigation property appManagementPolicies in policies

### [Update-MgPolicyAuthenticationFlowPolicy](Update-MgPolicyAuthenticationFlowPolicy.md)
Update the navigation property authenticationFlowsPolicy in policies

### [Update-MgPolicyAuthenticationMethodPolicy](Update-MgPolicyAuthenticationMethodPolicy.md)
Update the navigation property authenticationMethodsPolicy in policies

### [Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Update-MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Update the navigation property authenticationMethodConfigurations in policies

### [Update-MgPolicyAuthenticationStrengthPolicy](Update-MgPolicyAuthenticationStrengthPolicy.md)
Update the navigation property authenticationStrengthPolicies in policies

### [Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination](Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination.md)
Invoke action updateAllowedCombinations

### [Update-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration](Update-MgPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the navigation property combinationConfigurations in policies

### [Update-MgPolicyAuthorizationPolicy](Update-MgPolicyAuthorizationPolicy.md)
Update the navigation property authorizationPolicy in policies

### [Update-MgPolicyClaimMappingPolicy](Update-MgPolicyClaimMappingPolicy.md)
Update the navigation property claimsMappingPolicies in policies

### [Update-MgPolicyCrossTenantAccessPolicy](Update-MgPolicyCrossTenantAccessPolicy.md)
Update the navigation property crossTenantAccessPolicy in policies

### [Update-MgPolicyCrossTenantAccessPolicyDefault](Update-MgPolicyCrossTenantAccessPolicyDefault.md)
Update the navigation property default in policies

### [Update-MgPolicyCrossTenantAccessPolicyPartner](Update-MgPolicyCrossTenantAccessPolicyPartner.md)
Update the navigation property partners in policies

### [Update-MgPolicyDefaultAppManagementPolicy](Update-MgPolicyDefaultAppManagementPolicy.md)
Update the navigation property defaultAppManagementPolicy in policies

### [Update-MgPolicyFeatureRolloutPolicy](Update-MgPolicyFeatureRolloutPolicy.md)
Update the navigation property featureRolloutPolicies in policies

### [Update-MgPolicyHomeRealmDiscoveryPolicy](Update-MgPolicyHomeRealmDiscoveryPolicy.md)
Update the navigation property homeRealmDiscoveryPolicies in policies

### [Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Update the navigation property identitySecurityDefaultsEnforcementPolicy in policies

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

### [Update-MgUserAuthenticationEmailMethod](Update-MgUserAuthenticationEmailMethod.md)
Update the navigation property emailMethods in users

### [Update-MgUserAuthenticationOperation](Update-MgUserAuthenticationOperation.md)
Update the navigation property operations in users

### [Update-MgUserAuthenticationPhoneMethod](Update-MgUserAuthenticationPhoneMethod.md)
Update the navigation property phoneMethods in users

