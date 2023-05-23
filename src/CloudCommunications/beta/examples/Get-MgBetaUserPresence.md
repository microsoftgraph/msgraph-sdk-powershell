### Example 1: Get your own presence information

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserPresence -UserId $userId
```
This example shows how to use the Get-MgBetaBetaUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the presence information of another user

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaUserPresence -UserId $userId
```
This example shows how to use the Get-MgBetaBetaUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the presence information of another user

```powershellImport-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaCommunicationPresence -PresenceId $presenceId
```
This example shows how to use the Get-MgBetaBetaUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

