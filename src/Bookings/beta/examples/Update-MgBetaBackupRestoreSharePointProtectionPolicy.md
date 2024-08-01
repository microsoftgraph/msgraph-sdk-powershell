### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	displayName = "SharePoint Policy - Inadvertent data loss"
	"siteProtectionUnits@delta" = @(
		@{
			siteId = "contoso.sharepoint.com,bf6fb551-d508-4946-a439-b2a6154fc1d9,65a04b8b-1f44-442b-a1fc-9e5852fb946c"
		}
		@{
			siteId = "contoso.sharepoint.com,d9ecf079-9b13-4376-ac5d-f242dda55626,746dbcc1-fa2b-4120-b657-2670bae5bb6f"
		}
		@{
			siteId = "contoso.sharepoint.com,fd1a778f-263e-4c43-acdf-d5c2519d80eb,c06016db-dfec-4f79-83a1-09c6dbfd7022"
		}
		@{
			siteId = "contoso.sharepoint.com,bf6fb551-d508-4946-a439-b2a6154fc1d9,65a04b8b-1f44-442b-a1fc-9e5852fb946c"
		}
		@{
			"@removed" = @{
				reason = "changed"
			}
			id = "99954f18-c8ec-4b62-85bf-cdf3b70b140e"
		}
		@{
			"@removed" = @{
				reason = "changed"
			}
			id = "4267e382-71a9-4c07-bef7-bda97e09c0d2"
		}
		@{
			"@removed" = @{
				reason = "changed"
			}
			id = "3667e382-71a9-4c07-bef7-bda97e09c0d2"
		}
	)
}

Update-MgBetaBackupRestoreSharePointProtectionPolicy -SharePointProtectionPolicyId $sharePointProtectionPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaBackupRestoreSharePointProtectionPolicy Cmdlet.

