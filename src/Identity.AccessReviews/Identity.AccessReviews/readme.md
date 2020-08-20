
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
# # Rename cmdlets with duplicates in their name.
#   - where:
#       subject: ^(BusinessFlowTemplate)(\1)+
#     set:
#       subject: $1
#   - where:
#       subject: ^(ProgramControlType)(\1)+
#     set:
#       subject: $1
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
