
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
# Remove paths that are not valid.
  - remove-path-by-operation: ^users_(Get|Create|Update|Delete)Analytics$|^users.analytics_(Create|Update|Delete)ActivityStatistics$|^users_.*Insights$|^users.insights_(Create|Update|Delete)(Shared|Trending|Used)$
# Rename
  - where:
      subject: ^(User)Analytic(ActivityStatistics)$
    set:
      subject: $1$2
  - where:
      subject: ^(User)(Insight)(.*)$
    set:
      subject: $1$3$2
  - where:
      subject: ^(User)(Shared)(LastSharedMethodInsight)$
    set:
      subject: $1$3
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
