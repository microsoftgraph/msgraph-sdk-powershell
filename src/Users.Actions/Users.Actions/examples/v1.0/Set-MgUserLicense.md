### Example 1: Assign a license to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'

Set-MgUserLicense -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b' -AddLicenses @{SkuId = $Win10Sku.SkuId} -RemoveLicenses @()

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com

```

This example assigns a license from the **Win10_VDA_E3** licensing plan to the unlicensed user **20084e64-44ba-4c8f-853a-aed51fa14c2b**. For more information, see [assign licenses to users accounts with PowerShell](/microsoft-365/enterprise/assign-licenses-to-user-accounts-with-microsoft-365-powershell?view=o365-worldwide).

### Example 2: Assign more than one licenses to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'
$FlowSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'FLOW_FREE'
$addLicenses = @(
  @{SkuId = $Win10Sku.SkuId},
  @{SkuId = $FlowSku.SkuId}
  )

Set-MgUserLicense -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com
```

This example assigns **Win10_VDA_E3** and **FLOW_FREE** licenses to the user **20084e64-44ba-4c8f-853a-aed51fa14c2b**.

### Example 3: Assign a license to a user with some disabled plans

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'
$disabledPlans = $Win10Sku.ServicePlans | where ServicePlanName -in ("POWERAUTOMATE_DESKTOP_FOR_WIN", "UNIVERSAL_PRINT_01") | Select -ExpandProperty ServicePlanId
$addLicenses = @(
  @{SkuId = $Win10Sku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgUserLicense -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com
```

This example assigns **Win10_VDA_E3** license with the **EXCHANGE_S_FOUNDATION** and **UNIVERSAL_PRINT_01** services turned off.

### Example 4: Update a license assigned to a user to add more disabled plans leaving the user's existing disabled plans in their current state

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'

$userDisabledPlans = $userLicense.ServicePlans |
  Where ProvisioningStatus -eq "Disabled" |
  Select -ExpandProperty ServicePlanId

$newDisabledPlans = $Win10Sku.ServicePlans |
  Where ServicePlanName -in ("DATAVERSE_FOR_POWERAUTOMATE_DESKTOP", "WINDOWSUPDATEFORBUSINESS_DEPLOYMENTSERVICE") |
  Select -ExpandProperty ServicePlanId

$disabledPlans = $userDisabledPlans + $newDisabledPlans | Select -Unique

$addLicenses = @(
  @{SkuId = $Win10Sku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgUserLicense -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com
```

This example updates the **Win10_VDA_E3** license assigned to the user to add **DATAVERSE_FOR_POWERAUTOMATE_DESKTOP** and **WINDOWSUPDATEFORBUSINESS_DEPLOYMENTSERVICE** to the disabled services.

### Example 5: Assign licenses to a user by copying the license assignment from another user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

Select-MgProfile -Name Beta
$mgUser = Get-MgUser -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b'

Set-MgUserLicense -UserId "edca13ae-23f0-4670-951d-857e9ebf2958" -AddLicenses $mgUser.AssignedLicenses -RemoveLicenses @()


Id                                   DisplayName Mail UserPrincipalName                   UserType
--                                   ----------- ---- -----------------                   --------
edca13ae-23f0-4670-951d-857e9ebf2958 Raul Razo        RaulR@M365x81760664.OnMicrosoft.com Member
```

This examples copies the license assignment of user **20084e64-44ba-4c8f-853a-aed51fa14c2b** and assigns it to user **edca13ae-23f0-4670-951d-857e9ebf2958**.

### Example 6: Remove a license assigned to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'

Set-MgUserLicense -UserId "20084e64-44ba-4c8f-853a-aed51fa14c2b" -AddLicenses @{} `-RemoveLicenses @($Win10Sku.SkuId)

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com Member
```

This example removes the **Win10_VDA_E3** license assignment from the user.