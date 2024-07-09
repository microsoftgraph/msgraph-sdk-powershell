### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Compliance

$params = @{
	content = @{
		content = "Please take a look at the files tagged with follow up"
		contentType = "text"
	}
}

New-MgPrivacySubjectRightsRequestNote -SubjectRightsRequestId $subjectRightsRequestId -BodyParameter $params

```
This example shows how to use the New-MgPrivacySubjectRightsRequestNote Cmdlet.

