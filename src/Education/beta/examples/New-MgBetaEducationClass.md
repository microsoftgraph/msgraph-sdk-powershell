### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationClass"
	displayName = "String"
	mailNickname = "String"
	description = "String"
	createdBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	classCode = "String"
	externalName = "String"
	externalId = "String"
	externalSource = "String"
	externalSourceDetail = "String"
	grade = "String"
	term = @{
		"@odata.type" = "microsoft.graph.educationTerm"
	}
}

New-MgBetaEducationClass -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

