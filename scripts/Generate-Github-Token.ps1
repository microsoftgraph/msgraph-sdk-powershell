# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

# Generates a short-lived GitHub App installation access token for the specified repository.
#
# The token is minted by:
#   1. Building an RS256-signed JWT from the App's client id and private key.
#   2. Resolving the App installation id for the owner (org, then repo, then user scope).
#   3. Exchanging the JWT for a repository-scoped installation access token.
#
# The resulting token is valid for ~1 hour and should be generated immediately before it is
# used (e.g. right before a git push or PR creation). Emitted on the pipeline via Write-Output.

[CmdletBinding()]
param (
    [Parameter(Mandatory = $true)]
    [string]
    $AppClientId,
    [Parameter(Mandatory = $true)]
    [string]
    $AppPrivateKeyContents,
    [Parameter(Mandatory = $true)]
    [ValidatePattern('^[a-zA-Z0-9_.-]+/[a-zA-Z0-9_.-]+$', ErrorMessage = "Repository must be in the format 'owner/repo' (e.g. 'octocat/hello-world')")]
    [string]
    $Repository
)

$ErrorActionPreference = "Stop"

function Generate-AppToken {
    param (
        [string]
        $ClientId,
        [string]
        $PrivateKeyContents
    )

    $header = [Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes((ConvertTo-Json -InputObject @{
                    alg = "RS256"
                    typ = "JWT"
                }))).TrimEnd('=').Replace('+', '-').Replace('/', '_');

    $payload = [Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes((ConvertTo-Json -InputObject @{
                    iat = [System.DateTimeOffset]::UtcNow.AddSeconds(-10).ToUnixTimeSeconds()
                    exp = [System.DateTimeOffset]::UtcNow.AddMinutes(1).ToUnixTimeSeconds()
                    iss = $ClientId
                }))).TrimEnd('=').Replace('+', '-').Replace('/', '_');

    $rsa = [System.Security.Cryptography.RSA]::Create()
    $rsa.ImportFromPem($PrivateKeyContents)

    $signature = [Convert]::ToBase64String($rsa.SignData([System.Text.Encoding]::UTF8.GetBytes("$header.$payload"), [System.Security.Cryptography.HashAlgorithmName]::SHA256, [System.Security.Cryptography.RSASignaturePadding]::Pkcs1)).TrimEnd('=').Replace('+', '-').Replace('/', '_')
    $jwt = "$header.$payload.$signature"

    return $jwt
}

function Generate-InstallationToken {
    param (
        [string]
        $AppToken,
        [string]
        $InstallationId,
        [string]
        $Repository
    )

    $uri = "https://api.github.com/app/installations/$InstallationId/access_tokens"
    $headers = @{
        Authorization          = "Bearer $AppToken"
        Accept                 = "application/vnd.github+json"
        "X-GitHub-Api-Version" = "2022-11-28"
    }

    $body = @{
        repositories = @($Repository)
    }

    $response = Invoke-RestMethod -Uri $uri -Method Post -Headers $headers -Body (ConvertTo-Json -InputObject $body -Compress -Depth 10)

    return $response.token
}

function Get-OrganizationInstallationId {
    param (
        [string]
        $AppToken,
        [string]
        $Organization
    )

    $uri = "https://api.github.com/orgs/$Organization/installation"
    $headers = @{
        Authorization          = "Bearer $AppToken"
        Accept                 = "application/vnd.github+json"
        "X-GitHub-Api-Version" = "2022-11-28"
    }

    try {
        $response = Invoke-RestMethod -Uri $uri -Method Get -Headers $headers

        return $response.id
    }
    catch [Microsoft.PowerShell.Commands.HttpResponseException] {
        if ($_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::UnprocessableContent -or $_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::NotFound) {
            return $null
        }

        throw
    }
}

function Get-RepositoryInstallationId {
    param (
        [string]
        $AppToken,
        [string]
        $Repository
    )

    $uri = "https://api.github.com/repos/$Repository/installation"
    $headers = @{
        Authorization          = "Bearer $AppToken"
        Accept                 = "application/vnd.github+json"
        "X-GitHub-Api-Version" = "2022-11-28"
    }

    try {
        $response = Invoke-RestMethod -Uri $uri -Method Get -Headers $headers

        return $response.id
    }
    catch [Microsoft.PowerShell.Commands.HttpResponseException] {
        if ($_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::UnprocessableContent -or $_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::NotFound) {
            return $null
        }

        throw
    }
}

function Get-UserInstallationId {
    param (
        [string]
        $AppToken,
        [string]
        $Username
    )

    $uri = "https://api.github.com/users/$Username/installation"
    $headers = @{
        Authorization          = "Bearer $AppToken"
        Accept                 = "application/vnd.github+json"
        "X-GitHub-Api-Version" = "2022-11-28"
    }

    try {
        $response = Invoke-RestMethod -Uri $uri -Method Get -Headers $headers

        return $response.id
    }
    catch [Microsoft.PowerShell.Commands.HttpResponseException] {
        if ($_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::UnprocessableContent -or $_.Exception.Response.StatusCode -eq [System.Net.HttpStatusCode]::NotFound) {
            return $null
        }

        throw
    }
}

function Get-InstallationId {
    param (
        [string]
        $AppToken,
        [string]
        $Owner,
        [string]
        $Repo
    )

    $orgInstallationId = Get-OrganizationInstallationId -AppToken $AppToken -Organization $Owner

    if ($null -eq $orgInstallationId) {
        $repoInstallationId = Get-RepositoryInstallationId -AppToken $AppToken -Repository "$Owner/$Repo"
    }
    else {
        return $orgInstallationId
    }

    if ($null -eq $repoInstallationId) {
        $userInstallationId = Get-UserInstallationId -AppToken $AppToken -Username $Owner
    }
    else {
        return $repoInstallationId
    }

    if ($null -eq $userInstallationId) {
        throw "Installation not found for repository '$Repo'"
    }
    else {
        return $userInstallationId
    }
}

$owner, $repo = $Repository -split '/'

$AppToken = Generate-AppToken -ClientId $AppClientId -PrivateKeyContents $AppPrivateKeyContents

$InstallationId = Get-InstallationId -AppToken $AppToken -Owner $owner -Repo $repo

$InstallationToken = Generate-InstallationToken -AppToken $AppToken -InstallationId $InstallationId -Repository $repo

Write-Output $InstallationToken
