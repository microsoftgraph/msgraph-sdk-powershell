### Example 1: Create an educationLinkResource

```powershell
Import-Module Microsoft.Graph.Beta.Education

$params = @{
	distributeForStudentWork = $false
	resource = @{
		displayName = "Where the Wonders of Learning Never Cease | Wonderopolis"
		link = "https://wonderopolis.org/"
		thumbnailPreviewUrl = $null
		"@odata.type" = "#microsoft.graph.educationLinkResource"
	}
}

New-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationClassAssignmentResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

