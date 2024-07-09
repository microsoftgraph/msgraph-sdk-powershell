### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	decision = "Approve"
	justification = "All principals with access need continued access to the resource (Marketing Group) as all the principals are on the marketing team"
	resourceId = "a5c51e59-3fcd-4a37-87a1-835c0c21488a"
}

# A UPN can also be used as -UserId.
Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision -UserId $userId -AccessReviewInstanceId $accessReviewInstanceId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision Cmdlet.

