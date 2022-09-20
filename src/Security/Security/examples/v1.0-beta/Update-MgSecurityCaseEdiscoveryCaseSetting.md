### Example 1: Using the Update-MgSecurityCaseEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	"@odata.type" = "#microsoft.graph.security.ediscoveryCaseSettings"
	RedundancyDetection = @{
		"@odata.type" = "microsoft.graph.security.redundancyDetectionSettings"
	}
	TopicModeling = @{
		"@odata.type" = "microsoft.graph.security.topicModelingSettings"
	}
	Ocr = @{
		"@odata.type" = "microsoft.graph.security.ocrSettings"
	}
}
Update-MgSecurityCaseEdiscoveryCaseSetting -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
