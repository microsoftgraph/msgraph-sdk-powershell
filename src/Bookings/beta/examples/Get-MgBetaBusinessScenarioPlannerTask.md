### Example 1: Get all tasks for a scenario

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBusinessScenarioPlannerTask -BusinessScenarioId $businessScenarioId

```
This example will get all tasks for a scenario

### Example 2: Get tasks associated with a specific externalContextId

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBusinessScenarioPlannerTask -BusinessScenarioId $businessScenarioId -Filter "businessScenarioProperties/externalContextId eq 'Warehouse-CA-36'" 

```
This example will get tasks associated with a specific externalcontextid

### Example 3: Get scenario tasks created in a specific group

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBusinessScenarioPlannerTask -BusinessScenarioId $businessScenarioId -Filter "location/microsoft.graph.businessScenarioGroupTarget/groupId eq '7a339254-4b2b-4410-b295-c890a16776ee'" 

```
This example will get scenario tasks created in a specific group

