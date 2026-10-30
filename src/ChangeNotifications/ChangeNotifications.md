# ChangeNotifications

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for ChangeNotifications v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!
```

### Wrapper migration audit

The shared file contains no cmdlet suppressions or renames and no parameter
aliases/transforms or schema/response directives to defer. The AutoRest require
and placeholder above remain unchanged. This audit excludes `src/readme.graph.md`
and both profile-local `readme.md` files; their directives are not migrated.

`wrapper/ChangeNotifications_directiveMigrationMap.json` therefore has an empty
`mappings` array, not invented directive-to-operation mappings. Its separate audit
records exact HTTP method/path/operation-ID evidence from both required
`openApiDocs_KiotaCompat` specifications: seven operations in each profile.
Neither profile is excluded. Revalidation against the merged #3849 target also
refreshes the aligned `subscription_*` operation IDs and spec hashes. The current
compatible v1.0 spec now includes `getVapidPublicKey()`, unlike the original
six-operation audit; that spec refresh is not a shared-directive change.

`ChangeNotifications_cmdletConfigurations.cs` intentionally remains empty.
Structural naming supplies subscription CRUD names and the action/function
names. Existing v1.0 parity data renames the structural
`Invoke-MgSubscriptionReauthorize` to `Invoke-MgReauthorizeSubscription`; beta
currently retains the structural name. Beta's structural
`Get-MgSubscriptionGetVapidPublicKey` also differs from the legacy beta published noun
`Get-MgBetaSubscriptionVapidPublicKey`. These baseline naming differences are not
shared directives and do not justify new overrides in this audit.

`tools/WrapperGenerator.Tests/ChangeNotificationsDirectiveMigrationTests.cs`
checks the empty audit and pins every compatible operation's identity,
classification, unsuppressed status, structural name, and data-aware name in both
profiles with derived data enabled and disabled. The profile is separate runtime
context on naming/suppression calls, not authored `GeneratorConfig` state.
Full generation/build evidence is a separate gate; existing tracked
output directories are `wrapper/v1.0` and `wrapper/Beta`.
