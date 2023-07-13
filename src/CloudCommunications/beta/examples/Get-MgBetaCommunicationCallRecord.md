### Example 1: Get basic details

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId
```
This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get full details

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)"
```
This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

