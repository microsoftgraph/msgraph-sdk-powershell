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

function Initialize-CfsPackageProvider {
    # Pre-seed the NuGet package provider so PowerShellGet uses it directly rather than bootstrapping /
    # resolving a public source on first use, which egresses to www.powershellgallery.com (a CFSClean2
    # violation). Prefer the private feed; otherwise import the provider already bundled on the agent.
    $cred = Get-CfsFeedCredential
    try {
        Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Source $script:CfsFeedUrl -Credential $cred -Scope AllUsers -Force -ErrorAction Stop *> $null
        Write-Host "Pre-seeded NuGet package provider from the private feed."
    }
    catch {
        Import-PackageProvider -Name NuGet -Force -ErrorAction SilentlyContinue *> $null
        Write-Host "Imported the agent's existing NuGet package provider (private-feed seed unavailable)."
    }
    $global:LASTEXITCODE = 0
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

function Unregister-PublicPSGallery {
    # Remove the public PowerShell Gallery. Call this FIRST, before any other PowerShellGet operation,
    # so PSGallery is gone before an enumeration resolves its source location (which egresses to
    # www.powershellgallery.com - a CFSClean2 violation). Unregister-PackageSource removes the source
    # entry without resolving its location; the PSRepository fallback covers the PowerShellGet view.
    Unregister-PackageSource -Name 'PSGallery' -Force -ErrorAction SilentlyContinue *> $null
    if (Get-PSRepository -Name 'PSGallery' -ErrorAction SilentlyContinue) {
        Unregister-PSRepository -Name 'PSGallery' -ErrorAction SilentlyContinue *> $null
    }
    Write-Host "Removed public 'PSGallery'; module installs now resolve only through '$($script:CfsFeedName)'."
    $global:LASTEXITCODE = 0
}

function Install-CfsToolingModules {
    # Pre-installs the generation-time tooling modules from the private feed once, in this controlled
    # credential context, so the lazy Install-Module calls during generation are skipped by their
    # Get-Module -ListAvailable guards. This avoids repeating authenticated private-feed installs across
    # many generation steps and parallel runspaces (where credential/source resolution is fragile).
    $cred = Get-CfsFeedCredential
    $tooling = @(
        @{ Name = 'PlatyPS' },
        @{ Name = 'Pester'; SkipPublisherCheck = $true },
        @{ Name = 'powershell-yaml'; AcceptLicense = $true },
        @{ Name = 'PowerHTML' },
        @{ Name = 'Az.Accounts' }
    )
    foreach ($t in $tooling) {
        if (Get-Module -Name $t.Name -ListAvailable) {
            Write-Host "Tooling module '$($t.Name)' already available; skipping."
            continue
        }
        $params = @{ Name = $t.Name; Repository = $script:CfsFeedName; Scope = 'AllUsers'; Force = $true; AllowClobber = $true }
        if ($null -ne $cred) { $params.Credential = $cred }
        if ($t.SkipPublisherCheck) { $params.SkipPublisherCheck = $true }
        if ($t.AcceptLicense) { $params.AcceptLicense = $true }
        Install-Module @params
        Write-Host "Installed tooling module '$($t.Name)' from '$($script:CfsFeedName)'."
    }
    $global:LASTEXITCODE = 0
}

function Get-CfsModuleGuid {
    # Returns the GUID of the module already published to the private feed, or $null when it is not
    # published there or the GUID cannot be determined (callers then mint a fresh GUID, preserving the
    # original "first publish" behaviour). The Azure Artifacts feed does not surface the GUID via
    # Find-Module's AdditionalMetadata (public PS Gallery does), so this downloads the published package
    # directly over HTTP from the feed's NuGet v2 OData endpoint and reads the GUID from its manifest.
    # Using raw HTTP (not Find-Module/Save-Package) avoids PowerShellGet/PackageManagement source
    # resolution, which is unreliable in the generation runspaces, and never touches public PS Gallery.
    # The module GUID is version-independent (locked), so any published version's manifest is fine.
    param(
        [Parameter(Mandatory)][string] $Name
    )
    if ([string]::IsNullOrWhiteSpace($env:SYSTEM_ACCESSTOKEN)) {
        Write-Host "[CfsGuid] ${Name}: SYSTEM_ACCESSTOKEN is empty in this step - returning null."
        return $null
    }
    Write-Host "[CfsGuid] ${Name}: SYSTEM_ACCESSTOKEN present (len=$($env:SYSTEM_ACCESSTOKEN.Length))."
    $headers = @{ Authorization = 'Basic ' + [Convert]::ToBase64String([System.Text.Encoding]::ASCII.GetBytes("azure:$($env:SYSTEM_ACCESSTOKEN)")) }
    $tmp = Join-Path ([System.IO.Path]::GetTempPath()) ("cfsguid_" + [System.Guid]::NewGuid().ToString('N'))
    try {
        New-Item -ItemType Directory -Path $tmp -Force | Out-Null
        $findUri = "$($script:CfsFeedUrl)/FindPackagesById()?id='$Name'"
        $resp = Invoke-WebRequest -Uri $findUri -Headers $headers -UseBasicParsing -ErrorAction Stop
        [xml]$xml = $resp.Content
        $entry = @($xml.feed.entry) | Where-Object { $_.content.src } | Select-Object -Last 1
        Write-Host "[CfsGuid] ${Name}: OData status=$($resp.StatusCode) version=$($entry.properties.Version)"
        if ($null -eq $entry) { return $null }
        $nupkgPath = Join-Path $tmp "$Name.nupkg"
        Invoke-WebRequest -Uri $entry.content.src -Headers $headers -OutFile $nupkgPath -UseBasicParsing -ErrorAction Stop
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        $zip = [System.IO.Compression.ZipFile]::OpenRead($nupkgPath)
        try {
            $psd1 = $zip.Entries | Where-Object { $_.Name -eq "$Name.psd1" } | Select-Object -First 1
            if ($null -eq $psd1) { return $null }
            $reader = [System.IO.StreamReader]::new($psd1.Open())
            try { $content = $reader.ReadToEnd() } finally { $reader.Dispose() }
        }
        finally { $zip.Dispose() }
        $match = [regex]::Match($content, "(?im)^\s*GUID\s*=\s*['`"]([0-9a-fA-F-]{36})['`"]")
        Write-Host "[CfsGuid] ${Name}: GUID match=$($match.Success) value=$($match.Groups[1].Value)"
        if ($match.Success) { return $match.Groups[1].Value }
        return $null
    }
    catch { Write-Host "[CfsGuid] $Name FAILED: $($_.Exception.Message)"; return $null }
    finally {
        Remove-Item -Path $tmp -Recurse -Force -ErrorAction SilentlyContinue
    }
}
