### Example 1: List all incidents

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityIncident

```
This example will list all incidents

### Example 2: List all incidents with their alerts

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityIncident -ExpandProperty "alerts" 

```
This example will list all incidents with their alerts

