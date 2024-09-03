### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	certificateAuthorities = @(
		@{
			isRootAuthority = $true
			certificate = [System.Text.Encoding]::ASCII.GetBytes("Binary")
		}
	)
}

New-MgOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the New-MgOrganizationCertificateBasedAuthConfiguration Cmdlet.

