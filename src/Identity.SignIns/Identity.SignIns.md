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

The shared cmdlet directives below are reviewed in
`wrapper/Identity.SignIns_directiveMigrationMap.json` against the actual legacy
and Kiota-compatible v1.0 and beta specifications. The adjacent
`Identity.SignIns_cmdletConfigurations.cs` supplies only missing cmdlet-surface
behavior; structural naming and existing derived resolutions remain authoritative.
`IdentitySignInsDirectiveMigrationTests` covers affected operations and neighbors.
All original directives remain active. Profile-local readmes and
`src/readme.graph.md` are excluded from this migration.

The response-content removal (directive 10) remains **DeferredSchema** and is
unchanged. Parameter aliases and transforms remain deferred and unchanged; this
shared file contains no parameter directives.

Current compatible operation IDs are aligned with the legacy selectors. The ledger
uses literal current triples; source-backed tests independently account for the full
original sets, including the seven removed top-level provider operations per profile
and beta's final action namespace removal. No unmerged Legacy-helper schema is used.

The shared wrapper configuration also resolves five pre-existing beta generation
collisions without dropping endpoints: item reference deletions include their exact
referenced entity type in the noun, while collection reference names remain unchanged.
The custom-extension action accepting endpoint/authentication configuration has a
distinct `Test-MgIdentityCustomAuthenticationExtensionEndpointAuthenticationConfiguration`
name from the bodyless existing-extension test. These are ordinary distinct commands,
not grouped variants or a migration of excluded profile-local directives. Existing
v1.0 derived suppressions and names remain authoritative. Required `@id` query
binding on collection reference deletions is a separately owned generator prerequisite,
not something this module config implements or bypasses.

``` yaml
directive:
# Wrapper migration 1: the original regex is evaluated against each actual legacy
# spec, then bridged to exact compatible operations. Seven deprecated top-level
# /identityProviders operations are absent in each compatible spec; the separately
# existing /identity/identityProviders routes are unaffected. Beta updatePin uses
# reviewed action-kind-guarded final namespace translation.
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0. The affected operation Ids starts from identity.b2xUserFlow_DeleteUserFlowIdentityProviderGraphBPreRef
  - remove-path-by-operation: ^identity_(Get|Create|Delete|Update|List)ConditionalAcces$|^policy\.policyRoot_.*PolicyRoot|^policy_(Get|Create|Delete|Update|List)ConditionalAccessPolicy$|^invitation\.invitation_(List|Get|Update|Delete)Invitation$|^invitation_(.*)InvitedUser$|^identityProtection\.identityProtectionRoot_(.*)$|^identity\.identityContainer_(.*)$|^identityProvider(\.identityProvider.*|_.*)$|^identity.b2xUserFlow_DeleteUserFlowIdentityProviderGraphBPreRef$|^policy.featureRolloutPolicy_DeleteAppliesToGraphBPreRef$|^user.authentication.qrCodePinMethod.pin_updatePin$
# Remove cmdlets
# Wrapper migration 2: structural path naming already collapses the repeated
# Oauth2PermissionGrant subject. No redundant noun override is needed.
  - where:
      subject: ^(Oauth2PermissionGrant)(\1)+
    set:
      subject: $1
# Wrapper migration 3: structural path naming already collapses the repeated
# DataPolicyOperation subject. No redundant noun override is needed.
  - where:
      subject: ^(DataPolicyOperation)(\1)+
    set:
      subject: $1
# Wrapper migration 4: strip IdentityProtection for descendant resource/action
# nouns; retain authoritative existing derived names and suppress only the root.
  - where:
      subject: ^(.*)(IdentityProtection)(.*)$
    set:
      subject: $1$3
# Remove cmdlets
# Wrapper migration 5: suppress only the /users/{id}/authentication singleton.
  - where:
      subject: ^UserAuthentication$
    remove: true
# Wrapper migration 6: suppress beta label/sublabel CRUD only; preserve counts,
# rights, functions, actions, and user-scoped information-protection routes.
  - where:
      subject: ^InformationProtectionSensitivity(Label|LabelSublabel)$
    remove: true
# Wrapper migration 7: suppress password-method creation. No password-method
# update operation exists in either compatible spec; GET/count remain available.
  - where:
      verb: New|Update
      subject: ^UserAuthenticationPasswordMethod$
    remove: true
# Wrapper migration 8: suppress the unnumbered singular authenticationStrength
# variants, not the legacy beta plural alias. Preserve combination-configuration
# POST (CreateViaIdentity variants remain) and the prefixed Usage subject.
  - where:
      subject: ^IdentityConditionalAccessAuthenticationStrength.*$
      variant: ^List$|Get$|GetViaIdentity$|Update$|UpdateExpanded$|UpdateViaIdentity$|UpdateViaIdentityExpanded$|Create$|CreateExpanded$|Delete$|DeleteViaIdentity$|Usage$|UsageViaIdentity$|Find$|FindViaIdentity$
    remove: true
# Wrapper migration 9: the numbered Update1 variants belong to the deprecated
# top-level /identityProviders item, already covered by directive 1 and the
# existing curated suppression. Keep nested /identity/identityProviders PATCH.
  - where:
      verb: Update
      subject: ^IdentityProvider$
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$
    remove: true
# Removes the response content since the Patch operation returns http status code 204
# Wrapper migration 10: DeferredSchema; retain this response directive unchanged.
  - where-operation-id: "policy_UpdateClaimsMappingPolicy"
    remove: $.responses["2XX"].content
```
