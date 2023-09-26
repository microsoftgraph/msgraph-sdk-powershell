---
Module Name: Microsoft.Graph.Beta.Identity.SignIns
Module Guid: 0f8e78c3-39a2-46d6-ab9d-3493a6c186ab
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Identity.SignIns Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Identity.SignIns Cmdlets
### [Confirm-MgBetaInformationProtectionSignature](Confirm-MgBetaInformationProtectionSignature.md)
Invoke action verifySignature

### [Confirm-MgBetaRiskyServicePrincipalCompromised](Confirm-MgBetaRiskyServicePrincipalCompromised.md)
Confirm one or more riskyServicePrincipal objects as compromised.
This action sets the targeted service principal account's risk level to high.

### [Confirm-MgBetaRiskyUserCompromised](Confirm-MgBetaRiskyUserCompromised.md)
Confirm one or more riskyUser objects as compromised.
This action sets the targeted user's risk level to high.

### [Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode](Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Find-MgBetaPolicyAuthenticationStrengthPolicyByMethodMode](Find-MgBetaPolicyAuthenticationStrengthPolicyByMethodMode.md)
Invoke function findByMethodMode

### [Get-MgBetaDataPolicyOperation](Get-MgBetaDataPolicyOperation.md)
Retrieve the properties of the dataPolicyOperation object.

### [Get-MgBetaDataPolicyOperationCount](Get-MgBetaDataPolicyOperationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityApiConnector](Get-MgBetaIdentityApiConnector.md)
Read the properties of an identityApiConnector object.

### [Get-MgBetaIdentityApiConnectorCount](Get-MgBetaIdentityApiConnectorCount.md)
Get the number of the resource

### [Get-MgBetaIdentityAuthenticationEventFlow](Get-MgBetaIdentityAuthenticationEventFlow.md)
Retrieve the properties and relationships of a specific authenticationEventsFlow object by ID.
Only externalUsersSelfServiceSignupEventsFlow object types are available.

### [Get-MgBetaIdentityAuthenticationEventFlowCount](Get-MgBetaIdentityAuthenticationEventFlowCount.md)
Get the number of the resource

### [Get-MgBetaIdentityAuthenticationEventListener](Get-MgBetaIdentityAuthenticationEventListener.md)
Get authenticationEventListeners from identity

### [Get-MgBetaIdentityAuthenticationEventListenerCount](Get-MgBetaIdentityAuthenticationEventListenerCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlow](Get-MgBetaIdentityB2CUserFlow.md)
Retrieve the properties and relationships of a b2cUserFlow object.

### [Get-MgBetaIdentityB2CUserFlowCount](Get-MgBetaIdentityB2CUserFlowCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowIdentityProvider](Get-MgBetaIdentityB2CUserFlowIdentityProvider.md)
Get userFlowIdentityProviders from identity

### [Get-MgBetaIdentityB2CUserFlowIdentityProviderByRef](Get-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Get the identity providers in a b2cIdentityUserFlow object.

### [Get-MgBetaIdentityB2CUserFlowIdentityProviderCount](Get-MgBetaIdentityB2CUserFlowIdentityProviderCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowLanguage](Get-MgBetaIdentityB2CUserFlowLanguage.md)
Read the properties and relationships of a userFlowLanguageConfiguration object.
These objects represent a language available in a user flow.
Note: To retrieve a language supported for customization, you must first enable language customization on your Azure AD B2C user flow.
For more information, see Update b2cIdentityUserFlow.
Language customization is enabled by default in Azure Active Directory user flows.

### [Get-MgBetaIdentityB2CUserFlowLanguageCount](Get-MgBetaIdentityB2CUserFlowLanguageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Get-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent](Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageCount](Get-MgBetaIdentityB2CUserFlowLanguageDefaultPageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowLanguageOverridePage](Get-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgBetaIdentityB2CUserFlowLanguageOverridePageContent](Get-MgBetaIdentityB2CUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgBetaIdentityB2CUserFlowLanguageOverridePageCount](Get-MgBetaIdentityB2CUserFlowLanguageOverridePageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Read the properties and relationships of an identityUserFlowAttributeAssignment object.

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentCount](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentUserAttribute](Get-MgBetaIdentityB2CUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgBetaIdentityB2XUserFlow](Get-MgBetaIdentityB2XUserFlow.md)
Retrieve the properties and relationships of a b2xIdentityUserFlow object.

### [Get-MgBetaIdentityB2XUserFlowApiConnectorConfiguration](Get-MgBetaIdentityB2XUserFlowApiConnectorConfiguration.md)
Configuration for enabling an API connector for use as part of the self-service sign up user flow.
You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.

### [Get-MgBetaIdentityB2XUserFlowCount](Get-MgBetaIdentityB2XUserFlowCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowIdentityProvider](Get-MgBetaIdentityB2XUserFlowIdentityProvider.md)
Get identityProviders from identity

### [Get-MgBetaIdentityB2XUserFlowIdentityProviderByRef](Get-MgBetaIdentityB2XUserFlowIdentityProviderByRef.md)
Get ref of userFlowIdentityProviders from identity

### [Get-MgBetaIdentityB2XUserFlowIdentityProviderCount](Get-MgBetaIdentityB2XUserFlowIdentityProviderCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowLanguage](Get-MgBetaIdentityB2XUserFlowLanguage.md)
The languages supported for customization within the user flow.
Language customization is enabled by default in self-service sign up user flow.
You cannot create custom languages in self-service sign up user flows.

### [Get-MgBetaIdentityB2XUserFlowLanguageCount](Get-MgBetaIdentityB2XUserFlowLanguageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Get-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Collection of pages with the default content to display in a user flow for a specified language.
This collection does not allow any kind of modification.

### [Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent](Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageContent.md)
Get media content for the navigation property defaultPages from identity

### [Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageCount](Get-MgBetaIdentityB2XUserFlowLanguageDefaultPageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowLanguageOverridePage](Get-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Collection of pages with the overrides messages to display in a user flow for a specified language.
This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

### [Get-MgBetaIdentityB2XUserFlowLanguageOverridePageContent](Get-MgBetaIdentityB2XUserFlowLanguageOverridePageContent.md)
Get media content for the navigation property overridesPages from identity

### [Get-MgBetaIdentityB2XUserFlowLanguageOverridePageCount](Get-MgBetaIdentityB2XUserFlowLanguageOverridePageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowPostAttributeCollection](Get-MgBetaIdentityB2XUserFlowPostAttributeCollection.md)
Get postAttributeCollection from identity

### [Get-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef](Get-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef.md)
Get ref of postAttributeCollection from identity

### [Get-MgBetaIdentityB2XUserFlowPostFederationSignup](Get-MgBetaIdentityB2XUserFlowPostFederationSignup.md)
Get postFederationSignup from identity

### [Get-MgBetaIdentityB2XUserFlowPostFederationSignupByRef](Get-MgBetaIdentityB2XUserFlowPostFederationSignupByRef.md)
Get ref of postFederationSignup from identity

### [Get-MgBetaIdentityB2XUserFlowPreTokenIssuance](Get-MgBetaIdentityB2XUserFlowPreTokenIssuance.md)
Get preTokenIssuance from identity

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
The user attribute assignments included in the user flow.

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentCount](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Invoke function getOrder

### [Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentUserAttribute](Get-MgBetaIdentityB2XUserFlowUserAttributeAssignmentUserAttribute.md)
The user attribute that you want to add to your user flow.

### [Get-MgBetaIdentityConditionalAccess](Get-MgBetaIdentityConditionalAccess.md)
the entry point for the Conditional Access (CA) object model.

### [Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Retrieve the properties and relationships of a authenticationContextClassReference object.

### [Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReferenceCount](Get-MgBetaIdentityConditionalAccessAuthenticationContextClassReferenceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrength](Get-MgBetaIdentityConditionalAccessAuthenticationStrength.md)
Get authenticationStrengths from identity

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Names and descriptions of all valid authentication method modes in the system.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodModeCount](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodModeCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Read the properties and relationships of an authenticationCombinationConfiguration object.

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfigurationCount](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfigurationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCount](Get-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessNamedLocation](Get-MgBetaIdentityConditionalAccessNamedLocation.md)
Retrieve the properties and relationships of a countryNamedLocation object.

### [Get-MgBetaIdentityConditionalAccessNamedLocationCount](Get-MgBetaIdentityConditionalAccessNamedLocationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessPolicy](Get-MgBetaIdentityConditionalAccessPolicy.md)
Retrieve the properties and relationships of a conditionalAccessPolicy object.

### [Get-MgBetaIdentityConditionalAccessPolicyCount](Get-MgBetaIdentityConditionalAccessPolicyCount.md)
Get the number of the resource

### [Get-MgBetaIdentityConditionalAccessTemplate](Get-MgBetaIdentityConditionalAccessTemplate.md)
Read the properties and relationships of a conditionalAccessTemplate object.

### [Get-MgBetaIdentityConditionalAccessTemplateCount](Get-MgBetaIdentityConditionalAccessTemplateCount.md)
Get the number of the resource

