### Example 1: Get the properties of the specified service principal

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal -ServicePrincipalId $servicePrincipalId

```
This example will get the properties of the specified service principal

### Example 2: Get the custom security attribute assignments of the specified service principal

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal -ServicePrincipalId $servicePrincipalId -Property "customSecurityAttributes" 

```
This example will get the custom security attribute assignments of the specified service principal

