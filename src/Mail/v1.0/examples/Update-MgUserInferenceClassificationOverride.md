### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Mail

$params = @{
	classifyAs = "focused"
}

# A UPN can also be used as -UserId.
Update-MgUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId -BodyParameter $params
```
This example shows how to use the Update-MgUserInferenceClassificationOverride Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

