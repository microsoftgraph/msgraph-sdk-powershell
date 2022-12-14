### Example 1: Using the New-MgBetaUserInferenceClassificationOverride Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	ClassifyAs = "focused"
	SenderEmailAddress = @{
		Name = "Samantha Booth"
		Address = "samanthab@adatum.onmicrosoft.com"
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserInferenceClassificationOverride -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
