### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Contoso ToU for guest users"
	isViewingBeforeAcceptanceRequired = $true
	files = @(
		@{
			fileName = "TOU.pdf"
			language = "en"
			isDefault = $true
			fileData = @{
				data = [System.Text.Encoding]::ASCII.GetBytes("SGVsbG8gd29ybGQ=//truncated-binary")
			}
		}
	)
}

New-MgIdentityGovernanceTermsOfUseAgreement -BodyParameter $params

```
This example shows how to use the New-MgIdentityGovernanceTermsOfUseAgreement Cmdlet.

