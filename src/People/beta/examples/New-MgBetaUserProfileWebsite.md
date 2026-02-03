### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	categories = @(
	"football"
)
displayName = "Lyn Damer"
webUrl = "www.lyndamer.no"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileWebsite -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileWebsite Cmdlet.

