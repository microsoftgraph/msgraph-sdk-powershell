# Replace with your ClientId
# Replace with your TenantId
# Replace with your Cert subject
Connect-Graph -ClientId "YOUR_CLIENT_ID" `
              -TenantId "YOUT_TENANT_ID" `
              -CertificateName "YOUR_CERTIFICATE_NAME"

# Switch to beta profile to use these samples.
Select-MgProfile -Name beta

$groups = Get-MgGroup
$teams = $groups | Where-Object { $_.ResourceProvisioningOptions -Contains "Team" }

# List owners and memebers of all Teams team in your tenant.
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
