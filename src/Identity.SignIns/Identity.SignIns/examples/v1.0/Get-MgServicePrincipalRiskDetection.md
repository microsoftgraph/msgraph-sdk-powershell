### Example 1: List risk detections

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgServicePrincipalRiskDetection
```
This example shows how to use the Get-MgServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List risk detections and filter the results

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgServicePrincipalRiskDetection -Filter "riskEventType eq 'investigationsThreatIntelligence' or riskLevel eq 'medium'"
```
This example shows how to use the Get-MgServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

