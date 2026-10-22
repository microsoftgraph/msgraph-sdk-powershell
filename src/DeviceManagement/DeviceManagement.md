# DeviceManagement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

Wrapper migration reviews only this shared file; profile-specific readmes and
`src/readme.graph.md` are excluded. Parameter aliases/transforms and schema/response
directives remain deferred (none occur in this shared file). Keep the AutoRest
directives active until the service-module pipeline is retired.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration: directive 1 selects zero actual legacy v1.0 operations and
# all 12 beta operations recorded in wrapper/DeviceManagement_directiveMigrationMap.json.
# Exact method/path suppressions in DeviceManagement_cmdletConfigurations.cs cover
# all successors; five final action namespaces are explicitly translated, not absent.
  - remove-path-by-operation: ^deviceManagement.(deviceManagementScript.userRunState.deviceRunState_.*|groupPolicyConfiguration.definitionValue.presentationValue_.*|deviceShellScript.userRunState.deviceRunState_.*|deviceConfiguration_assignedAccessMultiModeProfile|deviceConfiguration_windowsPrivacyAccessControl|microsoftTunnelSite.microsoftTunnelServer_createServerLogCollectionRequest|groupPolicyConfiguration_updateDefinitionValue|intent_updateSetting)$

# Remove cmdlets.
# Wrapper migration: directive 2 suppresses only POST logCollectionRequests (one
# v1.0 route, two beta routes). Existing derived v1.0 coverage is retained; the
# shared curated entries also cover beta and generation without derived data.
  - where:
      verb: New
      subject: ^DeviceManagement(Managed|Comanaged)DeviceLogCollectionRequest$
    remove: true
# Wrapper migration: directive 3 suppresses only beta PATCH /comanagedDevices/{id};
# no matching operation exists in the actual legacy or compatible v1.0 module.
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice$
    remove: true
# Wrapper migration: directive 4 is audited absent in both actual legacy and
# compatible module profiles. No scope-action path/operation or guessed suppression
# is introduced. DeviceManagement.Actions is not resurrected.
  - where:
      verb: Start
      subject: ^DeviceManagementUserExperienceAnalyticDeviceScopeAction$
    remove: true
```
