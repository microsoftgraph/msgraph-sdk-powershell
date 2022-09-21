### Example 1: Using the Update-MgUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	AllowedAudiences = "organization"
}
Update-MgUserProfileNote -UserId $userId -PersonAnnotationId $personAnnotationId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
