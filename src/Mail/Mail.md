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

The v3 shared-directive review covers v1.0 only. Beta is excluded from this
review because `openApiDocs_KiotaCompat\beta\Mail.yml` is absent; this is not
evidence that the corresponding beta API operations do not exist. No legacy
spec fallback was used. Profile-specific directives and `src\readme.graph.md`
are outside this review; parameter and schema/response migrations remain deferred.

`wrapper\Mail_directiveMigrationMap.json` records exact v1.0 operation evidence.
Its beta declarations are explicitly marked `excluded: true`, not
`absenceExpected: true`. The strict inventory validates the missing compatible
input without claiming that the beta API operations are absent.

The v1.0 revalidation after the target update includes the complete original
`openApiDocs\v1.0\Mail.yml` selection: one folder-message content GET and three
each of the `replyAll` and `createReplyAll` actions. All seven survive in the
compatible spec. Action paths lose only the `microsoft.graph.` qualifier; the
child-folder action operation IDs also retain a repeated `mailFolder` segment
in the compatible document. The adjacent ledger uses current literal IDs, while
`MailDirectiveMigrationTests` checks both full source selections and their
compatible route sets. No source-selected operation was removed.

``` yaml
# Directives go here!
directive:
# Remove cmdlets.
# Wrapper migration: the exact GET .../mailFolders/{id}/messages/{id}/$value
# suppression already exists in parity-suppressions.v1.0.json. MailDirectiveMigrationTests
# pins it and neighboring routes; no duplicate curated entry is needed. Keep active
# until the legacy service-module pipeline is retired.
  - where:
      verb: Get
      subject: ^UserMailFolderMessageContent$
    remove: true
# Wrapper migration: all three replyAll actions already have the ReplyAll-prefixed
# nouns in parity-renames.v1.0.json. The reviewed map records exact POST operations;
# MailDirectiveMigrationTests also pins the unaffected reply actions. Keep active.
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage|UserMailFolderChildFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$
    set:
      subject: $1All$2
# Wrapper migration: all three createReplyAll actions already have New- verbs and
# ReplyAll-suffixed nouns in parity-renames.v1.0.json. MailDirectiveMigrationTests
# pins these and the neighboring createReply actions. Keep this directive active.
  - where:
      verb: New
      subject: ^(User)(Message|MailFolderMessage|MailFolderChildFolderMessage)(Reply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: $1$2$3All
```
