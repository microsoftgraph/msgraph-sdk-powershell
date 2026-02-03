### Example 1: Create a new application if it doesn't exist

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	displayName = "Display name"
}

Update-MgApplicationByUniqueName -BodyParameter $params

```
This example will create a new application if it doesn't exist

### Example 2: Update an existing application

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	displayName = "Display name"
}

Update-MgApplicationByUniqueName -BodyParameter $params

```
This example will update an existing application

