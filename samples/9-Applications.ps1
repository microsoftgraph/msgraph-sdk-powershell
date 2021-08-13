# Incremental scope consent.
Connect-Graph -Scopes "Application.ReadWrite.All"

# Create an application for use with DeviceCodeFlow
$app1 = New-MgApplication   -displayName "DeviceCodeFlowApp" `
                            -IsFallbackPublicClient `
                            -PublicClient @{ `
                                RedirectUris = "https://login.microsoftonline.com/common/oauth2/nativeclient" `
                            }

# Create an application for use with Native Client an interactive sign in
$app2 = New-MgApplication   -displayName "NativeAppInteractiveFlowApp" `
                            -IsFallbackPublicClient `
                            -PublicClient @{ `
                                RedirectUris = "http://localhost" `
                            }

# Create an web app with implicit auth
$app3 = New-MgApplication -displayName "ImplicitWebApp" `
         -Web @{ `
            RedirectUris = "https://localhost:3000/"; `
            ImplicitGrantSettings = @{ `
                EnableAccessTokenIssuance = $true; `
                EnableIdTokenIssuance = $true; `
             } `
        }  

# Create an registration for an ASP.NET Web App
$scopeId_UserRead = Find-MgGraphPermission User.Read -ExactMatch -PermissionType Delegated | Select-Object -ExpandProperty Id
$app = New-MgApplication -displayName "AspNetWebApp" `
           -Web @{ 
              RedirectUris = "https://localhost:5001/signin-oidc"; `
              ImplicitGrantSettings = @{ 
                  EnableIdTokenIssuance = $true
               } 
             }`
             -RequiredResourceAccess @{ ResourceAppId = "00000003-0000-0000-c000-000000000000"
                                        ResourceAccess = @(
                                                @{ 
                                                    Id = $scopeId_UserRead
                                                    Type = "Scope"
                                                 }
                                                 )
                                            } 

## Create a registration for an ASP.NET Web App that call the Graph
$web = @{
    RedirectUris = @("https://localhost:5001/signin-oidc", "https://localhost:5001/" )
    LogoutUrl = "https://localhost:5001/signout-oidc"
    ImplicitGrantSettings = @{ EnableIdTokenIssuance = $true }
}

$createAppParams = @{
    DisplayName = "AspNetWebApp6"
    Web = $web
    RequiredResourceAccess = @{
        ResourceAppId = "00000003-0000-0000-c000-000000000000"
        ResourceAccess = @(
            @{
                Id = $scopeId_UserRead
                Type = "Scope"
            }
        )
    }
}
# note the use of @ below, instead of the expected $
$app = New-MgApplication @createAppParams

$secret = Add-MgApplicationPassword -applicationId $app.Id


# Create an application for use with Confidential Client flow using a certificate.
# Get certificate from current user store.
$CertificateThumbprint = "YOUR_THUMBPRINT"
$Certificate = Get-ChildItem -Path "Cert:\CurrentUser\My\$CertificateThumbprint"

# Graph resource Id
$GraphResourceId = "00000003-0000-0000-c000-000000000000"

# Show friendly Graph permission names given their unique identifiers
Find-MgGraphPermission | Where-Object Id -in @(
    'df021288-bdef-4463-88db-98f22de89214'
    '5b567255-7703-4780-807c-7be8301ae99b'
    '40f97065-369a-49f4-947c-6a255697ae91'
    'b633e1c5-b582-4048-a93e-9f11b44c7e96'
)

# Create an application registration.
$requiredPermissions = 'Group.Read.All', 'Mail.Send', 'MailboxSettings.Read', 'User.Read.All' |
  Find-MgGraphPermission -ExactMatch -PermissionType Application

$resourceAccess = foreach ( $permission in $requiredPermissions ) {
    @{ Id = $permission.Id; Type = 'Role' }
}

$AppName = "ScriptedGraphPSApp"
$app4 = New-MgApplication -"ClientCredentialApp" $AppName `
                    -SignInAudience "AzureADMyOrg" `
                    -RequiredResourceAccess @{ ResourceAppId = $graphResourceId; ResourceAccess = $resourceAccess } `
                    -KeyCredentials @(@{ Type = "AsymmetricX509Cert"; Usage = "Verify"; Key= $Certificate.RawData })

# Create corresponding service principal.
New-MgServicePrincipal -AppId $app4.AppId

# Show permissions assigned to the application in the organization
# using friendly permission names instead of just the unique identifiers
$servicePrincipal4 = Get-MgServicePrincipal -Filter "appId eq '$($app4.AppId)'"
Get-MgServicePrincipalAppRoleAssignment -ServicePrincipalId $servicePrincipal4.id |
  Select-Object appRoleId |
  Find-MgGraphPermission


