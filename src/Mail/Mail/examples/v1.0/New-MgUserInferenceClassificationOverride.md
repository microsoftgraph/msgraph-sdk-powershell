###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	ClassifyAs = "focused"
	SenderEmailAddress = @{
		Name = "Samantha Booth"
		Address = "samanthab@adatum.onmicrosoft.com"
	}
}
# A UPN can also be used as -UserId.
New-MgUserInferenceClassificationOverride -UserId $userId -BodyParameter $params
```
