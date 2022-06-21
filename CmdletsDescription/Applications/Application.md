## Applications

1. Create a new app registration.

    ``` powershell
    New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                      -SignInAudience "AzureADMyOrg" `
                      -Web @{ RedirectUris = "https://localhost"}
    ```