### [Get-MgBetaIdentityContinuouAccessEvaluationPolicy](Get-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Read the properties and relationships of a continuousAccessEvaluationPolicy object.

### [Get-MgBetaIdentityCustomAuthenticationExtension](Get-MgBetaIdentityCustomAuthenticationExtension.md)
Read the properties and relationships of an authenticationEventListener object.
The @odata.type property in the response object indicates the type of the authenticationEventListener object.

### [Get-MgBetaIdentityCustomAuthenticationExtensionCount](Get-MgBetaIdentityCustomAuthenticationExtensionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityProvider](Get-MgBetaIdentityProvider.md)
Get the properties and relationships of the specified identity provider configured in the tenant.
Among the types of providers derived from identityProviderBase, you can currently get a socialIdentityProvider or a builtinIdentityProvider resource in Azure AD.
In Azure AD B2C, this operation can currently get a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

### [Get-MgBetaIdentityProviderCount](Get-MgBetaIdentityProviderCount.md)
Get the number of the resource

### [Get-MgBetaIdentityUserFlow](Get-MgBetaIdentityUserFlow.md)
Retrieve the properties and associations for an userFlow object.

### [Get-MgBetaIdentityUserFlowAttribute](Get-MgBetaIdentityUserFlowAttribute.md)
Retrieve the properties and relationships of a identityUserFlowAttribute object.

### [Get-MgBetaIdentityUserFlowAttributeCount](Get-MgBetaIdentityUserFlowAttributeCount.md)
Get the number of the resource

### [Get-MgBetaIdentityUserFlowCount](Get-MgBetaIdentityUserFlowCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtection](Get-MgBetaInformationProtection.md)
Get informationProtection

### [Get-MgBetaInformationProtectionBitlocker](Get-MgBetaInformationProtectionBitlocker.md)
Get bitlocker from informationProtection

### [Get-MgBetaInformationProtectionBitlockerRecoveryKey](Get-MgBetaInformationProtectionBitlockerRecoveryKey.md)
Retrieve the properties and relationships of a bitlockerRecoveryKey object.
By default, this operation does not return the key property that represents the actual recovery key.
To include the key property in the response, use the $select OData query parameter.
Including the $select query parameter triggers an Azure AD audit of the operation and generates an audit log.
You can find the log in Azure AD audit logs under the KeyManagement category.

### [Get-MgBetaInformationProtectionBitlockerRecoveryKeyCount](Get-MgBetaInformationProtectionBitlockerRecoveryKeyCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionDataLossPreventionPolicy](Get-MgBetaInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from informationProtection

### [Get-MgBetaInformationProtectionDataLossPreventionPolicyCount](Get-MgBetaInformationProtectionDataLossPreventionPolicyCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionPolicy](Get-MgBetaInformationProtectionPolicy.md)
Get policy from informationProtection

### [Get-MgBetaInformationProtectionPolicyLabel](Get-MgBetaInformationProtectionPolicyLabel.md)
Retrieve the properties and relationships of an informationProtectionLabel object.

### [Get-MgBetaInformationProtectionPolicyLabelCount](Get-MgBetaInformationProtectionPolicyLabelCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionSensitivityLabelCount](Get-MgBetaInformationProtectionSensitivityLabelCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionSensitivityLabelSublabelCount](Get-MgBetaInformationProtectionSensitivityLabelSublabelCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionSensitivityPolicySetting](Get-MgBetaInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from informationProtection

### [Get-MgBetaInformationProtectionThreatAssessmentRequest](Get-MgBetaInformationProtectionThreatAssessmentRequest.md)
Retrieve the properties and relationships of a specified threatAssessmentRequest object.
A threat assessment request can be one of the following types:

### [Get-MgBetaInformationProtectionThreatAssessmentRequestCount](Get-MgBetaInformationProtectionThreatAssessmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaInformationProtectionThreatAssessmentRequestResult](Get-MgBetaInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Get-MgBetaInformationProtectionThreatAssessmentRequestResultCount](Get-MgBetaInformationProtectionThreatAssessmentRequestResultCount.md)
Get the number of the resource

### [Get-MgBetaInvitation](Get-MgBetaInvitation.md)
Get entity from invitations by key

### [Get-MgBetaInvitationCount](Get-MgBetaInvitationCount.md)
Get the number of the resource

### [Get-MgBetaInvitationInvitedUserMailboxSetting](Get-MgBetaInvitationInvitedUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaInvitationInvitedUserSponsor](Get-MgBetaInvitationInvitedUserSponsor.md)
The users or groups who are sponsors of the invited user.
Sponsors are users and groups that are responsible for guest users' privileges in the tenant and for keeping the guest users' information and access up to date.

### [Get-MgBetaInvitationInvitedUserSponsorCount](Get-MgBetaInvitationInvitedUserSponsorCount.md)
Get the number of the resource

### [Get-MgBetaOauth2PermissionGrant](Get-MgBetaOauth2PermissionGrant.md)
Retrieve the properties of a single delegated permission grant represented by an oAuth2PermissionGrant object.
An oAuth2PermissionGrant represents delegated permissions which have been granted for a client application to access an API on behalf of a signed-in user.

### [Get-MgBetaOauth2PermissionGrantCount](Get-MgBetaOauth2PermissionGrantCount.md)
Get the number of the resource

### [Get-MgBetaOauth2PermissionGrantDelta](Get-MgBetaOauth2PermissionGrantDelta.md)
Invoke function delta

### [Get-MgBetaOrganizationCertificateBasedAuthConfiguration](Get-MgBetaOrganizationCertificateBasedAuthConfiguration.md)
Get the properties of a certificateBasedAuthConfiguration object.

### [Get-MgBetaOrganizationCertificateBasedAuthConfigurationCount](Get-MgBetaOrganizationCertificateBasedAuthConfigurationCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAccessReviewPolicy](Get-MgBetaPolicyAccessReviewPolicy.md)
Read the properties and relationships of an accessReviewPolicy object.

### [Get-MgBetaPolicyActivityBasedTimeoutPolicy](Get-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Get the properties of an activityBasedTimeoutPolicy object.

### [Get-MgBetaPolicyActivityBasedTimeoutPolicyApplyTo](Get-MgBetaPolicyActivityBasedTimeoutPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyActivityBasedTimeoutPolicyApplyToCount](Get-MgBetaPolicyActivityBasedTimeoutPolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyActivityBasedTimeoutPolicyCount](Get-MgBetaPolicyActivityBasedTimeoutPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAdminConsentRequestPolicy](Get-MgBetaPolicyAdminConsentRequestPolicy.md)
Read the properties and relationships of an adminConsentRequestPolicy object.

### [Get-MgBetaPolicyAppManagementPolicy](Get-MgBetaPolicyAppManagementPolicy.md)
Read the properties of an appManagementPolicy object.

### [Get-MgBetaPolicyAppManagementPolicyApplyTo](Get-MgBetaPolicyAppManagementPolicyApplyTo.md)
Collection of application and service principals to which a policy is applied.

### [Get-MgBetaPolicyAppManagementPolicyApplyToCount](Get-MgBetaPolicyAppManagementPolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAppManagementPolicyCount](Get-MgBetaPolicyAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAuthenticationFlowPolicy](Get-MgBetaPolicyAuthenticationFlowPolicy.md)
Read the properties and relationships of an authenticationFlowsPolicy object.

### [Get-MgBetaPolicyAuthenticationMethodPolicy](Get-MgBetaPolicyAuthenticationMethodPolicy.md)
Read the properties and relationships of an authenticationMethodsPolicy object.

### [Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Represents the settings for each authentication method.
Automatically expanded on GET /policies/authenticationMethodsPolicy.

### [Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfigurationCount](Get-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfigurationCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAuthenticationStrengthPolicy](Get-MgBetaPolicyAuthenticationStrengthPolicy.md)
Read the properties and relationships of an authenticationStrengthPolicy object.

### [Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Read the properties and relationships of an authenticationCombinationConfiguration object.

### [Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfigurationCount](Get-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfigurationCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAuthenticationStrengthPolicyCount](Get-MgBetaPolicyAuthenticationStrengthPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAuthorizationPolicy](Get-MgBetaPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Get-MgBetaPolicyAuthorizationPolicyCount](Get-MgBetaPolicyAuthorizationPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Get defaultUserRoleOverrides from policies

### [Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverrideCount](Get-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverrideCount.md)
Get the number of the resource

### [Get-MgBetaPolicyB2CAuthenticationMethodPolicy](Get-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Read the properties of a b2cAuthenticationMethodsPolicy object.

### [Get-MgBetaPolicyClaimMappingPolicy](Get-MgBetaPolicyClaimMappingPolicy.md)
Retrieve the properties and relationships of a claimsMappingPolicy object.

### [Get-MgBetaPolicyClaimMappingPolicyApplyTo](Get-MgBetaPolicyClaimMappingPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyClaimMappingPolicyApplyToCount](Get-MgBetaPolicyClaimMappingPolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyClaimMappingPolicyCount](Get-MgBetaPolicyClaimMappingPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyConditionalAccessPolicyCount](Get-MgBetaPolicyConditionalAccessPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyCrossTenantAccessPolicy](Get-MgBetaPolicyCrossTenantAccessPolicy.md)
Read the properties and relationships of a crossTenantAccessPolicy object.

