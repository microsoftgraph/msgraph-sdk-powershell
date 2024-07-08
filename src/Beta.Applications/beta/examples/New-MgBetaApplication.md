### Example 1: Create an application with the default settings

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	displayName = "Display name"
}

New-MgBetaApplication -BodyParameter $params

```
This example will create an application with the default settings

### Example 2: Create a new application and add a password secret

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	displayName = "MyAppName"
	passwordCredentials = @(
		@{
			displayName = "Password name"
		}
	)
}

New-MgBetaApplication -BodyParameter $params

```
This example will create a new application and add a password secret

