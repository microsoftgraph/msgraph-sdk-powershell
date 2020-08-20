
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
# # Rename cmdlets
#   - where:
#       verb: Get
#       subject: ^(PrivilegedRoleAssignment)$
#     set:
#       subject: Role$1
# # Rename cmdlets with duplicates in their name.
#   - where:
#       subject: ^(PrivilegedRoleAssignment)(\1)+
#     set:
#       subject: $1
#   - where:
#       subject: ^(PrivilegedRoleAssignmentRequest)(\1)+
#     set:
#       subject: $1
#   - where:
#       subject: ^(PrivilegedOperationEvent)(\1)+
#     set:
#       subject: $1
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
