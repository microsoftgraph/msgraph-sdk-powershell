### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	nickname = "Kesha"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileName -UserId $userId -PersonNameId $personNameId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileName Cmdlet.

