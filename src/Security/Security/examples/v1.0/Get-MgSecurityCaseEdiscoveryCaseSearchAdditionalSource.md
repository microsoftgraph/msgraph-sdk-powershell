### Example 1
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Security
Get-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -OutFile $outFileId
```
