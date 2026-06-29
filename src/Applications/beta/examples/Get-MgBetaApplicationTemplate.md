### Example 1: Get application template

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaApplicationTemplate -ApplicationTemplateId $applicationTemplateId

```
This example will get application template

### Example 2: Get application template with optional properties

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaApplicationTemplate -ApplicationTemplateId $applicationTemplateId -Property "id,displayName,riskScore,riskFactors" 

```
This example will get application template with optional properties

