# Microsoft Graph PowerShell V2 Changelog and Upgrade Guide

The purpose of this document is to outline any breaking change and migration work the module users might run into while upgrading to v2 of the module.

## Overview

The v1 version of the PowerShell SDK uses profiles to switch from commands targeting different versions of the Microsoft Graph API. The profile design made the module bulky and error prone as it combined Microsoft Graph v1.0 and beta commands into a single module.

The v1 version used Microsoft Graph Auth Providers under the hood to acquire and cache access tokens. This limited us to just a handful of support auth grant types.

## Breaking changes

The following section lists our breaking changes requiring script changed from module users

### Profile Support

The new version drops profile support. Previously, customers needed to use `Select-MgProfile beta` to load `beta` commands and `Select-MgProfile v1.0` to load `v1.0` commands. The new version replaces profile support by the following changes to:

- Module Names

  Each module will be divided into independent `v1.0` and `beta` modules. `v1.0` modules will retain the names of existing modules. `beta` modules have `Beta` in the module name:
  | V1.0 | Beta |
  | - | - |
  | Microsoft.Graph | Microsoft.Graph.Beta |
  | Microsoft.Graph.Users | Microsoft.Graph.Beta.Users |

- Command Names

  `v1.0` commands will maintain the current Verb-Subject command names with `Mg` as the command prefix. `beta` commands will maintain the current Verb-Subject command names, with `MgBeta` as the prefix.
  | V1.0 | Beta |
  | - | - |
  | Get-MgUser | Get-MgBetaUser |

With this change customers targeting `beta` endpoint will no longer need to use `Select-MgProfile beta` to load `beta`, but will directly use `beta` commands. This will also allow for mixing on v1.0 and beta commands in the same script without needing to reload the entire module.

Before

```PowerShell
Connect-MgGraph
Select-MgProfile beta
$Users = Get-MgUser
```

With V2

```PowerShell
Connect-MgGraph
$Users = Get-MgBetaUser
```

### Beta Namespace

Model types in `beta` have moved from `Microsoft.Graph.PowerShell.Models.<Entity>` to `Microsoft.Graph.Beta.PowerShell.Models.<Entity>`. This was done to disambiguate `beta` types from `v1.0` types.

### Connect-MgGraph -AccessToken

With v2, we've changed type for `-AccessToken` from `String` to `SecureString.`This change was added to harden the module from security vulnerabilities.

### Connect-MgGraph -ForceRefresh

With v2, we've dropped support for `-ForceRefresh` on `Connect-MgGraph` command. `-ForceRefresh` is no longer support by out auth token credentials classes. Customers should use `Disconnect-MgGraph`to sign out of current context then call `Connect-MgGraph` to get a new access token.

## New Features and Improvements

The following new features are available as part on the v2 module.

### Authentication

1. Managed Identity support

   **Proposed Usage**

   - System-assigned managed identity

     Uses an automatically managed identity on a service instance. The identity is tied to the lifecycle of a service instance.

     ```PowerShell
     Connect-MgGraph -Identity
     ```

   - User-assigned managed identity

     Uses a user created managed identity as a standalone Azure resource.

     ```PowerShell
     Connect-MgGraph -Identity -ClientId "User_Assigned_Managed_identity_Client_Id"
     ```

2. Client Secret Credentials
   The new module adds support for client secret credentials by adding `-Credential` parameter to `Connect-MgGraph`.

   **Proposed Usage**

   ```PowerShell
   $ClientCredential = Get-Credential -Username "Client_Id"
   # Enter client_secret in the password prompt.
   Connect-MgGraph -TenantId "Tenant_Id" -Credential $ClientCredential
   ```

3. Certificate Credentials
   In v2, we've added support for certificate lookup in both current user and local machine certificate store. Priority will be given certificates in `CurrentUser` store if two identical certificates are present in both stores.

   **Proposed Usage**

   ```PowerShell
   Connect-MgGraph -ClientId "Client_Id" -Tenant "Tenant" -CertificateThumbprint "Cert_Thumbprint"
   ```

4. Environment Variable Based Auth Support
   In v2, we've added `-EnvironmentVariable` to `Connect-MgGraph` to support environment variable based auth. Client secret takes precedence over certificate. If values for a client secret and certificate are both present, the client secret will be used. See [Azure.Identity Environment Variables](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity#environment-variables) for more details.

   **Proposed Usage**

   ```PowerShell
   # Add environment variables to be used by Connect-MgGraph.
   $Env:AZURE_CLIENT_ID = "application id of the client app"
   $Env:AZURE_TENANT_ID = "Id of your tenant"
   $Env:AZURE_CLIENT_SECRET = "secret of the client app"

   # Tell Connect-MgGraph to use your environment variables.
   Connect-MgGraph -EnvironmentVariable
   ```

### Service Modules

1. HTTP/2 support

   V2 module adds [HTTP/2](https://httpwg.org/specs/rfc7540.html) support for supported API endpoints. The module will gracefully fallback to HTTP/1.1 when HTTP/2 is not supported by the API. HTTP/2 improves performance by adding support for: - Multiplexing - Header compression - Server push

2. Success status code range support
   With success status code range support. v2 commands will correctly handle and return back the right output is the HTTP request responds back with a success code (2xx). The old implementation only succeeded when the response status code exactly matched what was specified in the API schema.
