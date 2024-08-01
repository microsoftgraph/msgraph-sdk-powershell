### Example 1: Create a Microsoft 365 group if it doesn't exist

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	description = "Self help community for golf"
	displayName = "Golf Assist"
	groupTypes = @(
	"Unified"
)
mailEnabled = $true
mailNickname = "golfassist"
securityEnabled = $false
}

Update-MgGroupByUniqueName -BodyParameter $params -UniqueName $uniqueNameId 

```
This example will create a microsoft 365 group if it doesn't exist

### Example 2: Create a security group with an owner and members if it doesn't exist

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	description = "Group with designated owner and members"
	displayName = "Operations group"
	groupTypes = @(
	)
	mailEnabled = $false
	mailNickname = "operations2019"
	securityEnabled = $true
	"owners@odata.bind" = @(
	"https://graph.microsoft.com/v1.0/users/26be1845-4119-4801-a799-aea79d09f1a2"
)
"members@odata.bind" = @(
"https://graph.microsoft.com/v1.0/users/ff7cb387-6688-423c-8188-3da9532a73cc"
"https://graph.microsoft.com/v1.0/users/69456242-0067-49d3-ba96-9de6f2728e14"
)
}

Update-MgGroupByUniqueName -BodyParameter $params -UniqueName $uniqueNameId 

```
This example will create a security group with an owner and members if it doesn't exist

