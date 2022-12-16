### Example 1: Get a user's license details

```powershell
Get-MgUserLicenseDetail -UserId '0ec3a5e8-b4b6-4678-90ff-ce786055065f' | Format-List

Id                   : BF5i-6pS2kKxDRTxGV1mX6sU3Mts2TBMufRq2nzcHUY
ServicePlans         : {WINDOWSUPDATEFORBUSINESS_DEPLOYMENTSERVICE, UNIVERSAL_PRINT_01, M365_LIGHTHOUSE_CUSTOMER_PLAN1, POWER_VIRTUAL_AGENTS_O365_P3...}
SkuId                : ae5a2394-6002-4128-80c0-d27fe0d823a3
SkuPartNumber        : SPB
AdditionalProperties : {}
```

This example retrieves the license details for the specified user.