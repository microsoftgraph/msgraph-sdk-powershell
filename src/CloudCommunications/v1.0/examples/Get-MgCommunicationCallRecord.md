### Example 1: Get basic details

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecord -CallRecordId $callRecordId

```
This example will get basic details

### Example 2: Get full details

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)" 

```
This example will get full details

