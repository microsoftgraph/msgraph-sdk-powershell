### Example 1: Using the New-MgComplianceEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "My Case 1"
}
New-MgComplianceEdiscoveryCase -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
