### Example 1: Add a case member of type **user** using **smtpAddress**

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	recipientType = "user"
	smtpAddress = "johnadams@microsoft.com"
}

New-MgBetaSecurityCaseEdiscoveryCaseMember -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will add a case member of type **user** using **smtpaddress**

### Example 2: Add a case member of type **roleGroup** using **displayName**

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	recipientType = "roleGroup"
	displayName = "Security Administrator"
}

New-MgBetaSecurityCaseEdiscoveryCaseMember -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will add a case member of type **rolegroup** using **displayname**

### Example 3: Add a case member of type **user** using **ID*

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	recipientType = "user"
	id = "c4af6f9d-37f6-43f9-9e17-601544234146"
}

New-MgBetaSecurityCaseEdiscoveryCaseMember -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will add a case member of type **user** using **id*

### Example 4: Add a case member of type **roleGroup** using **ID**

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	recipientType = "roleGroup"
	id = "b9fb4f22-5f90-47a0-b309-44fe96a959fd"
}

New-MgBetaSecurityCaseEdiscoveryCaseMember -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will add a case member of type **rolegroup** using **id**

