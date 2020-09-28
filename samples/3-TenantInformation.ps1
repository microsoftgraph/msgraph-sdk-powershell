# Tenant Information

## Organization Contact Details
Get-MgOrganization | Select-Object DisplayName, City, State, Country, PostalCode, BusinessPhones

## Organization Assigned Plans
Get-MgOrganization | Select-Object -expand AssignedPlans

## List application registrations in the tenant
Get-MgApplication | Select-Object DisplayName, Appid, SignInAudience

## List service principals in the tenant
Get-MgServicePrincipal | Select-Object id, AppDisplayName | Where-Object { $_.AppDisplayName -like "*powershell*" }

