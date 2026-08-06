# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.SYNOPSIS
    Pre-populates the autorest extension cache so that autorest makes zero npm
    network calls during module generation.

.DESCRIPTION
    Autorest resolves extensions from ~/.autorest/<pkg>/<version>/node_modules/.
    This script pre-installs every extension referenced by
    autorest-configuration.md into that cache layout.
    Registry and auth are read from ~/.npmrc (copied from the authenticated
    .npmrc earlier in the pipeline).
#>

[CmdletBinding()]
param()

$extensions = @(
    "@autorest/core@3.10.4",
    "@autorest/modelerfour@4.24.3"
)

# Force these installs onto the authenticated private feed. `npm install --prefix <dir>` does not
# reliably pick up the registry/auth from ~/.npmrc (it was observed hitting registry.npmjs.org
# directly, breaking CFSClean network isolation), so pass --userconfig and --registry explicitly,
# derived from the authenticated ~/.npmrc that install-tools.yml produced.
$npmFeedArgs = @()
$userNpmrc = Join-Path $env:USERPROFILE ".npmrc"
if (Test-Path $userNpmrc) {
    $npmFeedArgs += @('--userconfig', $userNpmrc)
    $regLine = Select-String -Path $userNpmrc -Pattern '^registry=' | Select-Object -First 1
    if ($regLine) { $npmFeedArgs += @('--registry', ($regLine.Line -replace '^registry=', '').Trim()) }
}
else {
    Write-Host "WARNING: ~/.npmrc not found; npm install may reach the public registry (CFSClean risk)."
}

foreach ($ext in $extensions) {
    $parts   = $ext -split '@(?=[^@]+$)'   # split on last @
    $pkg     = $parts[0]
    $ver     = $parts[1]
    $cacheDir = Join-Path $env:USERPROFILE ".autorest\$($pkg.Replace('/','\'))\$ver"
    $nodeModules = Join-Path $cacheDir "node_modules\$($pkg.Replace('/','\'))"

    if (Test-Path $nodeModules) {
        Write-Host "Cache already present: $ext"
        continue
    }

    New-Item -ItemType Directory -Force -Path $cacheDir | Out-Null
    Write-Host "Pre-installing $ext into $cacheDir"
    npm install $ext --prefix $cacheDir @npmFeedArgs
    if ($LASTEXITCODE -ne 0) { throw "Failed to pre-install $ext (exit $LASTEXITCODE)" }
    Write-Host "Done: $ext"
}