### [Get-MgBetaPolicyCrossTenantAccessPolicyDefault](Get-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Read the default configuration of a cross-tenant access policy.
This default configuration may be the service default assigned by Azure AD (isServiceDefault is true) or may be customized in your tenant (isServiceDefault is false).

### [Get-MgBetaPolicyCrossTenantAccessPolicyPartner](Get-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Read the properties and relationships of a partner-specific configuration.

### [Get-MgBetaPolicyCrossTenantAccessPolicyPartnerCount](Get-MgBetaPolicyCrossTenantAccessPolicyPartnerCount.md)
Get the number of the resource

### [Get-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization](Get-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization.md)
Get the user synchronization policy of a partner-specific configuration.

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
Retrieve the properties and relationships of a featureRolloutPolicy object.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyTo](Get-MgBetaPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToById](Get-MgBetaPolicyFeatureRolloutPolicyApplyToById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](Get-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToCount](Get-MgBetaPolicyFeatureRolloutPolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToDelta](Get-MgBetaPolicyFeatureRolloutPolicyApplyToDelta.md)
Invoke function delta

### [Get-MgBetaPolicyFeatureRolloutPolicyApplyToUserOwnedObject](Get-MgBetaPolicyFeatureRolloutPolicyApplyToUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.

### [Get-MgBetaPolicyFeatureRolloutPolicyCount](Get-MgBetaPolicyFeatureRolloutPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyFederatedTokenValidationPolicy](Get-MgBetaPolicyFederatedTokenValidationPolicy.md)
Get federatedTokenValidationPolicy from policies

### [Get-MgBetaPolicyHomeRealmDiscoveryPolicy](Get-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Retrieve the properties and relationships of a homeRealmDiscoveryPolicy object.

### [Get-MgBetaPolicyHomeRealmDiscoveryPolicyApplyTo](Get-MgBetaPolicyHomeRealmDiscoveryPolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyHomeRealmDiscoveryPolicyApplyToCount](Get-MgBetaPolicyHomeRealmDiscoveryPolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyHomeRealmDiscoveryPolicyCount](Get-MgBetaPolicyHomeRealmDiscoveryPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Get-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Retrieve the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Get-MgBetaPolicyMobileAppManagementPolicy](Get-MgBetaPolicyMobileAppManagementPolicy.md)
Read the properties and relationships of a mobilityManagementPolicy object.

### [Get-MgBetaPolicyMobileAppManagementPolicyCount](Get-MgBetaPolicyMobileAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroup](Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupCount](Get-MgBetaPolicyMobileAppManagementPolicyIncludedGroupCount.md)
Get the number of the resource

### [Get-MgBetaPolicyMobileDeviceManagementPolicy](Get-MgBetaPolicyMobileDeviceManagementPolicy.md)
Read the properties and relationships of a mobilityManagementPolicy object.

### [Get-MgBetaPolicyMobileDeviceManagementPolicyCount](Get-MgBetaPolicyMobileDeviceManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroup](Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroup.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Get the list of groups that are included in a mobile app management policy.

### [Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupCount](Get-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupCount.md)
Get the number of the resource

### [Get-MgBetaPolicyPermissionGrantPolicy](Get-MgBetaPolicyPermissionGrantPolicy.md)
Retrieve a single permissionGrantPolicy object.

### [Get-MgBetaPolicyPermissionGrantPolicyCount](Get-MgBetaPolicyPermissionGrantPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyPermissionGrantPolicyExclude](Get-MgBetaPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Get-MgBetaPolicyPermissionGrantPolicyExcludeCount](Get-MgBetaPolicyPermissionGrantPolicyExcludeCount.md)
Get the number of the resource

### [Get-MgBetaPolicyPermissionGrantPolicyInclude](Get-MgBetaPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Get-MgBetaPolicyPermissionGrantPolicyIncludeCount](Get-MgBetaPolicyPermissionGrantPolicyIncludeCount.md)
Get the number of the resource

### [Get-MgBetaPolicyRoleManagementPolicy](Get-MgBetaPolicyRoleManagementPolicy.md)
Represents the role management policies.

### [Get-MgBetaPolicyRoleManagementPolicyAssignment](Get-MgBetaPolicyRoleManagementPolicyAssignment.md)
Represents the role management policy assignments.

### [Get-MgBetaPolicyRoleManagementPolicyAssignmentCount](Get-MgBetaPolicyRoleManagementPolicyAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPolicyRoleManagementPolicyAssignmentPolicy](Get-MgBetaPolicyRoleManagementPolicyAssignmentPolicy.md)
The policy that's associated with a policy assignment.
Supports $expand and a nested $expand of the rules and effectiveRules relationships for the policy.

### [Get-MgBetaPolicyRoleManagementPolicyCount](Get-MgBetaPolicyRoleManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyRoleManagementPolicyEffectiveRule](Get-MgBetaPolicyRoleManagementPolicyEffectiveRule.md)
The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules.
For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval.
Supports $expand.

### [Get-MgBetaPolicyRoleManagementPolicyEffectiveRuleCount](Get-MgBetaPolicyRoleManagementPolicyEffectiveRuleCount.md)
Get the number of the resource

### [Get-MgBetaPolicyRoleManagementPolicyRule](Get-MgBetaPolicyRoleManagementPolicyRule.md)
Retrieve a rule defined for a role management policy.
The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:\n+ unifiedRoleManagementPolicyApprovalRule\n+ unifiedRoleManagementPolicyAuthenticationContextRule\n+ unifiedRoleManagementPolicyEnablementRule\n+ unifiedRoleManagementPolicyExpirationRule\n+ unifiedRoleManagementPolicyNotificationRule

### [Get-MgBetaPolicyRoleManagementPolicyRuleCount](Get-MgBetaPolicyRoleManagementPolicyRuleCount.md)
Get the number of the resource

### [Get-MgBetaPolicyServicePrincipalCreationPolicy](Get-MgBetaPolicyServicePrincipalCreationPolicy.md)
Get servicePrincipalCreationPolicies from policies

### [Get-MgBetaPolicyServicePrincipalCreationPolicyCount](Get-MgBetaPolicyServicePrincipalCreationPolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyServicePrincipalCreationPolicyExclude](Get-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Get excludes from policies

### [Get-MgBetaPolicyServicePrincipalCreationPolicyExcludeCount](Get-MgBetaPolicyServicePrincipalCreationPolicyExcludeCount.md)
Get the number of the resource

### [Get-MgBetaPolicyServicePrincipalCreationPolicyInclude](Get-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Get includes from policies

### [Get-MgBetaPolicyServicePrincipalCreationPolicyIncludeCount](Get-MgBetaPolicyServicePrincipalCreationPolicyIncludeCount.md)
Get the number of the resource

### [Get-MgBetaPolicyTokenIssuancePolicy](Get-MgBetaPolicyTokenIssuancePolicy.md)
Retrieve the properties and relationships of a tokenIssuancePolicy object.

### [Get-MgBetaPolicyTokenIssuancePolicyApplyTo](Get-MgBetaPolicyTokenIssuancePolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyTokenIssuancePolicyApplyToCount](Get-MgBetaPolicyTokenIssuancePolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyTokenIssuancePolicyCount](Get-MgBetaPolicyTokenIssuancePolicyCount.md)
Get the number of the resource

### [Get-MgBetaPolicyTokenLifetimePolicy](Get-MgBetaPolicyTokenLifetimePolicy.md)
Retrieve the properties and relationships of a tokenLifetimePolicy object.

### [Get-MgBetaPolicyTokenLifetimePolicyApplyTo](Get-MgBetaPolicyTokenLifetimePolicyApplyTo.md)
Get appliesTo from policies

### [Get-MgBetaPolicyTokenLifetimePolicyApplyToCount](Get-MgBetaPolicyTokenLifetimePolicyApplyToCount.md)
Get the number of the resource

### [Get-MgBetaPolicyTokenLifetimePolicyCount](Get-MgBetaPolicyTokenLifetimePolicyCount.md)
Get the number of the resource

### [Get-MgBetaRiskDetection](Get-MgBetaRiskDetection.md)
Retrieve the properties of a collection of riskDetection objects.

### [Get-MgBetaRiskDetectionCount](Get-MgBetaRiskDetectionCount.md)
Get the number of the resource

### [Get-MgBetaRiskyServicePrincipal](Get-MgBetaRiskyServicePrincipal.md)
Read the properties and relationships of a riskyServicePrincipal object.

### [Get-MgBetaRiskyServicePrincipalCount](Get-MgBetaRiskyServicePrincipalCount.md)
Get the number of the resource

### [Get-MgBetaRiskyServicePrincipalHistory](Get-MgBetaRiskyServicePrincipalHistory.md)
Represents the risk history of Azure AD service principals.

