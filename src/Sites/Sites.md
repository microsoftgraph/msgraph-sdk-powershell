# Sites

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Sites v1.0 and/or beta modules.

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
# Remove invalid paths.
  - remove-path-by-operation: groups\.sites_.*Onenote$|groups\.sites\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|sites\..*_(Create|Get|Update|Delete)Activities$|sites\..*\.activities.*|^sites_(remove|add)$|^.*sites\.(.*_.*SourceColumn|contentTypes_.*(Base|BaseTypes|ColumnPositions)|.*_(Get|Create|Update|Delete)Activities|.*\.activities.*|termStore_ListSets|termStore\.groups\.sets(\.children.*|_.*ParentGroup|\.relations_.*|\.terms\.relations_.*|\.terms\.children.*|\.terms_.*Set)|termStore\.sets(\.children.*|_.*ParentGroup|\.parentGroup.*|\.relations.*|\.terms\.children.*|\.terms\.relations.*|\.terms_.*Set))$
# Remove cmdlets
  - where:
      verb: Remove|New
      subject: ^Site$
    remove: true
  - where:
      verb: Get
      subject: ^Site$
      variant: ^List1$
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: ^(Site)OnenoteNotebook(RecentNotebook$)
    set:
      subject: $1$2
  - where:
      verb: Get
      subject: ^GroupSite$
      variant: ^Get1$|^GetViaIdentity1$|^List1$
    set:
      subject: GroupSubSite
  - where:
      verb: Get
      subject: ^(Group|Site|GroupSite)(Drive)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
# Rename cmdlets that call onenotePatchContent action.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
  - where:
      parameter-name: SiteId
      verb: Get
      subject: (SiteAnalytic|SiteColumn|SiteContentType|SiteContentTypeContentLink|SubSite)
    set:
      default:
        name: SiteId Default Value
        description: Get the SiteId as default to root
        script: '"root"'
```
