### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	description = "Calculating the intent of a user to purchase an item based on the amount of time they hover their mouse over a given pixel."
	displayName = "Inferring User Intent through browsing behaviors"
	isPending = $true
	number = "USPTO-3954432633"
	webUrl = "https://patents.gov/3954432633"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfilePatent -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfilePatent Cmdlet.

