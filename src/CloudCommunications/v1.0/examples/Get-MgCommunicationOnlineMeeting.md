### Example 1: Retrieve an online meeting by videoTeleconferenceId

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationOnlineMeeting -Filter "VideoTeleconferenceId eq '123456789'" 

```
This example will retrieve an online meeting by videoteleconferenceid

