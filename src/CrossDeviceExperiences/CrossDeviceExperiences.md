# CrossDeviceExperiences

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for CrossDeviceExperiences v1.0 and/or beta modules.

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
directive:
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0.
# Wrapper migration: the actual legacy v1.0 spec has no selector matches. In beta,
# both selected collection DELETE /registeredOwners/$ref and /registeredUsers/$ref
# survive conversion with renamed operation IDs. Exact method/path suppressions
# retain that source intent; item-reference DELETEs and collection GET/POST remain.
# Exact spec/search and unaffected-route evidence is recorded in
# wrapper/CrossDeviceExperiences_directiveMigrationMap.json and pinned by
# CrossDeviceExperiencesDirectiveMigrationTests. Keep this AutoRest directive active
# until the service-module pipeline is retired. Global/profile-local directives are
# excluded; parameter/schema migration remains deferred (none in this shared file).
  - remove-path-by-operation: ^user.device_DeleteRegisteredOwnerGraphBPreRef$|^user.device_DeleteRegisteredUserGraphBPreRef$
```
