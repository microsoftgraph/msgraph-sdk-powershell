### Example 1: Update properties of the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	businessPhones = @(
	"+1 425 555 0109"
)
officeLocation = "18/2111"
}

# A UPN can also be used as -UserId.
Update-MgBetaUser -UserId $userId -BodyParameter $params

```
This example will update properties of the signed-in user

### Example 2: Update properties of the specified user

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	businessPhones = @(
	"+1 425 555 0109"
)
officeLocation = "18/2111"
authorizationInfo = @{
	certificateUserIds = @(
	"5432109876543210@mil"
)
}
}

Update-MgBetaUser -UserId $userId -BodyParameter $params

```
This example will update properties of the specified user

### Example 3: Update the passwordProfile of a user and reset their password

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	passwordProfile = @{
		forceChangePasswordNextSignIn = $true
		password = "xWwvJ]6NMw+bWH-d"
	}
}

Update-MgBetaUser -UserId $userId -BodyParameter $params

```
This example will update the passwordprofile of a user and reset their password

### Example 4: Assign a custom security attribute with a string value to a user

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	customSecurityAttributes = @{
		Engineering = @{
			"@odata.type" = "#Microsoft.DirectoryServices.CustomSecurityAttributeValue"
			ProjectDate = "2022-10-01"
		}
	}
}

Update-MgBetaUser -UserId $userId -BodyParameter $params

```
This example will assign a custom security attribute with a string value to a user

### Example 5: Add or update the values of a schema extension for a user

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	ext55gb1l09_msLearnCourses = @{
		courseType = "Admin"
	}
}

Update-MgBetaUser -UserId $userId -BodyParameter $params

```
This example will add or update the values of a schema extension for a user

