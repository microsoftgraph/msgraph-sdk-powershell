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
at base `51d441eeb5` are:

| Profile | Compatible specification | Git blob | GET function operations |
| --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/DeviceManagement.Functions.yml` | `4757fe33921b075f3f89216793b85159afbc6c54` | 3 |
| beta | `openApiDocs_KiotaCompat/beta/DeviceManagement.Functions.yml` | `3130ee19ee1b97d1eed5f229c08ef01d904db071` | 13 |

`DeviceManagementFunctionsDirectiveMigrationTests` reads those actual compatible
specifications and pins their exact GET paths, operation IDs, function markers,
and unchanged naming/suppression decisions with derived data both enabled and
disabled. In particular, it distinguishes the beta parameterless
`/deviceManagement/getEffectivePermissions()` operation
(`deviceManagement.getEffectivePermissions-43d0`) from its scoped overload
`/deviceManagement/getEffectivePermissions(scope='{scope}')`
(`deviceManagement.getEffectivePermissions-a04a`). The v1.0 scoped overload has
operation ID `deviceManagement.getEffectivePermissions`. Neighboring enrollment,
role-scope, and analytics functions are covered without adding overrides.

These operation counts and naming assertions are not claims that every response
shape compiles or exports successfully. Full fresh Kiota/client and wrapper
Release builds and nonzero exported cmdlets remain separate gates for each
profile. Preserve the committed `wrapper/Beta` output casing.

All profile-local readmes and `src/readme.graph.md` are outside this audit and
are not read, migrated, annotated, or edited. The required common include above
does not expand this scope. Any parameter aliases/transforms or schema/response
customizations outside this shared file remain deferred and unimplemented.
