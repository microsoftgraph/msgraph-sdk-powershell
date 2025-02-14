# Notes

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Notes v1.0 and/or beta modules.

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
  - remove-path-by-operation: ^(user|group|site)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebook_(Get|Update|Delete)Section.*|.*\.notebook\.section.*|.*\.sectionGroup_(Get|Update|Delete)Section.*|.*\.sectionGroup\.section.*|.*\.section_(Get|Update|Delete)Page|.*\.section.page.*|.*\.onenote_(List|Create|Update|Delete)(Operation|Resource)|group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$|^.*site\.(.*_.*SourceColumn|contentType_.*(Base|BaseType|ColumnPosition)|.*_(Get|Create|Update|Delete)Activity|.*\.activity.*
# Remove invalid cmdlet
  - where:
      verb: Update
      subject: ^GroupOnenoteNotebookSectionGroupSectionPage$|^GroupOnenoteNotebookSectionPage$|^GroupOnenotePage$|^GroupOnenoteSectionGroupSectionPage$|^GroupOnenoteSectionPage$|^SiteOnenoteNotebookSectionGroupSectionPage$|^SiteOnenoteNotebookSectionPage$|^SiteOnenotePage$|^SiteOnenoteSectionGroupSectionPage$|^SiteOnenoteSectionPage$|^UserOnenoteNotebookSectionGroupSectionPage$|^UserOnenoteNotebookSectionPage$|^UserOnenotePage$|^UserOnenoteSectionGroupSectionPage$|^UserOnenoteSectionPage$
      variant: ^Update$|UpdateExpanded$|UpdateViaIdentity$|UpdateViaIdentityExpanded$
    remove: true
# Rename cmdlets that call onenotePatchContent action.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
  - where:
      verb: Get
      subject: ^(GroupOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
  - where:
      verb: Update
      subject: ^(GroupOnenotePage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionGroupSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionGroupSectionPage)$
    set:
      subject: $1Content
    
```
