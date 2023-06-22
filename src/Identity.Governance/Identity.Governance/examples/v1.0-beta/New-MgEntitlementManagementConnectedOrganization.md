### Example 1: Using the New-MgEntitlementManagementConnectedOrganization Cmdlet

```powershell
$params = @{
    displayName = "Connected organization name"
    description = "Connected organization description"
    identitySources = @(
        @{
            "@odata.type" = "#microsoft.graph.domainIdentitySource"
            domainName = "example.com"
            displayName = "example.com"
        }
    )
    state = "proposed"
}

New-MgEntitlementManagementConnectedOrganization -BodyParameter $params
```

This example shows how to use the New-MgEntitlementManagementConnectedOrganization Cmdlet with the BodyParameter.

### Example 2: Add a connected organization using the DomainName parameter in the 'Proposed' state

```powershell
New-MgEntitlementManagementConnectedOrganization -DomainName microsoft.com -DisplayName "Microsoft" -State proposed
```

This example shows how to add a connected organization in the 'Proposed' state using the -DomainName and -State parameters.

### Example 3: Add a connected organization using the DomainName parameter in the 'Configured' state

```powershell
New-MgEntitlementManagementConnectedOrganization -DomainName microsoft.com -DisplayName "Microsoft" -State configured
```

This example shows how to add a connected organization in the 'Configured' state using the -DomainName and -State parameters.

### Example 4: Add a connected organization with multiple domains using the IdentitySources parameter

```powershell
$identitySources = @(
    @{
        '@odata.type' = '#microsoft.graph.domainIdentitySource';
        domainName = "example1.com";
    },
    @{
        '@odata.type' = '#microsoft.graph.domainIdentitySource';
        domainName = "example2.com";
    }
)

New-MgEntitlementManagementConnectedOrganization -DisplayName "Example" -IdentitySources $identitySources -State configured
```

This example shows how to use the -IdentitySources parameter to add a connected organization with multiple domains.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
