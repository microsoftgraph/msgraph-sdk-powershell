---
Module Name: Microsoft.Graph.Identity.SignIns
Module Guid: 3a04e785-db4a-488f-a888-183e4ea3e8f8
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.SignIns Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.SignIns Cmdlets
### [Get-MgDataPolicyOperation](Get-MgDataPolicyOperation.md)
Get entity from dataPolicyOperations by key

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

### [Get-MgPolicyActivityBasedTimeoutPolicy](Get-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Get-MgPolicyAdminConsentRequestPolicy](Get-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Get-MgPolicyAuthenticationFlowPolicy](Get-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Get-MgPolicyAuthenticationMethodPolicy](Get-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Get-MgPolicyAuthorizationPolicy](Get-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Get-MgPolicyClaimMappingPolicy](Get-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Get-MgPolicyFeatureRolloutPolicy](Get-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Get-MgPolicyFeatureRolloutPolicyApplyTo](Get-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

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

### [Get-MgPolicyTokenIssuancePolicy](Get-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Get-MgPolicyTokenLifetimePolicy](Get-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

### [Get-MgUserAuthenticationFido2Method](Get-MgUserAuthenticationFido2Method.md)
Get fido2Methods from users

### [Get-MgUserAuthenticationMethod](Get-MgUserAuthenticationMethod.md)
Get methods from users

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethod](Get-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Get microsoftAuthenticatorMethods from users

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Get-MgUserAuthenticationWindowHello](Get-MgUserAuthenticationWindowHello.md)
Get windowsHelloForBusinessMethods from users

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Get-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Invoke-MgAvailableIdentityProviderType](Invoke-MgAvailableIdentityProviderType.md)
Invoke function availableProviderTypes

### [New-MgDataPolicyOperation](New-MgDataPolicyOperation.md)
Add new entity to dataPolicyOperations

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

### [New-MgInformationProtectionBitlockerRecoveryKey](New-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

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

### [New-MgPolicyClaimMappingPolicy](New-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [New-MgPolicyFeatureRolloutPolicy](New-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [New-MgPolicyFeatureRolloutPolicyApplyTo](New-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [New-MgPolicyHomeRealmDiscoveryPolicy](New-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [New-MgPolicyPermissionGrantPolicy](New-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [New-MgPolicyPermissionGrantPolicyExclude](New-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyPermissionGrantPolicyInclude](New-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [New-MgPolicyTokenIssuancePolicy](New-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [New-MgPolicyTokenLifetimePolicy](New-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

### [New-MgUserAuthenticationFido2Method](New-MgUserAuthenticationFido2Method.md)
Create new navigation property to fido2Methods for users

### [New-MgUserAuthenticationMethod](New-MgUserAuthenticationMethod.md)
Create new navigation property to methods for users

### [New-MgUserAuthenticationMicrosoftAuthenticatorMethod](New-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Create new navigation property to microsoftAuthenticatorMethods for users

### [New-MgUserAuthenticationWindowHello](New-MgUserAuthenticationWindowHello.md)
Create new navigation property to windowsHelloForBusinessMethods for users

### [Remove-MgDataPolicyOperation](Remove-MgDataPolicyOperation.md)
Delete entity from dataPolicyOperations

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

### [Remove-MgInformationProtectionBitlocker](Remove-MgInformationProtectionBitlocker.md)
Delete navigation property bitlocker for informationProtection

### [Remove-MgInformationProtectionBitlockerRecoveryKey](Remove-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Remove-MgInformationProtectionThreatAssessmentRequest](Remove-MgInformationProtectionThreatAssessmentRequest.md)
Delete navigation property threatAssessmentRequests for informationProtection

### [Remove-MgInformationProtectionThreatAssessmentRequestResult](Remove-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Remove-MgOauth2PermissionGrant](Remove-MgOauth2PermissionGrant.md)
Delete entity from oauth2PermissionGrants

### [Remove-MgPolicyActivityBasedTimeoutPolicy](Remove-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Remove-MgPolicyAdminConsentRequestPolicy](Remove-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Remove-MgPolicyAuthenticationFlowPolicy](Remove-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Remove-MgPolicyAuthenticationMethodPolicy](Remove-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Remove-MgPolicyAuthorizationPolicy](Remove-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Remove-MgPolicyClaimMappingPolicy](Remove-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Remove-MgPolicyFeatureRolloutPolicy](Remove-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Remove-MgPolicyFeatureRolloutPolicyApplyTo](Remove-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Remove-MgPolicyHomeRealmDiscoveryPolicy](Remove-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Remove-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Remove-MgPolicyPermissionGrantPolicy](Remove-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Remove-MgPolicyPermissionGrantPolicyExclude](Remove-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyPermissionGrantPolicyInclude](Remove-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Remove-MgPolicyTokenIssuancePolicy](Remove-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Remove-MgPolicyTokenLifetimePolicy](Remove-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

