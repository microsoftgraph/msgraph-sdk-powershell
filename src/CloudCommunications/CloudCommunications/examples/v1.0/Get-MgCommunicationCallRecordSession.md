### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId -ExpandProperty "segments" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId
```
