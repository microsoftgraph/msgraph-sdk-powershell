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
# Remove paths that are not valid.
  - remove-path-by-operation: ^user_(Get|Create|Update|Delete)Analytic$|^user.analytic_(Create|Update|Delete)ActivityStatistic$|^user_.*Insight$|^user.insight_(Create|Update|Delete)(Shared|Trending|Used)$
# Modify generated .cs cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2F(New(Mg|MgBeta)UserProfileProject_Create(Expanded|ViaIdentityExpanded)|Update(Mg|MgBeta)UserProfileProject_Update(Expanded|ViaIdentityExpanded))\d*.cs/gm))
      {
        return $;
      } else {
        // Rename Client to ServiceClient to avoid conflict with "Client" property in "People" entity.
        let serviceClientRegex = /(public\s*Microsoft.(Graph|Graph.Beta).PowerShell.People\s*)(Client\s*=>)/gmi
        $ = $.replace(serviceClientRegex, "$1Service$3");

        let serviceClientCallRegex = /(this.)(Client.UserProfile(Create|Update)Project)/gmi
        $ = $.replace(serviceClientCallRegex, "$1Service$2");

        return $;
      }
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
