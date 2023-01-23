### Example 1: Using the Get-MgBetaServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaServicePrincipalRiskDetection -ServicePrincipalRiskDetectionId $servicePrincipalRiskDetectionId
```
This example shows how to use the Get-MgBetaServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaServicePrincipalRiskDetection -Filter "riskEventType eq 'investigationsThreatIntelligence' or riskLevel eq 'medium'" 
```
This example shows how to use the Get-MgBetaServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaServicePrincipalRiskDetection
```
This example shows how to use the Get-MgBetaServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
