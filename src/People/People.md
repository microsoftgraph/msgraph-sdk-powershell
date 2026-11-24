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
# Wrapper migration: directive 1 suppresses exactly beta GET/PATCH/DELETE
# /users/{user-id}/analytics. The original legacy regex does not match the plural
# ActivityStatistics IDs; those operations remain available. No v1.0 selector
# matches exist. People_directiveMigrationMap.json records the complete old/new
# operation evidence; PeopleDirectiveMigrationTests pins the affected neighbors.
# Refreshed powershell-v3 compatible IDs now align with the legacy source: the
# literal selector matches exactly every original survivor (v1.0 zero, beta three).
# The ledger uses supported literal evidence, not the unmerged Legacy helper.
# Keep all original shared directives active until the AutoRest pipeline retires.
  - remove-path-by-operation: ^user_(Get|Create|Update|Delete)Analytic$|^user.analytic_(Create|Update|Delete)ActivityStatistic$|^user_.*Insight$|^user.insight_(Create|Update|Delete)(Shared|Trending|Used)$
# Modify generated .cs cmdlets.
# Wrapper migration: directive 2 is DeferredParameter (source transform).
# Do not port this AutoRest-specific Client/ServiceClient rewrite. Parameter
# aliases/transforms and schema/response changes are explicitly deferred.
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
# Wrapper migration: directive 3 maps five beta activityStatistics collection/item
# operations to UserActivityStatistics using exact method/path overrides. The
# $count neighbor does not match this anchored subject and keeps its own name.
# This family is absent from both actual v1.0 specifications.
  - where:
      subject: ^(User)Analytic(ActivityStatistics)$
    set:
      subject: $1$2
# Wrapper migration: directive 4 is a reviewed absent-selector audit in both
# profiles: neither actual legacy nor compatible People spec has insight routes.
# No successor or redundant override is invented.
  - where:
      subject: ^(User)(Insight)(.*)$
    set:
      subject: $1$3$2
# Wrapper migration: directive 5 is likewise absent from both profiles' actual
# legacy and compatible People routes. See the adjacent reviewed ledger.
  - where:
      subject: ^(User)(Shared)(LastSharedMethodInsight)$
    set:
      subject: $1$3
```
