
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
#  - remove-path-by-operation: auditLogs.auditLogRoot_.*|auditLogs_(Create|Update|Delete).*
# directive:
# # Rename cmdlets with duplicates in their name.
#   - where:
#       subject: ^(Oauth2PermissionGrant)(\1)+
#     set:
#       subject: $1
  # - where:
  #     subject: ^(DataPolicyOperation)(\1)+
  #   set:
  #     subject: $1
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
