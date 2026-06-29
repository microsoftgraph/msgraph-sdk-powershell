### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	workLocationType = "office"
	placeId = "eb706f15-137e-4722-b4d1-b601481d9251"
}

# A UPN can also be used as -UserId.
Set-MgUserPresenceManualLocation -UserId $userId -BodyParameter $params

```
This example shows how to use the Set-MgUserPresenceManualLocation Cmdlet.

