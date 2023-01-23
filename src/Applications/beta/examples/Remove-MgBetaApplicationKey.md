### Example 1: Using the Remove-MgBetaApplicationKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	KeyId = "f0b0b335-1d71-4883-8f98-567911bfdca6"
	Proof = "eyJ0eXAiOiJ..."
}
Remove-MgBetaApplicationKey -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaApplicationKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
