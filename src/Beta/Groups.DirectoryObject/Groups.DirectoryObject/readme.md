<!-- region Generated -->
# Mg.Groups.DirectoryObject
This directory contains the PowerShell module for the GroupsDirectoryObject service.

---
## Status
[![Mg.Groups.DirectoryObject](https://img.shields.io/powershellgallery/v/Mg.Groups.DirectoryObject.svg?style=flat-square&label=Mg.Groups.DirectoryObject "Mg.Groups.DirectoryObject")](https://www.powershellgallery.com/packages/Mg.Groups.DirectoryObject/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Mg.Groups.DirectoryObject`, see [how-to.md](how-to.md).
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
