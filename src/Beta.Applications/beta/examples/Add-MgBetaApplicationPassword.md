### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	passwordCredential = @{
		displayName = "Password friendly name"
	}
}

Add-MgBetaApplicationPassword -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the Add-MgBetaApplicationPassword Cmdlet.

