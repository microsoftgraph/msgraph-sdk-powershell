### Example 1: List risk detections

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaServicePrincipalRiskDetection

```
This example will list risk detections

### Example 2: List risk detections and filter the results

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaServicePrincipalRiskDetection -Filter "riskEventType eq 'investigationsThreatIntelligence' or riskLevel eq 'medium'" 

```
This example will list risk detections and filter the results

