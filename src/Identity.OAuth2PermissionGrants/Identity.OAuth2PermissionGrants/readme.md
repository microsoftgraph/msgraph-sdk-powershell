<!-- region Generated -->
# Microsoft.Graph.Identity.OAuth2PermissionGrants
This directory contains the PowerShell module for the IdentityOAuth2PermissionGrants service.

---
## Status
[![Microsoft.Graph.Identity.OAuth2PermissionGrants](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.OAuth2PermissionGrants.svg?style=flat-square&label=Microsoft.Graph.Identity.OAuth2PermissionGrants "Microsoft.Graph.Identity.OAuth2PermissionGrants")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.OAuth2PermissionGrants/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.OAuth2PermissionGrants`, see [how-to.md](how-to.md).
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
      subject: ^(Oauth2PermissionGrant)(\1)+
    set:
      subject: $1
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
