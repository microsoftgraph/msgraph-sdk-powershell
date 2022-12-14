### Example 1: Using the Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation -UserId $userId -AccessReviewInstanceId $accessReviewInstanceId
```
This example shows how to use the Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
