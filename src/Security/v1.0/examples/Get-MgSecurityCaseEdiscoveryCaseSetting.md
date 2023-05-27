### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.ediscoveryCaseSettings"
	redundancyDetection = @{
		"@odata.type" = "microsoft.graph.security.redundancyDetectionSettings"
	}
	topicModeling = @{
		"@odata.type" = "microsoft.graph.security.topicModelingSettings"
	}
	ocr = @{
		"@odata.type" = "microsoft.graph.security.ocrSettings"
	}
}

Update-MgSecurityCaseEdiscoveryCaseSetting -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the Get-MgSecurityCaseEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

