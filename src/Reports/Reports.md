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
