### Example 1: Using the Get-MgBetaUserInformationProtectionPolicyLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserInformationProtectionPolicyLabel -UserId $userId -InformationProtectionLabelId $informationProtectionLabelId
```
This example shows how to use the Get-MgBetaUserInformationProtectionPolicyLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserInformationProtectionPolicyLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserInformationProtectionPolicyLabel -UserId $userId
```
This example shows how to use the Get-MgBetaUserInformationProtectionPolicyLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
