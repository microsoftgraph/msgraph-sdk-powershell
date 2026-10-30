# PersonalContacts

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for PersonalContacts v1.0 and/or beta modules.

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

The shared file above contains no cmdlet suppression, subject/verb rename,
parameter alias/transform, or schema/response directives. The existing AutoRest
configuration remains unchanged. The reviewed
`wrapper/PersonalContacts_directiveMigrationMap.json` therefore has an empty
`mappings` array, and `PersonalContacts_cmdletConfigurations.cs` intentionally
remains empty: there are no shared selectors to map or overrides to invent.

Both required Kiota-compatible profiles were reviewed without using the legacy
`openApiDocs` fallback:

| Profile | Compatible spec Git blob | Paths | Operations |
| --- | --- | --- | --- |
| v1.0 | `d7a60e304e2116012e806bc33ef578ba2c9cda85` | 40 | 73 |
| beta | `ad65c527d83a7af23877005de6435d49e92b9662` | 40 | 73 |

The inputs are `openApiDocs_KiotaCompat/<profile>/PersonalContacts.yml`; neither
profile is excluded. `PersonalContactsDirectiveMigrationTests` reads these real
specifications, checks every operation remains unsuppressed with the existing
curated and derived configuration, and pins exact method/path/operation-ID and
naming evidence for contact CRUD and neighboring folder, nested-contact,
extension, count, and photo-content routes. No existing curated or derived
configuration is removed or replaced by this audit.

After integrating the natural-ID variant framework, the tests pass each profile
separately to naming and suppression, with derived data enabled and disabled.
Exact operation IDs reflect the target's aligned compatible specs. The existing
permanent-delete action names also guard against accidentally applying v1.0
derived naming to beta. No authored variant groups are needed for this empty
shared configuration.

All directives in `v1.0/readme.md`, `beta/readme.md`, and `src/readme.graph.md`
are explicitly outside this shared-file audit and remain untouched. Parameter
aliases/transforms and schema/response directives are deferred classes, not
implemented here; none occur in this shared file. This audit does not claim
profile-local directive parity or successful full generation/builds. Those are
separate gates, preserving the committed wrapper output casing `v1.0` and `Beta`.
