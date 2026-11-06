### Example 2: Get access package suggestions based on assignment history

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterEntitlementManagementAccessPackageSuggestionByCurrentUser -ExpandProperty "accessPackage"  -On $onId 

```
This example will get access package suggestions based on assignment history

