### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	categories = @(
	"Sports"
)
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileInterest -UserId $userId -PersonInterestId $personInterestId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileInterest Cmdlet.

