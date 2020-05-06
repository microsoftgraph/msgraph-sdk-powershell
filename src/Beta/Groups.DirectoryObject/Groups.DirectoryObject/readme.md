<!-- region Generated -->
# Microsoft.Graph.Groups.DirectoryObject
This directory contains the PowerShell module for the GroupsDirectoryObject service.

---
## Status
[![Microsoft.Graph.Groups.DirectoryObject](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups.DirectoryObject.svg?style=flat-square&label=Microsoft.Graph.Groups.DirectoryObject "Microsoft.Graph.Groups.DirectoryObject")](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups.DirectoryObject/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Groups.DirectoryObject`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
  - where:
      verb: Get
      subject: GroupMember
      variant: Get1
    set:
      subject: GroupMemberOf
  - where:
      verb: Get
      subject: GroupMember
      variant: List
    set:
      subject: GroupMemberOf
  - where:
      verb: Get
      subject: GroupMember
      variant: GetViaIdentity1
    set:
      subject: GroupMemberOf
  - where:
      verb: Get
      subject: GroupMember
      variant: Get
    set:
      subject: GroupMemberWithLicenseError
  - where:
      verb: Get
      subject: GroupMember
      variant: List2
    set:
      subject: GroupMemberWithLicenseError
  - where:
      verb: Get
      subject: GroupMember
      variant: GetViaIdentity
    set:
      subject: GroupMemberWithLicenseError
  - where:
      verb: Get
      subject: GroupTransitiveMember
      variant: List
    set:
      subject: GroupTransitiveMemberOf
  - where:
      verb: Get
      subject: GroupTransitiveMember
      variant: Get
    set:
      subject: GroupTransitiveMemberOf
  - where:
      verb: Get
      subject: GroupTransitiveMember
      variant: GetViaIdentity
    set:
      subject: GroupTransitiveMemberOf
```
### Versioning

``` yaml
module-version: 0.5.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
