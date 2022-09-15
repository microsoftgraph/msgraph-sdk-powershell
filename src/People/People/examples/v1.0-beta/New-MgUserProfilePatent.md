### Example 1: Using the New-MgUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Description = "Calculating the intent of a user to purchase an item based on the amount of time they hover their mouse over a given pixel."
	DisplayName = "Inferring User Intent through browsing behaviors"
	IsPending = $true
	Number = "USPTO-3954432633"
	WebUrl = "https://patents.gov/3954432633"
}
# A UPN can also be used as -UserId.
New-MgUserProfilePatent -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
