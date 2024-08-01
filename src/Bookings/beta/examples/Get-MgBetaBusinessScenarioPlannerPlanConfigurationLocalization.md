### Example 1: Get all localizations

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId $businessScenarioId

```
This example will get all localizations

### Example 2: Get localization for a specific language tag

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId $businessScenarioId -Filter "languageTag eq 'en-us'" 

```
This example will get localization for a specific language tag

