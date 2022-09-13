###Example 1
```
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource" 
```
###Example 2
```
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource"  -OutFile $outFileId
```
###Example 3
```
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryNoncustodialDataSourceId $ediscoveryNoncustodialDataSourceId -ExpandProperty "dataSource" 
```
