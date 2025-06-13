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
  - where:
      parameter-name: Period
    set:
      completer:
        name: Period Completer
        description: Gets the list of Period values.
        script: "'D7', 'D30', 'D90', 'D180'"
# Remove invalid paths.
  - remove-path-by-operation: auditLog\.auditLogRoot.*|report.reportRoot.*|(auditLog|report)_(Create|Delete|Update).*|
# Remove cmdlets
  - where:
      verb: Get
      subject: ^ReportTenantSecureScore$|^DeviceManagementReportCertificateReport$
    remove: true
  - where:
      verb: Invoke
      subject: ^TopReport$
    set:
      verb: Get
      subject: ReportManagedDeviceEnrollmentTopFailure
  - where:
      verb: Invoke
      subject: ^(Device)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
  - where:
      verb: Invoke
      subject: ^(Detail)Report(.*)$
    set:
      verb: Get
      subject: Report$2$1
  - where:
      verb: Invoke
      subject: ^(Managed)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
  - where:
      subject: ^(ReportApplicationSign)$
    set:
      subject: $1InDetailedSummary
  - where:
      subject: ^(ReportAzureAdApplicationSign)$
    set:
      subject: $1InSummary
```
