### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation -UserId $userId -AccessReviewInstanceId $accessReviewInstanceId

```
This example shows how to use the Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation Cmdlet.

