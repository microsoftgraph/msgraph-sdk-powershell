### Example 1: Using the Initialize-MgUserServicePlan Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	ServicePlanId = "28f42d6f-8034-4a0f-9d8a-a218a63b3299"
	SkuId = "465a2a90-5e59-456d-a7b8-127b9fb2e484"
}
# A UPN can also be used as -UserId.
Initialize-MgUserServicePlan -UserId $userId -BodyParameter $params
```
This example shows how to use the Initialize-MgUserServicePlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
