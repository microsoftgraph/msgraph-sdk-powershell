$permissions = Get-Content ~/datasample.json | Out-String | ConvertFrom-Json
function GetOauthData {
    
    $msOauth = $permissions.oauth2PermissionScopes
    
    ForEach ($oauth2grant in $msOauth) {

        $description = $null

        $description = If ($oauth2grant.type -eq "Admin") { 
        
            $description = $oauth2grant.adminConsentDescription
        
        } elseif ($oauth2grant.type -eq "User") {
        
            $description = $oauth2grant.userConsentDescription
        
        }
        
        $entry = [ordered] @{
            
            "Id" = $oauth2grant.id
            "PermissionType" = $oauth2grant.type
            "Name" = $oauth2grant.value
            "Description" = $description
        
        }

        [PSCustomObject] $entry

    }
}