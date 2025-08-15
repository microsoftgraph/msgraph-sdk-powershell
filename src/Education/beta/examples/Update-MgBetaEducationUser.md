### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	relatedContacts = @(
		@{
			displayName = "Father Time"
			emailAddress = "father@time.com"
			mobilePhone = "4251231234"
			relationship = "guardian"
			accessConsent = $true
		}
		@{
			displayName = "Mother Nature"
			emailAddress = "mother@nature.co.uk"
			mobilePhone = "3251231234"
			relationship = "parent"
			accessConsent = $true
		}
	)
}

Update-MgBetaEducationUser -EducationUserId $educationUserId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationUser Cmdlet.

