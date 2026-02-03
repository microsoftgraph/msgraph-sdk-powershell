### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	displayName = "Car Phone"
	number = "+7 499 342 22 13"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfilePhone -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfilePhone Cmdlet.

