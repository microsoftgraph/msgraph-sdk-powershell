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

The wrapper migration inventories only this shared file. Profile-local readmes and
`src/readme.graph.md` are intentionally ignored. Parameter aliases/defaults and
schema/response transforms are deferred. Reviewed method/path/old-ID/new-ID evidence
lives in `wrapper/Sites_directiveMigrationMap.json`; module-specific regressions live
in `tools/WrapperGenerator.Tests/SitesDirectiveMigrationTests.cs`. Original AutoRest
directives remain active.

`wrapper/Sites_multiRouteEvidence.json` records 192 exact recursive termStore
operations behind 84 formerly colliding public names. Published defaults are
independently pinned to Learn's default syntax and unique path-ID contracts, not
the lossy metadata inventory's first URI. All 84 default contracts use the direct
tree. The shared configuration preserves those direct command names and uses
distinct `NestedChild` nouns for the actual `/children/{id}/children` navigation;
both URLs remain reachable without endpoint selectors or mutation merges.
Existing derived v1.0 and curated termStores/singleton behavior remains authoritative.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration 1: authorized source correction appends exactly one missing
# terminal ')'. The invalid original below has NO defined match set; .NET reports
# "Not enough )'s" at offset 631. This is a source/behavior correction, not API absence.
# Original invalid selector: group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$|^.*site\.(.*_.*SourceColumn|contentType_.*(Base|BaseType|ColumnPosition)|.*_(Get|Create|Update|Delete)Activity|.*\.activity.*|^(user|group|site)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebook_(Get|Update|Delete)Section.*|.*\.sectionGroup_(Get|Update|Delete)Section.*|.*\.section_(Get|Update|Delete)Page|.*\.section.page.*|.*\.onenote_(List|Create|Update|Delete)(Operation|Resource)|^site_UpdatePage$
# The ledger accounts for the COMPLETE corrected-selector legacy matches in each
# profile and bridges actual surviving routes/IDs, including guarded final action
# or function qualification. Module tests cover suppressions and unaffected neighbors.
  - remove-path-by-operation: group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$|^.*site\.(.*_.*SourceColumn|contentType_.*(Base|BaseType|ColumnPosition)|.*_(Get|Create|Update|Delete)Activity|.*\.activity.*|^(user|group|site)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebook_(Get|Update|Delete)Section.*|.*\.sectionGroup_(Get|Update|Delete)Section.*|.*\.section_(Get|Update|Delete)Page|.*\.section.page.*|.*\.onenote_(List|Create|Update|Delete)(Operation|Resource)|^site_UpdatePage$)
# Remove cmdlets
# Wrapper migration 2: suppress beta POST /sites only; neither actual input has a
# root site DELETE. Preserve root GETs/PATCH and the separate group-site actions.
  - where:
      verb: Remove|New
      subject: ^Site$
    remove: true
# Wrapper migration 3: all five exact GroupSite page PATCHes are covered by
# directive 1's reviewed OneNote suppression; no redundant override is added.
  - where:
      verb: Update
      subject: ^GroupSiteOnenoteNotebookSectionGroupSectionPage$|^GroupSiteOnenoteNotebookSectionPage$|^GroupSiteOnenotePage$|^GroupSiteOnenoteSectionGroupSectionPage$|^GroupSiteOnenoteSectionPage$
      variant: ^(Patch|PatchExpanded|PatchViaIdentity|PatchViaIdentityExpanded)$
    remove: true
# Wrapper migration 4: retain existing curated collection/item SubSite renames.
  - where:
      verb: Get
      subject: ^Site$
      variant: ^Get1$|^GetViaIdentity1$|^List2$
    set:
      subject: SubSite
# Wrapper migration 5: exact nested count rename; root SiteCount is unaffected.
  - where:
      verb: Get
      subject: ^SiteCount$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: SubSiteCount
# Wrapper migration 6: List1 is the /sites/{id}/lists collection. Structural
# naming already emits SiteList and preserves the paired item GET.
  - where:
      verb: Get
      subject: ^(Site)$
      variant: ^List1$
    set:
      subject: $1List
# Wrapper migration 7: retain existing curated GroupSubSite collection/item names.
  - where:
      verb: Get
      subject: ^GroupSite$
      variant: ^Get1$|^GetViaIdentity1$|^List2$
    set:
      subject: GroupSubSite
# Wrapper migration 8: exact nested count rename; parent GroupSiteCount is kept.
  - where:
      verb: Get
      subject: ^GroupSiteCount$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: GroupSubSiteCount
# Wrapper migration 9: structural naming already emits GroupSiteList for List1.
  - where:
      verb: Get
      subject: ^(GroupSite)$
      variant: ^List1$
    set:
      subject: $1List
# Wrapper migration 10: singleton drive naming already supplies DefaultDrive.
# The group-root drive is absent from both same-module inputs, not fabricated.
  - where:
      verb: Get
      subject: ^(Group|Site|GroupSite)(Drive)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
# Wrapper audit 11: no site-root OneNote operations exist in either actual legacy
# or compatible profile. GroupSite OneNote is not this Site-only selector.
  - where:
      verb: Get
      subject: ^(Site)OnenoteNotebook(RecentNotebook$)
    set:
      subject: $1$2
# Wrapper migration 12: actual getAllSites function maps published variant Get2
# to AllSite, retaining the existing v1 derived rename and covering beta.
  - where:
      verb: Get
      variant: Get2
      subject: ^(Site)$
    set:
      subject: All$1
# Rename cmdlets that call onenotePatchContent action.
# Wrapper audit 13: no SiteOnenote operations exist in either actual same-profile
# legacy/compatible input; do not invent a successor from GroupSite operations.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
# Wrapper deferred 14: retain the SiteId default/parameter transform unchanged.
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
