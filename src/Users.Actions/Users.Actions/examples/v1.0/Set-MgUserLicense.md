### Example 1: Assign a license to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'

Set-MgUserLicense -UserId '20084e64-44ba-4c8f-853a-aed51fa14c2b' -AddLicenses @{SkuId = $Win10Sku.SkuId} -RemoveLicenses @()

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com

```

This example assigns a license from the **Win10_VDA_E3** licensing plan to the unlicensed user **20084e64-44ba-4c8f-853a-aed51fa14c2b**.

### Example 2: Assign more than 1 licenses to a user

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
$disabledPlans = $Win10Sku.ServicePlans | where ServicePlanName -in ("EXCHANGE_S_FOUNDATION", "UNIVERSAL_PRINT_01") | Select -ExpandProperty ServicePlanId
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

### Example 4: Remove a license assigned to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$Win10Sku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'Win10_VDA_E3'

Set-MgUserLicense -UserId "20084e64-44ba-4c8f-853a-aed51fa14c2b" -AddLicenses @{} `-RemoveLicenses @($Win10Sku.SkuId)

Id                                   DisplayName    Mail UserPrincipalName                    UserType
--                                   -----------    ---- -----------------                    --------
20084e64-44ba-4c8f-853a-aed51fa14c2b Nomin Battulga      NominB@M365x81760664.onmicrosoft.com Member
```

This example removes the **Win10_VDA_E3** license assignment from the user.