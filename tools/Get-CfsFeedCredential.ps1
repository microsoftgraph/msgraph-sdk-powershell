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
    # Get-PSRepository can lazily return nothing in a fresh session even when the source is already
    # persisted (registered by an earlier step/runspace). Get-PackageSource surfaces that collision,
    # so check both before attempting to register.
    if ((Get-PSRepository -Name $script:CfsFeedName -ErrorAction SilentlyContinue) -or
        (Get-PackageSource -Name $script:CfsFeedName -ErrorAction SilentlyContinue)) {
        Write-Host "Package source '$($script:CfsFeedName)' is already registered; skipping."
        return
    }
    # The "already added" collision is a non-terminating error emitted by an internal PackageManagement
    # cmdlet that bypasses -ErrorAction Stop (and would otherwise fail the task under its default Stop
    # preference), so redirect every stream to null and verify the outcome instead of trusting the call.
    Register-PSRepository -Name $script:CfsFeedName -SourceLocation $script:CfsFeedUrl -InstallationPolicy Trusted -Credential $cred -ErrorAction SilentlyContinue *> $null
    if (-not (Get-PSRepository -Name $script:CfsFeedName -ErrorAction SilentlyContinue)) {
        throw "Failed to register PSRepository '$($script:CfsFeedName)'."
    }
    Write-Host "Registered PSRepository '$($script:CfsFeedName)'."
}

function Get-CfsModuleGuid {
    # Returns the GUID of the module already published to the private feed, or $null when it is not
    # published there or the GUID cannot be determined. The Azure Artifacts feed does not surface the
    # module GUID via Find-Module's AdditionalMetadata (public PS Gallery does), so download the
    # package (nupkg) from the feed and read the GUID out of its manifest. Callers mint a fresh GUID
    # when this returns $null, preserving the original "first publish" behaviour without ever querying
    # the public PowerShell Gallery.
    param(
        [Parameter(Mandatory)][string] $Name
    )
    $cred = Get-CfsFeedCredential
    $found = Find-Module -Name $Name -Repository $script:CfsFeedName -Credential $cred -ErrorAction SilentlyContinue
    if ($null -eq $found) { return $null }
    $tmp = Join-Path ([System.IO.Path]::GetTempPath()) ("cfsguid_" + [System.Guid]::NewGuid().ToString('N'))
    try {
        New-Item -ItemType Directory -Path $tmp -Force | Out-Null
        # Save-Package (NuGet provider) downloads just this package's nupkg (no dependency resolution),
        # so it stays cheap even for meta-modules that depend on many sub-modules.
        Save-Package -Name $Name -RequiredVersion $found.Version -Source $script:CfsFeedUrl -ProviderName NuGet -Credential $cred -Path $tmp -Force -ErrorAction Stop *> $null
        $nupkg = Get-ChildItem -Path $tmp -Filter '*.nupkg' -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1
        if ($null -eq $nupkg) { return $null }
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        $zip = [System.IO.Compression.ZipFile]::OpenRead($nupkg.FullName)
        try {
            $entry = $zip.Entries | Where-Object { $_.Name -eq "$Name.psd1" } | Select-Object -First 1
            if ($null -eq $entry) { return $null }
            $reader = [System.IO.StreamReader]::new($entry.Open())
            try { $content = $reader.ReadToEnd() } finally { $reader.Dispose() }
        }
        finally { $zip.Dispose() }
        $match = [regex]::Match($content, "(?im)^\s*GUID\s*=\s*['`"]([0-9a-fA-F-]{36})['`"]")
        if ($match.Success) { return $match.Groups[1].Value }
        return $null
    }
    catch { return $null }
    finally {
        Remove-Item -Path $tmp -Recurse -Force -ErrorAction SilentlyContinue
        # PackageManagement/NuGet can leave a stray non-zero $LASTEXITCODE from an internal native call;
        # this helper is a side-effect-free read, so do not let that leak into the caller's exit code.
        $global:LASTEXITCODE = 0
    }
}
