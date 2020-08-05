
### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Versioning

``` yaml
<<<<<<< HEAD
module-version: 0.7.1
=======
module-version: 0.9.0
>>>>>>> dev
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
