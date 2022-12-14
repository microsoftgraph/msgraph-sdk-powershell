### Example 1: Using the Remove-MgBetaUserInferenceClassificationOverride Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
# A UPN can also be used as -UserId.
Remove-MgBetaUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId
```
This example shows how to use the Remove-MgBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
