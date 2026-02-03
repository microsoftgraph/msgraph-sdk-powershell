### Example 1: Get a callTranscript content

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId

```
This example will get a calltranscript content

### Example 2: Get a callTranscript content specifying $format query param

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId -Format "text/vtt" 

```
This example will get a calltranscript content specifying $format query param

