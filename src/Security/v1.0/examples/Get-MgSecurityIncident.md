### Example 1: List all incidents

```powershell

Import-Module Microsoft.Graph.Security

Get-MgSecurityIncident

```
This example will list all incidents

### Example 2: List all incidents with their alerts

```powershell

Import-Module Microsoft.Graph.Security

Get-MgSecurityIncident -ExpandProperty "alerts" 

```
This example will list all incidents with their alerts

