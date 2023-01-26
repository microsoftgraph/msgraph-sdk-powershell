### Example 1: Using the New-MgEducationSchool Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationSchool"
	DisplayName = "String"
	Description = "String"
	ExternalSource = "String"
	ExternalSourceDetail = "String"
	PrincipalEmail = "String"
	PrincipalName = "String"
	ExternalPrincipalId = "String"
	LowestGrade = "String"
	HighestGrade = "String"
	SchoolNumber = "String"
	ExternalId = "String"
	Phone = "String"
	Fax = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	Address = @{
		"@odata.type" = "microsoft.graph.physicalAddress"
	}
}
New-MgEducationSchool -BodyParameter $params
```
This example shows how to use the New-MgEducationSchool Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
