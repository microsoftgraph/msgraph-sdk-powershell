# People

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for People v1.0 and/or beta modules.

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
# Modify generated .cs cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2F(NewMgUserProfileProject_Create(Expanded|ViaIdentityExpanded)|UpdateMgUserProfileProject_Update(Expanded|ViaIdentityExpanded))\d*.cs/gm))
      {
        return $;
      } else {
        // Rename Client to ServiceClient to avoid conflict with "Client" property in "People" entity.
        let serviceClientRegex = /(public\s*Microsoft.Graph.PowerShell.People\s*)(Client\s*=>)/gmi
        $ = $.replace(serviceClientRegex, "$1Service$2");

        let serviceClientCallRegex = /(this.)(Client.UsersProfile(Create|Update)Projects)/gmi
        $ = $.replace(serviceClientCallRegex, "$1Service$2");

        return $;
      }
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
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
