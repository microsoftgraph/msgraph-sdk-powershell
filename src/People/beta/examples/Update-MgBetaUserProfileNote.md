### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	allowedAudiences = "organization"
}

Update-MgBetaUserProfileNote -UserId $userId -PersonAnnotationId $personAnnotationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileNote Cmdlet.

