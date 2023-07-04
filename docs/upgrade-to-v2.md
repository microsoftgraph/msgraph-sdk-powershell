# Microsoft Graph PowerShell V2 Changelog and Upgrade Guide

The purpose of this document is to outline breaking changes and migration work module users might run into while upgrading to v2 of the module.

## Overview

The old v1 version of the PowerShell module used profiles (`Select-MgProfile <API-VERSION>`) to switch the commands from one version of Microsoft Graph API to another. The profile design made the module bulky and error prone as it combined Microsoft Graph v1.0 and beta commands into a single module.

The v1 version relied on the now deprecated Microsoft Graph Auth providers to acquire and cache access tokens. This limited us to just a handful of auth grant types that we could support.

## Breaking changes

The following section lists breaking changes that may require script changes for users of the module.

### Profile Support

Previously, customers needed to use `Select-MgProfile beta` to load `beta` commands and `Select-MgProfile v1.0` to load `v1.0` commands. The new version drops profile support by having separate v1.0 and beta modules. v2 replaces profile support with the following changes:

#### Module Names

Each module will be divided into independent `v1.0` and `beta` modules. `v1.0` modules will retain the names of existing modules. `beta` modules will have `Beta` in the module name, e.g.
| V1.0 | Beta |
| - | - |
| Microsoft.Graph | Microsoft.Graph.Beta |
| Microsoft.Graph.Users | Microsoft.Graph.Beta.Users |

#### Command Names

`v1.0` commands will maintain the current `Verb-Subject` syntax with `Mg` as the command prefix. `beta` commands will maintain the current `Verb-Subject` syntax, with `MgBeta` as the prefix, e.g.
| V1.0 | Beta |
| - | - |
| Get-MgUser | Get-MgBetaUser |
| Get-MgUserMessage | Get-MgBetaUserMessage |

With this change, customers targeting `beta` endpoint will no longer need to use `Select-MgProfile beta` to load `beta` commands as beta commands will exist side-by-side with `v1.0` commands. This will also allow for mixing on v1.0 and beta commands in the same script without needing to reload the entire module.

##### With v1

```PowerShell
Connect-MgGraph
Select-MgProfile beta
$BetaUsers = Get-MgUser
Select-MgProfile v1.0
$V1Users = Get-MgUser
```

##### With V2

```PowerShell
Connect-MgGraph
$BetaUsers = Get-MgBetaUser
$V1Users = Get-MgUser
```

### Beta Namespace

Entity types in `beta` have moved from `Microsoft.Graph.PowerShell.Models.<Entity>` to `Microsoft.Graph.Beta.PowerShell.Models.<Entity>` namespace. This was done to disambiguate `beta` types from `v1.0` types.

### Connect-MgGraph -AccessToken

In v2, we've changed `-AccessToken` from `String` to `SecureString` type. This change was added to harden the module from security vulnerabilities.

### Connect-MgGraph -ForceRefresh

We've dropped support for `-ForceRefresh` on `Connect-MgGraph` command. `-ForceRefresh` is no longer support by the auth token credentials used in v2. Customers should instead use `Disconnect-MgGraph` to sign out of current context then call `Connect-MgGraph` to get a new access token.

### Renamed `DeviceManagement.Enrolment` module to `DeviceManagement.Enrollment`

`DeviceManagement.Enrolment` module has been renamed to `DeviceManagement.Enrollment` to align with the API.

### Directory Role and Entitlement Management Commands

