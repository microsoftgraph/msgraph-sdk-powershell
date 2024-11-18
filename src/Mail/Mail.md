# Mail

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Mail v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!
directive:
  - remove-path-by-operation: ^user.mailFolder.childFolder.message_(reply|replyAll)$|^user.mailFolder.message_(reply|replyAll)$
# Remove cmdlets.
  - where:
      verb: Get
      subject: ^UserMailFolderMessageContent$
    remove: true
```
