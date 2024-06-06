# Microsoft Graph PowerShell SDK: Access Token Proof of Possession (AT PoP) Capability

## SYNOPSIS

This README provides comprehensive details on the Access Token Proof of Possession (AT PoP) functionality introduced in the Microsoft Graph PowerShell SDK. This feature enhances security by binding tokens to specific HTTP methods and URIs, ensuring they are used only for their intended purposes.

## KEY FEATURES

- **Access Token Proof of Possession (AT PoP)**: This feature binds tokens to specific HTTP methods and URIs, preventing misuse of tokens by ensuring they are used only for the intended HTTP requests.
- **Updated Dependencies**: Compatibility improvements with recent library changes.
- **Enhanced Token Acquisition Options**: Users can now specify the HTTP method and URI during token acquisition to further secure token usage.

### TOKEN ACQUISITION BEHAVIORS

| Condition | Unbound (default) | Bound (PoP) |
|-----------|-----------|-----------|
| First sign-in | New token, interactive| New token, interactive |
| Existing token, same URI | No new token, silent | No new token, silent |
| Existing token, different URI | No new token, silent | New token, silent |
| Existing expired token, below max token refreshes | New token, silent | New token, silent |
| Existing expired token, exceeded max refreshes | New token, interactive | New token, interactive |

## INSTALLATION

To install the Microsoft Graph PowerShell SDK with the latest updates, use the following command:

```powershell
Install-Module -Name Microsoft.Graph -AllowClobber -Force
```

Ensure you are using the latest version to access the AT PoP functionality.

## CONFIGURATION

### Enabling Access Token Proof of Possession

To enable AT PoP, configure the Microsoft Graph SDK options as follows:

```powershell
Set-MgGraphOption -EnableATPoP $true

Connect-MgGraph
```

This configuration ensures that the acquired token is only valid for the specified HTTP method and URI.

## EXAMPLES

### Example 1:

```powershell
Set-MgGraphOption -EnableATPoP $true

Connect-MgGraph

Invoke-MgGraphRequest -Method GET https://graph.microsoft.com/v1.0/me -Debug
```

### Example 2:

```powershell
Set-MgGraphOption -EnableATPoP $true

Connect-MgGraph

Invoke-MgGraphRequest -Uri "https://graph.microsoft.com/v1.0/me/sendMail" -Method POST -Debug
```

## REFERENCES

This README provides a detailed guide on the new AT PoP functionality, offering users the ability to secure their token usage effectively. If you have any questions or need further assistance, please refer to the official [Microsoft Graph PowerShell SDK documentation](https://docs.microsoft.com/en-us/powershell/microsoftgraph/).
