###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId -ExpandProperty "segments" 
```
###Example 2
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecordSession -CallRecordId $callRecordId
```
