# Removes Microsoft Graph PowerShell (preview) Service Principal
# This will cause you to need to reconsent after doing Disconnect-Graph

$sp = Get-ServicePrincipal -top 999 | ? { $_.AppId -like "14d82eec-204b-4c2f-b7e8-296a70dab67e" }
Remove-ServicePrincipal -ServicePrincipalId $sp.Id 