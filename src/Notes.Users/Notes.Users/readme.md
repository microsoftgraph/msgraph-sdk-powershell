
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
# Remove paths that are not valid.
  # - remove-path-by-operation: users_(Get|Create|Update|Delete)Onenote|.*.onenote..*.parent.*|.*.notebooks_(Get|Update|Delete)Section.*|.*.notebooks.section.*|.*.sectionGroups_(Get|Update|Delete)Section.*|.*.sectionGroups.section.*|.*.sections_(Get|Update|Delete)Pages|.*.sections.pages.*|.*.onenote_(List|Create|Update|Delete)(Operations|Resources)

```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
