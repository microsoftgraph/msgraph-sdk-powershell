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
`openApiDocs_KiotaCompat` specifications: six operations in v1.0 and seven in beta.
Neither profile is excluded. The absence of `getVapidPublicKey()` in v1.0 is an
operation-level difference, not an unsupported profile.

`ChangeNotifications_cmdletConfigurations.cs` intentionally remains empty.
Structural naming supplies subscription CRUD names and the action/function
names. Existing v1.0 parity data renames the structural
`Invoke-MgSubscriptionReauthorize` to `Invoke-MgReauthorizeSubscription`; beta
currently retains the structural name. Beta's structural
`Get-MgSubscriptionGetVapidPublicKey` also differs from the legacy published noun
`Get-MgBetaSubscriptionVapidPublicKey`. These baseline naming differences are not
shared directives and do not justify new overrides in this audit.

`tools/WrapperGenerator.Tests/ChangeNotificationsDirectiveMigrationTests.cs`
checks the empty audit and pins every compatible operation's identity,
classification, unsuppressed status, structural name, and data-aware name in both
profiles. Full generation/build evidence is a separate gate; existing tracked
output directories are `wrapper/v1.0` and `wrapper/Beta`.
