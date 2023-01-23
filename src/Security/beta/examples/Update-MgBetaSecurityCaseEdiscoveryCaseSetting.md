### Example 1: Using the Update-MgBetaSecurityCaseEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
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
Update-MgBetaSecurityCaseEdiscoveryCaseSetting -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