### [Get-MgBetaRiskyServicePrincipalHistoryCount](Get-MgBetaRiskyServicePrincipalHistoryCount.md)
Get the number of the resource

### [Get-MgBetaRiskyUser](Get-MgBetaRiskyUser.md)
Users that are flagged as at-risk by Azure AD Identity Protection.

### [Get-MgBetaRiskyUserCount](Get-MgBetaRiskyUserCount.md)
Get the number of the resource

### [Get-MgBetaRiskyUserHistory](Get-MgBetaRiskyUserHistory.md)
Get a riskyUserHistoryItem object of a riskyUser.

### [Get-MgBetaRiskyUserHistoryCount](Get-MgBetaRiskyUserHistoryCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalRiskDetection](Get-MgBetaServicePrincipalRiskDetection.md)
Read the properties and relationships of a servicePrincipalRiskDetection object.

### [Get-MgBetaServicePrincipalRiskDetectionCount](Get-MgBetaServicePrincipalRiskDetectionCount.md)
Get the number of the resource

### [Get-MgBetaTenantRelationshipMultiTenantOrganization](Get-MgBetaTenantRelationshipMultiTenantOrganization.md)
Get properties of the multi-tenant organization.

### [Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest](Get-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest.md)
Get the status of a tenant joining a multi-tenant organization.

### [Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant](Get-MgBetaTenantRelationshipMultiTenantOrganizationTenant.md)
Get a tenant and its properties in the multi-tenant organization.

### [Get-MgBetaTenantRelationshipMultiTenantOrganizationTenantCount](Get-MgBetaTenantRelationshipMultiTenantOrganizationTenantCount.md)
Get the number of the resource

### [Get-MgBetaTrustFramework](Get-MgBetaTrustFramework.md)
Get trustFramework

### [Get-MgBetaTrustFrameworkKeySet](Get-MgBetaTrustFrameworkKeySet.md)
Retrieve the properties and associations for a Trustframeworkkeyset.

### [Get-MgBetaTrustFrameworkKeySetActiveKey](Get-MgBetaTrustFrameworkKeySetActiveKey.md)
Invoke function getActiveKey

### [Get-MgBetaTrustFrameworkKeySetCount](Get-MgBetaTrustFrameworkKeySetCount.md)
Get the number of the resource

### [Get-MgBetaTrustFrameworkPolicy](Get-MgBetaTrustFrameworkPolicy.md)
Get policies from trustFramework

### [Get-MgBetaTrustFrameworkPolicyContent](Get-MgBetaTrustFrameworkPolicyContent.md)
Get media content for the navigation property policies from trustFramework

### [Get-MgBetaTrustFrameworkPolicyCount](Get-MgBetaTrustFrameworkPolicyCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationEmailMethod](Get-MgBetaUserAuthenticationEmailMethod.md)
Retrieve a user's single email Authentication Method object.

### [Get-MgBetaUserAuthenticationEmailMethodCount](Get-MgBetaUserAuthenticationEmailMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationFido2Method](Get-MgBetaUserAuthenticationFido2Method.md)
Retrieve a user's single FIDO2 Security Key Authentication Method object.

### [Get-MgBetaUserAuthenticationFido2MethodCount](Get-MgBetaUserAuthenticationFido2MethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationMethod](Get-MgBetaUserAuthenticationMethod.md)
Retrieve the properties and relationships of an authenticationMethod object.

### [Get-MgBetaUserAuthenticationMethodCount](Get-MgBetaUserAuthenticationMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod.md)
Read the properties and relationships of a microsoftAuthenticatorAuthenticationMethod object.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodCount](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgBetaUserAuthenticationOperation](Get-MgBetaUserAuthenticationOperation.md)
Retrieve the properties and relationships of an operation object.
Currently these operations are generated by initiating a password reset using the reset password method.
An operation object tells the caller about the current state of that password reset operation.
Possible states include: Succeeded and Failed are terminal states.

### [Get-MgBetaUserAuthenticationOperationCount](Get-MgBetaUserAuthenticationOperationCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Retrieve a user's single Microsoft Authenticator Passwordless Phone Sign-in method object.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodCount](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice.md)
Get device from users

### [Get-MgBetaUserAuthenticationPasswordMethod](Get-MgBetaUserAuthenticationPasswordMethod.md)
Retrieve the properties and relationships of a password authentication method object.

### [Get-MgBetaUserAuthenticationPasswordMethodCount](Get-MgBetaUserAuthenticationPasswordMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationPhoneMethod](Get-MgBetaUserAuthenticationPhoneMethod.md)
Retrieve a single phoneAuthenticationMethod object.
This method is available only for standard Azure AD and B2B users, but not B2C users.

### [Get-MgBetaUserAuthenticationPhoneMethodCount](Get-MgBetaUserAuthenticationPhoneMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationSoftwareOathMethod](Get-MgBetaUserAuthenticationSoftwareOathMethod.md)
Retrieve a user's single Software OATH token authentication method object and its properties.

### [Get-MgBetaUserAuthenticationSoftwareOathMethodCount](Get-MgBetaUserAuthenticationSoftwareOathMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationTemporaryAccessPassMethod](Get-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Retrieve a user's single temporaryAccessPassAuthenticationMethod object.

### [Get-MgBetaUserAuthenticationTemporaryAccessPassMethodCount](Get-MgBetaUserAuthenticationTemporaryAccessPassMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethod](Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethod.md)
Read the properties and relationships of a windowsHelloForBusinessAuthenticationMethod object.

### [Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethodCount](Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethodCount.md)
Get the number of the resource

### [Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethodDevice](Get-MgBetaUserAuthenticationWindowsHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Get-MgBetaUserInformationProtection](Get-MgBetaUserInformationProtection.md)
Get informationProtection from users

### [Get-MgBetaUserInformationProtectionBitlocker](Get-MgBetaUserInformationProtectionBitlocker.md)
Get bitlocker from users

### [Get-MgBetaUserInformationProtectionBitlockerRecoveryKey](Get-MgBetaUserInformationProtectionBitlockerRecoveryKey.md)
Retrieve the properties and relationships of a bitlockerRecoveryKey object.
By default, this operation does not return the key property that represents the actual recovery key.
To include the key property in the response, use the $select OData query parameter.
Including the $select query parameter triggers an Azure AD audit of the operation and generates an audit log.
You can find the log in Azure AD audit logs under the KeyManagement category.

### [Get-MgBetaUserInformationProtectionBitlockerRecoveryKeyCount](Get-MgBetaUserInformationProtectionBitlockerRecoveryKeyCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionDataLossPreventionPolicy](Get-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Get dataLossPreventionPolicies from users

### [Get-MgBetaUserInformationProtectionDataLossPreventionPolicyCount](Get-MgBetaUserInformationProtectionDataLossPreventionPolicyCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionPolicy](Get-MgBetaUserInformationProtectionPolicy.md)
Get policy from users

### [Get-MgBetaUserInformationProtectionPolicyLabel](Get-MgBetaUserInformationProtectionPolicyLabel.md)
Retrieve the properties and relationships of an informationProtectionLabel object.

### [Get-MgBetaUserInformationProtectionPolicyLabelCount](Get-MgBetaUserInformationProtectionPolicyLabelCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionSensitivityLabel](Get-MgBetaUserInformationProtectionSensitivityLabel.md)
Get sensitivityLabels from users

### [Get-MgBetaUserInformationProtectionSensitivityLabelCount](Get-MgBetaUserInformationProtectionSensitivityLabelCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionSensitivityLabelSublabel](Get-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Get sublabels from users

### [Get-MgBetaUserInformationProtectionSensitivityLabelSublabelCount](Get-MgBetaUserInformationProtectionSensitivityLabelSublabelCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionSensitivityPolicySetting](Get-MgBetaUserInformationProtectionSensitivityPolicySetting.md)
Get sensitivityPolicySettings from users

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequest](Get-MgBetaUserInformationProtectionThreatAssessmentRequest.md)
Retrieve the properties and relationships of a specified threatAssessmentRequest object.
A threat assessment request can be one of the following types:

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequestCount](Get-MgBetaUserInformationProtectionThreatAssessmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequestResult](Get-MgBetaUserInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Get-MgBetaUserInformationProtectionThreatAssessmentRequestResultCount](Get-MgBetaUserInformationProtectionThreatAssessmentRequestResultCount.md)
Get the number of the resource

### [Invoke-MgBetaAvailableIdentityProviderType](Invoke-MgBetaAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgBetaBufferInformationProtectionDecrypt](Invoke-MgBetaBufferInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBetaBufferInformationProtectionEncrypt](Invoke-MgBetaBufferInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgBetaDismissRiskyServicePrincipal](Invoke-MgBetaDismissRiskyServicePrincipal.md)
Dismiss the risk of one or more riskyServicePrincipal objects.
This action sets the targeted service principal account's risk level to none.
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

### [Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPostAttributeCollectionClientCertificate](Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPostAttributeCollectionClientCertificate.md)
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

### [Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPostFederationSignupClientCertificate](Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPostFederationSignupClientCertificate.md)
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

