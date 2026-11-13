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

The v3 migration covers only this shared file. Profile-local readmes and
`src/readme.graph.md` are intentionally ignored. Parameter aliases/transforms and
schema/response directives remain deferred (none occur in this file).

The nested `sectionGroups/{sectionGroup-id}/sectionGroups` collection is distinct
from the root `sectionGroups/{sectionGroup-id}` item despite requiring the same
IDs. Its shared path-derived noun is now `*OnenoteSectionGroupNestedSectionGroup`
(and `*OnenoteSectionGroupNestedSectionGroupCount` for its distinct `$count`);
ordinary root List/Get defaults remain unchanged. No selector or incompatible
natural-ID group is introduced. Existing v1.0 oracle-derived data still suppresses
the three nested collections and the three root collection counts. These baseline
endpoint gaps block a full-fidelity claim and are not repaired by silently changing
global data in this module.

The compatible IDs now align with all 298 of the active selector's actual
same-profile legacy selections. The finite required-path ID corrections in
the normally merged prerequisite restore nine section/page action/function IDs.
The ledger uses ordinary literal method/path/ID evidence, without a runtime
legacy lookup or bridge schema. A one-time historical source comparison in the
module tests verifies all surviving routes and the final action/function
qualification changes; no selected API is classified as removed.

The source selector no longer includes the unrelated terminal site metadata
alternation. The simplified regex is valid and selects the same 298 operations
in each legacy and compatible Notes profile. The earlier invalid regex and its
minimal parenthesis repair remain historical audit evidence, not the active
selector; the ledger's active source anchor matches this file.

Validation targets PowerShell 7/Core only; explicit PowerShell 5.1 support is
outside the v3 scope.

Resource PATCH commands return only their own response: a 204 produces no
object and no automatic GET, while a 200 model is returned as typed output.
Call the corresponding GET explicitly when needed; its permissions, headers
and query inputs remain independent of the mutation. This supersedes the
historical implicit-readback validation, without adding a readback switch.

``` yaml
directive:
# Remove paths that are not valid.
# Wrapper migration: the simplified active source selector removes the unrelated
# terminal site metadata alternation. It parses and preserves the exact Notes
# selections. The invalid original ("Not enough )'s", offset 665) and previous
# minimal parenthesis repair remain historical in the adjacent
# Notes_directiveMigrationMap.json sourceCorrection audit and regression tests.
# The active selector below selects 298 actual legacy operations
# per profile: historical comparison found 244 exact paths and 54 final
# action/function qualification changes. Current literal IDs cover all 298.
# All have real compatible successors; none are claimed removed. Exact
# suppressions live in Notes_cmdletConfigurations.cs. Keep the directive active.
  - remove-path-by-operation: ^(user|group|site)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebook_(Get|Update|Delete)Section.*|.*\.notebook\.section.*|.*\.sectionGroup_(Get|Update|Delete)Section.*|.*\.sectionGroup\.section.*|.*\.section_(Get|Update|Delete)Page|.*\.section.page.*|.*\.onenote_(List|Create|Update|Delete)(Operation|Resource)|group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$
# Remove invalid cmdlet
# Wrapper migration: suppress only the resource PATCH Update variants. Twelve
# routes are already suppressed by directive 1; three direct Page PATCH routes
# need additional exact rules. POST onenotePatchContent and GET neighbors remain.
  - where:
      verb: Update
      subject: ^GroupOnenoteNotebookSectionGroupSectionPage$|^GroupOnenoteNotebookSectionPage$|^GroupOnenotePage$|^GroupOnenoteSectionGroupSectionPage$|^GroupOnenoteSectionPage$|^SiteOnenoteNotebookSectionGroupSectionPage$|^SiteOnenoteNotebookSectionPage$|^SiteOnenotePage$|^SiteOnenoteSectionGroupSectionPage$|^SiteOnenoteSectionPage$|^UserOnenoteNotebookSectionGroupSectionPage$|^UserOnenoteNotebookSectionPage$|^UserOnenotePage$|^UserOnenoteSectionGroupSectionPage$|^UserOnenoteSectionPage$
      variant: ^Update$|UpdateExpanded$|UpdateViaIdentity$|UpdateViaIdentityExpanded$
    remove: true
# Rename cmdlets that call onenotePatchContent action.
# Wrapper migration: the broad Site Update selector also appends Content to
# surviving Notebook, SectionGroup and Section resource PATCH names. Of fifteen
# actual candidates, eleven are suppressed by directive 1. Four shared fallback
# names cover beta; existing v1.0 derived names remain authoritative.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
# Wrapper migration: exact Group getRecentNotebooks fallback removes redundant
# Notebook in beta; v1.0 already has the same derived published name.
  - where:
      verb: Get
      subject: ^(GroupOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
# Wrapper migration: direct Group PageContent keeps its published Update verb
# and Content noun. Resource PATCH suppression does not remove this POST action.
  - where:
      verb: Update
      subject: ^(GroupOnenotePage)$
    set:
      subject: $1Content
# Wrapper migration: directive 1 suppresses this actual nested action. Retain
# its active rename and compatible evidence, without an unreachable override.
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionPage)$
    set:
      subject: $1Content
# Wrapper migration: superseded by directive 1 suppression; actual compatible
# successor recorded in the ledger, not misclassified as an absent API.
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionPage)$
    set:
      subject: $1Content
# Wrapper migration: superseded by directive 1 suppression; retain source and
# actual compatible successor evidence, without a redundant rename.
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionGroupSectionPage)$
    set:
      subject: $1Content
# Wrapper migration: superseded by directive 1 suppression; retain source and
# actual compatible successor evidence, without a redundant rename.
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionGroupSectionPage)$
    set:
      subject: $1Content
    
```
