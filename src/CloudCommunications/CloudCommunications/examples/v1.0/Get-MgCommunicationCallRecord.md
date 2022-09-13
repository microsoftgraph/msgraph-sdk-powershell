###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
###Example 2
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
###Example 3
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)" 
```
###Example 4
```
Import-Module Microsoft.Graph.CloudCommunications
Get-MgCommunicationCallRecord -CallRecordId $callRecordId
```
