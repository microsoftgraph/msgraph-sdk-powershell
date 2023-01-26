### Example 1: Using the Update-MgBetaUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	IssuingAuthority = "International Academy of Marketing Excellence"
	IssuingCompany = "International Academy of Marketing Excellence"
}
Update-MgBetaUserProfileCertification -UserId $userId -PersonCertificationId $personCertificationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