### [Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate](Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate.md)
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

### [New-MgBetaIdentityAuthenticationEventFlow](New-MgBetaIdentityAuthenticationEventFlow.md)
Create a new authenticationEventsFlow object that is of the type specified in the request body.
You can create only an externalUsersSelfServiceSignupEventsFlow object type.

### [New-MgBetaIdentityAuthenticationEventListener](New-MgBetaIdentityAuthenticationEventListener.md)
Create a new authenticationEventListener object.
You can create one of the following subtypes that are derived from authenticationEventListener.

### [New-MgBetaIdentityB2CUserFlow](New-MgBetaIdentityB2CUserFlow.md)
Create a new b2cIdentityUserFlow object.

### [New-MgBetaIdentityB2CUserFlowIdentityProviderByRef](New-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Add identity providers in a b2cIdentityUserFlow object.

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
Create a new customAuthenticationExtension object.
Only the onTokenIssuanceStartCustomExtension object type is supported.

### [New-MgBetaIdentityProvider](New-MgBetaIdentityProvider.md)
Create an identity provider object that is of the type specified in the request body.
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

### [New-MgBetaOrganizationCertificateBasedAuthConfiguration](New-MgBetaOrganizationCertificateBasedAuthConfiguration.md)
Create a new certificateBasedAuthConfiguration object.

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
Add an appliesTo on a featureRolloutPolicy object to specify the directoryObject to which the featureRolloutPolicy should be applied.

### [New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Add an appliesTo on a featureRolloutPolicy object to specify the directoryObject to which the featureRolloutPolicy should be applied.

### [New-MgBetaPolicyHomeRealmDiscoveryPolicy](New-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Create a new homeRealmDiscoveryPolicy object.

### [New-MgBetaPolicyMobileAppManagementPolicy](New-MgBetaPolicyMobileAppManagementPolicy.md)
Create new navigation property to mobileAppManagementPolicies for policies

### [New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Add groups to be included in a mobile app management policy.

### [New-MgBetaPolicyMobileDeviceManagementPolicy](New-MgBetaPolicyMobileDeviceManagementPolicy.md)
Create new navigation property to mobileDeviceManagementPolicies for policies

### [New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Add groups to be included in a mobile app management policy.

### [New-MgBetaPolicyPermissionGrantPolicy](New-MgBetaPolicyPermissionGrantPolicy.md)
Creates a permissionGrantPolicy.
A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).
After creating the permission grant policy, you can add include condition sets to add matching rules, and add exclude condition sets to add exclusion rules.

### [New-MgBetaPolicyPermissionGrantPolicyExclude](New-MgBetaPolicyPermissionGrantPolicyExclude.md)
Add conditions under which a permission grant event is *excluded* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the excludes collection of a  permissionGrantPolicy.

### [New-MgBetaPolicyPermissionGrantPolicyInclude](New-MgBetaPolicyPermissionGrantPolicyInclude.md)
Add conditions under which a permission grant event is *included* in a permission grant policy.
You do this by adding a permissionGrantConditionSet to the includes collection of a  permissionGrantPolicy.

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

### [New-MgBetaTenantRelationshipMultiTenantOrganizationTenant](New-MgBetaTenantRelationshipMultiTenantOrganizationTenant.md)
Add a tenant to a multi-tenant organization.
The administrator of an owner tenant has the permissions to add tenants to the multi-tenant organization.
The added tenant is in the pending state until the administrator of the added tenant joins the multi-tenant organization by submitting a join request.
Note that a tenant can be part of only one multi-tenant organization.

### [New-MgBetaTrustFrameworkKeySet](New-MgBetaTrustFrameworkKeySet.md)
Create a new trustFrameworkKeySet.
The ID of the trustFrameworkKeySet is expected in the create request; however, it can be modified by the service.
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

### [New-MgBetaUserAuthenticationMethod](New-MgBetaUserAuthenticationMethod.md)
Create new navigation property to methods for users

### [New-MgBetaUserAuthenticationOperation](New-MgBetaUserAuthenticationOperation.md)
Create new navigation property to operations for users

### [New-MgBetaUserAuthenticationPhoneMethod](New-MgBetaUserAuthenticationPhoneMethod.md)
Add a new phone authentication method.
A user may only have one phone of each type, captured in the phoneType property.
This means, for example, adding a mobile phone to a user with a preexisting mobile phone will fail.
Additionally, a user must always have a mobile phone before adding an alternateMobile phone.
Adding a phone number makes it available for use in both Azure multi-factor authentication (MFA) and self-service password reset (SSPR), if enabled.
Additionally, if a user is enabled by policy to use SMS sign-in and a mobile number is added, the system will attempt to register the number for use in that system.

### [New-MgBetaUserAuthenticationTemporaryAccessPassMethod](New-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Create a new temporaryAccessPassAuthenticationMethod object on a user.
A user can only have one Temporary Access Pass that's usable within its specified lifetime.
If the user requires a new Temporary Access Pass while the current Temporary Access Pass is valid, the admin can create a new Temporary Access Pass for the user, the previous Temporary Access Pass will be deleted, and a new Temporary Access Pass will be created.

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
Deletes an identityApiConnector object.

### [Remove-MgBetaIdentityAuthenticationEventFlow](Remove-MgBetaIdentityAuthenticationEventFlow.md)
Delete a specific authenticationEventsFlow resource by ID.
Only externalUsersSelfServiceSignupEventsFlow object types are available.

### [Remove-MgBetaIdentityAuthenticationEventListener](Remove-MgBetaIdentityAuthenticationEventListener.md)
Deletes an authenticationEventListener object.

### [Remove-MgBetaIdentityB2CUserFlow](Remove-MgBetaIdentityB2CUserFlow.md)
Delete a b2cIdentityUserFlow object.

### [Remove-MgBetaIdentityB2CUserFlowIdentityProviderByRef](Remove-MgBetaIdentityB2CUserFlowIdentityProviderByRef.md)
Delete an identity provider from a b2cIdentityUserFlow object.
For more information about identity providers available for user flows, see the identityProviders API reference.

### [Remove-MgBetaIdentityB2CUserFlowLanguage](Remove-MgBetaIdentityB2CUserFlowLanguage.md)
Deletes a userFlowLanguageConfiguration object from a Azure AD B2C user flow.
Note: You cannot delete languages from an Azure Active Directory user flow.

### [Remove-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Remove-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgBetaIdentityB2CUserFlowLanguageOverridePage](Remove-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Remove-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Delete an identityUserFlowAttributeAssignment object.

### [Remove-MgBetaIdentityB2XUserFlow](Remove-MgBetaIdentityB2XUserFlow.md)
Delete a b2xIdentityUserFlow object.

### [Remove-MgBetaIdentityB2XUserFlowIdentityProvider](Remove-MgBetaIdentityB2XUserFlowIdentityProvider.md)
Delete an identity provider from a b2xIdentityUserFlow object.
For self-service sign up user flows, the values can be Google-OAUTH or Facebook-OAUTH.

### [Remove-MgBetaIdentityB2XUserFlowIdentityProviderByRef](Remove-MgBetaIdentityB2XUserFlowIdentityProviderByRef.md)
Delete ref of navigation property userFlowIdentityProviders for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguage](Remove-MgBetaIdentityB2XUserFlowLanguage.md)
Delete navigation property languages for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Remove-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Delete navigation property defaultPages for identity

### [Remove-MgBetaIdentityB2XUserFlowLanguageOverridePage](Remove-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Delete navigation property overridesPages for identity

### [Remove-MgBetaIdentityB2XUserFlowPostAttributeCollection](Remove-MgBetaIdentityB2XUserFlowPostAttributeCollection.md)
Delete navigation property postAttributeCollection for identity

### [Remove-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef](Remove-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef.md)
Delete ref of navigation property postAttributeCollection for identity

### [Remove-MgBetaIdentityB2XUserFlowPostFederationSignup](Remove-MgBetaIdentityB2XUserFlowPostFederationSignup.md)
Delete navigation property postFederationSignup for identity

### [Remove-MgBetaIdentityB2XUserFlowPostFederationSignupByRef](Remove-MgBetaIdentityB2XUserFlowPostFederationSignupByRef.md)
Delete ref of navigation property postFederationSignup for identity

### [Remove-MgBetaIdentityB2XUserFlowPreTokenIssuance](Remove-MgBetaIdentityB2XUserFlowPreTokenIssuance.md)
Delete navigation property preTokenIssuance for identity

### [Remove-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Remove-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
Delete navigation property userAttributeAssignments for identity

### [Remove-MgBetaIdentityConditionalAccess](Remove-MgBetaIdentityConditionalAccess.md)
Delete navigation property conditionalAccess for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Remove-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Delete an authenticationContextClassReference object that's not published or used by a conditional access policy.

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrength](Remove-MgBetaIdentityConditionalAccessAuthenticationStrength.md)
Delete navigation property authenticationStrengths for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthAuthenticationMethodMode.md)
Delete navigation property authenticationMethodModes for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicy.md)
Delete navigation property policies for identity

