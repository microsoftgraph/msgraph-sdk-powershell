# Replace with your ClientId
# Replace with your TenantId
# Replace with your Cert subject
Connect-Graph -ClientId "1e4ee20b-9a64-44cb-bb6f-0d693e76490a" `
              -TenantId "d5fe491b-5987-4770-a68f-477c204cd1ca" `
              -CertificateName "CN=GraphPowerShellScriptCert"    
$groups = Get-MgGroup
$teams = $groups | Where-Object { $_.ResourceProvisioningOptions -Contains "Team" }

foreach($team in $teams) {
    Write-Host "Team: " + $team.DisplayName -ForegroundColor Blue

    Write-Host "Owners: " -ForegroundColor Yellow
    $owners = Get-MgGroupOwner -GroupId $team.Id 
    foreach($owner in $owners) {
        $o = Get-MgUser -UserId $owner.Id 
        Write-Host $o.DisplayName -ForegroundColor Yellow
    }

    Write-Host "Members: " -ForegroundColor Green
    $members = Get-MgGroupMember -GroupId $team.Id
    foreach($member in $members) {
        $u = Get-MgUser -UserId $member.Id 
        Write-Host $u.DisplayName -ForegroundColor Green
    }
}
