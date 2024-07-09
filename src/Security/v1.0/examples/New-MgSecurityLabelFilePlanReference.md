### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.filePlanReferenceTemplate"
	displayName = "FIN 01-02-001"
}

New-MgSecurityLabelFilePlanReference -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelFilePlanReference Cmdlet.

