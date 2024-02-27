# Removes Microsoft Graph PowerShell (preview) Service Principal
# This will cause you to need to reconsent after doing Disconnect-Graph

$sp = Get-MgServicePrincipal -top 999 | ? { $_.AppId -like "3849bfaa-deab-480f-a8b1-39dc5bf58c35" }
Remove-MgServicePrincipal -ServicePrincipalId $sp.Id 