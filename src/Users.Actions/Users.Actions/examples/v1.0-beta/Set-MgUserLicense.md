### Example 1: Assign a license to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$EmsSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'

Set-MgUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses @{SkuId = $EmsSku.SkuId} -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member
```

This example assigns a license from the **EMSPREMIUM** (ENTERPRISE MOBILITY + SECURITY E5) licensing plan to the unlicensed user **38955658-c844-4f59-9430-6519430ac89b**. For more information, see [assign licenses to users accounts with PowerShell](/microsoft-365/enterprise/assign-licenses-to-user-accounts-with-microsoft-365-powershell?view=o365-worldwide).

### Example 2: Assign more than one licenses to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$EmsSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$FlowSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'FLOW_FREE'
$addLicenses = @(
  @{SkuId = $EmsSku.SkuId},
  @{SkuId = $FlowSku.SkuId}
  )

Set-MgUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member
```

This example assigns **EMSPREMIUM** and **FLOW_FREE** licenses to the user **38955658-c844-4f59-9430-6519430ac89b**.

### Example 3: Assign a license to a user with some disabled plans

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$EmsSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$disabledPlans = $EmsSku.ServicePlans | where ServicePlanName -in ("MFA_PREMIUM", "INTUNE_A") | Select -ExpandProperty ServicePlanId
$addLicenses = @(
  @{SkuId = $EmsSku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member
```

This example assigns **EMSPREMIUM** license with the **MFA_PREMIUM** and **INTUNE_A** services turned off.

### Example 4: Update a license assigned to a user to add more disabled plans leaving the user's existing disabled plans in their current state

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$EmsSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$userLicense = Get-MgUserLicenseDetail -UserId "38955658-c844-4f59-9430-6519430ac89b"

$userDisabledPlans = $userLicense.ServicePlans |
  Where ProvisioningStatus -eq "Disabled" |
  Select -ExpandProperty ServicePlanId

$newDisabledPlans = $EmsSku.ServicePlans |
  Where ServicePlanName -in ("AAD_PREMIUM_P2", "AAD_PREMIUM") |
  Select -ExpandProperty ServicePlanId

$disabledPlans = $userDisabledPlans + $newDisabledPlans | Select -Unique

$addLicenses = @(
  @{SkuId = $EmsSku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member
```

This example updates the **EMSPREMIUM** license assigned to the user to add **AAD_PREMIUM_P2** and **AAD_PREMIUM** to the disabled services.

### Example 5: Assign licenses to a user by copying the license assignment from another user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

Select-MgProfile -Name Beta
$mgUser = Get-MgUser -UserId '38955658-c844-4f59-9430-6519430ac89b'

Set-MgUserLicense -UserId "82f51c98-7221-442f-8329-3faf9fe022f1" -AddLicenses $mgUser.AssignedLicenses -RemoveLicenses @()


Id                                   DisplayName    Mail UserPrincipalName                      UserType
--                                   -----------    ---- -----------------                      --------
82f51c98-7221-442f-8329-3faf9fe022f1 Mallory Cortez      MalloryC@contoso.onmicrosoft.com       Member
```

This examples copies the license assignment of user **38955658-c844-4f59-9430-6519430ac89b** and assigns it to user **82f51c98-7221-442f-8329-3faf9fe022f1**.

### Example 6: Remove a license assigned to a user

```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All

$EmsSku = Get-MgSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'

Set-MgUserLicense -UserId "38955658-c844-4f59-9430-6519430ac89b" -AddLicenses @{} `-RemoveLicenses @($EmsSku.SkuId)

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member
```

This example removes the **EMSPREMIUM** license assignment from the user.
