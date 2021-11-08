### Example 1: Get the resource role scope for a specified catalog and access package resource

```powershell
Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceScope -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -Filter "originSystem eq 'AadGroup' and accessPackageResource/id eq '36d8d18f-b081-4867-acf5-4a8b893761e8'"

Id                                   Description DisplayName IsRootScope OriginId                             OriginSystem RoleOriginId Url
--                                   ----------- ----------- ----------- --------                             ------------ ------------ ---
2386db28-94fc-45ce-b4bd-56188da884fe Root Scope  Root        True        b5cd9d19-91c0-4622-93e2-537ad8a0b3ad AadGroup

```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

