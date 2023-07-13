### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationSchool"
	displayName = "String"
	description = "String"
	externalSource = "String"
	externalSourceDetail = "String"
	principalEmail = "String"
	principalName = "String"
	externalPrincipalId = "String"
	lowestGrade = "String"
	highestGrade = "String"
	schoolNumber = "String"
	externalId = "String"
	phone = "String"
	fax = "String"
	createdBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	address = @{
		"@odata.type" = "microsoft.graph.physicalAddress"
	}
}

New-MgEducationSchool -BodyParameter $params
```
This example shows how to use the New-MgEducationSchool Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

