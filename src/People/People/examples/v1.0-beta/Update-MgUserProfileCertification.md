### Example 1: Using the Update-MgUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	IssuingAuthority = "International Academy of Marketing Excellence"
	IssuingCompany = "International Academy of Marketing Excellence"
}
Update-MgUserProfileCertification -UserId $userId -PersonCertificationId $personCertificationId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
