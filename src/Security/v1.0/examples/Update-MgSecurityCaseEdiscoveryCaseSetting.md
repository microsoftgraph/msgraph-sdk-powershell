### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "https://graph.microsoft.com/v1.0/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/settings/$entity"
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

Update-MgSecurityCaseEdiscoveryCaseSetting -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCaseSetting Cmdlet.

