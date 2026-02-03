### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	certificateAuthorities = @(
		@{
			isRootAuthority = $true
			certificate = [System.Text.Encoding]::ASCII.GetBytes("Binary")
		}
	)
}

New-MgBetaOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the New-MgBetaOrganizationCertificateBasedAuthConfiguration Cmdlet.

