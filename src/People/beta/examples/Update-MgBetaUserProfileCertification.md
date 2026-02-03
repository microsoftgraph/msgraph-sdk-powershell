### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	issuingAuthority = "International Academy of Marketing Excellence"
	issuingCompany = "International Academy of Marketing Excellence"
}

Update-MgBetaUserProfileCertification -UserId $userId -PersonCertificationId $personCertificationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileCertification Cmdlet.

