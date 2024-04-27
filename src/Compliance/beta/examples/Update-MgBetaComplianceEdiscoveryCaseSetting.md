### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	redundancyDetection = @{
		isEnabled = $false
		similarityThreshold = 70
		minWords = 12
		maxWords = 400000
	}
	topicModeling = @{
		isEnabled = $false
		ignoreNumbers = $false
		topicCount = 50
		dynamicallyAdjustTopicCount = $false
	}
	ocr = @{
		isEnabled = $true
		maxImageSize = 12000
	}
}

Update-MgBetaComplianceEdiscoveryCaseSetting -CaseId $caseId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseSetting Cmdlet.

