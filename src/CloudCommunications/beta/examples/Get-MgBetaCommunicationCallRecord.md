### Example 1: Get basic details

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId

```
This example will get basic details

### Example 2: Get session and segment details

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)" 

```
This example will get session and segment details

### Example 3: Get participant details

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "participants_v2" 

```
This example will get participant details

