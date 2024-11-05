### Example 1: Creating registration record with delegated permission

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	externalRegistrationInformation = @{
		referrer = "Facebook"
		registrationId = "myExternalRegistrationId"
	}
	preferredTimezone = "Pacific Standard Time"
	preferredLanguage = "en-us"
	registrationQuestionAnswers = @(
		@{
			questionId = "95320781-96b3-4b8f-8cf8-e6561d23447a"
			value = $null
			booleanValue = $null
			multiChoiceValues = @(
			"Seattle"
		)
	}
	@{
		questionId = "4577afdb-8bee-4219-b482-04b52c6b855c"
		value = $null
		booleanValue = $true
		multiChoiceValues = @(
		)
	}
	@{
		questionId = "80fefcf1-caf7-4cd3-b8d7-159e17c47f20"
		value = $null
		booleanValue = $null
		multiChoiceValues = @(
		"Cancun"
	"Hoboken"
"Beijing"
)
}
)
}

New-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId $virtualEventWebinarId -BodyParameter $params

```
This example shows creating registration record with delegated permission

### Example 2: Creating registration record with application permission

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	firstName = "Diane"
	lastName = "Demoss"
	email = "DianeDemoss@contoso.com"
	externalRegistrationInformation = @{
		referrer = "Facebook"
		registrationId = "myExternalRegistrationId"
	}
	preferredTimezone = "Pacific Standard Time"
	preferredLanguage = "en-us"
	registrationQuestionAnswers = @(
		@{
			questionId = "95320781-96b3-4b8f-8cf8-e6561d23447a"
			value = $null
			booleanValue = $null
			multiChoiceValues = @(
			"Seattle"
		)
	}
	@{
		questionId = "4577afdb-8bee-4219-b482-04b52c6b855c"
		value = $null
		booleanValue = $true
		multiChoiceValues = @(
		)
	}
	@{
		questionId = "80fefcf1-caf7-4cd3-b8d7-159e17c47f20"
		value = $null
		booleanValue = $null
		multiChoiceValues = @(
		"London"
	"New York City"
)
}
)
}

New-MgBetaVirtualEventWebinarRegistration -VirtualEventWebinarId $virtualEventWebinarId -BodyParameter $params

```
This example shows creating registration record with application permission

