### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

# A UPN can also be used as -UserId.
Get-MgBetaUserDefaultDrive -UserId $userId
```
This example shows how to use the Remove-MgBetaDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaUserDefaultDrive -UserId $userId
```
This example shows how to use the Remove-MgBetaDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaGroupDefaultDrive -GroupId $groupId
```
This example shows how to use the Remove-MgBetaDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteDefaultDrive -SiteId $siteId
```
This example shows how to use the Remove-MgBetaDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDrive -DriveId $driveId
```
This example shows how to use the Remove-MgBetaDrive Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

