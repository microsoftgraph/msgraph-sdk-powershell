### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users

$params = @{
	"@odata.type" = "#microsoft.graph.directoryObject"
}

New-MgUserSponsorByRef -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgUserSponsorByRef Cmdlet.

