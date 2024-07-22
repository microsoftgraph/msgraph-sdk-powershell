### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	status = "resolved"
	resolvedReason = "fraud"
}

Update-MgBetaSecurityPartnerSecurityAlert -PartnerSecurityAlertId $partnerSecurityAlertId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityPartnerSecurityAlert Cmdlet.

