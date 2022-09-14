### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId -CertificateBasedAuthConfigurationId $certificateBasedAuthConfigurationId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId
```
