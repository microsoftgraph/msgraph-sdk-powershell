### Example 1: Using the Update-MgUserOnlineMeetingRegistrationCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	AnswerInputType = "radioButton"
	AnswerOptions = @(
		"Software Engineer"
		"Software Development Manager"
		"Product Manager"
		"Data scientist"
		"Other"
	)
}
# A UPN can also be used as -UserId.
Update-MgUserOnlineMeetingRegistrationCustomQuestion -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingRegistrationQuestionId $meetingRegistrationQuestionId -BodyParameter $params
```
This example shows how to use the Update-MgUserOnlineMeetingRegistrationCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
