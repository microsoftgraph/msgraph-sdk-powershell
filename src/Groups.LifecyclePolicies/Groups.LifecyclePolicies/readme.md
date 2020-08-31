<!-- region Generated -->
# Microsoft.Graph.Groups.LifecyclePolicies
This directory contains the PowerShell module for the GroupsLifecyclePolicies service.

---
## Status
[![Microsoft.Graph.Groups.LifecyclePolicies](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups.LifecyclePolicies.svg?style=flat-square&label=Microsoft.Graph.Groups.LifecyclePolicies "Microsoft.Graph.Groups.LifecyclePolicies")](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups.LifecyclePolicies/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Groups.LifecyclePolicies`, see [how-to.md](how-to.md).
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
      subject: ^(GroupLifecyclePolicy)(\1)+
    set:
      subject: $1
# Rename cmdlets
  - where:
      verb: Remove
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1From$2
  - where:
      verb: Add
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1To$2
  - where:
      verb: Invoke
      subject: ^(RenewGroup)(LifecyclePolicy)Group$
    set:
      subject: $1$2
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
