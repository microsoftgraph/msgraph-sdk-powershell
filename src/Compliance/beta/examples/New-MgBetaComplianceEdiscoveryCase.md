### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "My Case 1"
}

New-MgBetaComplianceEdiscoveryCase -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCase Cmdlet.

