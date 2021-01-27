<!-- region Generated -->
# Microsoft.Graph.Reports
This directory contains the PowerShell module for the Reports service.

---
## Status
[![Microsoft.Graph.Reports](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Reports.svg?style=flat-square&label=Microsoft.Graph.Reports "Microsoft.Graph.Reports")](https://www.powershellgallery.com/packages/Microsoft.Graph.Reports/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Reports`, see [how-to.md](how-to.md).
<!-- endregion -->

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
directive:
# Remove invalid paths.
  - remove-path-by-operation: auditLogs\.auditLogRoot.*|reports.reportRoot.*|(auditLogs|reports)_(Create|Delete|Update).*
# Remove cmdlets
  - where:
      verb: Get
      subject: ReportTenantSecureScore
    remove: true
# Rename cmdlets
  - where:
      verb: Get
      subject: (^ReportDailyPrintUsageSummary$|^ReportMonthlyPrintUsageSummary$)
      variant: ^Get$|^GetViaIdentity$|^List$
    set:
      subject: $1ByPrinter
  - where:
      verb: Get
      subject: (^ReportDailyPrintUsageSummary$|^ReportMonthlyPrintUsageSummary$)
      variant: ^Get1$|^GetViaIdentity1$|^List1$
    set:
      subject: $1ByUser
  - where:
      verb: Invoke
      subject: ^TopReport$
    set:
      verb: Get
      subject: ReportManagedDeviceEnrollmentTopFailures
  - where:
      verb: Invoke
      subject: ^(Device)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
  - where:
      verb: Invoke
      subject: ^(Managed)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
