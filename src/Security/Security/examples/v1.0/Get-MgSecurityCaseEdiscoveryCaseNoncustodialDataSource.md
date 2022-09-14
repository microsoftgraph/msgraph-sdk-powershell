### Example 1
``` powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource"  -OutFile $outFileId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryNoncustodialDataSourceId $ediscoveryNoncustodialDataSourceId -ExpandProperty "dataSource" 
```
