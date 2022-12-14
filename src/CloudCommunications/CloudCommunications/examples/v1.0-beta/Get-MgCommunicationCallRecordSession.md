### Example 1: Using the Get-MgBetaCommunicationCallRecordSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecordSession -CallRecordId $callRecordId -ExpandProperty "segments" 
```
This example shows how to use the Get-MgBetaCommunicationCallRecordSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaCommunicationCallRecordSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecordSession -CallRecordId $callRecordId
```
This example shows how to use the Get-MgBetaCommunicationCallRecordSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
