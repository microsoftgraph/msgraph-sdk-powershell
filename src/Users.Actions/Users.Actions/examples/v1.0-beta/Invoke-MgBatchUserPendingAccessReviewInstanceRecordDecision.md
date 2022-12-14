### Example 1: Using the Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Decision = "Approve"
	Justification = "All principals with access need continued access to the resource (Marketing Group) as all the principals are on the marketing team"
	ResourceId = "a5c51e59-3fcd-4a37-87a1-835c0c21488a"
}
# A UPN can also be used as -UserId.
Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision -UserId $userId -AccessReviewInstanceId $accessReviewInstanceId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
