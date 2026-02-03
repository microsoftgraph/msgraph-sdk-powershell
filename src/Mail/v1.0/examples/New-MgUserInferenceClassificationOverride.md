### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Mail

$params = @{
	classifyAs = "focused"
	senderEmailAddress = @{
		name = "Samantha Booth"
		address = "samanthab@adatum.onmicrosoft.com"
	}
}

# A UPN can also be used as -UserId.
New-MgUserInferenceClassificationOverride -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserInferenceClassificationOverride Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

