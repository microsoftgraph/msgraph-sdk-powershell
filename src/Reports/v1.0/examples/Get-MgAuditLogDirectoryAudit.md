### Example 1: Retrieve the list of audit logs

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogDirectoryAudit

```
This example will retrieve the list of audit logs

### Example 2: Retrieve the list of audit logs with a filter on initiatedBy/user

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogDirectoryAudit -Filter "initiatedBy/user/id eq '00000000-0000-0000-0000-000000000000'" 

```
This example will retrieve the list of audit logs with a filter on initiatedby/user

