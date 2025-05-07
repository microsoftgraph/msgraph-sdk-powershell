# Identity.SignIns

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Identity.SignIns v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0. The affected operation Ids starts from identity.b2xUserFlow_DeleteUserFlowIdentityProviderGraphBPreRef
  - remove-path-by-operation: ^identity_(Get|Create|Delete|Update|List)ConditionalAcces$|^policy\.policyRoot_.*PolicyRoot|^policy_(Get|Create|Delete|Update|List)ConditionalAccessPolicy$|^invitation\.invitation_(List|Get|Update|Delete)Invitation$|^invitation_(.*)InvitedUser$|^identityProtection\.identityProtectionRoot_(.*)$|^identity\.identityContainer_(.*)$|^identityProvider(\.identityProvider.*|_.*)$|^identity.b2xUserFlow_DeleteUserFlowIdentityProviderGraphBPreRef$|^policy.featureRolloutPolicy_DeleteAppliesToGraphBPreRef$|^user.authentication.qrCodePinMethod.pin_updatePin$
# Remove cmdlets
  - where:
      subject: ^(Oauth2PermissionGrant)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(DataPolicyOperation)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(.*)(IdentityProtection)(.*)$
    set:
      subject: $1$3
# Remove cmdlets
  - where:
      subject: ^UserAuthentication$
    remove: true
  - where:
      subject: ^InformationProtectionSensitivity(Label|LabelSublabel)$
    remove: true
  - where:
      verb: New|Update
      subject: ^UserAuthenticationPasswordMethod$
    remove: true
  - where:
      subject: ^IdentityConditionalAccessAuthenticationStrength.*$
      variant: ^List$|Get$|GetViaIdentity$|Update$|UpdateExpanded$|UpdateViaIdentity$|UpdateViaIdentityExpanded$|Create$|CreateExpanded$|Delete$|DeleteViaIdentity$|Usage$|UsageViaIdentity$|Find$|FindViaIdentity$
    remove: true
# Removes the response content since the Patch operation returns http status code 204
  - where-operation-id: "policy_UpdateClaimsMappingPolicy"
    remove: $.responses["2XX"].content
```
