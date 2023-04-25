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
  - where:
      verb: Test
      subject: (Application|ServicePrincipal)SynchronizationJobCredential
      variant: Validate1|ValidateExpanded1|ValidateViaIdentity1|ValidateViaIdentityExpanded1
    remove: true
  - where:
      subject: (ServicePrincipal)FederatedIdentityCredential.*
    remove: true
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(OnPremisePublishingProfile)(\1)+
    set:
      subject: $1
```
