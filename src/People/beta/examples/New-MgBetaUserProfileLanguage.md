### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	displayName = "Norwegian Bokmål"
	tag = "nb-NO"
	spoken = "nativeOrBilingual"
	written = "nativeOrBilingual"
	reading = "nativeOrBilingual"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileLanguage -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileLanguage Cmdlet.

