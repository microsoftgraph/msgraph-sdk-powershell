### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	"@odata.type" = "#microsoft.graph.directoryObject"
}

New-MgBetaUserSponsorByRef -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserSponsorByRef Cmdlet.

