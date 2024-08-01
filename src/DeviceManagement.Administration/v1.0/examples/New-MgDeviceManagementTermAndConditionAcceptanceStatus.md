### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.termsAndConditionsAcceptanceStatus"
	userDisplayName = "User Display Name value"
	acceptedVersion = 15
	acceptedDateTime = [System.DateTime]::Parse("2016-12-31T23:57:43.6165506-08:00")
	userPrincipalName = "User Principal Name value"
}

New-MgDeviceManagementTermAndConditionAcceptanceStatus -TermsAndConditionsId $termsAndConditionsId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementTermAndConditionAcceptanceStatus Cmdlet.

