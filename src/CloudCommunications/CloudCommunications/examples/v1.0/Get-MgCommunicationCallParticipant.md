### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallParticipant -CallId $callId -ParticipantId $participantId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallParticipant -CallId $callId
```
