
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
# Needs validation
# directive:
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: Get1
#     set:
#       subject: GroupMemberOf
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: List
#     set:
#       subject: GroupMemberOf
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: GetViaIdentity1
#     set:
#       subject: GroupMemberOf
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: Get
#     set:
#       subject: GroupMemberWithLicenseError
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: List2
#     set:
#       subject: GroupMemberWithLicenseError
#   - where:
#       verb: Get
#       subject: GroupMember
#       variant: GetViaIdentity
#     set:
#       subject: GroupMemberWithLicenseError
#   - where:
#       verb: Get
#       subject: GroupTransitiveMember
#       variant: List
#     set:
#       subject: GroupTransitiveMemberOf
#   - where:
#       verb: Get
#       subject: GroupTransitiveMember
#       variant: Get
#     set:
#       subject: GroupTransitiveMemberOf
#   - where:
#       verb: Get
#       subject: GroupTransitiveMember
#       variant: GetViaIdentity
#     set:
#       subject: GroupTransitiveMemberOf
# # Rename cmdlets with duplicates in their name.
#   - where:
#       subject: ^(GroupLifecyclePolicy)(\1)+
#     set:
#       subject: $1
# # Rename cmdlets
#   - where:
#       verb: Remove
#       subject: ^(Group)(LifecyclePolicy)Group$
#     set:
#       subject: $1From$2
#   - where:
#       verb: Add
#       subject: ^(Group)(LifecyclePolicy)Group$
#     set:
#       subject: $1To$2
#   - where:
#       verb: Invoke
#       subject: ^(RenewGroup)(LifecyclePolicy)Group$
#     set:
#       subject: $1$2

```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
