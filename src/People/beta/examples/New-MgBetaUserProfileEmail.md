### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	address = "Innocenty.Popov@adventureworks.com"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileEmail -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileEmail Cmdlet.

