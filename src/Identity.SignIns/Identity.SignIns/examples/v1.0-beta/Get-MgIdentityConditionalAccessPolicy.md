### Example 1: Get a list of all conditional access policies in Azure AD.

```powershell
Connect-MgGraph -Scopes 'Policy.Read.All'
Get-MgIdentityConditionalAccessPolicy |Format-List

Conditions           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessConditionSet
CreatedDateTime      : 1/13/2022 6:35:35 AM
Description          :
DisplayName          : Exchange Online Requires Compliant Device
GrantControls        : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessGrantControls
Id                   : 5e7615b8-dbe4-4cc1-810c-26adb77a3518
ModifiedDateTime     : 7/29/2022 9:08:10 AM
SessionControls      : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessSessionControls
State                : enabled
AdditionalProperties : {}

Conditions           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessConditionSet
CreatedDateTime      : 1/13/2022 6:35:39 AM
Description          :
DisplayName          : Office 365 App Control
GrantControls        : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessGrantControls
Id                   : 8783f4ea-215e-49f9-a4f6-cc21f6de45f6
ModifiedDateTime     : 7/29/2022 9:08:39 AM
SessionControls      : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessSessionControls
State                : enabled
AdditionalProperties : {}
```

This example retrieves all the conditional access policies in Azure AD.

### Example 2: Get a conditional access policy by Id

```powershell
Connect-MgGraph -Scopes 'Policy.Read.All'
Get-MgIdentityConditionalAccessPolicy -ConditionalAccessPolicyId '5e7615b8-dbe4-4cc1-810c-26adb77a3518' | 
  Format-List

Conditions           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessConditionSet
CreatedDateTime      : 1/13/2022 6:35:35 AM
Description          :
DisplayName          : Exchange Online Requires Compliant Device
GrantControls        : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessGrantControls
Id                   : 5e7615b8-dbe4-4cc1-810c-26adb77a3518
ModifiedDateTime     : 7/29/2022 9:08:10 AM
SessionControls      : Microsoft.Graph.PowerShell.Models.MicrosoftGraphConditionalAccessSessionControls
State                : enabled
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#identity/conditionalAccess/policies/$entity]}
```

This command retrieves the conditional access by Id.
