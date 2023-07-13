### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	RedundancyDetection = @{
		IsEnabled = $false
		SimilarityThreshold = 70
		MinWords = 12
		MaxWords = 400000
	}
	TopicModeling = @{
		IsEnabled = $false
		IgnoreNumbers = $false
		TopicCount = 50
		DynamicallyAdjustTopicCount = $false
	}
	Ocr = @{
		IsEnabled = $true
		MaxImageSize = 12000
	}
}
Update-MgBetaComplianceEdiscoveryCaseSetting -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaComplianceEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	RedundancyDetection = @{
		IsEnabled = $false
		SimilarityThreshold = 70
		MinWords = 12
		MaxWords = 400000
	}
	TopicModeling = @{
		IsEnabled = $false
		IgnoreNumbers = $false
		TopicCount = 50
		DynamicallyAdjustTopicCount = $false
	}
	Ocr = @{
		IsEnabled = $true
		MaxImageSize = 12000
	}
}
Update-MgBetaComplianceEdiscoveryCaseSetting -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
