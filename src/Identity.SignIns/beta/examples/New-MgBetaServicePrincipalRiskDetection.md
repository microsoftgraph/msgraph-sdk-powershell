### Example 1: List risk detections

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaServicePrincipalRiskDetection
```
This example shows how to use the New-MgBetaBetaServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List risk detections and filter the results

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaServicePrincipalRiskDetection -Filter "riskEventType eq 'investigationsThreatIntelligence' or riskLevel eq 'medium'"
```
This example shows how to use the New-MgBetaBetaServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

