# Tenant Information

## Organization Contact Details
Get-Organization | Select-Object DisplayName, City, State, Country, PostalCode, BusinessPhones

## Organization Assigned Plans
Get-Organization | Select-Object -expand AssignedPlans

## List application registrations in the tenant
Get-Application | Select-Object DisplayName, Appid, WebRedirectUris

## List service principals in the tenant
get-serviceprincipal | Select-Object id, AppDisplayName | Where-Object { $_.AppDisplayName -like "*powershell*" }

## Create a new Application Registration
New-Application -displayName "MyTestApp7"
