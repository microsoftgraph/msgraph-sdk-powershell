### Example 1: Using the Update-MgUserSettingShiftPreference Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Id = "SHPR_eeab4fb1-20e5-48ca-ad9b-98119d94bee7"
	"@odata.etag" = "1a371e53-f0a6-4327-a1ee-e3c56e4b38aa"
	Availability = @(
		@{
			Recurrence = @{
				Pattern = @{
					Type = "Weekly"
					DaysOfWeek = @(
						"Monday"
						"Wednesday"
						"Friday"
					)
					Interval = 1
				}
				Range = @{
					Type = "noEnd"
				}
			}
			TimeZone = "Pacific Standard Time"
			TimeSlots = $null
		}
	)
}
Update-MgUserSettingShiftPreference -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserSettingShiftPreference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
