### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.filePlanReferenceTemplate"
	displayName = "FIN 01-02-001"
}

New-MgBetaSecurityLabelFilePlanReference -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityLabelFilePlanReference Cmdlet.

