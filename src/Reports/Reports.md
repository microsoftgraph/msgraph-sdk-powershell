# Reports

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Reports v1.0 and/or beta modules.

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
  - remove-path-by-operation: auditLogs\.auditLogRoot.*|reports.reportRoot.*|(auditLogs|reports)_(Create|Delete|Update).*
# Remove cmdlets
  - where:
      verb: Get
      subject: ReportTenantSecureScore
    remove: true
# Rename cmdlets
  # - where:
  #     verb: Get
  #     subject: (^ReportDailyPrintUsageSummary$|^ReportMonthlyPrintUsageSummary$)
  #     variant: ^Get$|^GetViaIdentity$|^List$
  #   set:
  #     subject: $1ByPrinter
  # - where:
  #     verb: Get
  #     subject: (^ReportDailyPrintUsageSummary$|^ReportMonthlyPrintUsageSummary$)
  #     variant: ^Get1$|^GetViaIdentity1$|^List1$
  #   set:
  #     subject: $1ByUser
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
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