### [Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete an authenticationCombinationConfiguration  for a custom authenticationStrengthPolicy object.

### [Remove-MgBetaIdentityConditionalAccessNamedLocation](Remove-MgBetaIdentityConditionalAccessNamedLocation.md)
Delete a countryNamedLocation object.

### [Remove-MgBetaIdentityConditionalAccessPolicy](Remove-MgBetaIdentityConditionalAccessPolicy.md)
Delete a conditionalAccessPolicy object.

### [Remove-MgBetaIdentityContinuouAccessEvaluationPolicy](Remove-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Delete navigation property continuousAccessEvaluationPolicy for identity

### [Remove-MgBetaIdentityCustomAuthenticationExtension](Remove-MgBetaIdentityCustomAuthenticationExtension.md)
Delete a customAuthenticationExtension object.

### [Remove-MgBetaIdentityProvider](Remove-MgBetaIdentityProvider.md)
Delete an identity provider resource that is of the type specified by the id in the request.
Among the types of providers derived from identityProviderBase, you can currently delete a socialIdentityProvider resource in Azure AD.
In Azure AD B2C, this operation can currently delete a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

### [Remove-MgBetaIdentityUserFlow](Remove-MgBetaIdentityUserFlow.md)
Delete an existing userFlow object.

### [Remove-MgBetaIdentityUserFlowAttribute](Remove-MgBetaIdentityUserFlowAttribute.md)
Delete an identityUserFlowAttribute.
Only custom user flow attributes can be deleted.

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

### [Remove-MgBetaInvitation](Remove-MgBetaInvitation.md)
Delete entity from invitations

### [Remove-MgBetaOauth2PermissionGrant](Remove-MgBetaOauth2PermissionGrant.md)
Delete an oAuth2PermissionGrant, representing a delegated permission grant.
When a delegated permission grant is deleted, the access it granted is revoked.
Existing access tokens will continue to be valid for their lifetime, but new access tokens will not be granted for the delegated permissions identified in the deleted oAuth2PermissionGrant.

### [Remove-MgBetaOrganizationCertificateBasedAuthConfiguration](Remove-MgBetaOrganizationCertificateBasedAuthConfiguration.md)
Delete a certificateBasedAuthConfiguration object.

### [Remove-MgBetaPolicyAccessReviewPolicy](Remove-MgBetaPolicyAccessReviewPolicy.md)
Delete navigation property accessReviewPolicy for policies

### [Remove-MgBetaPolicyActivityBasedTimeoutPolicy](Remove-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Delete an activityBasedTimeoutPolicy object.

### [Remove-MgBetaPolicyAdminConsentRequestPolicy](Remove-MgBetaPolicyAdminConsentRequestPolicy.md)
Delete navigation property adminConsentRequestPolicy for policies

### [Remove-MgBetaPolicyAppManagementPolicy](Remove-MgBetaPolicyAppManagementPolicy.md)
Delete an appManagementPolicy object.

### [Remove-MgBetaPolicyAuthenticationFlowPolicy](Remove-MgBetaPolicyAuthenticationFlowPolicy.md)
Delete navigation property authenticationFlowsPolicy for policies

### [Remove-MgBetaPolicyAuthenticationMethodPolicy](Remove-MgBetaPolicyAuthenticationMethodPolicy.md)
Delete navigation property authenticationMethodsPolicy for policies

### [Remove-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Remove-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Delete navigation property authenticationMethodConfigurations for policies

### [Remove-MgBetaPolicyAuthenticationStrengthPolicy](Remove-MgBetaPolicyAuthenticationStrengthPolicy.md)
Delete a custom authenticationStrengthPolicy object.

### [Remove-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Remove-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Delete an authenticationCombinationConfiguration  for a custom authenticationStrengthPolicy object.

### [Remove-MgBetaPolicyAuthorizationPolicy](Remove-MgBetaPolicyAuthorizationPolicy.md)
Delete navigation property authorizationPolicy for policies

### [Remove-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Remove-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Delete navigation property defaultUserRoleOverrides for policies

### [Remove-MgBetaPolicyB2CAuthenticationMethodPolicy](Remove-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Delete navigation property b2cAuthenticationMethodsPolicy for policies

### [Remove-MgBetaPolicyClaimMappingPolicy](Remove-MgBetaPolicyClaimMappingPolicy.md)
Delete a claimsMappingPolicy object.

### [Remove-MgBetaPolicyCrossTenantAccessPolicy](Remove-MgBetaPolicyCrossTenantAccessPolicy.md)
Delete navigation property crossTenantAccessPolicy for policies

### [Remove-MgBetaPolicyCrossTenantAccessPolicyDefault](Remove-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Delete navigation property default for policies

### [Remove-MgBetaPolicyCrossTenantAccessPolicyPartner](Remove-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Delete a partner-specific configuration in a cross-tenant access policy.
If a configuration includes a user synchronization policy, you must first delete the user synchronization policy before you can delete the partner-specific configuration.

### [Remove-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization](Remove-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization.md)
Delete the user synchronization policy for a partner-specific configuration.

### [Remove-MgBetaPolicyDefaultAppManagementPolicy](Remove-MgBetaPolicyDefaultAppManagementPolicy.md)
Delete navigation property defaultAppManagementPolicy for policies

### [Remove-MgBetaPolicyDirectoryRoleAccessReviewPolicy](Remove-MgBetaPolicyDirectoryRoleAccessReviewPolicy.md)
Delete navigation property directoryRoleAccessReviewPolicy for policies

### [Remove-MgBetaPolicyExternalIdentityPolicy](Remove-MgBetaPolicyExternalIdentityPolicy.md)
Delete navigation property externalIdentitiesPolicy for policies

### [Remove-MgBetaPolicyFeatureRolloutPolicy](Remove-MgBetaPolicyFeatureRolloutPolicy.md)
Delete a featureRolloutPolicy object.

### [Remove-MgBetaPolicyFeatureRolloutPolicyApplyToByRef](Remove-MgBetaPolicyFeatureRolloutPolicyApplyToByRef.md)
Remove an appliesTo on a featureRolloutPolicy object to remove the directoryObject from feature rollout.

### [Remove-MgBetaPolicyFederatedTokenValidationPolicy](Remove-MgBetaPolicyFederatedTokenValidationPolicy.md)
Delete navigation property federatedTokenValidationPolicy for policies

### [Remove-MgBetaPolicyHomeRealmDiscoveryPolicy](Remove-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Delete a homeRealmDiscoveryPolicy object.

### [Remove-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Delete navigation property identitySecurityDefaultsEnforcementPolicy for policies

### [Remove-MgBetaPolicyMobileAppManagementPolicy](Remove-MgBetaPolicyMobileAppManagementPolicy.md)
Delete a mobilityManagementPolicy object.

### [Remove-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef](Remove-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef.md)
Delete a group from the list of groups included in a mobile app management policy.

### [Remove-MgBetaPolicyMobileDeviceManagementPolicy](Remove-MgBetaPolicyMobileDeviceManagementPolicy.md)
Delete a mobilityManagementPolicy object.

### [Remove-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef](Remove-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef.md)
Delete a group from the list of groups included in a mobile app management policy.

### [Remove-MgBetaPolicyPermissionGrantPolicy](Remove-MgBetaPolicyPermissionGrantPolicy.md)
Delete a permissionGrantPolicy object.

### [Remove-MgBetaPolicyPermissionGrantPolicyExclude](Remove-MgBetaPolicyPermissionGrantPolicyExclude.md)
Deletes a permissionGrantConditionSet from the excludes collection of a permissionGrantPolicy.

### [Remove-MgBetaPolicyPermissionGrantPolicyInclude](Remove-MgBetaPolicyPermissionGrantPolicyInclude.md)
Deletes a permissionGrantConditionSet from the includes collection of a permissionGrantPolicy.

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
Delete a tokenIssuancePolicy object.

### [Remove-MgBetaPolicyTokenLifetimePolicy](Remove-MgBetaPolicyTokenLifetimePolicy.md)
Delete a tokenLifetimePolicy object.

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

### [Remove-MgBetaTenantRelationshipMultiTenantOrganization](Remove-MgBetaTenantRelationshipMultiTenantOrganization.md)
Delete navigation property multiTenantOrganization for tenantRelationships

### [Remove-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest](Remove-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest.md)
Delete navigation property joinRequest for tenantRelationships

### [Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant](Remove-MgBetaTenantRelationshipMultiTenantOrganizationTenant.md)
Remove a tenant from a multi-tenant organization.
A tenant can be removed in the following scenarios: To allow for asynchronous processing, you must wait for up to 2 hours before removal of a tenant is completed.

### [Remove-MgBetaTrustFrameworkKeySet](Remove-MgBetaTrustFrameworkKeySet.md)
Delete a trustFrameworkKeySet.

### [Remove-MgBetaTrustFrameworkPolicy](Remove-MgBetaTrustFrameworkPolicy.md)
Delete an existing trustFrameworkPolicy.

