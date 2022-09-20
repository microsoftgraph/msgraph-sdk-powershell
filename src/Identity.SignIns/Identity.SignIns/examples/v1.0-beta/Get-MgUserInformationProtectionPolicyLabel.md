### Example 1: Using the Get-MgUserInformationProtectionPolicyLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserInformationProtectionPolicyLabel -UserId $userId -InformationProtectionLabelId $informationProtectionLabelId
```
This example shows how to use the Get-MgUserInformationProtectionPolicyLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserInformationProtectionPolicyLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserInformationProtectionPolicyLabel -UserId $userId
```
This example shows how to use the Get-MgUserInformationProtectionPolicyLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
