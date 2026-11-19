### Example 1: Retrieve child tags of a specific eDiscovery review tag

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTag -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewTagId $ediscoveryReviewTagId

```
This example will retrieve child tags of a specific ediscovery review tag

