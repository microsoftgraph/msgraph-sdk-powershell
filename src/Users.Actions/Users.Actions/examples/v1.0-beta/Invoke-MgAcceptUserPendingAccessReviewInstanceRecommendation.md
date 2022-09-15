### Example 1: Using the Invoke-MgAcceptUserPendingAccessReviewInstanceRecommendation Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgAcceptUserPendingAccessReviewInstanceRecommendation -UserId $userId -AccessReviewInstanceId $accessReviewInstanceId
```
This example shows how to use the Invoke-MgAcceptUserPendingAccessReviewInstanceRecommendation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
