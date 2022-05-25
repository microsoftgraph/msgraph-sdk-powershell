# Identity.DirectoryManagement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Identity.DirectoryManagement v1.0 and/or beta modules.

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
# Remove cmdlets.
  - where:
      verb: Get
      subject: (Contact|Contract|Device|DirectoryRole|DirectoryRoleTemplate|Organization)AvailableExtensionProperty
    remove: true
# Alias then rename cmdlets to avoid breaking change.
  - where:
      subject: ^UserScopedRoleMember$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^UserScopedRoleMember$
    set:
      subject: UserScopedRoleMemberOf
  - where:
      subject: ^(Contact|Device)(Member|TransitiveMember)$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(Contact|Device)(Member|TransitiveMember)$
    set:
      subject: $1$2Of
# Rename cmdlets
# TODO: Clean up
  # - where:
  #     verb: Get
  #     subject: (^DirectorySettingTemplate$)
  #     variant: Get|GetExpanded
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^DirectoryRoleTemplate$)
  #     variant: Get|GetExpanded|Get1|GetExpanded1
  #   set:
  #     verb: Get
  #     subject: $1ById
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(DirectorySettingTemplate|DirectoryRoleTemplate)(\1)+
    set:
      subject: $1
# Rename cmdlets
  # - where:
  #     verb: Get
  #     subject: (^AdministrativeUnit$)
  #     variant: Get1|GetExpanded
  #   set:
  #     subject: $1ById
  - where:
      verb: Get
      subject: (^Contact$)
    set:
      subject: $1ById
  - where:
      subject: (^Contact)(OrgContact$)
    set:
      subject: $1
# TODO: Clean up
  # - where:
  #     verb: Get
  #     subject: (^Device$)
  #     variant: Get|GetExpanded|Get2|GetExpanded1
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^DirectoryRole$)
  #     variant: Get1|GetExpanded|Get3|GetExpanded1
  #   set:
  #     verb: Get
  #     subject: $1ById
  - where:
      subject: ^(Setting)(DirectorySetting)$
    set:
      subject: $2
# TODO: Clean up
  # - where:
  #     verb: Get
  #     subject: (^Contract$)
  #     variant: Get1|GetExpanded|Get3|GetExpanded1
  #   set:
  #     verb: Get
  #     subject: $1ById
  # - where:
  #     verb: Get
  #     subject: (^Organization$)
  #     variant: Get1|GetExpanded|Get3|GetExpanded1
  #   set:
  #     verb: Get
  #     subject: $1ById
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
