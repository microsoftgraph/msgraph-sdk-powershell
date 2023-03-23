# Applications

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Applications v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths.
  - remove-path-by-operation: onPremisesPublishingProfile\.(connector\.memberOf_.*|connector_GetMemberOf|connectorGroup\.member_.*|connectorGroup_(Get|Create|Update|Delete)Member
  - where:
      verb: Test
      subject: (Application|ServicePrincipal)SynchronizationJobCredentials
      variant: Validate1|ValidateExpanded1|ValidateViaIdentity1|ValidateViaIdentityExpanded1
    remove: true
  - where:
      subject: (ServicePrincipal)FederatedIdentityCredential.*
    remove: true
# Singularize credentials.
  - where:
      subject: (.*)(FederatedIdentityCredential)s(.*)
    set:
      subject: $1$2$3
```
