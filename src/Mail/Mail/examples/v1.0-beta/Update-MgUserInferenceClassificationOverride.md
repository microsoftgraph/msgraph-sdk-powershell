### Example 1: Using the Update-MgBetaUserInferenceClassificationOverride Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	ClassifyAs = "focused"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
