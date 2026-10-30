# DeviceManagement.Functions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Functions v1.0 and/or beta modules.

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

### WrapperGenerator v3 directive audit

The shared YAML above contains only a placeholder, not a `directive:` collection.
There are no shared cmdlet suppressions, subject/verb renames, parameter
aliases/transforms, or schema/response directives to migrate or defer. The
placeholder and common AutoRest configuration remain unchanged.

`wrapper/DeviceManagement.Functions_directiveMigrationMap.json` deliberately has
an empty `mappings` array. The module's curated cmdlet configuration remains
empty: no operation mappings, suppressions, or redundant renames are invented
for this audit. Existing structural naming and derived parity/collision data
remain authoritative, including the v1.0
`Invoke-MgExperienceDeviceManagement` name for
`GET /deviceManagement/userExperienceAnalyticsSummarizeWorkFromAnywhereDevices()`.
The beta name for that route remains
`Get-MgDeviceManagementUserExperienceAnalyticsSummarizeWorkFromAnywhereDevices`.

Both compatible profiles are required; neither is excluded. The reviewed inputs
after normally integrating `powershell-v3` at `08e409a6aa` are:

| Profile | Compatible specification | Git blob | GET function operations |
| --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/DeviceManagement.Functions.yml` | `76896f6c6f954fbe1f1474a6dac925dc66b79e37` | 3 |
| beta | `openApiDocs_KiotaCompat/beta/DeviceManagement.Functions.yml` | `a27fdd5c9e3a5e09c2914e8c07ba48732e89f5da` | 13 |

`DeviceManagementFunctionsDirectiveMigrationTests` reads those actual compatible
specifications and pins their exact GET paths, operation IDs, function markers,
and unchanged naming/suppression decisions with derived data both enabled and
disabled. Generation, naming, and suppression calls pass the oracle profile
separately from the shared `GeneratorConfig` run settings. In particular, route
identity distinguishes the beta parameterless
`/deviceManagement/getEffectivePermissions()` operation from its scoped overload
`/deviceManagement/getEffectivePermissions(scope='{scope}')`
even though both now have the aligned operation ID
`deviceManagement_getEffectivePermission`. The v1.0 scoped overload has the same
aligned ID. No original shared selector needs a legacy-ID bridge. Neighboring enrollment,
role-scope, and analytics functions are covered without adding overrides.

These operation counts and naming assertions are not claims that every response
shape compiles or exports successfully. Full fresh Kiota/client and wrapper
Release builds and nonzero exported cmdlets remain separate gates for each
profile. Preserve the committed `wrapper/Beta` output casing.

All profile-local readmes and `src/readme.graph.md` are outside this audit and
are not read, migrated, annotated, or edited. The required common include above
does not expand this scope. Any parameter aliases/transforms or schema/response
customizations outside this shared file remain deferred and unimplemented.
