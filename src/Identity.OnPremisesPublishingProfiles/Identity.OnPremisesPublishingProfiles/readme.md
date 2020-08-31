<!-- region Generated -->
# Microsoft.Graph.Identity.OnPremisesPublishingProfiles
This directory contains the PowerShell module for the IdentityOnPremisesPublishingProfiles service.

---
## Status
[![Microsoft.Graph.Identity.OnPremisesPublishingProfiles](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.OnPremisesPublishingProfiles.svg?style=flat-square&label=Microsoft.Graph.Identity.OnPremisesPublishingProfiles "Microsoft.Graph.Identity.OnPremisesPublishingProfiles")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.OnPremisesPublishingProfiles/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.OnPremisesPublishingProfiles`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''

```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(OnPremisPublishingProfile)(\1)+
    set:
      subject: $1
# Fix AutoREST OnPremis* typo.
  - where:
      subject: ^OnPremis(PublishingProfile.*)$
    set:
      subject: OnPremise$1
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