### [Remove-MgBetaUserAuthenticationEmailMethod](Remove-MgBetaUserAuthenticationEmailMethod.md)
Deletes a user's email Authentication Method object.

### [Remove-MgBetaUserAuthenticationFido2Method](Remove-MgBetaUserAuthenticationFido2Method.md)
Deletes a user's FIDO2 Security Key Authentication Method object.

### [Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgBetaUserAuthenticationMicrosoftAuthenticatorMethod.md)
Deletes a microsoftAuthenticatorAuthenticationMethod object.

### [Remove-MgBetaUserAuthenticationOperation](Remove-MgBetaUserAuthenticationOperation.md)
Delete navigation property operations for users

### [Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod](Remove-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod.md)
Deletes a user's Microsoft Authenticator Passwordless Phone Sign-in method object.

### [Remove-MgBetaUserAuthenticationPhoneMethod](Remove-MgBetaUserAuthenticationPhoneMethod.md)
Delete a user's phone authentication method.
Remember that a user cannot have an alternateMobile number without a mobile number.
If you want to remove a mobile number from a user that also has an alternateMobile number, first update the mobile number to the new number, then delete the alternateMobile number.
If the phone number is the user's default Azure multi-factor authentication (MFA) authentication method, it cannot be deleted.
Have the user change their default authentication method, and then delete the number.

### [Remove-MgBetaUserAuthenticationSoftwareOathMethod](Remove-MgBetaUserAuthenticationSoftwareOathMethod.md)
Delete a user's Software OATH token authentication method object.

### [Remove-MgBetaUserAuthenticationTemporaryAccessPassMethod](Remove-MgBetaUserAuthenticationTemporaryAccessPassMethod.md)
Delete a users's temporaryAccessPassAuthenticationMethod object.

### [Remove-MgBetaUserAuthenticationWindowsHelloForBusinessMethod](Remove-MgBetaUserAuthenticationWindowsHelloForBusinessMethod.md)
Deletes a windowsHelloForBusinessAuthenticationMethod object.

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

### [Set-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef](Set-MgBetaIdentityB2XUserFlowPostAttributeCollectionByRef.md)
Update the ref of navigation property postAttributeCollection in identity

### [Set-MgBetaIdentityB2XUserFlowPostFederationSignupByRef](Set-MgBetaIdentityB2XUserFlowPostFederationSignupByRef.md)
Update the ref of navigation property postFederationSignup in identity

### [Set-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder](Set-MgBetaIdentityB2XUserFlowUserAttributeAssignmentOrder.md)
Set the order of identityUserFlowAttributeAssignments being collected within a user flow.

### [Set-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization](Set-MgBetaPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization.md)
Update the navigation property identitySynchronization in policies

### [Set-MgBetaTrustFrameworkPolicyContent](Set-MgBetaTrustFrameworkPolicyContent.md)
Update media content for the navigation property policies in trustFramework

### [Test-MgBetaIdentityCustomAuthenticationExtensionAuthenticationConfiguration](Test-MgBetaIdentityCustomAuthenticationExtensionAuthenticationConfiguration.md)
An API to check validity of the endpoint and and authentication configuration for a customAuthenticationExtension.

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
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
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
Update the properties of an identityApiConnector object.

### [Update-MgBetaIdentityAuthenticationEventFlow](Update-MgBetaIdentityAuthenticationEventFlow.md)
Update the properties of an authenticationEventsFlow object.
Only the externalUsersSelfServiceSignupEventsFlow object type is supported.

### [Update-MgBetaIdentityAuthenticationEventListener](Update-MgBetaIdentityAuthenticationEventListener.md)
Update the properties of an authenticationEventListener object.
You must specify the @odata.type property and the value of the authenticationEventListener object type to update.

### [Update-MgBetaIdentityB2CUserFlow](Update-MgBetaIdentityB2CUserFlow.md)
Update the properties of a b2cIdentityUserFlow object.

### [Update-MgBetaIdentityB2CUserFlowLanguage](Update-MgBetaIdentityB2CUserFlowLanguage.md)
This method is used to create or update a custom language in an Azure AD B2C user flow.
Note: You must enable language customization in the Azure AD B2C user flow before you can create a custom language.
For more information, see Update b2cIdentityUserFlow.

### [Update-MgBetaIdentityB2CUserFlowLanguageDefaultPage](Update-MgBetaIdentityB2CUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgBetaIdentityB2CUserFlowLanguageOverridePage](Update-MgBetaIdentityB2CUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgBetaIdentityB2CUserFlowUserAttributeAssignment](Update-MgBetaIdentityB2CUserFlowUserAttributeAssignment.md)
Update the properties of a identityUserFlowAttributeAssignment object.

### [Update-MgBetaIdentityB2XUserFlow](Update-MgBetaIdentityB2XUserFlow.md)
Update the navigation property b2xUserFlows in identity

### [Update-MgBetaIdentityB2XUserFlowLanguage](Update-MgBetaIdentityB2XUserFlowLanguage.md)
Update the navigation property languages in identity

### [Update-MgBetaIdentityB2XUserFlowLanguageDefaultPage](Update-MgBetaIdentityB2XUserFlowLanguageDefaultPage.md)
Update the navigation property defaultPages in identity

### [Update-MgBetaIdentityB2XUserFlowLanguageOverridePage](Update-MgBetaIdentityB2XUserFlowLanguageOverridePage.md)
Update the navigation property overridesPages in identity

### [Update-MgBetaIdentityB2XUserFlowPostAttributeCollection](Update-MgBetaIdentityB2XUserFlowPostAttributeCollection.md)
Update the navigation property postAttributeCollection in identity

### [Update-MgBetaIdentityB2XUserFlowPostFederationSignup](Update-MgBetaIdentityB2XUserFlowPostFederationSignup.md)
Update the navigation property postFederationSignup in identity

### [Update-MgBetaIdentityB2XUserFlowPreTokenIssuance](Update-MgBetaIdentityB2XUserFlowPreTokenIssuance.md)
Update the navigation property preTokenIssuance in identity

### [Update-MgBetaIdentityB2XUserFlowUserAttributeAssignment](Update-MgBetaIdentityB2XUserFlowUserAttributeAssignment.md)
Update the navigation property userAttributeAssignments in identity

### [Update-MgBetaIdentityConditionalAccess](Update-MgBetaIdentityConditionalAccess.md)
Update the navigation property conditionalAccess in identity

### [Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference](Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference.md)
Update the properties of an authenticationContextClassReference object.

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
Update the properties of an authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be updated as they are the only type of authenticationCombinationConfiguration that may be created.

### [Update-MgBetaIdentityConditionalAccessNamedLocation](Update-MgBetaIdentityConditionalAccessNamedLocation.md)
Update the properties of a countryNamedLocation object.

### [Update-MgBetaIdentityConditionalAccessPolicy](Update-MgBetaIdentityConditionalAccessPolicy.md)
Update the properties of a conditionalAccessPolicy object.

### [Update-MgBetaIdentityContinuouAccessEvaluationPolicy](Update-MgBetaIdentityContinuouAccessEvaluationPolicy.md)
Update the properties of a continuousAccessEvaluationPolicy object.

### [Update-MgBetaIdentityCustomAuthenticationExtension](Update-MgBetaIdentityCustomAuthenticationExtension.md)
Update the navigation property customAuthenticationExtensions in identity

### [Update-MgBetaIdentityProvider](Update-MgBetaIdentityProvider.md)
Update the properties of the specified identity provider configured in the tenant.
Among the types of providers derived from identityProviderBase, you can currently update a socialIdentityProvider resource in Azure AD.
In Azure AD B2C, this operation can currently update a socialIdentityProvider, openIdConnectIdentityProvider, or an appleManagedIdentityProvider resource.

### [Update-MgBetaIdentityUserFlow](Update-MgBetaIdentityUserFlow.md)
Update the navigation property userFlows in identity

### [Update-MgBetaIdentityUserFlowAttribute](Update-MgBetaIdentityUserFlowAttribute.md)
Update the properties of a identityUserFlowAttribute object.
Only custom user flow attributes can be updated.

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

### [Update-MgBetaInvitation](Update-MgBetaInvitation.md)
Update entity in invitations

### [Update-MgBetaInvitationInvitedUserMailboxSetting](Update-MgBetaInvitationInvitedUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaOauth2PermissionGrant](Update-MgBetaOauth2PermissionGrant.md)
Update the properties of oAuth2PermissionGrant object, representing a delegated permission grant.
An oAuth2PermissionGrant can be updated to change which delegated permissions are granted, by adding or removing items from the list in scopes.

### [Update-MgBetaPolicyAccessReviewPolicy](Update-MgBetaPolicyAccessReviewPolicy.md)
Update the properties of an accessReviewPolicy object.

### [Update-MgBetaPolicyActivityBasedTimeoutPolicy](Update-MgBetaPolicyActivityBasedTimeoutPolicy.md)
Update the properties of an activityBasedTimeoutPolicy object.

### [Update-MgBetaPolicyAdminConsentRequestPolicy](Update-MgBetaPolicyAdminConsentRequestPolicy.md)
Update the properties of an adminConsentRequestPolicy object.

