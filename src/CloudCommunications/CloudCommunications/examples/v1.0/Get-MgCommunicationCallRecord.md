### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
