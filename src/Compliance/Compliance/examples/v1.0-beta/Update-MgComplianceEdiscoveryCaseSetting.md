### Example 1: Using the Update-MgComplianceEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
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
Update-MgComplianceEdiscoveryCaseSetting -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgComplianceEdiscoveryCaseSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
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
Update-MgComplianceEdiscoveryCaseSetting -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
