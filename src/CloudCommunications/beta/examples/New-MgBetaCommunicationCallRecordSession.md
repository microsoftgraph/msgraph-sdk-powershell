### Example 1: Get session list

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecordSession -CallRecordId $callRecordId
```
This example shows how to use the New-MgBetaCommunicationCallRecordSession Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get session list with segments

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecordSession -CallRecordId $callRecordId -ExpandProperty "segments"
```
This example shows how to use the New-MgBetaCommunicationCallRecordSession Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

