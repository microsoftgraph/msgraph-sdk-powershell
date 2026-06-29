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
# Remove cmdlets.
  - where:
      verb: Get
      subject: ^UserMailFolderMessageContent$
    remove: true
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage|UserMailFolderChildFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$
    set:
      subject: $1All$2
  - where:
      verb: New
      subject: ^(User)(Message|MailFolderMessage|MailFolderChildFolderMessage)(Reply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: $1$2$3All
```
