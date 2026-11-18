# Users

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The reviewed wrapper migration covers only this shared file, for both v1.0 and
beta; no profiles are excluded. Profile-local readmes (including their local
directive groups) and `src/readme.graph.md` are explicitly ignored and unchanged.
Parameter aliases/transforms and schema/response directives are deferred, not
implemented by this cmdlet-surface migration; none occur in this shared file.
Exact legacy-to-compatible evidence is recorded in
`wrapper/Users_directiveMigrationMap.json`, with regression coverage in
`tools/WrapperGenerator.Tests/UsersDirectiveMigrationTests.cs`.

``` yaml
directive:
# Remove invalid root paths e.g. users{id}/todo
# Wrapper migration, directive 1: the ORIGINAL case-sensitive regex selects only
# root todo GET/PATCH/DELETE in each legacy profile. All three survive with
# aligned compatible IDs and exact method/path module suppressions.
# It does not select user_GetOutlook or any nested todo/lists operation.
  - remove-path-by-operation: user_(Get|Create|Update|Delete|Set)(Todo|outlook)
# Remove commands
# Wrapper migration, directive 2: suppress POST .../licenseDetails only. The
# curated entry preserves existing v1.0 derived behavior and also covers beta.
  - where:
      verb: New
      subject: ^UserLicenseDetail$
    remove: true
# Wrapper migration, directive 3: subsumed by directive 1's earlier root-path
# removal. The actual legacy todo GET returns a singleton, not a List response.
# Record the surviving GET as lineage, not API absence; add no redundant rename.
  - where:
      verb: Get
      subject: ^(UserTodo)$
      variant: List
    set:
      subject: $1List
# Wrapper migration, directive 4: suppress PATCH .../photo only, retaining the
# existing curated /photos behavior and all unaffected photo/content neighbors.
  - where:
      verb: Update
      subject: ^UserPhoto$
    remove: true
# Keep these original directives active until the AutoRest pipeline is retired.
```
