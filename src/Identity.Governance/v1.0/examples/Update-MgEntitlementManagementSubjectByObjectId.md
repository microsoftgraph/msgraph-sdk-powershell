### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	subjectLifecycle = "governed"
}

Update-MgEntitlementManagementSubjectByObjectId -BodyParameter $params -ObjectId $objectIdId 

```
This example shows how to use the Update-MgEntitlementManagementSubjectByObjectId Cmdlet.

