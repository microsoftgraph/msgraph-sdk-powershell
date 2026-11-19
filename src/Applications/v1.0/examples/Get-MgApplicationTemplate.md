### Example 1: Get application template

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplicationTemplate -ApplicationTemplateId $applicationTemplateId

```
This example will get application template

### Example 2: Get application template with optional properties

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplicationTemplate -ApplicationTemplateId $applicationTemplateId -Property "id,displayName,riskScore,riskFactors" 

```
This example will get application template with optional properties

