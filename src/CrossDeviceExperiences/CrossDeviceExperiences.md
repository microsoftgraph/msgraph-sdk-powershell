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
# Wrapper migration: reviewed expected absence in BOTH v1.0 and beta compatible
# specs; neither historical operation ID matches a current operation. No wrapper
# suppression is needed. In particular, the live beta users.devices.* reference
# operations are not replacements selected by this expression and remain available.
# Exact spec/search and unaffected-route evidence is recorded in
# wrapper/CrossDeviceExperiences_directiveMigrationMap.json and pinned by
# CrossDeviceExperiencesDirectiveMigrationTests. Keep this AutoRest directive active
# until the service-module pipeline is retired. Global/profile-local directives are
# excluded; parameter/schema migration remains deferred (none in this shared file).
  - remove-path-by-operation: ^user.device_DeleteRegisteredOwnerGraphBPreRef$|^user.device_DeleteRegisteredUserGraphBPreRef$
```
