### Example 1: Using the Get-MgBetaSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
Get-MgBetaSecurityIncident -IncidentId $incidentId
```
This example shows how to use the Get-MgBetaSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
Get-MgBetaSecurityIncident
```
This example shows how to use the Get-MgBetaSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
Get-MgBetaSecurityIncident -ExpandProperty "alerts" 
```
This example shows how to use the Get-MgBetaSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
