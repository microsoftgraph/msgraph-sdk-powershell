### Example 1: Using the New-MgBetaUserMessageExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	"@odata.type" = "microsoft.graph.openTypeExtension"
	ExtensionName = "Com.Contoso.Referral"
	CompanyName = "Wingtip Toys"
	DealValue = 
	ExpirationDate = "2015-12-03T10:00:00.000Z"
}
# A UPN can also be used as -UserId.
New-MgBetaUserMessageExtension -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
