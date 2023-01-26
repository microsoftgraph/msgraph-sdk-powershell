### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaGroupDrive -GroupId $groupId
```
This example shows how to use the New-MgBetaUserDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteDrive -SiteId $siteId
```
This example shows how to use the New-MgBetaUserDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaUserDrive -UserId $userId
```
This example shows how to use the New-MgBetaUserDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

# A UPN can also be used as -UserId.
Get-MgBetaUserDrive -UserId $userId
```
This example shows how to use the New-MgBetaUserDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