### [Update-MgBetaPolicyAppManagementPolicy](Update-MgBetaPolicyAppManagementPolicy.md)
Update an appManagementPolicy object.

### [Update-MgBetaPolicyAuthenticationFlowPolicy](Update-MgBetaPolicyAuthenticationFlowPolicy.md)
Update the Boolean selfServiceSignUp property of an authenticationFlowsPolicy object.
The properties id, type, and description cannot be modified.

### [Update-MgBetaPolicyAuthenticationMethodPolicy](Update-MgBetaPolicyAuthenticationMethodPolicy.md)
Update the properties of an authenticationMethodsPolicy object.

### [Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration](Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration.md)
Update the navigation property authenticationMethodConfigurations in policies

### [Update-MgBetaPolicyAuthenticationStrengthPolicy](Update-MgBetaPolicyAuthenticationStrengthPolicy.md)
Update the properties of an authenticationStrengthPolicy object.
You cannot update the allowed auth method combinations using this request.
To do so, use the Update allowed combinations action.

### [Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination](Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination.md)
Update the allowedCombinations property of an authenticationStrengthPolicy object.
To update other properties of an authenticationStrengthPolicy object, use the Update authenticationStrengthPolicy method.

### [Update-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration](Update-MgBetaPolicyAuthenticationStrengthPolicyCombinationConfiguration.md)
Update the properties of an authenticationCombinationConfiguration object.
In use, only fido2combinationConfigurations may be updated as they are the only type of authenticationCombinationConfiguration that may be created.

### [Update-MgBetaPolicyAuthorizationPolicy](Update-MgBetaPolicyAuthorizationPolicy.md)
Update the navigation property authorizationPolicy in policies

### [Update-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride](Update-MgBetaPolicyAuthorizationPolicyDefaultUserRoleOverride.md)
Update the navigation property defaultUserRoleOverrides in policies

### [Update-MgBetaPolicyB2CAuthenticationMethodPolicy](Update-MgBetaPolicyB2CAuthenticationMethodPolicy.md)
Update the properties of a b2cAuthenticationMethodsPolicy object.

### [Update-MgBetaPolicyClaimMappingPolicy](Update-MgBetaPolicyClaimMappingPolicy.md)
Update the properties of a claimsMappingPolicy object.

### [Update-MgBetaPolicyCrossTenantAccessPolicy](Update-MgBetaPolicyCrossTenantAccessPolicy.md)
Update the properties of a cross-tenant access policy.

### [Update-MgBetaPolicyCrossTenantAccessPolicyDefault](Update-MgBetaPolicyCrossTenantAccessPolicyDefault.md)
Update the default configuration of a cross-tenant access policy.

### [Update-MgBetaPolicyCrossTenantAccessPolicyPartner](Update-MgBetaPolicyCrossTenantAccessPolicyPartner.md)
Update the properties of a partner-specific configuration.

### [Update-MgBetaPolicyDefaultAppManagementPolicy](Update-MgBetaPolicyDefaultAppManagementPolicy.md)
Update the properties of a tenantAppManagementPolicy object.

### [Update-MgBetaPolicyDeviceRegistrationPolicy](Update-MgBetaPolicyDeviceRegistrationPolicy.md)
Update the properties of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

### [Update-MgBetaPolicyDirectoryRoleAccessReviewPolicy](Update-MgBetaPolicyDirectoryRoleAccessReviewPolicy.md)
Update the navigation property directoryRoleAccessReviewPolicy in policies

### [Update-MgBetaPolicyExternalIdentityPolicy](Update-MgBetaPolicyExternalIdentityPolicy.md)
Update the settings of the tenant-wide externalIdentitiesPolicy object that controls whether external users can leave an Azure AD tenant via self-service controls.

### [Update-MgBetaPolicyFeatureRolloutPolicy](Update-MgBetaPolicyFeatureRolloutPolicy.md)
Update the properties of featureRolloutPolicy object.

### [Update-MgBetaPolicyFederatedTokenValidationPolicy](Update-MgBetaPolicyFederatedTokenValidationPolicy.md)
Update the navigation property federatedTokenValidationPolicy in policies

### [Update-MgBetaPolicyHomeRealmDiscoveryPolicy](Update-MgBetaPolicyHomeRealmDiscoveryPolicy.md)
Update the properties of a homeRealmDiscoveryPolicy object.

### [Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgBetaPolicyIdentitySecurityDefaultEnforcementPolicy.md)
Update the properties of an identitySecurityDefaultsEnforcementPolicy object.

### [Update-MgBetaPolicyMobileAppManagementPolicy](Update-MgBetaPolicyMobileAppManagementPolicy.md)
Update the properties of a mobilityManagementPolicy object.

### [Update-MgBetaPolicyMobileDeviceManagementPolicy](Update-MgBetaPolicyMobileDeviceManagementPolicy.md)
Update the properties of a mobilityManagementPolicy object.

### [Update-MgBetaPolicyPermissionGrantPolicy](Update-MgBetaPolicyPermissionGrantPolicy.md)
Update properties of a  permissionGrantPolicy.

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
Update a rule defined for a role management policy.
The rule can be one of the following types that are derived from the unifiedRoleManagementPolicyRule object:\n+ unifiedRoleManagementPolicyApprovalRule\n+ unifiedRoleManagementPolicyAuthenticationContextRule\n+ unifiedRoleManagementPolicyEnablementRule\n+ unifiedRoleManagementPolicyExpirationRule\n+ unifiedRoleManagementPolicyNotificationRule For more information about rules for Azure AD roles and examples of updating rules, see the following articles:\n+ Overview of rules for Azure AD roles in PIM APIs in Microsoft Graph\n+ Use PIM APIs in Microsoft Graph to update Azure AD rules

### [Update-MgBetaPolicyServicePrincipalCreationPolicy](Update-MgBetaPolicyServicePrincipalCreationPolicy.md)
Update the navigation property servicePrincipalCreationPolicies in policies

### [Update-MgBetaPolicyServicePrincipalCreationPolicyExclude](Update-MgBetaPolicyServicePrincipalCreationPolicyExclude.md)
Update the navigation property excludes in policies

### [Update-MgBetaPolicyServicePrincipalCreationPolicyInclude](Update-MgBetaPolicyServicePrincipalCreationPolicyInclude.md)
Update the navigation property includes in policies

### [Update-MgBetaPolicyTokenIssuancePolicy](Update-MgBetaPolicyTokenIssuancePolicy.md)
Update the properties of a tokenIssuancePolicy object.

### [Update-MgBetaPolicyTokenLifetimePolicy](Update-MgBetaPolicyTokenLifetimePolicy.md)
Update the properties of a tokenLifetimePolicy object.

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

### [Update-MgBetaTenantRelationshipMultiTenantOrganization](Update-MgBetaTenantRelationshipMultiTenantOrganization.md)
Update the properties of a multi-tenant organization.

### [Update-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest](Update-MgBetaTenantRelationshipMultiTenantOrganizationJoinRequest.md)
Join a multi-tenant organization, after the owner of the multi-tenant organization has added your tenant to the multi-tenant organization as pending.
Before a tenant added to a multi-tenant organization can participate in the multi-tenant organization, the administrator of the joining tenant must submit a join request.
To allow for asynchronous processing, you must wait a minimum of 2 hours between creation and joining a multi-tenant organization.
Furthermore, to allow for asynchronous processing, you must wait up to 4 hours before joining a multi-tenant organization is completed.

### [Update-MgBetaTenantRelationshipMultiTenantOrganizationTenant](Update-MgBetaTenantRelationshipMultiTenantOrganizationTenant.md)
Update the navigation property tenants in tenantRelationships

### [Update-MgBetaTrustFramework](Update-MgBetaTrustFramework.md)
Update trustFramework

### [Update-MgBetaTrustFrameworkKeySet](Update-MgBetaTrustFrameworkKeySet.md)
Update the properties of a trustFrameworkKeyset.
This operation will replace the content of an existing keyset.
Specifying the ID in the request payload is optional.

### [Update-MgBetaTrustFrameworkPolicy](Update-MgBetaTrustFrameworkPolicy.md)
Update the navigation property policies in trustFramework

### [Update-MgBetaUserAuthenticationEmailMethod](Update-MgBetaUserAuthenticationEmailMethod.md)
Update a user's email address associated with an email Authentication Method object.

### [Update-MgBetaUserAuthenticationMethod](Update-MgBetaUserAuthenticationMethod.md)
Update the navigation property methods in users

### [Update-MgBetaUserAuthenticationOperation](Update-MgBetaUserAuthenticationOperation.md)
Update the navigation property operations in users

### [Update-MgBetaUserAuthenticationPhoneMethod](Update-MgBetaUserAuthenticationPhoneMethod.md)
Update the phone number associated with a phone authentication method.
You can't change a phone's type.
To change a phone's type, add a new number of the desired type and then delete the object with the original type.
If a user is enabled by policy to use SMS to sign in and the mobile number is changed, the system will attempt to register the number for use in that system.

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

