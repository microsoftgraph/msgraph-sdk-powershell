### Example 1: Add a custom registration question to a webinar registration

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.virtualEventRegistrationCustomQuestion"
	displayName = "What's your job position?"
	answerInputType = "multiChoice"
	answerChoices = @(
	"Software Engineer"
"Engineer Manager"
"Product Manager"
)
}

New-MgBetaVirtualEventWebinarRegistrationConfigurationQuestion -VirtualEventWebinarId $virtualEventWebinarId -BodyParameter $params

```
This example will add a custom registration question to a webinar registration

### Example 2: Add a predefined registration question to a webinar registration

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

New-MgBetaVirtualEventWebinarRegistrationConfigurationQuestion -VirtualEventWebinarId $virtualEventWebinarId

```
This example will add a predefined registration question to a webinar registration

