### Example 1: Using the Get-MgSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityIncident -IncidentId $incidentId
```
This example shows how to use the Get-MgSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityIncident
```
This example shows how to use the Get-MgSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityIncident -ExpandProperty "alerts" 
```
This example shows how to use the Get-MgSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
