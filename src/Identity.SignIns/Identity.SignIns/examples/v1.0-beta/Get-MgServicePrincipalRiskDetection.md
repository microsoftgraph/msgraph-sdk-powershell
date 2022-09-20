### Example 1: Using the Get-MgServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgServicePrincipalRiskDetection -ServicePrincipalRiskDetectionId $servicePrincipalRiskDetectionId
```
This example shows how to use the Get-MgServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgServicePrincipalRiskDetection -Filter "riskEventType eq 'investigationsThreatIntelligence' or riskLevel eq 'medium'" 
```
This example shows how to use the Get-MgServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgServicePrincipalRiskDetection Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgServicePrincipalRiskDetection
```
This example shows how to use the Get-MgServicePrincipalRiskDetection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