Directory role and entitlement management commands that were in `DeviceManagement.Enrollment` module have been moved to `Identity.Governance` to align with the [API reference](https://learn.microsoft.com/graph/api/resources/directoryrole?view=graph-rest-1.0).

## New Features and Improvements

The following new features and improvements have been added to the module in v2.

### Authentication

#### Managed Identity

The new module adds support for Managed Identity. Managed Identity allows the module to obtain access tokens for Azure resources that are protected by Azure Active Directory. The identity is managed by the Azure platform and does not require you to provision or rotate any secrets. See [Managed identities fro Azure resources](https://learn.microsoft.com/azure/active-directory/managed-identities-azure-resources/overview) for more details.

##### System-assigned managed identity

Uses an automatically managed identity on a service instance. The identity is tied to the lifecycle of a service instance.

```PowerShell
Connect-MgGraph -Identity
```

##### User-assigned managed identity

Uses a user created managed identity as a standalone Azure resource.

```PowerShell
Connect-MgGraph -Identity -ClientId "User_Assigned_Managed_identity_Client_Id"
```

#### Client Secret Credentials

The new module adds support for client secret credentials by adding `-Credential` parameter to `Connect-MgGraph`.

```PowerShell
$ClientSecretCredential = Get-Credential -Username "Client_Id"
# Enter client_secret in the password prompt.
Connect-MgGraph -TenantId "Tenant_Id" -ClientSecretCredential $ClientSecretCredential
```

#### Certificate Credentials

In v2, we've added support for certificate lookup in both current user and local machine certificate store. Priority will be given certificates in `CurrentUser` store if two identical certificates are present in both stores.

```PowerShell
Connect-MgGraph -ClientId "Client_Id" -Tenant "Tenant" -CertificateThumbprint "Cert_Thumbprint"
```

#### Environment Variable Based Auth

We've added `-EnvironmentVariable` to `Connect-MgGraph` to support environment variable based auth. Client secret takes precedence over certificate, i.e., if values for a client secret and certificate are both present, the client secret will be used. See [Azure.Identity Environment Variables](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity#environment-variables) for more details.

```PowerShell
# Add environment variables to be used by Connect-MgGraph.
$Env:AZURE_CLIENT_ID = "application id of the client app"
$Env:AZURE_TENANT_ID = "Id of your tenant"
$Env:AZURE_CLIENT_SECRET = "secret of the client app"

# Tell Connect-MgGraph to use your environment variables.
Connect-MgGraph -EnvironmentVariable
```

### Service Modules

#### Count Commands (`/$count`)

We've added dedicated count commands in v2 for supported resources. In v2, you can now get a [count of users in your tenant](https://learn.microsoft.com/graph/api/user-list?view=graph-rest-1.0&tabs=http#example-3-get-only-a-count-of-users) using:

``` powershell
$UsersCount = Get-MgUserCount -ConsistencyLevel Eventual
```

See [advanced query capabilities on Azure AD objects](https://learn.microsoft.com/graph/aad-advanced-queries) for more details.

#### OData Cast Support

V2 adds OData cast commands via `*-Mg*As<CAST-Type>` syntax when supported by the API. With OData cast support, customers can now access properties on specialized types rather than going through AdditionalProperties for supported APIs. For example, one can use `Get-MgGroupMemberAsUser` to [list group members that are users](https://learn.microsoft.com/graph/api/group-list-members?view=graph-rest-1.0&tabs=http):

```powershell
$Users = Get-MgGroupMemberAsUser -GroupId "GROUP_ID"
```

> In the example above, the cast type can also be `ServicePrincipal`, `Application`, `Device`, `Group`, and more as supported by the API.

#### Improved Service Error Reporting

We've updated how service errors are written to the error stream to help with debugging API related errors. In v2, when a service error occurs, the SDK will now write message, HTTP status code, error code, request-id, date, and other useful headers to the error stream.

![image](https://github.com/microsoftgraph/msgraph-sdk-powershell/assets/7061532/45ab9783-12ee-4666-b6ee-c29bfbff6827)

See [Microsoft Graph API error response](https://learn.microsoft.com/graph/errors) for more details.

#### HTTP/2 support

V2 adds [HTTP/2](https://httpwg.org/specs/rfc7540.html) support for supported API endpoints. The module will gracefully fallback to HTTP/1.1 when HTTP/2 is not supported by the API. HTTP/2 improves performance by adding support for; multiplexing, header compression, and server push.

#### Success status code range support

With success status code range support. v2 commands will correctly handle and return the right output when an HTTP request responds back with a successful code (2xx). The old implementation only succeeded when the response status code exactly matched what was specified in the API schema.
