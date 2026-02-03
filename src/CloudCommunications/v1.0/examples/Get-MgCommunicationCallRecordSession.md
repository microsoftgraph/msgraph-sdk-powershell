### Example 1: Get session list

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId

```
This example will get session list

### Example 2: Get session list with segments

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId -ExpandProperty "segments" 

```
This example will get session list with segments

