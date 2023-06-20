### Example 1: Add a connected organization using the DomainName parameter
```powershell
New-MgBetaEntitlementManagementConnectedOrganization -DomainName microsoft.com
```

### Example 2: Add a connected organization using the IdentitySources parameter
```powershell
$identitySources = @(
    @{
        '@odata.type' = '#microsoft.graph.domainIdentitySource';
        domainName = "microsoft.com";
    }
)

New-MgEntitlementManagementConnectedOrganization -IdentitySources $identitySources
```
This example shows how to use the New-MgEntitlementManagementConnectedOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
