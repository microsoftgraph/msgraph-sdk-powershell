### Example 1: Using the New-MgBetaIdentityGovernanceTermOfUseAgreement Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "Contoso ToU for guest users"
	IsViewingBeforeAcceptanceRequired = $true
	Files = @(
		@{
			FileName = "TOU.pdf"
			Language = "en"
			IsDefault = $true
			FileData = @{
				Data = [System.Text.Encoding]::ASCII.GetBytes("SGVsbG8gd29ybGQ=//truncated-binary")
			}
		}
	)
}
New-MgBetaIdentityGovernanceTermOfUseAgreement -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityGovernanceTermOfUseAgreement Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
