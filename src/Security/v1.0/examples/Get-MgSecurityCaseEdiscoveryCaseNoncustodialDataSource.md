### Example 1: Using the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource" 
```
This example shows how to use the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -ExpandProperty "dataSource"  -OutFile $outFileId
```
This example shows how to use the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryNoncustodialDataSourceId $ediscoveryNoncustodialDataSourceId -ExpandProperty "dataSource" 
```
This example shows how to use the Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
