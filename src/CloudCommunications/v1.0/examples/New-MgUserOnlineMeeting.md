### Example 1: Create an online meeting with user token

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	startDateTime = [System.DateTime]::Parse("2019-07-12T14:30:34.2444915-07:00")
	endDateTime = [System.DateTime]::Parse("2019-07-12T15:00:34.2464912-07:00")
	subject = "User Token Meeting"
}

# A UPN can also be used as -UserId.
New-MgUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example will create an online meeting with user token

### Example 2: Create an online meeting that requires a passcode

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	startDateTime = [System.DateTime]::Parse("2019-07-12T14:30:34.2444915-07:00")
	endDateTime = [System.DateTime]::Parse("2019-07-12T15:00:34.2464912-07:00")
	subject = "User meeting"
	joinMeetingIdSettings = @{
		isPasscodeRequired = $true
	}
}

# A UPN can also be used as -UserId.
New-MgUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example will create an online meeting that requires a passcode

### Example 3: Create an online meeting that doesn't require a passcode

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	startDateTime = [System.DateTime]::Parse("2019-07-12T14:30:34.2444915-07:00")
	endDateTime = [System.DateTime]::Parse("2019-07-12T15:00:34.2464912-07:00")
	subject = "User meeting in Microsoft Teams channel."
	joinMeetingIdSettings = @{
		isPasscodeRequired = $false
	}
}

# A UPN can also be used as -UserId.
New-MgUserOnlineMeeting -UserId $userId -BodyParameter $params

```
This example will create an online meeting that doesn't require a passcode

