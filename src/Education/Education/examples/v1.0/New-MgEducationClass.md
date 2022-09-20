### Example 1: Using the New-MgEducationClass Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationClass"
	DisplayName = "String"
	MailNickname = "String"
	Description = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	ClassCode = "String"
	ExternalName = "String"
	ExternalId = "String"
	ExternalSource = "String"
	ExternalSourceDetail = "String"
	Grade = "String"
	Term = @{
		"@odata.type" = "microsoft.graph.educationTerm"
	}
}
New-MgEducationClass -BodyParameter $params
```
This example shows how to use the New-MgEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
