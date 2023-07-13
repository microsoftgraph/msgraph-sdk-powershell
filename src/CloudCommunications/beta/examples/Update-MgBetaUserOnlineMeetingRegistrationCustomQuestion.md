### Example 1: Using the Update-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
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
Update-MgBetaUserOnlineMeetingRegistrationCustomQuestion -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingRegistrationQuestionId $meetingRegistrationQuestionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
