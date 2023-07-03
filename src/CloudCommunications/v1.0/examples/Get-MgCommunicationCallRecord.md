### Example 1: Get basic details

```powershellImport-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
This example shows how to use the Get-MgCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get full details

```powershellImport-Module Microsoft.Graph.CloudCommunications

Get-MgCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)"
```
This example shows how to use the Get-MgCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

