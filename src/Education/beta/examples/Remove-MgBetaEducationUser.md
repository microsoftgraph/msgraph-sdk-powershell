### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Rogelio Cazares"
	givenName = "Rogelio"
	middleName = "Fernando"
	surname = "Cazares"
}

Update-MgBetaEducationUser -EducationUserId $educationUserId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaBetaEducationUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

