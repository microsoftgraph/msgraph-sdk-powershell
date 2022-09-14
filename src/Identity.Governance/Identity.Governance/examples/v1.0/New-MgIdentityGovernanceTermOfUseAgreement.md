### Example 1: Using the New-MgIdentityGovernanceTermOfUseAgreement Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
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
New-MgIdentityGovernanceTermOfUseAgreement -BodyParameter $params
```
This example shows how to use the New-MgIdentityGovernanceTermOfUseAgreement Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
