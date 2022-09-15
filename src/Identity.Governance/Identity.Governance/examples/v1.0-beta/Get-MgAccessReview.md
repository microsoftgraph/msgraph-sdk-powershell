### Example 1: Using the Get-MgAccessReview Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgAccessReview -AccessReviewId $accessReviewId
```
This example shows how to use the Get-MgAccessReview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgAccessReview Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgAccessReview -Filter "businessFlowTemplateId eq '6e4f3d20-c5c3-407f-9695-8460952bcc68'" -Top 100 -Skip 0 
```
This example shows how to use the Get-MgAccessReview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
