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
  - remove-path-by-operation: group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$|^.*site\.(.*_.*SourceColumn|contentType_.*(Base|BaseType|ColumnPosition)|.*_(Get|Create|Update|Delete)Activity|.*\.activity.*
# Remove cmdlets
  - where:
      verb: Remove|New
      subject: ^Site$
    remove: true
  - where:
      verb: Update
      subject: ^GroupSiteOnenoteNotebookSectionGroupSectionPage$|^GroupSiteOnenoteNotebookSectionPage$
    remove: true
  - where:
      verb: Get
      subject: ^Site$
      variant: ^Get1$|^GetViaIdentity1$|^List2$
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: ^SiteCount$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: SubSiteCount
  - where:
      verb: Get
      subject: ^(Site)$
      variant: ^List1$
    set:
      subject: $1List
  - where:
      verb: Get
      subject: ^GroupSite$
      variant: ^Get1$|^GetViaIdentity1$|^List2$
    set:
      subject: GroupSubSite
  - where:
      verb: Get
      subject: ^GroupSiteCount$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: GroupSubSiteCount
  - where:
      verb: Get
      subject: ^(GroupSite)$
      variant: ^List1$
    set:
      subject: $1List
  - where:
      verb: Get
      subject: ^(Group|Site|GroupSite)(Drive)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
  - where:
      verb: Get
      subject: ^(Site)OnenoteNotebook(RecentNotebook$)
    set:
      subject: $1$2
  - where:
      verb: Get
      variant: Get2
      subject: ^(Site)$
    set:
      subject: All$1
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
