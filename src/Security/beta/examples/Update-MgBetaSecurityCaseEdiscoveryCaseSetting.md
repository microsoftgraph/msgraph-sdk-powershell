### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/settings/$entity"
	redundancyDetection = @{
		isEnabled = $true
		similarityThreshold = 65
		minWords = 10
		maxWords = 500000
	}
	topicModeling = @{
		isEnabled = $false
		ignoreNumbers = $true
		topicCount = 100
		dynamicallyAdjustTopicCount = $true
	}
	ocr = @{
		isEnabled = $false
		maxImageSize = 24576
		timeout = "PT1M"
	}
	caseType = "standard"
	reviewSetSettings = "disableGrouping"
}

Update-MgBetaSecurityCaseEdiscoveryCaseSetting -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCaseSetting Cmdlet.

