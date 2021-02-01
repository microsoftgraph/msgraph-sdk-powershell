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
                                                    Id = "e1fe6dd8-ba31-4d61-89e7-88639da4683d"
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
                Id = "e1fe6dd8-ba31-4d61-89e7-88639da4683d"
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

# Graph permissions constants
$UserReadAll = @{ Id = "df021288-bdef-4463-88db-98f22de89214"; Type = "Role" }
$GroupReadAll = @{ Id = "5b567255-7703-4780-807c-7be8301ae99b"; Type = "Role" }
$MailboxSettingsRead = @{ Id = "40f97065-369a-49f4-947c-6a255697ae91"; Type = "Role" }
$MailSend = @{ Id = "b633e1c5-b582-4048-a93e-9f11b44c7e96"; Type = "Role" }

# Create an application registration.
$AppName = "ScriptedGraphPSApp"
$app4 = New-MgApplication -"ClientCredentialApp" $AppName `
                    -SignInAudience "AzureADMyOrg" `
                    -RequiredResourceAccess @{ ResourceAppId = $graphResourceId; ResourceAccess = $UserReadAll, $GroupReadAll, $MailboxSettingsRead, $MailSend } `
                    -KeyCredentials @(@{ Type = "AsymmetricX509Cert"; Usage = "Verify"; Key= $Certificate.RawData })

# Create corresponding service principal.
New-MgServicePrincipal -AppId $app4.AppId
