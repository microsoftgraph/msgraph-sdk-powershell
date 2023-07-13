### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	classifyAs = "focused"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