### [Remove-MgUserAuthenticationFido2Method](Remove-MgUserAuthenticationFido2Method.md)
Delete navigation property fido2Methods for users

### [Remove-MgUserAuthenticationMethod](Remove-MgUserAuthenticationMethod.md)
Delete navigation property methods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Delete navigation property microsoftAuthenticatorMethods for users

### [Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Remove-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Remove-MgUserAuthenticationWindowHello](Remove-MgUserAuthenticationWindowHello.md)
Delete navigation property windowsHelloForBusinessMethods for users

### [Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Remove-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

### [Update-MgDataPolicyOperation](Update-MgDataPolicyOperation.md)
Update entity in dataPolicyOperations

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

### [Update-MgInformationProtection](Update-MgInformationProtection.md)
Update informationProtection

### [Update-MgInformationProtectionBitlocker](Update-MgInformationProtectionBitlocker.md)
Update the navigation property bitlocker in informationProtection

### [Update-MgInformationProtectionBitlockerRecoveryKey](Update-MgInformationProtectionBitlockerRecoveryKey.md)
The recovery keys associated with the bitlocker entity.

### [Update-MgInformationProtectionThreatAssessmentRequest](Update-MgInformationProtectionThreatAssessmentRequest.md)
Update the navigation property threatAssessmentRequests in informationProtection

### [Update-MgInformationProtectionThreatAssessmentRequestResult](Update-MgInformationProtectionThreatAssessmentRequestResult.md)
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.

### [Update-MgOauth2PermissionGrant](Update-MgOauth2PermissionGrant.md)
Update entity in oauth2PermissionGrants

### [Update-MgPolicyActivityBasedTimeoutPolicy](Update-MgPolicyActivityBasedTimeoutPolicy.md)
The policy that controls the idle time out for web sessions for applications.

### [Update-MgPolicyAdminConsentRequestPolicy](Update-MgPolicyAdminConsentRequestPolicy.md)
The policy by which consent requests are created and managed for the entire tenant.

### [Update-MgPolicyAuthenticationFlowPolicy](Update-MgPolicyAuthenticationFlowPolicy.md)
The policy configuration of the self-service sign-up experience of external users.

### [Update-MgPolicyAuthenticationMethodPolicy](Update-MgPolicyAuthenticationMethodPolicy.md)
The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).

### [Update-MgPolicyAuthorizationPolicy](Update-MgPolicyAuthorizationPolicy.md)
The policy that controls Azure AD authorization settings.

### [Update-MgPolicyClaimMappingPolicy](Update-MgPolicyClaimMappingPolicy.md)
The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.

### [Update-MgPolicyFeatureRolloutPolicy](Update-MgPolicyFeatureRolloutPolicy.md)
The feature rollout policy associated with a directory object.

### [Update-MgPolicyFeatureRolloutPolicyApplyTo](Update-MgPolicyFeatureRolloutPolicyApplyTo.md)
Nullable.
Specifies a list of directoryObjects that feature is enabled for.

### [Update-MgPolicyHomeRealmDiscoveryPolicy](Update-MgPolicyHomeRealmDiscoveryPolicy.md)
The policy to control Azure AD authentication behavior for federated users.

### [Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy](Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy.md)
The policy that represents the security defaults that protect against common attacks.

### [Update-MgPolicyPermissionGrantPolicy](Update-MgPolicyPermissionGrantPolicy.md)
The policy that specifies the conditions under which consent can be granted.

### [Update-MgPolicyPermissionGrantPolicyExclude](Update-MgPolicyPermissionGrantPolicyExclude.md)
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyPermissionGrantPolicyInclude](Update-MgPolicyPermissionGrantPolicyInclude.md)
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.

### [Update-MgPolicyTokenIssuancePolicy](Update-MgPolicyTokenIssuancePolicy.md)
The policy that specifies the characteristics of SAML tokens issued by Azure AD.

### [Update-MgPolicyTokenLifetimePolicy](Update-MgPolicyTokenLifetimePolicy.md)
The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.

### [Update-MgUserAuthenticationFido2Method](Update-MgUserAuthenticationFido2Method.md)
Update the navigation property fido2Methods in users

### [Update-MgUserAuthenticationMethod](Update-MgUserAuthenticationMethod.md)
Update the navigation property methods in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethod](Update-MgUserAuthenticationMicrosoftAuthenticatorMethod.md)
Update the navigation property microsoftAuthenticatorMethods in users

### [Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice](Update-MgUserAuthenticationMicrosoftAuthenticatorMethodDevice.md)
The registered device on which Microsoft Authenticator resides.
This property is null if the device is not registered for passwordless Phone Sign-In.

### [Update-MgUserAuthenticationWindowHello](Update-MgUserAuthenticationWindowHello.md)
Update the navigation property windowsHelloForBusinessMethods in users

### [Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Update-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
The registered device on which this Windows Hello for Business key resides.
Supports $expand.
When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand.
For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.

