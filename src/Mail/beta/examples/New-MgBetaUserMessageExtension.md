### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	"@odata.type" = "microsoft.graph.openTypeExtension"
	extensionName = "Com.Contoso.Referral"
	companyName = "Wingtip Toys"
	dealValue = 
	expirationDate = "2015-12-03T10:00:00.000Z"
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessageExtension -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageExtension Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

