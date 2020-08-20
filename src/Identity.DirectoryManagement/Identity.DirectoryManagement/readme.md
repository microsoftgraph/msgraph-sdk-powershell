
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
# # directive:
# # Rename cmdlets
#   - where:
#       verb: Get
#       subject: (^AdministrativeUnit$)
#       variant: Get1|GetExpanded
#     set:
#       verb: Get
#       subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^Contact$)
  #     variant: Get|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get|New|Remove|Update
  #     subject: (^Contact)(OrgContact$)
  #   set:
  #     subject: $1
  # - where:
  #     verb: Get
  #     subject: (^Device$)
  #     variant: Get1|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^DirectoryRole$)
  #     variant: Get1|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^DirectoryRoleTemplate$)
  #     variant: Get|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get|New|Remove|Update
  #     subject: (^DirectoryRoleTemplate)(DirectoryRoleTemplate.*)
  #   set:
  #     subject: $1
  #   - where:
  #     verb: Get
  #     subject: (^DirectorySettingTemplate$)
  #     variant: Get|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get|New|Remove|Update
  #     subject: (^DirectorySettingTemplate)(DirectorySettingTemplate.*)
  #   set:
  #     subject: $1
  # - where:
  #   subject: ^(Setting)(DirectorySetting)$
  # set:
  #   subject: $2
  # - where:
  #     verb: Get
  #     subject: (^Contract$)
  #     variant: Get1|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^Organization$)
  #     variant: Get1|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
