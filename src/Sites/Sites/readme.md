
### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Needs validation
# directive:
  # - where:
  #     verb: Remove
  #     subject: Site
  #     variant: Remove
  #   hide: true
  # - where:
  #     verb: Remove
  #     subject: Site
  #     variant: RemoveExpanded
  #   hide: true
  # - where:
  #     verb: Get
  #     subject: Site
  #     variant: Get1
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: Get
  #     subject: Site
  #     variant: List1
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: Get
  #     subject: Site
  #     variant: GetViaIdentity1
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: New
  #     subject: Site
  #     variant: Create1
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: New
  #     subject: Site
  #     variant: CreateExpanded1
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: New
  #     subject: Site
  #     variant: CreateViaIdentity
  #   set:
  #     subject: SubSite
  # - where:
  #     verb: New
  #     subject: Site
  #     variant: CreateViaIdentityExpanded
  #   set:
  #     subject: SubSite
  # - where:
  #     parameter-name: SiteId
  #     verb: Get
  #     subject: (SiteAnalytic|SiteColumn|SiteContentType|SiteContentTypeContentLink|SubSite)
  #   set:
  #     default:
  #       name: SiteId Default Value
  #       description: Get the SiteId as default to root
  #       script: '"root"'
# # Remove paths that are not valid.
#   - remove-path-by-operation: sites.onenote..*.parent.*|.*.notebooks.section.*|.*.sectionGroups.section.*|.*.sections.pages.*
# # Remove cmdlets
#   - where:
#       subject: ^SiteListItemActivityListItemActivity$|^SiteListActivityListItemActivity$
#     remove: true
# # Rename cmdlets
#   - where:
#       verb: Get
#       subject: (^Site$)
#     set:
#       subject: $1ByPath
#   - where:
#       verb: Get
#       subject: (^SiteActivity$)
#     set:
#       subject: $1ByInterval
#   - where:
#       verb: Get
#       subject: (^SiteListItemActivity$)
#     set:
#       subject: $1ByInterval
#   - where:
#       verb: Get
#       subject: ^(Site)OnenoteNotebook(RecentNotebook$)
#     set:
#       subject: $1$2
#   - where:
#       verb: Invoke
#       subject: ^PreviewSite(.*)
#     set:
#       subject: Preview$1
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
