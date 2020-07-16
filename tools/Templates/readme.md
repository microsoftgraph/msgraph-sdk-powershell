
### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
```

### Versioning

``` yaml
module-version: 0.7.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
