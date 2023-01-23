### Example 1: Using the Update-MgBetaUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "organization"
}
Update-MgBetaUserProfileNote -UserId $userId -PersonAnnotationId $personAnnotationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
