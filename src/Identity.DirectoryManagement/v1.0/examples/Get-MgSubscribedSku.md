### Example 1: Get subscribed SKUs

```powershell
Get-MgSubscribedSKU | Format-List

AppliesTo            : User
CapabilityStatus     : Enabled
ConsumedUnits        : 23
Id                   : fb625e04-52aa-42da-b10d-14f1195d665f_cbdc14ab-d96c-4c30-b9f4-6ada7cdc1d46
PrepaidUnits         : Microsoft.Graph.PowerShell.Models.MicrosoftGraphLicenseUnitsDetail
ServicePlans         : {M365_LIGHTHOUSE_PARTNER_PLAN1, WINDOWSUPDATEFORBUSINESS_DEPLOYMENTSERVICE, UNIVERSAL_PRINT_01,
                       M365_LIGHTHOUSE_CUSTOMER_PLAN1...}
SkuId                : cbdc14ab-d96c-4c30-b9f4-6ada7cdc1d46
SkuPartNumber        : SPB
AdditionalProperties : {[@odata.id, https://graph.microsoft.com/v2/fb625e04-52aa-42da-b10d-14f1195d665f/subscribedSkus/fb625e04-52a
                       a-42da-b10d-14f1195d665f_cbdc14ab-d96c-4c30-b9f4-6ada7cdc1d46]}
```

This command gets the information about the service SKU that the company has subscribed to.
