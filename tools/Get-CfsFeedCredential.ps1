# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.SYNOPSIS
    Shared helpers to route PowerShell module installs/queries through the private Azure Artifacts
    feed (CFSClean network isolation) instead of the public PowerShell Gallery.

.DESCRIPTION
    The private feed `PowerShell_V2_Build` has a PowerShell Gallery upstream, so it can serve both
    the internally published Graph modules and public tooling modules (Pester, PlatyPS,
    powershell-yaml, PowerHTML). Reads the credential from the process-wide $env:SYSTEM_ACCESSTOKEN
    (mapped from $(System.AccessToken) at the pipeline `variables:` level), so it works inside
    ForEach-Object -Parallel runspaces where session state is not inherited.
#>

$script:CfsFeedName = 'PowerShell_V2_Build'
$script:CfsFeedUrl  = 'https://microsoftgraph.pkgs.visualstudio.com/0985d294-5762-4bc2-a565-161ef349ca3e/_packaging/PowerShell_V2_Build/nuget/v2'

function Get-CfsFeedName {
    return $script:CfsFeedName
}

function Get-CfsFeedCredential {
    # Returns a PSCredential built from the build identity's access token, or $null when the token is
    # unavailable (e.g. local dev), in which case callers fall back to their default behaviour.
    if ([string]::IsNullOrWhiteSpace($env:SYSTEM_ACCESSTOKEN)) {
        return $null
    }
    $token = ConvertTo-SecureString $env:SYSTEM_ACCESSTOKEN -AsPlainText -Force
    return [System.Management.Automation.PSCredential]::new('azure', $token)
}

function Register-CfsFeed {
    # Registers the private feed as a Trusted PSRepository (idempotent). Persisted under the user's
    # PowerShellGet config, so a single registration per job is visible to later steps and runspaces.
    $cred = Get-CfsFeedCredential
    if (Get-PSRepository -Name $script:CfsFeedName -ErrorAction SilentlyContinue) {
        return
    }
    try {
        Register-PSRepository -Name $script:CfsFeedName -SourceLocation $script:CfsFeedUrl -InstallationPolicy Trusted -Credential $cred -ErrorAction Stop
    }
    catch {
        # A package source with this name may already exist at the PackageManagement layer (e.g. a
        # NuGet source, or a registration from an earlier step/runspace) that Get-PSRepository does
        # not surface. If a usable PSRepository now exists, the registration effectively succeeded, so
        # swallow the "already added" collision; otherwise rethrow the real failure.
        if (Get-PSRepository -Name $script:CfsFeedName -ErrorAction SilentlyContinue) {
            Write-Host "PSRepository '$($script:CfsFeedName)' is already registered; continuing."
            return
        }
        throw
    }
}
