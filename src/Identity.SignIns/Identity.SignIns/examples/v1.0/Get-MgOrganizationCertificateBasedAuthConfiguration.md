###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId -CertificateBasedAuthConfigurationId $certificateBasedAuthConfigurationId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgOrganizationCertificateBasedAuthConfiguration -OrganizationId $organizationId
```
