### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	classifyAs = "focused"
	senderEmailAddress = @{
		name = "Samantha Booth"
		address = "samanthab@adatum.onmicrosoft.com"
	}
}

# A UPN can also be used as -UserId.
New-MgBetaUserInferenceClassificationOverride -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

