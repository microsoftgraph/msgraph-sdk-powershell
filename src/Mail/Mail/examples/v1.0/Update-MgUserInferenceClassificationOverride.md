###Example 1
```
Import-Module Microsoft.Graph.Mail
$params = @{
	ClassifyAs = "focused"
}
# A UPN can also be used as -UserId.
Update-MgUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId -BodyParameter $params
```
