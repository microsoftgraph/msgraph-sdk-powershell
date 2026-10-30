# DeviceManagement.Enrollment

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Enrollment v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The wrapper migration covers only the three shared cmdlet directives below for
v1.0 and beta. Profile-local readmes and `src/readme.graph.md` are not migrated.
Parameter aliases/transforms and schema/response directives remain deferred; none
are present in this shared file. Reviewed evidence lives in
`wrapper/DeviceManagement.Enrollment_directiveMigrationMap.json`, with behavior
pinned by `DeviceManagementEnrollmentDirectiveMigrationTests`.

Current compatible spec Git blobs: v1.0 `e9cde3860c4d6be4cc2aa2ddb02830f0865a3edd`;
beta `7ca6c5e3f4dacfff0a7b1c26fae09d011befed94`. The original
same-profile source blobs are v1.0 `de23b3a431fe51f0f0c272fe8d1d18ebbae84af2`
and beta `78729506beadbdcd85c40eeb61e3ed4b65b11c0e`. Current literal
selector matches are zero and eight, respectively; the reviewed beta bridge must
still cover all eleven original operations, including the three actual functions.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration: evaluate the original selector against each actual legacy
# spec (v1.0: zero matches; beta: eleven). Exact compatible successors are five
# analytics CRUD operations, three inherited assignedPrincipals functions, and
# three inherited counts. Only the functions lose the final microsoft.graph.
# qualifier. Suppress these exact routes, not all inheritsPermissionsFrom CRUD.
# Keep this AutoRest directive active until the service-module pipeline retires.
  - remove-path-by-operation: ^(deviceManagement_.*UserExperienceAnalytic.*|roleManagement\..*\.roleDefinition\.inheritsPermissionsFrom.*)$
# Remove cmdlets.
# Wrapper migration: suppress PATCH on the windowsAutopilotDeviceIdentities item
# in both profiles. Existing v1.0 derived suppression is preserved; the curated
# entry also covers beta and generation without derived data. Retain other CRUD
# and updateDeviceProperties. Keep the original directive active.
  - where:
      verb: Update
      subject: ^DeviceManagementWindowAutopilotDeviceIdentity$
    remove: true
# Wrapper migration: suppress only GET analytics /$count in beta; this route is
# absent in v1.0 and is not selected by the operation-ID regex above. Keep this
# original directive active.
  - where:
      verb: Get
      subject: ^DeviceManagementUserExperienceAnalyticNotAutopilotReadyDeviceCount$
    remove: true
```
